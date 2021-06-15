using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LGV.Business_Layer
{
    class Methods
    {
        public MemoryStream ma = new MemoryStream();
        public byte[] by;

        // Convertir en octet
        public byte[] convert_byte()
        {
            return ma.ToArray();
        }

        // Convertir l'octet en image
        public MemoryStream convert_image()
        {
            ma = new MemoryStream(by);
            return ma;
        }
    }
}
