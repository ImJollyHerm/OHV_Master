namespace Obsthandel
{
    partial class Hauptform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anmeldungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundenverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warenverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechnungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.kundenverwaltungToolStripMenuItem,
            this.warenverwaltungToolStripMenuItem,
            this.rechnungenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anmeldungToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // anmeldungToolStripMenuItem
            // 
            this.anmeldungToolStripMenuItem.Name = "anmeldungToolStripMenuItem";
            this.anmeldungToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.anmeldungToolStripMenuItem.Text = "Anmeldung";
            this.anmeldungToolStripMenuItem.Click += new System.EventHandler(this.AnmeldungToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // kundenverwaltungToolStripMenuItem
            // 
            this.kundenverwaltungToolStripMenuItem.Name = "kundenverwaltungToolStripMenuItem";
            this.kundenverwaltungToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.kundenverwaltungToolStripMenuItem.Text = "Kundenverwaltung";
            this.kundenverwaltungToolStripMenuItem.Click += new System.EventHandler(this.KundenverwaltungToolStripMenuItem_Click);
            // 
            // warenverwaltungToolStripMenuItem
            // 
            this.warenverwaltungToolStripMenuItem.Name = "warenverwaltungToolStripMenuItem";
            this.warenverwaltungToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.warenverwaltungToolStripMenuItem.Text = "Warenverwaltung";
            this.warenverwaltungToolStripMenuItem.Click += new System.EventHandler(this.WarenverwaltungToolStripMenuItem_Click);
            // 
            // rechnungenToolStripMenuItem
            // 
            this.rechnungenToolStripMenuItem.Name = "rechnungenToolStripMenuItem";
            this.rechnungenToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.rechnungenToolStripMenuItem.Text = "Bestellungen";
            this.rechnungenToolStripMenuItem.Click += new System.EventHandler(this.RechnungenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anzeigenToolStripMenuItem,
            this.neuToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // anzeigenToolStripMenuItem
            // 
            this.anzeigenToolStripMenuItem.Name = "anzeigenToolStripMenuItem";
            this.anzeigenToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.anzeigenToolStripMenuItem.Text = "Anzeigen";
            this.anzeigenToolStripMenuItem.Click += new System.EventHandler(this.AnzeigenToolStripMenuItem_Click);
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 628);
            this.panel1.TabIndex = 1;
            // 
            // Hauptform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Hauptform";
            this.Text = "Hauptform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anmeldungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundenverwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warenverwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechnungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}