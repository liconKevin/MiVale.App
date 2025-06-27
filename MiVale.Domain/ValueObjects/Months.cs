
namespace MiVale.Domain.ValueObjects
{
    public record Months
    {
        public int Value { get; init; }

        public Months(int value)
        {

            if(value <= 0) throw new ArgumentOutOfRangeException("Invalid quantity");

            Value = value;

        }

    }
}
