using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler
{
    class ConsoleOutput : IOutput
    {
        public void Print()
        {
            Console.WriteLine("does нот workинг");
        }
    }
}
