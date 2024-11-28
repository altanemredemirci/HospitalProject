using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Hasta
    {
        public int Id { get; set; }

        [StringLength(20,ErrorMessage ="Max 20 karakter girilebilir")] //Attribute
        public string Isim { get; set; }

        [MaxLength(11)]
        [MinLength(11)]
        public string TC { get; set; }
        public string Telefon { get; set; }
        public string Kangrubu { get; set; }
        public int Boy { get; set; }
        public int Kilo { get; set; }
        public int IlceId { get; set; }
        public Ilce Ilce { get; set; }
        public string TakipliMi { get; set; }

        public List<Randevu> Randevus { get; set; }
    }
}
