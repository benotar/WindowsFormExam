using System.Speech.Synthesis;
using WindowsFormExam.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormExam.Forms;

public partial class InfoToDoForm : Form
{
    private Todo? _todo;

    private SpeechSynthesizer _synthesizer = new SpeechSynthesizer();

    public InfoToDoForm(object? toDoesListBoxItem)
    {
        _todo = toDoesListBoxItem as Todo;

        InitializeComponent();
    }

    // TODO
    private void InfoToDoFormLoad(object sender, EventArgs e)
    {
        titleLabel.Text = _todo.Title;
        createDateLable.Text = _todo.CreatedDateString();
        endingDateLabel.Text = _todo.EndingDateString();
        descriptionRichTextBox.Text = _todo.Description;
    }

    private void ReadDescriptionButtonClick(object sender, EventArgs e)
    {
        string text = descriptionRichTextBox.Text;

        if (!string.IsNullOrEmpty(text))
        {
            _synthesizer.Dispose();

            _synthesizer = new SpeechSynthesizer();

            _synthesizer.SpeakAsync(text);
        }
        else
        {
            MessageBox.Show("Please enter some text first!");
        }

        //ReadText(descriptionRichTextBox.Text);
    }

    //private async void ReadText(string text)
    //{
    //    if (!string.IsNullOrEmpty(text))
    //    {
    //        _synthesizer.Dispose();

    //        _synthesizer = new SpeechSynthesizer();

    //        _synthesizer.SpeakAsync(text);
    //    }
    //    else
    //    {
    //        MessageBox.Show("Please enter some text first!");
    //    }
    //}

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
            string text = descriptionRichTextBox.Text;

            if (!string.IsNullOrEmpty(text))
            {
                //_synthesizer.Dispose();

                _synthesizer = new SpeechSynthesizer();

                _synthesizer.SpeakAsync(text);
            }
            else
            {
                MessageBox.Show("Please enter some text first!");
            }
        }
    }

    private void StopButtonClick(object sender, EventArgs e)
    {
        if (_synthesizer is not null)
        {
            _synthesizer.Dispose();
        }
    }
}
