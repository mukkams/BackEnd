using System;
using Domain;
using Domain.Models.UserStore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class UserStoreDataContext : DbContext
    {
        public UserStoreDataContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<User> User { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Email> Email { get; set; }

        public DbSet<Client> Client { get; set; }

    }
}
