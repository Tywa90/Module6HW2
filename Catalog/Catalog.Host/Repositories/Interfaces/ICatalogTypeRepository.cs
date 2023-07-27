using Catalog.Host.Data;
using Catalog.Host.Data.Entities;

namespace Catalog.Host.Repositories.Interfaces;

public interface ICatalogTypeRepository
{
    Task<PaginatedItems<CatalogType>> GetByPageAsync(int pageIndex, int pageSize);
    Task<int?> Add(string type);
}