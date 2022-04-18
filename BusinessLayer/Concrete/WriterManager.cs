using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal) => _writerDal = writerDal;

        public List<Writer> GetAll() => _writerDal.GetAll();


        public List<Writer> GetWriterById(int id) => _writerDal.GetFilterAll(x => x.WriterID == id);

        public void TAdd(Writer entity) => _writerDal.Insert(entity);

        public void TDelete(Writer entity) => _writerDal.Delete(entity);

        public Writer TGetById(int id) => _writerDal.GetById(id);

        public void TUpdate(Writer entity) => _writerDal.Update(entity);

    }
}
