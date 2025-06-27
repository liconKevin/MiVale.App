
using MiVale.Domain.ValueObjects;

namespace MiVale.Domain.Entities
{
    public class Loan
    {

        public int LoanId { get; set; }

        public Months months { get; set; }

        public Money TotalPayment { get; set; }

        public DateOnly CreationDate { get; set; }

        public bool IsActive { get; set; }

        public PhoneNumber ClientId { get; set; }

    }
}
