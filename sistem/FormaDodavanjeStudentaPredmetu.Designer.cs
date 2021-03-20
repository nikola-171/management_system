
namespace sistem
{
    partial class FormaDodavanjeStudentaPredmetu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaDodavanjeStudentaPredmetu));
            this.panelNaslov = new System.Windows.Forms.Panel();
            this.labelaNaslov = new System.Windows.Forms.Label();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.dugmeNazad = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.studentDepartmanUnos = new System.Windows.Forms.TextBox();
            this.studentDepartman = new System.Windows.Forms.Label();
            this.studentBrojIndeksaUnos = new System.Windows.Forms.TextBox();
            this.studentPrezimeUnos = new System.Windows.Forms.TextBox();
            this.studentImeUnos = new System.Windows.Forms.TextBox();
            this.dugmePretragaStudenta = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.predmetNazivUnos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.predmetDepartmanUnos = new System.Windows.Forms.TextBox();
            this.dugmePretragaPredmet = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaStudent = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listaPredmet = new System.Windows.Forms.ComboBox();
            this.dugmeDodajPredmet = new FontAwesome.Sharp.IconButton();
            this.BrojIndeksa = new System.Windows.Forms.Label();
            this.panelNaslov.SuspendLayout();
            this.panelMeni.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNaslov
            // 
            this.panelNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelNaslov.Controls.Add(this.labelaNaslov);
            this.panelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNaslov.Location = new System.Drawing.Point(222, 0);
            this.panelNaslov.Name = "panelNaslov";
            this.panelNaslov.Size = new System.Drawing.Size(932, 113);
            this.panelNaslov.TabIndex = 24;
            // 
            // labelaNaslov
            // 
            this.labelaNaslov.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaNaslov.ForeColor = System.Drawing.Color.White;
            this.labelaNaslov.Location = new System.Drawing.Point(47, 34);
            this.labelaNaslov.Name = "labelaNaslov";
            this.labelaNaslov.Size = new System.Drawing.Size(335, 35);
            this.labelaNaslov.TabIndex = 2;
            this.labelaNaslov.Text = "Upravljanje predmetima";
            this.labelaNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panelMeni.Size = new System.Drawing.Size(222, 614);
            this.panelMeni.TabIndex = 26;
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
            this.dugmeNazad.Location = new System.Drawing.Point(0, 340);
            this.dugmeNazad.Name = "dugmeNazad";
            this.dugmeNazad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dugmeNazad.Size = new System.Drawing.Size(219, 68);
            this.dugmeNazad.TabIndex = 9;
            this.dugmeNazad.Text = "nazad";
            this.dugmeNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeNazad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeNazad.UseVisualStyleBackColor = true;
            this.dugmeNazad.Click += new System.EventHandler(this.dugmeNazad_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Location = new System.Drawing.Point(0, 112);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(219, 222);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sistem.Properties.Resources.slika_student;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 219);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.studentDepartmanUnos);
            this.groupBox3.Controls.Add(this.studentDepartman);
            this.groupBox3.Controls.Add(this.studentBrojIndeksaUnos);
            this.groupBox3.Controls.Add(this.studentPrezimeUnos);
            this.groupBox3.Controls.Add(this.studentImeUnos);
            this.groupBox3.Controls.Add(this.dugmePretragaStudenta);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(529, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 429);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "filtrirajte studenta";
            // 
            // studentDepartmanUnos
            // 
            this.studentDepartmanUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentDepartmanUnos.Location = new System.Drawing.Point(16, 301);
            this.studentDepartmanUnos.Name = "studentDepartmanUnos";
            this.studentDepartmanUnos.Size = new System.Drawing.Size(227, 29);
            this.studentDepartmanUnos.TabIndex = 30;
            // 
            // studentDepartman
            // 
            this.studentDepartman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentDepartman.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDepartman.ForeColor = System.Drawing.Color.White;
            this.studentDepartman.Location = new System.Drawing.Point(12, 263);
            this.studentDepartman.Name = "studentDepartman";
            this.studentDepartman.Size = new System.Drawing.Size(231, 35);
            this.studentDepartman.TabIndex = 31;
            this.studentDepartman.Text = "departman:";
            this.studentDepartman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentBrojIndeksaUnos
            // 
            this.studentBrojIndeksaUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentBrojIndeksaUnos.Location = new System.Drawing.Point(16, 228);
            this.studentBrojIndeksaUnos.Name = "studentBrojIndeksaUnos";
            this.studentBrojIndeksaUnos.Size = new System.Drawing.Size(227, 29);
            this.studentBrojIndeksaUnos.TabIndex = 5;
            // 
            // studentPrezimeUnos
            // 
            this.studentPrezimeUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentPrezimeUnos.Location = new System.Drawing.Point(16, 150);
            this.studentPrezimeUnos.Name = "studentPrezimeUnos";
            this.studentPrezimeUnos.Size = new System.Drawing.Size(227, 29);
            this.studentPrezimeUnos.TabIndex = 4;
            // 
            // studentImeUnos
            // 
            this.studentImeUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentImeUnos.Location = new System.Drawing.Point(16, 70);
            this.studentImeUnos.Name = "studentImeUnos";
            this.studentImeUnos.Size = new System.Drawing.Size(227, 29);
            this.studentImeUnos.TabIndex = 3;
            // 
            // dugmePretragaStudenta
            // 
            this.dugmePretragaStudenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dugmePretragaStudenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dugmePretragaStudenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmePretragaStudenta.FlatAppearance.BorderSize = 0;
            this.dugmePretragaStudenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmePretragaStudenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmePretragaStudenta.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dugmePretragaStudenta.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.dugmePretragaStudenta.IconColor = System.Drawing.Color.Black;
            this.dugmePretragaStudenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmePretragaStudenta.Location = new System.Drawing.Point(16, 358);
            this.dugmePretragaStudenta.Margin = new System.Windows.Forms.Padding(0);
            this.dugmePretragaStudenta.Name = "dugmePretragaStudenta";
            this.dugmePretragaStudenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dugmePretragaStudenta.Size = new System.Drawing.Size(227, 47);
            this.dugmePretragaStudenta.TabIndex = 11;
            this.dugmePretragaStudenta.Text = "pretraga";
            this.dugmePretragaStudenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dugmePretragaStudenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmePretragaStudenta.UseVisualStyleBackColor = false;
            this.dugmePretragaStudenta.Click += new System.EventHandler(this.dugmePretragaStudenta_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 35);
            this.label2.TabIndex = 29;
            this.label2.Text = "broj indeksa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "prezime:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 35);
            this.label8.TabIndex = 25;
            this.label8.Text = "ime:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.predmetNazivUnos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.predmetDepartmanUnos);
            this.groupBox2.Controls.Add(this.dugmePretragaPredmet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(242, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 429);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "filtrirajte predmet";
            // 
            // predmetNazivUnos
            // 
            this.predmetNazivUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.predmetNazivUnos.Location = new System.Drawing.Point(18, 215);
            this.predmetNazivUnos.Name = "predmetNazivUnos";
            this.predmetNazivUnos.Size = new System.Drawing.Size(224, 29);
            this.predmetNazivUnos.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 35);
            this.label4.TabIndex = 36;
            this.label4.Text = "naziv:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // predmetDepartmanUnos
            // 
            this.predmetDepartmanUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.predmetDepartmanUnos.Location = new System.Drawing.Point(18, 109);
            this.predmetDepartmanUnos.Name = "predmetDepartmanUnos";
            this.predmetDepartmanUnos.Size = new System.Drawing.Size(224, 29);
            this.predmetDepartmanUnos.TabIndex = 1;
            // 
            // dugmePretragaPredmet
            // 
            this.dugmePretragaPredmet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dugmePretragaPredmet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dugmePretragaPredmet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmePretragaPredmet.FlatAppearance.BorderSize = 0;
            this.dugmePretragaPredmet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmePretragaPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmePretragaPredmet.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dugmePretragaPredmet.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.dugmePretragaPredmet.IconColor = System.Drawing.Color.Black;
            this.dugmePretragaPredmet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmePretragaPredmet.Location = new System.Drawing.Point(18, 358);
            this.dugmePretragaPredmet.Margin = new System.Windows.Forms.Padding(0);
            this.dugmePretragaPredmet.Name = "dugmePretragaPredmet";
            this.dugmePretragaPredmet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dugmePretragaPredmet.Size = new System.Drawing.Size(214, 47);
            this.dugmePretragaPredmet.TabIndex = 10;
            this.dugmePretragaPredmet.Text = "pretraga";
            this.dugmePretragaPredmet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dugmePretragaPredmet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmePretragaPredmet.UseVisualStyleBackColor = false;
            this.dugmePretragaPredmet.Click += new System.EventHandler(this.dugmePretragaPredmet_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 35);
            this.label6.TabIndex = 29;
            this.label6.Text = "departman:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.listaStudent);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.listaPredmet);
            this.groupBox1.Controls.Add(this.dugmeDodajPredmet);
            this.groupBox1.Controls.Add(this.BrojIndeksa);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(816, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 429);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "izaberite studentai predmet";
            // 
            // listaStudent
            // 
            this.listaStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listaStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaStudent.FormattingEnabled = true;
            this.listaStudent.Location = new System.Drawing.Point(24, 121);
            this.listaStudent.Name = "listaStudent";
            this.listaStudent.Size = new System.Drawing.Size(245, 29);
            this.listaStudent.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 176);
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
            this.listaPredmet.Location = new System.Drawing.Point(24, 228);
            this.listaPredmet.Name = "listaPredmet";
            this.listaPredmet.Size = new System.Drawing.Size(245, 29);
            this.listaPredmet.TabIndex = 7;
            // 
            // dugmeDodajPredmet
            // 
            this.dugmeDodajPredmet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dugmeDodajPredmet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeDodajPredmet.FlatAppearance.BorderSize = 0;
            this.dugmeDodajPredmet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeDodajPredmet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeDodajPredmet.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dugmeDodajPredmet.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.dugmeDodajPredmet.IconColor = System.Drawing.Color.Black;
            this.dugmeDodajPredmet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeDodajPredmet.Location = new System.Drawing.Point(15, 358);
            this.dugmeDodajPredmet.Name = "dugmeDodajPredmet";
            this.dugmeDodajPredmet.Size = new System.Drawing.Size(242, 47);
            this.dugmeDodajPredmet.TabIndex = 12;
            this.dugmeDodajPredmet.Text = "dodaj predmet";
            this.dugmeDodajPredmet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeDodajPredmet.UseVisualStyleBackColor = false;
            this.dugmeDodajPredmet.Click += new System.EventHandler(this.dugmeDodajPredmet_Click);
            // 
            // BrojIndeksa
            // 
            this.BrojIndeksa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrojIndeksa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrojIndeksa.ForeColor = System.Drawing.Color.White;
            this.BrojIndeksa.Location = new System.Drawing.Point(20, 64);
            this.BrojIndeksa.Name = "BrojIndeksa";
            this.BrojIndeksa.Size = new System.Drawing.Size(92, 35);
            this.BrojIndeksa.TabIndex = 20;
            this.BrojIndeksa.Text = "student:";
            this.BrojIndeksa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormaDodavanjeStudentaPredmetu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1154, 614);
            this.Controls.Add(this.panelNaslov);
            this.Controls.Add(this.panelMeni);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaDodavanjeStudentaPredmetu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje predmeta studentu";
            this.Load += new System.EventHandler(this.FormaDodavanjeStudentaPredmetu_Load);
            this.panelNaslov.ResumeLayout(false);
            this.panelMeni.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNaslov;
        private System.Windows.Forms.Label labelaNaslov;
        private FontAwesome.Sharp.IconButton dugmeNazad;
        private System.Windows.Forms.Panel panelMeni;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox studentBrojIndeksaUnos;
        private System.Windows.Forms.TextBox studentPrezimeUnos;
        private System.Windows.Forms.TextBox studentImeUnos;
        private FontAwesome.Sharp.IconButton dugmePretragaStudenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox predmetNazivUnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox predmetDepartmanUnos;
        private FontAwesome.Sharp.IconButton dugmePretragaPredmet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox listaStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox listaPredmet;
        private FontAwesome.Sharp.IconButton dugmeDodajPredmet;
        private System.Windows.Forms.Label BrojIndeksa;
        private System.Windows.Forms.TextBox studentDepartmanUnos;
        private System.Windows.Forms.Label studentDepartman;
    }
}