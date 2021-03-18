
namespace sistem
{
    partial class FormaUpravljanjeStudentima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaUpravljanjeStudentima));
            this.panelNaslov = new System.Windows.Forms.Panel();
            this.labelaNaslov = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.dugmeDodajStudenta = new FontAwesome.Sharp.IconButton();
            this.dugmeNazad = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelaPretraga = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPrikazRezultata = new System.Windows.Forms.Panel();
            this.dugmeUkloniProfesora = new FontAwesome.Sharp.IconButton();
            this.labelaStatus = new System.Windows.Forms.Label();
            this.prosekPrikaz = new System.Windows.Forms.Label();
            this.labelaSmer = new System.Windows.Forms.Label();
            this.labelaProsek = new System.Windows.Forms.Label();
            this.smerPrikaz = new System.Windows.Forms.Label();
            this.diplomiraoPrikaz = new System.Windows.Forms.Label();
            this.fakultetPrikaz = new System.Windows.Forms.Label();
            this.labelaDiplomirao = new System.Windows.Forms.Label();
            this.statusPrikaz = new System.Windows.Forms.Label();
            this.espbPrikaz = new System.Windows.Forms.Label();
            this.labelaFakultet = new System.Windows.Forms.Label();
            this.labelaEspb = new System.Windows.Forms.Label();
            this.labelaStudent = new System.Windows.Forms.Label();
            this.brojIndeksaPrikaz = new System.Windows.Forms.Label();
            this.studentImePrikaz = new System.Windows.Forms.Label();
            this.labelaBrojIndeksa = new System.Windows.Forms.Label();
            this.dugmePretraga = new FontAwesome.Sharp.IconButton();
            this.brojIndeksaUnos = new System.Windows.Forms.TextBox();
            this.BrojIndeksa = new System.Windows.Forms.Label();
            this.jmbgPrikaz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panelNaslov.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMeni.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPrikazRezultata.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNaslov
            // 
            this.panelNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelNaslov.Controls.Add(this.labelaNaslov);
            this.panelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNaslov.Location = new System.Drawing.Point(0, 0);
            this.panelNaslov.Name = "panelNaslov";
            this.panelNaslov.Size = new System.Drawing.Size(981, 93);
            this.panelNaslov.TabIndex = 9;
            // 
            // labelaNaslov
            // 
            this.labelaNaslov.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaNaslov.ForeColor = System.Drawing.Color.White;
            this.labelaNaslov.Location = new System.Drawing.Point(215, 35);
            this.labelaNaslov.Name = "labelaNaslov";
            this.labelaNaslov.Size = new System.Drawing.Size(335, 35);
            this.labelaNaslov.TabIndex = 2;
            this.labelaNaslov.Text = "Upravljanje studentima";
            this.labelaNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(199, 174);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sistem.Properties.Resources.student_ikonica;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMeni.Controls.Add(this.dugmeDodajStudenta);
            this.panelMeni.Controls.Add(this.dugmeNazad);
            this.panelMeni.Controls.Add(this.panelLogo);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMeni.Location = new System.Drawing.Point(0, 93);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(199, 485);
            this.panelMeni.TabIndex = 10;
            // 
            // dugmeDodajStudenta
            // 
            this.dugmeDodajStudenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeDodajStudenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.dugmeDodajStudenta.FlatAppearance.BorderSize = 0;
            this.dugmeDodajStudenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeDodajStudenta.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dugmeDodajStudenta.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.dugmeDodajStudenta.IconColor = System.Drawing.Color.Black;
            this.dugmeDodajStudenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeDodajStudenta.Location = new System.Drawing.Point(0, 242);
            this.dugmeDodajStudenta.Name = "dugmeDodajStudenta";
            this.dugmeDodajStudenta.Size = new System.Drawing.Size(199, 68);
            this.dugmeDodajStudenta.TabIndex = 4;
            this.dugmeDodajStudenta.Text = "dodaj studenta";
            this.dugmeDodajStudenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeDodajStudenta.UseVisualStyleBackColor = true;
            this.dugmeDodajStudenta.Click += new System.EventHandler(this.dugmeDodajStudenta_Click);
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
            this.dugmeNazad.Location = new System.Drawing.Point(0, 174);
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
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelaPretraga);
            this.panel1.Location = new System.Drawing.Point(221, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 85);
            this.panel1.TabIndex = 11;
            // 
            // labelaPretraga
            // 
            this.labelaPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelaPretraga.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaPretraga.ForeColor = System.Drawing.Color.White;
            this.labelaPretraga.Location = new System.Drawing.Point(39, 25);
            this.labelaPretraga.Name = "labelaPretraga";
            this.labelaPretraga.Size = new System.Drawing.Size(662, 35);
            this.labelaPretraga.TabIndex = 3;
            this.labelaPretraga.Text = "Pretraga studenata na osnovu broja indeksa";
            this.labelaPretraga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelPrikazRezultata);
            this.panel2.Controls.Add(this.dugmePretraga);
            this.panel2.Controls.Add(this.brojIndeksaUnos);
            this.panel2.Controls.Add(this.BrojIndeksa);
            this.panel2.Location = new System.Drawing.Point(221, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 358);
            this.panel2.TabIndex = 12;
            // 
            // panelPrikazRezultata
            // 
            this.panelPrikazRezultata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPrikazRezultata.Controls.Add(this.iconButton2);
            this.panelPrikazRezultata.Controls.Add(this.iconButton1);
            this.panelPrikazRezultata.Controls.Add(this.jmbgPrikaz);
            this.panelPrikazRezultata.Controls.Add(this.label2);
            this.panelPrikazRezultata.Controls.Add(this.dugmeUkloniProfesora);
            this.panelPrikazRezultata.Controls.Add(this.labelaStatus);
            this.panelPrikazRezultata.Controls.Add(this.prosekPrikaz);
            this.panelPrikazRezultata.Controls.Add(this.labelaSmer);
            this.panelPrikazRezultata.Controls.Add(this.labelaProsek);
            this.panelPrikazRezultata.Controls.Add(this.smerPrikaz);
            this.panelPrikazRezultata.Controls.Add(this.diplomiraoPrikaz);
            this.panelPrikazRezultata.Controls.Add(this.fakultetPrikaz);
            this.panelPrikazRezultata.Controls.Add(this.labelaDiplomirao);
            this.panelPrikazRezultata.Controls.Add(this.statusPrikaz);
            this.panelPrikazRezultata.Controls.Add(this.espbPrikaz);
            this.panelPrikazRezultata.Controls.Add(this.labelaFakultet);
            this.panelPrikazRezultata.Controls.Add(this.labelaEspb);
            this.panelPrikazRezultata.Controls.Add(this.labelaStudent);
            this.panelPrikazRezultata.Controls.Add(this.brojIndeksaPrikaz);
            this.panelPrikazRezultata.Controls.Add(this.studentImePrikaz);
            this.panelPrikazRezultata.Controls.Add(this.labelaBrojIndeksa);
            this.panelPrikazRezultata.Location = new System.Drawing.Point(3, 112);
            this.panelPrikazRezultata.Name = "panelPrikazRezultata";
            this.panelPrikazRezultata.Size = new System.Drawing.Size(740, 245);
            this.panelPrikazRezultata.TabIndex = 23;
            this.panelPrikazRezultata.Visible = false;
            // 
            // dugmeUkloniProfesora
            // 
            this.dugmeUkloniProfesora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dugmeUkloniProfesora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeUkloniProfesora.Enabled = false;
            this.dugmeUkloniProfesora.FlatAppearance.BorderSize = 0;
            this.dugmeUkloniProfesora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeUkloniProfesora.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeUkloniProfesora.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dugmeUkloniProfesora.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.dugmeUkloniProfesora.IconColor = System.Drawing.Color.Black;
            this.dugmeUkloniProfesora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeUkloniProfesora.Location = new System.Drawing.Point(303, 170);
            this.dugmeUkloniProfesora.Name = "dugmeUkloniProfesora";
            this.dugmeUkloniProfesora.Size = new System.Drawing.Size(138, 49);
            this.dugmeUkloniProfesora.TabIndex = 23;
            this.dugmeUkloniProfesora.Text = "ukloni studenta";
            this.dugmeUkloniProfesora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeUkloniProfesora.UseVisualStyleBackColor = false;
            this.dugmeUkloniProfesora.Click += new System.EventHandler(this.dugmeUkloniStudenta_Click);
            // 
            // labelaStatus
            // 
            this.labelaStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaStatus.ForeColor = System.Drawing.Color.White;
            this.labelaStatus.Location = new System.Drawing.Point(336, 54);
            this.labelaStatus.Name = "labelaStatus";
            this.labelaStatus.Size = new System.Drawing.Size(66, 35);
            this.labelaStatus.TabIndex = 17;
            this.labelaStatus.Text = "status:";
            this.labelaStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prosekPrikaz
            // 
            this.prosekPrikaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prosekPrikaz.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prosekPrikaz.ForeColor = System.Drawing.Color.White;
            this.prosekPrikaz.Location = new System.Drawing.Point(153, 100);
            this.prosekPrikaz.Name = "prosekPrikaz";
            this.prosekPrikaz.Size = new System.Drawing.Size(117, 35);
            this.prosekPrikaz.TabIndex = 22;
            this.prosekPrikaz.Text = "nedefinisano";
            this.prosekPrikaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelaSmer
            // 
            this.labelaSmer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaSmer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaSmer.ForeColor = System.Drawing.Color.White;
            this.labelaSmer.Location = new System.Drawing.Point(342, 123);
            this.labelaSmer.Name = "labelaSmer";
            this.labelaSmer.Size = new System.Drawing.Size(60, 35);
            this.labelaSmer.TabIndex = 11;
            this.labelaSmer.Text = "smer:";
            this.labelaSmer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelaProsek
            // 
            this.labelaProsek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaProsek.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaProsek.ForeColor = System.Drawing.Color.White;
            this.labelaProsek.Location = new System.Drawing.Point(61, 100);
            this.labelaProsek.Name = "labelaProsek";
            this.labelaProsek.Size = new System.Drawing.Size(86, 35);
            this.labelaProsek.TabIndex = 21;
            this.labelaProsek.Text = "prosek:";
            this.labelaProsek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // smerPrikaz
            // 
            this.smerPrikaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.smerPrikaz.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smerPrikaz.ForeColor = System.Drawing.Color.White;
            this.smerPrikaz.Location = new System.Drawing.Point(408, 123);
            this.smerPrikaz.Name = "smerPrikaz";
            this.smerPrikaz.Size = new System.Drawing.Size(293, 35);
            this.smerPrikaz.TabIndex = 12;
            this.smerPrikaz.Text = "nedefinisano";
            this.smerPrikaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // diplomiraoPrikaz
            // 
            this.diplomiraoPrikaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diplomiraoPrikaz.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diplomiraoPrikaz.ForeColor = System.Drawing.Color.White;
            this.diplomiraoPrikaz.Location = new System.Drawing.Point(156, 170);
            this.diplomiraoPrikaz.Name = "diplomiraoPrikaz";
            this.diplomiraoPrikaz.Size = new System.Drawing.Size(119, 35);
            this.diplomiraoPrikaz.TabIndex = 16;
            this.diplomiraoPrikaz.Text = "nedefinisano";
            this.diplomiraoPrikaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fakultetPrikaz
            // 
            this.fakultetPrikaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fakultetPrikaz.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fakultetPrikaz.ForeColor = System.Drawing.Color.White;
            this.fakultetPrikaz.Location = new System.Drawing.Point(408, 89);
            this.fakultetPrikaz.Name = "fakultetPrikaz";
            this.fakultetPrikaz.Size = new System.Drawing.Size(293, 35);
            this.fakultetPrikaz.TabIndex = 20;
            this.fakultetPrikaz.Text = "nedefinisano";
            this.fakultetPrikaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelaDiplomirao
            // 
            this.labelaDiplomirao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaDiplomirao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaDiplomirao.ForeColor = System.Drawing.Color.White;
            this.labelaDiplomirao.Location = new System.Drawing.Point(24, 170);
            this.labelaDiplomirao.Name = "labelaDiplomirao";
            this.labelaDiplomirao.Size = new System.Drawing.Size(126, 35);
            this.labelaDiplomirao.TabIndex = 15;
            this.labelaDiplomirao.Text = "Diplomirao:";
            this.labelaDiplomirao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusPrikaz
            // 
            this.statusPrikaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusPrikaz.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPrikaz.ForeColor = System.Drawing.Color.White;
            this.statusPrikaz.Location = new System.Drawing.Point(408, 54);
            this.statusPrikaz.Name = "statusPrikaz";
            this.statusPrikaz.Size = new System.Drawing.Size(223, 35);
            this.statusPrikaz.TabIndex = 18;
            this.statusPrikaz.Text = "nedefinisano";
            this.statusPrikaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // espbPrikaz
            // 
            this.espbPrikaz.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.espbPrikaz.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espbPrikaz.ForeColor = System.Drawing.Color.White;
            this.espbPrikaz.Location = new System.Drawing.Point(153, 135);
            this.espbPrikaz.Name = "espbPrikaz";
            this.espbPrikaz.Size = new System.Drawing.Size(122, 35);
            this.espbPrikaz.TabIndex = 14;
            this.espbPrikaz.Text = "nedefinisano";
            this.espbPrikaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelaFakultet
            // 
            this.labelaFakultet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaFakultet.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaFakultet.ForeColor = System.Drawing.Color.White;
            this.labelaFakultet.Location = new System.Drawing.Point(320, 89);
            this.labelaFakultet.Name = "labelaFakultet";
            this.labelaFakultet.Size = new System.Drawing.Size(82, 35);
            this.labelaFakultet.TabIndex = 19;
            this.labelaFakultet.Text = "fakultet:";
            this.labelaFakultet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelaEspb
            // 
            this.labelaEspb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaEspb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaEspb.ForeColor = System.Drawing.Color.White;
            this.labelaEspb.Location = new System.Drawing.Point(77, 135);
            this.labelaEspb.Name = "labelaEspb";
            this.labelaEspb.Size = new System.Drawing.Size(53, 35);
            this.labelaEspb.TabIndex = 13;
            this.labelaEspb.Text = "espb:";
            this.labelaEspb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelaStudent
            // 
            this.labelaStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelaStudent.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaStudent.ForeColor = System.Drawing.Color.White;
            this.labelaStudent.Location = new System.Drawing.Point(37, 22);
            this.labelaStudent.Name = "labelaStudent";
            this.labelaStudent.Size = new System.Drawing.Size(93, 35);
            this.labelaStudent.TabIndex = 8;
            this.labelaStudent.Text = "Student:";
            this.labelaStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // brojIndeksaPrikaz
            // 
            this.brojIndeksaPrikaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brojIndeksaPrikaz.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojIndeksaPrikaz.ForeColor = System.Drawing.Color.White;
            this.brojIndeksaPrikaz.Location = new System.Drawing.Point(153, 65);
            this.brojIndeksaPrikaz.Name = "brojIndeksaPrikaz";
            this.brojIndeksaPrikaz.Size = new System.Drawing.Size(132, 35);
            this.brojIndeksaPrikaz.TabIndex = 10;
            this.brojIndeksaPrikaz.Text = "nedefinisano";
            this.brojIndeksaPrikaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentImePrikaz
            // 
            this.studentImePrikaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentImePrikaz.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentImePrikaz.ForeColor = System.Drawing.Color.White;
            this.studentImePrikaz.Location = new System.Drawing.Point(136, 23);
            this.studentImePrikaz.Name = "studentImePrikaz";
            this.studentImePrikaz.Size = new System.Drawing.Size(152, 35);
            this.studentImePrikaz.TabIndex = 7;
            this.studentImePrikaz.Text = "nedefinisano";
            this.studentImePrikaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelaBrojIndeksa
            // 
            this.labelaBrojIndeksa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaBrojIndeksa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaBrojIndeksa.ForeColor = System.Drawing.Color.White;
            this.labelaBrojIndeksa.Location = new System.Drawing.Point(21, 65);
            this.labelaBrojIndeksa.Name = "labelaBrojIndeksa";
            this.labelaBrojIndeksa.Size = new System.Drawing.Size(126, 35);
            this.labelaBrojIndeksa.TabIndex = 9;
            this.labelaBrojIndeksa.Text = "broj indeksa:";
            this.labelaBrojIndeksa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dugmePretraga.Location = new System.Drawing.Point(203, 58);
            this.dugmePretraga.Margin = new System.Windows.Forms.Padding(0);
            this.dugmePretraga.Name = "dugmePretraga";
            this.dugmePretraga.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dugmePretraga.Size = new System.Drawing.Size(316, 47);
            this.dugmePretraga.TabIndex = 6;
            this.dugmePretraga.Text = "pretraga";
            this.dugmePretraga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dugmePretraga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmePretraga.UseVisualStyleBackColor = false;
            this.dugmePretraga.Click += new System.EventHandler(this.dugmePretraga_Click);
            // 
            // brojIndeksaUnos
            // 
            this.brojIndeksaUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brojIndeksaUnos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojIndeksaUnos.Location = new System.Drawing.Point(333, 26);
            this.brojIndeksaUnos.MaxLength = 5;
            this.brojIndeksaUnos.Name = "brojIndeksaUnos";
            this.brojIndeksaUnos.Size = new System.Drawing.Size(186, 26);
            this.brojIndeksaUnos.TabIndex = 5;
            // 
            // BrojIndeksa
            // 
            this.BrojIndeksa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrojIndeksa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrojIndeksa.ForeColor = System.Drawing.Color.White;
            this.BrojIndeksa.Location = new System.Drawing.Point(199, 20);
            this.BrojIndeksa.Name = "BrojIndeksa";
            this.BrojIndeksa.Size = new System.Drawing.Size(128, 35);
            this.BrojIndeksa.TabIndex = 4;
            this.BrojIndeksa.Text = "broj indeksa:";
            this.BrojIndeksa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jmbgPrikaz
            // 
            this.jmbgPrikaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jmbgPrikaz.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmbgPrikaz.ForeColor = System.Drawing.Color.White;
            this.jmbgPrikaz.Location = new System.Drawing.Point(408, 23);
            this.jmbgPrikaz.Name = "jmbgPrikaz";
            this.jmbgPrikaz.Size = new System.Drawing.Size(199, 35);
            this.jmbgPrikaz.TabIndex = 25;
            this.jmbgPrikaz.Text = "nedefinisano";
            this.jmbgPrikaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(336, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 35);
            this.label2.TabIndex = 24;
            this.label2.Text = "JMBG:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(446, 170);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(139, 49);
            this.iconButton1.TabIndex = 26;
            this.iconButton1.Text = "položeni predmeti";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(591, 170);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(139, 49);
            this.iconButton2.TabIndex = 27;
            this.iconButton2.Text = "predmeti koje sluša";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // FormaUpravljanjeStudentima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(981, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMeni);
            this.Controls.Add(this.panelNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaUpravljanjeStudentima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje studentima";
            this.panelNaslov.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMeni.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPrikazRezultata.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNaslov;
        private System.Windows.Forms.Label labelaNaslov;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton dugmeDodajStudenta;
        private FontAwesome.Sharp.IconButton dugmeNazad;
        private System.Windows.Forms.Panel panelMeni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelaPretraga;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton dugmePretraga;
        private System.Windows.Forms.TextBox brojIndeksaUnos;
        private System.Windows.Forms.Label BrojIndeksa;
        private System.Windows.Forms.Label prosekPrikaz;
        private System.Windows.Forms.Label labelaProsek;
        private System.Windows.Forms.Label fakultetPrikaz;
        private System.Windows.Forms.Label labelaFakultet;
        private System.Windows.Forms.Label statusPrikaz;
        private System.Windows.Forms.Label labelaStatus;
        private System.Windows.Forms.Label diplomiraoPrikaz;
        private System.Windows.Forms.Label labelaDiplomirao;
        private System.Windows.Forms.Label espbPrikaz;
        private System.Windows.Forms.Label labelaEspb;
        private System.Windows.Forms.Label smerPrikaz;
        private System.Windows.Forms.Label labelaSmer;
        private System.Windows.Forms.Label brojIndeksaPrikaz;
        private System.Windows.Forms.Label labelaBrojIndeksa;
        private System.Windows.Forms.Label labelaStudent;
        private System.Windows.Forms.Label studentImePrikaz;
        private System.Windows.Forms.Panel panelPrikazRezultata;
        private FontAwesome.Sharp.IconButton dugmeUkloniProfesora;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label jmbgPrikaz;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}