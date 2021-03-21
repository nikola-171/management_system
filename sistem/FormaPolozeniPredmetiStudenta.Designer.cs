
namespace sistem
{
    partial class FormaPolozeniPredmetiStudenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPolozeniPredmetiStudenta));
            this.panelNaslov = new System.Windows.Forms.Panel();
            this.labelaUnosStudent = new System.Windows.Forms.Label();
            this.labelaNaslov = new System.Windows.Forms.Label();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.dugmeStampajIspite = new FontAwesome.Sharp.IconButton();
            this.dugmeNazad = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabelaPolozeniPredmeti = new System.Windows.Forms.DataGridView();
            this.predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakultetska_godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNaslov.SuspendLayout();
            this.panelMeni.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPolozeniPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNaslov
            // 
            this.panelNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelNaslov.Controls.Add(this.labelaUnosStudent);
            this.panelNaslov.Controls.Add(this.labelaNaslov);
            this.panelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNaslov.Location = new System.Drawing.Point(199, 0);
            this.panelNaslov.Name = "panelNaslov";
            this.panelNaslov.Size = new System.Drawing.Size(843, 93);
            this.panelNaslov.TabIndex = 7;
            // 
            // labelaUnosStudent
            // 
            this.labelaUnosStudent.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaUnosStudent.ForeColor = System.Drawing.Color.White;
            this.labelaUnosStudent.Location = new System.Drawing.Point(426, 27);
            this.labelaUnosStudent.Name = "labelaUnosStudent";
            this.labelaUnosStudent.Size = new System.Drawing.Size(335, 35);
            this.labelaUnosStudent.TabIndex = 3;
            this.labelaUnosStudent.Text = "nedefinisano";
            this.labelaUnosStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelaNaslov
            // 
            this.labelaNaslov.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaNaslov.ForeColor = System.Drawing.Color.White;
            this.labelaNaslov.Location = new System.Drawing.Point(24, 27);
            this.labelaNaslov.Name = "labelaNaslov";
            this.labelaNaslov.Size = new System.Drawing.Size(379, 35);
            this.labelaNaslov.TabIndex = 2;
            this.labelaNaslov.Text = "Položeni predmeti";
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
            this.panelMeni.Size = new System.Drawing.Size(199, 508);
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
            this.dugmeStampajIspite.TabIndex = 2;
            this.dugmeStampajIspite.Text = "štampaj ispite";
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
            // tabelaPolozeniPredmeti
            // 
            this.tabelaPolozeniPredmeti.AllowUserToAddRows = false;
            this.tabelaPolozeniPredmeti.AllowUserToDeleteRows = false;
            this.tabelaPolozeniPredmeti.AllowUserToResizeColumns = false;
            this.tabelaPolozeniPredmeti.AllowUserToResizeRows = false;
            this.tabelaPolozeniPredmeti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelaPolozeniPredmeti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaPolozeniPredmeti.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.tabelaPolozeniPredmeti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaPolozeniPredmeti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaPolozeniPredmeti.ColumnHeadersHeight = 50;
            this.tabelaPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.predmet,
            this.datum,
            this.ocena,
            this.fakultetska_godina});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaPolozeniPredmeti.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaPolozeniPredmeti.EnableHeadersVisualStyles = false;
            this.tabelaPolozeniPredmeti.Location = new System.Drawing.Point(199, 93);
            this.tabelaPolozeniPredmeti.Name = "tabelaPolozeniPredmeti";
            this.tabelaPolozeniPredmeti.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabelaPolozeniPredmeti.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tabelaPolozeniPredmeti.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelaPolozeniPredmeti.Size = new System.Drawing.Size(843, 477);
            this.tabelaPolozeniPredmeti.TabIndex = 8;
            // 
            // predmet
            // 
            this.predmet.HeaderText = "predmet";
            this.predmet.Name = "predmet";
            // 
            // datum
            // 
            this.datum.HeaderText = "datum";
            this.datum.Name = "datum";
            // 
            // ocena
            // 
            this.ocena.HeaderText = "ocena";
            this.ocena.Name = "ocena";
            // 
            // fakultetska_godina
            // 
            this.fakultetska_godina.HeaderText = "fakultetska godina";
            this.fakultetska_godina.Name = "fakultetska_godina";
            // 
            // FormaPolozeniPredmetiStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1042, 508);
            this.Controls.Add(this.tabelaPolozeniPredmeti);
            this.Controls.Add(this.panelNaslov);
            this.Controls.Add(this.panelMeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaPolozeniPredmetiStudenta";
            this.Text = "Položeni predmeti";
            this.Load += new System.EventHandler(this.FormaPolozeniPredmetiStudenta_Load);
            this.panelNaslov.ResumeLayout(false);
            this.panelMeni.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPolozeniPredmeti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNaslov;
        private System.Windows.Forms.Label labelaUnosStudent;
        private System.Windows.Forms.Label labelaNaslov;
        private System.Windows.Forms.Panel panelMeni;
        private FontAwesome.Sharp.IconButton dugmeNazad;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tabelaPolozeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocena;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakultetska_godina;
        private FontAwesome.Sharp.IconButton dugmeStampajIspite;
    }
}