using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Procesamiento;
namespace FrutasVerduras.Controles
{
    public partial class histograma : UserControl
    {
        Histograma miHistograma;
        public histograma()
        {
            InitializeComponent();
            miHistograma = new Histograma();

            Bitmap bmp = new Bitmap(pictureBox1.Image);

            miHistograma.setHistograma(bmp);

            miHistograma.matriz = miHistograma.matriz;
           
        }
    }
}
