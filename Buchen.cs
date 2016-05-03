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
        private void TextBox_Turnover_tax_TextChanged(object sender, EventArgs e)
        {
            #region
            //TextBox_Umsatzsteuer.SelectAll();
            //if (TextBox_Umsatzsteuer.SelectionLength > 0)
            //{
            //    TextBox_Vorsteuer.Enabled = false;
            //}
            //else
            //{
            //    TextBox_Vorsteuer.Enabled = true;
            //}

            //TextBox_Umsatzsteuer.SelectionStart = TextBox_Umsatzsteuer.SelectionLength;
            //This SelectAll()-Method is necessary, because Selection.Length doesn't work until there is something selected
            //TextBox_Turnover_tax.SelectionStart=0; - would also work 
            #endregion
            if (TextBox_Umsatzsteuer.Text != string.Empty)
            {
                TextBox_Vorsteuer.Enabled = false;
            }
            else
            {
                TextBox_Vorsteuer.Enabled = true;
            }

            if (TextBox_Umsatzsteuer.Text != string.Empty)
            {
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }
        private void TextBox_Input_tax_TextChanged(object sender, EventArgs e)
        {
            #region 
            //TextBox_Vorsteuer.SelectAll();
            //if (TextBox_Vorsteuer.SelectionLength > 0)
            //{
            //    TextBox_Umsatzsteuer.Enabled = false;
            //}
            //else
            //{
            //    TextBox_Umsatzsteuer.Enabled = true;
            //}

            //TextBox_Vorsteuer.SelectionStart = TextBox_Vorsteuer.SelectionLength;
            //This SelectAll()-Method is necessary, because Selection.Length doesn't work until there is something selected
            //TextBox_Input_tax.SelectionStart=0; - would also work 
            #endregion
            if (TextBox_Vorsteuer.Text != string.Empty)
            {
                TextBox_Umsatzsteuer.Enabled = false;
            }
            else
            {
                TextBox_Umsatzsteuer.Enabled = true;
            }
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
            string cmdString = "";
            if (TextBox_Umsatzsteuer.Text == string.Empty)
            {
                cmdString = "INSERT INTO Buchungen (Belegnr, Rechnungsdatum, Eingangsdatum, Buchungstext, Wert, Steuer, GruppenID, Art) VALUES ('" + TextBox_Belegnummer.Text + "','" + DateTimePicker_Rechnungsdatum.Value + "','" + DateTimePicker_Date_of_receipt.Value + "','" + TextBox_Note.Text + "','" + TextBox_Betrag.Text + "','" + TextBox_Vorsteuer.Text + "','" + textBox1.Text + "','"+ "Ausgabe"+"')";
            }
            else
            {
                cmdString = "INSERT INTO Buchungen (Belegnr, Rechnungsdatum, Eingangsdatum, Buchungstext, Wert, Steuer, Art) VALUES ('" + TextBox_Belegnummer.Text + "','" + DateTimePicker_Rechnungsdatum.Value + "','" + DateTimePicker_Date_of_receipt.Value + "','" + TextBox_Note.Text + "','" + TextBox_Betrag.Text + "','" + TextBox_Umsatzsteuer.Text + "','"+"Einnahme"+"')";
            }

            using (OleDbConnection con = new OleDbConnection(connectionstring))
            {
                using (OleDbCommand cmd = new OleDbCommand(cmdString, con))
                {
                    con.Open();
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
                    textBox1.Clear();
                    TextBox_Belegnummer.Clear();
                    TextBox_Betrag.Clear();
                    TextBox_Note.Clear();
                    TextBox_Umsatzsteuer.Clear();
                    TextBox_Vorsteuer.Clear();
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
            if (TextBox_Umsatzsteuer.Text.Trim() == string.Empty)
            {
                if (TextBox_Vorsteuer.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Umsatz- bzw. Vorsteuer muss vorhanden sein", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBox_Umsatzsteuer.Focus();
                    return false;
                }
            }
            if (TextBox_Vorsteuer.Text.Trim() != string.Empty)
            {
                if (textBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Da es sich um eine Ausgangsrechung handelt muss eine GruppenID vorliegen! Bei Fragen klicken Sie bitte auf Gruppen Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
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
        #endregion
    }
}
