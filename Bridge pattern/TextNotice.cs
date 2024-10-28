using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    public class TextNotice : NoticeBase
    {
        public TextNotice(notice notice) : base(notice) { }
        public override void Notify(string message)
        { 
            _notice.Send(message);
        }
    }
}
