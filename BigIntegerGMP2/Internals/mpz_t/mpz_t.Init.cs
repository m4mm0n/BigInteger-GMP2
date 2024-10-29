using BigIntegerGMP2.Internals.mpir;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Internals.mpz_t
{
    /// <summary>
    /// Arbitrary precision integer.
    /// </summary>
    public partial class mpz_t : IDisposable, IEquatable<mpz_t>, ICloneable, IConvertible, IComparable, IComparable<mpz_t>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        public mpz_t()
        {
            mpz.init(this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="other">The other number.</param>
        public mpz_t(mpz_t other)
        {
            mpz.init_set(this, other);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        public mpz_t(uint op)
        {
            mpz.init_set_ui(this, op);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        public mpz_t(int op)
        {
            mpz.init_set_si(this, op);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        public mpz_t(ulong op)
        {
            mpz.init_set_ux(this, op);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        public mpz_t(long op)
        {
            mpz.init_set_sx(this, op);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        public mpz_t(double op)
        {
            mpz.init_set_d(this, op);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="text">The number text.</param>
        public mpz_t(string text)
            : this(text, DefaultBase)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="text">The number text.</param>
        /// <param name="strBase">The digit base.</param>
        public mpz_t(string text, uint strBase)
        {
            var Success = mpz.init_set_str(this, text, strBase);
            if (!Success)
                throw new ArgumentException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        public mpz_t(BigInteger op)
            : this(op.ToByteArray())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="size">The count of bits.</param>
        public mpz_t(bitcount_t size)
        {
            mpz.init2(this, size.Count);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="bytes">The number raw bytes.</param>
        public mpz_t(byte[] bytes)
            : this()
        {
            mpz.import(this, (ulong)bytes.LongLength, -1, sizeof(byte), -1, 0UL, bytes);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        internal mpz_t(__mpz_t value)
        {
            mpz_init_set(ref Value, ref value);
        }

        /// <summary>
        /// Creates an array of new instances of the <see cref="mpz_t"/> class.
        /// </summary>
        /// <param name="length">The array length.</param>
        public static mpz_t[] CreateArray(int length)
        {
            if (length >= MaxArrayLength)
                throw new ArgumentException(nameof(length));

            var Result = new mpz_t[length];
            for (var i = 0; i < Result.Length; i++)
                Result[i] = new mpz_t();

            ProcessArray(Result, (nint[] args) =>
            {
                var Index = 0;
                mpz_inits(args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++],
                          args[Index++]);
            });

            return Result;
        }

#pragma warning disable SA1401 // Fields should be private
#pragma warning disable SA1600 // Elements should be documented
        internal __mpz_t Value;
#pragma warning restore SA1401 // Fields should be private
#pragma warning restore SA1600 // Elements should be documented
    }
}
