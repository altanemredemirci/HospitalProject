namespace Hospital
{
    public partial class Form1 : Form
    {
        public static int HastaId = 0;
        public static int DoktorId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            DatabaseContext db = new DatabaseContext();

            if(string.IsNullOrEmpty(txt_sifre.Text) || string.IsNullOrEmpty(txt_tc.Text))
            {
                MessageBox.Show("Alanlarý Doldurunuz");
            }
            else if(rd_hasta.Checked) 
            {
                var model = db.Hastas.Where(i => i.TC == txt_tc.Text && i.Sifre == txt_sifre.Text).FirstOrDefault();

                if (model == null)
                {
                    MessageBox.Show("Hasta Kaydý Bulunamadý.");
                    txt_sifre.Text = "";
                    return;
                }

                HastaId = model.Id;
                HastaProfil form = new HastaProfil();
                form.Show();
                this.Hide();

            }

            else if (rd_doktor.Checked) 
            {
                var model = db.Doktors.Where(i => i.TC == txt_tc.Text && i.Sifre == txt_sifre.Text).FirstOrDefault();

                if (model == null)
                {
                    MessageBox.Show("Doktor Kaydý Bulunamadý.");
                    txt_sifre.Text = "";
                    return;
                }

                DoktorId = model.Id;
                DoktorProfil form = new DoktorProfil();
                form.Show();
                this.Hide();
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        
    }
}
