﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        void CommentAdd(Comment comment);
        List<Comment> GetAll(int id);
        List<Comment> GetCommentListWithBlog();

    }
}
