using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class Karga:Kuslar // kalıtım aldık.
    {
        public string isim;
        public string renk;

        public override string Sescikar()
        {
            return "gak gak"; // gak gak değerini döndürdük.
        }
    }
}
