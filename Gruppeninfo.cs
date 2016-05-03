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
    public partial class Gruppeninfo : Form
    {
        public Gruppeninfo()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();
        private void Daten_laden()
        {
            dataGridView1.DataSource = übersichtList();
        }
        private DataTable übersichtList()
        {
            string connectionstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Paul\Desktop\EingabeAusgabe\EA_Datenbank.mdb;Persist Security Info=False;";
            using (OleDbConnection con = new OleDbConnection(connectionstring))
            {
                using (OleDbCommand command = new OleDbCommand("select * from Gruppen", con))
                {
                    con.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                    con.Close();
                }
            }
            return dt;
        }
        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
        private void Gruppeninfo_Load(object sender, EventArgs e)
        {
            Daten_laden();
        }
    }
}
