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
    public partial class DoktorProfil : Form
    {

        DatabaseContext db;
        public DoktorProfil()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToShortDateString();
            db = new DatabaseContext();
        }

        private void DoktorProfil_Load(object sender, EventArgs e)
        {
            var randevular = db.Randevus
                .Include(i=> i.Hasta)
                .Include(i=> i.Doktor)
                .Where(d => d.Id == Form1.DoktorId).ToList();

            foreach (var item in randevular)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Id.ToString();
                lvi.SubItems.Add(item.Doktor.Isim);
                lvi.SubItems.Add(item._RandevuSaati);
                lvi.SubItems.Add(item.Hasta.Isim);

                lst_doktorRandevu.Items.Add(lvi);
            }

            
        }
    }
}
