namespace Hammer
{
    partial class frmVozniPark
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
            this.btnUrediVozilo = new System.Windows.Forms.Button();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vozniparkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozniparkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.Location = new System.Drawing.Point(597, 326);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiVozilo.TabIndex = 6;
            this.btnObrisiVozilo.Text = "Obriši";
            this.btnObrisiVozilo.UseVisualStyleBackColor = true;
            this.btnObrisiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // btnUrediVozilo
            // 
            this.btnUrediVozilo.Location = new System.Drawing.Point(516, 326);
            this.btnUrediVozilo.Name = "btnUrediVozilo";
            this.btnUrediVozilo.Size = new System.Drawing.Size(75, 23);
            this.btnUrediVozilo.TabIndex = 5;
            this.btnUrediVozilo.Text = "Uredi";
            this.btnUrediVozilo.UseVisualStyleBackColor = true;
            this.btnUrediVozilo.Click += new System.EventHandler(this.btnUrediVozilo_Click);
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(435, 326);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(75, 23);
            this.btnDodajVozilo.TabIndex = 4;
            this.btnDodajVozilo.Text = "Dodaj";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.servisDataGridViewTextBoxColumn,
            this.zaposleniciDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vozniparkBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 307);
            this.dataGridView1.TabIndex = 7;
            // 
            // vozniparkBindingSource
            // 
            this.vozniparkBindingSource.DataSource = typeof(Hammer.vozni_park);
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
            this.nazivDataGridViewTextBoxColumn.Width = 200;
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
            // 
            // zaposleniciDataGridViewTextBoxColumn
            // 
            this.zaposleniciDataGridViewTextBoxColumn.DataPropertyName = "zaposlenici";
            this.zaposleniciDataGridViewTextBoxColumn.HeaderText = "zaposlenici";
            this.zaposleniciDataGridViewTextBoxColumn.Name = "zaposleniciDataGridViewTextBoxColumn";
            this.zaposleniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmVozniPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnObrisiVozilo);
            this.Controls.Add(this.btnUrediVozilo);
            this.Controls.Add(this.btnDodajVozilo);
            this.Name = "frmVozniPark";
            this.Text = "frmVozniPark";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozniparkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiVozilo;
        private System.Windows.Forms.Button btnUrediVozilo;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vozniparkBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposleniciDataGridViewTextBoxColumn;
    }
}