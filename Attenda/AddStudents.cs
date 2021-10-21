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
    public partial class AddStudents : MetroFramework.Forms.MetroForm
    {
        public string className { get; set; }
        public int classID { get; set; }
        public AddStudents()
        {
            InitializeComponent();
        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(className))
            {
                // TODO: This line of code loads data into the 'userDataSet.Student' table. You can move, or remove it, as needed.
                this.studentTableAdapter.FillByClassID(this.userDataSet.Student, classID);
                this.metroLabelClassName.Text = className.ToString();
                this.metroLabelClassID.Text = classID.ToString();
            }
        }

        private void metroButtonSaveStudent_Click(object sender, EventArgs e)
        {
            studentBindingSource.EndEdit();
            studentTableAdapter.Update(userDataSet.Student);
            MessageBox.Show("New student(s) added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
