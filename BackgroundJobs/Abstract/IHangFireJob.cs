using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundJobs.Abstract
{
    public interface IHangFireJob
    {
        void DelayedJobs(int UserId, string UserName, string Email, TimeSpan timeSpan);
        void FireandForget(int UserId, string UserName, string Email);
    }
}
