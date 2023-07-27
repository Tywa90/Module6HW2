namespace Catalog.Host.Services.Interfaces;

public interface ICatalogBrandService
{
    Task<int?> Add(string brand);
}