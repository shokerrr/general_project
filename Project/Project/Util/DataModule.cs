using Autofac;
using Autofac.Builder;
using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Project.Util
{
    public class DataModule : Module
    {
        private string connStr;
        public DataModule(string connectionString)
        {
            connStr = connectionString;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ServiceContext>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<AdvertismentRepository>().As<IAdvertismentRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerLifetimeScope();
            builder.RegisterType<FeedbackRepository>().As<IFeedbackRepository>().InstancePerLifetimeScope();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RateRepository>().As<IRateRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            base.Load(builder);
        }
    }
}