using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Scheduler
{
    class DatabaseScheduler : IScheduler
    {
        private ITaskContainer _container;
        private IOutput _output;
        public DatabaseScheduler(ITaskContainer container, IOutput output)
        {
            _container = container;
            _output = output;
        }
        public void Start()
        {
            UpdateTask().Start();
        }

        private async System.Threading.Tasks.Task UpdateTask()
        {
            while (true)
            {
                var task = _container.GetTask(DateTime.Now);
                if (task != null)
                {
                    await ((IExecutable) task)?.Execute();
                    if (!task.Done)
                    {
                        _output.Print();
                    }
                    else
                    {
                        _container.UpdateTask(task);
                    }
                }
                Thread.Sleep(500);
            }
        }
    }
}
