
namespace Attenda
{
    partial class AddClass
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
            this.metroTextBoxClassName = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonAddClass = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(107, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Class Name";
            // 
            // metroTextBoxClassName
            // 
            this.metroTextBoxClassName.Location = new System.Drawing.Point(219, 75);
            this.metroTextBoxClassName.Name = "metroTextBoxClassName";
            this.metroTextBoxClassName.Size = new System.Drawing.Size(227, 23);
            this.metroTextBoxClassName.TabIndex = 1;
            // 
            // metroButtonAddClass
            // 
            this.metroButtonAddClass.Location = new System.Drawing.Point(453, 74);
            this.metroButtonAddClass.Name = "metroButtonAddClass";
            this.metroButtonAddClass.Size = new System.Drawing.Size(75, 23);
            this.metroButtonAddClass.TabIndex = 2;
            this.metroButtonAddClass.Text = "Add";
            this.metroButtonAddClass.Click += new System.EventHandler(this.metroButtonAddClass_Click);
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButtonAddClass);
            this.Controls.Add(this.metroTextBoxClassName);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxClassName;
        private MetroFramework.Controls.MetroButton metroButtonAddClass;
    }
}