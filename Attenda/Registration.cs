using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attenda
{
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
           
            if (metroTextBoxCreatePassword.Text != metroTextBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            UserDataSetTableAdapters.UserTableAdapter userAdapter = new UserDataSetTableAdapters.UserTableAdapter();

            userAdapter.InsertQuery(metroTextBoxRegUsername.Text, metroTextBoxCreatePassword.Text);
            MessageBox.Show("User registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
