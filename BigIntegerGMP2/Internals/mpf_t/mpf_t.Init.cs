using BigIntegerGMP2.Internals.mpir;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Internals.mpf_t
{
    /// <summary>
    /// See http://mpir.org/mpir-3.0.0.pdf.
    /// </summary>
    public partial class mpf_t : IDisposable, IEquatable<mpf_t>, ICloneable, IConvertible, IComparable, IComparable<mpf_t>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="mpf_t"/> class.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="precision">The precision.</param>
        public mpf_t(ulong precision = ulong.MaxValue)
        {
            if (precision == ulong.MaxValue)
                mpf.init(this);
            else
                mpf.init2(this, precision);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpf_t"/> class.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="n">The value.</param>
        /// <param name="precision">The precision.</param>
        public mpf_t(ulong n, ulong precision)
        {
            if (precision == ulong.MaxValue)
                mpf.init_set_ui(this, n);
            else
            {
                mpf.init2(this, precision);
                mpf.set_ui(this, n);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpf_t"/> class.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="n">The value.</param>
        /// <param name="precision">The precision.</param>
        public mpf_t(long n, ulong precision = ulong.MaxValue)
        {
            if (precision == ulong.MaxValue)
                mpf.init_set_si(this, n);
            else
            {
                mpf.init2(this, precision);
                mpf.set_si(this, n);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpf_t"/> class.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="d">The value.</param>
        /// <param name="precision">The precision.</param>
        public mpf_t(double d, ulong precision = ulong.MaxValue)
        {
            if (precision == ulong.MaxValue)
                mpf.init_set_d(this, d);
            else
            {
                mpf.init2(this, precision);
                mpf.set_d(this, d);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpf_t"/> class.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="s">The value.</param>
        /// <param name="precision">The precision.</param>
        public mpf_t(string s, ulong precision = ulong.MaxValue)
            : this(s, mpz_t.mpz_t.DefaultBase, precision)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpf_t"/> class.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="s">The value.</param>
        /// <param name="strBase">The base.</param>
        /// <param name="precision">The precision.</param>
        public mpf_t(string s, uint strBase, ulong precision = ulong.MaxValue)
        {
            int Success;

            if (precision == ulong.MaxValue)
                Success = mpf.init_set_str(this, s, strBase);
            else
            {
                mpf.init2(this, precision);
                Success = mpf.set_str(this, s, strBase);
            }

            if (Success != 0)
                throw new ArgumentException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpf_t"/> class.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="other">The value.</param>
        /// <param name="useDefaultPrecision">True to use the default precision.</param>
        public mpf_t(mpf_t other, bool useDefaultPrecision = false)
        {
            if (useDefaultPrecision)
            {
                mpf.init_set(this, other);
            }
            else
            {
                mpf.init2(this, mpf.get_prec(other));
                mpf.set(this, other);
            }
        }

        /// <summary>
        /// Sets the exact precision.
        /// </summary>
        /// <param name="value">The precision.</param>
        public void SetPrecisionRaw(ulong value)
        {
            mpf.set_prec_raw(this, value);
        }

        /// <summary>
        /// Sets the value from an integer.
        /// </summary>
        /// <param name="value">The integer.</param>
        public void Set(mpz_t.mpz_t value)
        {
            mpf.set_z(this, value);
        }

        /// <summary>
        /// Sets the value from a rational.
        /// </summary>
        /// <param name="value">The rational.</param>
        public void Set(mpq_t.mpq_t value)
        {
            mpf.set_q(this, value);
        }

        /// <summary>
        /// Swaps two numbers.
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        public static void Swap(mpf_t x, mpf_t y)
        {
            mpf.swap(x, y);
        }

#pragma warning disable SA1401 // Fields should be private
#pragma warning disable SA1600 // Elements should be documented
        internal __mpf_t Value;
#pragma warning restore SA1401 // Fields should be private
#pragma warning restore SA1600 // Elements should be documented
    }
}
