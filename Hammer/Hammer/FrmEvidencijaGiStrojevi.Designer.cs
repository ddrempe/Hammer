namespace Hammer
{
    partial class FrmEvidencijaGiStrojevi
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
            this.btnObrisiStroj = new System.Windows.Forms.Button();
            this.btnDodajStroj = new System.Windows.Forms.Button();
            this.dgvGradilista = new System.Windows.Forms.DataGridView();
            this.dgvStrojevi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godproizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumregistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snagaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradilistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strojeviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivandoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kooperantiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strojeviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradilistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradilista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrojevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strojeviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradilistaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiStroj
            // 
            this.btnObrisiStroj.Location = new System.Drawing.Point(681, 326);
            this.btnObrisiStroj.Name = "btnObrisiStroj";
            this.btnObrisiStroj.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiStroj.TabIndex = 7;
            this.btnObrisiStroj.Text = "Obriši";
            this.btnObrisiStroj.UseVisualStyleBackColor = true;
            this.btnObrisiStroj.Click += new System.EventHandler(this.btnObrisiStroj_Click);
            // 
            // btnDodajStroj
            // 
            this.btnDodajStroj.Location = new System.Drawing.Point(600, 326);
            this.btnDodajStroj.Name = "btnDodajStroj";
            this.btnDodajStroj.Size = new System.Drawing.Size(75, 23);
            this.btnDodajStroj.TabIndex = 6;
            this.btnDodajStroj.Text = "Dodaj";
            this.btnDodajStroj.UseVisualStyleBackColor = true;
            this.btnDodajStroj.Click += new System.EventHandler(this.btnDodajStroj_Click);
            // 
            // dgvGradilista
            // 
            this.dgvGradilista.AutoGenerateColumns = false;
            this.dgvGradilista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradilista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.aktivanodDataGridViewTextBoxColumn,
            this.aktivandoDataGridViewTextBoxColumn,
            this.kooperantiDataGridViewTextBoxColumn,
            this.alatiDataGridViewTextBoxColumn,
            this.strojeviDataGridViewTextBoxColumn,
            this.zaposleniciDataGridViewTextBoxColumn});
            this.dgvGradilista.DataSource = this.gradilistaBindingSource;
            this.dgvGradilista.Location = new System.Drawing.Point(13, 13);
            this.dgvGradilista.Name = "dgvGradilista";
            this.dgvGradilista.Size = new System.Drawing.Size(743, 131);
            this.dgvGradilista.TabIndex = 8;
            this.dgvGradilista.SelectionChanged += new System.EventHandler(this.dgvGradilista_SelectionChanged);
            // 
            // dgvStrojevi
            // 
            this.dgvStrojevi.AutoGenerateColumns = false;
            this.dgvStrojevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrojevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.cijenaDataGridViewTextBoxColumn,
            this.servisDataGridViewTextBoxColumn,
            this.godproizvodnjeDataGridViewTextBoxColumn,
            this.datumregistracijeDataGridViewTextBoxColumn,
            this.snagaDataGridViewTextBoxColumn,
            this.gradilistaDataGridViewTextBoxColumn});
            this.dgvStrojevi.DataSource = this.strojeviBindingSource;
            this.dgvStrojevi.Location = new System.Drawing.Point(13, 150);
            this.dgvStrojevi.Name = "dgvStrojevi";
            this.dgvStrojevi.Size = new System.Drawing.Size(743, 170);
            this.dgvStrojevi.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // servisDataGridViewTextBoxColumn
            // 
            this.servisDataGridViewTextBoxColumn.DataPropertyName = "servis";
            this.servisDataGridViewTextBoxColumn.HeaderText = "Datum servisa";
            this.servisDataGridViewTextBoxColumn.Name = "servisDataGridViewTextBoxColumn";
            // 
            // godproizvodnjeDataGridViewTextBoxColumn
            // 
            this.godproizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "god_proizvodnje";
            this.godproizvodnjeDataGridViewTextBoxColumn.HeaderText = "Godina proizvodnje";
            this.godproizvodnjeDataGridViewTextBoxColumn.Name = "godproizvodnjeDataGridViewTextBoxColumn";
            // 
            // datumregistracijeDataGridViewTextBoxColumn
            // 
            this.datumregistracijeDataGridViewTextBoxColumn.DataPropertyName = "datum_registracije";
            this.datumregistracijeDataGridViewTextBoxColumn.HeaderText = "Datum registracije";
            this.datumregistracijeDataGridViewTextBoxColumn.Name = "datumregistracijeDataGridViewTextBoxColumn";
            // 
            // snagaDataGridViewTextBoxColumn
            // 
            this.snagaDataGridViewTextBoxColumn.DataPropertyName = "snaga";
            this.snagaDataGridViewTextBoxColumn.HeaderText = "Snaga";
            this.snagaDataGridViewTextBoxColumn.Name = "snagaDataGridViewTextBoxColumn";
            // 
            // gradilistaDataGridViewTextBoxColumn
            // 
            this.gradilistaDataGridViewTextBoxColumn.DataPropertyName = "gradilista";
            this.gradilistaDataGridViewTextBoxColumn.HeaderText = "gradilista";
            this.gradilistaDataGridViewTextBoxColumn.Name = "gradilistaDataGridViewTextBoxColumn";
            this.gradilistaDataGridViewTextBoxColumn.Visible = false;
            // 
            // strojeviBindingSource
            // 
            this.strojeviBindingSource.DataSource = typeof(Hammer.strojevi);
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
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // aktivanodDataGridViewTextBoxColumn
            // 
            this.aktivanodDataGridViewTextBoxColumn.DataPropertyName = "aktivan_od";
            this.aktivanodDataGridViewTextBoxColumn.HeaderText = "Početak radova";
            this.aktivanodDataGridViewTextBoxColumn.Name = "aktivanodDataGridViewTextBoxColumn";
            this.aktivanodDataGridViewTextBoxColumn.Width = 150;
            // 
            // aktivandoDataGridViewTextBoxColumn
            // 
            this.aktivandoDataGridViewTextBoxColumn.DataPropertyName = "aktivan_do";
            this.aktivandoDataGridViewTextBoxColumn.HeaderText = "Završetak radova";
            this.aktivandoDataGridViewTextBoxColumn.Name = "aktivandoDataGridViewTextBoxColumn";
            this.aktivandoDataGridViewTextBoxColumn.Width = 150;
            // 
            // kooperantiDataGridViewTextBoxColumn
            // 
            this.kooperantiDataGridViewTextBoxColumn.DataPropertyName = "kooperanti";
            this.kooperantiDataGridViewTextBoxColumn.HeaderText = "kooperanti";
            this.kooperantiDataGridViewTextBoxColumn.Name = "kooperantiDataGridViewTextBoxColumn";
            this.kooperantiDataGridViewTextBoxColumn.Visible = false;
            // 
            // alatiDataGridViewTextBoxColumn
            // 
            this.alatiDataGridViewTextBoxColumn.DataPropertyName = "alati";
            this.alatiDataGridViewTextBoxColumn.HeaderText = "alati";
            this.alatiDataGridViewTextBoxColumn.Name = "alatiDataGridViewTextBoxColumn";
            this.alatiDataGridViewTextBoxColumn.Visible = false;
            // 
            // strojeviDataGridViewTextBoxColumn
            // 
            this.strojeviDataGridViewTextBoxColumn.DataPropertyName = "strojevi";
            this.strojeviDataGridViewTextBoxColumn.HeaderText = "strojevi";
            this.strojeviDataGridViewTextBoxColumn.Name = "strojeviDataGridViewTextBoxColumn";
            this.strojeviDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposleniciDataGridViewTextBoxColumn
            // 
            this.zaposleniciDataGridViewTextBoxColumn.DataPropertyName = "zaposlenici";
            this.zaposleniciDataGridViewTextBoxColumn.HeaderText = "zaposlenici";
            this.zaposleniciDataGridViewTextBoxColumn.Name = "zaposleniciDataGridViewTextBoxColumn";
            this.zaposleniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // gradilistaBindingSource
            // 
            this.gradilistaBindingSource.DataSource = typeof(Hammer.gradilista);
            // 
            // FrmEvidencijaGiStrojevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 361);
            this.Controls.Add(this.dgvStrojevi);
            this.Controls.Add(this.dgvGradilista);
            this.Controls.Add(this.btnObrisiStroj);
            this.Controls.Add(this.btnDodajStroj);
            this.Name = "FrmEvidencijaGiStrojevi";
            this.Text = "FrmEvidencijaGiStrojevi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradilista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrojevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strojeviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradilistaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiStroj;
        private System.Windows.Forms.Button btnDodajStroj;
        private System.Windows.Forms.DataGridView dgvGradilista;
        private System.Windows.Forms.DataGridView dgvStrojevi;
        private System.Windows.Forms.BindingSource gradilistaBindingSource;
        private System.Windows.Forms.BindingSource strojeviBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivanodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivandoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kooperantiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strojeviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposleniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godproizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumregistracijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snagaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradilistaDataGridViewTextBoxColumn;
    }
}