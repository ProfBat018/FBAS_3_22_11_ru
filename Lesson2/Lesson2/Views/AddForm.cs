using Lesson2.Models;
using Lesson2.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lesson2.Program;

namespace Lesson2.Views
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ToDoItem itemToAdd = new()
            {
                Name = nameTextBox.Text,
                Due = duePicker.Value,
            };

            AddPresenter.AddItem(itemToAdd);
        }

        public void UpdatePicture(string fileName)
        {
            taskPictureBox.Image = Image.FromFile(fileName);
        }

    }
}
