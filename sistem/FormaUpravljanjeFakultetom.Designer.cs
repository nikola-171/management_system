
namespace sistem
{
    partial class FormaUpravljanjeFakultetom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaUpravljanjeFakultetom));
            this.panelNaslov = new System.Windows.Forms.Panel();
            this.labelaNaslov = new System.Windows.Forms.Label();
            this.dugmeDodaj = new FontAwesome.Sharp.IconButton();
            this.dugmeZaNazad = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.tabelaPrikazFakulteta = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.univerzitet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akcija = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelNaslov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMeni.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazFakulteta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNaslov
            // 
            this.panelNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelNaslov.Controls.Add(this.labelaNaslov);
            this.panelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNaslov.Location = new System.Drawing.Point(199, 0);
            this.panelNaslov.Name = "panelNaslov";
            this.panelNaslov.Size = new System.Drawing.Size(1036, 102);
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
            this.labelaNaslov.Text = "Upravljanje fakultetom";
            this.labelaNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dugmeDodaj.Text = "dodaj fakultet";
            this.dugmeDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dugmeDodaj.UseVisualStyleBackColor = true;
            this.dugmeDodaj.Click += new System.EventHandler(this.dugmeDodaj_Click);
            // 
            // dugmeZaNazad
            // 
            this.dugmeZaNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeZaNazad.FlatAppearance.BorderSize = 0;
            this.dugmeZaNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeZaNazad.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dugmeZaNazad.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.dugmeZaNazad.IconColor = System.Drawing.Color.Black;
            this.dugmeZaNazad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dugmeZaNazad.IconSize = 50;
            this.dugmeZaNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugmeZaNazad.Location = new System.Drawing.Point(-3, 317);
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
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMeni.Controls.Add(this.dugmeDodaj);
            this.panelMeni.Controls.Add(this.dugmeZaNazad);
            this.panelMeni.Controls.Add(this.panelLogo);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMeni.Location = new System.Drawing.Point(0, 0);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(199, 533);
            this.panelMeni.TabIndex = 7;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(0, 102);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(199, 215);
            this.panelLogo.TabIndex = 0;
            // 
            // tabelaPrikazFakulteta
            // 
            this.tabelaPrikazFakulteta.AllowUserToAddRows = false;
            this.tabelaPrikazFakulteta.AllowUserToDeleteRows = false;
            this.tabelaPrikazFakulteta.AllowUserToResizeColumns = false;
            this.tabelaPrikazFakulteta.AllowUserToResizeRows = false;
            this.tabelaPrikazFakulteta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelaPrikazFakulteta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaPrikazFakulteta.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.tabelaPrikazFakulteta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaPrikazFakulteta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaPrikazFakulteta.ColumnHeadersHeight = 50;
            this.tabelaPrikazFakulteta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabelaPrikazFakulteta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.naziv,
            this.mesto,
            this.univerzitet,
            this.akcija});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaPrikazFakulteta.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaPrikazFakulteta.EnableHeadersVisualStyles = false;
            this.tabelaPrikazFakulteta.Location = new System.Drawing.Point(199, 102);
            this.tabelaPrikazFakulteta.Name = "tabelaPrikazFakulteta";
            this.tabelaPrikazFakulteta.RowHeadersVisible = false;
            this.tabelaPrikazFakulteta.RowHeadersWidth = 70;
            this.tabelaPrikazFakulteta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabelaPrikazFakulteta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tabelaPrikazFakulteta.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelaPrikazFakulteta.RowTemplate.Height = 40;
            this.tabelaPrikazFakulteta.Size = new System.Drawing.Size(1036, 431);
            this.tabelaPrikazFakulteta.TabIndex = 9;
            this.tabelaPrikazFakulteta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaPrikazFakulteta_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // naziv
            // 
            this.naziv.HeaderText = "naziv";
            this.naziv.Name = "naziv";
            // 
            // mesto
            // 
            this.mesto.HeaderText = "mesto";
            this.mesto.Name = "mesto";
            // 
            // univerzitet
            // 
            this.univerzitet.HeaderText = "univerzitet";
            this.univerzitet.Name = "univerzitet";
            // 
            // akcija
            // 
            this.akcija.HeaderText = "akcija";
            this.akcija.Name = "akcija";
            // 
            // FormaUpravljanjeFakultetom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1235, 533);
            this.Controls.Add(this.tabelaPrikazFakulteta);
            this.Controls.Add(this.panelNaslov);
            this.Controls.Add(this.panelMeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaUpravljanjeFakultetom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje fakultetom";
            this.Load += new System.EventHandler(this.FormaUpravljanjeFakultetom_Load);
            this.panelNaslov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMeni.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazFakulteta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNaslov;
        private System.Windows.Forms.Label labelaNaslov;
        private FontAwesome.Sharp.IconButton dugmeDodaj;
        private FontAwesome.Sharp.IconButton dugmeZaNazad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMeni;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.DataGridView tabelaPrikazFakulteta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn univerzitet;
        private System.Windows.Forms.DataGridViewButtonColumn akcija;
    }
}