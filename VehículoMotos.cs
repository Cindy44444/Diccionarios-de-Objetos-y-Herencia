using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_de_Objetos_y_Herencia
{
    internal class VehículoMotos: BaseVehículo
    {
        public VehículoMotos() { }
        public VehículoMotos(int iD, string marca, string modelo, int año,string escape, string motor)
            :base(iD,marca,modelo, año)
        {
            Escape = escape;
            Motor = motor;
        }

        public string Escape {  get; set; }
        public string Motor {  get; set; }

    }
}
