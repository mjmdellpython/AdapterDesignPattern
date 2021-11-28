using System;
using design_Pattern.Interfaces;

namespace design_Pattern.Services
{
    public class AdvanceAudiTest : IAdvanceTest
    {
        public AdvanceAudiTest()
        {
            Audi();
        }
        public void Audi()
        {
            Console.WriteLine("Audi");
        }

        public void Bmw()
        {
            
        }
    }

    public class AdvanceBmwTest : IAdvanceTest
    {
        public AdvanceBmwTest()
        {
            Bmw();
        }
        public void Audi()
        {
            
        }

        public void Bmw()
        {
            Console.WriteLine("Bmw");
        }
    }
}