using WindowsFormExam.Data;
using WindowsFormExam.Entities;

namespace WindowsFormExam.Forms;

public partial class AddToDoForm : Form
{
    private readonly DataContext _db;

    public AddToDoForm(DataContext db)
    {
        _db = db;
        InitializeComponent();
    }

    private void SaveBtnClick(object sender, EventArgs e)
    { 
        if (string.IsNullOrEmpty(newTODOTitleTextBox.Text) ||
            string.IsNullOrEmpty(newTODODescriptionTextBox.Text) ||
             string.IsNullOrEmpty(newTODOEndingDateTimePicker.Text))
        {
            MessageBox.Show("Something went wrong! The data is not filled!");
            return;
        }

        Todo newTodo = new Todo
        {
            Title = newTODOTitleTextBox.Text,
            Description = newTODODescriptionTextBox.Text,
            EndingDate = newTODOEndingDateTimePicker.Value
        };

        _db.Add(newTodo);

        _db.SaveChanges();

        var mainForm = Application.OpenForms[("MainForm")] as MainForm;

        if (mainForm is null)
        {
            MessageBox.Show("Something went wrong!");

            return;
        }

        mainForm.RefreshListTODOMainForm();

        MessageBox.Show("TODO successfully added!");

        this.Close();
    }
}