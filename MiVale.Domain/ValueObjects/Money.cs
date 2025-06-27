
namespace MiVale.Domain.ValueObjects
{
    public record Money
    {

        public double Value { get; init; }

        public Money(double value)
        {

            if(value < 0) throw new ArgumentException("Invalid quantity of money");

            Value = value;

        }

    }
}
