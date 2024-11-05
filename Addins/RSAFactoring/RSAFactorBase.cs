using BigIntegerGMP2;

namespace RSAFactoring
{
    /// <summary>
    /// Base class for RSA factorization tools.
    /// Provides common properties and methods for factoring operations.
    /// </summary>
    public abstract class RSAFactorBase
    {
        // The modulus we want to factor
        protected BigInteger modulus;

        // Constructor that accepts the modulus to be factored
        public RSAFactorBase(BigInteger modulus)
        {
            this.modulus = modulus ?? throw new ArgumentNullException(nameof(modulus));
            if (modulus <= 0)
                throw new ArgumentException("Modulus must be a positive integer.", nameof(modulus));
        }

        /// <summary>
        /// Abstract method for performing the factorization.
        /// Each subclass must implement this according to the algorithm it uses.
        /// </summary>
        /// <returns>A list of prime factors of the modulus.</returns>
        public abstract List<BigInteger> Factorize();

        /// <summary>
        /// Validates whether the given factors actually multiply back to the modulus.
        /// </summary>
        /// <param name="factors">A list of candidate factors.</param>
        /// <returns>True if the factors are valid, false otherwise.</returns>
        public bool ValidateFactors(List<BigInteger>? factors)
        {
            if (factors == null || factors.Count == 0)
                return false;

            var product = factors.Aggregate(BigInteger.One, (current, factor) => current * factor);
            return product == modulus;
        }

        /// <summary>
        /// Checks if the modulus is a prime number.
        /// </summary>
        /// <returns>True if the modulus is prime, otherwise false.</returns>
        public bool IsPrime() => BigInteger.IsProbablePrime(modulus, 40); // Miller-Rabin with 40 rounds as default
    }
}
