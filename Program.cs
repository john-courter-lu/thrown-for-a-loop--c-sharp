// See https://aka.ms/new-console-template for more information
string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";
Console.WriteLine(greeting);
Console.WriteLine("Please enter a product name: ");

string response = Console.ReadLine(); 
/* 这一行, 很关键, ReadLine是阅读用户的input(在hit enter之前) */
Console.WriteLine($"You chose: {response}");

Console.WriteLine(@$"You chose: {response}. 
Thank you for your input!");
/* 这一行, string interpolation */

// comments