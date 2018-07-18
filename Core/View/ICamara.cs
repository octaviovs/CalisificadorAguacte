using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.View;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;

using AForge.Video;
using AForge.Video.DirectShow;
namespace Core.View
{
    public interface ICamara
    {
        void MensajeCamara(string Mensaje, int tipo);
        FilterInfoCollection videoDevices { get;set;}
        VideoCaptureDevice videoDevice { get; set; }
        Bitmap imagenProceso { get; set; }
    }
}
