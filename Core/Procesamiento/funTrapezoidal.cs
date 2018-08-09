using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Procesamiento
{
    class funTrapezoidal
    {

        public funTrapezoidal()
        {
        }

        /*
         datos(item) -> x  
         0->a
         1->b
         2->c
         3->d
             */
        public List<double> resultado(List<double> datos, List<double> parametros)
        {
            List<double> Cadena = new List<double>();
            double aux = 0;
            foreach (var item in datos)
            {
                if (item <= parametros[0])
                {
                    Cadena.Add(0);
                    goto Final;
                }

                if (parametros[0] <= item && item <= parametros[1])
                {
                    aux = (item - parametros[0]) / (parametros[1] - parametros[0]);
                    Cadena.Add(aux);
                    goto Final;
                }


                if (parametros[1] <= item && item <= parametros[2])
                {
                    Cadena.Add(1);
                    goto Final;
                }

                if (parametros[2] <= item && item <= parametros[3])
                {
                    aux = (parametros[3] - item) / (parametros[3] - parametros[2]);
                    Cadena.Add(aux);
                    goto Final;
                }
                if (parametros[3] <= item)
                {
                    Cadena.Add(0);
                    goto Final;
                }

                Final:
                aux = 0;
            }


            return Cadena;
        }
    }
}
