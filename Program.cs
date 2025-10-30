// File: Program.cs
using System;
using System.Collections.Generic;
using ProgramMaintenanceSystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Product Management System");
        Console.WriteLine();

        var book = new Book
        {
            ProductID = 1,
            Name = "C# In Depth",
            Price = 40.00m,
            Author = "Jon Skeet"
        };

        var software = new Software
        {
            ProductID = 2,
            Name = "Visual Studio",
            Price = 0.00m,
            Version = "2022",
            Platform = "Windows"
        };

        var products = new List<Product> { book, software };

        for (int i = 0; i < products.Count; i++)
        {
            var product = products[i];
            Console.WriteLine(product.GetProductInfo());
            Console.WriteLine($"The type of product {i + 1} is: {product.GetType().Name}");
        }

        var firstAsBook = products[0] as Book;
        if (firstAsBook != null)
        {
            Console.WriteLine($"Author for product 1: {firstAsBook.Author}");
        }

        var secondAsBook = products[1] as Book;
        if (secondAsBook == null)
        {
            Console.WriteLine("Casting product 2 to Book failed as expected.");
        }
    }
}