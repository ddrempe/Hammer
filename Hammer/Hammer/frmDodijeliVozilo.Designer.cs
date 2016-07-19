namespace Hammer
{
    partial class frmDodijeliVozilo
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
            this.cmbVozilo = new System.Windows.Forms.ComboBox();
            this.vozniparkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vozniparkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(124, 99);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 29;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(22, 99);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 28;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Vozilo:";
            // 
            // cmbVozilo
            // 
            this.cmbVozilo.DataSource = this.vozniparkBindingSource;
            this.cmbVozilo.DisplayMember = "naziv";
            this.cmbVozilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVozilo.FormattingEnabled = true;
            this.cmbVozilo.Location = new System.Drawing.Point(78, 56);
            this.cmbVozilo.Name = "cmbVozilo";
            this.cmbVozilo.Size = new System.Drawing.Size(121, 21);
            this.cmbVozilo.TabIndex = 26;
            this.cmbVozilo.ValueMember = "id";
            // 
            // vozniparkBindingSource
            // 
            this.vozniparkBindingSource.DataSource = typeof(Hammer.vozni_park);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Zaposlenik:";
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(78, 14);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.Size = new System.Drawing.Size(121, 20);
            this.txtZaposlenik.TabIndex = 24;
            // 
            // frmDodijeliVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 136);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVozilo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZaposlenik);
            this.Name = "frmDodijeliVozilo";
            this.Text = "frmDodijeliVozilo";
            this.Load += new System.EventHandler(this.frmDodijeliVozilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vozniparkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVozilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.BindingSource vozniparkBindingSource;
    }
}