
using Repositories.Common;
using Repositories.Contracts;

namespace Repositories.Concrete
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IBlockRepository _blockRepository;
        private readonly IHouseRepository  _houseRepository;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IInvoiceTypeRepository _invoiceTypeRepository;

        public RepositoryManager(RepositoryContext context, IBlockRepository blockRepository, IHouseRepository houseRepository, IInvoiceRepository invoiceRepository, IInvoiceTypeRepository invoiceTypeRepository)
        {
            _context = context;
            _blockRepository = blockRepository;
            _houseRepository = houseRepository;
            _invoiceRepository = invoiceRepository;
            _invoiceTypeRepository = invoiceTypeRepository;
        }

        public IBlockRepository BlockRepository => _blockRepository;

        public IHouseRepository HouseRepository => _houseRepository;

        public IInvoiceRepository InvoiceRepository => _invoiceRepository;

        public IInvoiceTypeRepository InvoiceTypeRepository => _invoiceTypeRepository;

        public void Save()
        => _context.SaveChanges();
    }
}