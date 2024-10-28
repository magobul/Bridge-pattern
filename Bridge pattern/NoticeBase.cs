using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    public abstract class NoticeBase
    {
        protected notice _notice;
        protected NoticeBase(notice notice)
        {
            _notice = notice;
        }
        public abstract void Notify(string message);
    }
}
