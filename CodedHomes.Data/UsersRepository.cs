using CodedHomes.Models;
using System.Data.Entity;

namespace CodedHomes.Data
{
    public class UsersRepository : GenericRepository<User>
    {
        public UsersRepository(DbContext context) :
            base(context) { }
    }
}
