using System;
using System.Linq;
using Exceptions_Homework.Models;
using Exceptions_Homework.Services.Interface;

namespace Exceptions_Homework.Services
{
	public class UserService :IUserService
	{
		public User[] GetAll()
		{
			User user1 = new()
			{
				Password = "ilqarBaki2",
				Fullname = "Ilqar Shiriyev",
				Email = "shiriyev@gmail.com",
				Age = 26
			};
			User user2 = new()
            {
                Password = "salam",
                Fullname = "Anar Aliyev",
                Email = "anar@gmail.com",
                Age = 18
            };
            User user3 = new()
            {
                Password = "Bakili!salam2",
                Fullname = "Aydan Piriyeva",
                Email = "aydan@gmail.com",
                Age = 32
            };

           User[] users = { user1, user2, user3 };
            return users;
        }

        public User Login(User[] users,string email,string password)
        {
          return users.FirstOrDefault(m => m.Email == email && m.Password == password);
         
        }
        public int CheckEmailLength(string password)
        {
            return password.Length;
        }
	}
}

