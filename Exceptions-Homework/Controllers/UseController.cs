using System;
using Exceptions_Homework.Helpers.Exceptions;
using Exceptions_Homework.Services;

namespace Exceptions_Homework.Controllers
{
	public class UseController
	{
		private readonly UserService _userService;
		internal UseController()
		{
			_userService = new();
		}

		public void Login()
		{
			Console.WriteLine("Enter email");
			string email = Console.ReadLine();
			Console.WriteLine("Enter password");
			string password = Console.ReadLine();

            var length = _userService.CheckEmailLength(password);
            var result = _userService.Login(_userService.GetAll(), email, password);
			try
			{
                if (length < 6)
                {
                    throw new CustomPasswordLengthException("Password is short");
                }
                if (result == null)
                {
                    throw new CustomEmailOrPasswordWrong("Email or Password is wrong.Acces denied");
                }
				Console.WriteLine("Login succesful");
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}
	}
}

