using ConsoleApp_.NET4._8.Repository;
using ConsoleApp_.NET4._8.Repository.IRepository;
using ConsoleApp_.NET4._8.Service;
using ConsoleApp_.NET4._8.Service.IService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_net48
{
    public class Program
    {
        private readonly IHelperService _helperService;

        public Program(IHelperService helperService)
        {
            this._helperService = helperService; 
        }
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<Program>().StartProcess();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {   
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<Program>();
                    services.AddSingleton<IHelperService, HelperService>();
                    services.AddSingleton<IHelperRepository, HelperRepository>();
                    //add more service/repository to be injected here
                });
        }
        public void StartProcess()
        {
            Console.WriteLine("Process start.");

            //do the main logic in here.
            _helperService.PrintWelcome();

            Console.WriteLine("Process end.");
        }
    }
}
