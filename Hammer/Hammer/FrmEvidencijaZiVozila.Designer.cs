namespace Hammer
{
    partial class FrmEvidencijaZiVozila
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
            this.btnObrisiVozilo = new System.Windows.Forms.Button();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozniparkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strucnaspremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izracunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradilistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozniparkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozniparkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.Location = new System.Drawing.Point(597, 326);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiVozilo.TabIndex = 7;
            this.btnObrisiVozilo.Text = "Obriši";
            this.btnObrisiVozilo.UseVisualStyleBackColor = true;
            this.btnObrisiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(516, 326);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(75, 23);
            this.btnDodajVozilo.TabIndex = 6;
            this.btnDodajVozilo.Text = "Dodaj";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AutoGenerateColumns = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.strucnaspremaDataGridViewTextBoxColumn,
            this.satnicaDataGridViewTextBoxColumn,
            this.izracunDataGridViewTextBoxColumn,
            this.gradilistaDataGridViewTextBoxColumn,
            this.vozniparkDataGridViewTextBoxColumn});
            this.dgvZaposlenici.DataSource = this.zaposleniciBindingSource;
            this.dgvZaposlenici.Location = new System.Drawing.Point(12, 12);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.Size = new System.Drawing.Size(660, 192);
            this.dgvZaposlenici.TabIndex = 8;
            this.dgvZaposlenici.SelectionChanged += new System.EventHandler(this.dgvZaposlenici_SelectionChanged);
            // 
            // dgvVozila
            // 
            this.dgvVozila.AutoGenerateColumns = false;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.servisDataGridViewTextBoxColumn,
            this.zaposleniciDataGridViewTextBoxColumn});
            this.dgvVozila.DataSource = this.vozniparkBindingSource;
            this.dgvVozila.Location = new System.Drawing.Point(13, 210);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.Size = new System.Drawing.Size(659, 110);
            this.dgvVozila.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // servisDataGridViewTextBoxColumn
            // 
            this.servisDataGridViewTextBoxColumn.DataPropertyName = "servis";
            this.servisDataGridViewTextBoxColumn.HeaderText = "Datum servisa";
            this.servisDataGridViewTextBoxColumn.Name = "servisDataGridViewTextBoxColumn";
            this.servisDataGridViewTextBoxColumn.Width = 150;
            // 
            // zaposleniciDataGridViewTextBoxColumn
            // 
            this.zaposleniciDataGridViewTextBoxColumn.DataPropertyName = "zaposlenici";
            this.zaposleniciDataGridViewTextBoxColumn.HeaderText = "zaposlenici";
            this.zaposleniciDataGridViewTextBoxColumn.Name = "zaposleniciDataGridViewTextBoxColumn";
            this.zaposleniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // vozniparkBindingSource
            // 
            this.vozniparkBindingSource.DataSource = typeof(Hammer.vozni_park);
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
            // strucnaspremaDataGridViewTextBoxColumn
            // 
            this.strucnaspremaDataGridViewTextBoxColumn.DataPropertyName = "strucna_sprema";
            this.strucnaspremaDataGridViewTextBoxColumn.HeaderText = "Stručna sprema";
            this.strucnaspremaDataGridViewTextBoxColumn.Name = "strucnaspremaDataGridViewTextBoxColumn";
            // 
            // satnicaDataGridViewTextBoxColumn
            // 
            this.satnicaDataGridViewTextBoxColumn.DataPropertyName = "satnica";
            this.satnicaDataGridViewTextBoxColumn.HeaderText = "Satnica";
            this.satnicaDataGridViewTextBoxColumn.Name = "satnicaDataGridViewTextBoxColumn";
            // 
            // izracunDataGridViewTextBoxColumn
            // 
            this.izracunDataGridViewTextBoxColumn.DataPropertyName = "izracun";
            this.izracunDataGridViewTextBoxColumn.HeaderText = "izracun";
            this.izracunDataGridViewTextBoxColumn.Name = "izracunDataGridViewTextBoxColumn";
            this.izracunDataGridViewTextBoxColumn.Visible = false;
            // 
            // gradilistaDataGridViewTextBoxColumn
            // 
            this.gradilistaDataGridViewTextBoxColumn.DataPropertyName = "gradilista";
            this.gradilistaDataGridViewTextBoxColumn.HeaderText = "gradilista";
            this.gradilistaDataGridViewTextBoxColumn.Name = "gradilistaDataGridViewTextBoxColumn";
            this.gradilistaDataGridViewTextBoxColumn.Visible = false;
            // 
            // vozniparkDataGridViewTextBoxColumn
            // 
            this.vozniparkDataGridViewTextBoxColumn.DataPropertyName = "vozni_park";
            this.vozniparkDataGridViewTextBoxColumn.HeaderText = "vozni_park";
            this.vozniparkDataGridViewTextBoxColumn.Name = "vozniparkDataGridViewTextBoxColumn";
            this.vozniparkDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataSource = typeof(Hammer.zaposlenici);
            // 
            // FrmEvidencijaZiVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dgvVozila);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.btnObrisiVozilo);
            this.Controls.Add(this.btnDodajVozilo);
            this.Name = "FrmEvidencijaZiVozila";
            this.Text = "FrmEvidencijaZiVozila";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozniparkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiVozilo;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.BindingSource vozniparkBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strucnaspremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izracunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradilistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozniparkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposleniciDataGridViewTextBoxColumn;
    }
}