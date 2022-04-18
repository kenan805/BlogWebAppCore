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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal) => _contactDal = contactDal;

        public List<Contact> GetAll() => _contactDal.GetAll();

        public void TAdd(Contact entity) => _contactDal.Insert(entity);

        public void TDelete(Contact entity) => _contactDal.Delete(entity);

        public Contact TGetById(int id) => _contactDal.GetById(id);

        public void TUpdate(Contact entity) => _contactDal.Update(entity);
    }
}
