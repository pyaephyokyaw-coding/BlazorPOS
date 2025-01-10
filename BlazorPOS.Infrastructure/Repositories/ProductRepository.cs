using BlazorPOS.Application.Interfaces;
using BlazorPOS.Domain.Entities;
using BlazorPOS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorPOS.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Detach(Product product)
    {
        _context.Entry(product).State = EntityState.Detached;
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> AddAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task UpdateAsync(Product product)
    {
        _context.Entry(product).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<Product?> GetByBarcodeAsync(string barcode)
    {
        return await _context.Products
            .FirstOrDefaultAsync(p => p.Barcode == barcode);
    }
}
