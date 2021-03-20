
namespace sistem
{
    partial class FormaIzmenaFakultet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaIzmenaFakultet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dugmeZaIzmenu = new FontAwesome.Sharp.IconButton();
            this.dugmeZaBrisanje = new FontAwesome.Sharp.IconButton();
            this.mestoUnos = new System.Windows.Forms.TextBox();
            this.nazivUnos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNaslov = new System.Windows.Forms.Panel();
            this.labelaNaslov = new System.Windows.Forms.Label();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.dugmeZaNazad = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panelNaslov.SuspendLayout();
            this.panelMeni.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Controls.Add(this.dugmeZaIzmenu);
            this.groupBox1.Controls.Add(this.dugmeZaBrisanje);
            this.groupBox1.Controls.Add(this.mestoUnos);
            this.groupBox1.Controls.Add(this.nazivUnos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(364, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 334);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmeni fakultet";
            // 
            // dugmeZaIzmenu
            // 
            this.dugmeZaIzmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dugmeZaIzmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeZaIzmenu.FlatAppearance.BorderSize = 0;
            this.dugmeZaIzmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeZaIzmenu.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dugmeZaIzmenu.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.dugmeZaIzmenu.IconColor = System.Drawing.Color.Black;
            this.dugmeZaIzmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeZaIzmenu.IconSize = 50;
            this.dugmeZaIzmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeZaIzmenu.Location = new System.Drawing.Point(236, 246);
            this.dugmeZaIzmenu.Name = "dugmeZaIzmenu";
            this.dugmeZaIzmenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dugmeZaIzmenu.Size = new System.Drawing.Size(174, 51);
            this.dugmeZaIzmenu.TabIndex = 12;
            this.dugmeZaIzmenu.Text = "izmeni";
            this.dugmeZaIzmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeZaIzmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeZaIzmenu.UseVisualStyleBackColor = false;
            this.dugmeZaIzmenu.Click += new System.EventHandler(this.dugmeZaIzmenu_Click);
            // 
            // dugmeZaBrisanje
            // 
            this.dugmeZaBrisanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dugmeZaBrisanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeZaBrisanje.FlatAppearance.BorderSize = 0;
            this.dugmeZaBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeZaBrisanje.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dugmeZaBrisanje.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.dugmeZaBrisanje.IconColor = System.Drawing.Color.Black;
            this.dugmeZaBrisanje.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeZaBrisanje.IconSize = 50;
            this.dugmeZaBrisanje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeZaBrisanje.Location = new System.Drawing.Point(56, 246);
            this.dugmeZaBrisanje.Name = "dugmeZaBrisanje";
            this.dugmeZaBrisanje.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dugmeZaBrisanje.Size = new System.Drawing.Size(174, 51);
            this.dugmeZaBrisanje.TabIndex = 11;
            this.dugmeZaBrisanje.Text = "izbriši";
            this.dugmeZaBrisanje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeZaBrisanje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeZaBrisanje.UseVisualStyleBackColor = false;
            this.dugmeZaBrisanje.Click += new System.EventHandler(this.dugmeZaBrisanje_Click);
            // 
            // mestoUnos
            // 
            this.mestoUnos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mestoUnos.Location = new System.Drawing.Point(162, 159);
            this.mestoUnos.Name = "mestoUnos";
            this.mestoUnos.Size = new System.Drawing.Size(248, 29);
            this.mestoUnos.TabIndex = 5;
            // 
            // nazivUnos
            // 
            this.nazivUnos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivUnos.Location = new System.Drawing.Point(162, 80);
            this.nazivUnos.Name = "nazivUnos";
            this.nazivUnos.Size = new System.Drawing.Size(248, 29);
            this.nazivUnos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "grad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "naziv: ";
            // 
            // panelNaslov
            // 
            this.panelNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelNaslov.Controls.Add(this.labelaNaslov);
            this.panelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNaslov.Location = new System.Drawing.Point(0, 0);
            this.panelNaslov.Name = "panelNaslov";
            this.panelNaslov.Size = new System.Drawing.Size(984, 125);
            this.panelNaslov.TabIndex = 9;
            // 
            // labelaNaslov
            // 
            this.labelaNaslov.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaNaslov.ForeColor = System.Drawing.Color.White;
            this.labelaNaslov.Location = new System.Drawing.Point(198, 46);
            this.labelaNaslov.Name = "labelaNaslov";
            this.labelaNaslov.Size = new System.Drawing.Size(335, 35);
            this.labelaNaslov.TabIndex = 2;
            this.labelaNaslov.Text = "Upravljanje fakultetom";
            this.labelaNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMeni.Controls.Add(this.dugmeZaNazad);
            this.panelMeni.Controls.Add(this.panelLogo);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMeni.Location = new System.Drawing.Point(0, 125);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(199, 443);
            this.panelMeni.TabIndex = 10;
            // 
            // dugmeZaNazad
            // 
            this.dugmeZaNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeZaNazad.Dock = System.Windows.Forms.DockStyle.Top;
            this.dugmeZaNazad.FlatAppearance.BorderSize = 0;
            this.dugmeZaNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeZaNazad.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dugmeZaNazad.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.dugmeZaNazad.IconColor = System.Drawing.Color.Black;
            this.dugmeZaNazad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeZaNazad.IconSize = 50;
            this.dugmeZaNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeZaNazad.Location = new System.Drawing.Point(0, 215);
            this.dugmeZaNazad.Name = "dugmeZaNazad";
            this.dugmeZaNazad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dugmeZaNazad.Size = new System.Drawing.Size(199, 68);
            this.dugmeZaNazad.TabIndex = 1;
            this.dugmeZaNazad.Text = "nazad";
            this.dugmeZaNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeZaNazad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeZaNazad.UseVisualStyleBackColor = true;
            this.dugmeZaNazad.Click += new System.EventHandler(this.dugmeZaNazad_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(199, 215);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sistem.Properties.Resources.univerzitet1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 212);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormaIzmenaFakultet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(984, 568);
            this.Controls.Add(this.panelMeni);
            this.Controls.Add(this.panelNaslov);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaIzmenaFakultet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmena fakulteta";
            this.Load += new System.EventHandler(this.FormaIzmenaFakultet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelNaslov.ResumeLayout(false);
            this.panelMeni.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mestoUnos;
        private System.Windows.Forms.TextBox nazivUnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNaslov;
        private System.Windows.Forms.Label labelaNaslov;
        private System.Windows.Forms.Panel panelMeni;
        private FontAwesome.Sharp.IconButton dugmeZaNazad;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton dugmeZaIzmenu;
        private FontAwesome.Sharp.IconButton dugmeZaBrisanje;
    }
}