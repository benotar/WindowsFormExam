using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormExam.Entities;

namespace WindowsFormExam.Forms
{
    public partial class InfoToDoForm : Form
    {
        private Todo? _todo;

        public InfoToDoForm(object? toDoesListBoxItem)
        {
            _todo = toDoesListBoxItem as Todo;

            InitializeComponent();
        }

        private void InfoToDoFormLoad(object sender, EventArgs e)
        {
            titleLabel.Text = _todo.Title;
        }
    }
}
