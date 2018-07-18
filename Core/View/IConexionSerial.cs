using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;

namespace Core.View
{
    public interface IConexionSerial
    {
        void Mensaje(string Mensaje, int tipo);
        conexionSerial objConexion { get; set; }
        List<String> puertos {  set; }
    }
}
