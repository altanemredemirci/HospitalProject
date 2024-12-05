namespace Hospital
{
    partial class RandevuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuForm));
            cmb_sehir = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmb_ilce = new ComboBox();
            label3 = new Label();
            cmb_hastane = new ComboBox();
            label4 = new Label();
            cmb_klinik = new ComboBox();
            label5 = new Label();
            cmb_doktor = new ComboBox();
            pictureBox1 = new PictureBox();
            dt_tarih = new DateTimePicker();
            label6 = new Label();
            grp_randevuSaati = new GroupBox();
            radioButton12 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton1 = new RadioButton();
            rd_saat = new RadioButton();
            btn_randevuKayit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grp_randevuSaati.SuspendLayout();
            SuspendLayout();
            // 
            // cmb_sehir
            // 
            cmb_sehir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmb_sehir.FormattingEnabled = true;
            cmb_sehir.Location = new Point(192, 80);
            cmb_sehir.Name = "cmb_sehir";
            cmb_sehir.Size = new Size(227, 29);
            cmb_sehir.TabIndex = 0;
            cmb_sehir.SelectedIndexChanged += cmb_sehir_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(60, 83);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 1;
            label1.Text = "Şehir:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(60, 128);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 3;
            label2.Text = "İlçe:";
            // 
            // cmb_ilce
            // 
            cmb_ilce.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmb_ilce.FormattingEnabled = true;
            cmb_ilce.Location = new Point(192, 125);
            cmb_ilce.Name = "cmb_ilce";
            cmb_ilce.Size = new Size(227, 29);
            cmb_ilce.TabIndex = 2;
            cmb_ilce.SelectedIndexChanged += cmb_ilce_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(60, 172);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 5;
            label3.Text = "Hastane:";
            // 
            // cmb_hastane
            // 
            cmb_hastane.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmb_hastane.FormattingEnabled = true;
            cmb_hastane.Location = new Point(192, 169);
            cmb_hastane.Name = "cmb_hastane";
            cmb_hastane.Size = new Size(227, 29);
            cmb_hastane.TabIndex = 4;
            cmb_hastane.SelectedIndexChanged += cmb_hastane_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(60, 214);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 7;
            label4.Text = "Klinik:";
            // 
            // cmb_klinik
            // 
            cmb_klinik.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmb_klinik.FormattingEnabled = true;
            cmb_klinik.Location = new Point(192, 211);
            cmb_klinik.Name = "cmb_klinik";
            cmb_klinik.Size = new Size(227, 29);
            cmb_klinik.TabIndex = 6;
            cmb_klinik.SelectedIndexChanged += cmb_klinik_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(60, 257);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 9;
            label5.Text = "Doktor:";
            // 
            // cmb_doktor
            // 
            cmb_doktor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmb_doktor.FormattingEnabled = true;
            cmb_doktor.Location = new Point(192, 254);
            cmb_doktor.Name = "cmb_doktor";
            cmb_doktor.Size = new Size(227, 29);
            cmb_doktor.TabIndex = 8;
            cmb_doktor.SelectedIndexChanged += cmb_doktor_SelectedIndexChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(425, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 261);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dt_tarih
            // 
            dt_tarih.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dt_tarih.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dt_tarih.Format = DateTimePickerFormat.Short;
            dt_tarih.Location = new Point(192, 307);
            dt_tarih.Name = "dt_tarih";
            dt_tarih.Size = new Size(227, 29);
            dt_tarih.TabIndex = 11;
            dt_tarih.ValueChanged += dt_tarih_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(60, 313);
            label6.Name = "label6";
            label6.Size = new Size(119, 21);
            label6.TabIndex = 12;
            label6.Text = "Randevu Tarihi:";
            // 
            // grp_randevuSaati
            // 
            grp_randevuSaati.Controls.Add(radioButton12);
            grp_randevuSaati.Controls.Add(radioButton11);
            grp_randevuSaati.Controls.Add(radioButton10);
            grp_randevuSaati.Controls.Add(radioButton9);
            grp_randevuSaati.Controls.Add(radioButton8);
            grp_randevuSaati.Controls.Add(radioButton7);
            grp_randevuSaati.Controls.Add(radioButton1);
            grp_randevuSaati.Controls.Add(rd_saat);
            grp_randevuSaati.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grp_randevuSaati.Location = new Point(64, 357);
            grp_randevuSaati.Name = "grp_randevuSaati";
            grp_randevuSaati.Size = new Size(355, 149);
            grp_randevuSaati.TabIndex = 13;
            grp_randevuSaati.TabStop = false;
            grp_randevuSaati.Text = "Randevu Saati:";
            grp_randevuSaati.Visible = false;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(91, 38);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(65, 25);
            radioButton12.TabIndex = 12;
            radioButton12.TabStop = true;
            radioButton12.Text = "10:00";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(165, 39);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(62, 25);
            radioButton11.TabIndex = 11;
            radioButton11.TabStop = true;
            radioButton11.Text = "11:00";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(239, 39);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(65, 25);
            radioButton10.TabIndex = 10;
            radioButton10.TabStop = true;
            radioButton10.Text = "12:00";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(15, 95);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(65, 25);
            radioButton9.TabIndex = 9;
            radioButton9.TabStop = true;
            radioButton9.Text = "14:00";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(89, 95);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(65, 25);
            radioButton8.TabIndex = 8;
            radioButton8.TabStop = true;
            radioButton8.Text = "15:00";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(239, 95);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(65, 25);
            radioButton7.TabIndex = 7;
            radioButton7.TabStop = true;
            radioButton7.Text = "17:00";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(163, 95);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 25);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "16:00";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rd_saat
            // 
            rd_saat.AutoSize = true;
            rd_saat.Location = new Point(17, 38);
            rd_saat.Name = "rd_saat";
            rd_saat.Size = new Size(68, 25);
            rd_saat.TabIndex = 0;
            rd_saat.TabStop = true;
            rd_saat.Text = "09:00";
            rd_saat.UseVisualStyleBackColor = true;
            // 
            // btn_randevuKayit
            // 
            btn_randevuKayit.BackColor = SystemColors.ActiveCaption;
            btn_randevuKayit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_randevuKayit.ForeColor = SystemColors.ButtonHighlight;
            btn_randevuKayit.Location = new Point(425, 368);
            btn_randevuKayit.Name = "btn_randevuKayit";
            btn_randevuKayit.Size = new Size(363, 32);
            btn_randevuKayit.TabIndex = 14;
            btn_randevuKayit.Text = "Randevu Kaydet";
            btn_randevuKayit.UseVisualStyleBackColor = false;
            btn_randevuKayit.Click += btn_randevuKayit_Click;
            // 
            // RandevuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(btn_randevuKayit);
            Controls.Add(grp_randevuSaati);
            Controls.Add(label6);
            Controls.Add(dt_tarih);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(cmb_doktor);
            Controls.Add(label4);
            Controls.Add(cmb_klinik);
            Controls.Add(label3);
            Controls.Add(cmb_hastane);
            Controls.Add(label2);
            Controls.Add(cmb_ilce);
            Controls.Add(label1);
            Controls.Add(cmb_sehir);
            Name = "RandevuForm";
            Text = "RandevuForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grp_randevuSaati.ResumeLayout(false);
            grp_randevuSaati.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_sehir;
        private Label label1;
        private Label label2;
        private ComboBox cmb_ilce;
        private Label label3;
        private ComboBox cmb_hastane;
        private Label label4;
        private ComboBox cmb_klinik;
        private Label label5;
        private ComboBox cmb_doktor;
        private PictureBox pictureBox1;
        private DateTimePicker dt_tarih;
        private Label label6;
        private GroupBox grp_randevuSaati;
        private RadioButton rd_saat;
        private RadioButton radioButton12;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton1;
        private Button btn_randevuKayit;
    }
}