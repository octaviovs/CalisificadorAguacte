using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Procesamiento
{
    public class Histograma
    {

        public Histograma(){
          
        }
        public int[,] matriz;



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
        

        public int[] histogramaGenerico(Bitmap bmp)
        {
            byte[] bytes = ImageToByte(bmp);
            int[] numeros = new int[256];
            //en este ciclo agrego la cantidad de btyes a las series
            for (int i = 0; i < bytes.Length; i++)
                numeros[(int)bytes[i]] += 1;           
            return numeros;
        }

        private  byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
