using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormExam.Data;

namespace WindowsFormExam.Forms
{
    public partial class AddToDoForm : Form
    {
        private DataContext _db;

        public AddToDoForm(DataContext db)
        {
            _db = db;
            InitializeComponent();
        }


        private void SaveBtnClick(object sender, EventArgs e)
        { 
            if (String.IsNullOrEmpty(newTODOTitleTextBox.Text) ||
                String.IsNullOrEmpty(newTODODescriptionTextBox.Text) ||
                 String.IsNullOrEmpty(newTODOEndingDateTimePicker.Text))
            {
                MessageBox.Show("Something went wrong! The data is not filled!");

                return;
            }

            MessageBox.Show("Temp");

            return;
        }
    }
}
