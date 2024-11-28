using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Randevu
    {
        public int Id { get; set; }

        public int IlceId { get; set; }
        public Ilce Ilce { get; set; }
              

        public int KlinikId { get; set; }
        public Klinik Klinik { get; set; }

        public int DoktorId { get; set; }
        public Doktor Doktor  { get; set; }

        public int HastaId { get; set; }
        public Hasta Hasta{ get; set; }


        private string RandevuTarihi { get; set; }

        private string RandevuSaati { get; set; }


        public string _RandevuTarihi 
        {
            get
            {
                return RandevuTarihi;
            }
            set
            {
                RandevuTarihi = value.ToString().Split(' ')[0];
            } 
        }

        public string _RandevuSaati
        {
            get
            {
                return RandevuSaati;
            }
            set
            {
                RandevuSaati = value.ToString().Split(' ')[1];
            }
        }

    }
}
