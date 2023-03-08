using System;
using RezolvareTemalab11.Autovehicule.Interfete;

namespace RezolvareTemalab11.Autovehicule
{
    class AutovehiculHibrid : AutovehiculBenzina, IElectric
    {
        public AutovehiculHibrid(string name) : base(name)
        {
        }      
        public void IncarcaElectric(int kwh)
        {
            Console.WriteLine($"Am alimentat {kwh}kwh");
        }
    }
}
