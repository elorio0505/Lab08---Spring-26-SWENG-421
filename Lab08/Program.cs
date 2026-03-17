using Lab08;
using System;

class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Buyer object trading Sony TV for a new Sony TV of any type with a budget of 500:");
        Buyer buyer1 = new Buyer(new TV(new SonyTV()));
        buyer1.Show();
        buyer1.Replenish(null, 500);
        buyer1.Show();

        Console.WriteLine("\nCustomer object trading current generic brand TV for a generic ultra TV with a budget of 200:");
        Customer customer1 = new Customer(new TV(new GenericTV()));
        customer1.Show();
        customer1.Replenish("Ultra TV", 200);
        customer1.Show();

    }
}