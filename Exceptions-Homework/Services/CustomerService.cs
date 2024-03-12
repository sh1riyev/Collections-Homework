using Exceptions_Homework.Data;
using Exceptions_Homework.Models;
using Exceptions_Homework.Services.Interface;

namespace Exceptions_Homework.Services
{
	public class CustomerService :ICustomerService
	{
       public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }

      public  Customer GetById(int id)
        {
            return id == null ? throw new ArgumentNullException() : AppDbContext.customers.FirstOrDefault(m => m.Id == id);
        }

       public List<Customer> GetAllByAge(int age)
        {
            return AppDbContext.customers.Where(m => m.Age == age).ToList();
        }

      public int GetCount()
        {
            return AppDbContext.customers.Count;
        }

        public List<Customer> OrderByAge(int digit)
        {
            switch (digit)
            {
                case 1:
                    return AppDbContext.customers.OrderBy(m => m.Age).ToList();
                case 2:
                  return  AppDbContext.customers.OrderByDescending(m => m.Age).ToList();
            }
            return null;
        }
    }
}

