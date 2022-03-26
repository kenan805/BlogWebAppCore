using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal) => _categoryDal = categoryDal;

        public List<Category> GetAll() => _categoryDal.GetAll();

        public Category GetById(int id) => _categoryDal.GetById(id);

        public void TAdd(Category entity) => _categoryDal.Insert(entity);

        public void TDelete(Category entity) => _categoryDal.Delete(entity);

        public void TUpdate(Category entity) => _categoryDal.Update(entity);
    }
}
