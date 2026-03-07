using UgnayDesktop.Forms;
using UgnayDesktop.Data;

namespace UgnayDesktop;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        DbInitializer.Seed();

        ApplicationConfiguration.Initialize();
        Application.Run(new LoginForm());
    }
}
