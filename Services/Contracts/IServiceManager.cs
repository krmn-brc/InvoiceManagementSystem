
namespace Services.Contracts
{
    public interface IServiceManager
    {
        IBlockService BlockService { get; }
        IHouseService HouseService { get; }
        IInvoiceService InvoiceService { get; }
        IInvoiceTypeService InvoiceTypeService { get; }
    }
}