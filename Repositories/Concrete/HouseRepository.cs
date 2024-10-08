
using Entities.Models;
using Repositories.Common;
using Repositories.Contracts;

namespace Repositories.Concrete
{
    public class HouseRepository : RepositoryBase<House>, IHouseRepository
    {
        protected HouseRepository(RepositoryContext context) : base(context)
        {
        }
    }
}