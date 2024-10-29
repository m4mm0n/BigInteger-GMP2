using BigIntegerGMP2.Internals.mpfr;

namespace BigIntegerGMP2.Internals.mpfr_t
{
    /// <summary>
    /// Represents an arbitrary precision floating-point number.
    /// </summary>
    public partial class mpfr_t : IDisposable
    {
        /// <summary>
        /// Gets or sets the default rounding mode.
        /// </summary>
        public static mpfr_rnd_t DefaultRoundingMode
        {
            get => mpfr.mpfr.get_default_rounding_mode();
            set => mpfr.mpfr.set_default_rounding_mode(value);
        }

        /// <summary>
        /// Rounds to an integer.
        /// </summary>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t RoundToInteger(mpfr_rnd_t rounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.rint(z, this, rounding);

            return z;
        }

        /// <summary>
        /// Rounds to ceil.
        /// </summary>
        public mpfr_t Ceil()
        {
            mpfr_t z = new();

            mpfr.mpfr.ceil(z, this);

            return z;
        }

        /// <summary>
        /// Rounds to ceil.
        /// </summary>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t Ceil(mpfr_rnd_t rounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.rint_ceil(z, this, rounding);

            return z;
        }

        /// <summary>
        /// Rounds to floor.
        /// </summary>
        public mpfr_t Floor()
        {
            mpfr_t z = new();

            mpfr.mpfr.floor(z, this);

            return z;
        }

        /// <summary>
        /// Rounds to floor.
        /// </summary>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t Floor(mpfr_rnd_t rounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.rint_floor(z, this, rounding);

            return z;
        }

        /// <summary>
        /// Rounds to nearest.
        /// </summary>
        public mpfr_t Round()
        {
            mpfr_t z = new();

            mpfr.mpfr.round(z, this);

            return z;
        }

        /// <summary>
        /// Rounds to nearest.
        /// </summary>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t Round(mpfr_rnd_t rounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.rint_round(z, this, rounding);

            return z;
        }

        /// <summary>
        /// Rounds to even.
        /// </summary>
        public mpfr_t RoundEven()
        {
            mpfr_t z = new();

            mpfr.mpfr.roundeven(z, this);

            return z;
        }

        /// <summary>
        /// Rounds to even.
        /// </summary>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t RoundEven(mpfr_rnd_t rounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.rint_roundeven(z, this, rounding);

            return z;
        }

        /// <summary>
        /// Rounds truncating.
        /// </summary>
        public mpfr_t Trunc()
        {
            mpfr_t z = new();

            mpfr.mpfr.trunc(z, this);

            return z;
        }

        /// <summary>
        /// Rounds truncating.
        /// </summary>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t Trunc(mpfr_rnd_t rounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.rint_trunc(z, this, rounding);

            return z;
        }

        /// <summary>
        /// Gets the fractional part.
        /// </summary>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t Fractional(mpfr_rnd_t rounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.frac(z, this, rounding);

            return z;
        }

        /// <summary>
        /// Gets the fractional part.
        /// </summary>
        /// <param name="integer">The integer part upon return.</param>
        /// <param name="fractional">The fractional part upon return.</param>
        /// <param name="rounding">The rounding mode.</param>
        public void IntegerAndFractional(out mpfr_t integer, out mpfr_t fractional, mpfr_rnd_t rounding = DefaultRounding)
        {
            integer = new mpfr_t();
            fractional = new mpfr_t();

            mpfr.mpfr.modf(integer, fractional, this, rounding);
        }

        /// <summary>
        /// Gets the fractional difference.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t FMod(mpfr_t x, mpfr_t y, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.fmod(z, x, y, rounding);

            return z;
        }

        /// <summary>
        /// Gets the fractional difference.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t FMod(mpfr_t x, ulong y, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.fmod_ui(z, x, y, rounding);

            return z;
        }

        /// <summary>
        /// Gets the fractional difference.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="q">The quotient upon return.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t FMod(mpfr_t x, mpfr_t y, out long q, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.fmodquo(z, out q, x, y, rounding);

            return z;
        }

        /// <summary>
        /// Gets the fractional remainder.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t Remainder(mpfr_t x, mpfr_t y, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.remainder(z, x, y, rounding);

            return z;
        }

        /// <summary>
        /// Gets the fractional remainder.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="q">The quotient upon return.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t Remainder(mpfr_t x, mpfr_t y, out long q, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.remquo(z, out q, x, y, rounding);

            return z;
        }

        /// <summary>
        /// Rounds to an integer.
        /// </summary>
        /// <param name="precision">The precision.</param>
        /// <param name="rounding">The rounding mode.</param>
        public void RoundWithPrecision(ulong precision, mpfr_rnd_t rounding)
        {
            mpfr.mpfr.prec_round(this, precision, rounding);
        }

        /// <summary>
        /// Checks if the number can be rounded correctly.
        /// </summary>
        /// <param name="err">The error exponent.</param>
        /// <param name="rounding1">The number rounding.</param>
        /// <param name="rounding2">The precision rounding.</param>
        /// <param name="precision">The precision.</param>
        public bool CanRound(int err, mpfr_rnd_t rounding1, mpfr_rnd_t rounding2, ulong precision) => mpfr.mpfr.can_round(this, err, rounding1, rounding2, precision);
    }
}
