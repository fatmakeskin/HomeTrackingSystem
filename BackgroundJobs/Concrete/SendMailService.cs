using BackgroundJobs.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundJobs.Concrete
{
    public class SendMailService : ISendMailService
    {
        public void SendMail(int UserId, string UserName, string Email)
        {
            throw new NotImplementedException();
        }
    }
}
