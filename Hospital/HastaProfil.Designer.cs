namespace Hospital
{
    partial class HastaProfil
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
            components = new System.ComponentModel.Container();
            lbl_name = new Label();
            lbl_tc = new Label();
            updateHastaBindingSource = new BindingSource(components);
            createDatabaseBindingSource = new BindingSource(components);
            dt_grid_randevu = new DataGridView();
            lst_randevu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button1 = new Button();
            btn_randevuAl = new Button();
            btn_logout = new Button();
            ((System.ComponentModel.ISupportInitialize)updateHastaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)createDatabaseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dt_grid_randevu).BeginInit();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_name.Location = new Point(38, 34);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(31, 21);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Ad";
            // 
            // lbl_tc
            // 
            lbl_tc.AutoSize = true;
            lbl_tc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_tc.Location = new Point(228, 34);
            lbl_tc.Name = "lbl_tc";
            lbl_tc.Size = new Size(28, 21);
            lbl_tc.TabIndex = 2;
            lbl_tc.Text = "TC";
            // 
            // updateHastaBindingSource
            // 
            updateHastaBindingSource.DataSource = typeof(Migrations.UpdateHasta);
            // 
            // createDatabaseBindingSource
            // 
            createDatabaseBindingSource.DataSource = typeof(Migrations.CreateDatabase);
            // 
            // dt_grid_randevu
            // 
            dt_grid_randevu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_grid_randevu.Location = new Point(41, 100);
            dt_grid_randevu.Name = "dt_grid_randevu";
            dt_grid_randevu.Size = new Size(1119, 175);
            dt_grid_randevu.TabIndex = 3;
            // 
            // lst_randevu
            // 
            lst_randevu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lst_randevu.FullRowSelect = true;
            lst_randevu.GridLines = true;
            lst_randevu.Location = new Point(41, 310);
            lst_randevu.Name = "lst_randevu";
            lst_randevu.Size = new Size(1119, 219);
            lst_randevu.TabIndex = 4;
            lst_randevu.UseCompatibleStateImageBehavior = false;
            lst_randevu.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "HASTANE";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "KLİNİK";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "DOKTOR";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "RANDEVU TARİHİ";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "RANDEVU SAATİ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(472, 27);
            button1.Name = "button1";
            button1.Size = new Size(153, 34);
            button1.TabIndex = 5;
            button1.Text = "Randevu İptal Et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_randevuAl
            // 
            btn_randevuAl.BackColor = SystemColors.ActiveCaption;
            btn_randevuAl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_randevuAl.ForeColor = SystemColors.ControlLightLight;
            btn_randevuAl.Location = new Point(667, 27);
            btn_randevuAl.Name = "btn_randevuAl";
            btn_randevuAl.Size = new Size(153, 34);
            btn_randevuAl.TabIndex = 6;
            btn_randevuAl.Text = "Randevu Al";
            btn_randevuAl.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_randevuAl.UseVisualStyleBackColor = false;
            btn_randevuAl.Click += btn_randevuAl_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = SystemColors.ActiveCaption;
            btn_logout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_logout.ForeColor = SystemColors.ButtonHighlight;
            btn_logout.Location = new Point(870, 27);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(141, 32);
            btn_logout.TabIndex = 17;
            btn_logout.Text = "Çıkış";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // HastaProfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 568);
            Controls.Add(btn_logout);
            Controls.Add(btn_randevuAl);
            Controls.Add(button1);
            Controls.Add(lst_randevu);
            Controls.Add(dt_grid_randevu);
            Controls.Add(lbl_tc);
            Controls.Add(lbl_name);
            Name = "HastaProfil";
            Text = "HastaProfil";
            Shown += HastaProfil_Shown;
            ((System.ComponentModel.ISupportInitialize)updateHastaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)createDatabaseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dt_grid_randevu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_tc;
        private BindingSource updateHastaBindingSource;
        private BindingSource createDatabaseBindingSource;
        private DataGridView dt_grid_randevu;
        private ListView lst_randevu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button1;
        private Button btn_randevuAl;
        private Button btn_logout;
    }
}