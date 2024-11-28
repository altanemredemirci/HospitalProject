using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Klinik
    {
        public int Id { get; set; }
        public string Isim { get; set; }

        public int HastahaneId { get; set; }
        public Hastahane Hastahane { get; set; }

        public List<Randevu> Randevus { get; set; }
        public List<Doktor> Doktors { get; set; }
    }
}
