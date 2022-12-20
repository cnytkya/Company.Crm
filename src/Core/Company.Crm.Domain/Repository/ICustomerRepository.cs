using Company.Crm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Crm.Domain.Repository
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAll();
        public Customer GetById(int Id);
        public bool Insert(Customer customer);
        public bool Update(Customer customer);
        public bool Delete(Customer customer);
        public bool DeleteById(int Id);
        public List<Customer> GetAllByRegionId(int regionId);
    }
}
