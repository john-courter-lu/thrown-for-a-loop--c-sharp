// See https://aka.ms/new-console-template for more information



string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);

Console.WriteLine(@"Products:
1. Football
2. Hockey Stick
3. Boomerang
4. Frisbee
5. Golf Putter");

Console.WriteLine("Please enter a product number: ");

int response = int.Parse( Console.ReadLine().Trim());
/* 这一行, 很关键, ReadLine是阅读用户的input(在hit enter之前) */
// int.Parse是把string转为int

while (response > 5 || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
        // 可以reassign
}

    Console.WriteLine($"You chose: {response}");



/* Console.WriteLine(@$"You chose: {response}. 
Thank you for your input!");

这一行, string interpolation */

