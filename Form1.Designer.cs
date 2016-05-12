namespace test
{
    partial class Form_Buchhaltung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Buchhaltung));
            this.Button_Buchung_tätigen = new System.Windows.Forms.Button();
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung = new System.Windows.Forms.Button();
            this.Button_Anlagenverzeichnis_ausgeben = new System.Windows.Forms.Button();
            this.Butten_Fahrtenbuch_ausgeben = new System.Windows.Forms.Button();
            this.Button_Buchungsübersicht_ausgeben = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Buchung_tätigen
            // 
            this.Button_Buchung_tätigen.Location = new System.Drawing.Point(430, 397);
            this.Button_Buchung_tätigen.Name = "Button_Buchung_tätigen";
            this.Button_Buchung_tätigen.Size = new System.Drawing.Size(126, 63);
            this.Button_Buchung_tätigen.TabIndex = 0;
            this.Button_Buchung_tätigen.Text = "Buchung tätigen";
            this.Button_Buchung_tätigen.UseVisualStyleBackColor = true;
            this.Button_Buchung_tätigen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_Einnahmen_bzw_Ausgaben_Rechnung
            // 
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.Location = new System.Drawing.Point(430, 466);
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.Name = "Button_Einnahmen_bzw_Ausgaben_Rechnung";
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.Size = new System.Drawing.Size(126, 63);
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.TabIndex = 1;
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.Text = "Einnahmen bzw. Ausgaben Rechnung ";
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.UseVisualStyleBackColor = true;
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button_Anlagenverzeichnis_ausgeben
            // 
            this.Button_Anlagenverzeichnis_ausgeben.Location = new System.Drawing.Point(12, 199);
            this.Button_Anlagenverzeichnis_ausgeben.Name = "Button_Anlagenverzeichnis_ausgeben";
            this.Button_Anlagenverzeichnis_ausgeben.Size = new System.Drawing.Size(144, 63);
            this.Button_Anlagenverzeichnis_ausgeben.TabIndex = 4;
            this.Button_Anlagenverzeichnis_ausgeben.Text = "Anlagenverzeichnis";
            this.Button_Anlagenverzeichnis_ausgeben.UseVisualStyleBackColor = true;
            this.Button_Anlagenverzeichnis_ausgeben.Click += new System.EventHandler(this.button3_Click);
            // 
            // Butten_Fahrtenbuch_ausgeben
            // 
            this.Butten_Fahrtenbuch_ausgeben.Location = new System.Drawing.Point(12, 130);
            this.Butten_Fahrtenbuch_ausgeben.Name = "Butten_Fahrtenbuch_ausgeben";
            this.Butten_Fahrtenbuch_ausgeben.Size = new System.Drawing.Size(144, 63);
            this.Butten_Fahrtenbuch_ausgeben.TabIndex = 3;
            this.Butten_Fahrtenbuch_ausgeben.Text = "Fahrtenbuch ";
            this.Butten_Fahrtenbuch_ausgeben.UseVisualStyleBackColor = true;
            this.Butten_Fahrtenbuch_ausgeben.Click += new System.EventHandler(this.Butten_Fahrtenbuch_ausgeben_Click);
            // 
            // Button_Buchungsübersicht_ausgeben
            // 
            this.Button_Buchungsübersicht_ausgeben.Location = new System.Drawing.Point(12, 61);
            this.Button_Buchungsübersicht_ausgeben.Name = "Button_Buchungsübersicht_ausgeben";
            this.Button_Buchungsübersicht_ausgeben.Size = new System.Drawing.Size(144, 63);
            this.Button_Buchungsübersicht_ausgeben.TabIndex = 2;
            this.Button_Buchungsübersicht_ausgeben.Text = "Buchen";
            this.Button_Buchungsübersicht_ausgeben.UseVisualStyleBackColor = true;
            this.Button_Buchungsübersicht_ausgeben.Click += new System.EventHandler(this.Button_Buchungen_ausgeben_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schließenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // Form_Buchhaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 541);
            this.Controls.Add(this.Button_Buchungsübersicht_ausgeben);
            this.Controls.Add(this.Butten_Fahrtenbuch_ausgeben);
            this.Controls.Add(this.Button_Anlagenverzeichnis_ausgeben);
            this.Controls.Add(this.Button_Einnahmen_bzw_Ausgaben_Rechnung);
            this.Controls.Add(this.Button_Buchung_tätigen);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Buchhaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Screen";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Buchung_tätigen;
        private System.Windows.Forms.Button Button_Einnahmen_bzw_Ausgaben_Rechnung;
        private System.Windows.Forms.Button Button_Anlagenverzeichnis_ausgeben;
        private System.Windows.Forms.Button Butten_Fahrtenbuch_ausgeben;
        private System.Windows.Forms.Button Button_Buchungsübersicht_ausgeben;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
    }
}

