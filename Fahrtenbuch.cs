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
    public partial class Form_Fahrtenbuch : Form
    {
        Fahrt_hinzufügen hinzufügen;
        public Form_Fahrtenbuch()
        {
            hinzufügen = new Fahrt_hinzufügen();
            InitializeComponent();
        }
        private DataTable dt = new DataTable();

        private void Form_Fahrtenbuch_Load(object sender, EventArgs e)
        {
            Daten_laden();
        }
        private void Daten_laden()
        {
            dataGridView_Fahrtenbuch.DataSource = fahrtenbuch();
        }
        private DataTable fahrtenbuch()
        {
            
            string connectionstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Paul\Desktop\EingabeAusgabe\EA_Datenbank.mdb;Persist Security Info=False;";
            using (OleDbConnection con = new OleDbConnection(connectionstring))
            {
                using (OleDbCommand command = new OleDbCommand("select * from Fahrtenbuch", con))
                {
                    con.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                    con.Close();
                }
            }
            return dt;
        }
        private void Filter(string columnName, TextBox txtbox)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = columnName + "+ '' LIKE '%" + txtbox.Text + "%'";
            //'' = Convert.ToString 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zurücksetzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filter("Datum", textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Filter("Fahrstrecke", textBox2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Filter("Zweck", textBox3);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Filter("Anfangskilometer", textBox4);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Filter("Endkilometer", textBox5);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Filter("Gefahrenekilometer", textBox6);
        }

        private void fahrtHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hinzufügen.ShowDialog();
        }
    }
}
