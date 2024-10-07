using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models.Common;

namespace Entities.Models
{
    public class Invoice:BaseEntity
    {
        public DateTime InvocingDateTime { get; set; }
        public DateTime LastPaymentDate { get; set; }
        public decimal Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int InvoiceTypeId { get; set; }
        public InvoiceType InvoiceType { get; set; }
        public int HouseId { get; set; }
        public House House { get; set; }
    }
}