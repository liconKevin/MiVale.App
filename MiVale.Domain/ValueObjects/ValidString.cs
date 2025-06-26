using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiVale.Domain.ValueObjects
{
    public record ValidString
    {

        public string Value { get; init; }

        public ValidString(string value)
        {

            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Invalid string");
            }

            Value = value;

        }

    }
}
