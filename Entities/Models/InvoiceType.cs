

using Entities.Models.Common;

namespace Entities.Models
{
    public class InvoiceType:BaseEntity
    {
        public string TypeName { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}