using RezolvareTemalab11.Autovehicule.Interfete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RezolvareTemalab11.Statii
{
    class StatieClasica
    {
        public void AlimenteazaBenzina(IBenzina autovehiculBenzina, int cantitate)
        {
            Console.WriteLine($"Alimentam cu benzina autovehiculul {autovehiculBenzina}");
            autovehiculBenzina.IncarcaBenzina(cantitate);
        }
        public void AlimenteazaGPL(IGPL autovehiculGPL, int cantitate)
        {
            Console.WriteLine($"Alimentam cu GPL autovehiculul {autovehiculGPL}");
            autovehiculGPL.IncarcaGPL(cantitate);
        }
        public void AlimenteazaDiesel(IDiesel autovehiculDiesel, int cantitate)
        {
            Console.WriteLine($"Alimentam cu diesel autovehiculul {autovehiculDiesel}");
            autovehiculDiesel.IncarcaDiesel(cantitate);
        }
    }
}
