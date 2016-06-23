namespace Hammer
{
    partial class frmZaposlenici
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
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.btnObrisiZaposlenika = new System.Windows.Forms.Button();
            this.btnUrediZaposlenika = new System.Windows.Forms.Button();
            this.oibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strucnaspremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
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
            this.satnicaDataGridViewTextBoxColumn});
            this.dgvZaposlenici.DataSource = this.zaposleniciBindingSource;
            this.dgvZaposlenici.Location = new System.Drawing.Point(12, 12);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowTemplate.Height = 24;
            this.dgvZaposlenici.Size = new System.Drawing.Size(864, 330);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(567, 357);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(86, 37);
            this.btnDodajZaposlenika.TabIndex = 1;
            this.btnDodajZaposlenika.Text = "Dodaj";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // btnObrisiZaposlenika
            // 
            this.btnObrisiZaposlenika.Location = new System.Drawing.Point(777, 357);
            this.btnObrisiZaposlenika.Name = "btnObrisiZaposlenika";
            this.btnObrisiZaposlenika.Size = new System.Drawing.Size(99, 38);
            this.btnObrisiZaposlenika.TabIndex = 2;
            this.btnObrisiZaposlenika.Text = "Obriši";
            this.btnObrisiZaposlenika.UseVisualStyleBackColor = true;
            this.btnObrisiZaposlenika.Click += new System.EventHandler(this.btnObrisiZaposlenika_Click);
            // 
            // btnUrediZaposlenika
            // 
            this.btnUrediZaposlenika.Location = new System.Drawing.Point(672, 357);
            this.btnUrediZaposlenika.Name = "btnUrediZaposlenika";
            this.btnUrediZaposlenika.Size = new System.Drawing.Size(86, 38);
            this.btnUrediZaposlenika.TabIndex = 3;
            this.btnUrediZaposlenika.Text = "Uredi";
            this.btnUrediZaposlenika.UseVisualStyleBackColor = true;
            this.btnUrediZaposlenika.Click += new System.EventHandler(this.btnUrediZaposlenika_Click);
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
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataSource = typeof(Hammer.zaposlenici);
            // 
            // frmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 407);
            this.Controls.Add(this.btnUrediZaposlenika);
            this.Controls.Add(this.btnObrisiZaposlenika);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.dgvZaposlenici);
            this.Name = "frmZaposlenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmZaposlenici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.Button btnObrisiZaposlenika;
        private System.Windows.Forms.Button btnUrediZaposlenika;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strucnaspremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satnicaDataGridViewTextBoxColumn;
    }
}