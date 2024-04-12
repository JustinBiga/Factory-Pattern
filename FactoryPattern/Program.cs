namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Example usage of ComputerFactory.GetComputer method
            Console.WriteLine("Please choose a computer you would like to use.");

            string userInput = Console.ReadLine();

            IComputer computer = ComputerFactory.GetComputer(userInput);
            computer.ComputerDescription();

            Console.WriteLine($"The Price of this computer is: ${computer.Price}");

        }
    }
}
