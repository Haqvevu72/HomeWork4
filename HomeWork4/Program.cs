// See https://aka.ms/new-console-template for more information
using HomeWork4.Contexts;
using HomeWork4.Entities;

Console.WriteLine("Hello, World!");
using LibraryDb libraryDb = new LibraryDb();

libraryDb.Authors.Add(new Author() { FirstName = "Elgun", LastName = "Haqverdiyev" });