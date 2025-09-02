using CatalogoProductos.Models;

namespace CatalogoProductos.Services
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetAllProductos();
        Task<Producto?> GetProductoById(int id);
        Task<Producto> CreateProducto(Producto producto);
        Task<Producto?> UpdateProducto(int id, Producto producto);
        Task<bool> DeleteProducto(int id);
    }
}

