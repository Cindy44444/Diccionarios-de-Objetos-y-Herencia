using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_de_Objetos_y_Herencia
{
    public enum Menu
    {
        Agregar=1, Mostrar, Actualizar, Eliminar
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    static Menu menu()
    {
        Console.WriteLine("Agregar");
        Console.WriteLine("Mostrar vehículos");
        Console.WriteLine("Modificar Vehículos");
        Console.WriteLine("Eliminar Vehículos");
        Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
        return opc;
    }
}
