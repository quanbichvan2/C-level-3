using Autofac;
using DataLayer.Context;
using DataLayer.IRepository;
using Lab7B1.UI.ManagerMember;
using Autofac.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using DataLayer.Repository;
using DataLayer.Models;
using Lab7B1.UI;
using Microsoft.EntityFrameworkCore;
using DataLayer.Migrations.ContactDb;
using DataLayer.Service.Repository;

namespace Lab7B1
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cấu hình DI Container
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Tạo ServiceProvider từ DI Container
            using var serviceProvider = services.BuildServiceProvider();

            var form = serviceProvider.GetRequiredService<GUI_ThanhVien>();
            Application.Run(form);
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ContactDbContext>(options => options.UseSqlServer("server=YUN;initial catalog=fuckyou;trusted_connection=True;App=EntityFramework;TrustServerCertificate=True", providerOptions => providerOptions.EnableRetryOnFailure()));
            services.AddScoped<IContactSvc, ContactSvc>();
            services.AddScoped<IMemberSvc, MemberSvc>();
            services.AddSingleton<Main>();
            services.AddSingleton<GUI_ThanhVien>();
        }
    }
}
