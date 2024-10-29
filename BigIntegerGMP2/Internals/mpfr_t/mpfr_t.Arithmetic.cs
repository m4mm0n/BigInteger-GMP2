using BigIntegerGMP2.Internals.mpfr;

namespace BigIntegerGMP2.Internals.mpfr_t
{
    /// <summary>
    /// Represents an arbitrary precision floating-point number.
    /// </summary>
    public partial class mpfr_t : IDisposable
    {
        /// <summary>
        /// Gets the square.
        /// </summary>
        public mpfr_t Sqr()
        {
            mpfr_t z = new();

            LastTernaryResult = mpfr.mpfr.sqr(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the square root.
        /// </summary>
        public mpfr_t Sqrt()
        {
            mpfr_t z = new();

            LastTernaryResult = mpfr.mpfr.sqrt(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the cubic root.
        /// </summary>
        public mpfr_t Cbrt()
        {
            mpfr_t z = new();

            LastTernaryResult = mpfr.mpfr.cbrt(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the nth root.
        /// </summary>
        /// <param name="n">The nth.</param>
        public mpfr_t NthRoot(ulong n)
        {
            mpfr_t z = new();

            LastTernaryResult = mpfr.mpfr.rootn_ui(z, this, n, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the nth root.
        /// </summary>
        /// <param name="n">The nth.</param>
        public mpfr_t NthRoot(long n)
        {
            mpfr_t z = new();

            LastTernaryResult = mpfr.mpfr.rootn_si(z, this, n, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the absolute value.
        /// </summary>
        public mpfr_t Abs()
        {
            mpfr_t z = new();

            LastTernaryResult = mpfr.mpfr.abs(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the euclidean norm of two numbers.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t EuclideanNorm(mpfr_t x, mpfr_t y, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.hypot(z, x, y, rounding);

            return z;
        }

        /// <summary>
        /// Gets the positive difference of <paramref name="x"/> and <paramref name="y"/>.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t Dim(mpfr_t x, mpfr_t y, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            mpfr.mpfr.dim(z, x, y, rounding);

            return z;
        }

        /// <summary>
        /// Gets (<paramref name="a"/> * <paramref name="b"/>) + <paramref name="c"/>.
        /// </summary>
        /// <param name="a">The first operand.</param>
        /// <param name="b">The second operand.</param>
        /// <param name="c">The third operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t Fma(mpfr_t a, mpfr_t b, mpfr_t c, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t Result = new();

            mpfr.mpfr.fma(Result, a, b, c, rounding);

            return Result;
        }

        /// <summary>
        /// Gets (<paramref name="a"/> * <paramref name="b"/>) - <paramref name="c"/>.
        /// </summary>
        /// <param name="a">The first operand.</param>
        /// <param name="b">The second operand.</param>
        /// <param name="c">The third operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t Fms(mpfr_t a, mpfr_t b, mpfr_t c, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t Result = new();

            mpfr.mpfr.fms(Result, a, b, c, rounding);

            return Result;
        }

        /// <summary>
        /// Gets (<paramref name="a"/> * <paramref name="b"/>) + (<paramref name="c"/> * <paramref name="d"/>).
        /// </summary>
        /// <param name="a">The first operand.</param>
        /// <param name="b">The second operand.</param>
        /// <param name="c">The third operand.</param>
        /// <param name="d">The fourth operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t Fmma(mpfr_t a, mpfr_t b, mpfr_t c, mpfr_t d, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t Result = new();

            mpfr.mpfr.fmma(Result, a, b, c, d, rounding);

            return Result;
        }

        /// <summary>
        /// Gets (<paramref name="a"/> * <paramref name="b"/>) - (<paramref name="c"/> * <paramref name="d"/>).
        /// </summary>
        /// <param name="a">The first operand.</param>
        /// <param name="b">The second operand.</param>
        /// <param name="c">The third operand.</param>
        /// <param name="d">The fourth operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t Fmms(mpfr_t a, mpfr_t b, mpfr_t c, mpfr_t d, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t Result = new();

            mpfr.mpfr.fmms(Result, a, b, c, d, rounding);

            return Result;
        }

        /// <summary>
        /// Gets the value multiplied by 2^<paramref name="n"/>.
        /// </summary>
        /// <param name="n">The power.</param>
        public mpfr_t Mul2(ulong n)
        {
            mpfr_t z = new();

            LastTernaryResult = mpfr.mpfr.mul_2ui(z, this, n, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the value multiplied by 2^<paramref name="n"/>.
        /// </summary>
        /// <param name="n">The power.</param>
        public mpfr_t Mul2(long n)
        {
            mpfr_t z = new();

            LastTernaryResult = mpfr.mpfr.mul_2si(z, this, n, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the value divided by 2^<paramref name="n"/>.
        /// </summary>
        /// <param name="n">The power.</param>
        public mpfr_t Div2(ulong n)
        {
            mpfr_t z = new();

            LastTernaryResult = mpfr.mpfr.div_2ui(z, this, n, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the value divided by 2^<paramref name="n"/>.
        /// </summary>
        /// <param name="n">The power.</param>
        public mpfr_t Div2(long n)
        {
            mpfr_t z = new();

            LastTernaryResult = mpfr.mpfr.div_2si(z, this, n, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the reciprocal square root.
        /// </summary>
        public mpfr_t RecSqrt()
        {
            mpfr_t z = new();

            LastTernaryResult = mpfr.mpfr.rec_sqrt(z, this, Rounding);

            return z;
        }
    }
}
