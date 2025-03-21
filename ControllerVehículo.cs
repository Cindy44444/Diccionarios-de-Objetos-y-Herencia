using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_de_Objetos_y_Herencia
{
    internal class ControllerVehículo
    {
        Dictionary<int, VehículoAuto> diccionarioCoche = new Dictionary<int, VehículoAuto>();
        Dictionary<int, VehículoMotos> diccionarioMotos = new Dictionary<int, VehículoMotos>();
        VehículoAuto vau = new VehículoAuto();
        VehículoMotos vmo = new VehículoMotos();

        public void AddAuto()
        {
            Console.WriteLine("Dame matricula");
            int iD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame id");
            vau.ID = Convert.ToInt32(Console.ReadLine());
            vau.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame Marca");
            vau.Marca = Console.ReadLine();
            Console.WriteLine("Dame Modelo");
            vau.Modelo = Console.ReadLine();
            Console.WriteLine("Dame Año");
            vau.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame Número de puertas");
            vau.Numpuertas= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame color");
            vau.Color = Console.ReadLine();
           

            diccionarioCoche.Add(iD, new VehículoAuto(vau.ID,vau.Marca,vau.Modelo,vau.Año,vau.Numpuertas,vau.Color));
        }
        public void AddMoto()
        {
            Console.WriteLine("Dame matricula");
            int iD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame ID");
            vmo.ID = Convert.ToInt32(Console.ReadLine());
            vmo.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame Marca");
            vmo.Marca = Console.ReadLine();
            Console.WriteLine("Dame Modelo");
            vmo.Modelo = Console.ReadLine();
            Console.WriteLine("Dame Año");
            vmo.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame Escape");
            vmo.Escape = Console.ReadLine();
            Console.WriteLine("Dame Motor");
            vmo.Motor = Console.ReadLine();

            diccionarioMotos.Add(iD, new VehículoMotos(vmo.ID, vmo.Marca, vmo.Modelo, vmo.Año, vmo.Escape, vmo.Motor));

        }
        public void MostrarCoche()
        {
            foreach (var coch in diccionarioCoche)
            {
                Console.WriteLine($"ID:{coch.Value.ID}");
                Console.WriteLine($"Marca:{coch.Value.Marca}");
                Console.WriteLine($"Modelo:{coch.Value.Año}");
                Console.WriteLine($"Número de puertas:{coch.Value.Numpuertas}");
                Console.WriteLine($"Color:{coch.Value.Color}");
            }
        }

    }
}
