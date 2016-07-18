namespace Hammer
{
    partial class frmDodijeliStroj
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
            this.cmbStroj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGradiliste = new System.Windows.Forms.TextBox();
            this.strojeviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.strojeviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(126, 99);
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
            this.btnSpremi.Location = new System.Drawing.Point(24, 99);
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
            this.label2.Location = new System.Drawing.Point(46, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Stroj:";
            // 
            // cmbStroj
            // 
            this.cmbStroj.DataSource = this.strojeviBindingSource;
            this.cmbStroj.DisplayMember = "naziv";
            this.cmbStroj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStroj.FormattingEnabled = true;
            this.cmbStroj.Location = new System.Drawing.Point(80, 56);
            this.cmbStroj.Name = "cmbStroj";
            this.cmbStroj.Size = new System.Drawing.Size(121, 21);
            this.cmbStroj.TabIndex = 26;
            this.cmbStroj.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gradilište:";
            // 
            // txtGradiliste
            // 
            this.txtGradiliste.Location = new System.Drawing.Point(80, 14);
            this.txtGradiliste.Name = "txtGradiliste";
            this.txtGradiliste.Size = new System.Drawing.Size(121, 20);
            this.txtGradiliste.TabIndex = 24;
            // 
            // strojeviBindingSource
            // 
            this.strojeviBindingSource.DataSource = typeof(Hammer.strojevi);
            // 
            // frmDodijeliStroj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 136);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStroj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGradiliste);
            this.Name = "frmDodijeliStroj";
            this.Text = "frmDodijeliStroj";
            this.Load += new System.EventHandler(this.frmDodijeliStroj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.strojeviBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGradiliste;
        private System.Windows.Forms.BindingSource strojeviBindingSource;
    }
}