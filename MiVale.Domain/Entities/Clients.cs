
using MiVale.Domain.ValueObjects;

namespace MiVale.Domain.Entities
{
    public class Clients
    {

        public PhoneNumber phoneNumber { get; set; }

        public ValidString Name { get; set; }

        public ValidString LastName { get; set; }

        public bool IsActive { get; set; }


    }
}
