

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IBlockRepository BlockRepository { get; }
        IHouseRepository HouseRepository { get; }
        IInvoiceRepository InvoiceRepository { get; }
        IInvoiceTypeRepository InvoiceTypeRepository { get; }

        void Save();
    }
}