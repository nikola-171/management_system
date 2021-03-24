
namespace sistem
{
    partial class FormaPredmetiNaKojimaPredajeProfesor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPredmetiNaKojimaPredajeProfesor));
            this.panelNaslov = new System.Windows.Forms.Panel();
            this.labelaProfesorUnos = new System.Windows.Forms.Label();
            this.labelaNaslov = new System.Windows.Forms.Label();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.dugmeStampajIspite = new FontAwesome.Sharp.IconButton();
            this.dugmeNazad = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabelaPrikazPredmeta = new System.Windows.Forms.DataGridView();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNaslov.SuspendLayout();
            this.panelMeni.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazPredmeta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNaslov
            // 
            this.panelNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelNaslov.Controls.Add(this.labelaProfesorUnos);
            this.panelNaslov.Controls.Add(this.labelaNaslov);
            this.panelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNaslov.Location = new System.Drawing.Point(199, 0);
            this.panelNaslov.Name = "panelNaslov";
            this.panelNaslov.Size = new System.Drawing.Size(794, 93);
            this.panelNaslov.TabIndex = 7;
            // 
            // labelaProfesorUnos
            // 
            this.labelaProfesorUnos.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaProfesorUnos.ForeColor = System.Drawing.Color.White;
            this.labelaProfesorUnos.Location = new System.Drawing.Point(496, 27);
            this.labelaProfesorUnos.Name = "labelaProfesorUnos";
            this.labelaProfesorUnos.Size = new System.Drawing.Size(267, 35);
            this.labelaProfesorUnos.TabIndex = 3;
            this.labelaProfesorUnos.Text = "nedefinisano";
            this.labelaProfesorUnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelaNaslov
            // 
            this.labelaNaslov.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaNaslov.ForeColor = System.Drawing.Color.White;
            this.labelaNaslov.Location = new System.Drawing.Point(31, 27);
            this.labelaNaslov.Name = "labelaNaslov";
            this.labelaNaslov.Size = new System.Drawing.Size(449, 35);
            this.labelaNaslov.TabIndex = 2;
            this.labelaNaslov.Text = "Predmeti na kojima profesor predaje";
            this.labelaNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMeni.Controls.Add(this.dugmeStampajIspite);
            this.panelMeni.Controls.Add(this.dugmeNazad);
            this.panelMeni.Controls.Add(this.panelLogo);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMeni.Location = new System.Drawing.Point(0, 0);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(199, 479);
            this.panelMeni.TabIndex = 6;
            // 
            // dugmeStampajIspite
            // 
            this.dugmeStampajIspite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeStampajIspite.FlatAppearance.BorderSize = 0;
            this.dugmeStampajIspite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeStampajIspite.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dugmeStampajIspite.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.dugmeStampajIspite.IconColor = System.Drawing.Color.Black;
            this.dugmeStampajIspite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeStampajIspite.IconSize = 50;
            this.dugmeStampajIspite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeStampajIspite.Location = new System.Drawing.Point(0, 391);
            this.dugmeStampajIspite.Name = "dugmeStampajIspite";
            this.dugmeStampajIspite.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dugmeStampajIspite.Size = new System.Drawing.Size(199, 68);
            this.dugmeStampajIspite.TabIndex = 3;
            this.dugmeStampajIspite.Text = "štampaj predmete";
            this.dugmeStampajIspite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeStampajIspite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeStampajIspite.UseVisualStyleBackColor = true;
            this.dugmeStampajIspite.Click += new System.EventHandler(this.dugmeStampajIspite_Click);
            // 
            // dugmeNazad
            // 
            this.dugmeNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeNazad.FlatAppearance.BorderSize = 0;
            this.dugmeNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeNazad.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dugmeNazad.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.dugmeNazad.IconColor = System.Drawing.Color.Black;
            this.dugmeNazad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeNazad.IconSize = 50;
            this.dugmeNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeNazad.Location = new System.Drawing.Point(0, 317);
            this.dugmeNazad.Name = "dugmeNazad";
            this.dugmeNazad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dugmeNazad.Size = new System.Drawing.Size(199, 68);
            this.dugmeNazad.TabIndex = 1;
            this.dugmeNazad.Text = "nazad";
            this.dugmeNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeNazad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeNazad.UseVisualStyleBackColor = true;
            this.dugmeNazad.Click += new System.EventHandler(this.dugmeNazad_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(0, 93);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(199, 223);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistem.Properties.Resources.univerzitet1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabelaPrikazPredmeta
            // 
            this.tabelaPrikazPredmeta.AllowUserToAddRows = false;
            this.tabelaPrikazPredmeta.AllowUserToDeleteRows = false;
            this.tabelaPrikazPredmeta.AllowUserToResizeColumns = false;
            this.tabelaPrikazPredmeta.AllowUserToResizeRows = false;
            this.tabelaPrikazPredmeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelaPrikazPredmeta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaPrikazPredmeta.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.tabelaPrikazPredmeta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaPrikazPredmeta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaPrikazPredmeta.ColumnHeadersHeight = 50;
            this.tabelaPrikazPredmeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.email,
            this.naziv,
            this.tip});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaPrikazPredmeta.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaPrikazPredmeta.EnableHeadersVisualStyles = false;
            this.tabelaPrikazPredmeta.Location = new System.Drawing.Point(198, 93);
            this.tabelaPrikazPredmeta.Name = "tabelaPrikazPredmeta";
            this.tabelaPrikazPredmeta.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabelaPrikazPredmeta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tabelaPrikazPredmeta.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelaPrikazPredmeta.RowTemplate.Height = 30;
            this.tabelaPrikazPredmeta.Size = new System.Drawing.Size(795, 477);
            this.tabelaPrikazPredmeta.TabIndex = 8;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // naziv
            // 
            this.naziv.HeaderText = "naziv";
            this.naziv.Name = "naziv";
            // 
            // tip
            // 
            this.tip.HeaderText = "tip";
            this.tip.Name = "tip";
            // 
            // FormaPredmetiNaKojimaPredajeProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 479);
            this.Controls.Add(this.tabelaPrikazPredmeta);
            this.Controls.Add(this.panelNaslov);
            this.Controls.Add(this.panelMeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaPredmetiNaKojimaPredajeProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "predmeti na kojima predaje";
            this.Load += new System.EventHandler(this.FormaPredmetiNaKojimaPredajeProfesor_Load);
            this.panelNaslov.ResumeLayout(false);
            this.panelMeni.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazPredmeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNaslov;
        private System.Windows.Forms.Label labelaProfesorUnos;
        private System.Windows.Forms.Label labelaNaslov;
        private System.Windows.Forms.Panel panelMeni;
        private FontAwesome.Sharp.IconButton dugmeNazad;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tabelaPrikazPredmeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private FontAwesome.Sharp.IconButton dugmeStampajIspite;
    }
}