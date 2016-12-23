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
        //public object User { get; set; }

        static ServiceContext()
        {
            Database.SetInitializer<ServiceContext>(new AdvertismentDbInitializer());
        }
        public ServiceContext(string connectionString) : base(connectionString)
        {

        }

        public class AdvertismentDbInitializer : DropCreateDatabaseIfModelChanges<ServiceContext>
        {
            protected override void Seed(ServiceContext db)
            {
                db.Categories.Add(new Category { Name = "IT" });
                db.Categories.Add(new Category { Name = "Homework" });
                db.Users.Add(new User { FirstName = "John", LastName = "Mactavish", PhoneNumber = "+3333-333-33-33", Email = "job@gmail.com", BankDetails = "13huh3u12"});
                db.Users.Add(new User { FirstName = "Elizabeth", LastName = "Koner", PhoneNumber = "+3333-444-44-44", Email = "money@gmail.com", BankDetails = "adf23242a" });
                //db.Advertisments.Add(new Advertisment{TypeOfAuthor = Advertisment.Type.Performer,Author = "John",ServiceCategory = "",Text = "Anything Anything Anything Anything",Cost = 140);
                db.SaveChanges();
            }

        }
    }
}
