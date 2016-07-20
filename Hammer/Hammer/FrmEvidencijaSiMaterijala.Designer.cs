namespace Hammer
{
    partial class FrmEvidencijaSiMaterijala
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skladistematerijaliDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skladistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.skladistematerijaliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajSkladiste = new System.Windows.Forms.Button();
            this.btnUrediSkladiste = new System.Windows.Forms.Button();
            this.btnObrisiSkladiste = new System.Windows.Forms.Button();
            this.btnDodajMaterijal = new System.Windows.Forms.Button();
            this.btnObrisiMaterijal = new System.Windows.Forms.Button();
            this.btnUrediMaterijal = new System.Windows.Forms.Button();
            this.materijaliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladisteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijaliidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skladistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladistematerijaliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijaliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.kapacitetDataGridViewTextBoxColumn,
            this.skladistematerijaliDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.skladistaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 196);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // kapacitetDataGridViewTextBoxColumn
            // 
            this.kapacitetDataGridViewTextBoxColumn.DataPropertyName = "kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.HeaderText = "Kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.Name = "kapacitetDataGridViewTextBoxColumn";
            // 
            // skladistematerijaliDataGridViewTextBoxColumn1
            // 
            this.skladistematerijaliDataGridViewTextBoxColumn1.DataPropertyName = "skladiste_materijali";
            this.skladistematerijaliDataGridViewTextBoxColumn1.HeaderText = "skladiste_materijali";
            this.skladistematerijaliDataGridViewTextBoxColumn1.Name = "skladistematerijaliDataGridViewTextBoxColumn1";
            this.skladistematerijaliDataGridViewTextBoxColumn1.Visible = false;
            // 
            // skladistaBindingSource
            // 
            this.skladistaBindingSource.DataSource = typeof(Hammer.skladista);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skladisteidDataGridViewTextBoxColumn,
            this.materijaliidDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.materijaliDataGridViewTextBoxColumn,
            this.skladistaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.skladistematerijaliBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 244);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(447, 169);
            this.dataGridView2.TabIndex = 1;
            // 
            // skladistematerijaliBindingSource
            // 
            this.skladistematerijaliBindingSource.DataSource = typeof(Hammer.skladiste_materijali);
            // 
            // btnDodajSkladiste
            // 
            this.btnDodajSkladiste.Location = new System.Drawing.Point(223, 215);
            this.btnDodajSkladiste.Name = "btnDodajSkladiste";
            this.btnDodajSkladiste.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSkladiste.TabIndex = 2;
            this.btnDodajSkladiste.Text = "Dodaj";
            this.btnDodajSkladiste.UseVisualStyleBackColor = true;
            this.btnDodajSkladiste.Click += new System.EventHandler(this.btnDodajSkladiste_Click);
            // 
            // btnUrediSkladiste
            // 
            this.btnUrediSkladiste.Location = new System.Drawing.Point(304, 215);
            this.btnUrediSkladiste.Name = "btnUrediSkladiste";
            this.btnUrediSkladiste.Size = new System.Drawing.Size(75, 23);
            this.btnUrediSkladiste.TabIndex = 3;
            this.btnUrediSkladiste.Text = "Uredi";
            this.btnUrediSkladiste.UseVisualStyleBackColor = true;
            this.btnUrediSkladiste.Click += new System.EventHandler(this.btnUrediSkladiste_Click);
            // 
            // btnObrisiSkladiste
            // 
            this.btnObrisiSkladiste.Location = new System.Drawing.Point(385, 215);
            this.btnObrisiSkladiste.Name = "btnObrisiSkladiste";
            this.btnObrisiSkladiste.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiSkladiste.TabIndex = 4;
            this.btnObrisiSkladiste.Text = "Obriši";
            this.btnObrisiSkladiste.UseVisualStyleBackColor = true;
            this.btnObrisiSkladiste.Click += new System.EventHandler(this.btnObrisiSkladiste_Click);
            // 
            // btnDodajMaterijal
            // 
            this.btnDodajMaterijal.Location = new System.Drawing.Point(223, 419);
            this.btnDodajMaterijal.Name = "btnDodajMaterijal";
            this.btnDodajMaterijal.Size = new System.Drawing.Size(75, 23);
            this.btnDodajMaterijal.TabIndex = 5;
            this.btnDodajMaterijal.Text = "Dodaj";
            this.btnDodajMaterijal.UseVisualStyleBackColor = true;
            this.btnDodajMaterijal.Click += new System.EventHandler(this.btnDodajMaterijal_Click);
            // 
            // btnObrisiMaterijal
            // 
            this.btnObrisiMaterijal.Location = new System.Drawing.Point(385, 419);
            this.btnObrisiMaterijal.Name = "btnObrisiMaterijal";
            this.btnObrisiMaterijal.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiMaterijal.TabIndex = 6;
            this.btnObrisiMaterijal.Text = "Obriši";
            this.btnObrisiMaterijal.UseVisualStyleBackColor = true;
            this.btnObrisiMaterijal.Click += new System.EventHandler(this.btnObrisiMaterijal_Click);
            // 
            // btnUrediMaterijal
            // 
            this.btnUrediMaterijal.Location = new System.Drawing.Point(304, 419);
            this.btnUrediMaterijal.Name = "btnUrediMaterijal";
            this.btnUrediMaterijal.Size = new System.Drawing.Size(75, 23);
            this.btnUrediMaterijal.TabIndex = 7;
            this.btnUrediMaterijal.Text = "Uredi";
            this.btnUrediMaterijal.UseVisualStyleBackColor = true;
            this.btnUrediMaterijal.Click += new System.EventHandler(this.btnUrediMaterijal_Click);
            // 
            // materijaliBindingSource
            // 
            this.materijaliBindingSource.DataSource = typeof(Hammer.materijali);
            // 
            // skladisteidDataGridViewTextBoxColumn
            // 
            this.skladisteidDataGridViewTextBoxColumn.DataPropertyName = "skladiste_id";
            this.skladisteidDataGridViewTextBoxColumn.HeaderText = "ID skladišta";
            this.skladisteidDataGridViewTextBoxColumn.Name = "skladisteidDataGridViewTextBoxColumn";
            this.skladisteidDataGridViewTextBoxColumn.Visible = false;
            // 
            // materijaliidDataGridViewTextBoxColumn
            // 
            this.materijaliidDataGridViewTextBoxColumn.DataPropertyName = "materijali_id";
            this.materijaliidDataGridViewTextBoxColumn.HeaderText = "ID materijala";
            this.materijaliidDataGridViewTextBoxColumn.Name = "materijaliidDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // materijaliDataGridViewTextBoxColumn
            // 
            this.materijaliDataGridViewTextBoxColumn.DataPropertyName = "materijali";
            this.materijaliDataGridViewTextBoxColumn.HeaderText = "materijali";
            this.materijaliDataGridViewTextBoxColumn.Name = "materijaliDataGridViewTextBoxColumn";
            this.materijaliDataGridViewTextBoxColumn.Visible = false;
            // 
            // skladistaDataGridViewTextBoxColumn
            // 
            this.skladistaDataGridViewTextBoxColumn.DataPropertyName = "skladista";
            this.skladistaDataGridViewTextBoxColumn.HeaderText = "skladista";
            this.skladistaDataGridViewTextBoxColumn.Name = "skladistaDataGridViewTextBoxColumn";
            this.skladistaDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmEvidencijaSiMaterijala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 454);
            this.Controls.Add(this.btnUrediMaterijal);
            this.Controls.Add(this.btnObrisiMaterijal);
            this.Controls.Add(this.btnDodajMaterijal);
            this.Controls.Add(this.btnObrisiSkladiste);
            this.Controls.Add(this.btnUrediSkladiste);
            this.Controls.Add(this.btnDodajSkladiste);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEvidencijaSiMaterijala";
            this.Text = "FrmEvidencijaSiMaterijala";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladistematerijaliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijaliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDodajSkladiste;
        private System.Windows.Forms.Button btnUrediSkladiste;
        private System.Windows.Forms.Button btnObrisiSkladiste;
        private System.Windows.Forms.Button btnDodajMaterijal;
        private System.Windows.Forms.Button btnObrisiMaterijal;
        private System.Windows.Forms.BindingSource materijaliBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skladistematerijaliDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource skladistaBindingSource;
        private System.Windows.Forms.BindingSource skladistematerijaliBindingSource;
        private System.Windows.Forms.Button btnUrediMaterijal;
        private System.Windows.Forms.DataGridViewTextBoxColumn skladisteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijaliidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skladistaDataGridViewTextBoxColumn;
    }
}