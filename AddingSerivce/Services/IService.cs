using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddingSerivce.Services
{
    public interface IService
    {
        string GetSomeResultBack();
        Task<string> GetSomeResultBackAsync();

        void CreateSomething();
        Task CreateSomethingAsync();



    }
}
