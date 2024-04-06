using System.Speech.Synthesis;
using Microsoft.EntityFrameworkCore;
using WindowsFormExam.Data;

namespace WindowsFormExam.Forms;

public partial class MainForm : Form
{
    private SpeechSynthesizer _synthesizer = new SpeechSynthesizer();

    private DataContext _db;

    public MainForm(DataContext db)
    {
        _db = db;
        InitializeComponent();
    }


    private void ReadText(string text)
    {

    }
}
