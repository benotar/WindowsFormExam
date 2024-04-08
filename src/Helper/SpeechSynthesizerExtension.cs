using System.Speech.Synthesis;

namespace WindowsFormExam.Helper;

public static class SpeechSynthesizerExtension
{
    public static void SpeakText(ref SpeechSynthesizer? _synthesizer, string text)
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