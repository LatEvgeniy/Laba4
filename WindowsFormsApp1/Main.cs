using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        List<Subject> subjects = new List<Subject>();
        public Main()
        {
            InitializeComponent();
            btAddSubject.Click += BtAddSubject_Click;
            btDeleteSubject.Click += BtDeleteSubject_Click;
            btSiriaize.Click += BtSiriaize_Click;
            DGVSubjects.CellContentDoubleClick += DGVSelectedSubject_CellContentDoubleClick;
        }

        private void BtSiriaize_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbXML.Checked && rbFromFile.Checked)
                {
                    var deserializer = new XmlSerializer(typeof(List<Subject>));
                    List<Subject> subjectsFromFile = new List<Subject>();
                    using (var file = new FileStream("Subjects.xml", FileMode.Open))
                        subjectsFromFile = (List<Subject>)deserializer.Deserialize(file);
                    foreach (Subject subject in subjectsFromFile)
                        subjects.Add(subject);
                    DGVSubjects.DataSource = null;
                    DGVSubjects.DataSource = subjects;
                }
                else if (rbJSON.Checked && rbFromFile.Checked)
                {
                    var deserializer = new DataContractJsonSerializer(typeof(List<Subject>));
                    List<Subject> subjectsFromFile = new List<Subject>();
                    using (var file = new FileStream("Subjects.JSON", FileMode.Open))
                        subjectsFromFile = (List<Subject>)deserializer.ReadObject(file);
                    foreach (Subject subject in subjectsFromFile)
                        subjects.Add(subject);
                    DGVSubjects.DataSource = null;
                    DGVSubjects.DataSource = subjects;
                }
                else if (DGVSubjects.CurrentCell.RowIndex >= 0)
                {
                    if (rbXML.Checked && rbInFile.Checked)
                    {
                        var serializer = new XmlSerializer(typeof(List<Subject>));
                        using (var file = new FileStream("Subjects.xml", FileMode.Create))
                            serializer.Serialize(file, subjects);
                    }
                    else if (rbJSON.Checked && rbInFile.Checked)
                    {
                        var serializer = new DataContractJsonSerializer(typeof(List<Subject>));
                        using (var file = new FileStream("Subjects.JSON", FileMode.Create))
                            serializer.WriteObject(file, subjects);
                    }
                }
                else
                {
                    MessageBox.Show("Не було обрано предмет або помилка при читанні з файлу",
                         "Помилка",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Не було обрано предмет або помилка при читанні з файлу",
                     "Помилка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void BtDeleteSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVSubjects.CurrentCell.RowIndex >= 0)
                {
                    subjects.RemoveAt(DGVSubjects.CurrentCell.RowIndex);
                    DGVSubjects.DataSource = null;
                    DGVSubjects.DataSource = subjects;
                }
            }
            catch
            {
                MessageBox.Show("Немає предметів для видалення",
                                     "Помилка",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }

        private void DGVSelectedSubject_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (subjects[DGVSubjects.CurrentCell.RowIndex].students.Count == 0)
                subjects[DGVSubjects.CurrentCell.RowIndex].students.Add(new Student("Студент", "за замовчуванням", 0));

            var dialog = new Subjects(subjects[DGVSubjects.CurrentCell.RowIndex].Name, subjects[DGVSubjects.CurrentCell.RowIndex].students);
            dialog.Text = "Студенти обраного предмету";
            dialog.ShowDialog();
            subjects[DGVSubjects.CurrentCell.RowIndex].students = dialog.students;
        }

        private void BtAddSubject_Click(object sender, EventArgs e)
        {
            subjects.Add(new Subject("Назва предмету"));
            DGVSubjects.DataSource = null;
            DGVSubjects.DataSource = subjects;
        }     
    }

    [Serializable] public class Subject
    {
        private string name;
        public string Name { get => name; set => name = value; }

        public List<Student> students = new List<Student>();

        public Subject(string name)
        {
            Name = name;
        }
        public Subject() { }
    }
    [Serializable] public class Student
    {
        private string firstName;
        private string lastName;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        private int grade;
        public int Grade
        {
            get => grade;
            set
            {
                if (value <= 100 && value >= 0)
                    grade = value;
                else
                    MessageBox.Show("Оцінка може будти від 0 до 100 включно",
                         "Помилка введення даних",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }

        public Student(string firstName, string lastName, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public Student() { }
    }
}