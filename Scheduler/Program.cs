using System;
using Microsoft.EntityFrameworkCore;
using Scheduler.TestTask;

namespace Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new TaskContext("Data Source=(LocalDb)\\MSSQLLocalDB; Database=taskDb");
            ITaskContainer container = new DatabaseTaskContainer(context);
            IOutput output = new ConsoleOutput();
            IScheduler scheduler = new DatabaseScheduler(container, output);
            container.AddNewTask(new ConcreteTask());
            scheduler.Start();
        }
    }
}
