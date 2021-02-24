using LayerAppBLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerAppBLL.Interfaces
{
    public interface IProductsService:IDisposable
    {
        ProductDTO GetProduct(int id);
        IEnumerable<ProductDTO> GetProducts();
        IEnumerable<ProductDTO> GetProductsByCategoryId(int id);

        void Add(ProductDTO item);
        void Update(ProductDTO item);
        void Delete(ProductDTO item);
    }
}
