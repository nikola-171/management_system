
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.profesorIdUnos = new System.Windows.Forms.TextBox();
            this.profesorPrezimeUnos = new System.Windows.Forms.TextBox();
            this.profesorImeUnos = new System.Windows.Forms.TextBox();
            this.dugmePretragaProfesor = new FontAwesome.Sharp.IconButton();
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
            this.label1 = new System.Windows.Forms.Label();
            this.listaTip = new System.Windows.Forms.ComboBox();
            this.listaProfesor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listaPredmet = new System.Windows.Forms.ComboBox();
            this.dugmeDodajPredmet = new FontAwesome.Sharp.IconButton();
            this.BrojIndeksa = new System.Windows.Forms.Label();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.dugmeNazad = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelNaslov.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelMeni.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNaslov
            // 
            this.panelNaslov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelNaslov.Controls.Add(this.labelaNaslov);
            this.panelNaslov.Location = new System.Drawing.Point(0, 0);
            this.panelNaslov.Name = "panelNaslov";
            this.panelNaslov.Size = new System.Drawing.Size(1374, 113);
            this.panelNaslov.TabIndex = 21;
            this.panelNaslov.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNaslov_Paint);
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
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(228, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 423);
            this.panel1.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.profesorIdUnos);
            this.groupBox3.Controls.Add(this.profesorPrezimeUnos);
            this.groupBox3.Controls.Add(this.profesorImeUnos);
            this.groupBox3.Controls.Add(this.dugmePretragaProfesor);
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
            // profesorIdUnos
            // 
            this.profesorIdUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profesorIdUnos.Location = new System.Drawing.Point(83, 200);
            this.profesorIdUnos.Name = "profesorIdUnos";
            this.profesorIdUnos.Size = new System.Drawing.Size(160, 29);
            this.profesorIdUnos.TabIndex = 5;
            // 
            // profesorPrezimeUnos
            // 
            this.profesorPrezimeUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profesorPrezimeUnos.Location = new System.Drawing.Point(16, 146);
            this.profesorPrezimeUnos.Name = "profesorPrezimeUnos";
            this.profesorPrezimeUnos.Size = new System.Drawing.Size(227, 29);
            this.profesorPrezimeUnos.TabIndex = 4;
            // 
            // profesorImeUnos
            // 
            this.profesorImeUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profesorImeUnos.Location = new System.Drawing.Point(16, 76);
            this.profesorImeUnos.Name = "profesorImeUnos";
            this.profesorImeUnos.Size = new System.Drawing.Size(227, 29);
            this.profesorImeUnos.TabIndex = 3;
            // 
            // dugmePretragaProfesor
            // 
            this.dugmePretragaProfesor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dugmePretragaProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dugmePretragaProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmePretragaProfesor.FlatAppearance.BorderSize = 0;
            this.dugmePretragaProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmePretragaProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmePretragaProfesor.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dugmePretragaProfesor.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.dugmePretragaProfesor.IconColor = System.Drawing.Color.Black;
            this.dugmePretragaProfesor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmePretragaProfesor.Location = new System.Drawing.Point(16, 289);
            this.dugmePretragaProfesor.Margin = new System.Windows.Forms.Padding(0);
            this.dugmePretragaProfesor.Name = "dugmePretragaProfesor";
            this.dugmePretragaProfesor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dugmePretragaProfesor.Size = new System.Drawing.Size(227, 47);
            this.dugmePretragaProfesor.TabIndex = 11;
            this.dugmePretragaProfesor.Text = "pretraga";
            this.dugmePretragaProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dugmePretragaProfesor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmePretragaProfesor.UseVisualStyleBackColor = false;
            this.dugmePretragaProfesor.Click += new System.EventHandler(this.dugmePretragaProfesor_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(23, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 352);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "filtrirajte predmet";
            // 
            // predmetNazivUnos
            // 
            this.predmetNazivUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.predmetNazivUnos.Location = new System.Drawing.Point(15, 197);
            this.predmetNazivUnos.Name = "predmetNazivUnos";
            this.predmetNazivUnos.Size = new System.Drawing.Size(224, 29);
            this.predmetNazivUnos.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 35);
            this.label4.TabIndex = 36;
            this.label4.Text = "naziv:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // predmetDepartmanUnos
            // 
            this.predmetDepartmanUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.predmetDepartmanUnos.Location = new System.Drawing.Point(15, 97);
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
            this.dugmePretragaPredmet.Location = new System.Drawing.Point(15, 289);
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
            this.label6.Location = new System.Drawing.Point(11, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 35);
            this.label6.TabIndex = 29;
            this.label6.Text = "departman:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.listaTip.TabIndex = 8;
            // 
            // listaProfesor
            // 
            this.listaProfesor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listaProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaProfesor.FormattingEnabled = true;
            this.listaProfesor.Location = new System.Drawing.Point(24, 77);
            this.listaProfesor.Name = "listaProfesor";
            this.listaProfesor.Size = new System.Drawing.Size(245, 29);
            this.listaProfesor.TabIndex = 6;
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
            this.dugmeDodajPredmet.Location = new System.Drawing.Point(27, 289);
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
            this.panelMeni.Size = new System.Drawing.Size(222, 563);
            this.panelMeni.TabIndex = 22;
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
            this.dugmeNazad.Location = new System.Drawing.Point(0, 356);
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
            this.panelLogo.Size = new System.Drawing.Size(219, 242);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sistem.Properties.Resources.slika_profesor;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 242);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            this.Name = "FormaDodavanjeProfesoraPredmetu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodeljivanje predmeta profesoru";
            this.Load += new System.EventHandler(this.FormaDodavanjeProfesoraPredmetu_Load);
            this.panelNaslov.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panelMeni.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.ComboBox listaProfesor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox listaPredmet;
        private FontAwesome.Sharp.IconButton dugmePretragaPredmet;
        private System.Windows.Forms.TextBox predmetDepartmanUnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listaTip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox profesorIdUnos;
        private System.Windows.Forms.TextBox profesorPrezimeUnos;
        private System.Windows.Forms.TextBox profesorImeUnos;
        private FontAwesome.Sharp.IconButton dugmePretragaProfesor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox predmetNazivUnos;
        private System.Windows.Forms.Label label4;
    }
}