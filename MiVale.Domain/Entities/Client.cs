
using MiVale.Domain.ValueObjects;

namespace MiVale.Domain.Entities
{
    public class Client
    {

        public PhoneNumber phoneNumber { get; set; }

        public ValidString Name { get; set; }

        public ValidString LastName { get; set; }

        public bool IsActive { get; set; }

        public List<Loan> Loans { get; set; }

    }
}
