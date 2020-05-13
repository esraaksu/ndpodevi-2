using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvd_koleksiyonu
{
    class yılın_filmi
    {

        public string adi { get; set; }

        public string yönetmeni { get; set; }

        public string süresi { get; set; }

        public string konusu { get; set; }

        public string türü { get; set; }

        public string ülke { get; set; }

        public string tarih { get; set; }

        public string adigetir()
        {
            return adi;
        }
    }
}
