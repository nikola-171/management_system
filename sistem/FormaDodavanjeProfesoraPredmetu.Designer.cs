
namespace sistem
{
    partial class FormaDodavanjeProfesoraPredmetu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaDodavanjeProfesoraPredmetu));
            this.panelNaslov = new System.Windows.Forms.Panel();
            this.labelaNaslov = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dugmeNazad = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dugmePretraga = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaProfesor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listaPredmet = new System.Windows.Forms.ComboBox();
            this.dugmeDodajPredmet = new FontAwesome.Sharp.IconButton();
            this.BrojIndeksa = new System.Windows.Forms.Label();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listaTip = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelNaslov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelMeni.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNaslov
            // 
            this.panelNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelNaslov.Controls.Add(this.labelaNaslov);
            this.panelNaslov.Location = new System.Drawing.Point(0, 0);
            this.panelNaslov.Name = "panelNaslov";
            this.panelNaslov.Size = new System.Drawing.Size(1374, 113);
            this.panelNaslov.TabIndex = 21;
            // 
            // labelaNaslov
            // 
            this.labelaNaslov.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaNaslov.ForeColor = System.Drawing.Color.White;
            this.labelaNaslov.Location = new System.Drawing.Point(196, 41);
            this.labelaNaslov.Name = "labelaNaslov";
            this.labelaNaslov.Size = new System.Drawing.Size(335, 35);
            this.labelaNaslov.TabIndex = 2;
            this.labelaNaslov.Text = "Upravljanje predmetima";
            this.labelaNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sistem.Properties.Resources.title1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            this.dugmeNazad.Location = new System.Drawing.Point(0, 303);
            this.dugmeNazad.Name = "dugmeNazad";
            this.dugmeNazad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dugmeNazad.Size = new System.Drawing.Size(199, 68);
            this.dugmeNazad.TabIndex = 3;
            this.dugmeNazad.Text = "nazad";
            this.dugmeNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeNazad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeNazad.UseVisualStyleBackColor = true;
            this.dugmeNazad.Click += new System.EventHandler(this.dugmeNazad_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(228, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 423);
            this.panel1.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dugmePretraga);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(23, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 352);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "filtrirajte predmet";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(15, 232);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 29);
            this.textBox3.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(14, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 29);
            this.textBox2.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(15, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 29);
            this.textBox1.TabIndex = 33;
            // 
            // dugmePretraga
            // 
            this.dugmePretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dugmePretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dugmePretraga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmePretraga.FlatAppearance.BorderSize = 0;
            this.dugmePretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmePretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmePretraga.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dugmePretraga.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.dugmePretraga.IconColor = System.Drawing.Color.Black;
            this.dugmePretraga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmePretraga.Location = new System.Drawing.Point(15, 289);
            this.dugmePretraga.Margin = new System.Windows.Forms.Padding(0);
            this.dugmePretraga.Name = "dugmePretraga";
            this.dugmePretraga.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dugmePretraga.Size = new System.Drawing.Size(214, 47);
            this.dugmePretraga.TabIndex = 30;
            this.dugmePretraga.Text = "pretraga";
            this.dugmePretraga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dugmePretraga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmePretraga.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 35);
            this.label6.TabIndex = 29;
            this.label6.Text = "departman:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 35);
            this.label5.TabIndex = 27;
            this.label5.Text = "fakultet:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 35);
            this.label4.TabIndex = 25;
            this.label4.Text = "univerzitet:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listaTip);
            this.groupBox1.Controls.Add(this.listaProfesor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.listaPredmet);
            this.groupBox1.Controls.Add(this.dugmeDodajPredmet);
            this.groupBox1.Controls.Add(this.BrojIndeksa);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(545, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 352);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "izaberite profesora i predmet";
            // 
            // listaProfesor
            // 
            this.listaProfesor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listaProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaProfesor.FormattingEnabled = true;
            this.listaProfesor.Location = new System.Drawing.Point(24, 77);
            this.listaProfesor.Name = "listaProfesor";
            this.listaProfesor.Size = new System.Drawing.Size(245, 29);
            this.listaProfesor.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 35);
            this.label7.TabIndex = 31;
            this.label7.Text = "predmet:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaPredmet
            // 
            this.listaPredmet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listaPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaPredmet.FormattingEnabled = true;
            this.listaPredmet.Location = new System.Drawing.Point(24, 154);
            this.listaPredmet.Name = "listaPredmet";
            this.listaPredmet.Size = new System.Drawing.Size(245, 29);
            this.listaPredmet.TabIndex = 30;
            // 
            // dugmeDodajPredmet
            // 
            this.dugmeDodajPredmet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dugmeDodajPredmet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeDodajPredmet.Enabled = false;
            this.dugmeDodajPredmet.FlatAppearance.BorderSize = 0;
            this.dugmeDodajPredmet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeDodajPredmet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeDodajPredmet.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dugmeDodajPredmet.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.dugmeDodajPredmet.IconColor = System.Drawing.Color.Black;
            this.dugmeDodajPredmet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeDodajPredmet.Location = new System.Drawing.Point(27, 289);
            this.dugmeDodajPredmet.Name = "dugmeDodajPredmet";
            this.dugmeDodajPredmet.Size = new System.Drawing.Size(242, 47);
            this.dugmeDodajPredmet.TabIndex = 28;
            this.dugmeDodajPredmet.Text = "dodaj predmet";
            this.dugmeDodajPredmet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeDodajPredmet.UseVisualStyleBackColor = false;
            // 
            // BrojIndeksa
            // 
            this.BrojIndeksa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrojIndeksa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrojIndeksa.ForeColor = System.Drawing.Color.White;
            this.BrojIndeksa.Location = new System.Drawing.Point(23, 38);
            this.BrojIndeksa.Name = "BrojIndeksa";
            this.BrojIndeksa.Size = new System.Drawing.Size(92, 35);
            this.BrojIndeksa.TabIndex = 20;
            this.BrojIndeksa.Text = "profesor:";
            this.BrojIndeksa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMeni.Controls.Add(this.dugmeNazad);
            this.panelMeni.Controls.Add(this.panelLogo);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMeni.Location = new System.Drawing.Point(0, 0);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(199, 563);
            this.panelMeni.TabIndex = 22;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Location = new System.Drawing.Point(0, 112);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(199, 194);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 35);
            this.label1.TabIndex = 34;
            this.label1.Text = "tip:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaTip
            // 
            this.listaTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listaTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaTip.FormattingEnabled = true;
            this.listaTip.Location = new System.Drawing.Point(27, 227);
            this.listaTip.Name = "listaTip";
            this.listaTip.Size = new System.Drawing.Size(245, 29);
            this.listaTip.TabIndex = 33;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.iconButton1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(279, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 352);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "filtrirajte profesora";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(83, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 29);
            this.textBox4.TabIndex = 35;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(16, 146);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(227, 29);
            this.textBox5.TabIndex = 34;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.Location = new System.Drawing.Point(16, 76);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(227, 29);
            this.textBox6.TabIndex = 33;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(16, 289);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton1.Size = new System.Drawing.Size(227, 47);
            this.iconButton1.TabIndex = 30;
            this.iconButton1.Text = "pretraga";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 35);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "prezime:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 35);
            this.label8.TabIndex = 25;
            this.label8.Text = "ime:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormaDodavanjeProfesoraPredmetu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1137, 563);
            this.Controls.Add(this.panelNaslov);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormaDodavanjeProfesoraPredmetu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaDodavanjeProfesoraPredmetu";
            this.Load += new System.EventHandler(this.FormaDodavanjeProfesoraPredmetu_Load);
            this.panelNaslov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panelMeni.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNaslov;
        private System.Windows.Forms.Label labelaNaslov;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton dugmeNazad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton dugmeDodajPredmet;
        private System.Windows.Forms.Label BrojIndeksa;
        private System.Windows.Forms.Panel panelMeni;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox listaProfesor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox listaPredmet;
        private FontAwesome.Sharp.IconButton dugmePretraga;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listaTip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}