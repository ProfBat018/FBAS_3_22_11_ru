using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part2
{
    public partial class MainForm : Form
    {
        private string? picturePath;
        public MainForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();

            dialog.Filter = "Picture (*.png, *.jpg, *.jpeg, *.jfif) | *.png; *.jpg; *.jpeg; *.jfif;|All files (*.*)|*.*";

            dialog.Title = "Select a picture";

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                picturePath = dialog.FileName;
                personPictureBox.Image = Image.FromFile(picturePath);
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Person personToAdd = new()
            {
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                BirthDate = birthDatePicker.Value,
                ImagePath = picturePath ?? "user.png"
            };

            if (InputCheckers.CheckAll(personToAdd))
            {
                peopleListBox.Items.Add(personToAdd);

                nameTextBox.Clear();
                surnameTextBox.Clear();
                birthDatePicker.Value = DateTime.Now;
                picturePath = null;
            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void peopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (peopleListBox.SelectedItem != null)
            {
                Person selectedPerson = peopleListBox.SelectedItem as Person;

                if (selectedPerson != null)
                {
                    nameTextBox.Text = selectedPerson.Name;
                    surnameTextBox.Text = selectedPerson.Surname;
                    birthDatePicker.Value = selectedPerson.BirthDate;
                    personPictureBox.Image = Image.FromFile(selectedPerson.ImagePath);
                }

            }

        }
    }
}
