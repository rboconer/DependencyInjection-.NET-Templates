using ConsoleApp_.NET4._8.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET4._8.Repository
{
    public class HelperRepository : IHelperRepository
    {
        public string GetWelcomeString()
        {
            return "Welcome, Hello World!";
        }
    }
}
