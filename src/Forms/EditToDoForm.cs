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
    public partial class EditToDoForm : Form
    {
        private readonly DataContext _db;
        public EditToDoForm(DataContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private void UpdateBtnClick(object sender, EventArgs e)
        {

        }
    }
}
