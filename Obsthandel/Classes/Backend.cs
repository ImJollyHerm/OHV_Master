using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Obsthandel
{
    public class Backend
    {
        private Hauptform frontend;
        private LogIN login;
        private MySqlConnection connection;
        private bool logind;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;

        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string Uid { get => uid; set => uid = value; }
        public string Password { get => password; set => password = value; }
        public bool Logind { get => logind; set => logind = value; }

        public Backend(Hauptform form)
        {
            frontend = form;
        }

        public bool Login(LogIN form)
        {
            login = form;
            Initialize();
            if (OpenConnection() && CloseConnection())
            {
                login.login = true;
                return true;
            }
            else
            {
                login.login = false;
                return false;
            }
        }

        //Initialize values
        private void Initialize()
        {
            server = "127.0.0.1";
            database = "obsthandel";

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public void Insert_Artikel(string pbezeichnung, double ppreis)
        {
            string query = "INSERT INTO `artikel` (`Bezeichnung`, `Preis`) VALUES ('" + pbezeichnung + "', '" + ppreis + "')";
            Insert_Query(query);
        }

        public void Insert_Kunde(string vorname, string nachname, string strasse, string PLZ)
        {
            string str = PLZ.Substring(0, 5);
            string query = "INSERT INTO `kunde` (`Vorname`, `Nachname`, `Strasse`, `PLZ`) VALUES ('" + vorname + "', '" + nachname + "', '" + strasse + "', '" + str + "')";
            Insert_Query(query);
        }

        private void Insert_Query(string query)
        {
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 1)
                    {
                        MessageBox.Show("Fehler!");
                    }
                    else
                    {
                        MessageBox.Show("Kunde korrekt angelegt", "Anlage erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                this.CloseConnection();
            }
        }

        public void Update_Kunde(string vorname, string nachname, string strasse, string PLZ, int id)
        {
            string str = PLZ.Substring(0, 5);
            string query = "UPDATE `kunde` SET `Vorname` = '" + vorname + "', `Nachname` = '" + nachname + "', `Strasse` = '" + strasse + "', `PLZ` = '" + str + "' WHERE `kunde`.`KundenID` = " + id;
            Insert_Query(query);
        }

        private string Get_Kunde(int ID)
        {
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            string kunde;
            sqlConnection.Open();
            //Create Command
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM kunde WHERE KundenID = " + ID, sqlConnection))
            {
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    kunde = dataReader["KundenID"] + " - " + Convert.ToString(dataReader["Nachname"]) + ", " + Convert.ToString(dataReader["Vorname"]);
                    dataReader.Close();
                    sqlConnection.Close();
                    return kunde;
                }
            }
            return null;
        }
        
        public BindingList<Position> Select_Position (string Tabelle, int BestellungsID)
        {
            string query = "SELECT * FROM `" + Tabelle + "` WHERE BestellungsID = " + BestellungsID;
            BindingList<Position> list = new BindingList<Position>();
            if(this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        Position newPos = new Position(Convert.ToInt32(dataReader["PositionID"])
                            , Convert.ToInt32(dataReader["BestellungsID"])
                            , Convert.ToInt32(dataReader["ArtikelID"])
                            , Convert.ToInt32(dataReader["Preis"]));

                        list.Add(newPos);
                    }

                    //close Data Reader
                    dataReader.Close();
                }
                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;

            }
            else
            {
                return list;
            }
        }

        public BindingList<Order> Select_Order(string Tabelle)
        {
            string query = "SELECT * FROM " + Tabelle;

            //Create a list to store the result
            BindingList<Order> list = new BindingList<Order>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        Order newOrder = new Order(Convert.ToInt32(dataReader["BestellungsID"])
                            , Get_Kunde(Convert.ToInt32(dataReader["KundenID"]))
                            , Convert.ToDateTime(dataReader["Datum"])
                            , Convert.ToDouble(dataReader["Preis"])
                            , Convert.ToBoolean(dataReader["Bezahlt"]));

                        list.Add(newOrder);
                    }

                    //close Data Reader
                    dataReader.Close();
                }

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Select statement
        public BindingList<Kunde> Select_Kunde(string Tabelle)
        {
            string query = "SELECT * FROM " + Tabelle;

            //Create a list to store the result
            BindingList<Kunde> list = new BindingList<Kunde>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                return Get_Query_Kunden(query, list);
            }
            else
            {
                return list;
            }
        }

        public BindingList<Kunde> Select_Kunde(string suchwort, string Tabelle)
        {
            string query = "SELECT * FROM " + Tabelle + " WHERE Vorname LIKE '%" + suchwort + "%' OR Nachname LIKE '%" + suchwort + "%'";

            //Create a list to store the result
            BindingList<Kunde> list = new BindingList<Kunde>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                return Get_Query_Kunden(query, list);
            }
            else
            {
                return list;
            }
        }

        private BindingList<Kunde> Get_Query_Kunden(string query, BindingList<Kunde> list)
        {
            //Create Command
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Kunde kunde = new Kunde(Convert.ToInt32(dataReader["KundenID"]), Convert.ToString(dataReader["Vorname"]), Convert.ToString(dataReader["Nachname"]), Convert.ToString(dataReader["Strasse"]), Convert.ToString(dataReader["PLZ"]));
                    list.Add(kunde);
                }

                //close Data Reader
                dataReader.Close();
            }

            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return list;
        }

        public List<string> Select_Ort(string Tabelle)
        {
            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + Tabelle, connection))
                {
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list.Add(dataReader["PLZ"] + " " + dataReader["Ort"]);
                    }

                    //close Data Reader
                    dataReader.Close();
                }

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1042:
                        MessageBox.Show("Fehler in der Verbindung!");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public BindingList<Artikel> Select_Artikel(string Tabelle)
        {
            string query = "SELECT * FROM " + Tabelle;

            //Create a list to store the result
            BindingList<Artikel> list = new BindingList<Artikel>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        Artikel Artikel = new Artikel(Convert.ToInt32(dataReader["ArtikelID"]), Convert.ToString(dataReader["Bezeichnung"]), Convert.ToDouble(dataReader["Preis"]));
                        list.Add(Artikel);
                    }

                    //close Data Reader
                    dataReader.Close();
                }

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public BindingList<Artikel> Select_Artikel(string suchwort, string Tabelle)
        {
            string query = "SELECT * FROM " + Tabelle + " WHERE Bezeichnung LIKE '%" + suchwort + "%'";

            //Create a list to store the result
            BindingList<Artikel> list = new BindingList<Artikel>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        Artikel Artikel = new Artikel(Convert.ToInt32(dataReader["ArtikelID"]), Convert.ToString(dataReader["Bezeichnung"]), Convert.ToDouble(dataReader["Preis"]));
                        list.Add(Artikel);
                    }

                    //close Data Reader
                    dataReader.Close();
                }

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public void Update_Artikel(string pbezeichnung, double preis, int id)
        {
            string query = "UPDATE `artikel` SET `Bezeichnung` = '" + pbezeichnung + "', `Preis` = '" + preis + "' WHERE `artikel`.`ArtikelID` = " + id;
            Insert_Query(query);
        }
    }
}