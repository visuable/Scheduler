using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Scheduler
{
    public class TaskContext : DbContext
    {
        private string connection;
        public TaskContext(string connection)
        {
            this.connection = connection;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
