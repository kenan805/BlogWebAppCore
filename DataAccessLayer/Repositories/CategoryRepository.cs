using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context _context = new Context();
        public void AddCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }

        public void Delete(Category item)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Insert(Category item)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            return _context.Categories.ToList();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }
    }
}
