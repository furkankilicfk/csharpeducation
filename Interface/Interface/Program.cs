using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
             FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DataBaseLogger dataBaseLogger = new DataBaseLogger();
            dataBaseLogger.WriteLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            Console.ReadKey();
        }
    }
}
