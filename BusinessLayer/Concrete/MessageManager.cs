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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal) => _messageDal = messageDal;

		public List<Message> GetAll() => _messageDal.GetAll();

		public List<Message> GetInboxListByWriter(string param) => _messageDal.GetListAll(x => x.Receiver == param);

		public void TAdd(Message entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message entity)
        {
            throw new NotImplementedException();
        }

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
