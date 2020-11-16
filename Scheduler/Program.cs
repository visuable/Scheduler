using System;
using Scheduler.TestTask;

namespace Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            ITaskContainer container = new HeapTaskContainer();
            IScheduler scheduler = new HeapScheduler(container);
            container.AddNewTask(new ConcreteTask());
            scheduler.Start();
        }
    }
}
