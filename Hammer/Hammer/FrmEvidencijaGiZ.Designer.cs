namespace Hammer
{
    partial class FrmEvidencijaGiZ
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEvidencijaGiZ));
            this.dgvGradilista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivandoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradilistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUrediGradiliste = new System.Windows.Forms.Button();
            this.btnObrisiGradiliste = new System.Windows.Forms.Button();
            this.btnDodajGradiliste = new System.Windows.Forms.Button();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.oibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnObrisiZaposlenika = new System.Windows.Forms.Button();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradilista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradilistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGradilista
            // 
            this.dgvGradilista.AutoGenerateColumns = false;
            this.dgvGradilista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradilista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.aktivanodDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.aktivandoDataGridViewTextBoxColumn});
            this.dgvGradilista.DataSource = this.gradilistaBindingSource;
            this.dgvGradilista.Location = new System.Drawing.Point(12, 12);
            this.dgvGradilista.Name = "dgvGradilista";
            this.dgvGradilista.RowTemplate.Height = 24;
            this.dgvGradilista.Size = new System.Drawing.Size(720, 169);
            this.dgvGradilista.TabIndex = 0;
            this.dgvGradilista.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // aktivanodDataGridViewTextBoxColumn
            // 
            this.aktivanodDataGridViewTextBoxColumn.DataPropertyName = "aktivan_od";
            this.aktivanodDataGridViewTextBoxColumn.HeaderText = "Početak radova";
            this.aktivanodDataGridViewTextBoxColumn.Name = "aktivanodDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv gradilišta";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // aktivandoDataGridViewTextBoxColumn
            // 
            this.aktivandoDataGridViewTextBoxColumn.DataPropertyName = "aktivan_do";
            this.aktivandoDataGridViewTextBoxColumn.HeaderText = "Završetak radova";
            this.aktivandoDataGridViewTextBoxColumn.Name = "aktivandoDataGridViewTextBoxColumn";
            // 
            // gradilistaBindingSource
            // 
            this.gradilistaBindingSource.DataSource = typeof(Hammer.gradilista);
            // 
            // btnUrediGradiliste
            // 
            this.btnUrediGradiliste.Location = new System.Drawing.Point(528, 188);
            this.btnUrediGradiliste.Name = "btnUrediGradiliste";
            this.btnUrediGradiliste.Size = new System.Drawing.Size(86, 38);
            this.btnUrediGradiliste.TabIndex = 6;
            this.btnUrediGradiliste.Text = "Uredi";
            this.btnUrediGradiliste.UseVisualStyleBackColor = true;
            this.btnUrediGradiliste.Click += new System.EventHandler(this.btnUrediGradiliste_Click);
            // 
            // btnObrisiGradiliste
            // 
            this.btnObrisiGradiliste.Location = new System.Drawing.Point(633, 188);
            this.btnObrisiGradiliste.Name = "btnObrisiGradiliste";
            this.btnObrisiGradiliste.Size = new System.Drawing.Size(99, 38);
            this.btnObrisiGradiliste.TabIndex = 5;
            this.btnObrisiGradiliste.Text = "Obriši";
            this.btnObrisiGradiliste.UseVisualStyleBackColor = true;
            this.btnObrisiGradiliste.Click += new System.EventHandler(this.btnObrisiGradiliste_Click);
            // 
            // btnDodajGradiliste
            // 
            this.btnDodajGradiliste.Location = new System.Drawing.Point(423, 188);
            this.btnDodajGradiliste.Name = "btnDodajGradiliste";
            this.btnDodajGradiliste.Size = new System.Drawing.Size(86, 37);
            this.btnDodajGradiliste.TabIndex = 4;
            this.btnDodajGradiliste.Text = "Dodaj";
            this.btnDodajGradiliste.UseVisualStyleBackColor = true;
            this.btnDodajGradiliste.Click += new System.EventHandler(this.btnDodajGradiliste_Click);
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AutoGenerateColumns = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oibDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.satnicaDataGridViewTextBoxColumn});
            this.dgvZaposlenici.DataSource = this.zaposleniciBindingSource;
            this.dgvZaposlenici.Location = new System.Drawing.Point(12, 231);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowTemplate.Height = 24;
            this.dgvZaposlenici.Size = new System.Drawing.Size(720, 150);
            this.dgvZaposlenici.TabIndex = 7;
            // 
            // oibDataGridViewTextBoxColumn
            // 
            this.oibDataGridViewTextBoxColumn.DataPropertyName = "oib";
            this.oibDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oibDataGridViewTextBoxColumn.Name = "oibDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // satnicaDataGridViewTextBoxColumn
            // 
            this.satnicaDataGridViewTextBoxColumn.DataPropertyName = "satnica";
            this.satnicaDataGridViewTextBoxColumn.HeaderText = "Satnica";
            this.satnicaDataGridViewTextBoxColumn.Name = "satnicaDataGridViewTextBoxColumn";
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataSource = typeof(Hammer.zaposlenici);
            // 
            // btnObrisiZaposlenika
            // 
            this.btnObrisiZaposlenika.Location = new System.Drawing.Point(633, 386);
            this.btnObrisiZaposlenika.Name = "btnObrisiZaposlenika";
            this.btnObrisiZaposlenika.Size = new System.Drawing.Size(99, 38);
            this.btnObrisiZaposlenika.TabIndex = 9;
            this.btnObrisiZaposlenika.Text = "Obriši";
            this.btnObrisiZaposlenika.UseVisualStyleBackColor = true;
            this.btnObrisiZaposlenika.Click += new System.EventHandler(this.btnObrisiZaposlenika_Click);
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(528, 387);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(86, 37);
            this.btnDodajZaposlenika.TabIndex = 8;
            this.btnDodajZaposlenika.Text = "Dodaj";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // FrmEvidencijaGiZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 426);
            this.Controls.Add(this.btnObrisiZaposlenika);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.btnUrediGradiliste);
            this.Controls.Add(this.btnObrisiGradiliste);
            this.Controls.Add(this.btnDodajGradiliste);
            this.Controls.Add(this.dgvGradilista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEvidencijaGiZ";
            this.Text = "EvidencijaGiZ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradilista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradilistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGradilista;
        private System.Windows.Forms.BindingSource gradilistaBindingSource;
        private System.Windows.Forms.Button btnUrediGradiliste;
        private System.Windows.Forms.Button btnObrisiGradiliste;
        private System.Windows.Forms.Button btnDodajGradiliste;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivanodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivandoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private System.Windows.Forms.Button btnObrisiZaposlenika;
        private System.Windows.Forms.Button btnDodajZaposlenika;
    }
}