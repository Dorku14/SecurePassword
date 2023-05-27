using Microsoft.EntityFrameworkCore;
using SecurePassword.Models;
using System.Collections.Generic;

namespace SecurePassword.Context
{
    public class AccountContext
        : DbContext
    {
        public DbSet<Password> passwords_id { get; set; }
        public DbSet<Password> Status { get; set; }
        public DbSet<Password> Name { get; set; }
        public DbSet<Password> Date_created { get; set; }
        public DbSet<Password> Date_last_updated { get; set; }
        public DbSet<Password> Date_last_time_used { get; set; }
        public AccountContext() { }
        public AccountContext(DbContextOptions<AccountContext> options) :
            base(options)
        {

        }




    }
}
