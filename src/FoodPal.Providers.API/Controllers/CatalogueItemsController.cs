using AutoMapper;
using FoodPal.Providers.Dtos;
using FoodPal.Providers.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace FoodPal.Providers.API.Controllers
{
    [Route("api/providers/{providerId}/menu")]
    [ApiController]
    public class CatalogueItemsController : ControllerBase
    {
        private readonly ICatalogueItemService _catalogueItemService;
        private readonly IProviderService _providerService;
        private readonly IMapper _mapper;

        public CatalogueItemsController(ICatalogueItemService catalogueItemService, IProviderService providerService, IMapper mapper)
        {
            _catalogueItemService = catalogueItemService ?? throw new ArgumentNullException(nameof(catalogueItemService));
            _providerService = providerService ?? throw new ArgumentNullException(nameof(providerService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }

        [HttpGet]
        public async Task<IActionResult> GetCatalogueItems(int providerId)
        {
            try
            {
                var catalogueItems = await _catalogueItemService.GetCatalogueItemsForProviderAsync(providerId);
                return Ok(catalogueItems);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpGet("{itemId}", Name ="GetCatalogueItem")]
        public async Task<IActionResult> GetCatalogueItem(int providerId, int itemId)
        {
            try
            {
                var catalogueItem = (await _catalogueItemService.GetCatalogueItemsForProviderAsync(providerId)).SingleOrDefault(x => x.Id == itemId);
                if (catalogueItem == null)
                    return NotFound();
                return Ok(catalogueItem);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCatalogueItem(NewCatalogueItemDto catalogueItem)
        {
            try
            {
                if (catalogueItem.Name == string.Empty)
                {
                    ModelState.AddModelError(
                        "Name",
                        "The catalogItem name should not be empty!");
                }

                var providerId = await _catalogueItemService.GetProviderIdForCatalogItemAsync(catalogueItem);
                if (await _catalogueItemService.CatalogueItemExistsAsync(catalogueItem.Name, providerId))
                {
                    ModelState.AddModelError(
                        "Name",
                        "A catalogueItem with the same name and the same providerId already exists into the database!");
                }

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var insertedCatalogueId = await _catalogueItemService.CreateAsync(catalogueItem);

                if (insertedCatalogueId == 0)
                    return Problem();

                return CreatedAtRoute("GetCatalogueItem", new { providerId, itemId = insertedCatalogueId }, await _catalogueItemService.GetCatalogueItemByIdAsync(insertedCatalogueId));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCatalogueItem(int id, [FromBody] CatalogueItemDto catalogueItem)
        {
            try
            {
                if (catalogueItem.Id != id)
                {
                    ModelState.AddModelError(
                        "Identifier",
                        "Request body not apropiate for ID");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (await _catalogueItemService.GetCatalogueItemByIdAsync(id) == null)
                {
                    return NotFound();
                }

                await _catalogueItemService.UpdateAsync(catalogueItem);

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCatalogueItem(int id)
        {
            try
            {
                if (await _catalogueItemService.GetCatalogueItemByIdAsync(id) == null)
                {
                    return NotFound();
                }

                await _catalogueItemService.DeleteAsync(id);

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }


    }
}
