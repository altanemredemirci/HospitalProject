namespace Hospital
{
    public partial class Form1 : Form
    {
        public static int HastaId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            DatabaseContext db = new DatabaseContext();

            var model = db.Hastas.Where(i => i.TC == txt_tc.Text && i.Sifre == txt_sifre.Text).FirstOrDefault();

            if (model == null)
            {
                MessageBox.Show("Hasta Kaydý Bulunamadý.");
                txt_sifre.Text = "";
            }

            HastaId = model.Id;
            RandevuForm form = new RandevuForm();
            form.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
