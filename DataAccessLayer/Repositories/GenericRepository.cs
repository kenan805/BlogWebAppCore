using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T item)
        {
            using var _context = new Context();
            _context.Remove(item);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var _context = new Context();
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var _context = new Context();
            return _context.Set<T>().Find(id);
        }

        public void Insert(T item)
        {
            using var _context = new Context();
            _context.Add(item);
            _context.SaveChanges();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using var _context = new Context();
            return _context.Set<T>().Where(filter).ToList();
        }

        public void Update(T item)
        {
            using var _context = new Context();
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
