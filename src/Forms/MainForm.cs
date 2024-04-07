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
        tittleLabel.Text = "TODO:";

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

    private void EditTodoButtonClick(object sender, EventArgs e)
    {
        if (toDoesListBox.SelectedItem is null)
        {
            MessageBox.Show("Something went wrong! No TODO selected!");

            return;
        }

        // TODO: Add form EDIT TODO
        EditToDoForm editToDoForm = new EditToDoForm(_db);

        editToDoForm.Show();
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
