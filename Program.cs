using System;
using Poor_Man_Pokemon.Data;


DisplayMenu();

void DisplayMenu()
{
    while (true)
    {
        Console.WriteLine(@"Welcome to Poor Man Pokemon! A text-based adventure awaits you!
a.) Battle!
b.) Catch Pokemon!
c.) Exit");

        string userMenuChoice = Console.ReadLine().Trim().ToLower();

        if (userMenuChoice == "a")
        {
            Console.WriteLine("Let's Battle!");
            ChoosePokemonForBattle();
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

void ChoosePokemonForBattle()
{
    Console.WriteLine("Choose your Pokémon for battle:");
    
    // Loop through the Pokedex list and display each Pokémon
    foreach (var pokemon in PokemonSampleData.Pokedex)
    {
        Console.WriteLine($"ID: {pokemon.ID} - Name: {pokemon.Name} - Type: {pokemon.Type} - HP: {pokemon.HP}");
    }

    Console.WriteLine("Enter the ID of the Pokémon you would like to choose:");
    if (int.TryParse(Console.ReadLine(), out int chosenId))
    {
        var chosenPokemon = PokemonSampleData.Pokedex.Find(p => p.ID == chosenId);
        if (chosenPokemon != null)
        {
            Console.WriteLine($"You chose {chosenPokemon.Name}!");
            // Further logic for starting the battle or assigning the chosen Pokémon can be added here
        }
        else
        {
            Console.WriteLine("Invalid ID. Please select a valid Pokémon ID.");
            ChoosePokemonForBattle();  // Retry if the user entered an invalid ID
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid Pokémon ID.");
        ChoosePokemonForBattle();  // Retry if the input was not a number
    }
}
