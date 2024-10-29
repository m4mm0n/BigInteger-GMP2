using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpq_t
{
    /// <summary>
    /// Arbitrary precision rational number.
    /// </summary>
    public partial class mpq_t : IDisposable, IEquatable<mpq_t>, ICloneable, IConvertible, IComparable, IComparable<mpq_t>
    {
        /// <summary>
        /// Compares with another number.
        /// </summary>
        /// <param name="other">The other number.</param>
        public int CompareTo(mpq_t? other) => ReferenceEquals(other, null) ? throw new ArgumentNullException(nameof(other)) : mpq.cmp(this, other);

        /// <summary>
        /// Compares with another number.
        /// </summary>
        /// <param name="other">The other number.</param>
        public int CompareTo(mpz_t.mpz_t other) => mpq.cmp_z(this, other);

        /// <summary>
        /// Compares with another number.
        /// </summary>
        /// <param name="other">The other number.</param>
        public bool IsEqualTo(mpq_t other) => mpq.equal(this, other);
    }
}
