
namespace sistem
{
    partial class FormaUpravljanjeZaposlenima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaUpravljanjeZaposlenima));
            this.panelNaslov = new System.Windows.Forms.Panel();
            this.labelaNaslov = new System.Windows.Forms.Label();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.dugmeDodaj = new FontAwesome.Sharp.IconButton();
            this.dugmeNazad = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNaslov.SuspendLayout();
            this.panelMeni.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNaslov
            // 
            this.panelNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelNaslov.Controls.Add(this.labelaNaslov);
            this.panelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNaslov.Location = new System.Drawing.Point(199, 0);
            this.panelNaslov.Name = "panelNaslov";
            this.panelNaslov.Size = new System.Drawing.Size(811, 102);
            this.panelNaslov.TabIndex = 8;
            // 
            // labelaNaslov
            // 
            this.labelaNaslov.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaNaslov.ForeColor = System.Drawing.Color.White;
            this.labelaNaslov.Location = new System.Drawing.Point(24, 40);
            this.labelaNaslov.Name = "labelaNaslov";
            this.labelaNaslov.Size = new System.Drawing.Size(335, 35);
            this.labelaNaslov.TabIndex = 2;
            this.labelaNaslov.Text = "Upravljanje zaposlenima";
            this.labelaNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelMeni.Size = new System.Drawing.Size(199, 514);
            this.panelMeni.TabIndex = 7;
            // 
            // dugmeDodaj
            // 
            this.dugmeDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeDodaj.FlatAppearance.BorderSize = 0;
            this.dugmeDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeDodaj.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dugmeDodaj.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.dugmeDodaj.IconColor = System.Drawing.Color.Black;
            this.dugmeDodaj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeDodaj.Location = new System.Drawing.Point(0, 391);
            this.dugmeDodaj.Name = "dugmeDodaj";
            this.dugmeDodaj.Size = new System.Drawing.Size(199, 68);
            this.dugmeDodaj.TabIndex = 3;
            this.dugmeDodaj.Text = "dodaj univerzitet";
            this.dugmeDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeDodaj.UseVisualStyleBackColor = true;
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
            this.dugmeNazad.Location = new System.Drawing.Point(-3, 317);
            this.dugmeNazad.Name = "dugmeNazad";
            this.dugmeNazad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dugmeNazad.Size = new System.Drawing.Size(199, 68);
            this.dugmeNazad.TabIndex = 1;
            this.dugmeNazad.Text = "nazad";
            this.dugmeNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeNazad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeNazad.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(0, 102);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(199, 215);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistem.Properties.Resources.univerzitet;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormaUpravljanjeZaposlenima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1010, 514);
            this.Controls.Add(this.panelNaslov);
            this.Controls.Add(this.panelMeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaUpravljanjeZaposlenima";
            this.Text = "FormaUpravljanjeZaposlenima";
            this.Load += new System.EventHandler(this.FormaUpravljanjeZaposlenima_Load);
            this.panelNaslov.ResumeLayout(false);
            this.panelMeni.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNaslov;
        private System.Windows.Forms.Label labelaNaslov;
        private System.Windows.Forms.Panel panelMeni;
        private FontAwesome.Sharp.IconButton dugmeDodaj;
        private FontAwesome.Sharp.IconButton dugmeNazad;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}