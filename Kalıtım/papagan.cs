using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class papagan:Kuslar // burada kuslar sınıfını kalıtımını aldık. Kuslar sınıfının özelliklerini de almak için 
    {
        public string isim;
        public string renk;

        // Sescikar metodunu ezdik aşağıda 
        public override string Sescikar() // yani burada demek istediğimiz kuşlae sınıfındaki Sescikar metodunu çağır ama ben oradaki ses çıkar metodunun içindeki özelliği kullanmıycam.

        {
            return "cik cik";
        }

    }
}
