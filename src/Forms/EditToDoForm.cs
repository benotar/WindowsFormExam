using WindowsFormExam.Data;
using WindowsFormExam.Entities;

namespace WindowsFormExam.Forms;

public partial class EditToDoForm : Form
{
    private readonly DataContext _db;

    private Todo? _todo;
    public EditToDoForm(DataContext db, object? toDoesListBoxItem)
    {
        _db = db;

        _todo = toDoesListBoxItem as Todo;

        InitializeComponent();
    }

    private void UpdateBtnClick(object sender, EventArgs e)
    {
        
        if (_todo is null)
        {
            MessageBox.Show("Something went wrong!");
        }

        Todo? newTodo = new Todo
        {
            Title = editTODOTitleTextBox.Text,
            Description = editTODODescriptionTextBox.Text,
            EndingDate = editTODOEndingDateTimePicker.Value
        };

        if (newTodo == _todo)
        {
            MessageBox.Show("TODO already exists!");

            return;
        }

        var updateTODO = _db.ToDoes.Where(td => td.Id == _todo.Id).FirstOrDefault();

        if (updateTODO is not null)
        {
            updateTODO.Title = newTodo.Title;

            updateTODO.Description = newTodo.Description;

            updateTODO.EndingDate = newTodo.EndingDate;

            _db.SaveChanges();

            var mainForm = Application.OpenForms[("MainForm")] as MainForm;

            if (mainForm is null)
            {
                MessageBox.Show("Something went wrong!");

                return;
            }

            mainForm.RefreshListTODOMainForm();

            MessageBox.Show("TODO successfully updated!");

            this.Close();
        }
        else
        {
            MessageBox.Show("Selected TODO not found in the database!");
            
            return;
        }
    }
}