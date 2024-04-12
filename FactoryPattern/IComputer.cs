using System;
namespace FactoryPattern
{
	public interface IComputer
	{
		public int Price { get; set; }

		void ComputerDescription();
    }
}

