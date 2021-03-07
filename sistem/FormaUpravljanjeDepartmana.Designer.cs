
namespace sistem
{
    partial class FormaUpravljanjeDepartmana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaUpravljanjeDepartmana));
            this.panelMeni = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelNaslov = new System.Windows.Forms.Panel();
            this.labelaNaslov = new System.Windows.Forms.Label();
            this.tabelaPrikazDepartmana = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.univerzitet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakultet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivo_studija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.dugmeDodaj = new FontAwesome.Sharp.IconButton();
            this.dugmeNazad = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMeni.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelNaslov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazDepartmana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMeni.Controls.Add(this.dugmeDodaj);
            this.panelMeni.Controls.Add(this.dugmeNazad);
            this.panelMeni.Controls.Add(this.panelLogo);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMeni.Location = new System.Drawing.Point(0, 0);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(199, 450);
            this.panelMeni.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(199, 112);
            this.panelLogo.TabIndex = 0;
            // 
            // panelNaslov
            // 
            this.panelNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelNaslov.Controls.Add(this.labelaNaslov);
            this.panelNaslov.Controls.Add(this.iconPictureBox1);
            this.panelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNaslov.Location = new System.Drawing.Point(199, 0);
            this.panelNaslov.Name = "panelNaslov";
            this.panelNaslov.Size = new System.Drawing.Size(809, 93);
            this.panelNaslov.TabIndex = 2;
            // 
            // labelaNaslov
            // 
            this.labelaNaslov.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaNaslov.ForeColor = System.Drawing.Color.White;
            this.labelaNaslov.Location = new System.Drawing.Point(60, 26);
            this.labelaNaslov.Name = "labelaNaslov";
            this.labelaNaslov.Size = new System.Drawing.Size(335, 35);
            this.labelaNaslov.TabIndex = 2;
            this.labelaNaslov.Text = "Upravljanje departmanima";
            this.labelaNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabelaPrikazDepartmana
            // 
            this.tabelaPrikazDepartmana.AllowUserToAddRows = false;
            this.tabelaPrikazDepartmana.AllowUserToDeleteRows = false;
            this.tabelaPrikazDepartmana.AllowUserToResizeColumns = false;
            this.tabelaPrikazDepartmana.AllowUserToResizeRows = false;
            this.tabelaPrikazDepartmana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaPrikazDepartmana.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabelaPrikazDepartmana.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaPrikazDepartmana.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaPrikazDepartmana.ColumnHeadersHeight = 50;
            this.tabelaPrikazDepartmana.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.univerzitet,
            this.fakultet,
            this.departman,
            this.nivo_studija});
            this.tabelaPrikazDepartmana.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabelaPrikazDepartmana.EnableHeadersVisualStyles = false;
            this.tabelaPrikazDepartmana.Location = new System.Drawing.Point(199, 93);
            this.tabelaPrikazDepartmana.Name = "tabelaPrikazDepartmana";
            this.tabelaPrikazDepartmana.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabelaPrikazDepartmana.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaPrikazDepartmana.Size = new System.Drawing.Size(809, 357);
            this.tabelaPrikazDepartmana.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Visible = false;
            // 
            // univerzitet
            // 
            this.univerzitet.HeaderText = "univerzitet";
            this.univerzitet.Name = "univerzitet";
            this.univerzitet.ReadOnly = true;
            // 
            // fakultet
            // 
            this.fakultet.HeaderText = "fakultet";
            this.fakultet.Name = "fakultet";
            this.fakultet.ReadOnly = true;
            // 
            // departman
            // 
            this.departman.HeaderText = "departman";
            this.departman.Name = "departman";
            this.departman.ReadOnly = true;
            // 
            // nivo_studija
            // 
            this.nivo_studija.HeaderText = "nivo studija";
            this.nivo_studija.Name = "nivo_studija";
            this.nivo_studija.ReadOnly = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(17, 26);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(37, 35);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // dugmeDodaj
            // 
            this.dugmeDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeDodaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.dugmeDodaj.FlatAppearance.BorderSize = 0;
            this.dugmeDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeDodaj.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dugmeDodaj.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.dugmeDodaj.IconColor = System.Drawing.Color.Black;
            this.dugmeDodaj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeDodaj.Location = new System.Drawing.Point(0, 180);
            this.dugmeDodaj.Name = "dugmeDodaj";
            this.dugmeDodaj.Size = new System.Drawing.Size(199, 68);
            this.dugmeDodaj.TabIndex = 2;
            this.dugmeDodaj.Text = "dodaj departman";
            this.dugmeDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeDodaj.UseVisualStyleBackColor = true;
            this.dugmeDodaj.Click += new System.EventHandler(this.dugmeDodaj_Click);
            // 
            // dugmeNazad
            // 
            this.dugmeNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeNazad.Dock = System.Windows.Forms.DockStyle.Top;
            this.dugmeNazad.FlatAppearance.BorderSize = 0;
            this.dugmeNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeNazad.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dugmeNazad.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.dugmeNazad.IconColor = System.Drawing.Color.Black;
            this.dugmeNazad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeNazad.IconSize = 50;
            this.dugmeNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeNazad.Location = new System.Drawing.Point(0, 112);
            this.dugmeNazad.Name = "dugmeNazad";
            this.dugmeNazad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dugmeNazad.Size = new System.Drawing.Size(199, 68);
            this.dugmeNazad.TabIndex = 1;
            this.dugmeNazad.Text = "nazad";
            this.dugmeNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeNazad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeNazad.UseVisualStyleBackColor = true;
            this.dugmeNazad.Click += new System.EventHandler(this.dugmeNazad_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistem.Properties.Resources.departman;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormaUpravljanjeDepartmana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.tabelaPrikazDepartmana);
            this.Controls.Add(this.panelNaslov);
            this.Controls.Add(this.panelMeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormaUpravljanjeDepartmana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje departmanima";
            this.Load += new System.EventHandler(this.FormaUpravljanjeDepartmana_Load);
            this.panelMeni.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelNaslov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazDepartmana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMeni;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton dugmeNazad;
        private System.Windows.Forms.Panel panelNaslov;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton dugmeDodaj;
        private System.Windows.Forms.Label labelaNaslov;
        private System.Windows.Forms.DataGridView tabelaPrikazDepartmana;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn univerzitet;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakultet;
        private System.Windows.Forms.DataGridViewTextBoxColumn departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivo_studija;
    }
}