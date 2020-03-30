using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseRepository<Customer> br = new BaseRepository<Customer>(new GRPDemoEntities());
            Customer customer = new Customer();
            customer.id = 1;
            customer.name = "Marko";
            br.Insert(customer);
            br.Save();
        }
    }
}
