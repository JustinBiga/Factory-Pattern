using System;
namespace FactoryPattern
{
	public class ComputerFactory
	{
        public static IComputer GetComputer(string choice)
        {
            switch (choice.ToLower())
            {
                case "desktop":
                    return new Desktop();
                case "laptop":
                    return new Laptop();
                default:
                    return new Laptop();
            }
        }
    }
}

