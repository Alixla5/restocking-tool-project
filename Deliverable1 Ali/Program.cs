using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the restocking tool.");
     
        int sodaStock = 100;
        int chipsStock = 40;
        int candyStock = 60;

        int sodaRestockValue = 40;
        int chipsRestockValue = 20;
        int candyRestockValue = 40;
       

       
        Console.Write("How many sodas have been sold today? 100 are in stock ");
        int sodasSold = int.Parse(Console.ReadLine());

        
        if (sodasSold <= sodaStock)
        {
            sodaStock -= sodasSold;
            Console.WriteLine($"There are {sodaStock} Sodas left");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }

        Console.Write("How many chips have been sold today? 40 are in stock ");
       
        
        int chipsSold = int.Parse(Console.ReadLine());
        if (chipsSold <= chipsStock)
        {
            chipsStock -= chipsSold;
            Console.WriteLine($"There are {chipsStock} Chips left");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        Console.Write("How many candies have been sold today? 60 are in stock ");
        int candiesSold = int.Parse(Console.ReadLine());

        if (candiesSold <= candyStock)
        {
            candyStock -= candiesSold;
            Console.WriteLine($"There are {candyStock} Candies left");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }

        if (sodaStock <= sodaRestockValue)
        {
            Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.\n\nSoda needs to be restocked");

        }

        if (chipsStock <= chipsRestockValue)
        {
            Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.\n\nChips needs to be restocked");
        }

        if (candyStock <= candyRestockValue)
        {
            Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.\n\nCandy needs to be restocked");
        }
        Console.WriteLine("Goodbye!");
    }
}
