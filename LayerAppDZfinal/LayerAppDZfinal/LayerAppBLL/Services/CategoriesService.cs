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
    public class CategoriesService : BaseService, ICategoriesService
    {
        public CategoriesService(IUnitOfWork uow) : base(uow) { }

        public void Add(CategoryDTO item)
        {
            var cat = mapper.Map<Category>(item);
            db.CategoriesRepository.Create(cat);
        }

        public void Delete(CategoryDTO item)
        {
            db.CategoriesRepository.Delete(item.Id);
        }

        public void Dispose() => db.Dispose();

        public IEnumerable<CategoryDTO> GetCategories()
        {
            var categories = db.CategoriesRepository.GetAll();
            return mapper.Map<IEnumerable<CategoryDTO>>(categories);
        }

        public CategoryDTO GetCategory(int id)
        {
            var category = db.CategoriesRepository.Get(id);
            return mapper.Map<CategoryDTO>(category);
        }

        public void Update(CategoryDTO item)
        {
            var cat = mapper.Map<Category>(item);
            db.CategoriesRepository.Update(cat);
            db.Save();
        }
    }
}
