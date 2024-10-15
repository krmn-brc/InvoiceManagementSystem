using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Repositories.Common;
using Repositories.Contracts;

namespace Repositories.Concrete
{
    public class InvoiceTypeRepository : RepositoryBase<InvoiceType>, IInvoiceTypeRepository
    {
        public InvoiceTypeRepository(RepositoryContext context) : base(context)
        {
        }
    }
}