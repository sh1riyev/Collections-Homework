using System;
using Exceptions_Homework.Models;

namespace Exceptions_Homework.Services.Interface
{
	public interface ICustomerService
	{
		List<Customer> GetAll();
		Customer GetById(int id);
		List<Customer> GetAllByAge(int age);
		int GetCount();
		List<Customer> OrderByAge(int digit);
	}
}

