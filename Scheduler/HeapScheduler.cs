using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    class HeapScheduler : IScheduler
    {
        private readonly ITaskContainer container;

        public HeapScheduler(ITaskContainer container)
        {
            this.container = container;
        }
        public Task Execute()
        {
            while (true)
            {
                var task = container.GetTask(DateTime.Now);
                task?.Execute();
                Task.Delay(500);
            }
        }

        public void Start()
        {
            Execute().Start();
        }
    }
}
