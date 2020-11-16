using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler
{
    interface ITaskContainer
    {
        void AddNewTask(ITask task);
        void DeleteTask(ITask task);
        ITask GetTask(DateTime time);
    }
}
