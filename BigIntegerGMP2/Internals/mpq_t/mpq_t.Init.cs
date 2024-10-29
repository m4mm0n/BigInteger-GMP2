using BigIntegerGMP2.Internals.mpir;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Internals.mpq_t
{
    /// <summary>
    /// Arbitrary precision rational number.
    /// </summary>
    public partial class mpq_t : IDisposable, IEquatable<mpq_t>, ICloneable, IConvertible, IComparable, IComparable<mpq_t>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="mpq_t"/> class.
        /// </summary>
        public mpq_t()
        {
            mpq.init(this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpq_t"/> class.
        /// </summary>
        /// <param name="other">The other instance.</param>
        public mpq_t(mpq_t other)
        {
            mpq.init(this);
            mpq.set(this, other);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpq_t"/> class.
        /// </summary>
        /// <param name="source">The source instance.</param>
        public mpq_t(mpf_t.mpf_t source)
        {
            mpq.init(this);
            mpq.set_f(this, source);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpq_t"/> class.
        /// </summary>
        /// <param name="source">The source instance.</param>
        public mpq_t(mpz_t.mpz_t source)
        {
            mpq.init(this);
            mpq.set_z(this, source);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpq_t"/> class.
        /// </summary>
        /// <param name="numerator">The numerator.</param>
        /// <param name="denominator">The denominator.</param>
        /// <param name="canonicalize">True if the new instance should use canonical numerator and denominator.</param>
        public mpq_t(ulong numerator, ulong denominator, bool canonicalize = false)
        {
            mpq.init(this);
            mpq.set_ui(this, numerator, denominator);

            if (canonicalize)
                mpq.canonicalize(this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpq_t"/> class.
        /// </summary>
        /// <param name="numerator">The numerator.</param>
        /// <param name="denominator">The denominator.</param>
        /// <param name="canonicalize">True if the new instance should use canonical numerator and denominator.</param>
        public mpq_t(long numerator, ulong denominator, bool canonicalize = false)
        {
            mpq.init(this);
            mpq.set_si(this, numerator, denominator);

            if (canonicalize)
                mpq.canonicalize(this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpq_t"/> class.
        /// </summary>
        /// <param name="op">The value.</param>
        public mpq_t(double op)
        {
            mpq.init(this);
            mpq.set_d(this, op);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpq_t"/> class.
        /// </summary>
        /// <param name="numerator">The numerator.</param>
        /// <param name="denominator">The denominator.</param>
        /// <param name="canonicalize">True if the new instance should use canonical numerator and denominator.</param>
        public mpq_t(mpz_t.mpz_t numerator, mpz_t.mpz_t denominator, bool canonicalize = false)
        {
            mpq.init(this);
            mpq.set_num(this, numerator);
            mpq.set_den(this, denominator);

            if (canonicalize)
                mpq.canonicalize(this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpq_t"/> class.
        /// </summary>
        /// <param name="text">The value text.</param>
        /// <param name="canonicalize">True if the new instance should use canonical numerator and denominator.</param>
        public mpq_t(string text, bool canonicalize = false)
            : this(text, mpz_t.mpz_t.DefaultBase, canonicalize)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpq_t"/> class.
        /// </summary>
        /// <param name="text">The value text.</param>
        /// <param name="strBase">The digit base.</param>
        /// <param name="canonicalize">True if the new instance should use canonical numerator and denominator.</param>
        public mpq_t(string text, int strBase, bool canonicalize = false)
        {
            mpq.init(this);

            var Success = mpq.set_str(this, text, strBase);
            if (!Success)
                throw new ArgumentException();

            if (canonicalize)
                mpq.canonicalize(this);
        }

        /// <summary>
        /// Creates an array of new instances of the <see cref="mpq_t"/> class.
        /// </summary>
        /// <param name="length">The array length.</param>
        public static mpq_t[] CreateArray(int length)
        {
            if (length >= MaxArrayLength)
                throw new ArgumentException(nameof(length));

            var Result = new mpq_t[length];
            for (var i = 0; i < Result.Length; i++)
                Result[i] = new mpq_t();

            ProcessArray(Result, (nint[] args) =>
            {
                var Index = 0;
                mpq_inits(args[Index++],
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

        /// <summary>
        /// Clear an array of numbers.
        /// </summary>
        /// <param name="array">The array.</param>
        public static void ClearArray(mpq_t[] array)
        {
            if (array.Length >= MaxArrayLength)
                throw new ArgumentException(nameof(array.Length));

            ProcessArray(array, (nint[] args) =>
            {
                var Index = 0;
                mpq_clears(args[Index++],
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

            foreach (var Item in array)
                Item.IsDisposed = true;
        }

#pragma warning disable SA1401 // Fields should be private
#pragma warning disable SA1600 // Elements should be documented
        internal __mpq_t Value;
#pragma warning restore SA1401 // Fields should be private
#pragma warning restore SA1600 // Elements should be documented
    }
}
