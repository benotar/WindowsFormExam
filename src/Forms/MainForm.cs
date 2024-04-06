using System.Speech.Synthesis;
using Microsoft.EntityFrameworkCore;
using WindowsFormExam.Data;

namespace WindowsFormExam.Forms;

public partial class MainForm : Form
{
    private SpeechSynthesizer _synthesizer = new SpeechSynthesizer();

    private DataContext _db;

    public MainForm(DbContextOptions<DataContext> options)
    {
        _db = new DataContext(options);
        InitializeComponent();
    }


    private void ReadText(string text)
    {

    }
}
