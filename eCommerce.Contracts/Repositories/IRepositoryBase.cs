using Ecommerce.Models;
using System.Collections.Generic;


namespace Ecommerce.Contracts.Repositories
{
    public interface IRepositoryBase
    {
        void Delete(Product entity);
    
        IEnumerable<Product> GetAll();
        Product GetById(object id);
        void Insert(Product entity);
        void Save();
        void Update(Product entity);
    }
}