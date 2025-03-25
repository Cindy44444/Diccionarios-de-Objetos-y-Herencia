using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_de_Objetos_y_Herencia
{
    public enum Menu
    {
        AgregarCoche=1,AgregarMoto, MostrarAutos,MostrarMotos, ActualizarCoche,ActualizarMoto, EliminarCoche,EliminarMoto
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
                    case Menu.MostrarAutos:
                        controller.MostrarCoche();
                        break;
                    case Menu.MostrarMotos:
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
            Console.WriteLine("1)Agregar Coche:");
            Console.WriteLine("2)Agregar Moto:");
            Console.WriteLine("3)Mostrar autos");
            Console.WriteLine("4Mostrar motos");
            Console.WriteLine("5)Modificar Coche:");
            Console.WriteLine("6)Modificar Moto:");
            Console.WriteLine("7)Eliminar Coche:");
            Console.WriteLine("8)Eliminar Moto:");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }

}
