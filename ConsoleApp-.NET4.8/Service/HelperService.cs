using ConsoleApp_.NET4._8.Repository.IRepository;
using ConsoleApp_.NET4._8.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET4._8.Service
{
    public class HelperService : IHelperService
    {
        private readonly IHelperRepository _helperRepo;

        public HelperService(IHelperRepository helperRepo)
        {
            this._helperRepo = helperRepo;
        }

        public void PrintWelcome()
        {
            Console.WriteLine(_helperRepo.GetWelcomeString());
        }
    }
}
