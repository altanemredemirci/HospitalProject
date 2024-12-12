using Microsoft.EntityFrameworkCore;
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
    public partial class HastaProfil : Form
    {
        DatabaseContext db;
        Hasta hasta = new Hasta();

        public HastaProfil()
        {
            InitializeComponent();
            db = new DatabaseContext();
        }

        private void HastaProfil_Shown(object sender, EventArgs e)
        {
            hasta = db.Hastas.Find(Form1.HastaId);
            if (hasta == null)
            {
                DialogResult result = MessageBox.Show("Giriş Yapınız!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
            }

            lbl_name.Text = hasta.Isim;
            lbl_tc.Text = hasta.TC;

            dt_grid_randevu.DataSource = db.Randevus.Where(i => i.HastaId == hasta.Id).ToList();

            RandevuLoader();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lst_randevu.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(lst_randevu.SelectedItems[0].Text);

                var randevu = db.Randevus.Find(id);
                db.Randevus.Remove(randevu);
                db.SaveChanges();
                MessageBox.Show("Randevu İptal Edildi.");
                RandevuLoader();
            }
            else
            {
                MessageBox.Show("Lütfen İptal Edilecek Randevuyu Seçiniz!");
            }

        }

        private void RandevuLoader()
        {
            lst_randevu.Items.Clear();

            var Randevular = db.Randevus
                               .Include(i => i.Hasta)
                               .Include(i => i.Doktor)
                               .Include(i => i.Klinik)
                               .ThenInclude(i => i.Hastahane)
                               .Where(i => i.HastaId == hasta.Id)
                               .ToList();

            foreach (var randevu in Randevular)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = randevu.Id.ToString();
                lvi.SubItems.Add(randevu.Klinik.Hastahane.Isim);
                lvi.SubItems.Add(randevu.Klinik.Isim);
                lvi.SubItems.Add(randevu.Doktor.Isim);
                lvi.SubItems.Add(randevu._RandevuTarihi);
                lvi.SubItems.Add(randevu._RandevuSaati);

                lst_randevu.Items.Add(lvi);
            }
        }

        private void btn_randevuAl_Click(object sender, EventArgs e)
        {
            this.Hide();
            RandevuForm form = new RandevuForm();
            form.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1.HastaId = 0;
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}


