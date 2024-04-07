using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormExam.Entities;

namespace WindowsFormExam.Forms
{
    public partial class InfoToDoForm : Form
    {
        private Todo? _todo;

        private SpeechSynthesizer _synthesizer;

        private CancellationTokenSource _cancellationTokenSource;

        public InfoToDoForm(object? toDoesListBoxItem, SpeechSynthesizer synthesizer)
        {
            _todo = toDoesListBoxItem as Todo;

            _synthesizer = synthesizer;

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
            string read = descriptionRichTextBox.Text;

            ReadText(read);
        }

        private async void ReadText(string text)
        {

            _synthesizer.SpeakAsync(text);
        }

        private void PauseReadingButtonClick(object sender, EventArgs e)
        {
            _synthesizer.Pause();
        }
    }
}
