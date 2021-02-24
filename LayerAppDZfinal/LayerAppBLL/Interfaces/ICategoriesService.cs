using LayerAppBLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerAppBLL.Interfaces
{
    public interface ICategoriesService:IDisposable
    {
        CategoryDTO GetCategory(int id);
        IEnumerable<CategoryDTO> GetCategories();
        void Add(CategoryDTO item);
        void Update(CategoryDTO item);
        void Delete(CategoryDTO item);
    }
}
