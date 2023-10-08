using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class MainForm : Form
    {
        private static int counter = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void clickmeButton_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
                counterLabel.Text = (++counter).ToString();
            else if (sender.GetType() == typeof(Label))
                counterLabel.Text = (--counter).ToString();
        }
    }
}
