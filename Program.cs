using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_de_Objetos_y_Herencia
{
    public enum Menu
    {
        AgregarCoche=1,AgregarMoto, MostrarVehiculos, ActualizarCoche,ActualizarMoto, EliminarCoche,EliminarMoto
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ControllerVehículo controller = new ControllerVehículo();

                switch (menu())
                {
                    case Menu.AgregarCoche:
                        controller.AddAuto();
                        break;
                    case Menu.AgregarMoto:
                        controller.AddMoto();
                        break;
                    case Menu.MostrarVehiculos:
                        controller.MostrarCoche();
                        controller.MostrarMoto();
                        break;
                    case Menu.ActualizarCoche:
                        controller.ActualizarCoche();
                        break;
                    case Menu.ActualizarMoto:
                        controller.ActualizarMoto();
                        break;
                    case Menu.EliminarCoche:
                        controller.EliminarCoche();
                        break;
                    case Menu.EliminarMoto:
                        controller.EliminarMOTOS();
                        break;
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
