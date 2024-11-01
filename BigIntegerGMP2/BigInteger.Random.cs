using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        /// <summary>
        /// Generates a random BigInteger with a specified bit length.
        /// </summary>
        /// <param name="bitLength">The bit length of the BigInteger to generate.</param>
        /// <returns>A random BigInteger of the specified bit length.</returns>
        /// <exception cref="ArgumentException">Thrown if the bit length is not positive.</exception>
        public static BigInteger Random(int bitLength)
        {
            if (bitLength <= 0)
                throw new ArgumentException("bitLength must be a positive integer.");

            var z = new BigInteger();
            mpz.urandomb(z._value, _randState, (uint)bitLength);
            return z;
        }

        /// <summary>
        /// Generates a random BigInteger with a bit length between the specified minimum and maximum values.
        /// </summary>
        /// <param name="minBitLength">The minimum bit length of the BigInteger to generate.</param>
        /// <param name="maxBitLength">The maximum bit length of the BigInteger to generate.</param>
        /// <returns>A random BigInteger with a bit length between the specified values.</returns>
        /// <exception cref="ArgumentException">Thrown if either bit length is not positive, or if the minimum bit length is greater than the maximum bit length.</exception>
        public static BigInteger Random(int minBitLength, int maxBitLength)
        {
            if (minBitLength <= 0 || maxBitLength <= 0)
                throw new ArgumentException("bitLength must be a positive integer.");

            if (minBitLength > maxBitLength)
                throw new ArgumentException("minBitLength must be less than or equal to maxBitLength.");

            var bitLength = (int)gmp.urandomm_ui(_randState, (uint)(maxBitLength - minBitLength)) + minBitLength;
            return Random(bitLength);
        }

        /// <summary>
        /// Generates a random BigInteger within the specified range.
        /// </summary>
        /// <param name="min">The inclusive lower bound of the range.</param>
        /// <param name="max">The exclusive upper bound of the range.</param>
        /// <returns>A random BigInteger within the specified range.</returns>
        /// <exception cref="ArgumentException">Thrown if the minimum value is greater than or equal to the maximum value.</exception>
        public static BigInteger Random(BigInteger min, BigInteger max)
        {
            if (min >= max)
                throw new ArgumentException("min must be less than max.");

            var range = max - min;
            var z = new BigInteger();
            mpz.urandomm(z._value, _randState, range._value);
            return min + z;
        }

    }
}
