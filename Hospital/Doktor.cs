using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Doktor
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Brans { get; set; }
        public string Unvan { get; set; }

        public int KlinikID { get; set; }
        public Klinik Klinik { get; set; }

        public List<Randevu> Randevus { get; set; }
    }
}
