using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using AForge.Video;
using AForge.Video.DirectShow;


namespace Core.Model
{
    public class CCamara
    {
        private FilterInfoCollection Dispositivos; 
        private VideoCaptureDevice FuenteDeVideo; 
        public CCamara() {

        }
        public bool obtenerDispositivos(ref FilterInfoCollection ListvideoDevices)
        {
            ListvideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (ListvideoDevices.Count !=  0)
                return true;
            else
                return false;

        }



    }
}
