using System;
namespace FactoryPattern
{
	public class Desktop : IComputer
	{
        public int Price { get; set; } = 5000;

        public void ComputerDescription()
        {
            Console.WriteLine("Desktop is very handy especially when you need a larger screen.");
        }
    }
}

