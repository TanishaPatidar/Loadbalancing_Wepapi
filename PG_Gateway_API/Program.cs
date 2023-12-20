using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace TMS_Web_Gateway_Api
{
    public class Program
    {
        public static string hostUrl, certName, certPass;
        public static void Main(string[] args)
        {
            //IConfigurationBuilder builder = new ConfigurationBuilder()
            //////.SetBasePath(Directory.GetCurrentDirectory()) // Set the base path to the application's directory
            //.SetBasePath(System.AppContext.BaseDirectory)
            //.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            //IConfiguration configuration = builder.Build();

            ////// Retrieve the value of "MySetting" from appsettings.json
            //hostUrl = configuration["AppSettings:hostUrl"];
            //certName = configuration["AppSettings:certName"];
            //certPass = configuration["AppSettings:certPass"];
            try
            {
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                //System.IO.File.AppendAllText("D://ex.txt"," # " + ex.Message.ToString());
                //throw;
            }

        }
        //With SSL
        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //     Host.CreateDefaultBuilder(args)
        //         .ConfigureWebHostDefaults(webBuilder =>
        //         {
        //             webBuilder.UseStartup<Startup>()
        //                       .UseKestrel(options =>
        //                       {
        //                           options.ConfigureHttpsDefaults(httpsOptions =>
        //                           {
        //                               //check host entry also
        //                               //192.168.10.117	testtmsy.com



        //                               httpsOptions.ServerCertificate = new X509Certificate2(
        //                                   Path.Combine(AppContext.BaseDirectory, certName)//@"E:\MQTT\1.Final\PG_Auth_Logs_API\bin\Test\", "testtmsy.com.pfx"),
        //                                   , certPass
        //                               );
        //                           });
        //                       })
        //                       .UseUrls(hostUrl); // Specify the desired HTTPS URL
        //         })
        //            .ConfigureAppConfiguration((hostingContext, config) =>
        //            {
        //                config
        //                .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
        //                .AddJsonFile("configuration.json", optional: false, reloadOnChange: true);
        //            })
        //         .UseWindowsService(); // Host as a Windows service

        //working latest
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                  
                })
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config
                .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                .AddJsonFile("configuration.json", optional: false, reloadOnChange: true)
                .AddJsonFile("ocelat.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            });













        //Win Service
        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //     Host.CreateDefaultBuilder(args)
        //         .ConfigureWebHostDefaults(webBuilder =>
        //         {
        //             webBuilder.UseStartup<Startup>()
        //                       .UseUrls(hostUrl); // Specify the desired HTTPS URL
        //         })
        //    .ConfigureAppConfiguration((hostingContext, config) =>
        //    {
        //        config
        //        .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
        //        .AddJsonFile("configuration.json", optional: false, reloadOnChange: true);
        //    })
        //.UseWindowsService();

    }
}
