using System;
using RezolvareTemalab11.Autovehicule.Interfete;

namespace RezolvareTemalab11.Autovehicule
{
    class AutovehiculElectric : Autovehicul, IElectric
    {
        public AutovehiculElectric(string name) : base(name)
        {
        }

        public void IncarcaElectric(int kwh)
        {
            Console.WriteLine($"Am alimentat {kwh}kwh");
        }
    }
}
