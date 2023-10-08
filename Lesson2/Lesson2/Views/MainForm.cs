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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddView.ShowDialog();
        }
        private void taskslistBox_DoubleClick(object sender, EventArgs e)
        {
            EditView.ShowItem(taskslistBox.SelectedItem as ToDoItem);
        }

        public void UpdateListBox(List<ToDoItem> tasks)
        {
            taskslistBox.Items.Clear();

            foreach (var task in tasks)
            {
                taskslistBox.Items.Add(task);
            }
        }   
    }
}
