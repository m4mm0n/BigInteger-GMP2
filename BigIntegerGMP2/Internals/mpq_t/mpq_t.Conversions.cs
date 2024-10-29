using BigIntegerGMP2.Internals.mpir;
using System.Text;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Internals.mpq_t
{
    /// <summary>
    /// Arbitrary precision rational number.
    /// </summary>
    public partial class mpq_t : IDisposable, IEquatable<mpq_t>, ICloneable, IConvertible, IComparable, IComparable<mpq_t>
    {
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString() => ToString(mpz_t.mpz_t.DefaultBase);

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <param name="resultbase">The digit base.</param>
        public string ToString(int resultbase)
        {
            using mpz_t.mpz_t Numerator = new();
            mpq.get_num(Numerator, this);

            using mpz_t.mpz_t Denominator = new();
            mpq.get_den(Denominator, this);

            var SizeInDigits = (ulong)mpz_sizeinbase(ref Numerator.Value, (uint)resultbase) + (ulong)mpz_sizeinbase(ref Denominator.Value, (uint)resultbase);

            var Data = new StringBuilder((int)(SizeInDigits + 3));
            mpq.get_str(Data, resultbase, this);

            var Result = Data.ToString();
            return Result;
        }

        /// <summary>
        /// Converts from a <see cref="float"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpq_t(float value) => new mpq_t((double)value);

        /// <summary>
        /// Converts from a <see cref="double"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpq_t(double value) => new mpq_t(value);

        /// <summary>
        /// Converts to a <see cref="float"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator float(mpq_t value) => (float)(double)value;

        /// <summary>
        /// Converts to a <see cref="double"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator double(mpq_t value) => mpq.get_d(value);
    }
}
