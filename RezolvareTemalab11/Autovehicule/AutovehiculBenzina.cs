using System;
using RezolvareTemalab11.Autovehicule.Interfete;

namespace RezolvareTemalab11.Autovehicule
{
    class AutovehiculBenzina  :Autovehicul, IBenzina
    {
        public AutovehiculBenzina(string name):base(name)
        {
        }

        public void IncarcaBenzina(int litri)
        {
            Console.WriteLine($"Am alimentat {litri}l benzina");
        }
    }
}
