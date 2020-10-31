using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models.ProcessFlow;

namespace Persistence
{
    public class ProcessFlowDataContext : DbContext
    {
        public ProcessFlowDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PFProcessType> PFProcessType { get; set; }

        public DbSet<PFActivity> PFActivity { get; set; }
    }
}
