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
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame id");
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
           

            diccionarioCoche.Add(id, new VehículoAuto(vau.ID,vau.Marca,vau.Modelo,vau.Año,vau.Numpuertas,vau.Color));
        }
        public void AddMoto()
        {
            Console.WriteLine("Dame matricula");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame ID");
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

            diccionarioMotos.Add(id, new VehículoMotos(vmo.ID, vmo.Marca, vmo.Modelo, vmo.Año, vmo.Escape, vmo.Motor));

        }
        public void MostrarCoche()
        {
            foreach (var vau in diccionarioCoche)
            {
                Console.WriteLine($"ID:{vau.Value.ID}");
                Console.WriteLine($"Marca:{vau.Value.Marca}");
                Console.WriteLine($"Modelo:{vau.Value.Modelo}");
                Console.WriteLine($"Año:{vau.Value.Año}");
                Console.WriteLine($"Número de puertas:{vau.Value.Numpuertas}");
                Console.WriteLine($"Color:{vau.Value.Color}");
            }
        }
        public void MostrarMoto()
        {
            foreach(var vmo in diccionarioMotos)
            {
                Console.WriteLine($"ID:{vmo.Value.ID}");
                Console.WriteLine($"Marca:{vmo.Value.Marca}");
                Console.WriteLine($"Modelo:{vmo.Value.Modelo}");
                Console.WriteLine($"Año: {vmo.Value.Año}");
                Console.WriteLine($"Escape:{vmo.Value.Escape}");
                Console.WriteLine($"Motor: {vmo.Value.Motor}");
            }
        }
        public void EliminarCoche()
        {
            Console.WriteLine("Dame id a eliminar:");
            int id = Convert.ToInt32( Console.ReadLine());

            diccionarioCoche.Remove(id);
        }
        public void EliminarMOTOS()
        {
            Console.WriteLine("Dame id a eliminar");
            int id = Convert.ToInt32( Console.ReadLine());

            diccionarioMotos.Remove(id);
        }
        public void ActualizarCoche()
        {
            Console.WriteLine("Dame id a actualizar");
            int id = Convert.ToInt32( Console.ReadLine());
            var coche = diccionarioCoche.FirstOrDefault(x => x.Value.ID == id);

            Console.WriteLine("Dame nuevo id:");
            coche.Value.ID = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Dame marca:");
            coche.Value.Marca = Console.ReadLine();
            Console.WriteLine("Dame modelo:");
            coche.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Dame año:");
            coche.Value.Año = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Dame numero d puertas:");
            coche.Value.Numpuertas = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Dame color:");
            coche.Value.Color = Console.ReadLine();
        }
        public void ActualizarMoto()
        {
            Console.WriteLine("Dame id a actualizar:");
            int id = Convert.ToInt32(Console.ReadLine());
            var moto = diccionarioMotos.FirstOrDefault(x =>x.Value.ID == id);

            Console.WriteLine("Dame nuevo id:");
            moto.Value.ID = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Dame marca:");
            moto.Value.Marca = Console.ReadLine();
            Console.WriteLine("Dame modelo:");
            moto.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Dame año:");
            moto.Value.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame escape:");
            moto.Value.Escape = Console.ReadLine();
            Console.WriteLine("Dame motor:");
            moto.Value.Motor = Console.ReadLine();
        }

    }
}
