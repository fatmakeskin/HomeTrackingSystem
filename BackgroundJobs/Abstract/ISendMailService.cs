using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundJobs.Abstract
{
    public interface ISendMailService
    {
        void SendMail(int UserId, string UserName, string Email);
    }
}
