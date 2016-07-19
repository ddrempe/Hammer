namespace Hammer
{
    partial class frmMaterijali
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
            this.btnObrisiMaterijal = new System.Windows.Forms.Button();
            this.btnUrediMaterijal = new System.Windows.Forms.Button();
            this.btnDodajMaterijal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacimaterijaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skladistematerijaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijaliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijaliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiMaterijal
            // 
            this.btnObrisiMaterijal.Location = new System.Drawing.Point(597, 326);
            this.btnObrisiMaterijal.Name = "btnObrisiMaterijal";
            this.btnObrisiMaterijal.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiMaterijal.TabIndex = 6;
            this.btnObrisiMaterijal.Text = "Obriši";
            this.btnObrisiMaterijal.UseVisualStyleBackColor = true;
            this.btnObrisiMaterijal.Click += new System.EventHandler(this.btnObrisiMaterijal_Click);
            // 
            // btnUrediMaterijal
            // 
            this.btnUrediMaterijal.Location = new System.Drawing.Point(516, 326);
            this.btnUrediMaterijal.Name = "btnUrediMaterijal";
            this.btnUrediMaterijal.Size = new System.Drawing.Size(75, 23);
            this.btnUrediMaterijal.TabIndex = 5;
            this.btnUrediMaterijal.Text = "Uredi";
            this.btnUrediMaterijal.UseVisualStyleBackColor = true;
            this.btnUrediMaterijal.Click += new System.EventHandler(this.btnUrediMaterijal_Click);
            // 
            // btnDodajMaterijal
            // 
            this.btnDodajMaterijal.Location = new System.Drawing.Point(435, 326);
            this.btnDodajMaterijal.Name = "btnDodajMaterijal";
            this.btnDodajMaterijal.Size = new System.Drawing.Size(75, 23);
            this.btnDodajMaterijal.TabIndex = 4;
            this.btnDodajMaterijal.Text = "Dodaj";
            this.btnDodajMaterijal.UseVisualStyleBackColor = true;
            this.btnDodajMaterijal.Click += new System.EventHandler(this.btnDodajMaterijal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.dobavljacimaterijaliDataGridViewTextBoxColumn,
            this.skladistematerijaliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materijaliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 307);
            this.dataGridView1.TabIndex = 7;
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
            // dobavljacimaterijaliDataGridViewTextBoxColumn
            // 
            this.dobavljacimaterijaliDataGridViewTextBoxColumn.DataPropertyName = "dobavljaci_materijali";
            this.dobavljacimaterijaliDataGridViewTextBoxColumn.HeaderText = "dobavljaci_materijali";
            this.dobavljacimaterijaliDataGridViewTextBoxColumn.Name = "dobavljacimaterijaliDataGridViewTextBoxColumn";
            this.dobavljacimaterijaliDataGridViewTextBoxColumn.Visible = false;
            // 
            // skladistematerijaliDataGridViewTextBoxColumn
            // 
            this.skladistematerijaliDataGridViewTextBoxColumn.DataPropertyName = "skladiste_materijali";
            this.skladistematerijaliDataGridViewTextBoxColumn.HeaderText = "skladiste_materijali";
            this.skladistematerijaliDataGridViewTextBoxColumn.Name = "skladistematerijaliDataGridViewTextBoxColumn";
            this.skladistematerijaliDataGridViewTextBoxColumn.Visible = false;
            // 
            // materijaliBindingSource
            // 
            this.materijaliBindingSource.DataSource = typeof(Hammer.materijali);
            // 
            // frmMaterijali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnObrisiMaterijal);
            this.Controls.Add(this.btnUrediMaterijal);
            this.Controls.Add(this.btnDodajMaterijal);
            this.Name = "frmMaterijali";
            this.Text = "frmMaterijali";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijaliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiMaterijal;
        private System.Windows.Forms.Button btnUrediMaterijal;
        private System.Windows.Forms.Button btnDodajMaterijal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacimaterijaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skladistematerijaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource materijaliBindingSource;
    }
}