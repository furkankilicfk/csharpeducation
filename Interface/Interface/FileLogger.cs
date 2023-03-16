using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class FileLogger : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("dOSYAYA LOG YAZAR");
        }
    }

}
