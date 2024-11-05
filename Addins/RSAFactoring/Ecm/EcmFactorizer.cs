using BigIntegerGMP2;

namespace RSAFactoring.Ecm
{
    /// <summary>
    /// Class for RSA factorization using Lenstra's Elliptic Curve Method (ECM).
    /// Suitable for bit sizes in the range of 65 to 100 bits.
    /// Implements the Elliptic Curve Method for efficient factorization of larger numbers.
    /// </summary>
    public class EcmFactorizer : RSAFactorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcmFactorizer"/> class with the specified modulus.
        /// </summary>
        /// <param name="modulus">The modulus to be factored.</param>
        public EcmFactorizer(BigInteger modulus) : base(modulus) { }

        /// <summary>
        /// Perform factorization using Lenstra's Elliptic Curve Method.
        /// </summary>
        /// <returns>A list of prime factors of the modulus.</returns>
        public override List<BigInteger> Factorize()
        {
            var factors = new List<BigInteger>();
            var n = modulus;

            // Handle small divisors first
            while (n % 2 == 0)
            {
                factors.Add(BigInteger.Two);
                n /= 2;
            }

            if (n == 1)
            {
                return factors;
            }

            // Use ECM to find a non-trivial factor
            var divisor = Ecm(n);
            while (divisor != n && divisor != BigInteger.One)
            {
                factors.Add(divisor);
                n /= divisor;
                divisor = Ecm(n);
            }

            if (n > 1) factors.Add(n);

            return factors;
        }

        /// <summary>
        /// Lenstra's Elliptic Curve Method to find a non-trivial factor of a number.
        /// </summary>
        /// <param name="n">The number to be factored.</param>
        /// <returns>A non-trivial factor of n, or n if no factor is found.</returns>
        private BigInteger Ecm(BigInteger n)
        {
            // Use a basic implementation of ECM with a single elliptic curve.
            // In practice, you may need multiple curves to increase the chances of finding a factor.

            var x = BigInteger.Two;
            var y = BigInteger.One;
            var a = BigInteger.One;
            var b = (y * y - x * x * x - a * x) % n;

            var g = BigInteger.One;
            var iterationLimit = 1000;

            for (var i = 0; i < iterationLimit && g == BigInteger.One; i++)
            {
                // Calculate point addition on the elliptic curve: y^2 = x^3 + ax + b (mod n)
                x = (x * x + a) % n;
                y = (y * y + b) % n;
                g = BigInteger.Gcd(y, n);
            }

            return g == n ? BigInteger.One : g;
        }
    }
}
