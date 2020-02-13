using System;
using System.Windows.Forms;

namespace Obsthandel
{
    public partial class Hauptform : Form
    {
        private Backend backend;
        private LogIN login;
        private Kunden frontend;
        private AboutBox aboutBox;
        private Waren waren;
        private Bestelluebersicht bestelluebersicht;

        public Hauptform()
        {
            InitializeComponent();
            backend = new Backend(this);
        }

        private void AnmeldungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login != null)
            {
                login.Close();
                login.Dispose();
            }
            login = new LogIN(this, backend)
            {
                TopLevel = false,
                AutoScroll = true
            };
            panel1.Controls.Add(login);
            login.Show();
        }

        public void Login(LogIN login)
        {
            backend.Login(login);
        }

        private void KundenverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backend.Logind)
            {
                if (frontend != null)
                {
                    frontend.Close();
                    frontend.Dispose();
                }
                frontend = new Kunden(this, backend)
                {
                    TopLevel = false,
                    AutoScroll = true
                };
                panel1.Controls.Add(frontend);
                frontend.Show();
            }
            else
            {
                MessageBox.Show("Loggen sie sich bitte ein! \n Die Verbindung zur Datenbank muss hergestellt werden!", "Verbindung zu Datenbank fehlt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutBox != null)
            {
                aboutBox.Close();
                aboutBox.Dispose();
            }
            aboutBox = new AboutBox()
            {
                TopLevel = false,
                AutoScroll = true
            };
            panel1.Controls.Add(aboutBox);
            aboutBox.Show();
        }

        private void WarenverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backend.Logind)
            {
                if (waren != null)
                {
                    waren.Close();
                    waren.Dispose();
                }
                waren = new Waren(this, backend)
                {
                    TopLevel = false,
                    AutoScroll = true
                };
                panel1.Controls.Add(waren);
                waren.Show();
            }
            else
            {
                MessageBox.Show("Loggen sie sich bitte ein! \n Die Verbindung zur Datenbank muss hergestellt werden!", "Verbindung zu Datenbank fehlt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RechnungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backend.Logind)
            {
                if (bestelluebersicht != null)
                {
                    bestelluebersicht.Close();
                    bestelluebersicht.Dispose();
                }
                bestelluebersicht = new Bestelluebersicht(this, backend)
                {
                    TopLevel = false,
                    AutoScroll = true
                };
                panel1.Controls.Add(bestelluebersicht);
                bestelluebersicht.Show();
            }
            else
            {
                MessageBox.Show("Loggen sie sich bitte ein! \n Die Verbindung zur Datenbank muss hergestellt werden!", "Verbindung zu Datenbank fehlt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}