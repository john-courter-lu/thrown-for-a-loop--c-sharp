// See https://aka.ms/new-console-template for more information



string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Football",
        Price = 15,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12,
        Sold = false,
        StockDate = new DateTime(2022, 12, 21),
        ManufactureYear = 2011
    }
};

Console.WriteLine("Products:");

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}

Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim());
/* 这一行, 很关键, ReadLine是阅读用户的input(在hit enter之前) */
// int.Parse是把string转为int

while (response > products.Count || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
    // 可以reassign
}

Product chosenProduct = products[response - 1];

DateTime now = DateTime.Now;

TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");



/* Console.WriteLine(@$"You chose: {response}. 
Thank you for your input!");

这一行, string interpolation */

