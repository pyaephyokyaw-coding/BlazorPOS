using BlazorPOS.Domain.Entities;

namespace BlazorPOS.Application.Interfaces;

public interface IProductRepository
{
    Task<Product?> GetByIdAsync(int id);
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product> AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(int id);
    Task<Product?> GetByBarcodeAsync(string barcode);
    void Detach(Product product);
}
