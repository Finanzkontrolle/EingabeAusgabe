﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form_Buchhaltung : Form
    {
        #region
        Form_Buchung_tätigen tätigen;
        Form_Buchungsübersicht übersicht;
        Form_Fahrtenbuch fahrtenbuch;
        Form_Anlagenverzeichnis verzeichnis;
        #endregion
        public Form_Buchhaltung()
        {
            #region
            tätigen = new Form_Buchung_tätigen();
            übersicht = new Form_Buchungsübersicht();
            fahrtenbuch = new Form_Fahrtenbuch();
            verzeichnis = new Form_Anlagenverzeichnis();
            #endregion
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tätigen.ShowDialog();
        }
        private void Button_Buchungen_ausgeben_Click(object sender, EventArgs e)
        {
            übersicht.ShowDialog();
        }
        private void Butten_Fahrtenbuch_ausgeben_Click(object sender, EventArgs e)
        {
            fahrtenbuch.ShowDialog();
        }
        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            verzeichnis.ShowDialog();
        }
        #endregion
    }
}
