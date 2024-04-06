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
        ConfigurationBuilder builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("Properties/appsettings.json");
        IConfigurationRoot? config = builder.Build();
        string stringConnection = config.GetConnectionString("DefaultSQLConnection");
        DbContextOptionsBuilder<DataContext> optionsBuilder = new DbContextOptionsBuilder<DataContext>();
        DbContextOptions<DataContext> options = optionsBuilder.UseMySql(stringConnection, ServerVersion.Parse("8.0.30-myslq")).Options;

        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm(options));
    }
}