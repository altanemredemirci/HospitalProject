namespace Hospital
{
    partial class Register
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
            label1 = new Label();
            txt_isim = new TextBox();
            txt_tc = new TextBox();
            label2 = new Label();
            txt_telefon = new TextBox();
            label3 = new Label();
            txt_kangrubu = new TextBox();
            label4 = new Label();
            txt_pass = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            nmr_boy = new NumericUpDown();
            nmr_kilo = new NumericUpDown();
            cmb_sehir = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            cmb_ilce = new ComboBox();
            btn_kayit = new Button();
            ((System.ComponentModel.ISupportInitialize)nmr_boy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_kilo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(42, 62);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 0;
            label1.Text = "Isim";
            // 
            // txt_isim
            // 
            txt_isim.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_isim.Location = new Point(139, 62);
            txt_isim.Name = "txt_isim";
            txt_isim.Size = new Size(246, 29);
            txt_isim.TabIndex = 1;
            // 
            // txt_tc
            // 
            txt_tc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_tc.Location = new Point(139, 105);
            txt_tc.MaxLength = 11;
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(246, 29);
            txt_tc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(42, 105);
            label2.Name = "label2";
            label2.Size = new Size(28, 21);
            label2.TabIndex = 2;
            label2.Text = "TC";
            // 
            // txt_telefon
            // 
            txt_telefon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_telefon.Location = new Point(139, 149);
            txt_telefon.MaxLength = 11;
            txt_telefon.Name = "txt_telefon";
            txt_telefon.Size = new Size(246, 29);
            txt_telefon.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(42, 149);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 4;
            label3.Text = "Telefon";
            // 
            // txt_kangrubu
            // 
            txt_kangrubu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_kangrubu.Location = new Point(139, 195);
            txt_kangrubu.Name = "txt_kangrubu";
            txt_kangrubu.Size = new Size(246, 29);
            txt_kangrubu.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(42, 195);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 6;
            label4.Text = "Kangrubu";
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_pass.Location = new Point(139, 236);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(246, 29);
            txt_pass.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(42, 236);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 8;
            label5.Text = "Sifre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(42, 279);
            label6.Name = "label6";
            label6.Size = new Size(38, 21);
            label6.TabIndex = 10;
            label6.Text = "Boy";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(45, 325);
            label7.Name = "label7";
            label7.Size = new Size(38, 21);
            label7.TabIndex = 13;
            label7.Text = "Kilo";
            // 
            // nmr_boy
            // 
            nmr_boy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nmr_boy.Location = new Point(136, 281);
            nmr_boy.Maximum = new decimal(new int[] { 220, 0, 0, 0 });
            nmr_boy.Name = "nmr_boy";
            nmr_boy.Size = new Size(249, 29);
            nmr_boy.TabIndex = 14;
            // 
            // nmr_kilo
            // 
            nmr_kilo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nmr_kilo.Location = new Point(136, 326);
            nmr_kilo.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nmr_kilo.Name = "nmr_kilo";
            nmr_kilo.Size = new Size(249, 29);
            nmr_kilo.TabIndex = 15;
            // 
            // cmb_sehir
            // 
            cmb_sehir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmb_sehir.FormattingEnabled = true;
            cmb_sehir.Location = new Point(139, 371);
            cmb_sehir.Name = "cmb_sehir";
            cmb_sehir.Size = new Size(246, 29);
            cmb_sehir.TabIndex = 16;
            cmb_sehir.SelectedIndexChanged += cmb_sehir_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(42, 371);
            label8.Name = "label8";
            label8.Size = new Size(47, 21);
            label8.TabIndex = 17;
            label8.Text = "Şehir";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(44, 417);
            label9.Name = "label9";
            label9.Size = new Size(36, 21);
            label9.TabIndex = 19;
            label9.Text = "İlçe";
            // 
            // cmb_ilce
            // 
            cmb_ilce.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmb_ilce.FormattingEnabled = true;
            cmb_ilce.Location = new Point(136, 417);
            cmb_ilce.Name = "cmb_ilce";
            cmb_ilce.Size = new Size(246, 29);
            cmb_ilce.TabIndex = 18;
            // 
            // btn_kayit
            // 
            btn_kayit.BackColor = SystemColors.ActiveCaption;
            btn_kayit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_kayit.ForeColor = SystemColors.ButtonHighlight;
            btn_kayit.Location = new Point(136, 462);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(249, 38);
            btn_kayit.TabIndex = 20;
            btn_kayit.Text = "Kayıt Ol";
            btn_kayit.UseVisualStyleBackColor = false;
            btn_kayit.Click += btn_kayit_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 541);
            Controls.Add(btn_kayit);
            Controls.Add(label9);
            Controls.Add(cmb_ilce);
            Controls.Add(label8);
            Controls.Add(cmb_sehir);
            Controls.Add(nmr_kilo);
            Controls.Add(nmr_boy);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txt_pass);
            Controls.Add(label5);
            Controls.Add(txt_kangrubu);
            Controls.Add(label4);
            Controls.Add(txt_telefon);
            Controls.Add(label3);
            Controls.Add(txt_tc);
            Controls.Add(label2);
            Controls.Add(txt_isim);
            Controls.Add(label1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)nmr_boy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_kilo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_isim;
        private TextBox txt_tc;
        private Label label2;
        private TextBox txt_telefon;
        private Label label3;
        private TextBox txt_kangrubu;
        private Label label4;
        private TextBox txt_pass;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown nmr_boy;
        private NumericUpDown nmr_kilo;
        private ComboBox cmb_sehir;
        private Label label8;
        private Label label9;
        private ComboBox cmb_ilce;
        private Button btn_kayit;
    }
}