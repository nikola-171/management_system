﻿
namespace sistem
{
    partial class FormaDodavanjeUniverziteta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaDodavanjeUniverziteta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dugmeNazad = new System.Windows.Forms.Button();
            this.dugmeProsledi = new System.Windows.Forms.Button();
            this.gradUnos = new System.Windows.Forms.TextBox();
            this.drzavaUnos = new System.Windows.Forms.TextBox();
            this.nazivUnos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.dugmeNazad);
            this.groupBox1.Controls.Add(this.dugmeProsledi);
            this.groupBox1.Controls.Add(this.gradUnos);
            this.groupBox1.Controls.Add(this.drzavaUnos);
            this.groupBox1.Controls.Add(this.nazivUnos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-2, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 287);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj univerzitet";
            // 
            // dugmeNazad
            // 
            this.dugmeNazad.Location = new System.Drawing.Point(185, 235);
            this.dugmeNazad.Name = "dugmeNazad";
            this.dugmeNazad.Size = new System.Drawing.Size(123, 34);
            this.dugmeNazad.TabIndex = 7;
            this.dugmeNazad.Text = "nazad";
            this.dugmeNazad.UseVisualStyleBackColor = true;
            this.dugmeNazad.Click += new System.EventHandler(this.dugmeNazad_Click);
            // 
            // dugmeProsledi
            // 
            this.dugmeProsledi.Location = new System.Drawing.Point(60, 235);
            this.dugmeProsledi.Name = "dugmeProsledi";
            this.dugmeProsledi.Size = new System.Drawing.Size(119, 34);
            this.dugmeProsledi.TabIndex = 6;
            this.dugmeProsledi.Text = "prosledi";
            this.dugmeProsledi.UseVisualStyleBackColor = true;
            this.dugmeProsledi.Click += new System.EventHandler(this.dugmeProsledi_Click);
            // 
            // gradUnos
            // 
            this.gradUnos.Location = new System.Drawing.Point(129, 176);
            this.gradUnos.Name = "gradUnos";
            this.gradUnos.Size = new System.Drawing.Size(186, 25);
            this.gradUnos.TabIndex = 5;
            // 
            // drzavaUnos
            // 
            this.drzavaUnos.Location = new System.Drawing.Point(129, 113);
            this.drzavaUnos.Name = "drzavaUnos";
            this.drzavaUnos.Size = new System.Drawing.Size(186, 25);
            this.drzavaUnos.TabIndex = 4;
            // 
            // nazivUnos
            // 
            this.nazivUnos.Location = new System.Drawing.Point(129, 48);
            this.nazivUnos.Name = "nazivUnos";
            this.nazivUnos.Size = new System.Drawing.Size(186, 25);
            this.nazivUnos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "grad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "država:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "naziv: ";
            // 
            // slikaUniverzitet
            // 
            this.slikaUniverzitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slikaUniverzitet.Image = global::sistem.Properties.Resources.univerzitet;
            this.slikaUniverzitet.Location = new System.Drawing.Point(373, 10);
            this.slikaUniverzitet.Name = "slikaUniverzitet";
            this.slikaUniverzitet.Size = new System.Drawing.Size(246, 287);
            this.slikaUniverzitet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikaUniverzitet.TabIndex = 2;
            this.slikaUniverzitet.TabStop = false;
            // 
            // FormaDodavanjeUniverziteta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.slikaUniverzitet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaDodavanjeUniverziteta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje univerziteta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slikaUniverzitet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dugmeNazad;
        private System.Windows.Forms.Button dugmeProsledi;
        private System.Windows.Forms.TextBox gradUnos;
        private System.Windows.Forms.TextBox drzavaUnos;
        private System.Windows.Forms.TextBox nazivUnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox slikaUniverzitet;
    }
}