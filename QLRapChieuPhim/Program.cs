using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QLRapChieuPhim.Infrastructure.Repositories;

namespace QLRapChieuPhim
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            //Application.Run(ServiceProvider.GetRequiredService<Form1>());
            Application.Run(new Login());        }
        public static IServiceProvider? ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddScoped( typeof(IRepository<>), typeof(Repository<>) );
                });
        }
    }
}