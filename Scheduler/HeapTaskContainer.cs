using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler
{
    class HeapTaskContainer : ITaskContainer
    {
        private readonly SortedList<DateTime, Task> tasks;

        public HeapTaskContainer()
        {
            tasks = new SortedList<DateTime, Task>();
        }
        public void AddNewTask(Task task)
        {
            tasks.Add(task.On, task);
        }

        public void UpdateTask(Task task)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(Task task)
        {
            tasks.Remove(task.On);
        }

        public Task GetTask(DateTime time)
        {
            var t = tasks.FirstOrDefault(x => x.Key.Date == time.Date &&
                                              x.Key.Hour == time.Hour &&
                                              x.Key.Minute == time.Minute);
            return t.Value;
        }
    }
}
