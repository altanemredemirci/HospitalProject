using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Register : Form
    {
        DatabaseContext db;
        public Register()
        {
            InitializeComponent();
            db = new DatabaseContext();
            SehirDoldur();

        }

        private void SehirDoldur()
        {
            var iller = db.Ils.ToList();

            cmb_sehir.DataSource = iller;
            cmb_sehir.DisplayMember = "Isim";
            cmb_sehir.ValueMember = "Id";
        }

        private void IlceDoldur(int Ilid)
        {
            var ilceler = db.Ilces.Where(i => i.IlId == Ilid).ToList();

            cmb_ilce.DataSource = ilceler;
            cmb_ilce.DisplayMember = "Isim";
            cmb_ilce.ValueMember = "Id";
        }

        private void cmb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Il)cmb_sehir.SelectedItem).Id;

            IlceDoldur(id);
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            Hasta hasta = db.Hastas.FirstOrDefault(i => i.TC == txt_tc.Text);


            if (hasta != null) 
            {
                MessageBox.Show("Kayıtlı TC!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                hasta = new Hasta()
                {
                    Isim = txt_isim.Text,
                    TC = txt_tc.Text,
                    Telefon = txt_telefon.Text,
                    Kangrubu = txt_kangrubu.Text,
                    Sifre = txt_pass.Text,
                    Boy = Convert.ToInt32(nmr_boy.Value),
                    Kilo = Convert.ToInt32(nmr_kilo.Value),
                    IlceId = Convert.ToInt32(cmb_ilce.SelectedValue),
                    TakipliMi = "0"
                };

                db.Hastas.Add(hasta);
                db.SaveChanges();

                MessageBox.Show("Kayıt Başarılı");
                this.Hide();
                Form1 login = new Form1();
                login.Show();
            }          
        }
    }
}
