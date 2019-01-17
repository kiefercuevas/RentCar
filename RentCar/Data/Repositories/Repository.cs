using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RentCar.Data.Core;
using RentCar.Data;
using System.Data.Entity;

namespace RentCar.Data.Repositories
{
   public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly RentCarContex _Context;
        protected readonly DbSet<T> _entity;
        public Repository(RentCarContex carContex){
            _Context = carContex;
            _entity = _Context.Set<T>();
        }
        public void Add(T entity)
        {
            _entity.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _entity.AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _entity.Where(predicate).ToList();
        }

        public T Get(int id)
        {
            return _entity.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entity.ToList();
        }

        public void Remove(T entity)
        {
            _entity.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _entity.RemoveRange(entities);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _entity.SingleOrDefault(predicate);
        }
    }
}
