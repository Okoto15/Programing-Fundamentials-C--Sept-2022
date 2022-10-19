using System;
using System.ComponentModel;
using System.Net.Security;
using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        int personsAge = int.Parse(Console.ReadLine());

        if (personsAge >= 0 && personsAge <= 2)
        {
            Console.WriteLine("baby");
        }
        else if (personsAge > 2 && personsAge <= 13)
        {
            Console.WriteLine("child");
        }
        else if (personsAge > 13 && personsAge <= 19)
        {
            Console.WriteLine("teenager");
        }
        else if (personsAge > 19 && personsAge <= 65)
        {
            Console.WriteLine("adult");
        }
        else if (personsAge >= 66)
        {
            Console.WriteLine("elder");
        }
    }
}