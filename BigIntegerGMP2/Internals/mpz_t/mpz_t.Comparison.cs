using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpz_t
{
    /// <summary>
    /// Arbitrary precision integer.
    /// </summary>
    public partial class mpz_t : IDisposable, IEquatable<mpz_t>, ICloneable, IConvertible, IComparable, IComparable<mpz_t>
    {
        /// <summary>
        /// Compares with another number.
        /// </summary>
        /// <param name="other">The other number.</param>
        public int CompareTo(mpz_t? other) => ReferenceEquals(other, null) ? throw new ArgumentNullException(nameof(other)) : mpz.cmp(this, other);

        /// <summary>
        /// Compares with another number.
        /// </summary>
        /// <param name="other">The other number.</param>
        public int CompareTo(long other) => mpz.cmp_si(this, other);

        /// <summary>
        /// Compares with another number.
        /// </summary>
        /// <param name="other">The other number.</param>
        public int CompareTo(ulong other) => mpz.cmp_ui(this, other);

        /// <summary>
        /// Compares with another number.
        /// </summary>
        /// <param name="other">The other number.</param>
        public int CompareTo(float other) => mpz.cmp_d(this, other);

        /// <summary>
        /// Compares with another number.
        /// </summary>
        /// <param name="other">The other number.</param>
        public int CompareTo(double other) => mpz.cmp_d(this, other);
    }
}
