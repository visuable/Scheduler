using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Scheduler.TestTask
{
    class ConcreteTask : Task, IExecutable
    {
        public ConcreteTask() : base(false, DateTime.Now.AddMinutes(1))
        {

        }
        public async System.Threading.Tasks.Task Execute()
        {
            try
            {
                await File.WriteAllTextAsync("отчет.txt", DateTime.Now.ToShortDateString());
            }
            catch
            {
                Done = false;
            }

            Done = true;
        }
    }
}
