using System.Speech.Synthesis;
using WindowsFormExam.Entities;
using WindowsFormExam.Helper;

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

    private void SpeakDescriptionButtonClick(object sender, EventArgs e)
    {
        _textFlag = false;

        SpeechSynthesizerExtension.SpeakText(ref _synthesizer, _descText);
    }

    private void SpeakAllInfoButtonClick(object sender, EventArgs e)
    {
        _allInfoText = $"Title - {titleLabel.Text}. Date of create {createDateLabel.Text}. Complete by {endingDateLabel.Text}.\n" +
            $"Description: {_descText}.";

        _textFlag = true;

        SpeechSynthesizerExtension.SpeakText(ref _synthesizer, _allInfoText);
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
                SpeechSynthesizerExtension.SpeakText(ref _synthesizer, _allInfoText);
            }
            else
            {
                SpeechSynthesizerExtension.SpeakText(ref _synthesizer, _descText);
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
}