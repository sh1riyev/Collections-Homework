using System;
namespace Exceptions_Homework.Helpers.Exceptions
{
	public class CustomNegativeException:Exception
	{
		public CustomNegativeException (string text):base(text)
		{
		}
	}
}

