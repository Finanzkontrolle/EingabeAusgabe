using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Data.OleDb;
using System.Diagnostics;

namespace test
{
    public partial class Form_Buchung_tätigen : Form
    {
        Gruppeninfo info;
        public Form_Buchung_tätigen()
        {
            InitializeComponent();
            info = new Gruppeninfo();
        }
        private void Button_Send_Click(object sender, EventArgs e)
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
        }
        private void SafeRecord()
        {
            string connectionstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Paul\Desktop\EingabeAusgabe\EA_Datenbank.mdb;Persist Security Info=False;";
            using (OleDbConnection con = new OleDbConnection(connectionstring))
            {
                con.Open();
                string cmdString = "";
                string cmdgetsteuersatz = "SELECT Steuersatz FROM Gruppen where Bezeichnung = '"+comboBox1.Text+"'";
                double steuersatz;
                int gruppenid;
                using (OleDbCommand cmd = new OleDbCommand(cmdgetsteuersatz, con))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    steuersatz =Convert.ToDouble(dt.Rows[0][0]);
                }
                using (OleDbCommand cmd = new OleDbCommand("SELECT GruppenID FROM Gruppen where Bezeichnung = '" + comboBox1.Text + "'", con))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    gruppenid= Convert.ToInt32(dt.Rows[0][0]);
                }
                // SELECT Gruppen.Steuersatz FROM Buchungen INNER JOIN Gruppen on Buchungen.GruppenID=Gruppen.GruppenID 
                if (checkBox2.Checked)
                {
                    var steuer = double.Parse(TextBox_Betrag.Text) * (steuersatz / 100);
                    cmdString = @"INSERT INTO Buchungen 
(Belegnr, Rechnungsdatum, Eingangsdatum, Buchungstext, Wert, Steuer, GruppenID, Art) 
VALUES ('" + 
TextBox_Belegnummer.Text+"','" + 
DateTimePicker_Rechnungsdatum.Value + "','" + 
DateTimePicker_Date_of_receipt.Value + "','" + 
TextBox_Note.Text + "','" + 
TextBox_Betrag.Text + "','" + 
steuer + "','" + 
gruppenid + "','" + 
"Ausgabe" + "')";

                }
                else
                {
                    cmdString = @"INSERT INTO Buchungen 
(Belegnr, Rechnungsdatum, Eingangsdatum, Buchungstext, Wert, Steuer, Art) 
VALUES ('" + 
TextBox_Belegnummer.Text + "','" + 
DateTimePicker_Rechnungsdatum.Value + "','" + 
DateTimePicker_Date_of_receipt.Value + "','" + 
TextBox_Note.Text + "','" + 
TextBox_Betrag.Text + "','" + 
20 + "','" + 
"Einnahme" + "')";
                }
                using (OleDbCommand cmd = new OleDbCommand(cmdString, con))
                {
                    #region
                    //string cmdString = "INSERT INTO Buchungen (Belegnr, Rechnungsdatum, Eingangsdatum, Buchungstext, Wert, Steuer) VALUES (@Belegnr, @Rechnungsdatum, @Eingangsdatum, @Buchungstext, @Wert, @Steuer)";

                    //cmd.Parameters.Add("@Belegnr", OleDbType.VarChar).Value=TextBox_Belegnummer.Text;

                    //cmd.Parameters.AddWithValue("@Belegnr", TextBox_Belegnummer.Text);
                    //cmd.Parameters.AddWithValue("@Rechnungsdatum", DateTimePicker_Rechnungsdatum.Value);
                    //cmd.Parameters.AddWithValue("@Eingangsdatum", DateTimePicker_Date_of_receipt.Value);
                    //cmd.Parameters.AddWithValue("@Buchungstext", TextBox_Note.Text);
                    //cmd.Parameters.AddWithValue("@Wert", TextBox_Betrag.Text);
                    //if (TextBox_Umsatzsteuer.Text == string.Empty)
                    //{
                    //    cmd.Parameters.AddWithValue("@Steuer", TextBox_Vorsteuer.Text);
                    //}
                    //else
                    //{
                    //    cmd.Parameters.AddWithValue("@Steuer", TextBox_Umsatzsteuer.Text);
                    //}
                    #endregion
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Buchung wurde getätigt.", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #region
                    TextBox_Belegnummer.Clear();
                    TextBox_Betrag.Clear();
                    TextBox_Note.Clear();
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    TextBox_Belegnummer.Focus();
                    #endregion
                }
            }
        }
        private bool IsValidated()
        {
            if (TextBox_Belegnummer.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Belegnummer muss vorhanden sein", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_Belegnummer.Focus();
                return false;
            }
            if (TextBox_Note.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Buchungstext muss vorhanden sein", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_Note.Focus();
                return false;
            }
            if (TextBox_Betrag.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Buchungsbetrag muss vorhanden sein", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_Betrag.Focus();
                return false;
            }
            if (!checkBox1.Checked)
            {
                if (!checkBox2.Checked)
                {
                    MessageBox.Show("Umsatz- bzw. Vorsteuer muss vorhanden sein", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (checkBox2.Checked)
            {
                if (comboBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Da es sich um eine Ausgangsrechung handelt muss eine Gruppe vorliegen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox1.Focus();
                    return false;
                }
            }
            return true;
        }
        private void gruppenInforrmationenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.ShowDialog();
        }
        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void DateTimePicker_RE_Date_ValueChanged(object sender, EventArgs e)
        {
        }
        private void Buchen_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void TextBox_Note_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
        }
        private void Label_Betrag_Click(object sender, EventArgs e)
        {

        }
        private void TextBox_Betrag_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        #endregion
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
                comboBox1.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                comboBox1.Enabled = true;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }
        }
    }
}
