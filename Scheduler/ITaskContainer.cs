using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler
{
    interface ITaskContainer
    {
        void AddNewTask(Task task);
        void UpdateTask(Task task);
        Task GetTask(DateTime time);
    }
}
