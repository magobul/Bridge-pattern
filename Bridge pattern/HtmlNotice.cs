using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    public class HtmlNotice : NoticeBase
    {
        public HtmlNotice(notice notice) : base(notice) { }
        public override void Notify(string message)
        {
            string Htmlmessage = $"<html><body><p>{message}</p></body></html>";
            _notice.Send(Htmlmessage);
        }
    }
}
