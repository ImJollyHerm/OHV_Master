using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Obsthandel
{
    public class Waren : Form
    {
        private Backend backend;

        private Hauptform hauptform;

        private IContainer components = null;

        private Button bt_new;

        private TextBox tB_Preis;

        private Label label6;

        private TextBox tB_Bezeichnung;

        private Label label5;

        private TextBox tB_Nr;

        private Button bt_Change;

        private Button bt_refresh;

        private DataGridView dataGridView1;

        private Panel panel1;

        private Label label3;

        private Button bt_Insert;

        private Label label2;

        private Label label1;
        private Panel panel2;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kundeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn bezahltDataGridViewCheckBoxColumn;
        private BindingSource orderBindingSource;
        private TextBox tB_suchwort;

        public Waren(Hauptform haupt, Backend back)
        {
            hauptform = haupt;
            backend = back;
            InitializeComponent();
        }

        private void Bt_Change_Click(object sender, EventArgs e)
        {
            backend.Update_Artikel(tB_Bezeichnung.Text, Convert.ToDouble(tB_Preis), Convert.ToInt32(tB_Nr));
            Waren_Shown(null, null);
            bt_Change.Enabled = true;
            bt_Insert.Enabled = false;
            Clear_Boxes();
        }

        private void Bt_Insert_Click(object sender, EventArgs e)
        {
            Waren_Shown(null, null);
            Clear_Boxes();
            bt_Change.Enabled = true;
            bt_Insert.Enabled = false;
        }

        private void Bt_new_Click(object sender, EventArgs e)
        {
            bt_Insert.Enabled = true;
            bt_Change.Enabled = false;
            Clear_Boxes();
        }

        private void Clear_Boxes()
        {
            tB_Nr.Text = null;
            tB_Preis.Text = null;
            tB_Bezeichnung.Text = null;
        }

        private void TB_suchwort_TextChanged(object sender, EventArgs e)
        {
            BindingList<Artikel> artikelliste = backend.Select_Artikel(tB_suchwort.Text, "artikel");
            dataGridView1.AutoGenerateColumns = true;
            orderBindingSource.DataSource = artikelliste;
        }

        private void Waren_Shown(object sender, EventArgs e)
        {
            BindingList<Artikel> artikelliste = backend.Select_Artikel("artikel");
            dataGridView1.AutoGenerateColumns = true;
            orderBindingSource.DataSource = artikelliste;
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Artikel a = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as Artikel;
                tB_Nr.Text = Convert.ToString(a.Id);
                tB_Bezeichnung.Text = a.Bezeichnung;
                tB_Preis.Text = Convert.ToString(a.Preis);
            }
            catch
            {
                MessageBox.Show("Das ist etwas schief gelaufen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_new = new System.Windows.Forms.Button();
            this.tB_Preis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_Bezeichnung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_Nr = new System.Windows.Forms.TextBox();
            this.bt_Change = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_suchwort = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezahltDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // tB_Preis
            //
            this.tB_Preis.Location = new System.Drawing.Point(7, 148);
            this.tB_Preis.Name = "tB_Preis";
            this.tB_Preis.Size = new System.Drawing.Size(100, 20);
            this.tB_Preis.TabIndex = 10;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Preis:";
            //
            // tB_Bezeichnung
            //
            this.tB_Bezeichnung.Location = new System.Drawing.Point(7, 109);
            this.tB_Bezeichnung.Name = "tB_Bezeichnung";
            this.tB_Bezeichnung.Size = new System.Drawing.Size(100, 20);
            this.tB_Bezeichnung.TabIndex = 8;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bezeichnung:";
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
            // bt_refresh
            //
            this.bt_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_refresh.Location = new System.Drawing.Point(536, 43);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(24, 23);
            this.bt_refresh.TabIndex = 11;
            this.bt_refresh.UseVisualStyleBackColor = true;
            //
            // dataGridView1
            //
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.kundeDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.preisDataGridViewTextBoxColumn,
            this.bezahltDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(567, 346);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            //
            // panel1
            //
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bt_new);
            this.panel1.Controls.Add(this.tB_Preis);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tB_Bezeichnung);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tB_Nr);
            this.panel1.Controls.Add(this.bt_Change);
            this.panel1.Controls.Add(this.bt_Insert);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(588, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 426);
            this.panel1.TabIndex = 9;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "WarenNr:";
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
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ware ändern / anlegen:";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Suchbegriff";
            //
            // tB_suchwort
            //
            this.tB_suchwort.Location = new System.Drawing.Point(6, 43);
            this.tB_suchwort.Name = "tB_suchwort";
            this.tB_suchwort.Size = new System.Drawing.Size(100, 20);
            this.tB_suchwort.TabIndex = 7;
            this.tB_suchwort.TextChanged += new System.EventHandler(this.TB_suchwort_TextChanged);
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
            this.panel2.Size = new System.Drawing.Size(567, 73);
            this.panel2.TabIndex = 12;
            //
            // orderBindingSource
            //
            this.orderBindingSource.DataSource = typeof(Obsthandel.Order);
            //
            // iDDataGridViewTextBoxColumn
            //
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // kundeDataGridViewTextBoxColumn
            //
            this.kundeDataGridViewTextBoxColumn.DataPropertyName = "Kunde";
            this.kundeDataGridViewTextBoxColumn.HeaderText = "Kunde";
            this.kundeDataGridViewTextBoxColumn.Name = "kundeDataGridViewTextBoxColumn";
            this.kundeDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // datumDataGridViewTextBoxColumn
            //
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // preisDataGridViewTextBoxColumn
            //
            this.preisDataGridViewTextBoxColumn.DataPropertyName = "Preis";
            this.preisDataGridViewTextBoxColumn.HeaderText = "Preis";
            this.preisDataGridViewTextBoxColumn.Name = "preisDataGridViewTextBoxColumn";
            this.preisDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // bezahltDataGridViewCheckBoxColumn
            //
            this.bezahltDataGridViewCheckBoxColumn.DataPropertyName = "Bezahlt";
            this.bezahltDataGridViewCheckBoxColumn.HeaderText = "Bezahlt";
            this.bezahltDataGridViewCheckBoxColumn.Name = "bezahltDataGridViewCheckBoxColumn";
            this.bezahltDataGridViewCheckBoxColumn.ReadOnly = true;
            //
            // Waren
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Waren";
            this.Text = "Waren";
            this.Shown += new System.EventHandler(this.Waren_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
        }
    }
}