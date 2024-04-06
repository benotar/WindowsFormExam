using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WindowsFormExam.Data;
using WindowsFormExam.Forms;

namespace WindowsWormExam;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}