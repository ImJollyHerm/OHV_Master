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
    public partial class Bestelluebersicht : Form
    {
        private Hauptform hauptform;
        private Backend backend;
        private Order selectedOrder;

        public Bestelluebersicht(Hauptform haupt, Backend back)
        {
            hauptform = haupt;
            backend = back;
            InitializeComponent();
        }

        private void Bestelluebersicht_Shown(object sender, EventArgs e)
        {
            BindingList<Order> orderliste = backend.Select_Order("bestellung");
            dataGridView1.AutoGenerateColumns = true;
            orderBindingSource.DataSource = orderliste;
        }

        private void Bt_OrderChange_Click(object sender, EventArgs e)
        {
            if(selectedOrder != null)
            {
                Bestellung bestellung = new Bestellung(selectedOrder);
                bestellung.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bitte Bestellung auswählen", "Bestellung auswählen!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Bt_order_insert_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Order o = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as Order;
                selectedOrder = o;
            }
            catch
            {
            }
        }
    }
}