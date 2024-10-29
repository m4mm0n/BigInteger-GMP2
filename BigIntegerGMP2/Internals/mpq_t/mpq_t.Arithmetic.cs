using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpq_t
{
    /// <summary>
    /// Arbitrary precision rational number.
    /// </summary>
    public partial class mpq_t : IDisposable, IEquatable<mpq_t>, ICloneable, IConvertible, IComparable, IComparable<mpq_t>
    {
        /// <summary>
        /// Gets the absolute value of the number.
        /// </summary>
        public mpq_t Abs()
        {
            var z = new mpq_t();

            mpq.abs(z, this);

            return z;
        }

        /// <summary>
        /// Gets the inverse of the number.
        /// </summary>
        public mpq_t Inverse()
        {
            var z = new mpq_t();

            mpq.inv(z, this);

            return z;
        }
    }
}
