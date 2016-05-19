namespace test
{
    partial class Fahrt_hinzufügen
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
            this.textBox_Fahrstrecke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePicker_Datum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Zweck = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Anfangskilometer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Endkilometer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Fahrstrecke
            // 
            this.textBox_Fahrstrecke.Location = new System.Drawing.Point(166, 97);
            this.textBox_Fahrstrecke.Name = "textBox_Fahrstrecke";
            this.textBox_Fahrstrecke.Size = new System.Drawing.Size(207, 22);
            this.textBox_Fahrstrecke.TabIndex = 0;
            this.textBox_Fahrstrecke.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DateTimePicker_Datum
            // 
            this.DateTimePicker_Datum.Location = new System.Drawing.Point(166, 44);
            this.DateTimePicker_Datum.Name = "DateTimePicker_Datum";
            this.DateTimePicker_Datum.Size = new System.Drawing.Size(243, 22);
            this.DateTimePicker_Datum.TabIndex = 2;
            this.DateTimePicker_Datum.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fahrstrecke:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zweck:";
            // 
            // textBox_Zweck
            // 
            this.textBox_Zweck.Location = new System.Drawing.Point(166, 155);
            this.textBox_Zweck.Name = "textBox_Zweck";
            this.textBox_Zweck.Size = new System.Drawing.Size(207, 22);
            this.textBox_Zweck.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Anfangskilometer:";
            // 
            // textBox_Anfangskilometer
            // 
            this.textBox_Anfangskilometer.Location = new System.Drawing.Point(166, 217);
            this.textBox_Anfangskilometer.Name = "textBox_Anfangskilometer";
            this.textBox_Anfangskilometer.Size = new System.Drawing.Size(207, 22);
            this.textBox_Anfangskilometer.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endkilometer:";
            // 
            // textBox_Endkilometer
            // 
            this.textBox_Endkilometer.Location = new System.Drawing.Point(166, 288);
            this.textBox_Endkilometer.Name = "textBox_Endkilometer";
            this.textBox_Endkilometer.Size = new System.Drawing.Size(207, 22);
            this.textBox_Endkilometer.TabIndex = 9;
            this.textBox_Endkilometer.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 80);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schließenToolStripMenuItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(588, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // Fahrt_hinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 465);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Endkilometer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Anfangskilometer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Zweck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimePicker_Datum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Fahrstrecke);
            this.Name = "Fahrt_hinzufügen";
            this.Text = "Fahrt_hinzufügen";
            this.Load += new System.EventHandler(this.Fahrt_hinzufügen_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Fahrstrecke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Datum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Zweck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Anfangskilometer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Endkilometer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
    }
}