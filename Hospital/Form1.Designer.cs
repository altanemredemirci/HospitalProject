namespace Hospital
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txt_tc = new TextBox();
            txt_sifre = new TextBox();
            label2 = new Label();
            btn_giris = new Button();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik:";
            // 
            // txt_tc
            // 
            txt_tc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_tc.Location = new Point(114, 29);
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(250, 29);
            txt_tc.TabIndex = 1;
            txt_tc.Text = "12345678909";
            // 
            // txt_sifre
            // 
            txt_sifre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_sifre.Location = new Point(113, 85);
            txt_sifre.MaxLength = 6;
            txt_sifre.Name = "txt_sifre";
            txt_sifre.PasswordChar = '*';
            txt_sifre.Size = new Size(250, 29);
            txt_sifre.TabIndex = 3;
            txt_sifre.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(26, 88);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // btn_giris
            // 
            btn_giris.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_giris.Location = new Point(114, 140);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(249, 29);
            btn_giris.TabIndex = 4;
            btn_giris.Text = "GİRİŞ";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(391, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            linkLabel1.Location = new Point(19, 191);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(66, 21);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kayıt Ol";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 226);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_giris);
            Controls.Add(txt_sifre);
            Controls.Add(label2);
            Controls.Add(txt_tc);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_tc;
        private TextBox txt_sifre;
        private Label label2;
        private Button btn_giris;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}
