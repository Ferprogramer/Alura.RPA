using Alura.RPA.Domain.Repositories;
using Alura.RPA.Domain.Services;
using Alura.RPA.Repository.Contexts;
using Alura.RPA.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Alura.RPA
{
    internal class Program
    {
        public static async Task Main(params string[] args)
        {
            using IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                {
                    logging.AddSimpleConsole(x =>
                    {
                        x.SingleLine = true;
                        x.TimestampFormat = "[yyyyMMdd HHmmss.fff] ";
                    });
                    logging.AddFile("Logs/{Date}-RPA.log");
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddScoped<ApplicationDbContext>();
                    services.AddScoped<CursoServices>();
                    services.AddScoped<ICursosRepository, CursosRepository>();

                    var serviceProvider = services.BuildServiceProvider();
                    CursoServices cursoServices = serviceProvider.GetRequiredService<CursoServices>();
                    cursoServices.GetCursoInformation();
                })
                .Build();
            await host.RunAsync();
        }
    }
}