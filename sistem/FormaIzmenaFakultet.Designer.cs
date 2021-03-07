
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dugmeBrisi = new System.Windows.Forms.Button();
            this.dugmeNazad = new System.Windows.Forms.Button();
            this.dugmeIzmeni = new System.Windows.Forms.Button();
            this.mestoUnos = new System.Windows.Forms.TextBox();
            this.nazivUnos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.slikaUniverzitet = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slikaUniverzitet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dugmeBrisi);
            this.groupBox1.Controls.Add(this.dugmeNazad);
            this.groupBox1.Controls.Add(this.dugmeIzmeni);
            this.groupBox1.Controls.Add(this.mestoUnos);
            this.groupBox1.Controls.Add(this.nazivUnos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 287);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmeni fakultet";
            // 
            // dugmeBrisi
            // 
            this.dugmeBrisi.Location = new System.Drawing.Point(28, 235);
            this.dugmeBrisi.Name = "dugmeBrisi";
            this.dugmeBrisi.Size = new System.Drawing.Size(95, 34);
            this.dugmeBrisi.TabIndex = 8;
            this.dugmeBrisi.Text = "izbriši";
            this.dugmeBrisi.UseVisualStyleBackColor = true;
            this.dugmeBrisi.Click += new System.EventHandler(this.dugmeBrisi_Click);
            // 
            // dugmeNazad
            // 
            this.dugmeNazad.Location = new System.Drawing.Point(223, 235);
            this.dugmeNazad.Name = "dugmeNazad";
            this.dugmeNazad.Size = new System.Drawing.Size(92, 34);
            this.dugmeNazad.TabIndex = 7;
            this.dugmeNazad.Text = "nazad";
            this.dugmeNazad.UseVisualStyleBackColor = true;
            this.dugmeNazad.Click += new System.EventHandler(this.dugmeNazad_Click);
            // 
            // dugmeIzmeni
            // 
            this.dugmeIzmeni.Location = new System.Drawing.Point(129, 235);
            this.dugmeIzmeni.Name = "dugmeIzmeni";
            this.dugmeIzmeni.Size = new System.Drawing.Size(88, 34);
            this.dugmeIzmeni.TabIndex = 6;
            this.dugmeIzmeni.Text = "izmeni";
            this.dugmeIzmeni.UseVisualStyleBackColor = true;
            this.dugmeIzmeni.Click += new System.EventHandler(this.dugmeIzmeni_Click);
            // 
            // mestoUnos
            // 
            this.mestoUnos.Location = new System.Drawing.Point(129, 147);
            this.mestoUnos.Name = "mestoUnos";
            this.mestoUnos.Size = new System.Drawing.Size(186, 25);
            this.mestoUnos.TabIndex = 5;
            // 
            // nazivUnos
            // 
            this.nazivUnos.Location = new System.Drawing.Point(129, 78);
            this.nazivUnos.Name = "nazivUnos";
            this.nazivUnos.Size = new System.Drawing.Size(186, 25);
            this.nazivUnos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "grad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "naziv: ";
            // 
            // slikaUniverzitet
            // 
            this.slikaUniverzitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slikaUniverzitet.Image = global::sistem.Properties.Resources.univerzitet;
            this.slikaUniverzitet.Location = new System.Drawing.Point(388, 15);
            this.slikaUniverzitet.Name = "slikaUniverzitet";
            this.slikaUniverzitet.Size = new System.Drawing.Size(242, 287);
            this.slikaUniverzitet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikaUniverzitet.TabIndex = 2;
            this.slikaUniverzitet.TabStop = false;
            // 
            // FormaIzmenaFakultet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 319);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.slikaUniverzitet);
            this.Name = "FormaIzmenaFakultet";
            this.Text = "FormaIzmenaFakultet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slikaUniverzitet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dugmeBrisi;
        private System.Windows.Forms.Button dugmeNazad;
        private System.Windows.Forms.Button dugmeIzmeni;
        private System.Windows.Forms.TextBox mestoUnos;
        private System.Windows.Forms.TextBox nazivUnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox slikaUniverzitet;
    }
}