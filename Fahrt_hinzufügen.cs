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
    public partial class Fahrt_hinzufügen : Form
    {
        private bool IsValidated()
        {
            if (textBox_Fahrstrecke.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Fahrstrecke muss vorhanden sein", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Fahrstrecke.Focus();
                return false;
            }
            if (textBox_Zweck.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Zweck muss angegeben werden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Zweck.Focus();
                return false;
            }
            if (textBox_Anfangskilometer.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anfangskilometer müssen angegeben werden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Anfangskilometer.Focus();
                return false;
            }
            if (textBox_Endkilometer.Text.Trim() == string.Empty)
            {
                
                    MessageBox.Show("Endkilometer müssen angegeben werden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Endkilometer.Focus();
                    return false;               
            }
           
            
            return true;
        }
        public Fahrt_hinzufügen()
        {
            InitializeComponent();
        }
       
        private void Fahrt_hinzufügen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                try
                {
                    SafeRecord();
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
        }
        private void SafeRecord()
        {
            string connectionstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Moritz\Documents\Schule\Programmieren\EingabeAusgabe\EA_Datenbank.mdb;Persist Security Info=False;";
            string cmdString = "";
            
            cmdString = "INSERT INTO Fahrtenbuch (Datum, Fahrstrecke, Zweck, Anfangskilometer, Endkilometer, Gefahrenekilometer) VALUES ('"+ DateTimePicker_Datum.Value + "','" + textBox_Fahrstrecke.Text + "','" + textBox_Zweck.Text + "','" + textBox_Anfangskilometer.Text + "','" + textBox_Endkilometer.Text + "','" + (int.Parse(textBox_Endkilometer.Text)-int.Parse(textBox_Anfangskilometer.Text)) + "')";
            

            using (OleDbConnection con = new OleDbConnection(connectionstring))
            {
                using (OleDbCommand cmd = new OleDbCommand(cmdString, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
