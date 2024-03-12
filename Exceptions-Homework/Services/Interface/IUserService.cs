using Exceptions_Homework.Models;

namespace Exceptions_Homework.Services.Interface
{
	public interface IUserService
	{
        public User[] GetAll();
        public User Login(User[] users, string email, string password);
    }
}

