namespace ConsoleApp___MathGame
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you're working on improving yourself");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n"); 
            
            var isGameOn = true;
            do
            {
                Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
                Console.WriteLine("---------------------------------------------");

                var gameSelected = Console.ReadLine();
                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition selected");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction selected");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication selected");
                        break;
                    case "d":
                        engine.DivisionGame("Division selected");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Environment.Exit(0);
                        break;
                }
            } while (isGameOn);

        }
    }
}
