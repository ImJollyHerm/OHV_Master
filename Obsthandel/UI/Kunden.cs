using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obsthandel
{
    public partial class Kunden : Form
    {
        private Backend backend;
        private Hauptform hauptform;

        public Kunden()
        {
            InitializeComponent();
        }

        private void Fill_Orte()
        {
            foreach(string s in backend.Select_Ort("ort"))
            {
                cb_PLZ.Items.Add(s);
            }
        }

        public Kunden(Hauptform haupt,Backend back)
        {
            InitializeComponent();
            hauptform = haupt;
            backend = back;
        }

        private void TB_suchwort_TextChanged(object sender, EventArgs e)
        {
            BindingList<Kunde> kundenliste = backend.Select_Kunde(tB_suchwort.Text, "kunde");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = kundenliste;
        }

        private void Kunden_Shown(object sender, EventArgs e)
        {
            Fill_Orte();
            BindingList<Kunde> kundenliste = backend.Select_Kunde("kunde");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = kundenliste;
        }

        private void Bt_Change_Click(object sender, EventArgs e)
        {
            backend.Update_Kunde(tB_Vorname.Text, tB_nachname.Text, tB_Straße.Text, cb_PLZ.SelectedItem.ToString(), Convert.ToInt32(tB_Nr.Text));
            Kunden_Shown(null, null);
            ClearCoustomer();
            bt_Change.Enabled = true;
            bt_Insert.Enabled = false;
        }

        private void Bt_Insert_Click(object sender, EventArgs e)
        {
            backend.Insert_Kunde(tB_Vorname.Text, tB_nachname.Text, tB_Straße.Text, cb_PLZ.SelectedItem.ToString());
            Kunden_Shown(null, null);
            ClearCoustomer();
            bt_Change.Enabled = true;
            bt_Insert.Enabled = false;
        }

        private void ClearCoustomer()
        {
            bt_Change.Enabled = false;
            tB_Nr.Text = null;
            tB_nachname.Text = null;
            tB_Straße.Text = null;
            tB_Vorname.Text = null;
            cb_PLZ.SelectedItem = null;
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Kunde k = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as Kunde;
                tB_Nr.Text = Convert.ToString(k.KundenID);
                tB_nachname.Text = k.Nachname;
                tB_Straße.Text = k.Strasse;
                tB_Vorname.Text = k.Vorname;
                cb_PLZ.SelectedIndex = cb_PLZ.FindString(k.PLZ);
            }
            catch
            {
            }
        }

        private void Bt_refresh_Click(object sender, EventArgs e)
        {
            Kunden_Shown(null, null);
        }

        private void Bt_new_Click(object sender, EventArgs e)
        {
            bt_Insert.Enabled = true;
            bt_Change.Enabled = false;
            ClearCoustomer();
        }
    }
}