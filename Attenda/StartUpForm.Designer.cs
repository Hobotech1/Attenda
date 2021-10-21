
namespace Attenda
{
    partial class StartUpForm
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
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSet1 = new Attenda.UserDataSet();
            this.metroButtonShowClassList = new MetroFramework.Controls.MetroButton();
            this.metroButtonClear = new MetroFramework.Controls.MetroButton();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSet = new Attenda.UserDataSet();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAddClass = new MetroFramework.Controls.MetroButton();
            this.metroButtonAddStudent = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroButtonGenerate = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Present = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Absent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new Attenda.UserDataSetTableAdapters.ClassTableAdapter();
            this.studentTableAdapter = new Attenda.UserDataSetTableAdapters.StudentTableAdapter();
            this.registerTableAdapter = new Attenda.UserDataSetTableAdapters.RegisterTableAdapter();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(760, 370);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.Controls.Add(this.metroButtonShowClassList);
            this.metroTabPage1.Controls.Add(this.metroButtonClear);
            this.metroTabPage1.Controls.Add(this.metroButtonSave);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.dateTimePicker1);
            this.metroTabPage1.Controls.Add(this.metroComboBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(752, 327);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Attendance";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(46, 77);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(306, 20);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "*Status: Type either p for present or a for absent";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Grade,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(406, 224);
            this.dataGridView1.TabIndex = 10;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Student Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 150;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.Width = 50;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 50;
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "Register";
            this.registerBindingSource.DataSource = this.userDataSet1;
            // 
            // userDataSet1
            // 
            this.userDataSet1.DataSetName = "UserDataSet";
            this.userDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroButtonShowClassList
            // 
            this.metroButtonShowClassList.Location = new System.Drawing.Point(462, 118);
            this.metroButtonShowClassList.Name = "metroButtonShowClassList";
            this.metroButtonShowClassList.Size = new System.Drawing.Size(164, 23);
            this.metroButtonShowClassList.TabIndex = 9;
            this.metroButtonShowClassList.Text = "Show Class List";
            this.metroButtonShowClassList.Click += new System.EventHandler(this.metroButtonShowClassList_Click);
            // 
            // metroButtonClear
            // 
            this.metroButtonClear.Location = new System.Drawing.Point(462, 197);
            this.metroButtonClear.Name = "metroButtonClear";
            this.metroButtonClear.Size = new System.Drawing.Size(164, 23);
            this.metroButtonClear.TabIndex = 8;
            this.metroButtonClear.Text = "Clear Status";
            this.metroButtonClear.Click += new System.EventHandler(this.metroButtonClear_Click);
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(462, 158);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(164, 23);
            this.metroButtonSave.TabIndex = 7;
            this.metroButtonSave.Text = "Save Attendance";
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(338, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Date";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Class";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(396, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.classBindingSource;
            this.metroComboBox1.DisplayMember = "ClassName";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(103, 30);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(190, 30);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.ValueMember = "ClassID";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.userDataSetBindingSource;
            // 
            // userDataSetBindingSource
            // 
            this.userDataSetBindingSource.DataSource = this.userDataSet;
            this.userDataSetBindingSource.Position = 0;
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroLabel9);
            this.metroTabPage3.Controls.Add(this.metroLabel8);
            this.metroTabPage3.Controls.Add(this.metroButtonAddClass);
            this.metroTabPage3.Controls.Add(this.metroButtonAddStudent);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(752, 327);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Admin";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.Location = new System.Drawing.Point(12, 100);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(218, 17);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "* Allocate student(s) to a specific class";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.Location = new System.Drawing.Point(12, 25);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(229, 17);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "* One teacher can have multiple classes";
            // 
            // metroButtonAddClass
            // 
            this.metroButtonAddClass.Location = new System.Drawing.Point(12, 55);
            this.metroButtonAddClass.Name = "metroButtonAddClass";
            this.metroButtonAddClass.Size = new System.Drawing.Size(110, 23);
            this.metroButtonAddClass.TabIndex = 3;
            this.metroButtonAddClass.Text = "Add Class";
            this.metroButtonAddClass.Click += new System.EventHandler(this.metroButtonAddClass_Click);
            // 
            // metroButtonAddStudent
            // 
            this.metroButtonAddStudent.Location = new System.Drawing.Point(12, 130);
            this.metroButtonAddStudent.Name = "metroButtonAddStudent";
            this.metroButtonAddStudent.Size = new System.Drawing.Size(110, 23);
            this.metroButtonAddStudent.TabIndex = 2;
            this.metroButtonAddStudent.Text = "Add Student";
            this.metroButtonAddStudent.Click += new System.EventHandler(this.metroButtonAddStudent_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.listView2);
            this.metroTabPage2.Controls.Add(this.metroButtonGenerate);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.dateTimePicker2);
            this.metroTabPage2.Controls.Add(this.metroComboBox2);
            this.metroTabPage2.Controls.Add(this.listView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(752, 327);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Reports";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(512, 75);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(96, 20);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Daily Report";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(158, 75);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(116, 20);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Monthy Report";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(369, 98);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(350, 206);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "StudentName";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Present";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Absent";
            // 
            // metroButtonGenerate
            // 
            this.metroButtonGenerate.Location = new System.Drawing.Point(608, 31);
            this.metroButtonGenerate.Name = "metroButtonGenerate";
            this.metroButtonGenerate.Size = new System.Drawing.Size(107, 23);
            this.metroButtonGenerate.TabIndex = 10;
            this.metroButtonGenerate.Text = "Generate";
            this.metroButtonGenerate.Click += new System.EventHandler(this.metroButtonGenerate_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(279, 34);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 20);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Date";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 34);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 20);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Class";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(337, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.DataSource = this.classBindingSource;
            this.metroComboBox2.DisplayMember = "ClassName";
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 24;
            this.metroComboBox2.Location = new System.Drawing.Point(70, 24);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(190, 30);
            this.metroComboBox2.TabIndex = 6;
            this.metroComboBox2.ValueMember = "ClassID";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentName,
            this.Present,
            this.Absent});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 206);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // StudentName
            // 
            this.StudentName.Text = "StudentName";
            this.StudentName.Width = 101;
            // 
            // Present
            // 
            this.Present.Text = "Present";
            // 
            // Absent
            // 
            this.Absent.Text = "Absent";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.userDataSet1;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartUpForm";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Activated += new System.EventHandler(this.StartUpForm_Activated);
            this.Load += new System.EventHandler(this.StartUpForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton metroButtonClear;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton metroButtonAddClass;
        private MetroFramework.Controls.MetroButton metroButtonAddStudent;
        private System.Windows.Forms.BindingSource userDataSetBindingSource;
        private UserDataSet userDataSet;
        private System.Windows.Forms.BindingSource classBindingSource;
        private UserDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private MetroFramework.Controls.MetroButton metroButtonShowClassList;
        private UserDataSet userDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private UserDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private UserDataSetTableAdapters.RegisterTableAdapter registerTableAdapter;
        private MetroFramework.Controls.MetroButton metroButtonGenerate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader StudentName;
        private System.Windows.Forms.ColumnHeader Present;
        private System.Windows.Forms.ColumnHeader Absent;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}

