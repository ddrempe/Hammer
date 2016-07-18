namespace Hammer
{
    partial class frmDodijeliAlat
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
            this.txtGradiliste = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAlat = new System.Windows.Forms.ComboBox();
            this.alatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGradiliste
            // 
            this.txtGradiliste.Location = new System.Drawing.Point(72, 17);
            this.txtGradiliste.Name = "txtGradiliste";
            this.txtGradiliste.Size = new System.Drawing.Size(121, 20);
            this.txtGradiliste.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gradilište:";
            // 
            // cmbAlat
            // 
            this.cmbAlat.DataSource = this.alatiBindingSource;
            this.cmbAlat.DisplayMember = "naziv";
            this.cmbAlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlat.FormattingEnabled = true;
            this.cmbAlat.Location = new System.Drawing.Point(72, 59);
            this.cmbAlat.Name = "cmbAlat";
            this.cmbAlat.Size = new System.Drawing.Size(121, 21);
            this.cmbAlat.TabIndex = 2;
            this.cmbAlat.ValueMember = "id";
            // 
            // alatiBindingSource
            // 
            this.alatiBindingSource.DataSource = typeof(Hammer.alati);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alat:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(118, 102);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 23;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(16, 102);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 22;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmDodijeliAlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 136);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAlat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGradiliste);
            this.Name = "frmDodijeliAlat";
            this.Text = "frmDodijeliAlat";
            this.Load += new System.EventHandler(this.frmDodijeliAlat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alatiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGradiliste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.BindingSource alatiBindingSource;
    }
}