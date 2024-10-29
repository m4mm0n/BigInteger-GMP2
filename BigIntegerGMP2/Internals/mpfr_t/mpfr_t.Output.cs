using BigIntegerGMP2.Internals.mpfr;
using System.Diagnostics;
using System.Text;

namespace BigIntegerGMP2.Internals.mpfr_t
{
    /// <summary>
    /// Represents an arbitrary precision floating-point number.
    /// </summary>
    public partial class mpfr_t : IDisposable
    {
        /// <summary>
        /// Gets the number of digits necessary to store a string with the current precision.
        /// </summary>
        public ulong DigitCount => mpfr.mpfr.get_str_ndigits(mpz_t.mpz_t.DefaultBase, Precision);

        /// <summary>
        /// Returns a string that represents the number value.
        /// </summary>
        /// <returns>The number value.</returns>
        public override string ToString() => ToString(mpz_t.mpz_t.DefaultBase, DefaultRounding);

        /// <summary>
        /// Returns a string that represents the number value.
        /// </summary>
        /// <param name="resultbase">The digit base.</param>
        /// <param name="rounding">The rounding mode.</param>
        /// <returns>The number value.</returns>
        public string ToString(int resultbase, mpfr_rnd_t rounding)
        {
            Debug.Assert(IsCacheInitialized);

            var SizeInDigits = DigitCount;
            var Data = new StringBuilder((int)(SizeInDigits + 2));

            int Exponent;
            mpfr.mpfr.get_str(Data, out Exponent, resultbase, SizeInDigits, this, rounding);

            var Result = Data.ToString();
            Debug.Assert(Result.Length > 0);

            if (Result == "@NaN@" || Result == "@Inf@" || Result == "-@Inf@")
                return Result;

            var IsNegative = Result[0] == '-';

            var IsZero = true;
            for (var i = IsNegative ? 1 : 0; i < Result.Length; i++)
                if (Result[i] != '0')
                {
                    IsZero = false;
                    break;
                }

            if (IsZero)
                return IsNegative ? "-0" : "0";

            var FractionalIndex = IsNegative ? 2 : 1;
            Debug.Assert(FractionalIndex <= Result.Length);

            var IntegerPart = Result.Substring(0, FractionalIndex);
            var FractionalPart = Result.Substring(FractionalIndex);

            var LastNonZero = FractionalPart.Length;
            while (LastNonZero > 0 && FractionalPart[LastNonZero - 1] == '0')
                LastNonZero--;

            FractionalPart = FractionalPart.Substring(0, LastNonZero);

            if (FractionalPart.Length > 0)
                FractionalPart = "." + FractionalPart;

            var ExponentPart = (Exponent - 1).ToString();
            if (Exponent > 0)
                ExponentPart = "+" + ExponentPart;

            Result = $"{IntegerPart}{FractionalPart}E{ExponentPart}";

            return Result;
        }
    }
}
