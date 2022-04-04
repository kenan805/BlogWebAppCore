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
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _message2Dal;

        public Message2Manager(IMessage2Dal message2Dal) => _message2Dal = message2Dal;

        public List<Message2> GetAll() => _message2Dal.GetAll();

        public List<Message2> GetInboxListByWriter(int id) => _message2Dal.GetListWithMessageByWriter(id);

        public void TAdd(Message2 entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message2 entity)
        {
            throw new NotImplementedException();
        }

        public Message2 TGetById(int id) => _message2Dal.GetById(id);

        public void TUpdate(Message2 entity)
        {
            throw new NotImplementedException();
        }
    }
}
