using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_de_Objetos_y_Herencia
{
    public enum Menu
    {
        AgregarCoche=1,AgregarMoto, MostrarCoche,MostrarMoto, ActualizarCoche,ActualizarMoto, EliminarCoche,EliminarMoto
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                switch(Menu())
                {

                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("Agregar Coche:");
            Console.WriteLine("Agregar Moto:");
            Console.WriteLine("Mostrar vehículos");
            Console.WriteLine("Modificar Coche:");
            Console.WriteLine("Modificar Moto:");
            Console.WriteLine("Eliminar Coche:");
            Console.WriteLine("Eliminar Moto:");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
    
}
