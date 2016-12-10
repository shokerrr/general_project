using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class ServiceContext : DbContext
    {
        public DbSet<Advertisment> Advertisments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<User> Users { get; set; }

        public ServiceContext(string connectionString) : base(connectionString)
        {

        }
    }
}
