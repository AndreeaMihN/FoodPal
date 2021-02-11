using FoodPal.Providers.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodPal.Providers.DataAccess.Repository
{
    public interface ICatalogueItemRepository : IRepository<CatalogueItem>
    {
        Task<IEnumerable<CatalogueItem>> GetAllWithProviderAndCategoryByProviderIdAsync(int providerId);

        Task<CatalogueItem> GetWithProviderAndCategoryItemByIdAsync(int catalogueItemId);
    }
}
