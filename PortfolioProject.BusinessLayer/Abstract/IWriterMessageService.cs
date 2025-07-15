using PortfolioProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.BusinessLayer.Abstract
{
    public interface IWriterMessageService: IGenericService<WriterMessage>
    {
        List<WriterMessage> GetListSendMessage(string p);
        List<WriterMessage> GetListReceiverMessage(string p);
    }
}
