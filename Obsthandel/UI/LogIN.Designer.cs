namespace Obsthandel
{
    partial class LogIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_benutzer = new System.Windows.Forms.TextBox();
            this.tB_PW = new System.Windows.Forms.TextBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benutzername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwort";
            // 
            // tB_benutzer
            // 
            this.tB_benutzer.Location = new System.Drawing.Point(105, 22);
            this.tB_benutzer.Name = "tB_benutzer";
            this.tB_benutzer.Size = new System.Drawing.Size(100, 20);
            this.tB_benutzer.TabIndex = 2;
            // 
            // tB_PW
            // 
            this.tB_PW.Location = new System.Drawing.Point(105, 48);
            this.tB_PW.Name = "tB_PW";
            this.tB_PW.Size = new System.Drawing.Size(100, 20);
            this.tB_PW.TabIndex = 3;
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(117, 83);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(75, 23);
            this.bt_Login.TabIndex = 4;
            this.bt_Login.Text = "Log In";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // LogIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 120);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.tB_PW);
            this.Controls.Add(this.tB_benutzer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogIN";
            this.Text = "LogIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_benutzer;
        private System.Windows.Forms.TextBox tB_PW;
        private System.Windows.Forms.Button bt_Login;
    }
}