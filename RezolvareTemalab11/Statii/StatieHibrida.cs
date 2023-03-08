using RezolvareTemalab11.Autovehicule.Interfete;
using System;

namespace RezolvareTemalab11.Statii
{
    class StatieHibrida : StatieClasica
    {
        public void AlimenteazaElectric(IElectric autovehiculElectric, int cantitate)
        {
            Console.WriteLine($"Alimentam cu diesel autovehiculul {autovehiculElectric}");
            autovehiculElectric.IncarcaElectric(cantitate);
        }
    }
}
