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
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        IConfigurationRoot config = builder.Build();

        string? stringConnection = config.GetConnectionString("DefaultConnection");

        var options = new DbContextOptionsBuilder<DataContext>()
            .UseMySql(stringConnection, ServerVersion.Parse("8.0.30-mysql")).Options;

        using (var db = new DataContext(options))
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(db));
        }
    }
}