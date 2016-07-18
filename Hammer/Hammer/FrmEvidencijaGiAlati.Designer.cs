namespace Hammer
{
    partial class FrmEvidencijaGiAlati
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
            this.dgvGradilista = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnObrisiAlat = new System.Windows.Forms.Button();
            this.btnDodajAlat = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradilistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradilistaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dgvGradilista.Size = new System.Drawing.Size(659, 156);
            this.dgvGradilista.TabIndex = 0;
            this.dgvGradilista.SelectionChanged += new System.EventHandler(this.dgvGradilista_SelectionChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.servisDataGridViewTextBoxColumn,
            this.gradilistaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alatiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 145);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnObrisiAlat
            // 
            this.btnObrisiAlat.Location = new System.Drawing.Point(597, 326);
            this.btnObrisiAlat.Name = "btnObrisiAlat";
            this.btnObrisiAlat.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiAlat.TabIndex = 5;
            this.btnObrisiAlat.Text = "Obriši";
            this.btnObrisiAlat.UseVisualStyleBackColor = true;
            this.btnObrisiAlat.Click += new System.EventHandler(this.btnObrisiAlat_Click);
            // 
            // btnDodajAlat
            // 
            this.btnDodajAlat.Location = new System.Drawing.Point(516, 326);
            this.btnDodajAlat.Name = "btnDodajAlat";
            this.btnDodajAlat.Size = new System.Drawing.Size(75, 23);
            this.btnDodajAlat.TabIndex = 4;
            this.btnDodajAlat.Text = "Dodaj";
            this.btnDodajAlat.UseVisualStyleBackColor = true;
            this.btnDodajAlat.Click += new System.EventHandler(this.btnDodajAlat_Click);
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
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
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
            this.servisDataGridViewTextBoxColumn.Width = 150;
            // 
            // gradilistaDataGridViewTextBoxColumn
            // 
            this.gradilistaDataGridViewTextBoxColumn.DataPropertyName = "gradilista";
            this.gradilistaDataGridViewTextBoxColumn.HeaderText = "gradilista";
            this.gradilistaDataGridViewTextBoxColumn.Name = "gradilistaDataGridViewTextBoxColumn";
            this.gradilistaDataGridViewTextBoxColumn.Visible = false;
            // 
            // alatiBindingSource
            // 
            this.alatiBindingSource.DataSource = typeof(Hammer.alati);
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
            // FrmEvidencijaGiAlati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnObrisiAlat);
            this.Controls.Add(this.btnDodajAlat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvGradilista);
            this.Name = "FrmEvidencijaGiAlati";
            this.Text = "FrmEvidencijaGiAlati";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradilista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradilistaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGradilista;
        private System.Windows.Forms.BindingSource gradilistaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivanodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivandoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kooperantiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strojeviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposleniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradilistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alatiBindingSource;
        private System.Windows.Forms.Button btnObrisiAlat;
        private System.Windows.Forms.Button btnDodajAlat;
    }
}