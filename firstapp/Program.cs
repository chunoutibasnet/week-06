﻿
class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Customer(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer(101, "First Customer");
        Customer customer2 = new Customer(102, "Second Customer");

        // Access properties using proper casing
        Console.WriteLine("ID of 1st Customer: " + customer1.Id);
        Console.WriteLine("Name of 1st Customer: " + customer1.Name);

        Console.WriteLine("ID of 2nd Customer:" + customer2.Id);
        
        // adding new line to see file status (git)
      Console.WriteLine("testing changes .....")


       Console.WriteLine("testing second changes .....")

    }
}
