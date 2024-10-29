using BigIntegerGMP2.Internals.mpir;
using System.Numerics;
using System.Text;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Internals.mpz_t
{
    /// <summary>
    /// Arbitrary precision integer.
    /// </summary>
    public partial class mpz_t : IDisposable, IEquatable<mpz_t>, ICloneable, IConvertible, IComparable, IComparable<mpz_t>
    {
        /// <summary>
        /// Gets the number bytes.
        /// </summary>
        public byte[] ToByteArray()
        {
            var SizeInBits = (ulong)mpz_sizeinbase(ref Value, 2);
            var Result = new byte[(SizeInBits + 7) / 8];

            mpz.export(Result, out var countp, -1, sizeof(byte), -1, 0UL, this);

            return Result;
        }

        /// <summary>
        /// Returns a string that represents the number value.
        /// </summary>
        /// <returns>The number value.</returns>
        public override string ToString() => ToString(DefaultBase);

        /// <summary>
        /// Returns a string that represents the number value.
        /// </summary>
        /// <param name="resultbase">The digit base used in the result.</param>
        /// <returns>The number value.</returns>
        public string ToString(int resultbase)
        {
            var SizeInDigits = mpz.sizeinbase(this, (uint)resultbase);

            var Data = new StringBuilder((int)(SizeInDigits + 2));
            mpz.get_str(Data, resultbase, this);

            var Result = Data.ToString();
            return Result;
        }

        /// <summary>
        /// Converts from a <see cref="byte"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpz_t(byte value) => new mpz_t((uint)value);

        /// <summary>
        /// Converts from a <see cref="int"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpz_t(int value) => new mpz_t(value);

        /// <summary>
        /// Converts from a <see cref="uint"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpz_t(uint value) => new mpz_t(value);

        /// <summary>
        /// Converts from a <see cref="short"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpz_t(short value) => new mpz_t(value);

        /// <summary>
        /// Converts from a <see cref="ushort"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpz_t(ushort value) => new mpz_t(value);

        /// <summary>
        /// Converts from a <see cref="long"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpz_t(long value) => new mpz_t(value);

        /// <summary>
        /// Converts from a <see cref="ulong"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpz_t(ulong value) => new mpz_t(value);

        /// <summary>
        /// Converts from a <see cref="float"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpz_t(float value) => new mpz_t((double)value);

        /// <summary>
        /// Converts from a <see cref="double"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpz_t(double value) => new mpz_t(value);

        /// <summary>
        /// Converts from a <see cref="System.Numerics.BigInteger"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpz_t(System.Numerics.BigInteger value) => new mpz_t(value);

        /// <summary>
        /// Converts to a <see cref="byte"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator byte(mpz_t value) => (byte)(uint)value;

        /// <summary>
        /// Converts to a <see cref="int"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator int(mpz_t value) => (int)mpz.get_si(value);

        /// <summary>
        /// Converts to a <see cref="uint"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator uint(mpz_t value) => (uint)mpz.get_ui(value);

        /// <summary>
        /// Converts to a <see cref="short"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator short(mpz_t value) => (short)(int)value;

        /// <summary>
        /// Converts to a <see cref="ushort"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator ushort(mpz_t value) => (ushort)(uint)value;

        /// <summary>
        /// Converts to a <see cref="long"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator long(mpz_t value)
        {
            if (mpz.cmp_si(value, long.MinValue) < 0 || mpz.cmp_si(value, long.MaxValue) > 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            var Bytes = new byte[8];
            mpz.export(Bytes, out _, -1, sizeof(byte), -1, 0, value);

            var Int64Result = BitConverter.ToInt64(Bytes, 0);
            if (mpz.cmp_si(value, 0) < 0)
                Int64Result = -Int64Result;

            return Int64Result;
        }

        /// <summary>
        /// Converts to a <see cref="ulong"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator ulong(mpz_t value)
        {
            if (mpz.cmp_ui(value, 0) < 0 || mpz.cmp_ui(value, ulong.MaxValue) > 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            var Bytes = new byte[8];
            mpz.export(Bytes, out _, -1, sizeof(byte), -1, 0, value);

            var UInt64Result = BitConverter.ToUInt64(Bytes, 0);

            return UInt64Result;
        }

        /// <summary>
        /// Converts to a <see cref="float"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator float(mpz_t value) => (float)(double)value;

        /// <summary>
        /// Converts to a <see cref="double"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator double(mpz_t value) => mpz.get_d(value);

        /// <summary>
        /// Converts to a <see cref="System.Numerics.BigInteger"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator BigInteger(mpz_t value)
        {
            var Bytes = value.ToByteArray();

            var Result = new System.Numerics.BigInteger(Bytes);
            return Result;
        }
    }
}
