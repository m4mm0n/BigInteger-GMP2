using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpz_t
{
    /// <summary>
    /// Arbitrary precision integer.
    /// </summary>
    public partial class mpz_t : IDisposable, IEquatable<mpz_t>, ICloneable, IConvertible, IComparable, IComparable<mpz_t>
    {
        /// <summary>
        /// Gets the absolute value of the number.
        /// </summary>
        public mpz_t Abs()
        {
            var z = new mpz_t();

            mpz.abs(z, this);

            return z;
        }

        /// <summary>
        /// Gets the sign.
        /// </summary>
        public int Sign => mpz.sgn(this);

        /// <summary>
        /// Divides the number by another with rounding.
        /// </summary>
        /// <param name="y">The other number.</param>
        /// <param name="rounding">The rounding.</param>
        public mpz_t Quotient(mpz_t y, Rounding rounding = Rounding.TowardZero)
        {
            var quotient = new mpz_t();

            switch (rounding)
            {
                default:
                case Rounding.TowardZero:
                    mpz.tdiv_q(quotient, this, y);
                    break;

                case Rounding.TowardPositiveInfinity:
                    mpz.cdiv_q(quotient, this, y);
                    break;

                case Rounding.TowardNegativeInfinity:
                    mpz.fdiv_q(quotient, this, y);
                    break;
            }

            return quotient;
        }

        /// <summary>
        /// Gets the remainder of the division of the number by another with rounding.
        /// </summary>
        /// <param name="y">The other number.</param>
        /// <param name="rounding">The rounding.</param>
        public mpz_t Remainder(mpz_t y, Rounding rounding = Rounding.TowardZero)
        {
            var remainder = new mpz_t();

            switch (rounding)
            {
                default:
                case Rounding.TowardZero:
                    mpz.tdiv_r(remainder, this, y);
                    break;

                case Rounding.TowardPositiveInfinity:
                    mpz.cdiv_r(remainder, this, y);
                    break;

                case Rounding.TowardNegativeInfinity:
                    mpz.fdiv_r(remainder, this, y);
                    break;
            }

            return remainder;
        }

        /// <summary>
        /// Divides two operands with rounding.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="quotient">The quotient.</param>
        /// <param name="remainder">The remainder.</param>
        /// <param name="rounding">The rounding.</param>
        public static void Divide(mpz_t x, mpz_t y, out mpz_t quotient, out mpz_t remainder, Rounding rounding = Rounding.TowardZero)
        {
            quotient = new mpz_t();
            remainder = new mpz_t();

            switch (rounding)
            {
                default:
                case Rounding.TowardZero:
                    mpz.tdiv_qr(quotient, remainder, x, y);
                    break;

                case Rounding.TowardPositiveInfinity:
                    mpz.cdiv_qr(quotient, remainder, x, y);
                    break;

                case Rounding.TowardNegativeInfinity:
                    mpz.fdiv_qr(quotient, remainder, x, y);
                    break;
            }
        }

        /// <summary>
        /// Divides the number by another with rounding.
        /// </summary>
        /// <param name="y">The other number.</param>
        /// <param name="rounding">The rounding.</param>
        public mpz_t Quotient(ulong y, Rounding rounding = Rounding.TowardZero)
        {
            var quotient = new mpz_t();

            switch (rounding)
            {
                default:
                case Rounding.TowardZero:
                    mpz.tdiv_q_ui(quotient, this, y);
                    break;

                case Rounding.TowardPositiveInfinity:
                    mpz.cdiv_q_ui(quotient, this, y);
                    break;

                case Rounding.TowardNegativeInfinity:
                    mpz.fdiv_q_ui(quotient, this, y);
                    break;
            }

            return quotient;
        }

        /// <summary>
        /// Gets the remainder of the division of the number by another with rounding.
        /// </summary>
        /// <param name="y">The other number.</param>
        /// <param name="rounding">The rounding.</param>
        public mpz_t Remainder(ulong y, Rounding rounding = Rounding.TowardZero)
        {
            var remainder = new mpz_t();

            switch (rounding)
            {
                default:
                case Rounding.TowardZero:
                    mpz.tdiv_r_ui(remainder, this, y);
                    break;

                case Rounding.TowardPositiveInfinity:
                    mpz.cdiv_r_ui(remainder, this, y);
                    break;

                case Rounding.TowardNegativeInfinity:
                    mpz.fdiv_r_ui(remainder, this, y);
                    break;
            }

            return remainder;
        }

        /// <summary>
        /// Divides two operands with rounding.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="quotient">The quotient.</param>
        /// <param name="remainder">The remainder.</param>
        /// <param name="rounding">The rounding.</param>
        public static void Divide(mpz_t x, ulong y, out mpz_t quotient, out mpz_t remainder, Rounding rounding = Rounding.TowardZero)
        {
            quotient = new mpz_t();
            remainder = new mpz_t();

            switch (rounding)
            {
                default:
                case Rounding.TowardZero:
                    mpz.tdiv_qr_ui(quotient, remainder, x, y);
                    break;

                case Rounding.TowardPositiveInfinity:
                    mpz.cdiv_qr_ui(quotient, remainder, x, y);
                    break;

                case Rounding.TowardNegativeInfinity:
                    mpz.fdiv_qr_ui(quotient, remainder, x, y);
                    break;
            }
        }

        /// <summary>
        /// Gets the absolute remainder of the division of the number by another with rounding.
        /// </summary>
        /// <param name="y">The other number.</param>
        /// <param name="rounding">The rounding.</param>
        public ulong AbsRemainder(ulong y, Rounding rounding = Rounding.TowardZero)
        {
            ulong remainder;

            switch (rounding)
            {
                default:
                case Rounding.TowardZero:
                    remainder = mpz.tdiv_ui(this, y);
                    break;

                case Rounding.TowardPositiveInfinity:
                    remainder = mpz.cdiv_ui(this, y);
                    break;

                case Rounding.TowardNegativeInfinity:
                    remainder = mpz.fdiv_ui(this, y);
                    break;
            }

            return remainder;
        }

        /// <summary>
        /// Gets the right shift of the number by another with rounding.
        /// </summary>
        /// <param name="y">The other number.</param>
        /// <param name="rounding">The rounding.</param>
        public mpz_t RightShift(ulong y, Rounding rounding = Rounding.TowardZero)
        {
            var quotient = new mpz_t();

            switch (rounding)
            {
                default:
                case Rounding.TowardZero:
                    mpz.tdiv_q_2exp(quotient, this, y);
                    break;

                case Rounding.TowardPositiveInfinity:
                    mpz.cdiv_q_2exp(quotient, this, y);
                    break;

                case Rounding.TowardNegativeInfinity:
                    mpz.fdiv_q_2exp(quotient, this, y);
                    break;
            }

            return quotient;
        }

        /// <summary>
        /// Gets the remainder of the right shift of the number by another with rounding.
        /// </summary>
        /// <param name="y">The other number.</param>
        /// <param name="rounding">The rounding.</param>
        public mpz_t RightShiftRemainder(ulong y, Rounding rounding = Rounding.TowardZero)
        {
            var remainder = new mpz_t();

            switch (rounding)
            {
                default:
                case Rounding.TowardZero:
                    mpz.tdiv_r_2exp(remainder, this, y);
                    break;

                case Rounding.TowardPositiveInfinity:
                    mpz.cdiv_r_2exp(remainder, this, y);
                    break;

                case Rounding.TowardNegativeInfinity:
                    mpz.fdiv_r_2exp(remainder, this, y);
                    break;
            }

            return remainder;
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="y">The divider.</param>
        public mpz_t DivExact(mpz_t y)
        {
            var quotient = new mpz_t();

            mpz.divexact(quotient, this, y);

            return quotient;
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="y">The divider.</param>
        public mpz_t DivExact(ulong y)
        {
            var quotient = new mpz_t();

            mpz.divexact_ui(quotient, this, y);

            return quotient;
        }

        /// <summary>
        /// Gets a value indicating whether the number can be exactly divided by another.
        /// </summary>
        /// <param name="y">The divider.</param>
        public bool IsDivisible(mpz_t y) => mpz.divisible_p(this, y);

        /// <summary>
        /// Gets a value indicating whether the number can be exactly divided by another.
        /// </summary>
        /// <param name="y">The divider.</param>
        public bool IsDivisible(ulong y) => mpz.divisible_ui_p(this, y);

        /// <summary>
        /// Gets a value indicating whether the number can be exactly divided by the power of two of another.
        /// </summary>
        /// <param name="y">The power.</param>
        public bool IsDivisibleByPowerOfTwo(ulong y) => mpz.divisible_2exp_p(this, y);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        public bool IsCongruent(mpz_t c, mpz_t d) => mpz.congruent_p(this, c, d);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        public bool IsCongruent(ulong c, ulong d) => mpz.congruent_ui_p(this, c, d);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        public bool IsCongruentPowerOfTwo(mpz_t c, long d) => mpz.congruent_2exp_p(this, c, (ulong)d);

        /// <summary>
        /// Gets the modulo of the number with a power of two.
        /// </summary>
        /// <param name="exp">The power.</param>
        /// <param name="mod">The modulo.</param>
        public mpz_t PowerMod(mpz_t exp, mpz_t mod)
        {
            var Result = new mpz_t();

            mpz.powm(Result, this, exp, mod);

            return Result;
        }

        /// <summary>
        /// Gets the modulo of the number with a power of two.
        /// </summary>
        /// <param name="exp">The power.</param>
        /// <param name="mod">The modulo.</param>
        public mpz_t PowerMod(ulong exp, mpz_t mod)
        {
            var Result = new mpz_t();

            mpz.powm_ui(Result, this, exp, mod);

            return Result;
        }

        /// <summary>
        /// Gets the value of the number to a power.
        /// </summary>
        /// <param name="exp">The power.</param>
        public mpz_t Pow(ulong exp)
        {
            var Result = new mpz_t();

            mpz.pow_ui(Result, this, exp);

            return Result;
        }

        /// <summary>
        /// Gets a value indicating whether the number is an exact root.
        /// </summary>
        /// <param name="n">The root number.</param>
        public bool IsRootExact(ulong n)
        {
            using var Result = new mpz_t();

            return mpz.root(Result, this, n);
        }

        /// <summary>
        /// Gets the root of the number.
        /// </summary>
        /// <param name="n">The root.</param>
        public mpz_t NthRoot(ulong n)
        {
            var Result = new mpz_t();

            mpz.nthroot(Result, this, n);

            return Result;
        }

        /// <summary>
        /// Gets the nth root of a number.
        /// </summary>
        /// <param name="x">The number.</param>
        /// <param name="n">The nth.</param>
        /// <param name="root">The root.</param>
        /// <param name="remainder">The remainder.</param>
        public static void NthRoot(mpz_t x, ulong n, out mpz_t root, out mpz_t remainder)
        {
            root = new mpz_t();
            remainder = new mpz_t();

            mpz.rootrem(root, remainder, x, n);
        }

        /// <summary>
        /// Gets the square root.
        /// </summary>
        public mpz_t Sqrt()
        {
            var Result = new mpz_t();

            mpz.sqrt(Result, this);

            return Result;
        }

        /// <summary>
        /// Gets the square root of a number.
        /// </summary>
        /// <param name="x">The number.</param>
        /// <param name="root">The root.</param>
        /// <param name="remainder">The remainder.</param>
        public static void SqrtRemainder(mpz_t x, out mpz_t root, out mpz_t remainder)
        {
            root = new mpz_t();
            remainder = new mpz_t();

            mpz.sqrtrem(root, remainder, x);
        }

        /// <summary>
        /// Gets a value indicating whether the number is an exact power.
        /// </summary>
        public bool IsPerfectPower() => mpz.perfect_power_p(this);

        /// <summary>
        /// Gets a value indicating whether the number is an exact square.
        /// </summary>
        public bool IsPerfectSquare() => mpz.perfect_square_p(this);
    }
}
