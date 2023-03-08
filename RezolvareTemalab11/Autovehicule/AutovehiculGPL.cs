using System;
using RezolvareTemalab11.Autovehicule.Interfete;

namespace RezolvareTemalab11.Autovehicule
{
    class AutovehiculGPL : Autovehicul, IGPL
    {
        public AutovehiculGPL(string name) : base(name)
        {
        }

        public void IncarcaGPL(int litri)
        {
            Console.WriteLine($"Am alimentat {litri}l GPL");
        }
    }
}
