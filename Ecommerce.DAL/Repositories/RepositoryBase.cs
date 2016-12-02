using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Contracts.Repositories;
using Ecommerce.DAL.Data;
using Ecommerce.Models;

namespace Ecommerce.DAL.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase where TEntity : class
    {
        internal DataContext context;
        internal DbSet<TEntity> dbset;

        protected RepositoryBase(DataContext context)
        {
            this.context = context;
            this.dbset = context.Set<TEntity>();
        }

        public virtual Product GetById(object id)
        {
            return context.Products.Find(id);
        }

        public virtual IEnumerable<Product> GetAll()
        {
            return context.Products;
        }

        public virtual void Insert(Product entity)
        {
            context.Products.Add(entity);
        }

        public virtual void Delete(Product entity)
        {
             
            Product book = context.Products.Find(entity);
            context.Products.Remove(book);
       
        }

        public virtual void Update(Product entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            context.SaveChanges();
        }

//        private bool _disposed = false;
//
//        protected virtual void Dispose(bool disposing)
//        {
//            if (!this._disposed)
//            {
//                if (disposing)
//                {
//                    context.Dispose();
//                }
//            }
//            this._disposed = true;
//        }
//
//        public void Dispose()
//        {
//            Dispose(true);
//            GC.SuppressFinalize(this);
//        }
    }

}
