namespace Obsthandel
{
    partial class Kunden
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tB_suchwort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_new = new System.Windows.Forms.Button();
            this.cb_PLZ = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_Straße = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_nachname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_Vorname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Nr = new System.Windows.Forms.TextBox();
            this.bt_Change = new System.Windows.Forms.Button();
            this.bt_Insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tB_suchwort
            // 
            this.tB_suchwort.Location = new System.Drawing.Point(3, 41);
            this.tB_suchwort.Name = "tB_suchwort";
            this.tB_suchwort.Size = new System.Drawing.Size(100, 20);
            this.tB_suchwort.TabIndex = 2;
            this.tB_suchwort.TextChanged += new System.EventHandler(this.TB_suchwort_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suchbegriff";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bt_new);
            this.panel1.Controls.Add(this.cb_PLZ);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tB_Straße);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tB_nachname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tB_Vorname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tB_Nr);
            this.panel1.Controls.Add(this.bt_Change);
            this.panel1.Controls.Add(this.bt_Insert);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(588, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 426);
            this.panel1.TabIndex = 4;
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(61, 55);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(75, 23);
            this.bt_new.TabIndex = 14;
            this.bt_new.Text = "Neue ID";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.Bt_new_Click);
            // 
            // cb_PLZ
            // 
            this.cb_PLZ.FormattingEnabled = true;
            this.cb_PLZ.Location = new System.Drawing.Point(7, 250);
            this.cb_PLZ.Name = "cb_PLZ";
            this.cb_PLZ.Size = new System.Drawing.Size(121, 21);
            this.cb_PLZ.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ort:";
            // 
            // tB_Straße
            // 
            this.tB_Straße.Location = new System.Drawing.Point(7, 211);
            this.tB_Straße.Name = "tB_Straße";
            this.tB_Straße.Size = new System.Drawing.Size(100, 20);
            this.tB_Straße.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Straße:";
            // 
            // tB_nachname
            // 
            this.tB_nachname.Location = new System.Drawing.Point(7, 172);
            this.tB_nachname.Name = "tB_nachname";
            this.tB_nachname.Size = new System.Drawing.Size(100, 20);
            this.tB_nachname.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nachname:";
            // 
            // tB_Vorname
            // 
            this.tB_Vorname.Location = new System.Drawing.Point(7, 133);
            this.tB_Vorname.Name = "tB_Vorname";
            this.tB_Vorname.Size = new System.Drawing.Size(100, 20);
            this.tB_Vorname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vorname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "KundenNr:";
            // 
            // tB_Nr
            // 
            this.tB_Nr.Enabled = false;
            this.tB_Nr.Location = new System.Drawing.Point(7, 55);
            this.tB_Nr.Name = "tB_Nr";
            this.tB_Nr.ReadOnly = true;
            this.tB_Nr.Size = new System.Drawing.Size(35, 20);
            this.tB_Nr.TabIndex = 3;
            // 
            // bt_Change
            // 
            this.bt_Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Change.Location = new System.Drawing.Point(7, 367);
            this.bt_Change.Name = "bt_Change";
            this.bt_Change.Size = new System.Drawing.Size(75, 23);
            this.bt_Change.TabIndex = 2;
            this.bt_Change.Text = "Ändern";
            this.bt_Change.UseVisualStyleBackColor = true;
            this.bt_Change.Click += new System.EventHandler(this.Bt_Change_Click);
            // 
            // bt_Insert
            // 
            this.bt_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Insert.Enabled = false;
            this.bt_Insert.Location = new System.Drawing.Point(7, 396);
            this.bt_Insert.Name = "bt_Insert";
            this.bt_Insert.Size = new System.Drawing.Size(75, 23);
            this.bt_Insert.TabIndex = 1;
            this.bt_Insert.Text = "Anlegen";
            this.bt_Insert.UseVisualStyleBackColor = true;
            this.bt_Insert.Click += new System.EventHandler(this.Bt_Insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kunden ändern / anlegen:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(567, 346);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // bt_refresh
            // 
            this.bt_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_refresh.Location = new System.Drawing.Point(536, 38);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(24, 23);
            this.bt_refresh.TabIndex = 6;
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.Bt_refresh_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bt_refresh);
            this.panel2.Controls.Add(this.tB_suchwort);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 74);
            this.panel2.TabIndex = 7;
            // 
            // Kunden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Kunden";
            this.Text = "Kundenverwaltung";
            this.Shown += new System.EventHandler(this.Kunden_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tB_suchwort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_PLZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_Straße;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_nachname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_Vorname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Nr;
        private System.Windows.Forms.Button bt_Change;
        private System.Windows.Forms.Button bt_Insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Panel panel2;
    }
}

