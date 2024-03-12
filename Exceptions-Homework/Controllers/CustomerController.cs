using Exceptions_Homework.Services;
using Exceptions_Homework.Services.Interface;

namespace Exceptions_Homework.Controllers
{
	public class CustomerController
	{
		private readonly ICustomerService _customerService;
		public CustomerController()
		{
			_customerService = new CustomerService();
		}
		public void GetAll()
		{
			foreach (var item in _customerService.GetAll())
			{
				Console.WriteLine(item.Fullname+ " " +item.Age+ " " +item.Adress);
			}
		}
		public void GetBydId()
		{
			try
			{
				int id = 4;
				var result = _customerService.GetById(id);
                Console.WriteLine(result.Fullname + " " + result.Age + " " + result.Adress);
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		public void GetAllByAge()
		{
			int age = 21;
			foreach (var item in _customerService.GetAllByAge(age))
			{
                Console.WriteLine(item.Fullname + " " + item.Age + " " + item.Adress);
            }
		}
		public void GetAllCountOfDatas()
		{
			Console.WriteLine(_customerService.GetCount());
		}
		public void OrderByAge()
		{
			Console.WriteLine("Choose type of order:\n1.Ascending\n2.Descending");
			Start: int digit = int.Parse(Console.ReadLine());
            var result = _customerService.OrderByAge(digit);
			if (result == null)
			{
				Console.WriteLine("Choose right option"); goto Start;
			}
			foreach (var item in result)
			{
				Console.WriteLine(item.Fullname+ " " +item.Age);
			}
		}
	}
}

