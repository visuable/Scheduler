using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler
{
    interface IExecutable
    {
        System.Threading.Tasks.Task Execute();
    }
}
