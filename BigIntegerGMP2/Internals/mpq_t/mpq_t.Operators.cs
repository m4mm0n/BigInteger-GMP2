using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpq_t
{
    /// <summary>
    /// Arbitrary precision rational number.
    /// </summary>
    public partial class mpq_t : IDisposable, IEquatable<mpq_t>, ICloneable, IConvertible, IComparable, IComparable<mpq_t>
    {
        /// <summary>
        /// Adds two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpq_t operator +(mpq_t x, mpq_t y)
        {
            var z = new mpq_t();

            mpq.add(z, x, y);

            return z;
        }

        /// <summary>
        /// Subtracts two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpq_t operator -(mpq_t x, mpq_t y)
        {
            var z = new mpq_t();

            mpq.sub(z, x, y);

            return z;
        }

        /// <summary>
        /// Multiplies two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpq_t operator *(mpq_t x, mpq_t y)
        {
            var z = new mpq_t();

            mpq.mul(z, x, y);

            return z;
        }

        /// <summary>
        /// Shifts a number to the left.
        /// </summary>
        /// <param name="x">The operand.</param>
        /// <param name="count">The number of bits to shift.</param>
        public static mpq_t operator <<(mpq_t x, int count)
        {
            var z = new mpq_t();

            if (count >= 0)
                mpq.mul_2exp(z, x, (ulong)count);

            return z;
        }

        /// <summary>
        /// Shifts a number to the right.
        /// </summary>
        /// <param name="x">The operand.</param>
        /// <param name="count">The number of bits to shift.</param>
        public static mpq_t operator >>(mpq_t x, int count)
        {
            var z = new mpq_t();

            if (count >= 0)
                mpq.div_2exp(z, x, (ulong)count);

            return z;
        }

        /// <summary>
        /// Negates a number.
        /// </summary>
        /// <param name="x">The number.</param>
        public static mpq_t operator -(mpq_t x)
        {
            var z = new mpq_t();

            mpq.neg(z, x);

            return z;
        }

        /// <summary>
        /// Divides two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpq_t operator /(mpq_t x, mpq_t y)
        {
            var z = new mpq_t();

            mpq.div(z, x, y);

            return z;
        }

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpq_t x, mpq_t y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpq_t x, mpq_t y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpq_t x, mpq_t y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpq_t x, mpq_t y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpq_t x, mpq_t y) => x.IsEqualTo(y);

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpq_t x, mpq_t y) => !x.IsEqualTo(y);

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpq_t x, mpz_t.mpz_t y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpq_t x, mpz_t.mpz_t y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpq_t x, mpz_t.mpz_t y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpq_t x, mpz_t.mpz_t y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpq_t x, mpz_t.mpz_t y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpq_t x, mpz_t.mpz_t y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object..</param>
        public override bool Equals(object? obj) => obj is mpq_t other && IsEqualTo(other);

        /// <summary>
        /// Gets the hash of the object.
        /// </summary>
        public override int GetHashCode()
        {
            using mpz_t.mpz_t Numerator = new();
            mpq.get_num(Numerator, this);

            using mpz_t.mpz_t Denominator = new();
            mpq.get_den(Denominator, this);

            return Numerator.GetHashCode() ^ Denominator.GetHashCode();
        }
    }
}
