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
    public partial class Form_Buchungsübersicht : Form
    {
        #region
        Form_Buchung_tätigen tätigen;
        #endregion
        public Form_Buchungsübersicht()
        {
            tätigen = new Form_Buchung_tätigen();
            InitializeComponent();
        }
        private DataTable dt = new DataTable();
        private void Form_Buchungsübersicht_Load(object sender, EventArgs e)
        {
            Daten_laden();
        }
        private void Daten_laden()
        {
            dataGridView_Buchungsübersicht.DataSource = übersichtList();
        }
        private DataTable übersichtList()
        {
            string connectionstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Paul\Desktop\EingabeAusgabe\EA_Datenbank.mdb;Persist Security Info=False;";
            using (OleDbConnection con = new OleDbConnection(connectionstring))
            {
                //
                using (OleDbCommand command = new OleDbCommand("select * from Buchungen", con))
                {
                    con.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }
        private void Textbox_GruppenID_TextChanged(object sender, EventArgs e)
        {
            Filter("GruppenID", Textbox_GruppenID);
        }

        private void TextBox_Buchungstext_TextChanged(object sender, EventArgs e)
        {
            Filter("Buchungstext", TextBox_Buchungstext);
        }

        private void TextBox_Wert_TextChanged(object sender, EventArgs e)
        {
            Filter("Wert", TextBox_Wert);
        }
        private void Filter(string columnName, TextBox txtbox)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = columnName + "+ '' LIKE '%" + txtbox.Text + "%'";
            //'' = Convert.ToString 
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Filter("Steuer", textBox3);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filter("Belegnr", textBox1);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Filter("Rechnungsdatum", textBox5);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Filter("Eingangsdatum", textBox4);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Filter("Art", textBox2);
        }
        private void zurücksetzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Textbox_GruppenID.Clear();
            TextBox_Buchungstext.Clear();
            TextBox_Wert.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void buchungTätigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tätigen.ShowDialog();
        }
        #region
        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Label_Buchungstext_Click(object sender, EventArgs e)
        {

        }
        private void Label_Eingangsdatum_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView_Buchungsübersicht_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        private void aktualisierenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView_Buchungsübersicht.DataSource).Rows.Clear();
            Daten_laden();

        }
        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Paul\Desktop\EingabeAusgabe\EA_Datenbank.mdb;Persist Security Info=False;";
                OleDbConnection con = new OleDbConnection(connectionstring);
                con.Open();
                string query = "delete from Buchungen where Belegnr= '"+textBox1.Text +"'";
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Buchung wurde gelöscht","Erfolgreich",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }
    }
}
