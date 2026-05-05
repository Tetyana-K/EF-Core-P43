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
        // Подія LoadForm виконується при завантаженні форми, і тут ми налаштовуємо інтерфейс та завантажуємо дані з бази даних для відображення у DataGridView
        private void Form1_Load(object sender, EventArgs e) // обробник події завантаження форми, виконується при запуску програми і відповідає за початкову настройку інтерфейсу та завантаження даних
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; // автоматичне налаштування ширини стовпців DataGridView під дані, які відображаються
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e) // обробник події кліку на кнопку "Add", який відповідає за додавання нового студента до бази даних
        {
            
            using var db = new StudentDbContext();
            try { 
                int.Parse(tbAge.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            Student student = new Student // створення нового об'єкта Student з даними, введеними користувачем у текстові поля
            {
                Name = tbName.Text,
                Age =  int.Parse(tbAge.Text),
                Group = tbGroup.Text,
                Grade = double.Parse(tbGrade.Text ?? "0")
            };
            db.Students.Add(student); // додавання нового студента до бази даних через контекст бази даних
            db.SaveChanges(); // збереження змін у базі даних, що фактично додає нового студента до бази даних
            LoadData(); // виклик методу LoadData для оновлення відображення даних у DataGridView після додавання нового студента до бази даних
        }

        private void LoadData() // Метод для завантаження даних з бази даних та відображення їх у DataGridView
        {
            using var db = new StudentDbContext(); // створення нового екземпляру контексту бази даних для взаємодії з базою даних
            var students = db.Students.ToList(); // отримання списку всіх студентів з бази даних та перетворення його в список для відображення у DataGridView
            dataGridView1.DataSource = students; // встановлення джерела даних(список студентів) для DataGridView, що дозволяє відображати список студентів у вигляді таблиці на формі
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

        private void btnSortByName_Click(object sender, EventArgs e) // обробник події кліку на кнопку "Sort by Name", який відповідає за сортування студентів за іменем
        {
            using var db = new StudentDbContext();
            var students = db.Students.OrderBy(s => s.Name).ToList();
            dataGridView1.DataSource = students;
        }

        private void btnSortByGrade_Click(object sender, EventArgs e)
        {
            using var db = new StudentDbContext();
            var students = db.Students.OrderByDescending(s => s.Grade).ToList();
            dataGridView1.DataSource = students; // переналштували GridView для відображення відсортованого списку студентів за оцінкою, де найвищі оцінки будуть показані першими
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var group = tbFilter.Text;
            if (string.IsNullOrEmpty(group))
            {
                MessageBox.Show("Please enter a group to filter.");
                return;
            }
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
            var index = dataGridView1.CurrentCell?.RowIndex ?? -1; // отримання індексу поточного вибраного рядка в DataGridView, якщо ж ні, то встановлюємо індекс в -1 для подальшої перевірки
            if (index == -1)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }
            var id = (int?)dataGridView1.Rows?[index].Cells[0].Value; // отримали id для студента, який ми хочемо редагувати, використовуючи індекс вибраного рядка та доступ до першої клітинки (яка містить Id) цього рядка. Якщо ж вибраний рядок або клітинка не існує, то id буде null
            var student = db.Students.Find(id);  // пошук студента в базі даних за отриманим id, що дозволяє отримати повну інформацію про вибраного студента для подальшого редагування
            if (student != null)
            {
                try { 
                    int.Parse(tbAge.Text);
                    double.Parse(tbGrade.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid age and grade.");
                    return;
                }
                student.Name = tbName.Text;
                student.Age = int.Parse(tbAge.Text);
                student.Group = tbGroup.Text;
                student.Grade = double.Parse(tbGrade.Text ?? "0");
                db.SaveChanges(); // збереження змін у базі даних після редагування інформації про студента, що фактично оновлює дані студента в базі даних
                LoadData(); // виклик методу LoadData для оновлення відображення даних у DataGridView після редагування інформації про студента, що дозволяє користувачу бачити оновлену інформацію про студента у таблиці на формі
            }
        }
        // Метод для відображення інформації про поточного студента у текстових полях на формі, що дозволяє користувачу бачити деталі вибраного студента та редагувати їх при необхідності
        private void ShowCurrentStudentInTextBoxes(Student student)
        {
            tbAge.Text = student.Age.ToString();
            tbName.Text = student.Name;
            tbGroup.Text = student.Group;
            tbGrade.Text = student.Grade.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null) // перевірка, чи є вибрана клітинка в DataGridView, щоб уникнути помилок при спробі отримати дані з неіснуючої клітинки
            {
                var index = dataGridView1.CurrentCell.RowIndex;
                //var id = (int)dataGridView1.Rows[index].Cells[0].Value;
                var id = (int)dataGridView1.Rows[index].Cells["Id"].Value; // отримання значення Id з вибраного рядка в DataGridView, використовуючи ім'я стовпця "Id" для доступу до відповідної клітинки, що дозволяє отримати унікальний ідентифікатор студента для подальших операцій, таких як редагування або видалення
                using var db = new StudentDbContext();
                var student = db.Students.Find(id); // пошук студента в базі даних за отриманим Id, що дозволяє отримати повну інформацію про вибраного студента для відображення у текстових полях або виконання інших операцій
                if (student != null)
                {
                    ShowCurrentStudentInTextBoxes(student);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = $"Cell clicked: Row {e.RowIndex}, Column {e.ColumnIndex}";

        }
    }
}
