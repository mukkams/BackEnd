using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models.UserStore;

namespace Persistence
{
    public class WorkflowDataContext: DbContext
    {
        public WorkflowDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Email> Email { get; set; }
    }

}
