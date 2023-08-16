// See https://aka.ms/new-console-template for more information



string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);

Console.WriteLine("Please enter a product name: ");

string response = Console.ReadLine().Trim();
/* 这一行, 很关键, ReadLine是阅读用户的input(在hit enter之前) */
while (string.IsNullOrEmpty(response))
{
    Console.WriteLine("You didn't choose anything! Try again");
        response = Console.ReadLine().Trim();
        // 可以reassign
}

    Console.WriteLine($"You chose: {response}");



/* Console.WriteLine(@$"You chose: {response}. 
Thank you for your input!");

这一行, string interpolation */

