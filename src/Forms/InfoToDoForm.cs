using System.Speech.Synthesis;
using WindowsFormExam.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormExam.Forms;

public partial class InfoToDoForm : Form
{
    private Todo? _todo;

    private SpeechSynthesizer? _synthesizer;

    private string _descText;

    private string _allInfoText;

    private bool _textFlag;

    public InfoToDoForm(object? toDoesListBoxItem)
    {
        _todo = toDoesListBoxItem as Todo;

        _synthesizer = new SpeechSynthesizer();

        _allInfoText = _descText = string.Empty;

        _textFlag = false;

        InitializeComponent();
    }

    private void InfoToDoFormLoad(object sender, EventArgs e)
    {
        titleLabel.Text = _todo!.Title;

        createDateLabel.Text = _todo.CreatedDateString();

        endingDateLabel.Text = _todo.EndingDateString();

        _descText = descriptionRichTextBox.Text = _todo.Description;
    }

    private void ReadDescriptionButtonClick(object sender, EventArgs e)
    {
        _textFlag = false;

        ReadText(_descText);
    }

    private void ReadAllInfoButtonClick(object sender, EventArgs e)
    {
        _allInfoText = $"Title - {titleLabel.Text}. Date of create {createDateLabel.Text}. Complete by {endingDateLabel.Text}.\n" +
            $"Description: {_descText}.";

        _textFlag = true;

        ReadText(_allInfoText);
    }

    private void PauseButtonClick(object sender, EventArgs e)
    {
        if (_synthesizer is not null)
        {
            if (_synthesizer.State == SynthesizerState.Speaking)
            {
                _synthesizer.Pause();
            }
        }
    }

    private void ResumeButtonClick(object sender, EventArgs e)
    {
        if (_synthesizer is not null)
        {
            if (_synthesizer.State == SynthesizerState.Paused)
            {
                _synthesizer.Resume();
            }
        }
        else
        {
            if (_textFlag)
            {
                ReadText(_allInfoText);
            }
            else
            {
                ReadText(_descText);
            }
        }
    }

    private void StopButtonClick(object sender, EventArgs e)
    {
        StopSpeak();
    }

    private void InfoToDoFormClosing(object sender, FormClosingEventArgs e)
    {
        StopSpeak();
    }

    private void StopSpeak()
    {
        if (_synthesizer is not null)
        {
            _synthesizer.Dispose();

            _synthesizer = null;
        }
    }

    private void ReadText(string text)
    {
        if (!string.IsNullOrEmpty(text))
        {
            if (_synthesizer is not null)
            {
                _synthesizer.Dispose();
            }

            _synthesizer = new SpeechSynthesizer();

            _synthesizer.SpeakAsync(text);
        }
        else
        {
            MessageBox.Show("Please enter some text first!");
        }
    }
}