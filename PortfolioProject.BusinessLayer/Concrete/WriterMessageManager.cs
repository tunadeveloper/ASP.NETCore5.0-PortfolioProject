using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.DataAccessLayer.Abstract;
using PortfolioProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.BusinessLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        private readonly IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writerMessageDal.GetListByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSendMessage(string p)
        {
            return _writerMessageDal.GetListByFilter(x => x.Sender == p);
        }

        public void TDelete(WriterMessage t)
        {
           _writerMessageDal.Delete(t);
        }

        public WriterMessage TGetById(int id)
        {
            return _writerMessageDal.GetByID(id);
        }

        public List<WriterMessage> TGetList()
        {
           return _writerMessageDal.GetList();
        }


        public List<WriterMessage> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(WriterMessage t)
        {
          _writerMessageDal.Insert(t);
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
