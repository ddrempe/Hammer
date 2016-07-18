namespace Hammer
{
    partial class frmStrojevi
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
            this.btnUrediStroj = new System.Windows.Forms.Button();
            this.btnDodajStroj = new System.Windows.Forms.Button();
            this.dgvStrojevi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godproizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumregistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snagaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradilistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strojeviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrojevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strojeviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiStroj
            // 
            this.btnObrisiStroj.Location = new System.Drawing.Point(682, 326);
            this.btnObrisiStroj.Name = "btnObrisiStroj";
            this.btnObrisiStroj.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiStroj.TabIndex = 6;
            this.btnObrisiStroj.Text = "Obriši";
            this.btnObrisiStroj.UseVisualStyleBackColor = true;
            this.btnObrisiStroj.Click += new System.EventHandler(this.btnObrisiStroj_Click);
            // 
            // btnUrediStroj
            // 
            this.btnUrediStroj.Location = new System.Drawing.Point(601, 326);
            this.btnUrediStroj.Name = "btnUrediStroj";
            this.btnUrediStroj.Size = new System.Drawing.Size(75, 23);
            this.btnUrediStroj.TabIndex = 5;
            this.btnUrediStroj.Text = "Uredi";
            this.btnUrediStroj.UseVisualStyleBackColor = true;
            this.btnUrediStroj.Click += new System.EventHandler(this.btnUrediStroj_Click);
            // 
            // btnDodajStroj
            // 
            this.btnDodajStroj.Location = new System.Drawing.Point(520, 326);
            this.btnDodajStroj.Name = "btnDodajStroj";
            this.btnDodajStroj.Size = new System.Drawing.Size(75, 23);
            this.btnDodajStroj.TabIndex = 4;
            this.btnDodajStroj.Text = "Dodaj";
            this.btnDodajStroj.UseVisualStyleBackColor = true;
            this.btnDodajStroj.Click += new System.EventHandler(this.btnDodajStroj_Click);
            // 
            // dgvStrojevi
            // 
            this.dgvStrojevi.AutoGenerateColumns = false;
            this.dgvStrojevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrojevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.servisDataGridViewTextBoxColumn,
            this.godproizvodnjeDataGridViewTextBoxColumn,
            this.datumregistracijeDataGridViewTextBoxColumn,
            this.snagaDataGridViewTextBoxColumn,
            this.gradilistaDataGridViewTextBoxColumn});
            this.dgvStrojevi.DataSource = this.strojeviBindingSource;
            this.dgvStrojevi.Location = new System.Drawing.Point(13, 13);
            this.dgvStrojevi.Name = "dgvStrojevi";
            this.dgvStrojevi.Size = new System.Drawing.Size(744, 307);
            this.dgvStrojevi.TabIndex = 7;
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
            // servisDataGridViewTextBoxColumn
            // 
            this.servisDataGridViewTextBoxColumn.DataPropertyName = "servis";
            this.servisDataGridViewTextBoxColumn.HeaderText = "Servis";
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
            // frmStrojevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 361);
            this.Controls.Add(this.dgvStrojevi);
            this.Controls.Add(this.btnObrisiStroj);
            this.Controls.Add(this.btnUrediStroj);
            this.Controls.Add(this.btnDodajStroj);
            this.Name = "frmStrojevi";
            this.Text = "frmStrojevi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrojevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strojeviBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiStroj;
        private System.Windows.Forms.Button btnUrediStroj;
        private System.Windows.Forms.Button btnDodajStroj;
        private System.Windows.Forms.DataGridView dgvStrojevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godproizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumregistracijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snagaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradilistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource strojeviBindingSource;
    }
}