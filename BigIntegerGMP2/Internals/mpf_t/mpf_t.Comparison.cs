using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpf_t
{
    /// <summary>
    /// See http://mpir.org/mpir-3.0.0.pdf.
    /// </summary>
    public partial class mpf_t : IDisposable, IEquatable<mpf_t>, ICloneable, IConvertible, IComparable, IComparable<mpf_t>
    {
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="other">The compared value.</param>
        public int CompareTo(mpf_t? other) => ReferenceEquals(other, null) ? throw new ArgumentNullException(nameof(other)) : mpf.cmp(this, other);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="other">The compared value.</param>
        public int CompareTo(long other) => mpf.cmp_si(this, other);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="other">The compared value.</param>
        public int CompareTo(ulong other) => mpf.cmp_ui(this, other);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="other">The compared value.</param>
        public int CompareTo(float other) => mpf.cmp_d(this, (double)other);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="other">The compared value.</param>
        public int CompareTo(double other) => mpf.cmp_d(this, other);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="bitcount">The number of bits.</param>
        public static bool EqualBits(mpf_t x, mpf_t y, ulong bitcount) => mpf.eq(x, y, bitcount) != 0;

        /// <summary>
        /// Returns the relative difference between two numbers.
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        public static mpf_t RelativeDifference(mpf_t x, mpf_t y)
        {
            mpf_t z = new();

            mpf.reldiff(z, x, y);

            return z;
        }
    }
}
