

using design_Pattern.Interfaces;
using design_Pattern.Services;

namespace design_Pattern.Adapter
{
    public class AdapterCars
    {
        IAdvanceTest Ia;
        
        public AdapterCars(string str)
        {
            if(str.Equals("Audi"))
            {
                Ia = new AdvanceAudiTest();
                
            }
            else if(str.Equals("Bmw"))
            {
                Ia = new AdvanceBmwTest();
            }
        }
    }
}
