﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal) => _blogDal = blogDal;

        public List<Blog> GetAll() => _blogDal.GetAll();

        public List<Blog> GetLastThreeBlog() => _blogDal.GetAll().Take(3).ToList();

        public List<Blog> GetBlogListWithCategory() => _blogDal.GetListWithCategory();
        public List<Blog> GetBlogListWithCategoryByWriter(int id) => _blogDal.GetListWithCategoryByWriter(id);

        public Blog TGetById(int id)
        {
            return _blogDal.GetById(id);
        }
        public List<Blog> GetBlogsById(int id) => _blogDal.GetListAll(x => x.BlogID == id);

        public List<Blog> GetBlogListWithWriter(int id) => _blogDal.GetListAll(x => x.WriterID == id);

        public void TAdd(Blog entity) => _blogDal.Insert(entity);

        public void TDelete(Blog entity) => _blogDal.Delete(entity);

        public void TUpdate(Blog entity) => _blogDal.Update(entity);
    }
}
