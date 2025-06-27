
using MiVale.Domain.ValueObjects;

namespace MiVale.Domain.Entities
{
    public class Voucher
    {
        public int VoucherId { get; set; }

        public Money Payment {  get; set; }

        public Months MonthPayment { get; set; }

        public DateOnly CreationDate { get; set; }

        public int LoanId { get; set; }

        public List<Voucher> VoucherList { get; set; }

    }
}
