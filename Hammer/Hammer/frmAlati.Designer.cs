namespace Hammer
{
    partial class frmAlati
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
            this.dgvAlati = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradilistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajAlat = new System.Windows.Forms.Button();
            this.btnUrediAlat = new System.Windows.Forms.Button();
            this.btnObrisiAlat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlati
            // 
            this.dgvAlati.AutoGenerateColumns = false;
            this.dgvAlati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.servisDataGridViewTextBoxColumn,
            this.gradilistaDataGridViewTextBoxColumn});
            this.dgvAlati.DataSource = this.alatiBindingSource;
            this.dgvAlati.Location = new System.Drawing.Point(12, 12);
            this.dgvAlati.Name = "dgvAlati";
            this.dgvAlati.Size = new System.Drawing.Size(660, 308);
            this.dgvAlati.TabIndex = 0;
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
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena (po kom.)";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.Width = 150;
            // 
            // servisDataGridViewTextBoxColumn
            // 
            this.servisDataGridViewTextBoxColumn.DataPropertyName = "servis";
            this.servisDataGridViewTextBoxColumn.HeaderText = "Datum servisa";
            this.servisDataGridViewTextBoxColumn.Name = "servisDataGridViewTextBoxColumn";
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
            // btnDodajAlat
            // 
            this.btnDodajAlat.Location = new System.Drawing.Point(435, 326);
            this.btnDodajAlat.Name = "btnDodajAlat";
            this.btnDodajAlat.Size = new System.Drawing.Size(75, 23);
            this.btnDodajAlat.TabIndex = 1;
            this.btnDodajAlat.Text = "Dodaj";
            this.btnDodajAlat.UseVisualStyleBackColor = true;
            this.btnDodajAlat.Click += new System.EventHandler(this.btnDodajAlat_Click);
            // 
            // btnUrediAlat
            // 
            this.btnUrediAlat.Location = new System.Drawing.Point(516, 326);
            this.btnUrediAlat.Name = "btnUrediAlat";
            this.btnUrediAlat.Size = new System.Drawing.Size(75, 23);
            this.btnUrediAlat.TabIndex = 2;
            this.btnUrediAlat.Text = "Uredi";
            this.btnUrediAlat.UseVisualStyleBackColor = true;
            this.btnUrediAlat.Click += new System.EventHandler(this.btnUrediAlat_Click);
            // 
            // btnObrisiAlat
            // 
            this.btnObrisiAlat.Location = new System.Drawing.Point(597, 326);
            this.btnObrisiAlat.Name = "btnObrisiAlat";
            this.btnObrisiAlat.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiAlat.TabIndex = 3;
            this.btnObrisiAlat.Text = "Obriši";
            this.btnObrisiAlat.UseVisualStyleBackColor = true;
            this.btnObrisiAlat.Click += new System.EventHandler(this.btnObrisiAlat_Click);
            // 
            // frmAlati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnObrisiAlat);
            this.Controls.Add(this.btnUrediAlat);
            this.Controls.Add(this.btnDodajAlat);
            this.Controls.Add(this.dgvAlati);
            this.Name = "frmAlati";
            this.Text = "frmAlati";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alatiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlati;
        private System.Windows.Forms.BindingSource alatiBindingSource;
        private System.Windows.Forms.Button btnDodajAlat;
        private System.Windows.Forms.Button btnUrediAlat;
        private System.Windows.Forms.Button btnObrisiAlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradilistaDataGridViewTextBoxColumn;
    }
}