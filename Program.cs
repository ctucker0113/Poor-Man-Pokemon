// See https://aka.ms/new-console-template for more information

DisplayMenu();

void DisplayMenu()
{
    while (true)
    {
        Console.WriteLine(@"Welcome to Poor Man Pokemon! A text-based adventure awaits you!
a.) New Game
b.) Load Game
c.) Exit");

        string userMenuChoice = Console.ReadLine().Trim().ToLower();

        if (userMenuChoice == "a")
        {
            Console.WriteLine("You selected 'New Game'!");
        }

        else  if (userMenuChoice == "b")
        {
            Console.WriteLine("You selected 'Load Game!'");
        }

        else if (userMenuChoice == "c")
        {
            Console.WriteLine("You selected Exit! Goodbye!");
            break;
        }

        else
        {
            Console.WriteLine(userMenuChoice);
            Console.Clear();
            Console.WriteLine("Invalid Option. Please select a valid option.");
        }
    }
}