namespace test
{
    partial class LoginBildschirm
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
            this.Button_Bestätigen = new System.Windows.Forms.Button();
            this.Label_Benutzename = new System.Windows.Forms.Label();
            this.Label_Passwort = new System.Windows.Forms.Label();
            this.TextBox_Benutzername = new System.Windows.Forms.TextBox();
            this.TextBox_Passwort = new System.Windows.Forms.TextBox();
            this.Button_Verlassen = new System.Windows.Forms.Button();
            this.Label_Connection_Status = new System.Windows.Forms.Label();
            this.GroupBox_Login = new System.Windows.Forms.GroupBox();
            this.GroupBox_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Bestätigen
            // 
            this.Button_Bestätigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Bestätigen.Location = new System.Drawing.Point(144, 117);
            this.Button_Bestätigen.Name = "Button_Bestätigen";
            this.Button_Bestätigen.Size = new System.Drawing.Size(124, 53);
            this.Button_Bestätigen.TabIndex = 0;
            this.Button_Bestätigen.Text = "Bestätigen";
            this.Button_Bestätigen.UseVisualStyleBackColor = true;
            this.Button_Bestätigen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_Benutzename
            // 
            this.Label_Benutzename.AutoSize = true;
            this.Label_Benutzename.Location = new System.Drawing.Point(3, 34);
            this.Label_Benutzename.Name = "Label_Benutzename";
            this.Label_Benutzename.Size = new System.Drawing.Size(104, 17);
            this.Label_Benutzename.TabIndex = 1;
            this.Label_Benutzename.Text = "Benutzername:";
            // 
            // Label_Passwort
            // 
            this.Label_Passwort.AutoSize = true;
            this.Label_Passwort.Location = new System.Drawing.Point(3, 67);
            this.Label_Passwort.Name = "Label_Passwort";
            this.Label_Passwort.Size = new System.Drawing.Size(69, 17);
            this.Label_Passwort.TabIndex = 2;
            this.Label_Passwort.Text = "Passwort:";
            // 
            // TextBox_Benutzername
            // 
            this.TextBox_Benutzername.Location = new System.Drawing.Point(113, 29);
            this.TextBox_Benutzername.Name = "TextBox_Benutzername";
            this.TextBox_Benutzername.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Benutzername.TabIndex = 3;
            // 
            // TextBox_Passwort
            // 
            this.TextBox_Passwort.Location = new System.Drawing.Point(113, 62);
            this.TextBox_Passwort.Name = "TextBox_Passwort";
            this.TextBox_Passwort.PasswordChar = '*';
            this.TextBox_Passwort.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Passwort.TabIndex = 4;
            // 
            // Button_Verlassen
            // 
            this.Button_Verlassen.Location = new System.Drawing.Point(6, 117);
            this.Button_Verlassen.Name = "Button_Verlassen";
            this.Button_Verlassen.Size = new System.Drawing.Size(124, 53);
            this.Button_Verlassen.TabIndex = 5;
            this.Button_Verlassen.Text = "Verlassen ";
            this.Button_Verlassen.UseVisualStyleBackColor = true;
            this.Button_Verlassen.Click += new System.EventHandler(this.Button_Verlassen_Click);
            // 
            // Label_Connection_Status
            // 
            this.Label_Connection_Status.AutoSize = true;
            this.Label_Connection_Status.Location = new System.Drawing.Point(328, 76);
            this.Label_Connection_Status.Name = "Label_Connection_Status";
            this.Label_Connection_Status.Size = new System.Drawing.Size(123, 17);
            this.Label_Connection_Status.TabIndex = 6;
            this.Label_Connection_Status.Text = "Connection Status";
            // 
            // GroupBox_Login
            // 
            this.GroupBox_Login.Controls.Add(this.Button_Verlassen);
            this.GroupBox_Login.Controls.Add(this.TextBox_Benutzername);
            this.GroupBox_Login.Controls.Add(this.TextBox_Passwort);
            this.GroupBox_Login.Controls.Add(this.Button_Bestätigen);
            this.GroupBox_Login.Controls.Add(this.Label_Passwort);
            this.GroupBox_Login.Controls.Add(this.Label_Benutzename);
            this.GroupBox_Login.Location = new System.Drawing.Point(9, 9);
            this.GroupBox_Login.Name = "GroupBox_Login";
            this.GroupBox_Login.Size = new System.Drawing.Size(274, 176);
            this.GroupBox_Login.TabIndex = 7;
            this.GroupBox_Login.TabStop = false;
            this.GroupBox_Login.Text = "Login";
            // 
            // LoginBildschirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 253);
            this.Controls.Add(this.Label_Connection_Status);
            this.Controls.Add(this.GroupBox_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginBildschirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login-Bildschirm";
            this.Load += new System.EventHandler(this.LoginBildschirm_Load);
            this.GroupBox_Login.ResumeLayout(false);
            this.GroupBox_Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Bestätigen;
        private System.Windows.Forms.Label Label_Benutzename;
        private System.Windows.Forms.Label Label_Passwort;
        private System.Windows.Forms.TextBox TextBox_Benutzername;
        private System.Windows.Forms.TextBox TextBox_Passwort;
        private System.Windows.Forms.Button Button_Verlassen;
        private System.Windows.Forms.Label Label_Connection_Status;
        private System.Windows.Forms.GroupBox GroupBox_Login;
    }
}