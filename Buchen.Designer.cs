namespace test
{
    partial class Form_Buchung_tätigen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Buchung_tätigen));
            this.DateTimePicker_Date_of_receipt = new System.Windows.Forms.DateTimePicker();
            this.Label_Rechnungsdatum = new System.Windows.Forms.Label();
            this.Label_Eingangsdatum = new System.Windows.Forms.Label();
            this.DateTimePicker_Rechnungsdatum = new System.Windows.Forms.DateTimePicker();
            this.Label_Anmerkung = new System.Windows.Forms.Label();
            this.TextBox_Note = new System.Windows.Forms.TextBox();
            this.Button_Senden = new System.Windows.Forms.Button();
            this.Label_Betrag = new System.Windows.Forms.Label();
            this.TextBox_Betrag = new System.Windows.Forms.TextBox();
            this.TextBox_Belegnummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Belegnummer = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gruppenInforrmationenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTimePicker_Date_of_receipt
            // 
            this.DateTimePicker_Date_of_receipt.Location = new System.Drawing.Point(128, 164);
            this.DateTimePicker_Date_of_receipt.Name = "DateTimePicker_Date_of_receipt";
            this.DateTimePicker_Date_of_receipt.Size = new System.Drawing.Size(241, 22);
            this.DateTimePicker_Date_of_receipt.TabIndex = 2;
            // 
            // Label_Rechnungsdatum
            // 
            this.Label_Rechnungsdatum.AutoSize = true;
            this.Label_Rechnungsdatum.Location = new System.Drawing.Point(12, 112);
            this.Label_Rechnungsdatum.Name = "Label_Rechnungsdatum";
            this.Label_Rechnungsdatum.Size = new System.Drawing.Size(123, 17);
            this.Label_Rechnungsdatum.TabIndex = 3;
            this.Label_Rechnungsdatum.Text = "Rechnungsdatum:";
            this.Label_Rechnungsdatum.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_Eingangsdatum
            // 
            this.Label_Eingangsdatum.AutoSize = true;
            this.Label_Eingangsdatum.Location = new System.Drawing.Point(12, 164);
            this.Label_Eingangsdatum.Name = "Label_Eingangsdatum";
            this.Label_Eingangsdatum.Size = new System.Drawing.Size(110, 17);
            this.Label_Eingangsdatum.TabIndex = 4;
            this.Label_Eingangsdatum.Text = "Eingangsdatum:";
            this.Label_Eingangsdatum.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateTimePicker_Rechnungsdatum
            // 
            this.DateTimePicker_Rechnungsdatum.Location = new System.Drawing.Point(137, 112);
            this.DateTimePicker_Rechnungsdatum.Name = "DateTimePicker_Rechnungsdatum";
            this.DateTimePicker_Rechnungsdatum.Size = new System.Drawing.Size(252, 22);
            this.DateTimePicker_Rechnungsdatum.TabIndex = 1;
            this.DateTimePicker_Rechnungsdatum.ValueChanged += new System.EventHandler(this.DateTimePicker_RE_Date_ValueChanged);
            // 
            // Label_Anmerkung
            // 
            this.Label_Anmerkung.AutoSize = true;
            this.Label_Anmerkung.Location = new System.Drawing.Point(12, 213);
            this.Label_Anmerkung.Name = "Label_Anmerkung";
            this.Label_Anmerkung.Size = new System.Drawing.Size(84, 17);
            this.Label_Anmerkung.TabIndex = 6;
            this.Label_Anmerkung.Text = "Anmerkung:";
            this.Label_Anmerkung.Click += new System.EventHandler(this.label3_Click);
            // 
            // TextBox_Note
            // 
            this.TextBox_Note.Location = new System.Drawing.Point(102, 213);
            this.TextBox_Note.Multiline = true;
            this.TextBox_Note.Name = "TextBox_Note";
            this.TextBox_Note.Size = new System.Drawing.Size(276, 22);
            this.TextBox_Note.TabIndex = 3;
            this.TextBox_Note.TextChanged += new System.EventHandler(this.TextBox_Note_TextChanged);
            // 
            // Button_Senden
            // 
            this.Button_Senden.Location = new System.Drawing.Point(562, 326);
            this.Button_Senden.Name = "Button_Senden";
            this.Button_Senden.Size = new System.Drawing.Size(117, 62);
            this.Button_Senden.TabIndex = 7;
            this.Button_Senden.Text = "Senden";
            this.Button_Senden.UseVisualStyleBackColor = true;
            this.Button_Senden.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Label_Betrag
            // 
            this.Label_Betrag.AutoSize = true;
            this.Label_Betrag.Location = new System.Drawing.Point(12, 262);
            this.Label_Betrag.Name = "Label_Betrag";
            this.Label_Betrag.Size = new System.Drawing.Size(54, 17);
            this.Label_Betrag.TabIndex = 9;
            this.Label_Betrag.Text = "Betrag:";
            this.Label_Betrag.Click += new System.EventHandler(this.Label_Betrag_Click);
            // 
            // TextBox_Betrag
            // 
            this.TextBox_Betrag.Location = new System.Drawing.Point(72, 262);
            this.TextBox_Betrag.Name = "TextBox_Betrag";
            this.TextBox_Betrag.Size = new System.Drawing.Size(163, 22);
            this.TextBox_Betrag.TabIndex = 4;
            this.TextBox_Betrag.TextChanged += new System.EventHandler(this.TextBox_Betrag_TextChanged);
            // 
            // TextBox_Belegnummer
            // 
            this.TextBox_Belegnummer.Location = new System.Drawing.Point(117, 66);
            this.TextBox_Belegnummer.Name = "TextBox_Belegnummer";
            this.TextBox_Belegnummer.Size = new System.Drawing.Size(173, 22);
            this.TextBox_Belegnummer.TabIndex = 0;
            this.TextBox_Belegnummer.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gruppen:";
            // 
            // Label_Belegnummer
            // 
            this.Label_Belegnummer.AutoSize = true;
            this.Label_Belegnummer.Location = new System.Drawing.Point(12, 66);
            this.Label_Belegnummer.Name = "Label_Belegnummer";
            this.Label_Belegnummer.Size = new System.Drawing.Size(99, 17);
            this.Label_Belegnummer.TabIndex = 11;
            this.Label_Belegnummer.Text = "Belegnummer:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schließenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.gruppenInforrmationenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // gruppenInforrmationenToolStripMenuItem
            // 
            this.gruppenInforrmationenToolStripMenuItem.Name = "gruppenInforrmationenToolStripMenuItem";
            this.gruppenInforrmationenToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.gruppenInforrmationenToolStripMenuItem.Text = "Gruppen Information";
            this.gruppenInforrmationenToolStripMenuItem.Click += new System.EventHandler(this.gruppenInforrmationenToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(562, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 21);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Umsatzsteuer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(562, 89);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 21);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Vorsteuer";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fachliteratur",
            "Büromaterial",
            "geringw. Wirtschaftsg.",
            "Werbeaufwand",
            "Rechtsberatung",
            "Telefon(Betriebsanteil)",
            "Ust an FA",
            "SV der gewerb. Wirtschaft",
            "Postgebühren",
            "Div. öffentl. Ausgaben",
            "Spesen des Geldverkehrs"});
            this.comboBox1.Location = new System.Drawing.Point(396, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 24);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form_Buchung_tätigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 400);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Belegnummer);
            this.Controls.Add(this.Label_Belegnummer);
            this.Controls.Add(this.TextBox_Betrag);
            this.Controls.Add(this.Label_Betrag);
            this.Controls.Add(this.Button_Senden);
            this.Controls.Add(this.TextBox_Note);
            this.Controls.Add(this.Label_Anmerkung);
            this.Controls.Add(this.DateTimePicker_Rechnungsdatum);
            this.Controls.Add(this.Label_Eingangsdatum);
            this.Controls.Add(this.Label_Rechnungsdatum);
            this.Controls.Add(this.DateTimePicker_Date_of_receipt);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Buchung_tätigen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buchung tätigen";
            this.Load += new System.EventHandler(this.Buchen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateTimePicker_Date_of_receipt;
        private System.Windows.Forms.Label Label_Rechnungsdatum;
        private System.Windows.Forms.Label Label_Eingangsdatum;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Rechnungsdatum;
        private System.Windows.Forms.Label Label_Anmerkung;
        private System.Windows.Forms.TextBox TextBox_Note;
        private System.Windows.Forms.Button Button_Senden;
        private System.Windows.Forms.Label Label_Betrag;
        private System.Windows.Forms.TextBox TextBox_Betrag;
        private System.Windows.Forms.TextBox TextBox_Belegnummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Belegnummer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gruppenInforrmationenToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}