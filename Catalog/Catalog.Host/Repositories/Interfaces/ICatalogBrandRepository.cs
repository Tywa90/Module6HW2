using Catalog.Host.Data;
using Catalog.Host.Data.Entities;

namespace Catalog.Host.Repositories.Interfaces;

public interface ICatalogBrandRepository
{
    Task<PaginatedItems<CatalogBrand>> GetByPageAsync(int pageIndex, int pageSize);
    Task<int?> Add(string brand);
}