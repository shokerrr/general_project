using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository
{
    public interface IUnitOfWork: IDisposable
    {


        IRepositoryBase<User> User { get; }
        IRepositoryBase<Order> Order { get; }
        IRepositoryBase<Rate> Rate { get; }
        IRepositoryBase<Feedback> Feedback { get; }
        IRepositoryBase<Advertisment> Advertisment { get; }
        //new void Dispose();
        //void Dispose();
        void Save();

        void Commit();
    }
}
