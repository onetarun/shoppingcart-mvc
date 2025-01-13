using System;
using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> GetAllProductAsync();
    Task<Product?> GetByIdAsync(int id);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(int id);
    Task<bool> SaveChangesAsync();
    bool IsProductExists(int id);
    

}
