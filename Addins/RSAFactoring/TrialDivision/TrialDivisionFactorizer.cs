using BigIntegerGMP2;

namespace RSAFactoring.TrialDivision
{
    /// <summary>
    /// Class for RSA factorization using Trial Division.
    /// Suitable for small bit sizes (e.g., 16 to 32 bits).
    /// Implements a straightforward trial division method for factoring.
    /// </summary>
    public class TrialDivisionFactorizer : RSAFactorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrialDivisionFactorizer"/> class with the specified modulus.
        /// </summary>
        /// <param name="modulus">The modulus to be factored.</param>
        public TrialDivisionFactorizer(BigInteger modulus) : base(modulus) { }

        /// <summary>
        /// Perform factorization using the trial division method.
        /// </summary>
        /// <returns>A list of prime factors of the modulus.</returns>
        public override List<BigInteger> Factorize()
        {
            var factors = new List<BigInteger>();
            var n = modulus;

            // Start dividing by 2 to handle even numbers first
            while (n % 2 == 0)
            {
                factors.Add(BigInteger.Two);
                n /= 2;
            }

            // Check odd divisors from 3 upwards
            var divisor = BigInteger.Three;
            var sqrtN = n.Sqrt();
            while (divisor <= sqrtN)
            {
                while (n % divisor == 0)
                {
                    factors.Add(divisor);
                    n /= divisor;
                }
                divisor += 2;
                sqrtN = n.Sqrt();
            }

            // If n is still greater than 1, it must be prime
            if (n > 1) factors.Add(n);

            return factors;
        }
    }
}
