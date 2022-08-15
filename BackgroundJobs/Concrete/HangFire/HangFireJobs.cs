using BackgroundJobs.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundJobs.Concrete.HangFireJobs
{
    public class HangFireJobs : IHangFireJob
    {
        private ISendMailService _sendMailService;
        public HangFireJobs(ISendMailService sendMailService)
        {
            _sendMailService = sendMailService;
        }

        public void DelayedJobs(int UserId, string UserName, string Email, TimeSpan timeSpan)
        {
            Hangfire.BackgroundJob.Schedule(() =>
               _sendMailService.SendMail(UserId, UserName, Email), timeSpan);
        }

        public void FireandForget(int UserId, string UserName, string Email)
        {
            Hangfire.BackgroundJob.Enqueue(() =>
               _sendMailService.SendMail(UserId, UserName, Email)); 
        }
    }
}
