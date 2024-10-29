using BigIntegerGMP2.Internals.mpfr;
using static BigIntegerGMP2.Internals.mpfr.mpfr;

namespace BigIntegerGMP2.Internals.mpfr_t
{
    /// <summary>
    /// Represents an arbitrary precision floating-point number.
    /// </summary>
    public partial class mpfr_t : IDisposable
    {
        #region Log
        /// <summary>
        /// Gets the log.
        /// </summary>
        public mpfr_t Log()
        {
            mpfr_t z = new();

            z.LastTernaryResult = log(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the log of the operand.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t Log(uint op, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            z.LastTernaryResult = log_ui(z, op, rounding);

            return z;
        }

        /// <summary>
        /// Gets the log2.
        /// </summary>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t Log2(mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            z.LastTernaryResult = log2(z, this, rounding);

            return z;
        }

        /// <summary>
        /// Gets the log10.
        /// </summary>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t Log10(mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            z.LastTernaryResult = log10(z, this, rounding);

            return z;
        }

        /// <summary>
        /// Gets the log1p.
        /// </summary>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t Log1p(mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            z.LastTernaryResult = log1p(z, this, rounding);

            return z;
        }

        /// <summary>
        /// Gets the log2.
        /// </summary>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t Log2p1(mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            z.LastTernaryResult = log2p1(z, this, rounding);

            return z;
        }

        /// <summary>
        /// Gets the log10.
        /// </summary>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t Log10p1(mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            z.LastTernaryResult = log10p1(z, this, rounding);

            return z;
        }
        #endregion

        #region Exp
        /// <summary>
        /// Gets the exponential.
        /// </summary>
        public mpfr_t Exp()
        {
            mpfr_t z = new();

            z.LastTernaryResult = exp(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the exp2.
        /// </summary>
        public mpfr_t Exp2()
        {
            mpfr_t z = new();

            z.LastTernaryResult = exp2(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the exp10.
        /// </summary>
        public mpfr_t Exp10()
        {
            mpfr_t z = new();

            z.LastTernaryResult = exp10(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the expm1.
        /// </summary>
        public mpfr_t Expm1()
        {
            mpfr_t z = new();

            z.LastTernaryResult = expm1(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the exp2.
        /// </summary>
        public mpfr_t Exp2m1()
        {
            mpfr_t z = new();

            z.LastTernaryResult = exp2m1(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the exp10.
        /// </summary>
        public mpfr_t Exp10m1()
        {
            mpfr_t z = new();

            z.LastTernaryResult = exp10m1(z, this, Rounding);

            return z;
        }
        #endregion

        #region Pow
        /// <summary>
        /// Gets the power by a number.
        /// </summary>
        /// <param name="op">The power operand.</param>
        public mpfr_t Pow(mpfr_t op)
        {
            mpfr_t z = new();

            z.LastTernaryResult = pow(z, this, op, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the power by a number.
        /// </summary>
        /// <param name="op">The power operand.</param>
        public mpfr_t Pow(ulong op)
        {
            mpfr_t z = new();

            z.LastTernaryResult = pow_ui(z, this, op, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the power by a number.
        /// </summary>
        /// <param name="op">The power operand.</param>
        public mpfr_t Pow(long op)
        {
            mpfr_t z = new();

            z.LastTernaryResult = pow_si(z, this, op, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the power by a number.
        /// </summary>
        /// <param name="op">The power operand.</param>
        public mpfr_t Pow(mpz_t.mpz_t op)
        {
            mpfr_t z = new();

            z.LastTernaryResult = pow_z(z, this, op, Rounding);

            return z;
        }

        /// <summary>
        /// Gets a number at the power of another number.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t Pow(ulong op1, ulong op2, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            z.LastTernaryResult = ui_pow_ui(z, op1, op2, rounding);

            return z;
        }

        /// <summary>
        /// Gets a number at the power of another number.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static mpfr_t Pow(ulong op1, mpfr_t op2)
        {
            mpfr_t z = new();

            z.LastTernaryResult = ui_pow(z, op1, op2, op2.Rounding);

            return z;
        }

        /// <summary>
        /// Gets exp(y*log(x)).
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public static mpfr_t Powr(mpfr_t x, mpfr_t y, mpfr_rnd_t rounding = DefaultRounding)
        {
            mpfr_t z = new();

            z.LastTernaryResult = powr(z, x, y, rounding);

            return z;
        }
        #endregion

        #region Trigonometric
        /// <summary>
        /// Gets the cosine.
        /// </summary>
        public mpfr_t Cos()
        {
            mpfr_t z = new();

            z.LastTernaryResult = cos(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the sine.
        /// </summary>
        public mpfr_t Sin()
        {
            mpfr_t z = new();

            z.LastTernaryResult = sin(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the tangent.
        /// </summary>
        public mpfr_t Tan()
        {
            mpfr_t z = new();

            z.LastTernaryResult = tan(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the sine and cosine of an operand.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="sin">The sine.</param>
        /// <param name="cos">The cosine.</param>
        public static void SinCos(mpfr_t op, out mpfr_t sin, out mpfr_t cos)
        {
            sin = new();
            cos = new();

            sin_cos(sin, cos, op, op.Rounding);
        }

        /// <summary>
        /// Gets the secant.
        /// </summary>
        public mpfr_t Sec()
        {
            mpfr_t z = new();

            z.LastTernaryResult = sec(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the cosecant.
        /// </summary>
        public mpfr_t Csc()
        {
            mpfr_t z = new();

            z.LastTernaryResult = csc(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the cotangent.
        /// </summary>
        public mpfr_t Cot()
        {
            mpfr_t z = new();

            z.LastTernaryResult = cot(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the arccosine.
        /// </summary>
        public mpfr_t Acos()
        {
            mpfr_t z = new();

            z.LastTernaryResult = acos(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the arcsine.
        /// </summary>
        public mpfr_t Asin()
        {
            mpfr_t z = new();

            z.LastTernaryResult = asin(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the arctangent.
        /// </summary>
        public mpfr_t Atan()
        {
            mpfr_t z = new();

            z.LastTernaryResult = atan(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the atan2 of two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpfr_t Atan2(mpfr_t x, mpfr_t y)
        {
            mpfr_t z = new();

            z.LastTernaryResult = atan2(z, x, y, x.Rounding);

            return z;
        }

        /// <summary>
        /// Gets the hyperbolic cosine.
        /// </summary>
        public mpfr_t Cosh()
        {
            mpfr_t z = new();

            z.LastTernaryResult = cosh(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the hyperbolic sine.
        /// </summary>
        public mpfr_t Sinh()
        {
            mpfr_t z = new();

            z.LastTernaryResult = sinh(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the hyperbolic tangent.
        /// </summary>
        public mpfr_t Tanh()
        {
            mpfr_t z = new();

            z.LastTernaryResult = tanh(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the hyperbolic sine and cosine of an operand.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="sinh">The hyperbolic sine.</param>
        /// <param name="cosh">The hyperbolic cosine.</param>
        public static void SinhCosh(mpfr_t op, out mpfr_t sinh, out mpfr_t cosh)
        {
            sinh = new();
            cosh = new();

            sinh_cosh(sinh, cosh, op, op.Rounding);
        }

        /// <summary>
        /// Gets the hyperbolic secant.
        /// </summary>
        public mpfr_t Sech()
        {
            mpfr_t z = new();

            z.LastTernaryResult = sech(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the hyperbolic cosecant.
        /// </summary>
        public mpfr_t Csch()
        {
            mpfr_t z = new();

            z.LastTernaryResult = csch(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the hyperbolic tangent.
        /// </summary>
        public mpfr_t Coth()
        {
            mpfr_t z = new();

            z.LastTernaryResult = coth(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the hyperbolic arccosine.
        /// </summary>
        public mpfr_t Acosh()
        {
            mpfr_t z = new();

            z.LastTernaryResult = acosh(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the hyperbolic arcsine.
        /// </summary>
        public mpfr_t Asinh()
        {
            mpfr_t z = new();

            z.LastTernaryResult = asinh(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets the hyperbolic arctangent.
        /// </summary>
        public mpfr_t Atanh()
        {
            mpfr_t z = new();

            z.LastTernaryResult = atanh(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets cos(2*pi*x/u).
        /// </summary>
        /// <param name="u">The operand.</param>
        public mpfr_t Cos(ulong u)
        {
            mpfr_t z = new();

            z.LastTernaryResult = cosu(z, this, u, Rounding);

            return z;
        }

        /// <summary>
        /// Gets sin(2*pi*x/u).
        /// </summary>
        /// <param name="u">The operand.</param>
        public mpfr_t Sin(ulong u)
        {
            mpfr_t z = new();

            z.LastTernaryResult = sinu(z, this, u, Rounding);

            return z;
        }

        /// <summary>
        /// Gets tan(2*pi*x/u).acos(x)*u/(2*pi).
        /// </summary>
        /// <param name="u">The operand.</param>
        public mpfr_t Tan(ulong u)
        {
            mpfr_t z = new();

            z.LastTernaryResult = tanu(z, this, u, Rounding);

            return z;
        }

        /// <summary>
        /// Gets acos(x)*u/(2*pi).
        /// </summary>
        /// <param name="u">The operand.</param>
        public mpfr_t Acos(ulong u)
        {
            mpfr_t z = new();

            z.LastTernaryResult = acosu(z, this, u, Rounding);

            return z;
        }

        /// <summary>
        /// Gets asin(x)*u/(2*pi).
        /// </summary>
        /// <param name="u">The operand.</param>
        public mpfr_t Asin(ulong u)
        {
            mpfr_t z = new();

            z.LastTernaryResult = asinu(z, this, u, Rounding);

            return z;
        }

        /// <summary>
        /// Gets atan(x)*u/(2*pi).
        /// </summary>
        /// <param name="u">The operand.</param>
        public mpfr_t Atan(ulong u)
        {
            mpfr_t z = new();

            z.LastTernaryResult = atanu(z, this, u, Rounding);

            return z;
        }

        /// <summary>
        /// Gets atan(|y/x|)*u/(2*pi) for x &gt; 0, 1-atan(|y/x|)*u/(2*pi) for x &lt; 0.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="u">The third operand.</param>
        public static mpfr_t Atan2(mpfr_t x, mpfr_t y, ulong u)
        {
            mpfr_t z = new();

            z.LastTernaryResult = atan2u(z, x, y, u, x.Rounding);

            return z;
        }

        /// <summary>
        /// Gets cos(pi*x).
        /// </summary>
        public mpfr_t CosPi()
        {
            mpfr_t z = new();

            z.LastTernaryResult = cospi(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets sin(pi*x).
        /// </summary>
        public mpfr_t SinPi()
        {
            mpfr_t z = new();

            z.LastTernaryResult = sinpi(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets tan(pi*x).
        /// </summary>
        public mpfr_t TanPi()
        {
            mpfr_t z = new();

            z.LastTernaryResult = tanpi(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets acos(x)/pi.
        /// </summary>
        public mpfr_t AcosPi()
        {
            mpfr_t z = new();

            z.LastTernaryResult = acospi(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets asin(x)/pi.
        /// </summary>
        public mpfr_t AsinPi()
        {
            mpfr_t z = new();

            z.LastTernaryResult = asinpi(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets atan(x)/pi.
        /// </summary>
        public mpfr_t AtanPi()
        {
            mpfr_t z = new();

            z.LastTernaryResult = atanpi(z, this, Rounding);

            return z;
        }

        /// <summary>
        /// Gets atan(|y/x|)/pi for x &gt; 0, 1-atan(|y/x|)/pi for x &lt; 0.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpfr_t Atan2Pi(mpfr_t x, mpfr_t y)
        {
            mpfr_t z = new();

            z.LastTernaryResult = atan2pi(z, x, y, x.Rounding);

            return z;
        }
        #endregion

        #region Other
        /// <summary>
        /// Gets the exponential integral.
        /// </summary>
        public mpfr_t EInt()
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = eint(Result, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the real part of the dilogarithm.
        /// </summary>
        public mpfr_t Li2()
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = li2(Result, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the result of the Gamma function.
        /// </summary>
        public mpfr_t Gamma()
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = gamma(Result, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the result of the incomplete Gamma function.
        /// </summary>
        /// <param name="operand">The operand.</param>
        public mpfr_t IncompleteGamma(mpfr_t operand)
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = gamma_inc(Result, this, operand, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the logarithm of the result of the Gamma function.
        /// </summary>
        public mpfr_t LnGamma()
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = lngamma(Result, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the logarithm of the absolute value of the result of the Gamma function.
        /// </summary>
        /// <param name="sign">The sign of the result upon return.</param>
        public mpfr_t LnGammaAbs(out int sign)
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = lgamma(Result, out sign, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the result of the Digamma function.
        /// </summary>
        public mpfr_t Digamma()
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = digamma(Result, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the result of the Beta function.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpfr_t Beta(mpfr_t x, mpfr_t y)
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = beta(Result, x, y, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the result of the error function.
        /// </summary>
        public mpfr_t Erf()
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = erf(Result, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the result of the complementary error function.
        /// </summary>
        public mpfr_t Erfc()
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = erfc(Result, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the order 0 of the first kind Bessel function.
        /// </summary>
        public mpfr_t BesselFirst0()
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = j0(Result, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the order 1 of the first kind Bessel function.
        /// </summary>
        public mpfr_t BesselFirst1()
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = j1(Result, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the order N of the first kind Bessel function.
        /// </summary>
        /// <param name="n">The order.</param>
        public mpfr_t BesselFirst(int n)
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = jn(Result, n, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the order 0 of the second kind Bessel function.
        /// </summary>
        public mpfr_t BesselSecond0()
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = y0(Result, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the order 1 of the second kind Bessel function.
        /// </summary>
        public mpfr_t BesselSecond1()
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = y1(Result, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the order N of the second kind Bessel function.
        /// </summary>
        /// <param name="n">The order.</param>
        public mpfr_t BesselSecond(int n)
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = yn(Result, n, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the arithmetic(geometric mean of <paramref name="x"/> and <paramref name="y"/>.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpfr_t ArithmeticGeometricMean(mpfr_t x, mpfr_t y)
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = agm(Result, x, y, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the result of the Airy function.
        /// </summary>
        public mpfr_t Airy()
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = ai(Result, this, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the log2.
        /// </summary>
        /// <param name="precision">The precision.</param>
        public static mpfr_t Log2(ulong precision = ulong.MaxValue)
        {
            var Result = new mpfr_t();

            if (precision == ulong.MaxValue)
                init2(Result, DefaultPrecision);
            else
                init2(Result, precision);

            Result.LastTernaryResult = const_log2(Result, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets π.
        /// </summary>
        /// <param name="precision">The precision.</param>
        public static mpfr_t Pi(ulong precision = ulong.MaxValue)
        {
            var Result = new mpfr_t();

            if (precision == ulong.MaxValue)
                init2(Result, DefaultPrecision);
            else
                init2(Result, precision);

            Result.LastTernaryResult = const_pi(Result, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets e.
        /// </summary>
        /// <param name="precision">The precision.</param>
        public static mpfr_t Euler(ulong precision = ulong.MaxValue)
        {
            var Result = new mpfr_t();

            if (precision == ulong.MaxValue)
                init2(Result, DefaultPrecision);
            else
                init2(Result, precision);

            Result.LastTernaryResult = const_euler(Result, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets the Catalan constant.
        /// </summary>
        /// <param name="precision">The precision.</param>
        public static mpfr_t Catalan(ulong precision = ulong.MaxValue)
        {
            var Result = new mpfr_t();

            if (precision == ulong.MaxValue)
                init2(Result, DefaultPrecision);
            else
                init2(Result, precision);

            Result.LastTernaryResult = const_catalan(Result, DefaultRounding);

            return Result;
        }

        /// <summary>
        /// Gets (1+x)^n.
        /// </summary>
        /// <param name="n">The operand.</param>
        public mpfr_t Compound(long n)
        {
            var Result = new mpfr_t();

            Result.LastTernaryResult = compound_si(Result, this, n, DefaultRounding);

            return Result;
        }
        #endregion
    }
}
