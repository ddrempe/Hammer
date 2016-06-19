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
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AutoGenerateColumns = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oibDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
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
            // 
            // oibDataGridViewTextBoxColumn
            // 
            this.oibDataGridViewTextBoxColumn.DataPropertyName = "oib";
            this.oibDataGridViewTextBoxColumn.HeaderText = "oib";
            this.oibDataGridViewTextBoxColumn.Name = "oibDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // strucnaspremaDataGridViewTextBoxColumn
            // 
            this.strucnaspremaDataGridViewTextBoxColumn.DataPropertyName = "strucna_sprema";
            this.strucnaspremaDataGridViewTextBoxColumn.HeaderText = "strucna_sprema";
            this.strucnaspremaDataGridViewTextBoxColumn.Name = "strucnaspremaDataGridViewTextBoxColumn";
            // 
            // satnicaDataGridViewTextBoxColumn
            // 
            this.satnicaDataGridViewTextBoxColumn.DataPropertyName = "satnica";
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
            // 
            // FrmEvidencijaGiZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}