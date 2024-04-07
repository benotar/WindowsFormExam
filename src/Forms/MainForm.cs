using System.Speech.Synthesis;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WindowsFormExam.Data;
using WindowsFormExam.Entities;

namespace WindowsFormExam.Forms;

public partial class MainForm : Form
{
    private SpeechSynthesizer _synthesizer;

    private DataContext _db;

    public MainForm()
    {
        _db = new DataContext();
        _synthesizer = new SpeechSynthesizer();
        InitializeComponent();
    }


    private void MainFormLoad(object sender, EventArgs e)
    {
        titleLabel.Text = "TODO:";

        List<Todo> todoes = _db.ToDoes.AsNoTracking().ToList();

        foreach (var item in todoes)
        {
            toDoesListBox.Items.Add(item);
        }

    }

    private void AddToDoButtonClick(object sender, EventArgs e)
    {
        AddToDoForm addToDoForm = new AddToDoForm(_db);

        addToDoForm.Show();
    }

    private void EditToDoButtonClick(object sender, EventArgs e)
    {
        if (toDoesListBox.SelectedItem is null)
        {
            MessageBox.Show("Something went wrong! No TODO selected!");

            return;
        }

        // TODO: Add form EDIT TODO
        EditToDoForm editToDoForm = new EditToDoForm(_db, toDoesListBox.SelectedItem);

        editToDoForm.Show();
    }

    private void DeleteToDoButtonClick(object sender, EventArgs e)
    {
        Todo? selectedTodo = toDoesListBox.SelectedItem as Todo;

        if (selectedTodo is null)
        {
            MessageBox.Show("Something went wrong! No TODO selected!");

            return;
        }

        var deleteTodo = _db.ToDoes.Where(td => td.Id == selectedTodo.Id).FirstOrDefault();

        if (deleteTodo is null)
        {
            MessageBox.Show("Selected TODO not found in the database!");

            return;
        }

        try
        {
            _db.Remove(deleteTodo);

            _db.SaveChanges();

            MessageBox.Show("Deleted successfully!");

            RefreshListTODOMainForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while deleting TODO: {ex.Message}");
        }
    }

    private void TodoListDoubleClick(object sender, EventArgs e)
    {
        var selectedToDo = toDoesListBox.SelectedItem as Todo;

        if (selectedToDo is null)
        {
            MessageBox.Show("Something went wrong! No TODO selected!");

            return;
        }

        InfoToDoForm infoToDoForm = new InfoToDoForm(selectedToDo);

        infoToDoForm.Show();
    }

    public void RefreshListTODOMainForm()
    {
        toDoesListBox.Items.Clear();

        List<Todo> todoes = _db.ToDoes.AsNoTracking().ToList();

        foreach (var item in todoes)
        {
            toDoesListBox.Items.Add(item);
        }
    }

    private void ReadText(string text)
    {

    }
}
