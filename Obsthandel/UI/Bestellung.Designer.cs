namespace Obsthandel
{
    partial class Bestellung
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_PLZ = new System.Windows.Forms.ComboBox();
            this.tB_Straße = new System.Windows.Forms.TextBox();
            this.tB_nachname = new System.Windows.Forms.TextBox();
            this.tB_Vorname = new System.Windows.Forms.TextBox();
            this.tB_Nr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tB_Realprice = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tB_Rabatt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tB_calcPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cb_PLZ);
            this.panel1.Controls.Add(this.tB_Straße);
            this.panel1.Controls.Add(this.tB_nachname);
            this.panel1.Controls.Add(this.tB_Vorname);
            this.panel1.Controls.Add(this.tB_Nr);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 518);
            this.panel1.TabIndex = 0;
            // 
            // cb_PLZ
            // 
            this.cb_PLZ.FormattingEnabled = true;
            this.cb_PLZ.Location = new System.Drawing.Point(7, 104);
            this.cb_PLZ.Name = "cb_PLZ";
            this.cb_PLZ.Size = new System.Drawing.Size(157, 21);
            this.cb_PLZ.TabIndex = 19;
            // 
            // tB_Straße
            // 
            this.tB_Straße.Location = new System.Drawing.Point(170, 105);
            this.tB_Straße.Name = "tB_Straße";
            this.tB_Straße.Size = new System.Drawing.Size(100, 20);
            this.tB_Straße.TabIndex = 18;
            // 
            // tB_nachname
            // 
            this.tB_nachname.Location = new System.Drawing.Point(113, 78);
            this.tB_nachname.Name = "tB_nachname";
            this.tB_nachname.Size = new System.Drawing.Size(100, 20);
            this.tB_nachname.TabIndex = 17;
            // 
            // tB_Vorname
            // 
            this.tB_Vorname.Location = new System.Drawing.Point(7, 78);
            this.tB_Vorname.Name = "tB_Vorname";
            this.tB_Vorname.Size = new System.Drawing.Size(100, 20);
            this.tB_Vorname.TabIndex = 16;
            // 
            // tB_Nr
            // 
            this.tB_Nr.Enabled = false;
            this.tB_Nr.Location = new System.Drawing.Point(7, 52);
            this.tB_Nr.Name = "tB_Nr";
            this.tB_Nr.ReadOnly = true;
            this.tB_Nr.Size = new System.Drawing.Size(35, 20);
            this.tB_Nr.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Kunde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bestellinformationen:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(349, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 334);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 307);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Positionen:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(350, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 178);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(144, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rabatt (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "End Preis:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.tB_Realprice);
            this.panel5.Location = new System.Drawing.Point(579, 138);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(99, 30);
            this.panel5.TabIndex = 5;
            // 
            // tB_Realprice
            // 
            this.tB_Realprice.Location = new System.Drawing.Point(3, 3);
            this.tB_Realprice.Name = "tB_Realprice";
            this.tB_Realprice.Size = new System.Drawing.Size(89, 20);
            this.tB_Realprice.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.tB_Rabatt);
            this.panel7.Location = new System.Drawing.Point(430, 138);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(99, 30);
            this.panel7.TabIndex = 4;
            // 
            // tB_Rabatt
            // 
            this.tB_Rabatt.Location = new System.Drawing.Point(3, 3);
            this.tB_Rabatt.Name = "tB_Rabatt";
            this.tB_Rabatt.Size = new System.Drawing.Size(89, 20);
            this.tB_Rabatt.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.tB_calcPrice);
            this.panel4.Location = new System.Drawing.Point(272, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(99, 30);
            this.panel4.TabIndex = 3;
            // 
            // tB_calcPrice
            // 
            this.tB_calcPrice.Location = new System.Drawing.Point(3, 3);
            this.tB_calcPrice.Name = "tB_calcPrice";
            this.tB_calcPrice.Size = new System.Drawing.Size(89, 20);
            this.tB_calcPrice.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kalkulierter Preis:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Position hinzufügen";
            // 
            // Bestellung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 535);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Bestellung";
            this.Text = "Bestellung";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tB_Realprice;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tB_Rabatt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tB_calcPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_PLZ;
        private System.Windows.Forms.TextBox tB_Straße;
        private System.Windows.Forms.TextBox tB_nachname;
        private System.Windows.Forms.TextBox tB_Vorname;
        private System.Windows.Forms.TextBox tB_Nr;
    }
}