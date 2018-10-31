using CounterApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CounterApi.Core.Interfaces
{

    public interface IUserRepository : IRepository<User>
    {
        int GetUsersCount();
        
    }
}
