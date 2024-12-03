using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Hastahane
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        
        public int IlceId { get; set; }
        public Ilce Ilce { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public List<Klinik> Kliniks { get; set; }

    }
}
