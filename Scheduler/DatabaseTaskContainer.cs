using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler
{
    class DatabaseTaskContainer : ITaskContainer
    {
        private TaskContext context;
        public DatabaseTaskContainer(TaskContext context)
        {
            this.context = context;
        }
        public void AddNewTask(Task task)
        {
            context.Tasks.Add(task);
            context.SaveChanges();
        }

        public void DeleteTask(Task task)
        {
            context.Tasks.Remove(task);
            context.SaveChanges();
        }

        public void UpdateTask(Task task)
        {
            context.Tasks.Update(task);
            context.SaveChanges();
        }
        public Task GetTask(DateTime time)
        {
            var t = context.Tasks.FirstOrDefault(x => x.On.Date == time.Date &&
                                              x.On.Hour == time.Hour &&
                                              x.On.Minute == time.Minute);
            return t;
        }
    }
}
