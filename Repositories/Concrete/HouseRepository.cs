
using Entities.Models;
using Repositories.Common;
using Repositories.Contracts;

namespace Repositories.Concrete
{
    public class HouseRepository : RepositoryBase<House>, IHouseRepository
    {
        public HouseRepository(RepositoryContext context) : base(context)
        {
        }
    }
}