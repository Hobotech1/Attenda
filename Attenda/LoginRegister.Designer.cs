
namespace Attenda
{
    partial class LoginRegister
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
            this.metroTextBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPswd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelUsername = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPswd = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.metroButtonRegister = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBoxUsername
            // 
            this.metroTextBoxUsername.Location = new System.Drawing.Point(268, 264);
            this.metroTextBoxUsername.Name = "metroTextBoxUsername";
            this.metroTextBoxUsername.Size = new System.Drawing.Size(162, 23);
            this.metroTextBoxUsername.TabIndex = 1;
            // 
            // metroTextBoxPswd
            // 
            this.metroTextBoxPswd.Location = new System.Drawing.Point(268, 304);
            this.metroTextBoxPswd.Name = "metroTextBoxPswd";
            this.metroTextBoxPswd.PasswordChar = '*';
            this.metroTextBoxPswd.Size = new System.Drawing.Size(162, 23);
            this.metroTextBoxPswd.TabIndex = 2;
            // 
            // metroLabelUsername
            // 
            this.metroLabelUsername.AutoSize = true;
            this.metroLabelUsername.Location = new System.Drawing.Point(174, 264);
            this.metroLabelUsername.Name = "metroLabelUsername";
            this.metroLabelUsername.Size = new System.Drawing.Size(73, 20);
            this.metroLabelUsername.TabIndex = 3;
            this.metroLabelUsername.Text = "Username";
            // 
            // metroLabelPswd
            // 
            this.metroLabelPswd.AutoSize = true;
            this.metroLabelPswd.Location = new System.Drawing.Point(174, 307);
            this.metroLabelPswd.Name = "metroLabelPswd";
            this.metroLabelPswd.Size = new System.Drawing.Size(66, 20);
            this.metroLabelPswd.TabIndex = 4;
            this.metroLabelPswd.Text = "Password";
            // 
            // metroButtonLogin
            // 
            this.metroButtonLogin.Location = new System.Drawing.Point(355, 350);
            this.metroButtonLogin.Name = "metroButtonLogin";
            this.metroButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.metroButtonLogin.TabIndex = 5;
            this.metroButtonLogin.Text = "Login";
            this.metroButtonLogin.Click += new System.EventHandler(this.metroButtonLogin_Click);
            // 
            // metroButtonRegister
            // 
            this.metroButtonRegister.Location = new System.Drawing.Point(268, 350);
            this.metroButtonRegister.Name = "metroButtonRegister";
            this.metroButtonRegister.Size = new System.Drawing.Size(75, 23);
            this.metroButtonRegister.TabIndex = 6;
            this.metroButtonRegister.Text = "Register";
            this.metroButtonRegister.Click += new System.EventHandler(this.metroButtonRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Attenda.Properties.Resources.blog_security_4;
            this.pictureBox1.Location = new System.Drawing.Point(174, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 424);
            this.Controls.Add(this.metroButtonRegister);
            this.Controls.Add(this.metroButtonLogin);
            this.Controls.Add(this.metroLabelPswd);
            this.Controls.Add(this.metroLabelUsername);
            this.Controls.Add(this.metroTextBoxPswd);
            this.Controls.Add(this.metroTextBoxUsername);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUsername;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPswd;
        private MetroFramework.Controls.MetroLabel metroLabelUsername;
        private MetroFramework.Controls.MetroLabel metroLabelPswd;
        private MetroFramework.Controls.MetroButton metroButtonLogin;
        private MetroFramework.Controls.MetroButton metroButtonRegister;
    }
}