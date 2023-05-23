using System;

namespace SimpleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            char userChoice;

            Console.WriteLine("Please choose one of the following options");
            Console.WriteLine("1 - Cappucino");
            Console.WriteLine("2 - Latte");
            Console.WriteLine("3 - Americano");
            Console.WriteLine("4 - Mocha");
            Console.WriteLine("5 - Macchiato");
            Console.WriteLine("6 - Espresso");
            Console.WriteLine("Q - Quit the program");

            do
            {
                userChoice = char.ToLower(Console.ReadKey(true).KeyChar);
                Console.WriteLine("You chose " + userChoice);

                switch (userChoice)
                {
                    case '1':
                        Console.WriteLine("Making cappucino");
                        Console.WriteLine("Steaming milk");
                        Console.WriteLine("Frothing milk");
                        Console.WriteLine("Brewing espresso shot");
                        Console.WriteLine("Adding milk to espresso");
                        break;
                    case '2':
                        Console.WriteLine("Making latte");
                        Console.WriteLine("Brewing espresso shot");
                        Console.WriteLine("Steaming milk");
                        Console.WriteLine("Adding milk to espresso");
                        break;
                    case '3':
                        Console.WriteLine("Making Americano");
                        Console.WriteLine("Steaming water");
                        Console.WriteLine("Brewing espresso shot");
                        Console.WriteLine("Adding espresso to water");
                        break;
                      case '4':
                        Console.WriteLine("Making mocha");
                        Console.WriteLine("Steaming milk");
                        Console.WriteLine("Brewing espresso shot");
                        Console.WriteLine("Adding chocolate syrup to cup");
                        Console.WriteLine("Adding espresso and milk to cup");
                        break;
                    case '5':
                        Console.WriteLine("Making macchiato");
                        Console.WriteLine("Steaming milk");
                        Console.WriteLine("Brewing espresso shot");
                        Console.WriteLine("Adding espresso to milk");
                        break;
                    case '6':
                        Console.WriteLine("Making espresso");
                        Console.WriteLine("Brewing espresso shot");
                        break;
                    default:
                        Console.WriteLine("Returning coins");
                        continue;
                }

                Console.WriteLine("Dispensing beverage.");
                Console.WriteLine("Have a nice day!");
            } while (!userChoice.Equals('q'));
    }
}