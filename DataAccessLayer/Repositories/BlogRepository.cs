using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void DeleteBlog(Blog blog)
        {
            using var _context = new Context();
            _context.Remove(blog);
            _context.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var _context = new Context();
            return _context.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            using var _context = new Context();
            return _context.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var _context = new Context();
            _context.Update(blog);
            _context.SaveChanges();
        }
    }
}
