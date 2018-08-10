using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;

namespace Core.View
{
    public interface IDiccionario
    {
        void MensajeDiccionario(string Mensaje, int tipo);
        //Inicio de sesion
        CDiccionario DiccionarioObj { set; get; }
        
        DataSet DatosDT { set;  }

    }
}
