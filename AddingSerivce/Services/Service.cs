using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddingSerivce.Services
{
    public class Service : IService
    {
        public void CreateSomething()
        {
            Console.WriteLine("Created something");
        }

        public async Task CreateSomethingAsync()
        {
            var task = Task.Run(() => Console.WriteLine("Created something async"));
            await task;
        }

        public string GetSomeResultBack()
        {
            return "This is the return value";
        }

        public async Task<string> GetSomeResultBackAsync()
        {
            return await SomeMethodThatIsAsync();
        }

        private async Task<string> SomeMethodThatIsAsync()
        {
            return "f";
        }
    }
}
