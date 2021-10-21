
namespace Attenda
{
    partial class Registration
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxRegUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCreatePassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(201, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Create Username";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(198, 174);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Create Password";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(198, 208);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Confirm Password";
            // 
            // metroTextBoxRegUsername
            // 
            this.metroTextBoxRegUsername.Location = new System.Drawing.Point(363, 106);
            this.metroTextBoxRegUsername.Name = "metroTextBoxRegUsername";
            this.metroTextBoxRegUsername.Size = new System.Drawing.Size(135, 23);
            this.metroTextBoxRegUsername.TabIndex = 3;
            this.metroTextBoxRegUsername.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // metroTextBoxCreatePassword
            // 
            this.metroTextBoxCreatePassword.Location = new System.Drawing.Point(363, 174);
            this.metroTextBoxCreatePassword.Name = "metroTextBoxCreatePassword";
            this.metroTextBoxCreatePassword.Size = new System.Drawing.Size(135, 23);
            this.metroTextBoxCreatePassword.TabIndex = 4;
            // 
            // metroTextBoxConfirmPassword
            // 
            this.metroTextBoxConfirmPassword.Location = new System.Drawing.Point(363, 208);
            this.metroTextBoxConfirmPassword.Name = "metroTextBoxConfirmPassword";
            this.metroTextBoxConfirmPassword.Size = new System.Drawing.Size(135, 23);
            this.metroTextBoxConfirmPassword.TabIndex = 5;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(198, 142);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(472, 20);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "*Use an easy to remember password. There is no password policy in place.";
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(422, 254);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(75, 23);
            this.metroButtonSave.TabIndex = 7;
            this.metroButtonSave.Text = "Save";
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButtonSave);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBoxConfirmPassword);
            this.Controls.Add(this.metroTextBoxCreatePassword);
            this.Controls.Add(this.metroTextBoxRegUsername);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRegUsername;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCreatePassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxConfirmPassword;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButtonSave;
    }
}