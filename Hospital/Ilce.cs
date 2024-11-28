using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Ilce
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        
        //Mapping -> Nesnelerin İlişkileri - Relational
        public int IlId { get; set; } 
        public Il Il { get; set; }

        public List<Hastahane> Hastahanes { get; set; }

        //Her ilçe mutlaka 1 İl'e aittir. Bu IlId özelliği ilçe kaydederken varolan bir IlId değeri girilip girilmediğini kontrol edecek. Böylece var olmayan bir Şehre ilçe eklenmeyecek.

    }
}
