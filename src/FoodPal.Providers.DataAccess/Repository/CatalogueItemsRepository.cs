using FoodPal.Providers.DomainModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPal.Providers.DataAccess.Repository
{
    public class CatalogueItemsRepository : Repository<CatalogueItem>, ICatalogueItemsRepository
    {
        public CatalogueItemsRepository(ProvidersContext context) : base(context)
        {

        }

        public async Task<IEnumerable<CatalogueItem>> GetAllWithProviderAsync(int providerId)
        {
            return await _providersContext.CatalogueItems
                .Include(ci => ci.Catalogue.Provider)
                .Include(ci => ci.Category)
                .Where(x => x.Catalogue.ProviderId == providerId)
                .ToListAsync();
        }

        public async Task<CatalogueItem> GetWithProviderByIdAsync(int catalogueItemId)
        {
            return await _providersContext.CatalogueItems
                .Include(ci => ci.Catalogue.Provider)
                .Include(ci => ci.Category)
                .SingleOrDefaultAsync(x => x.Id == catalogueItemId);
        }
    }
}