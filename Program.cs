using System;
using Bootcamp_GFT.src.Entities;

namespace Bootcamp_GFT
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            
        }
    }
}
