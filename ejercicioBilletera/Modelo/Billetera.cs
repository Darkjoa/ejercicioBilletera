using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBilletera.Modelo
{
    internal class Billetera
    {
        public int Billete10 { get; set; }
        public int Billete20 { get; set; }
        public int Billete50 { get; set; }
        public int Billete100 { get; set; }
        public int Billete200 { get; set; }
        public int Billete500 { get; set; }
        public int Billete1000 { get; set; }
        
        //Metodo
        public void IngresarBilletes()
        {
            Console.WriteLine("Ingrese la cantidad de billetes de 10 en la billetera");
            Billete10 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de billetes de 20 en la billetera");
            Billete20 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de billetes de 50 en la billetera");
            Billete50 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de billetes de 100 en la billetera");
            Billete100 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de billetes de 200 en la billetera");
            Billete200 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de billetes de 500 en la billetera");
            Billete500 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de billetes de 1000 en la billetera");
            Billete1000 = int.Parse(Console.ReadLine());
        }
        public void limpiar()
        {
            Billete10 = 0;
            Billete20 = 0;
            Billete50 = 0;
            Billete100 = 0;
            Billete200 = 0;
            Billete500 = 0;
            Billete1000 = 0;
        }
        public decimal Total()
        {

            decimal sumatoria = 0;
            sumatoria += (Billete10*10)+ (Billete20*20) + (Billete50*50) + (Billete100*100)+(Billete200*200) + (Billete500*500)+ (Billete1000*1000);
            return sumatoria;
        }
        public Billetera Combinar(Billetera bil)
        {
            Billetera bil3 = new Billetera
            {
                Billete10 = 0,
                Billete20 = 0,
                Billete50 = 0,
                Billete100=0,
                Billete200=0,
                Billete500=0,
                Billete1000=0,
            };
            bil3.Billete10 = Billete10 + bil.Billete10;
            bil3.Billete20 = Billete20 + bil.Billete20;
            bil3.Billete50 = Billete50 + bil.Billete50;
            bil3.Billete100 = Billete100 + bil.Billete100;
            bil3.Billete200 = Billete200 + bil.Billete200;
            bil3.Billete500 = Billete500 + bil.Billete500;
            bil3.Billete1000 = Billete1000 + bil.Billete1000;
            bil.limpiar();
            limpiar();
            return bil3;
            
        }
        public void PresumirBilletes()
        {
            Console.WriteLine($"Cantidad billetes 10: {Billete10}");
            Console.WriteLine($"Cantidad billetes 20: {Billete20}");
            Console.WriteLine($"Cantidad billetes 50: {Billete50}");
            Console.WriteLine($"Cantidad billetes 100: {Billete100}");
            Console.WriteLine($"Cantidad billetes 200: {Billete200}");
            Console.WriteLine($"Cantidad billetes 500: {Billete500}");
            Console.WriteLine($"Cantidad billetes 1000: {Billete1000}");
        }
    }
}
