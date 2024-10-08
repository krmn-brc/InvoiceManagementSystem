
using Services.Contracts;

namespace Services.Concrete
{
    public class ServiceManager : IServiceManager
    {
        private readonly IBlockService _blockService;
        private readonly IHouseService _houseService;
        private readonly IInvoiceService _invoiceService;
        private readonly IInvoiceTypeService _invoiceTypeService;

        public ServiceManager(IBlockService blockService, IHouseService houseService, IInvoiceService invoiceService, IInvoiceTypeService invoiceTypeService)
        {
            _blockService = blockService;
            _houseService = houseService;
            _invoiceService = invoiceService;
            _invoiceTypeService = invoiceTypeService;
        }

        public IBlockService BlockService =>  _blockService;

        public IHouseService HouseService => _houseService;

        public IInvoiceService InvoiceService => _invoiceService;

        public IInvoiceTypeService InvoiceTypeService => _invoiceTypeService;
    }
}