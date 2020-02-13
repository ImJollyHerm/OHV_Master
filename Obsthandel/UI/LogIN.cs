using System;
using System.Windows.Forms;

namespace Obsthandel
{
    public partial class LogIN : Form
    {
        public bool login = false;
        public Hauptform frontend;
        private Backend backend;

        public LogIN(Hauptform front, Backend back)
        {
            frontend = front;
            backend = back;
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (!login)
            {
                if (tB_benutzer.Text != null)
                    backend.Uid = tB_benutzer.Text;

                backend.Password = tB_PW.Text;
                login = backend.Login(this);
                if (login)
                {
                    backend.Logind = true;
                    Close();
                }
                else
                {
                    backend.Logind = false;
                    tB_benutzer.Clear();
                    tB_PW.Clear();
                }
            }
        }
    }
}