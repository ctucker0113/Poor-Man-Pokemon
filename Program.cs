// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Poor Man Pokemon! A text-based adventure awaits you!");

DisplayMenu();

void DisplayMenu()
{
    while (true)
    {
        Console.WriteLine(@"Choose Your Starter Pokemon!
a.) Bulbasaur
b.) Charmander
c.) Squirtle
d.) Pikachu");

        string userMenuChoice = Console.ReadLine().Trim().ToLower();

        if (userMenuChoice == "a")
        {
            Console.WriteLine("You selected Bulbasaur!");
        }

        if (userMenuChoice == "b")
        {
            Console.WriteLine("You selected Charmander!");
        }

        if (userMenuChoice == "c")
        {
            Console.WriteLine("You selected Squirtle!");
        }

        if (userMenuChoice == "d")
        {
            Console.WriteLine("You selected Pikachu!");
        }
    }
}