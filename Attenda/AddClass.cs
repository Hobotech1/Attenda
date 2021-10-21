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
    public partial class AddClass : Form
    {
        public int userID { get; set; }
        public AddClass()
        {
            InitializeComponent();
        }
        
        private void metroButtonAddClass_Click(object sender, EventArgs e)
        {
            UserDataSetTableAdapters.ClassTableAdapter classAdapter = new UserDataSetTableAdapters.ClassTableAdapter();
            classAdapter.AddClass(metroTextBoxClassName.Text, userID);
            MessageBox.Show("New class added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
