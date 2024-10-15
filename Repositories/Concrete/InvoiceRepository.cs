
using Entities.Models;
using Repositories.Common;
using Repositories.Contracts;

namespace Repositories.Concrete
{
    public class InvoiceRepository : RepositoryBase<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(RepositoryContext context) : base(context)
        {
        }
    }
}