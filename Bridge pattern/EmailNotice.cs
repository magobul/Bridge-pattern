using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    public class EmailNotice:notice
    {
        public void Send(string message)
        {
            Console.WriteLine($"Отправка email уведомления: {message}");
        }
    }
}
