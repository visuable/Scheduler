using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler
{
    class HeapTaskContainer : ITaskContainer
    {
        private readonly SortedList<DateTime, ITask> tasks;

        public HeapTaskContainer()
        {
            tasks = new SortedList<DateTime, ITask>();
        }
        public void AddNewTask(ITask task)
        {
            tasks.Add(task.On, task);
        }

        public void DeleteTask(ITask task)
        {
            tasks.Remove(task.On);
        }

        public ITask GetTask(DateTime time)
        {
            var t = tasks.FirstOrDefault(x => x.Key.Date == time.Date &&
                                              x.Key.Hour == time.Hour &&
                                              x.Key.Minute == time.Minute);
            return t.Value;
        }
    }
}
