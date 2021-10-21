using Attenda.UserDataSetTableAdapters;
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
    public partial class StartUpForm : MetroFramework.Forms.MetroForm
    {
        public int loggedIn { get; set; }
        public int userID { get; set; }
        public string className { get; set; }
        public int classID { get; set; }
        public StartUpForm()
        {
            InitializeComponent();
            loggedIn = 0;
        }

        private void StartUpForm_Load(object sender, EventArgs e)
        {
           
        }

        private void StartUpForm_Activated(object sender, EventArgs e)
        {
            metroTabPage1.Focus();

            if (loggedIn == 0)
            {
                LoginRegister login = new LoginRegister();
                login.ShowDialog();

                if (login.isLoginValid == false)
                {
                    Close();
                }
                else
                {
                    userID = login.userID;
                    loggedIn = 1;

                    this.classTableAdapter.Fill(this.userDataSet.Class);
                    classBindingSource.Filter = "UserID = '" + userID.ToString() + "'";
                }
            }
        }

        private void metroButtonAddClass_Click(object sender, EventArgs e)
        {
            AddClass addClass = new AddClass();
            addClass.userID = this.userID;
            addClass.ShowDialog();
        }

        private void metroButtonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudents student = new AddStudents();

            if (string.IsNullOrEmpty(student.className))
            {
                student.className = this.metroComboBox1.Text;
                student.classID = (int)this.metroComboBox1.SelectedValue;
            }
            student.ShowDialog(); 
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            RegisterTableAdapter attregister = new UserDataSetTableAdapters.RegisterTableAdapter();
            string present = "p";
            string absent = "a";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((row.Cells[0].Value != null) && string.IsNullOrEmpty(row.Cells[2].Value.ToString().Trim()))
                {
                    MessageBox.Show("Set Status for each student", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if ((row.Cells[0].Value != null) && (row.Cells[2].Value.ToString().Trim().ToLower() != present) && (row.Cells[2].Value.ToString().Trim().ToLower() != absent))
                {
                    MessageBox.Show("Set Status to either p or a", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    attregister.UpdateQuery(row.Cells[2].Value.ToString(), row.Cells[0].Value.ToString(), (int)metroComboBox1.SelectedValue, (DateTime)dateTimePicker1.Value);
                }
            }

            DataTable dat = attregister.GetDataBy((int)metroComboBox1.SelectedValue, (DateTime)dateTimePicker1.Value);
            dataGridView1.DataSource = dat;

            MessageBox.Show("Attendance saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            RegisterTableAdapter attregister = new UserDataSetTableAdapters.RegisterTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    attregister.UpdateQuery("", row.Cells[0].Value.ToString(), (int)metroComboBox1.SelectedValue, (DateTime)dateTimePicker1.Value);
                }
            }

            DataTable dta = attregister.GetDataBy((int)metroComboBox1.SelectedValue, (DateTime)dateTimePicker1.Value);
            dataGridView1.DataSource = dta;
        }

        private void metroButtonGenerate_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();

            StudentTableAdapter studentTableAdapter = new StudentTableAdapter();
            DataTable student = studentTableAdapter.GetDataByClassID((int)metroComboBox2.SelectedValue);

            RegisterTableAdapter attregister = new UserDataSetTableAdapters.RegisterTableAdapter();

            int present = 0;
            int absent = 0;

            int dailyp = 0;
            int dailya = 0;

            foreach (DataRow row in student.Rows)
            {
                present = (int)attregister.GetDataByMonthly(dateTimePicker2.Value.Month, row[1].ToString(), "p").Rows[0][8];
                absent = (int)attregister.GetDataByMonthly(dateTimePicker2.Value.Month, row[1].ToString(), "a").Rows[0][8];

                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = row[1].ToString();
                listViewItem.SubItems.Add(present.ToString());
                listViewItem.SubItems.Add(absent.ToString());
                listView1.Items.Add(listViewItem);

                dailyp = (int)attregister.GetDataByDaily(dateTimePicker2.Value.ToString("yyyy-MM-dd"), row[1].ToString(), "p").Rows[0][8];
                dailya = (int)attregister.GetDataByDaily(dateTimePicker2.Value.ToString("yyyy-MM-dd"), row[1].ToString(), "a").Rows[0][8];

                ListViewItem listViewItem2 = new ListViewItem();
                listViewItem2.Text = row[1].ToString();
                listViewItem2.SubItems.Add(dailyp.ToString());
                listViewItem2.SubItems.Add(dailya.ToString());
                listView2.Items.Add(listViewItem2);
            }
        }

        private void metroButtonShowClassList_Click(object sender, EventArgs e)
        {
            metroButtonShowClassList.Focus();
            dataGridView1.DataSource = null;
            dataGridView1.Update();
            dataGridView1.Refresh();

            RegisterTableAdapter attregister = new UserDataSetTableAdapters.RegisterTableAdapter();
            DataTable dt = attregister.GetDataBy((int)metroComboBox1.SelectedValue, (DateTime)dateTimePicker1.Value);

            if (dt.Rows.Count > 0)
            {
                DataTable dt_new = attregister.GetDataBy((int)metroComboBox1.SelectedValue, (DateTime)dateTimePicker1.Value);
                dataGridView1.DataSource = dt_new;
            }
            else
            {
                StudentTableAdapter studentTableAdapter = new StudentTableAdapter();
                DataTable dt_student = studentTableAdapter.GetDataByClassID((int)metroComboBox1.SelectedValue);

                foreach (DataRow row in dt_student.Rows)
                {
                    attregister.InsertQuery((int)row[0], (int)metroComboBox1.SelectedValue, (DateTime)dateTimePicker1.Value, "");
                }

                DataTable dta = attregister.GetDataBy((int)metroComboBox1.SelectedValue, (DateTime)dateTimePicker1.Value);
                dataGridView1.DataSource = dta;
            }
        }
    }
}
