using FoodPal.Providers.DomainModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace FoodPal.Providers.DataAccess.Repository
{
    public class CatalogueItemRepository : Repository<CatalogueItem>, ICatalogueItemRepository
    {
        public CatalogueItemRepository(CatalogueItemsContext catalogueItemsContext) : base(catalogueItemsContext)
        {
        }

        public async Task<IEnumerable<CatalogueItem>> GetAllWithProviderAndCategoryByProviderIdAsync(int providerId)
        {
            return await _catalogueItemsContext.CatalogueItems
                .Include(ci => ci.Catalogue)
                .ThenInclude(c => c.Provider)
                .ThenInclude(p => p.Category.Name)
                .Where(p => p.Catalogue.Provider.Id == providerId)
                .ToListAsync();
        }

        public async Task<CatalogueItem> GetWithProviderAndCategoryItemByIdAsync(int catalogueItemId)
        {
            return await _catalogueItemsContext.CatalogueItems
                .Include(ci => ci.Category.Name)
                .Include(ci => ci.Catalogue)
                .ThenInclude(c => c.Provider)
                .SingleOrDefaultAsync(x => x.Id == catalogueItemId);
        }
    }
}