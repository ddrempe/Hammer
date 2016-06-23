namespace Hammer
{
    partial class frmGlavniIzbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavniIzbornik));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.evidencijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradilištaIDodjeljivanjeZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaAlatastrojevaiVoznogParkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaMaterijalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obračunPlaćaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaDobavljačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1166, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaToolStripMenuItem,
            this.evidencijaAlatastrojevaiVoznogParkaToolStripMenuItem,
            this.evidencijaMaterijalaToolStripMenuItem,
            this.obračunPlaćaToolStripMenuItem,
            this.evidencijaDobavljačaToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // evidencijaToolStripMenuItem
            // 
            this.evidencijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaZaposlenikaToolStripMenuItem,
            this.gradilištaIDodjeljivanjeZaposlenikaToolStripMenuItem});
            this.evidencijaToolStripMenuItem.Name = "evidencijaToolStripMenuItem";
            this.evidencijaToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.evidencijaToolStripMenuItem.Text = "Evidencija gradilišta i zaposlenika";
            // 
            // evidencijaZaposlenikaToolStripMenuItem
            // 
            this.evidencijaZaposlenikaToolStripMenuItem.Name = "evidencijaZaposlenikaToolStripMenuItem";
            this.evidencijaZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.evidencijaZaposlenikaToolStripMenuItem.Text = "Evidencija zaposlenika";
            this.evidencijaZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.evidencijaZaposlenikaToolStripMenuItem_Click);
            // 
            // gradilištaIDodjeljivanjeZaposlenikaToolStripMenuItem
            // 
            this.gradilištaIDodjeljivanjeZaposlenikaToolStripMenuItem.Name = "gradilištaIDodjeljivanjeZaposlenikaToolStripMenuItem";
            this.gradilištaIDodjeljivanjeZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.gradilištaIDodjeljivanjeZaposlenikaToolStripMenuItem.Text = "Gradilišta i dodjeljivanje zaposlenika";
            this.gradilištaIDodjeljivanjeZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.gradilištaIDodjeljivanjeZaposlenikaToolStripMenuItem_Click);
            // 
            // evidencijaAlatastrojevaiVoznogParkaToolStripMenuItem
            // 
            this.evidencijaAlatastrojevaiVoznogParkaToolStripMenuItem.Name = "evidencijaAlatastrojevaiVoznogParkaToolStripMenuItem";
            this.evidencijaAlatastrojevaiVoznogParkaToolStripMenuItem.Size = new System.Drawing.Size(282, 24);
            this.evidencijaAlatastrojevaiVoznogParkaToolStripMenuItem.Text = "Evidencija alata,strojeva i voznog parka";
            // 
            // evidencijaMaterijalaToolStripMenuItem
            // 
            this.evidencijaMaterijalaToolStripMenuItem.Name = "evidencijaMaterijalaToolStripMenuItem";
            this.evidencijaMaterijalaToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.evidencijaMaterijalaToolStripMenuItem.Text = "Evidencija materijala";
            // 
            // obračunPlaćaToolStripMenuItem
            // 
            this.obračunPlaćaToolStripMenuItem.Name = "obračunPlaćaToolStripMenuItem";
            this.obračunPlaćaToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.obračunPlaćaToolStripMenuItem.Text = "Obračun plaća";
            // 
            // evidencijaDobavljačaToolStripMenuItem
            // 
            this.evidencijaDobavljačaToolStripMenuItem.Name = "evidencijaDobavljačaToolStripMenuItem";
            this.evidencijaDobavljačaToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.evidencijaDobavljačaToolStripMenuItem.Text = "Evidencija dobavljača";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Matej Cvitkovic\\Documents\\Hammer\\help.chm";
            // 
            // frmGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGlavniIzbornik";
            this.Text = "frmGlavniIzbornik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem evidencijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradilištaIDodjeljivanjeZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaAlatastrojevaiVoznogParkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaMaterijalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obračunPlaćaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaDobavljačaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}



