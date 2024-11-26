using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Il
    {
        //EF ID,Id,id,iD vb kelimeyi gördüğünde bu özelliği direk olarak PK ve Identity özelliklerini atar.
        public int Id { get; set; }
        public string Isim { get; set; }

        public List<Ilce> Ilces { get; set; }

        //Bir şehrin altında birden fazla ilçe olur.

        //Böylece Il Ilce arasında OneToMany(Bire çok ilişki) kurduk.
    }
}
