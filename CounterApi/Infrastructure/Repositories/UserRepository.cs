using CounterApi.Core.Models;
using CounterApi.Core.Interfaces;
using System.Linq;

namespace CounterApi.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext): base(dbContext)
        {            
        }

        public int GetUsersCount() => AppDbContext.Users.Count();

        public AppDbContext AppDbContext
        {
            get { return Context as AppDbContext; }
        }

    }
}