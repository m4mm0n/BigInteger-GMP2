using BigIntegerGMP2;

namespace RSAFactoring.PollardsRho
{
    /// <summary>
    /// Class for RSA factorization using Pollard's Rho method.
    /// Suitable for mid-range bit sizes (e.g., 33 to 64 bits).
    /// Implements Pollard's Rho algorithm, including Brent's cycle detection optimization for faster convergence.
    /// </summary>
    public class PollardsRhoFactorizer : RSAFactorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PollardsRhoFactorizer"/> class with the specified modulus.
        /// </summary>
        /// <param name="modulus">The modulus to be factored.</param>
        public PollardsRhoFactorizer(BigInteger modulus) : base(modulus) { }

        /// <summary>
        /// Perform factorization using Pollard's Rho method with Brent's modification.
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
                return factors;

            // Use Pollard's Rho to find a non-trivial factor
            var divisor = PollardsRhoWithBrent(n);
            while (divisor != n && divisor != BigInteger.One)
            {
                factors.Add(divisor);
                n /= divisor;
                divisor = PollardsRhoWithBrent(n);
            }

            if (n > 1) factors.Add(n);

            return factors;
        }

        /// <summary>
        /// Pollard's Rho algorithm with Brent's modification to find a non-trivial factor.
        /// </summary>
        /// <param name="n">The number to be factored.</param>
        /// <returns>A non-trivial factor of n.</returns>
        private BigInteger PollardsRhoWithBrent(BigInteger n)
        {
            if (n.IsEven())
                return BigInteger.Two;

            var y = BigInteger.Two;
            var c = BigInteger.One;
            var m = BigInteger.One;

            var g = BigInteger.One;
            var r = BigInteger.One;
            var q = BigInteger.One;

            var x = y;
            var ys = y;

            while (g == BigInteger.One)
            {
                x = y;
                for (var i = BigInteger.Zero; i < r; i++) y = (y * y + c) % n;

                var k = BigInteger.Zero;
                while (k < r && g == BigInteger.One)
                {
                    ys = y;
                    for (var i = BigInteger.Zero; i < BigInteger.Min(m, r - k); i++)
                    {
                        y = (y * y + c) % n;
                        q = q * BigInteger.Abs(x - y) % n;
                    }
                    g = BigInteger.Gcd(q, n);
                    k += m;
                }
                r *= 2;
            }

            if (g == n)
                do
                {
                    ys = (ys * ys + c) % n;
                    g = BigInteger.Gcd(BigInteger.Abs(x - ys), n);
                } while (g == BigInteger.One);

            return g;
        }
    }
}
