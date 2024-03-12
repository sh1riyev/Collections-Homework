using System;
using Exceptions_Homework.Helpers.Exceptions;
using Exceptions_Homework.Services;

namespace Exceptions_Homework.Controllers
{
	public class MathController
	{
        private readonly MathService _mathService;
        internal MathController()
        {
            _mathService = new MathService();
        }

        public void FactorialOfNumber()
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
           var result= _mathService.FactorialOfNumber(number);
            try
            {
                if (number == 0)
                {
                    Console.WriteLine("Cannot find factorial of 0");
                    return;
                }
                if (number < 0)
                {
                    throw new CustomNegativeException("Added number cannot be negative");
                }
                Console.WriteLine($"Result:{result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

