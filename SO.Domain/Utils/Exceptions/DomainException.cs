using System;

namespace SO.Domain.Utils.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
            throw new ArgumentException(message);
        }

        public static void When(bool condition, string message)
        {
            if (condition)
                _ = new DomainException(message);
        }
    }
}
