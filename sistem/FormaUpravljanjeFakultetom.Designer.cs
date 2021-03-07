
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabelaPrikazFakulteta = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.dugmeNazad = new System.Windows.Forms.Button();
            this.dugmeDodavanje = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.univerzitet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akcija = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazFakulteta)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelaPrikazFakulteta
            // 
            this.tabelaPrikazFakulteta.AllowUserToAddRows = false;
            this.tabelaPrikazFakulteta.AllowUserToDeleteRows = false;
            this.tabelaPrikazFakulteta.AllowUserToResizeColumns = false;
            this.tabelaPrikazFakulteta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelaPrikazFakulteta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaPrikazFakulteta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelaPrikazFakulteta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaPrikazFakulteta.BackgroundColor = System.Drawing.Color.White;
            this.tabelaPrikazFakulteta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelaPrikazFakulteta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaPrikazFakulteta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaPrikazFakulteta.ColumnHeadersHeight = 52;
            this.tabelaPrikazFakulteta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabelaPrikazFakulteta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.naziv,
            this.mesto,
            this.univerzitet,
            this.akcija});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaPrikazFakulteta.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabelaPrikazFakulteta.EnableHeadersVisualStyles = false;
            this.tabelaPrikazFakulteta.Location = new System.Drawing.Point(1, 69);
            this.tabelaPrikazFakulteta.Name = "tabelaPrikazFakulteta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaPrikazFakulteta.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabelaPrikazFakulteta.RowHeadersVisible = false;
            this.tabelaPrikazFakulteta.RowHeadersWidth = 20;
            this.tabelaPrikazFakulteta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelaPrikazFakulteta.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tabelaPrikazFakulteta.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tabelaPrikazFakulteta.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelaPrikazFakulteta.RowTemplate.Height = 30;
            this.tabelaPrikazFakulteta.Size = new System.Drawing.Size(1177, 321);
            this.tabelaPrikazFakulteta.TabIndex = 3;
            this.tabelaPrikazFakulteta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaPrikazFakulteta_CellClick);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.dugmeNazad);
            this.panel.Controls.Add(this.dugmeDodavanje);
            this.panel.Location = new System.Drawing.Point(1, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1177, 59);
            this.panel.TabIndex = 5;
            // 
            // dugmeNazad
            // 
            this.dugmeNazad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dugmeNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.dugmeNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeNazad.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.dugmeNazad.FlatAppearance.BorderSize = 5;
            this.dugmeNazad.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeNazad.ForeColor = System.Drawing.Color.White;
            this.dugmeNazad.Location = new System.Drawing.Point(184, 15);
            this.dugmeNazad.Name = "dugmeNazad";
            this.dugmeNazad.Size = new System.Drawing.Size(143, 40);
            this.dugmeNazad.TabIndex = 1;
            this.dugmeNazad.Text = "nazad";
            this.dugmeNazad.UseVisualStyleBackColor = false;
            this.dugmeNazad.Click += new System.EventHandler(this.dugmeNazad_Click);
            // 
            // dugmeDodavanje
            // 
            this.dugmeDodavanje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dugmeDodavanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.dugmeDodavanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeDodavanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeDodavanje.ForeColor = System.Drawing.Color.White;
            this.dugmeDodavanje.Location = new System.Drawing.Point(11, 15);
            this.dugmeDodavanje.Name = "dugmeDodavanje";
            this.dugmeDodavanje.Size = new System.Drawing.Size(151, 39);
            this.dugmeDodavanje.TabIndex = 0;
            this.dugmeDodavanje.Text = "dodaj fakultet";
            this.dugmeDodavanje.UseVisualStyleBackColor = false;
            this.dugmeDodavanje.Click += new System.EventHandler(this.dugmeDodavanje_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // naziv
            // 
            this.naziv.HeaderText = "naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
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
            this.univerzitet.ReadOnly = true;
            // 
            // akcija
            // 
            this.akcija.HeaderText = "akcija";
            this.akcija.Name = "akcija";
            this.akcija.ReadOnly = true;
            // 
            // FormaUpravljanjeFakultetom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 391);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tabelaPrikazFakulteta);
            this.Name = "FormaUpravljanjeFakultetom";
            this.Text = "FormaUpravljanjeFakultetom";
            this.Load += new System.EventHandler(this.FormaUpravljanjeFakultetom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazFakulteta)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button dugmeNazad;
        private System.Windows.Forms.Button dugmeDodavanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn univerzitet;
        private System.Windows.Forms.DataGridViewButtonColumn akcija;
        private System.Windows.Forms.DataGridView tabelaPrikazFakulteta;
    }
}