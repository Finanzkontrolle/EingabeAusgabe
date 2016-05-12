using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace test
{
    public partial class LoginBildschirm : Form
    {

        Form_Buchhaltung Buchhaltung;
        private OleDbConnection con = new OleDbConnection();
        public LoginBildschirm()
        {
            InitializeComponent();
            Buchhaltung = new Form_Buchhaltung();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Paul\Desktop\EingabeAusgabe\EA_Datenbank.mdb;Persist Security Info=False;";
        }
        private void LoginBildschirm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Label_Connection_Status.Text = "Connection Successful";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
       public bool anmeldung;
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = "select * from Login where Benutzername='" + TextBox_Benutzername.Text + "' and Passwort='" + TextBox_Passwort.Text + "'";

            OleDbCommand command2 = new OleDbCommand();
            command.Connection = con;
            string cmdgetRechte = "select Rechte from Login where Benutzername='" + TextBox_Benutzername.Text + "' and Passwort='" + TextBox_Passwort.Text + "'";
          
            using (OleDbCommand cmd = new OleDbCommand(cmdgetRechte, con))
            {
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                anmeldung = Convert.ToBoolean(dt.Rows[0][0]);
                if (anmeldung == true)
                {
                    MessageBox.Show("Administrator");
                }
                else
                {
                    MessageBox.Show("User");
                }
            }   

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                MessageBox.Show("Benutzername und Passwort waren korrekt");
                con.Close();
                Hide();
                Buchhaltung.ShowDialog();
            }
            else
            if (count > 1)
            {
                MessageBox.Show("Benutzername und Passwort sind mehr als einmal vorhanden. Somit ist keine eindeutige Zuweisung möglich");
                TextBox_Passwort.Clear();
            }
            else
            {
                MessageBox.Show("Benutzername bzw. Passwort ist inkorrekt");
                TextBox_Passwort.Clear();
            }
            con.Close();
        }
        private void Button_Verlassen_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TextBox_Passwort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
