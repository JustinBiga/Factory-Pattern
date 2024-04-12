using System;
namespace FactoryPattern
{
	public class Laptop : IComputer 
	{
        public int Price { get; set; } = 2000;

        public void ComputerDescription()
        {
            Console.WriteLine("Laptop is very easy to travel with. you won't miss your work.");
        }
       
    }
}

