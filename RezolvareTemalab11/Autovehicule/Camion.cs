using RezolvareTemalab11.Autovehicule.Interfete;
using RezolvareTemalab11.Combustibili;
using System;
using System.Collections.Generic;
using System.Text;

namespace RezolvareTemalab11.Autovehicule
{
    class Camion:AutovehiculDiesel
    {
        public Camion(string nume):base(nume)
        {
            Cisterna = new Cisterna();
        }

        public Cisterna Cisterna { get; private set; }
    }
    class Cisterna : IBenzina, IDiesel
    {
        private int stoc = 0;
        private Combustibil tipCombustibilStoc = Combustibil.Benzina;

        public override string ToString()
        {
            return $"cisterna combustibil {tipCombustibilStoc}  cantitate {stoc}";
        }
        public void IncarcaBenzina(int litri)
        {
            IncarcaCombustibil(litri, Combustibil.Benzina);
        }
        public void IncarcaDiesel(int litri)
        {
            IncarcaCombustibil(litri, Combustibil.Diesel);
        }
        private void IncarcaCombustibil(int litri, Combustibil combustibilIncarcat)
        {
            if(this.tipCombustibilStoc !=combustibilIncarcat && this.stoc != 0)
            {                
                Console.WriteLine("combustibil incompatibil");
            }
            else
            {
                this.stoc += litri;
                this.tipCombustibilStoc = combustibilIncarcat;
            }
        }

        public void AlimenteazaBenzina(IBenzina autovehiculBenzina, int cantitate)
        {
            if (PoateFieAlimentat(Combustibil.Benzina, cantitate))
            {
                Console.WriteLine($"Alimentam cu benzina autovehiculul {autovehiculBenzina}");
                autovehiculBenzina.IncarcaBenzina(cantitate);
                this.stoc -= cantitate;
            }
        }
        public void AlimenteazaDiesel(IDiesel autovehiculDiesel, int cantitate)
        {
            if (PoateFieAlimentat(Combustibil.Diesel, cantitate))
            {
                Console.WriteLine($"Alimentam cu benzina autovehiculul {autovehiculDiesel}");
                autovehiculDiesel.IncarcaDiesel(cantitate);
                this.stoc -= cantitate;
            }
        }

        private bool PoateFieAlimentat(Combustibil combustibilulDorit, int cantitateaDorita)
        {
            if (this.tipCombustibilStoc != combustibilulDorit)
            {
                Console.WriteLine("Cisterna nu are combustibilul dorit in stoc. nu putem alimenta");
                return false;
            }
            if (this.stoc < cantitateaDorita)
            {
                Console.WriteLine("Cisterna nu are suficient combustibil in stoc.");
                return false;
            }
            return true;
        }
    }
}
