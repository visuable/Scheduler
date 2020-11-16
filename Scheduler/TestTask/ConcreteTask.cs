using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Scheduler.TestTask
{
    class ConcreteTask : ITask
    {
        public DateTime On { get; set; }

        public ConcreteTask()
        {
            On = DateTime.Now.AddMinutes(1);
        }
        public async void Execute()
        {
            await File.WriteAllTextAsync("отчет.txt", DateTime.Now.ToShortDateString());
        }
    }
}
