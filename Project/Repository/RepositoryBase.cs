using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class RepositoryBase<T>: IRepositoryBase<T> where T: EntityBase
    {
        protected ServiceContext _db;
        private readonly IDbSet<T> _dbEntities;

        protected RepositoryBase(ServiceContext context)
        {
            _db = context;
            _dbEntities = _db.Set<T>();
        }
        public virtual IQueryable<T> GetAll()
        {
            return _dbEntities;
        }
        public virtual T Get(int id)
        {
            return _dbEntities.FirstOrDefault(e => e.Id == id);
        }
        public virtual void Create(T entity)
        {
            _dbEntities.Add(entity);
        }
        public virtual void Delete(int id)
        {
           var temp = _dbEntities.Find(id);
            if (temp != null)
                _dbEntities.Remove(temp);
        }
        public virtual void Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }
    }
}
