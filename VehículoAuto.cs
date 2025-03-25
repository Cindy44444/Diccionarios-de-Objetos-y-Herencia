using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_de_Objetos_y_Herencia
{
    internal class VehículoAuto : BaseVehículo
    {
        public VehículoAuto() { }
        public VehículoAuto(int iD, string marca, string modelo, int año,int numpuertas, string color)
        : base(iD,marca,modelo,año)
        {
            Numpuertas = numpuertas;
            Color = color;
        }

        public int Numpuertas {  get; set; }
        public string Color {  get; set; }
    }
}
