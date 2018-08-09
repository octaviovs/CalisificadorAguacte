using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Steganography;

namespace Core.Procesamiento
{
    public class Histograma
    {

        public Histograma()
        {

        }



        /// <summary>
        /// Permite obtener  un arregolo de los bytes de una imgen en sus 3 niveles rgb
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public int[,] getHistograma(Bitmap bmp)
        {
            //https://stackoverflow.com/questions/33227598/how-do-i-make-an-image-histogram
            //Creamos una matriz que contendrá el histograma acumulado
            byte Rojo = 0;
            byte Verde = 0;
            byte Azul = 0;
            //Declaramos tres variables que almacenarán los colores
            int[,] matrizAcumulada = new int[3, 256];
            //Recorremos la matriz
            for (int i = 0; i <= bmp.Width - 1; i++)
            {
                for (int j = 0; j <= bmp.Height - 1; j++)
                {
                    //Asignamos el color
                    Rojo = bmp.GetPixel(i, j).R;
                    Verde = bmp.GetPixel(i, j).G;
                    Azul = bmp.GetPixel(i, j).B;
                    //ACumulamos los valores. 
                    matrizAcumulada[0, Rojo] += 1;
                    matrizAcumulada[1, Verde] += 1;
                    matrizAcumulada[2, Azul] += 1;
                }
            }

            return matrizAcumulada;
        }

        public int[] Generico(Bitmap bmp)
        {
            byte[] bytes;
            bytes = SteganographyHelper.imageToByteArray(bmp);
            int[] numeros = new int[256];

            //en este ciclo agrego la cantidad de btyes a las series
            for (int i = 0; i < bytes.Length; i++)
            {
                int x = (int)bytes[i];
                numeros[x] += 1;
            }


            return numeros;

        }
        public int[] histogramaGenerico(Bitmap bmp)
        {
            byte[] bytes = ImageToByte(bmp);
            int[] numeros = new int[256];
            //en este ciclo agrego la cantidad de btyes a las series
            for (int i = 0; i < bytes.Length; i++)
                numeros[(int)bytes[i]] += 1;
            return numeros;
        }

        /// <summary>
        /// Imgen a bytes
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        private byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        /// <summary>
        /// Retorna una arreglo en 4 posiciones con los niveles de insidcenai de un vector
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public int[] GetRangoColor(int[] values)
        {
            int[] datos = new int[4];
            for (int i = 0; i < values.Length; i++)
            {
                try
                {
                    if (i < 64)
                    {
                        datos[0] += values[i];

                    }
                    if (i > 63 && i < 128)
                    {
                        datos[1] += values[i];
                    }
                    if (i > 127 && i < 192)
                    {
                        datos[2] += values[i];
                    }
                    if (i > 191 && i < 256)
                    {
                        datos[3] += values[i];
                    }
                }
                catch (Exception)
                {


                }
            }
            return datos;
        }
        /// <summary>
        /// Obtiene el porcentaje de un rango de color(histograma)
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public int[] GetPorcentajesColor(int[] values)
        {
            long total = 0L;
            int[] datos = new int[4];
            for (int i = 0; i < values.Length; i++)
            {
                total += values[i];
                if (i < 64)
                {
                    datos[0] += values[i];
                }
                if (i > 63 && i < 128)
                {
                    datos[1] += values[i];
                }
                if (i > 127 && i < 192)
                {
                    datos[2] += values[i];
                }
                if (i > 191 && i < 256)
                {
                    datos[3] += values[i];
                }
            }

           datos[0] =(int)( ((datos[0] * 100) / total));
           datos[1] =(int)( ((datos[1] * 100) / total));
            datos[2] = (int)(((datos[2] * 100) / total));
            datos[3] = (int)(((datos[3] * 100) / total));


            return datos;
        }
    }
}
