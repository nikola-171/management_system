﻿
namespace sistem
{
    partial class FormaDodavanjeDepartmana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaDodavanjeDepartmana));
            this.panelMeni = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelaNaslov = new System.Windows.Forms.Label();
            this.panelNaslov = new System.Windows.Forms.Panel();
            this.panelForma = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listaNivoaStudija = new System.Windows.Forms.ComboBox();
            this.listaFakulteta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.naziv_departmana_unos = new System.Windows.Forms.TextBox();
            this.espb_unos = new System.Windows.Forms.TextBox();
            this.trajanje_unos = new System.Windows.Forms.TextBox();
            this.dugmeDodajDepartman = new FontAwesome.Sharp.IconButton();
            this.dugmeNazad = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelMeni.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelNaslov.SuspendLayout();
            this.panelForma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMeni.Controls.Add(this.dugmeNazad);
            this.panelMeni.Controls.Add(this.panelLogo);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMeni.Location = new System.Drawing.Point(0, 93);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(199, 357);
            this.panelMeni.TabIndex = 3;
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
            // labelaNaslov
            // 
            this.labelaNaslov.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaNaslov.ForeColor = System.Drawing.Color.White;
            this.labelaNaslov.Location = new System.Drawing.Point(60, 26);
            this.labelaNaslov.Name = "labelaNaslov";
            this.labelaNaslov.Size = new System.Drawing.Size(335, 35);
            this.labelaNaslov.TabIndex = 2;
            this.labelaNaslov.Text = "Dodavanje departmana";
            this.labelaNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNaslov
            // 
            this.panelNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelNaslov.Controls.Add(this.labelaNaslov);
            this.panelNaslov.Controls.Add(this.iconPictureBox1);
            this.panelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNaslov.Location = new System.Drawing.Point(0, 0);
            this.panelNaslov.Name = "panelNaslov";
            this.panelNaslov.Size = new System.Drawing.Size(940, 93);
            this.panelNaslov.TabIndex = 4;
            // 
            // panelForma
            // 
            this.panelForma.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelForma.Controls.Add(this.dugmeDodajDepartman);
            this.panelForma.Controls.Add(this.label5);
            this.panelForma.Controls.Add(this.label4);
            this.panelForma.Controls.Add(this.listaNivoaStudija);
            this.panelForma.Controls.Add(this.listaFakulteta);
            this.panelForma.Controls.Add(this.label3);
            this.panelForma.Controls.Add(this.label2);
            this.panelForma.Controls.Add(this.label1);
            this.panelForma.Controls.Add(this.naziv_departmana_unos);
            this.panelForma.Controls.Add(this.espb_unos);
            this.panelForma.Controls.Add(this.trajanje_unos);
            this.panelForma.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForma.Location = new System.Drawing.Point(199, 93);
            this.panelForma.Name = "panelForma";
            this.panelForma.Size = new System.Drawing.Size(741, 363);
            this.panelForma.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "naziv departmana:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(181, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "trajanje:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaNivoaStudija
            // 
            this.listaNivoaStudija.FormattingEnabled = true;
            this.listaNivoaStudija.Items.AddRange(new object[] {
            "osnovne akademske studije",
            "master akademske studije",
            "doktorske akadamske studije"});
            this.listaNivoaStudija.Location = new System.Drawing.Point(305, 169);
            this.listaNivoaStudija.Name = "listaNivoaStudija";
            this.listaNivoaStudija.Size = new System.Drawing.Size(224, 21);
            this.listaNivoaStudija.TabIndex = 8;
            // 
            // listaFakulteta
            // 
            this.listaFakulteta.FormattingEnabled = true;
            this.listaFakulteta.Location = new System.Drawing.Point(305, 206);
            this.listaFakulteta.Name = "listaFakulteta";
            this.listaFakulteta.Size = new System.Drawing.Size(224, 21);
            this.listaFakulteta.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(144, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "nivo stdija:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "fakultet:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "espb:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // naziv_departmana_unos
            // 
            this.naziv_departmana_unos.Location = new System.Drawing.Point(305, 62);
            this.naziv_departmana_unos.MaxLength = 45;
            this.naziv_departmana_unos.Name = "naziv_departmana_unos";
            this.naziv_departmana_unos.Size = new System.Drawing.Size(224, 20);
            this.naziv_departmana_unos.TabIndex = 3;
            // 
            // espb_unos
            // 
            this.espb_unos.Location = new System.Drawing.Point(305, 132);
            this.espb_unos.MaxLength = 3;
            this.espb_unos.Name = "espb_unos";
            this.espb_unos.Size = new System.Drawing.Size(224, 20);
            this.espb_unos.TabIndex = 2;
            // 
            // trajanje_unos
            // 
            this.trajanje_unos.Location = new System.Drawing.Point(305, 100);
            this.trajanje_unos.Name = "trajanje_unos";
            this.trajanje_unos.Size = new System.Drawing.Size(224, 20);
            this.trajanje_unos.TabIndex = 1;
            // 
            // dugmeDodajDepartman
            // 
            this.dugmeDodajDepartman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dugmeDodajDepartman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeDodajDepartman.FlatAppearance.BorderSize = 0;
            this.dugmeDodajDepartman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeDodajDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeDodajDepartman.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dugmeDodajDepartman.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.dugmeDodajDepartman.IconColor = System.Drawing.Color.Black;
            this.dugmeDodajDepartman.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeDodajDepartman.Location = new System.Drawing.Point(305, 252);
            this.dugmeDodajDepartman.Name = "dugmeDodajDepartman";
            this.dugmeDodajDepartman.Size = new System.Drawing.Size(224, 56);
            this.dugmeDodajDepartman.TabIndex = 11;
            this.dugmeDodajDepartman.Text = "dodaj departman";
            this.dugmeDodajDepartman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeDodajDepartman.UseVisualStyleBackColor = false;
            this.dugmeDodajDepartman.Click += new System.EventHandler(this.dugmeDodajDepartman_Click);
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
            this.dugmeNazad.Click += new System.EventHandler(this.dugmeNazad_Click);
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
            // FormaDodavanjeDepartmana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.panelForma);
            this.Controls.Add(this.panelMeni);
            this.Controls.Add(this.panelNaslov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormaDodavanjeDepartmana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormaDodavanjeDepartmana";
            this.panelMeni.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelNaslov.ResumeLayout(false);
            this.panelForma.ResumeLayout(false);
            this.panelForma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMeni;
        private FontAwesome.Sharp.IconButton dugmeNazad;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelaNaslov;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panelNaslov;
        private System.Windows.Forms.Panel panelForma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox listaNivoaStudija;
        private System.Windows.Forms.ComboBox listaFakulteta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox naziv_departmana_unos;
        private System.Windows.Forms.TextBox espb_unos;
        private System.Windows.Forms.TextBox trajanje_unos;
        private FontAwesome.Sharp.IconButton dugmeDodajDepartman;
    }
}