using Company.Crm.Application.Services.Abstracts;
using Company.Crm.Domain.Repository;
using Company.Crm.Domain.Entities;

namespace Company.Crm.Application.Services
{
    //Concrete : Abstarct
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }


        public Customer GetById(int Id)
        {
            return _customerRepository.GetById(Id);
        }
    
        public bool Insert(Customer customer)
        {
            return _customerRepository.Insert(customer);
        }

        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }

        public bool Delete(Customer customer)
        {
            return _customerRepository.Delete(customer);
        }

        public bool DeleteById(int Id)
        {
            return _customerRepository.DeleteById(Id);
        }

        public List<Customer> GetAllByRegionId(int regionId)
        {
            return _customerRepository.GetAllByRegionId(regionId);
        }
    }
}
