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
    public partial class RandevuForm : Form
    {
        DatabaseContext db;
        public RandevuForm()
        {
            db = new DatabaseContext();
            InitializeComponent();
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

        private void HastaneDoldur(int Ilceid)
        {
            var hastahaneler = db.Hastahanes.Where(i => i.IlceId == Ilceid).ToList();

            cmb_hastane.DataSource = hastahaneler;
            cmb_hastane.DisplayMember = "Isim";
            cmb_hastane.ValueMember = "Id";
        }

        private void KlinikDoldur(int Hastaneid)
        {
            var klinikler = db.Kliniks.Where(i => i.HastahaneId == Hastaneid).ToList();

            cmb_klinik.DataSource = klinikler;
            cmb_klinik.DisplayMember = "Isim";
            cmb_klinik.ValueMember = "Id";
        }

        private void DoktorDoldur(int Klinikid)
        {
            var doktorlar = db.Doktors.Where(i => i.KlinikID == Klinikid).ToList();

            cmb_doktor.DataSource = doktorlar;
            cmb_doktor.DisplayMember = "Isim";
            cmb_doktor.ValueMember = "Id";
        }

        private void cmb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Il)cmb_sehir.SelectedItem).Id;

            IlceDoldur(id);

        }

        private void cmb_ilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Ilce)cmb_ilce.SelectedItem).Id;

            HastaneDoldur(id);
        }

        private void cmb_hastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Hastahane)cmb_hastane.SelectedItem).Id;

            KlinikDoldur(id);
        }

        private void cmb_klinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Klinik)cmb_klinik.SelectedItem).Id;

            DoktorDoldur(id);
        }

        private void dt_tarih_ValueChanged(object sender, EventArgs e)
        {
            if (cmb_sehir.Text != "" && cmb_ilce.Text != "" && cmb_hastane.Text != "" && cmb_klinik.Text != "" && cmb_doktor.Text != "")
            {
                grp_randevuSaati.Visible = true;

                var randevuSaatleri = db.Randevus.Where(i => i._RandevuTarihi == dt_tarih.Text).Select(i => i._RandevuSaati);

                foreach (RadioButton rd in grp_randevuSaati.Controls)
                {
                    if (randevuSaatleri.Contains(rd.Text))
                    {
                        rd.Enabled = false;
                    }
                }

            }
            else
            {
                MessageBox.Show("Bütün alanları doldurunuz");
            }


        }

        private void btn_randevuKayit_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
