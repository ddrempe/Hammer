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
<<<<<<< HEAD
            this.dgvGradilista = new System.Windows.Forms.DataGridView();
            this.btnUrediGradiliste = new System.Windows.Forms.Button();
            this.btnObrisiGradiliste = new System.Windows.Forms.Button();
            this.btnDodajGradiliste = new System.Windows.Forms.Button();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.btnObrisiZaposlenika = new System.Windows.Forms.Button();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivandoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradilistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradilista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradilistaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGradilista
            // 
            this.dgvGradilista.AutoGenerateColumns = false;
            this.dgvGradilista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradilista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nazivDataGridViewTextBoxColumn,
            this.aktivanodDataGridViewTextBoxColumn,
            this.aktivandoDataGridViewTextBoxColumn});
            this.dgvGradilista.DataSource = this.gradilistaBindingSource;
            this.dgvGradilista.Location = new System.Drawing.Point(12, 12);
            this.dgvGradilista.Name = "dgvGradilista";
            this.dgvGradilista.RowTemplate.Height = 24;
            this.dgvGradilista.Size = new System.Drawing.Size(720, 169);
            this.dgvGradilista.TabIndex = 0;
            this.dgvGradilista.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
=======
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodajGradilista = new System.Windows.Forms.Button();
            this.btnIzmijeniGradilista = new System.Windows.Forms.Button();
            this.btnObrisiGradilista = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivandoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradilistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strucnaspremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradilistaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradilistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
>>>>>>> origin/master
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AutoGenerateColumns = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oibDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
<<<<<<< HEAD
            this.satnicaDataGridViewTextBoxColumn});
            this.dgvZaposlenici.DataSource = this.zaposleniciBindingSource;
            this.dgvZaposlenici.Location = new System.Drawing.Point(12, 231);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowTemplate.Height = 24;
            this.dgvZaposlenici.Size = new System.Drawing.Size(720, 150);
            this.dgvZaposlenici.TabIndex = 7;
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
=======
            this.strucnaspremaDataGridViewTextBoxColumn,
            this.satnicaDataGridViewTextBoxColumn,
            this.gradilistaidDataGridViewTextBoxColumn,
            this.odDataGridViewTextBoxColumn,
            this.doDataGridViewTextBoxColumn,
            this.voziloidDataGridViewTextBoxColumn});
            this.dgvZaposlenici.DataSource = this.zaposleniciBindingSource;
            this.dgvZaposlenici.Location = new System.Drawing.Point(12, 248);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowTemplate.Height = 24;
            this.dgvZaposlenici.Size = new System.Drawing.Size(969, 161);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(681, 415);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(82, 33);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Novi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(769, 415);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(82, 33);
            this.btnIzmijeni.TabIndex = 2;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(857, 415);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(81, 33);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.aktivanodDataGridViewTextBoxColumn,
            this.aktivandoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gradilistaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(591, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnDodajGradilista
            // 
            this.btnDodajGradilista.Location = new System.Drawing.Point(681, 209);
            this.btnDodajGradilista.Name = "btnDodajGradilista";
            this.btnDodajGradilista.Size = new System.Drawing.Size(82, 33);
            this.btnDodajGradilista.TabIndex = 5;
            this.btnDodajGradilista.Text = "Novi";
            this.btnDodajGradilista.UseVisualStyleBackColor = true;
            this.btnDodajGradilista.Click += new System.EventHandler(this.btnDodajGradilista_Click);
            // 
            // btnIzmijeniGradilista
            // 
            this.btnIzmijeniGradilista.Location = new System.Drawing.Point(768, 209);
            this.btnIzmijeniGradilista.Name = "btnIzmijeniGradilista";
            this.btnIzmijeniGradilista.Size = new System.Drawing.Size(82, 33);
            this.btnIzmijeniGradilista.TabIndex = 6;
            this.btnIzmijeniGradilista.Text = "Izmijeni";
            this.btnIzmijeniGradilista.UseVisualStyleBackColor = true;
            this.btnIzmijeniGradilista.Click += new System.EventHandler(this.btnIzmijeniGradilista_Click);
            // 
            // btnObrisiGradilista
            // 
            this.btnObrisiGradilista.Location = new System.Drawing.Point(856, 209);
            this.btnObrisiGradilista.Name = "btnObrisiGradilista";
            this.btnObrisiGradilista.Size = new System.Drawing.Size(82, 33);
            this.btnObrisiGradilista.TabIndex = 7;
            this.btnObrisiGradilista.Text = "Obriši";
            this.btnObrisiGradilista.UseVisualStyleBackColor = true;
            this.btnObrisiGradilista.Click += new System.EventHandler(this.btnObrisiGradilista_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // aktivanodDataGridViewTextBoxColumn
            // 
            this.aktivanodDataGridViewTextBoxColumn.DataPropertyName = "aktivan_od";
            this.aktivanodDataGridViewTextBoxColumn.HeaderText = "aktivan_od";
            this.aktivanodDataGridViewTextBoxColumn.Name = "aktivanodDataGridViewTextBoxColumn";
            // 
            // aktivandoDataGridViewTextBoxColumn
            // 
            this.aktivandoDataGridViewTextBoxColumn.DataPropertyName = "aktivan_do";
            this.aktivandoDataGridViewTextBoxColumn.HeaderText = "aktivan_do";
            this.aktivandoDataGridViewTextBoxColumn.Name = "aktivandoDataGridViewTextBoxColumn";
            // 
            // gradilistaBindingSource
            // 
            this.gradilistaBindingSource.DataSource = typeof(Hammer.gradilista);
>>>>>>> origin/master
            // 
            // oibDataGridViewTextBoxColumn
            // 
            this.oibDataGridViewTextBoxColumn.DataPropertyName = "oib";
<<<<<<< HEAD
            this.oibDataGridViewTextBoxColumn.HeaderText = "OIB";
=======
            this.oibDataGridViewTextBoxColumn.HeaderText = "oib";
>>>>>>> origin/master
            this.oibDataGridViewTextBoxColumn.Name = "oibDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
<<<<<<< HEAD
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 150;
=======
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
>>>>>>> origin/master
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
<<<<<<< HEAD
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 150;
=======
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // strucnaspremaDataGridViewTextBoxColumn
            // 
            this.strucnaspremaDataGridViewTextBoxColumn.DataPropertyName = "strucna_sprema";
            this.strucnaspremaDataGridViewTextBoxColumn.HeaderText = "strucna_sprema";
            this.strucnaspremaDataGridViewTextBoxColumn.Name = "strucnaspremaDataGridViewTextBoxColumn";
>>>>>>> origin/master
            // 
            // satnicaDataGridViewTextBoxColumn
            // 
            this.satnicaDataGridViewTextBoxColumn.DataPropertyName = "satnica";
<<<<<<< HEAD
            this.satnicaDataGridViewTextBoxColumn.HeaderText = "Satnica";
            this.satnicaDataGridViewTextBoxColumn.Name = "satnicaDataGridViewTextBoxColumn";
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataSource = typeof(Hammer.zaposlenici);
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv gradilišta";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // aktivanodDataGridViewTextBoxColumn
            // 
            this.aktivanodDataGridViewTextBoxColumn.DataPropertyName = "aktivan_od";
            this.aktivanodDataGridViewTextBoxColumn.HeaderText = "Početak radova";
            this.aktivanodDataGridViewTextBoxColumn.Name = "aktivanodDataGridViewTextBoxColumn";
            this.aktivanodDataGridViewTextBoxColumn.Width = 160;
            // 
            // aktivandoDataGridViewTextBoxColumn
            // 
            this.aktivandoDataGridViewTextBoxColumn.DataPropertyName = "aktivan_do";
            this.aktivandoDataGridViewTextBoxColumn.HeaderText = "Završetak radova";
            this.aktivandoDataGridViewTextBoxColumn.Name = "aktivandoDataGridViewTextBoxColumn";
            this.aktivandoDataGridViewTextBoxColumn.Width = 160;
            // 
            // gradilistaBindingSource
            // 
            this.gradilistaBindingSource.DataSource = typeof(Hammer.gradilista);
=======
            this.satnicaDataGridViewTextBoxColumn.HeaderText = "satnica";
            this.satnicaDataGridViewTextBoxColumn.Name = "satnicaDataGridViewTextBoxColumn";
            // 
            // gradilistaidDataGridViewTextBoxColumn
            // 
            this.gradilistaidDataGridViewTextBoxColumn.DataPropertyName = "gradilista_id";
            this.gradilistaidDataGridViewTextBoxColumn.HeaderText = "gradilista_id";
            this.gradilistaidDataGridViewTextBoxColumn.Name = "gradilistaidDataGridViewTextBoxColumn";
            this.gradilistaidDataGridViewTextBoxColumn.Visible = false;
            // 
            // odDataGridViewTextBoxColumn
            // 
            this.odDataGridViewTextBoxColumn.DataPropertyName = "od";
            this.odDataGridViewTextBoxColumn.HeaderText = "od";
            this.odDataGridViewTextBoxColumn.Name = "odDataGridViewTextBoxColumn";
            // 
            // doDataGridViewTextBoxColumn
            // 
            this.doDataGridViewTextBoxColumn.DataPropertyName = "do";
            this.doDataGridViewTextBoxColumn.HeaderText = "do";
            this.doDataGridViewTextBoxColumn.Name = "doDataGridViewTextBoxColumn";
            // 
            // voziloidDataGridViewTextBoxColumn
            // 
            this.voziloidDataGridViewTextBoxColumn.DataPropertyName = "vozilo_id";
            this.voziloidDataGridViewTextBoxColumn.HeaderText = "vozilo_id";
            this.voziloidDataGridViewTextBoxColumn.Name = "voziloidDataGridViewTextBoxColumn";
            this.voziloidDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataSource = typeof(Hammer.zaposlenici);
>>>>>>> origin/master
            // 
            // FrmEvidencijaGiZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(744, 426);
            this.Controls.Add(this.btnObrisiZaposlenika);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.btnUrediGradiliste);
            this.Controls.Add(this.btnObrisiGradiliste);
            this.Controls.Add(this.btnDodajGradiliste);
            this.Controls.Add(this.dgvGradilista);
            this.Name = "FrmEvidencijaGiZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvidencijaGiZ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEvidencijaGiZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradilista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradilistaBindingSource)).EndInit();
=======
            this.ClientSize = new System.Drawing.Size(1002, 449);
            this.Controls.Add(this.btnObrisiGradilista);
            this.Controls.Add(this.btnIzmijeniGradilista);
            this.Controls.Add(this.btnDodajGradilista);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvZaposlenici);
            this.Name = "FrmEvidencijaGiZ";
            this.Text = "EvidencijaGiZ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradilistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
>>>>>>> origin/master
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.DataGridView dgvGradilista;
        private System.Windows.Forms.BindingSource gradilistaBindingSource;
        private System.Windows.Forms.Button btnUrediGradiliste;
        private System.Windows.Forms.Button btnObrisiGradiliste;
        private System.Windows.Forms.Button btnDodajGradiliste;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private System.Windows.Forms.Button btnObrisiZaposlenika;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivanodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivandoDataGridViewTextBoxColumn;
=======
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strucnaspremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradilistaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivanodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivandoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gradilistaBindingSource;
        private System.Windows.Forms.Button btnDodajGradilista;
        private System.Windows.Forms.Button btnIzmijeniGradilista;
        private System.Windows.Forms.Button btnObrisiGradilista;
>>>>>>> origin/master
    }
}