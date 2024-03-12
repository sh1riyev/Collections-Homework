using System;
namespace Exceptions_Homework.Helpers.Exceptions
{
	public class CustomEmailOrPasswordWrong :Exception
	{
		public CustomEmailOrPasswordWrong(string text) : base(text)
		{
		}
	}
}

