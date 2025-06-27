
using System.Text.RegularExpressions;

namespace MiVale.Domain.ValueObjects
{
    public record PhoneNumber
    {

        const string pattern = @"^\d{10}$";

        public string value {  get; init; }

        public PhoneNumber(string value)
        {

            if (Regex.IsMatch(value, pattern))
            {
                throw new ArgumentException("Invalid Phone Number");
            }

            this.value = value;

        }

    }
}
