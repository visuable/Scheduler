using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Scheduler
{
    public class Task
    {
        public Task(bool done, DateTime @on)
        {
            Done = done;
            On = @on;
        }

        public int Id { get; set; }
        public bool Done { get; set; }
        public string Concrete { get; set; }
        public DateTime On { get; set; }
    }
}
