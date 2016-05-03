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
    public partial class Form_Anlagenverzeichnis : Form
    {
       
        public Form_Anlagenverzeichnis()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();

        private void Form_Anlagenverzeichnis_Load(object sender, EventArgs e)
        {
            Daten_laden();
        }
        private void Daten_laden()
        {
            dataGridView_Anlagenverzeichnis.DataSource = verzeichnis();
        }
        private DataTable verzeichnis()
        {
            string connectionstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Paul\Desktop\EingabeAusgabe\EA_Datenbank.mdb;Persist Security Info=False;";
           
            using (OleDbConnection con = new OleDbConnection(connectionstring))
            {
                using (OleDbCommand command = new OleDbCommand("select * from Anlagenverzeichnis", con))
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
            textBox7.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filter("Gegenstand",textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Filter("Anschaffungsdatum", textBox2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Filter("Anschaffungswert", textBox3);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Filter("Bilanzwertperersten", textBox4);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Filter("Dauer", textBox5);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Filter("Wert", textBox6);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Filter("Buchwertperersten", textBox7);
        }
    }
}
