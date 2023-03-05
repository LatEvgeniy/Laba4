using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Subjects : Form
    {
        public string subjectName;
        public List<Student> students = new List<Student>();
        public Subjects(string subjectname, List<Student> students)
        {
            InitializeComponent();
            this.subjectName = subjectname;
            this.students = students;
            labelInformation.Text = $"Інформація про обраний предмет: {subjectName}";
            DGVSelectedSubject.DataSource = students;
            btDeleteStudent.Click += BtDeleteStudent_Click;
            btStudentSort.Click += BtStudentSort_Click;
            btAddStudent.Click += BtAddStudent_Click;
        }

        private void BtAddStudent_Click(object sender, EventArgs e)
        {
            students.Add(new Student("Студент", "за замовчуванням", 0));
            DGVSelectedSubject.DataSource = null;
            DGVSelectedSubject.DataSource = students;
        }

        private void BtStudentSort_Click(object sender, EventArgs e)
        {
            var temp = from p in students orderby p.LastName select p;
            List<Student> list = new List<Student>();
            foreach (var item in temp)
                list.Add(item);
            students = list;
            DGVSelectedSubject.DataSource = students;
        }

        private void BtDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVSelectedSubject.CurrentCell.RowIndex >= 0)
                {
                    students.RemoveAt(DGVSelectedSubject.CurrentCell.RowIndex);
                    DGVSelectedSubject.DataSource = null;
                    DGVSelectedSubject.DataSource = students;
                }
            }
            catch
            {
                MessageBox.Show("Немає студентів для видалення",
                                     "Помилка",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        } 
    }
}
