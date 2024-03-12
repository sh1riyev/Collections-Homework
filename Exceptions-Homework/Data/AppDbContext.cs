using System;
using Exceptions_Homework.Models;

namespace Exceptions_Homework.Data
{
	public class AppDbContext
	{
		public static List<Customer> customers;
		 static AppDbContext()
		{
            customers = new List<Customer>
            {
                new Customer
                {
                    Id=1,
                    Fullname="Ilqar Shiriyev",
                    Adress="Bayil",
                    Age=26
                },
                new Customer
                {
                    Id=2,
                    Fullname="Orxan Aliyev",
                    Adress="Sahil",
                    Age=21
                },
                new Customer
                {
                    Id=3,
                    Fullname="Nigar Abishova",
                    Adress="Narimanov",
                    Age=36
                },
                  new Customer
                {
                    Id=4,
                    Fullname="Cingiz Osmanov",
                    Adress="Masazir",
                    Age=17
                },
                  new Customer
                {
                    Id=5,
                    Fullname="Elmir Suleymanov",
                    Adress="Bakixanov",
                    Age=30
                },
            };
            
		}
	}
}

