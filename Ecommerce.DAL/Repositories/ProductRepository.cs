using System;
using Ecommerce.DAL.Data;
using Ecommerce.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Ecommerce.DAL.Repositories
{
    public class ProductRepository:RepositoryBase<Customer>
    {
        public ProductRepository(DataContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}