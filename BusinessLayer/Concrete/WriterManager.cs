using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal) => _writerDal = writerDal;

        public List<Writer> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id) => _writerDal.GetListAll(x => x.WriterID == id);

		public void TAdd(Writer entity) => _writerDal.Insert(entity);

		public void TDelete(Writer entity)
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id) => _writerDal.GetById(id);

        public void TUpdate(Writer entity) => _writerDal.Update(entity);

    }
}
