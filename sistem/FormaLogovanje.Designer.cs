
namespace sistem
{
    partial class FormaLogovanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaLogovanje));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelaUcitavanje = new System.Windows.Forms.Label();
            this.dugme_registracija = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dugme_logovanje = new System.Windows.Forms.Button();
            this.lozinka_unos = new System.Windows.Forms.TextBox();
            this.korisnicko_ime_unos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ulogujte se";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "lozinka:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.labelaUcitavanje);
            this.groupBox1.Controls.Add(this.dugme_registracija);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dugme_logovanje);
            this.groupBox1.Controls.Add(this.lozinka_unos);
            this.groupBox1.Controls.Add(this.korisnicko_ime_unos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulogujte se";
            // 
            // labelaUcitavanje
            // 
            this.labelaUcitavanje.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaUcitavanje.Location = new System.Drawing.Point(10, 216);
            this.labelaUcitavanje.Name = "labelaUcitavanje";
            this.labelaUcitavanje.Size = new System.Drawing.Size(248, 20);
            this.labelaUcitavanje.TabIndex = 8;
            this.labelaUcitavanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dugme_registracija
            // 
            this.dugme_registracija.BackColor = System.Drawing.Color.DarkGray;
            this.dugme_registracija.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme_registracija.Location = new System.Drawing.Point(120, 167);
            this.dugme_registracija.Name = "dugme_registracija";
            this.dugme_registracija.Size = new System.Drawing.Size(136, 36);
            this.dugme_registracija.TabIndex = 7;
            this.dugme_registracija.Text = "registracija";
            this.dugme_registracija.UseVisualStyleBackColor = false;
            this.dugme_registracija.Click += new System.EventHandler(this.dugme_registracija_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Registrujte se:";
            // 
            // dugme_logovanje
            // 
            this.dugme_logovanje.BackColor = System.Drawing.Color.DarkGray;
            this.dugme_logovanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugme_logovanje.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme_logovanje.Location = new System.Drawing.Point(13, 110);
            this.dugme_logovanje.Name = "dugme_logovanje";
            this.dugme_logovanje.Size = new System.Drawing.Size(244, 43);
            this.dugme_logovanje.TabIndex = 5;
            this.dugme_logovanje.Text = "prosledi";
            this.dugme_logovanje.UseVisualStyleBackColor = false;
            this.dugme_logovanje.Click += new System.EventHandler(this.dugme_logovanje_Click);
            // 
            // lozinka_unos
            // 
            this.lozinka_unos.Location = new System.Drawing.Point(131, 71);
            this.lozinka_unos.MaxLength = 15;
            this.lozinka_unos.Name = "lozinka_unos";
            this.lozinka_unos.Size = new System.Drawing.Size(127, 26);
            this.lozinka_unos.TabIndex = 4;
            this.lozinka_unos.UseSystemPasswordChar = true;
            // 
            // korisnicko_ime_unos
            // 
            this.korisnicko_ime_unos.Location = new System.Drawing.Point(131, 37);
            this.korisnicko_ime_unos.MaxLength = 15;
            this.korisnicko_ime_unos.Name = "korisnicko_ime_unos";
            this.korisnicko_ime_unos.Size = new System.Drawing.Size(127, 26);
            this.korisnicko_ime_unos.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormaLogovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(304, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormaLogovanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logovanje";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormaLogovanje_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lozinka_unos;
        private System.Windows.Forms.TextBox korisnicko_ime_unos;
        private System.Windows.Forms.Button dugme_logovanje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dugme_registracija;
        private System.Windows.Forms.Label labelaUcitavanje;
    }
}