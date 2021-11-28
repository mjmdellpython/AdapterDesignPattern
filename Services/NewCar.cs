using design_Pattern.Adapter;
using design_Pattern.Interfaces;
using System;

namespace design_Pattern.Services
{
    
    public class NewCar : INewCars
    {
        AdapterCars Ac;
        public NewCar(string str)
        {
            if(str.Equals("Tesla"))
            {
                Tesla();
            }
            else if(str.Equals("Audi") || str.Equals("Bmw"))
            {
                Ac = new AdapterCars(str);
            }
            else
            {
                Console.WriteLine("the car is not supported !");
            }
            
        }
        public void Tesla()
        {
            Console.WriteLine("Tesla");
        }
    }
}