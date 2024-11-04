using BigIntegerGMP2.Internals;
using BigIntegerGMP2.Internals.mpir;
using BigIntegerGMP2.Internals.mpz_t;

namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        /// <summary>
        /// Static constructor for the BigInteger class. Initializes random number generators.
        /// </summary>
        static BigInteger()
        {
            _randState = randstate_t.Create();
            gmp.randinit_mt(_randState);
            _sysRand = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the BigInteger class with a value of zero.
        /// </summary>
        public BigInteger() => _value = new mpz_t();

        /// <summary>
        /// Initializes a new instance of the BigInteger class with the specified mpz_t value.
        /// </summary>
        /// <param name="value">The mpz_t value to initialize with.</param>
        public BigInteger(mpz_t value) => _value = new mpz_t(value);

        /// <summary>
        /// Initializes a new instance of the BigInteger class by copying another BigInteger value.
        /// </summary>
        /// <param name="value">The BigInteger value to copy.</param>
        public BigInteger(BigInteger value) => _value = new mpz_t(value._value);

        /// <summary>
        /// Initializes a new instance of the BigInteger class from a byte array.
        /// </summary>
        /// <param name="value">The byte array representing the value to initialize.</param>
        public BigInteger(byte[] value) => _value = new mpz_t(value);

        /// <summary>
        /// Initializes a new instance of the BigInteger class with the specified integer value.
        /// </summary>
        /// <param name="value">The integer value to initialize with.</param>
        public BigInteger(int value) => _value = new mpz_t(value);

        /// <summary>
        /// Initializes a new instance of the BigInteger class with the specified long value.
        /// </summary>
        /// <param name="value">The long value to initialize with.</param>
        public BigInteger(long value) => _value = new mpz_t(value);

        /// <summary>
        /// Initializes a new instance of the BigInteger class with the specified unsigned integer value.
        /// </summary>
        /// <param name="value">The unsigned integer value to initialize with.</param>
        public BigInteger(uint value) => _value = new mpz_t(value);

        /// <summary>
        /// Initializes a new instance of the BigInteger class with the specified unsigned long value.
        /// </summary>
        /// <param name="value">The unsigned long value to initialize with.</param>
        public BigInteger(ulong value) => _value = new mpz_t(value);

        /// <summary>
        /// Initializes a new instance of the BigInteger class with the specified double value.
        /// </summary>
        /// <param name="value">The double value to initialize with.</param>
        public BigInteger(double value) => _value = new mpz_t(value);

        /// <summary>
        /// Initializes a new instance of the BigInteger class with the specified float value.
        /// </summary>
        /// <param name="value">The float value to initialize with.</param>
        public BigInteger(float value) => _value = new mpz_t(value);

        /// <summary>
        /// Initializes a new instance of the BigInteger class with the specified string value.
        /// </summary>
        /// <param name="value">The string representing the value to initialize.</param>
        public BigInteger(string value) => _value = new mpz_t(value);

        /// <summary>
        /// Initializes a new instance of the BigInteger class with the specified string value and radix.
        /// </summary>
        /// <param name="value">The string representing the value to initialize.</param>
        /// <param name="radix">The radix (base) of the value string.</param>
        public BigInteger(string value, int radix) => _value = new mpz_t(value, (uint)radix);

        /// <summary>
        /// Initializes a new instance of the BigInteger class with the specified string value and base format.
        /// </summary>
        /// <param name="value">The string representing the value to initialize.</param>
        /// <param name="format">The base format of the value string.</param>
        public BigInteger(string value, BaseFormat format) => _value = new mpz_t(value, GetRadix(format));

        /// <summary>
        /// Initializes a new instance of the BigInteger class with a random value of a specified bit length.
        /// </summary>
        /// <param name="numBits">The number of bits for the random value.</param>
        /// <param name="rand">The random number generation algorithm to use.</param>
        public BigInteger(int numBits, RngAlgorithm rand)
        {
            _value = new mpz_t();
            _randState = randstate_t.Create(rand);

            if (numBits > 0) mpz.urandomb(_value, _randState, (uint)numBits);
        }

        /// <summary>
        /// Initializes a new instance of the BigInteger class from a uint array.
        /// </summary>
        /// <param name="value">The uint array representing the value to initialize.</param>
        public BigInteger(uint[] value)
        {
            try
            {
                var byteArray = new byte[value.Length * sizeof(uint)];
                Buffer.BlockCopy(value, 0, byteArray, 0, byteArray.Length);

                _value = new mpz_t(byteArray);
            }
            catch (Exception ex)
            {
                throw new FormatException("The value is not in a valid format.", ex);
            }
        }

        /// <summary>
        /// Initializes a new instance of the BigInteger class from an int array.
        /// </summary>
        /// <param name="value">The int array representing the value to initialize.</param>
        public BigInteger(int[] value)
        {
            try
            {
                var byteArray = new byte[value.Length * sizeof(int)];
                Buffer.BlockCopy(value, 0, byteArray, 0, byteArray.Length);

                _value = new mpz_t(byteArray);
            }
            catch (Exception ex)
            {
                throw new FormatException("The value is not in a valid format.", ex);
            }
        }
    }
}
