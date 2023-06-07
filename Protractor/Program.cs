using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Protractor.Contracts;
using Protractor.Data.Context;
using Protractor.Data.Repositories;
using System;
using System.Windows.Forms;

namespace Protractor
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<transactionsForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddScoped<DbSession>();
                    services.AddTransient<ITransactionsRepository, TransactionsRepository>();
                    services.AddTransient<transactionsForm>();
                });
        }
    }
}
