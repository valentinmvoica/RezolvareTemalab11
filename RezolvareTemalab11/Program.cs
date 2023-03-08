using RezolvareTemalab11.Autovehicule;
using RezolvareTemalab11.Statii;
using System;

namespace RezolvareTemalab11
{
    class Program
    {
        static void Main(string[] args)
        {
            var mazda = new AutovehiculBenzina("mazda cx5");
            var audi = new AutovehiculDiesel("audi butoias");
            var bmw = new AutovehiculGPL("x5");
            var dacia = new AutovehiculElectric("dacia spring");
            var toyota = new AutovehiculHibrid("toyota prius");

            var statieClasica = new StatieClasica();
            var statieHibrida = new StatieHibrida();

            statieClasica.AlimenteazaGPL(bmw, 5);
            statieClasica.AlimenteazaDiesel(audi, 50);
            statieClasica.AlimenteazaBenzina(mazda, 45);
            statieClasica.AlimenteazaBenzina(toyota, 30);

            statieHibrida.AlimenteazaElectric(toyota, 500);
            statieHibrida.AlimenteazaElectric(dacia, 100);

            var camion1 = new Camion("camion1");

            statieClasica.AlimenteazaDiesel(camion1, 500);
            statieClasica.AlimenteazaDiesel(camion1.Cisterna, 5000);
            statieClasica.AlimenteazaBenzina(camion1.Cisterna, 5000);

            var camion2 = new Camion("camion2");
            statieHibrida.AlimenteazaBenzina(camion2.Cisterna,1000);

            camion1.Cisterna.AlimenteazaDiesel(camion2,500);
            camion1.Cisterna.AlimenteazaBenzina(mazda, 500);
            var camion3 = new Camion("camion3");

            camion1.Cisterna.AlimenteazaDiesel(camion1.Cisterna,1000);

        }
    }
}
