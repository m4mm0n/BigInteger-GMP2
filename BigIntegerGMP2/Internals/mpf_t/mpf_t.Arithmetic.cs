using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpf_t
{
    /// <summary>
    /// See http://mpir.org/mpir-3.0.0.pdf.
    /// </summary>
    public partial class mpf_t : IDisposable, IEquatable<mpf_t>, ICloneable, IConvertible, IComparable, IComparable<mpf_t>
    {
        /// <summary>
        /// Gets the absolute value of the number.
        /// </summary>
        public mpf_t Abs()
        {
            var z = new mpf_t();

            mpf.abs(z, this);

            return z;
        }

        /// <summary>
        /// Gets the value sign.
        /// </summary>
        public int Sign => mpf.sgn(this);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        public mpf_t Sqrt()
        {
            var Result = new mpf_t();

            mpf.sqrt(Result, this);

            return Result;
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="exp">The power.</param>
        public mpf_t Pow(ulong exp)
        {
            var Result = new mpf_t();

            mpf.pow_ui(Result, this, exp);

            return Result;
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value.</param>
        public static mpf_t Sqrt(ulong value)
        {
            var Result = new mpf_t();

            mpf.sqrt_ui(Result, value);

            return Result;
        }
    }
}
