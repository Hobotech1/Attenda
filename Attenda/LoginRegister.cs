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
    public partial class LoginRegister : MetroFramework.Forms.MetroForm
    {
        public bool isLoginValid { get; set; }
        public int userID { get; set; }
        public LoginRegister()
        {
            InitializeComponent();
            isLoginValid = false;
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            UserDataSetTableAdapters.UserTableAdapter userAdapter = new UserDataSetTableAdapters.UserTableAdapter();
            DataTable dt = userAdapter.GetDataByUserNameandPassword(metroTextBoxUsername.Text, metroTextBoxPswd.Text);

            if (dt.Rows.Count > 0)
            {
                //login details exist
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userID = int.Parse(dt.Rows[0]["UserID"].ToString());
                isLoginValid = true;
            }
            else
            {
                //login details combo not found
                MessageBox.Show("Login failed", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                isLoginValid = false;
            }
            Close();
        }

        private void metroButtonRegister_Click(object sender, EventArgs e)
        {
            Registration RegisterUser = new Registration();
            RegisterUser.ShowDialog();
        }
    }
}
