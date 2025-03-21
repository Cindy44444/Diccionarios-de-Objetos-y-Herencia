using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_de_Objetos_y_Herencia
{
    internal class BaseVehículo
    {
        public BaseVehículo() { }
        public BaseVehículo(int iD, string marca, string modelo, int año)
        {
            ID = iD;
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public int ID {  get; set; }
        public string Marca { get; set; } 
        public string Modelo { get; set; }
        public int Año { get; set; }

    }
}
