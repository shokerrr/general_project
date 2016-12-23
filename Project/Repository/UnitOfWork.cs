using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
//using AutoMapper;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private ServiceContext _db;
        private UserRepository userRepository;
        private FeedbackRepository feedbackRepository;
        private OrderRepository orderRepository;
        private RateRepository rateRepository;
        private AdvertismentRepository advertismentRepository;

        public void Commit()
        {
            _db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public  IRepositoryBase< User > User{get; private  set;}
        public  IRepositoryBase< Order > Order{get; private    set;}
        public  IRepositoryBase< Rate > Rate{get; private  set;}
        public  IRepositoryBase< Feedback > Feedback{get; private  set;}
        public  IRepositoryBase< Advertisment > Advertisment{get; private    set;}

        public  void Save ()
            {
                _db.SaveChanges();
            }
        }
}
