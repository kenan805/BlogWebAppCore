using EntityLayer.Concrete;
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
        //void BlogDelete(Blog comment);
        //void BlogUpdate(Blog comment);
        List<Comment> GetAll(int id);
        //Blog GetById(int id);
    }
}
