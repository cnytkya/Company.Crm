using Company.Crm.Domain.Entities;

namespace Company.Crm.Application.Services.Abstracts
{
    public interface ICustomerService
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