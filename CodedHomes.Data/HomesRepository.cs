using CodedHomes.Models;
using System.Data.Entity;

namespace CodedHomes.Data
{
    public class HomesRepository : GenericRepository<Home>
    {
        public HomesRepository(DbContext context) :
            base(context) { }
    }
}
