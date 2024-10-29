using System.Text;
using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpf_t
{
    /// <summary>
    /// See http://mpir.org/mpir-3.0.0.pdf.
    /// </summary>
    public partial class mpf_t : IDisposable, IEquatable<mpf_t>, ICloneable, IConvertible, IComparable, IComparable<mpf_t>
    {
        /// <summary>
        /// Returns a string that represents the number value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <returns>The number value.</returns>
        public override string ToString() => ToString(mpz_t.mpz_t.DefaultBase);

        /// <summary>
        /// Returns a string that represents the number value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="resultbase">The base to use for the result.</param>
        /// <returns>The number value.</returns>
        public string ToString(int resultbase)
        {
            var SizeInDigits = Precision;

            var Data = new StringBuilder((int)(SizeInDigits + 2));

            mpf.get_str(Data, out var Exponent, resultbase, SizeInDigits, this);

            var Result = Data.ToString();

            if (Result.Length == 0)
                return "0";

            var FractionalIndex = Result[0] == '-' ? 2 : 1;
            var IntegerPart = Result[..FractionalIndex];

            var FractionalPart = Result[FractionalIndex..];
            if (FractionalPart.Length > 0)
                FractionalPart = "." + FractionalPart;

            var ExponentPart = (Exponent - 1).ToString();
            if (Exponent > 0)
                ExponentPart = "+" + ExponentPart;

            Result = $"{IntegerPart}{FractionalPart}E{ExponentPart}";

            return Result;
        }

        /// <summary>
        /// Converts a <see cref="uint"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpf_t(uint value) => new(value);

        /// <summary>
        /// Converts an <see cref="int"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpf_t(int value) => new(value);

        /// <summary>
        /// Converts a <see cref="float"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpf_t(float value) => new((double)value);

        /// <summary>
        /// Converts a <see cref="double"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value.</param>
        public static implicit operator mpf_t(double value) => new(value);

        /// <summary>
        /// Converts to a <see cref="byte"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static explicit operator byte(mpf_t value) => (byte)mpf.get_ui(value);

        /// <summary>
        /// Converts to an <see cref="sbyte"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static explicit operator sbyte(mpf_t value) => (sbyte)mpf.get_si(value);

        /// <summary>
        /// Converts to a <see cref="ushort"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static explicit operator ushort(mpf_t value) => (ushort)mpf.get_ui(value);

        /// <summary>
        /// Converts to an <see cref="short"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static explicit operator short(mpf_t value) => (short)mpf.get_si(value);

        /// <summary>
        /// Converts to a <see cref="uint"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static explicit operator uint(mpf_t value) => (uint)mpf.get_ui(value);

        /// <summary>
        /// Converts to an <see cref="int"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static explicit operator int(mpf_t value) => (int)mpf.get_si(value);

        /// <summary>
        /// Converts to a <see cref="ulong"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static explicit operator ulong(mpf_t value) => (ulong)mpf.get_ui(value);

        /// <summary>
        /// Converts to a <see cref="long"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static explicit operator long(mpf_t value) => (long)mpf.get_si(value);

        /// <summary>
        /// Converts to a <see cref="float"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static explicit operator float(mpf_t value) => (float)(double)value;

        /// <summary>
        /// Converts to a <see cref="double"/> value.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static explicit operator double(mpf_t value) => mpf.get_d(value);

        /// <summary>
        /// Converts to a double with an exponent returned separately.
        /// </summary>
        /// <param name="d">The double upon return.</param>
        /// <param name="exp">The exponent upon return.</param>
        public void GetDoubleWithExponent(out double d, out long exp)
        {
            mpf.get_d_2exp(this, out d, out exp);
        }

        /// <summary>
        /// Gets a value indicating whether the number can be converted to a <see cref="ulong"/>.
        /// </summary>
        public bool FitsUnsignedLong => mpf.fits_ulong_p(this);

        /// <summary>
        /// Gets a value indicating whether a number can be converted to a <see cref="long"/>.
        /// </summary>
        public bool FitsSignedLong => mpf.fits_slong_p(this);

        /// <summary>
        /// Gets a value indicating whether a number can be converted to a <see cref="uint"/>.
        /// </summary>
        public bool FitsUnsignedInt => mpf.fits_uint_p(this);

        /// <summary>
        /// Gets a value indicating whether a number can be converted to a <see cref="int"/>.
        /// </summary>
        public bool FitsSignedInt => mpf.fits_sint_p(this);

        /// <summary>
        /// Gets a value indicating whether a number can be converted to a <see cref="ushort"/>.
        /// </summary>
        public bool FitsUnsignedShort => mpf.fits_ushort_p(this);

        /// <summary>
        /// Gets a value indicating whether a number can be converted to a <see cref="short"/>.
        /// </summary>
        public bool FitsSignedShort => mpf.fits_sshort_p(this);
    }
}
