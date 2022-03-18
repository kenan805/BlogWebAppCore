using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            using var _context = new Context();
            _context.Add(blog);
            _context.SaveChanges();
        }

        public void Delete(Blog item)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            using var _context = new Context();
            _context.Remove(blog);
            _context.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            using var _context = new Context();
            return _context.Blogs.Find(id);
        }

        public void Insert(Blog item)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            using var _context = new Context();
            return _context.Blogs.ToList();
        }

        public void Update(Blog item)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            using var _context = new Context();
            _context.Update(blog);
            _context.SaveChanges();
        }
    }
}
