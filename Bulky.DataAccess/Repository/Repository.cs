using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Repository
{
    public class Repository<T> : Bulky.DataAccess.Repository.IRepository.IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> DbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            DbSet = _db.Set<T>();
        }

        public IEnumerable<T> GetAll()
            => DbSet.ToList();

        public T? Get(Expression<Func<T, bool>> filter)
            => DbSet.FirstOrDefault(filter);

        public void Add(T entity)
            => DbSet.Add(entity);

        public void Remove(T entity)
            => DbSet.Remove(entity);

        public void RemoveRange(IEnumerable<T> entities)
            => DbSet.RemoveRange(entities);
    }
}
