using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryPattern
{
    class UnitOfWork : IUnitOfWork
    {
        GRPDemoEntities _grpde;
        IRepository<Customer> _Customers;
        IRepository<Order> _Orders;

        public UnitOfWork(GRPDemoEntities grpde)
        {
            _grpde = grpde;
        }

        public IRepository<Customer> Customers 
        {
            get
            {
                return _Customers ??
                       (_Customers = new BaseRepository<Customer>(_grpde));
            }
        }

        public IRepository<Order> Orders 
        {
            get 
            {
                return _Orders ??
                      (_Orders = new BaseRepository<Order>(_grpde));
                    }
        }

        public void commit()
        {
            _grpde.SaveChanges();
        }
    }
}
