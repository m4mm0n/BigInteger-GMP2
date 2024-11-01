using System.Text;
using BigIntegerGMP2.Internals.mpfr;
using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        /// <summary>
        /// Gets the number of bits of the current BigInteger value.
        /// </summary>
        /// <returns>The number of bits of the BigInteger value in binary.</returns>
        /// <exception cref="Exception">Thrown if the bit length cannot be determined.</exception>
        public int BitLength()
        {
            try
            {
                return (int)mpz.sizeinbase(_value, 2);
            }
            catch (Exception e)
            {
                throw new Exception("Failed to get bit length", e);
            }
        }

        /// <summary>
        /// Converts a non-negative BigInteger to its Base-64 string representation.
        /// </summary>
        /// <param name="bigInteger">The BigInteger to convert.</param>
        /// <returns>A Base-64 string representation of the BigInteger.</returns>
        /// <exception cref="ArgumentException">Thrown if the input BigInteger is negative.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if an invalid character index is encountered during conversion.</exception>
        public static string ConvertToBase64(BigInteger bigInteger)
        {
            if (bigInteger < 0)
                throw new ArgumentException("Only non-negative numbers can be converted to Base-64.");

            if (bigInteger == 0)
                return "A===";  // Representing 0 as "A===" in Base-64 with padding

            var result = new StringBuilder();
            var base64 = new BigInteger(64);
            var zero = new BigInteger(0);

            while (bigInteger > zero)
            {
                var remainder = bigInteger % base64;
                bigInteger /= base64;

                var index = (int)remainder.ToInt64();
                if (index < 0 || index >= Base64Chars.Length)
                    throw new ArgumentOutOfRangeException($"Invalid character index: {index} for Base-64.");

                result.Insert(0, Base64Chars[index]); // Convert remainder to Base-64 character
            }

            // Calculate padding required to make the output length a multiple of 4
            var paddingLength = (4 - (result.Length % 4)) % 4;
            result.Append('=', paddingLength); // Add '=' padding as needed

            return result.ToString();
        }

        /// <summary>
        /// Converts a Base-64 string representation to a BigInteger.
        /// </summary>
        /// <param name="base64String">The Base-64 string to convert.</param>
        /// <returns>A BigInteger representing the converted value of the Base-64 string.</returns>
        /// <exception cref="ArgumentException">Thrown if the input string is null, empty, or contains invalid characters.</exception>
        public static BigInteger ConvertFromBase64(string base64String)
        {
            // Validate the Base64 string
            if (string.IsNullOrEmpty(base64String))
                throw new ArgumentException("Input string cannot be null or empty.");

            // Remove any padding characters ('=')
            base64String = base64String.TrimEnd('=');

            var result = new BigInteger(0);
            var base64 = new BigInteger(64);

            foreach (var c in base64String)
            {
                var index = Base64Chars.IndexOf(c);
                if (index < 0)
                    throw new ArgumentException($"Invalid character '{c}' in Base-64 string.");

                result = result * base64 + new BigInteger(index);
            }

            return result;
        }

        /// <summary>
        /// Gets the radix (or base) value for the specified base format.
        /// </summary>
        /// <param name="format">The base format for which to retrieve the radix.</param>
        /// <returns>The radix value corresponding to the specified base format.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the base format is not supported.</exception>
        public static uint GetRadix(BaseFormat format) =>
            format switch
            {
                BaseFormat.Base2 => 2,
                BaseFormat.Base8 => 8,
                BaseFormat.Base10 => 10,
                BaseFormat.Base16 => 16,
                BaseFormat.Base32 => 32,
                BaseFormat.Base64 => 64,
                _ => throw new ArgumentOutOfRangeException(nameof(format), format, null)
            };

        /// <summary>
        /// Computes a hash code for the current BigInteger instance.
        /// </summary>
        /// <returns>An integer representing the hash code of the current instance.</returns>
        public override int GetHashCode()
        {
            var hash = 0u;
            var bytes = ToByteArray(false);
            var len = bytes.Length;
            var shift = 0;
            for (var i = 0; i < len; i++)
            {
                hash ^= (uint)(bytes[i] << shift);
                shift = (shift + 8) & 0x1F;
            }
            return (int)hash;
        }

        /// <summary>
        /// Finds the index of the first bit set to 1 starting from a specified bit index.
        /// </summary>
        /// <param name="startingIndex">The bit index from which to start searching.</param>
        /// <returns>An integer representing the index of the first bit set to 1, or -1 if no such bit is found.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the starting index is negative.</exception>
        public int IndexOfOne(int startingIndex) =>
            startingIndex < 0
                ? throw new ArgumentOutOfRangeException()
                : (int)mpz.scan1(this, (uint)startingIndex);

        /// <summary>
        /// Finds the index of the first bit set to 0 starting from a specified bit index.
        /// </summary>
        /// <param name="startingIndex">The bit index from which to start searching.</param>
        /// <returns>An integer representing the index of the first bit set to 0, or -1 if no such bit is found.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the starting index is negative.</exception>
        public int IndexOfZero(int startingIndex) =>
            startingIndex < 0
                ? throw new ArgumentOutOfRangeException()
                : (int)mpz.scan0(this, (uint)startingIndex);

    }
}
