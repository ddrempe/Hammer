namespace Hammer
{
    partial class frmDodijeliMaterijal
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaterijal = new System.Windows.Forms.ComboBox();
            this.materijaliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSkladiste = new System.Windows.Forms.TextBox();
            this.skladistematerijaliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.materijaliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladistematerijaliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(124, 133);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 35;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(22, 133);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 34;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Materijal:";
            // 
            // cmbMaterijal
            // 
            this.cmbMaterijal.DataSource = this.materijaliBindingSource;
            this.cmbMaterijal.DisplayMember = "naziv";
            this.cmbMaterijal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterijal.FormattingEnabled = true;
            this.cmbMaterijal.Location = new System.Drawing.Point(78, 40);
            this.cmbMaterijal.Name = "cmbMaterijal";
            this.cmbMaterijal.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterijal.TabIndex = 32;
            this.cmbMaterijal.ValueMember = "id";
            // 
            // materijaliBindingSource
            // 
            this.materijaliBindingSource.DataSource = typeof(Hammer.materijali);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Skladište:";
            // 
            // txtSkladiste
            // 
            this.txtSkladiste.Location = new System.Drawing.Point(78, 14);
            this.txtSkladiste.Name = "txtSkladiste";
            this.txtSkladiste.Size = new System.Drawing.Size(121, 20);
            this.txtSkladiste.TabIndex = 30;
            // 
            // skladistematerijaliBindingSource
            // 
            this.skladistematerijaliBindingSource.DataSource = typeof(Hammer.skladiste_materijali);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(78, 67);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(121, 20);
            this.txtOpis.TabIndex = 36;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(78, 93);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(121, 20);
            this.txtKolicina.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Opis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Količina:";
            // 
            // frmDodijeliMaterijal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 170);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMaterijal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSkladiste);
            this.Name = "frmDodijeliMaterijal";
            this.Text = "frmDodijeliMaterijal";
            this.Load += new System.EventHandler(this.frmDodijeliMaterijal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materijaliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladistematerijaliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaterijal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSkladiste;
        private System.Windows.Forms.BindingSource skladistematerijaliBindingSource;
        private System.Windows.Forms.BindingSource materijaliBindingSource;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}