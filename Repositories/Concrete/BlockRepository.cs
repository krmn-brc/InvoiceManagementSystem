
using Entities.Models;
using Repositories.Common;
using Repositories.Contracts;

namespace Repositories.Concrete
{
    public class BlockRepository : RepositoryBase<Block>, IBlockRepository
    {
        protected BlockRepository(RepositoryContext context) : base(context)
        {
            
        }
    }
}