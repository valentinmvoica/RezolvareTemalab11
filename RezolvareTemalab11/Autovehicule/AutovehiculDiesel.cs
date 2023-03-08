using System;
using RezolvareTemalab11.Autovehicule.Interfete;

namespace RezolvareTemalab11.Autovehicule
{
    class AutovehiculDiesel : Autovehicul, IDiesel
    {
        public AutovehiculDiesel(string name) : base(name)
        {
        }

        public void IncarcaDiesel(int litri)
        {
            Console.WriteLine($"Am alimentat {litri}l diesel");
        }
    }
}
