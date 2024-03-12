using Exceptions_Homework.Services.Interface;

namespace Exceptions_Homework.Services
{
	public class MathService : IMathService
	{
		public int FactorialOfNumber(int number)
		{
			int result = 1;
			for (int i = 1; i <= number; i++)
			{
				result *= i;
			}
			return result;
		}
	}
}

