using WF_Students.Data;
using WF_Students.Models;

namespace WF_Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; // автоматичне налаштування ширини стовпців DataGridView під дані, які відображаються
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var db = new StudentDbContext();
            Student student = new Student
            {
                Name = tbName.Text,
                Age = 17,// int.Parse(tbAge.Text),
                Group = "A11", //tbGroup.Text,
                Grade = double.Parse(tbGrade.Text ?? "0")
            };
            db.Students.Add(student);
            db.SaveChanges();
            LoadData();
        }

        private void LoadData()
        {
            using var db = new StudentDbContext();
            var students = db.Students.ToList();
            dataGridView1.DataSource = students;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowIndex;
            var id = (int)dataGridView1.Rows[index].Cells[0].Value;
            using var db = new StudentDbContext();
            var student = db.Students.Find(id);
            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
                LoadData();
            }
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            using var db = new StudentDbContext();
            var students = db.Students.OrderBy(s => s.Name).ToList();
            dataGridView1.DataSource = students;
        }

        private void btnSortByGrade_Click(object sender, EventArgs e)
        {
            using var db = new StudentDbContext();
            var students = db.Students.OrderByDescending(s => s.Grade).ToList();
            dataGridView1.DataSource = students;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var group = tbFilter.Text;
            using var db = new StudentDbContext();
            var students = db.Students.Where(s => s.Group == group).ToList();
            dataGridView1.DataSource = students;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using var db = new StudentDbContext();
            var index = dataGridView1.CurrentCell?.RowIndex ?? -1;
            if (index == -1)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }
            var id = (int?)dataGridView1.Rows?[index].Cells[0].Value;
            var student = db.Students.Find(id);
            if (student != null)
            {
                student.Name = tbName.Text;
                student.Age = int.Parse(tbAge.Text);
                student.Group = tbGroup.Text;
                student.Grade = double.Parse(tbGrade.Text ?? "0");
                db.SaveChanges();
                LoadData();
            }
        }

        private void ShowCurrentStudentInTextBoxes(Student student)
        {
            tbAge.Text = student.Age.ToString();
            tbName.Text = student.Name;
            tbGroup.Text = student.Group;
            tbGrade.Text = student.Grade.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentCell != null)
            {
                var index = dataGridView1.CurrentCell.RowIndex;
                var id = (int)dataGridView1.Rows[index].Cells[0].Value;
                using var db = new StudentDbContext();
                var student = db.Students.Find(id);
                if (student != null)
                {
                    ShowCurrentStudentInTextBoxes(student);
                }
            }
        }
    }
}
