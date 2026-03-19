using Lab08;
using System;

class Program {
    static void Main(string[] args)
    {
        Buyer b = new Buyer(new TV(new SonyTV()));
        Customer c = new Customer(new TV(new LGTV()));

        Console.WriteLine("BUYER Initial TV:");
        b.Show();

        Console.WriteLine("1. Type: TV, budget: 500"); //remain TV and high budget
        b.Replenish("TV", 500);
        b.Show();

        Console.WriteLine("2. Type: null, budget: 400"); //null type and medium budget
        b.Replenish(null, 400);
        b.Show();

        Console.WriteLine("3. Type: UltraHD_TV, budget: 500"); //request type and high budget
        b.Replenish("UltraHD_TV", 500);
        b.Show();

        Console.WriteLine("4. Type: null, budget: 100"); //null type and low budget test
        b.Replenish(null, 100);
        b.Show();

        Console.WriteLine("\nCUSTOMER Intital TV:");
        c.Show();

        Console.WriteLine("1. Type: Smart_TY, budget: 360"); //request type and high budget
        c.Replenish("Smart_TV", 360);
        c.Show();

        Console.WriteLine("2. Type: UltraHD_TV, budget: 300:"); //request type and low budget
        c.Replenish("UltraHD_TV", 300);
        c.Show();

        Console.WriteLine("3. Type: UltraHD_TV, budget: 450"); //request type and exact budget
        c.Replenish("UltraHD_TV", 450);
        c.Show();

        Console.WriteLine("4. Type: null, budget: 380:"); //null type and medium budget
        c.Replenish(null, 380);
        c.Show();

    }
}