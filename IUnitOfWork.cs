using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryPattern
{
    interface IUnitOfWork
    {
        IRepository<Customer> Customers { get; }
        IRepository<Order> Orders { get; }
        void commit();
    }
}
