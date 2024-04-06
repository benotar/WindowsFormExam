using System.Speech.Synthesis;

namespace WindowsFormExam.Forms;

public partial class MainForm : Form
{
    private SpeechSynthesizer _synthesizer = new SpeechSynthesizer();

    public MainForm()
    {
        InitializeComponent();
    }


    private void ReadText(string text)
    {

    }
}
