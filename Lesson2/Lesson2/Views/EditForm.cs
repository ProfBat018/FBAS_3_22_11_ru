using Lesson2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2.Views
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        public void ShowItem(ToDoItem item)
        {
            nameTextBox.Text = item.Name;
            duePicker.Value = item.Due;
            taskPictureBox.Image = Image.FromFile(item.ImagePath);

            this.ShowDialog();
        }
    }
}
