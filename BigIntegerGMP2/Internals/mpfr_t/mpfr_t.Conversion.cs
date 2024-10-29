using System.Numerics;
using static BigIntegerGMP2.Native.Mpfr.NativeMethods;

namespace BigIntegerGMP2.Internals.mpfr_t
{
    /// <summary>
    /// Represents an arbitrary precision floating-point number.
    /// </summary>
    public partial class mpfr_t : IDisposable
    {
        /// <summary>
        /// Converts from a <see cref="byte"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpfr_t(byte value) => new mpfr_t((uint)value);

        /// <summary>
        /// Converts from a <see cref="int"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpfr_t(int value) => new mpfr_t(value);

        /// <summary>
        /// Converts from a <see cref="uint"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpfr_t(uint value) => new mpfr_t(value);

        /// <summary>
        /// Converts from a <see cref="short"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpfr_t(short value) => new mpfr_t(value);

        /// <summary>
        /// Converts from a <see cref="ushort"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpfr_t(ushort value) => new mpfr_t(value);

        /// <summary>
        /// Converts from a <see cref="long"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpfr_t(long value) => new mpfr_t(value);

        /// <summary>
        /// Converts from a <see cref="ulong"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpfr_t(ulong value) => new mpfr_t(value);

        /// <summary>
        /// Converts from a <see cref="float"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpfr_t(float value) => new mpfr_t((double)value);

        /// <summary>
        /// Converts from a <see cref="double"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpfr_t(double value) => new mpfr_t(value);

        /// <summary>
        /// Converts from a <see cref="System.Numerics.BigInteger"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpfr_t(System.Numerics.BigInteger value)
        {
            using var Temporary = new mpz_t.mpz_t(value);
            return new mpfr_t(Temporary);
        }

        /// <summary>
        /// Converts to a <see cref="byte"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator byte(mpfr_t value) => (byte)(uint)value;

        /// <summary>
        /// Converts to a <see cref="int"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator int(mpfr_t value) => mpfr_get_sj(ref value.Value, (__mpfr_rnd_t)value.Rounding);

        /// <summary>
        /// Converts to a <see cref="uint"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator uint(mpfr_t value) => mpfr_get_uj(ref value.Value, (__mpfr_rnd_t)value.Rounding);

        /// <summary>
        /// Converts to a <see cref="short"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator short(mpfr_t value) => (short)(int)value;

        /// <summary>
        /// Converts to a <see cref="ushort"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator ushort(mpfr_t value) => (ushort)(uint)value;

        /// <summary>
        /// Converts to a <see cref="long"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator long(mpfr_t value) => mpfr.mpfr.get_si(value, value.Rounding);

        /// <summary>
        /// Converts to a <see cref="ulong"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator ulong(mpfr_t value) => mpfr.mpfr.get_ui(value, value.Rounding);

        /// <summary>
        /// Converts to a <see cref="float"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator float(mpfr_t value) => mpfr.mpfr.get_flt(value, value.Rounding);

        /// <summary>
        /// Converts to a <see cref="double"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator double(mpfr_t value) => mpfr.mpfr.get_d(value, value.Rounding);

        /// <summary>
        /// Converts to a <see cref="System.Numerics.BigInteger"/> value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static explicit operator BigInteger(mpfr_t value)
        {
            using var Temporary = new mpz_t.mpz_t();

            mpfr.mpfr.get_z(Temporary, value, value.Rounding);

            var Result = (System.Numerics.BigInteger)Temporary;
            return Result;
        }

        /// <summary>
        /// Converts to a <see cref="double"/> value and exponent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="d">The double upon return.</param>
        /// <param name="e">The exponent upon return.</param>
        public static void ToDoubleAndExponent(mpfr_t value, out double d, out int e)
        {
            d = mpfr.mpfr.get_d_2exp(out e, value, value.Rounding);
        }

        /// <summary>
        /// Convert to integral and fractional parts.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="e">The exponent upon return.</param>
        public static mpfr_t ToIntegralFractional(mpfr_t value, out int e)
        {
            mpfr_t y = new();

            mpfr.mpfr.frexp(out e, y, value, value.Rounding);

            return y;
        }

        /// <summary>
        /// Converts to an integer value and exponent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="e">The exponent upon return.</param>
        public static mpz_t.mpz_t ToIntegerAndExponent(mpfr_t value, out int e)
        {
            mpz_t.mpz_t Result = new();

            e = mpfr.mpfr.get_z_2exp(Result, value);

            return Result;
        }

        /// <summary>
        /// Converts to a rational.
        /// </summary>
        /// <param name="value">The value.</param>
        public static mpq_t.mpq_t ToRational(mpfr_t value)
        {
            mpq_t.mpq_t Result = new();

            mpfr.mpfr.get_q(Result, value);

            return Result;
        }

        /// <summary>
        /// Converts to a <see cref="mpf_t"/> floating-point value.
        /// </summary>
        /// <param name="value">The value.</param>
        public static mpf_t.mpf_t ToFloatingPoint(mpfr_t value)
        {
            mpf_t.mpf_t Result = new();

            mpfr.mpfr.get_f(Result, value, value.Rounding);

            return Result;
        }

        /// <summary>
        /// Gets a value indicating whether the number can be converted to a <see cref="ulong"/>.
        /// </summary>
        public bool FitsUnsignedLong => mpfr.mpfr.fits_ulong_p(this, Rounding);

        /// <summary>
        /// Gets a value indicating whether a number can be converted to a <see cref="long"/>.
        /// </summary>
        public bool FitsSignedLong => mpfr.mpfr.fits_slong_p(this, Rounding);

        /// <summary>
        /// Gets a value indicating whether a number can be converted to a <see cref="uint"/>.
        /// </summary>
        public bool FitsUnsignedInt => mpfr.mpfr.fits_uint_p(this, Rounding);

        /// <summary>
        /// Gets a value indicating whether a number can be converted to a <see cref="int"/>.
        /// </summary>
        public bool FitsSignedInt => mpfr.mpfr.fits_sint_p(this, Rounding);

        /// <summary>
        /// Gets a value indicating whether a number can be converted to a <see cref="ushort"/>.
        /// </summary>
        public bool FitsUnsignedShort => mpfr.mpfr.fits_ushort_p(this, Rounding);

        /// <summary>
        /// Gets a value indicating whether a number can be converted to a <see cref="short"/>.
        /// </summary>
        public bool FitsSignedShort => mpfr.mpfr.fits_sshort_p(this, Rounding);

        /// <summary>
        /// Gets a value indicating whether the number is an integer.
        /// </summary>
        public bool IsInteger => mpfr.mpfr.integer_p(this);
    }
}
