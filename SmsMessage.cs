using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProcess
{
    internal class SmsMessage : Message
    {
        public SmsMessage()
        {
            Console.WriteLine("SMS отправдено");
        }
    }
}
