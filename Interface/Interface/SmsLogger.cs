using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class SmsLogger : ILogger //buradan sonra implemente etmen gereken bazı metotlar old söylüyor
    {
        public void WriteLog()
        {
          //  throw new NotImplementedException();
          Console.Write("sms olarak log a yazar");
        }
    }

}
