﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    interface ITask
    {
        DateTime On { get; set; }
        void Execute();
    }
}