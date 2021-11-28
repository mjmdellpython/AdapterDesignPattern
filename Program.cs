using System;
using design_Pattern.Services;

namespace design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NewCar nc;

            

            nc = new NewCar("Toyta");
            nc = new NewCar("Bmw");
            nc = new NewCar("Vw");
            nc = new NewCar("Audi");
            nc = new NewCar("Tesla");
        }
    }
}
