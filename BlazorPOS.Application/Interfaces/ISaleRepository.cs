using BlazorPOS.Domain.Entities;

namespace BlazorPOS.Application.Interfaces;

public interface ISaleRepository
{
    Task<Sale?> GetByIdAsync(int id);
    Task<IEnumerable<Sale>> GetAllAsync();
    Task<Sale> AddAsync(Sale sale);
    Task<IEnumerable<Sale>> GetSalesByDateRangeAsync(DateTime startDate, DateTime endDate);
}
