namespace test
{
    partial class Form_Buchungsübersicht
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
            this.dataGridView_Buchungsübersicht = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buchungTätigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zurücksetzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualisierenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_GruppenID = new System.Windows.Forms.Label();
            this.Textbox_GruppenID = new System.Windows.Forms.TextBox();
            this.TextBox_Buchungstext = new System.Windows.Forms.TextBox();
            this.Label_Buchungstext = new System.Windows.Forms.Label();
            this.Label_Wert = new System.Windows.Forms.Label();
            this.TextBox_Wert = new System.Windows.Forms.TextBox();
            this.Label_belegnummer = new System.Windows.Forms.Label();
            this.Label_Rechnungsdatum = new System.Windows.Forms.Label();
            this.Label_Eingangsdatum = new System.Windows.Forms.Label();
            this.Label_USt = new System.Windows.Forms.Label();
            this.Label_Einnahme_Ausgabe = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Buchungsübersicht)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Buchungsübersicht
            // 
            this.dataGridView_Buchungsübersicht.AllowUserToAddRows = false;
            this.dataGridView_Buchungsübersicht.AllowUserToDeleteRows = false;
            this.dataGridView_Buchungsübersicht.AllowUserToOrderColumns = true;
            this.dataGridView_Buchungsübersicht.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Buchungsübersicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Buchungsübersicht.Location = new System.Drawing.Point(12, 269);
            this.dataGridView_Buchungsübersicht.MultiSelect = false;
            this.dataGridView_Buchungsübersicht.Name = "dataGridView_Buchungsübersicht";
            this.dataGridView_Buchungsübersicht.ReadOnly = true;
            this.dataGridView_Buchungsübersicht.RowTemplate.Height = 24;
            this.dataGridView_Buchungsübersicht.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Buchungsübersicht.Size = new System.Drawing.Size(1433, 229);
            this.dataGridView_Buchungsübersicht.TabIndex = 0;
            this.dataGridView_Buchungsübersicht.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Buchungsübersicht_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schließenToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.buchungTätigenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zurücksetzenToolStripMenuItem,
            this.aktualisierenToolStripMenuItem,
            this.aktualisierenToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.löschenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1457, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(25, 24);
            this.resetToolStripMenuItem.Text = "|";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // buchungTätigenToolStripMenuItem
            // 
            this.buchungTätigenToolStripMenuItem.Name = "buchungTätigenToolStripMenuItem";
            this.buchungTätigenToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.buchungTätigenToolStripMenuItem.Text = "Buchung tätigen";
            this.buchungTätigenToolStripMenuItem.Click += new System.EventHandler(this.buchungTätigenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // zurücksetzenToolStripMenuItem
            // 
            this.zurücksetzenToolStripMenuItem.Name = "zurücksetzenToolStripMenuItem";
            this.zurücksetzenToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.zurücksetzenToolStripMenuItem.Text = "Zurücksetzen";
            this.zurücksetzenToolStripMenuItem.Click += new System.EventHandler(this.zurücksetzenToolStripMenuItem_Click);
            // 
            // aktualisierenToolStripMenuItem
            // 
            this.aktualisierenToolStripMenuItem.Name = "aktualisierenToolStripMenuItem";
            this.aktualisierenToolStripMenuItem.Size = new System.Drawing.Size(25, 24);
            this.aktualisierenToolStripMenuItem.Text = "|";
            // 
            // aktualisierenToolStripMenuItem1
            // 
            this.aktualisierenToolStripMenuItem1.Name = "aktualisierenToolStripMenuItem1";
            this.aktualisierenToolStripMenuItem1.Size = new System.Drawing.Size(106, 24);
            this.aktualisierenToolStripMenuItem1.Text = "Aktualisieren";
            this.aktualisierenToolStripMenuItem1.Click += new System.EventHandler(this.aktualisierenToolStripMenuItem1_Click);
            // 
            // Label_GruppenID
            // 
            this.Label_GruppenID.AutoSize = true;
            this.Label_GruppenID.Location = new System.Drawing.Point(671, 148);
            this.Label_GruppenID.Name = "Label_GruppenID";
            this.Label_GruppenID.Size = new System.Drawing.Size(81, 17);
            this.Label_GruppenID.TabIndex = 2;
            this.Label_GruppenID.Text = "GruppenID:";
            // 
            // Textbox_GruppenID
            // 
            this.Textbox_GruppenID.Location = new System.Drawing.Point(758, 143);
            this.Textbox_GruppenID.Name = "Textbox_GruppenID";
            this.Textbox_GruppenID.Size = new System.Drawing.Size(182, 22);
            this.Textbox_GruppenID.TabIndex = 3;
            this.Textbox_GruppenID.TextChanged += new System.EventHandler(this.Textbox_GruppenID_TextChanged);
            // 
            // TextBox_Buchungstext
            // 
            this.TextBox_Buchungstext.Location = new System.Drawing.Point(375, 185);
            this.TextBox_Buchungstext.Name = "TextBox_Buchungstext";
            this.TextBox_Buchungstext.Size = new System.Drawing.Size(182, 22);
            this.TextBox_Buchungstext.TabIndex = 5;
            this.TextBox_Buchungstext.TextChanged += new System.EventHandler(this.TextBox_Buchungstext_TextChanged);
            // 
            // Label_Buchungstext
            // 
            this.Label_Buchungstext.AutoSize = true;
            this.Label_Buchungstext.Location = new System.Drawing.Point(272, 190);
            this.Label_Buchungstext.Name = "Label_Buchungstext";
            this.Label_Buchungstext.Size = new System.Drawing.Size(97, 17);
            this.Label_Buchungstext.TabIndex = 4;
            this.Label_Buchungstext.Text = "Buchungstext:";
            this.Label_Buchungstext.Click += new System.EventHandler(this.Label_Buchungstext_Click);
            // 
            // Label_Wert
            // 
            this.Label_Wert.AutoSize = true;
            this.Label_Wert.Location = new System.Drawing.Point(710, 62);
            this.Label_Wert.Name = "Label_Wert";
            this.Label_Wert.Size = new System.Drawing.Size(42, 17);
            this.Label_Wert.TabIndex = 6;
            this.Label_Wert.Text = "Wert:";
            // 
            // TextBox_Wert
            // 
            this.TextBox_Wert.Location = new System.Drawing.Point(758, 59);
            this.TextBox_Wert.Name = "TextBox_Wert";
            this.TextBox_Wert.Size = new System.Drawing.Size(182, 22);
            this.TextBox_Wert.TabIndex = 9;
            this.TextBox_Wert.TextChanged += new System.EventHandler(this.TextBox_Wert_TextChanged);
            // 
            // Label_belegnummer
            // 
            this.Label_belegnummer.AutoSize = true;
            this.Label_belegnummer.Location = new System.Drawing.Point(270, 62);
            this.Label_belegnummer.Name = "Label_belegnummer";
            this.Label_belegnummer.Size = new System.Drawing.Size(99, 17);
            this.Label_belegnummer.TabIndex = 10;
            this.Label_belegnummer.Text = "Belegnummer:";
            // 
            // Label_Rechnungsdatum
            // 
            this.Label_Rechnungsdatum.AutoSize = true;
            this.Label_Rechnungsdatum.Location = new System.Drawing.Point(246, 106);
            this.Label_Rechnungsdatum.Name = "Label_Rechnungsdatum";
            this.Label_Rechnungsdatum.Size = new System.Drawing.Size(123, 17);
            this.Label_Rechnungsdatum.TabIndex = 11;
            this.Label_Rechnungsdatum.Text = "Rechnungsdatum:";
            // 
            // Label_Eingangsdatum
            // 
            this.Label_Eingangsdatum.AutoSize = true;
            this.Label_Eingangsdatum.Location = new System.Drawing.Point(259, 148);
            this.Label_Eingangsdatum.Name = "Label_Eingangsdatum";
            this.Label_Eingangsdatum.Size = new System.Drawing.Size(110, 17);
            this.Label_Eingangsdatum.TabIndex = 12;
            this.Label_Eingangsdatum.Text = "Eingangsdatum:";
            this.Label_Eingangsdatum.Click += new System.EventHandler(this.Label_Eingangsdatum_Click);
            // 
            // Label_USt
            // 
            this.Label_USt.AutoSize = true;
            this.Label_USt.Location = new System.Drawing.Point(659, 108);
            this.Label_USt.Name = "Label_USt";
            this.Label_USt.Size = new System.Drawing.Size(93, 17);
            this.Label_USt.TabIndex = 13;
            this.Label_USt.Text = "USt bzw. VSt:";
            // 
            // Label_Einnahme_Ausgabe
            // 
            this.Label_Einnahme_Ausgabe.AutoSize = true;
            this.Label_Einnahme_Ausgabe.Location = new System.Drawing.Point(617, 190);
            this.Label_Einnahme_Ausgabe.Name = "Label_Einnahme_Ausgabe";
            this.Label_Einnahme_Ausgabe.Size = new System.Drawing.Size(135, 17);
            this.Label_Einnahme_Ausgabe.TabIndex = 14;
            this.Label_Einnahme_Ausgabe.Text = "Einnahme/Ausgabe:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(758, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 22);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(758, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 22);
            this.textBox3.TabIndex = 17;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(375, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(182, 22);
            this.textBox4.TabIndex = 18;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(375, 101);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 22);
            this.textBox5.TabIndex = 19;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem2.Text = "|";
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // Form_Buchungsübersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 510);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label_Einnahme_Ausgabe);
            this.Controls.Add(this.Label_USt);
            this.Controls.Add(this.Label_Eingangsdatum);
            this.Controls.Add(this.Label_Rechnungsdatum);
            this.Controls.Add(this.Label_belegnummer);
            this.Controls.Add(this.TextBox_Wert);
            this.Controls.Add(this.Label_Wert);
            this.Controls.Add(this.TextBox_Buchungstext);
            this.Controls.Add(this.Label_Buchungstext);
            this.Controls.Add(this.Textbox_GruppenID);
            this.Controls.Add(this.Label_GruppenID);
            this.Controls.Add(this.dataGridView_Buchungsübersicht);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Buchungsübersicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buchungsübersicht";
            this.Load += new System.EventHandler(this.Form_Buchungsübersicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Buchungsübersicht)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Buchungsübersicht;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label Label_GruppenID;
        private System.Windows.Forms.TextBox Textbox_GruppenID;
        private System.Windows.Forms.TextBox TextBox_Buchungstext;
        private System.Windows.Forms.Label Label_Buchungstext;
        private System.Windows.Forms.Label Label_Wert;
        private System.Windows.Forms.TextBox TextBox_Wert;
        private System.Windows.Forms.Label Label_belegnummer;
        private System.Windows.Forms.Label Label_Rechnungsdatum;
        private System.Windows.Forms.Label Label_Eingangsdatum;
        private System.Windows.Forms.Label Label_USt;
        private System.Windows.Forms.Label Label_Einnahme_Ausgabe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ToolStripMenuItem buchungTätigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zurücksetzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktualisierenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
    }
}