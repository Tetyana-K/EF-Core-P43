using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WF_One_To_One.Data;
using WF_One_To_One.DTO;
using WF_One_To_One.Models;

namespace WF_One_To_One
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var db = new Data.PeopleAddressDbContexts();
            Person person = new Person
            {
                Name = tbName.Text,
                Age = (int)numAge.Value,

            };
            if (tbStreet.Text != "" || tbCity.Text != "" || tbCountry.Text != "")
            {
                person.Address = new Address
                {
                    Street = tbStreet.Text,
                    City = tbCity.Text,
                    Country = tbCountry.Text
                };
            }
            db.People.Add(person);
            db.SaveChanges();
            LoadData();
        }

        private void LoadData()
        {
            using var db = new Data.PeopleAddressDbContexts();
            var people = db.People.Include(p => p.Address).Select(p => new PersonAddressDTO
            {
                Id = p.Id,
                Name = p.Name,
                Age = p.Age,
                Street = p.Address != null ? p.Address.Street : "",
                City = p.Address != null ? p.Address.City : "",
                Country = p.Address != null ? p.Address.Country : ""
            }).ToList();
            dataGridView1.DataSource = people;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index >= 0)
            {
                var selectedPerson = (PersonAddressDTO)dataGridView1.Rows[index].DataBoundItem;
                tbName.Text = selectedPerson?.Name;
                numAge.Value = selectedPerson?.Age ?? 0;
                tbStreet.Text = selectedPerson?.Street;
                tbCity.Text = selectedPerson?.City;
                tbCountry.Text = selectedPerson?.Country;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell?.RowIndex ?? -1;
            if (index >= 0)
            {
                var selectedPerson = (PersonAddressDTO)dataGridView1.Rows[index].DataBoundItem;
                if (selectedPerson != null)
                {
                    using var db = new PeopleAddressDbContexts();
                    var person = db.People.Include(p => p.Address).FirstOrDefault(p => p.Id == selectedPerson.Id);
                    if (person != null)
                    {
                        person.Name = tbName.Text;
                        person.Age = (int)numAge.Value;
                        if (person.Address != null)
                        {
                            person.Address.Street = tbStreet.Text;
                            person.Address.City = tbCity.Text;
                            person.Address.Country = tbCountry.Text;
                        }
                        else if (!string.IsNullOrEmpty(tbStreet.Text) || !string.IsNullOrEmpty(tbCity.Text) || !string.IsNullOrEmpty(tbCountry.Text))
                        {
                            person.Address = new Address
                            {
                                Street = tbStreet.Text,
                                City = tbCity.Text,
                                Country = tbCountry.Text
                            };
                        }
                        db.SaveChanges();
                        LoadData();
                    }
                }
            }
        }
    }
}
