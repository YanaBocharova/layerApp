using LayerApp.DAL.Entities;
using LayerApp.DAL.Interfaces;
using LayerAppBLL.DTO;
using LayerAppBLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerAppBLL.Services
{
        }
public class ProductsService : BaseService, IProductsService
{
    public ProductsService(IUnitOfWork uow) : base(uow) { }

    public void Add(ProductDTO item)
    {
        var prod = mapper.Map<Product>(item);
        db.ProductsRepository.Create(prod);
    }

    public void Delete(ProductDTO item)
    {
        var prod = mapper.Map<Product>(item);
        db.ProductsRepository.Delete(prod.Id);

    }

    public void Dispose() => db.Dispose();

    public ProductDTO GetProduct(int id)
    {
        var product = db.ProductsRepository.Get(id);
        return mapper.Map<ProductDTO>(product);
    }

    public IEnumerable<ProductDTO> GetProducts()
    {
        var products = db.ProductsRepository.GetAll();
        return mapper.Map<IEnumerable<ProductDTO>>(products);
    }

    public IEnumerable<ProductDTO> GetProductsByCategoryId(int id)
    {
        var products = db.ProductsRepository.GetAll(prod => prod.CategoryId == id);
        return mapper.Map<IEnumerable<ProductDTO>>(products);
    }

    public void Update(ProductDTO item)
    {
        var prod = mapper.Map<Product>(item);
        db.ProductsRepository.Update(prod);
        db.Save();
    }
}
