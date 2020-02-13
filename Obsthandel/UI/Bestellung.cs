using System.Windows.Forms;

namespace Obsthandel
{
    public partial class Bestellung : Form
    {
        private Order order;
        public Bestellung(Order porder)
        {
            InitializeComponent();
            order = porder;
        }
    }
}