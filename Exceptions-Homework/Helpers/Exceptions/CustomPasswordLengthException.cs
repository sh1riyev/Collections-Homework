using System;
namespace Exceptions_Homework.Helpers.Exceptions
{
	public class CustomPasswordLengthException :Exception
	{
		public CustomPasswordLengthException(string text) : base(text)
		{

		}
	}
}

