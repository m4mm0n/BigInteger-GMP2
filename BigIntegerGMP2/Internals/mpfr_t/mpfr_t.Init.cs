using BigIntegerGMP2.Internals.mpfr;
using static BigIntegerGMP2.Native.Mpfr.NativeMethods;

namespace BigIntegerGMP2.Internals.mpfr_t
{
    /// <summary>
    /// Represents an arbitrary precision floating-point number.
    /// </summary>
    public partial class mpfr_t : IDisposable
    {
        /// <summary>
        /// The default rounding mode.
        /// </summary>
        public const mpfr_rnd_t DefaultRounding = mpfr_rnd_t.MPFR_RNDN;

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        public mpfr_t()
        {
            mpfr.mpfr.init2(this, DefaultPrecision);
            InitCacheManagement();
        }

        /// <summary>
        /// Creates a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="precision">The precision.</param>
        public static mpfr_t Create(ulong precision = ulong.MaxValue)
        {
            var Result = new mpfr_t();

            var EffectivePrecision = (precision == ulong.MaxValue) ? DefaultPrecision : precision;
            mpfr.mpfr.init2(Result, EffectivePrecision);

            return Result;
        }

        /// <summary>
        /// Creates an array of new instances of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="length">The array length.</param>
        /// <param name="precision">The precision.</param>
        public static mpfr_t[] CreateArray(int length, ulong precision = ulong.MaxValue)
        {
            if (length >= MaxArrayLength)
                throw new ArgumentException(nameof(length));

            if (precision == ulong.MaxValue)
                return CreateArrayDefaultPrecision(length);
            else
                return CreateArrayCustomPrecision(length, precision);
        }

        private static mpfr_t[] CreateArrayDefaultPrecision(int length)
        {
            var Result = new mpfr_t[length];
            for (var i = 0; i < Result.Length; i++)
                Result[i] = new mpfr_t();

            ProcessArray(Result, (nint[] args) =>
            {
                var Index = 0;
                mpfr_inits(args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++],
                           args[Index++]);
            });

            return Result;
        }

        private static mpfr_t[] CreateArrayCustomPrecision(int length, ulong precision)
        {
            var Result = new mpfr_t[length];
            for (var i = 0; i < Result.Length; i++)
                Result[i] = new mpfr_t();

            ProcessArray(Result, (nint[] args) =>
            {
                var Index = 0;
                mpfr_inits2(precision,
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++]);
            });

            return Result;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="mpfr_t"/> class representing NaN.
        /// </summary>
        /// <param name="sign">The sign.</param>
        public static mpfr_t NaN(int sign = +1)
        {
            mpfr_t Result = new();
            mpfr.mpfr.set_nan(Result);

            if (sign < 0)
                mpfr.mpfr.neg(Result, Result, mpfr_rnd_t.MPFR_RNDF);

            return Result;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="mpfr_t"/> class representing infinite.
        /// </summary>
        /// <param name="sign">The sign.</param>
        public static mpfr_t Infinite(int sign = +1)
        {
            var Result = new mpfr_t();
            mpfr.mpfr.set_inf(Result, sign);

            return Result;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="mpfr_t"/> class representing zero.
        /// </summary>
        /// <param name="sign">The sign.</param>
        public static mpfr_t Zero(int sign = +1)
        {
            var Result = new mpfr_t();
            mpfr.mpfr.set_zero(Result, sign);

            return Result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="other">The other instance.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(mpfr_t other, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set(this, other, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(ulong op, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_ui(this, op, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(long op, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_si(this, op, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(uint op, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_uj(this, op, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(int op, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_sj(this, op, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(float op, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_flt(this, op, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(double op, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_d(this, op, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(mpz_t.mpz_t op, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_z(this, op, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(mpq_t.mpq_t op, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_q(this, op, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(mpf_t.mpf_t op, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_f(this, op, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="str">The string text.</param>
        /// <param name="strbase">The digit base.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(string str, uint strbase = 10, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            var Success = mpfr.mpfr.set_str(this, str, strbase, rounding);
            if (!Success)
            {
                DisposeCache();
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="e">The shift.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(ulong op, long e, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_ui_2exp(this, op, e, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="e">The shift.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(long op, long e, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_si_2exp(this, op, e, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="e">The shift.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(uint op, long e, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_uj_2exp(this, op, e, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="e">The shift.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(int op, long e, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_sj_2exp(this, op, e, rounding);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mpfr_t"/> class.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="e">The exponent.</param>
        /// <param name="rounding">The rounding mode.</param>
        public mpfr_t(mpz_t.mpz_t op, long e, mpfr_rnd_t rounding = DefaultRounding)
            : this()
        {
            mpfr.mpfr.set_z_2exp(this, op, e, rounding);
        }

        /// <summary>
        /// Clear an array of numbers.
        /// </summary>
        /// <param name="array">The array.</param>
        public static void ClearArray(mpfr_t[] array)
        {
            if (array.Length >= MaxArrayLength)
                throw new ArgumentException(nameof(array.Length));

            ProcessArray(array, (nint[] args) =>
            {
                var Index = 0;
                mpfr_clears(args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++],
                            args[Index++]);
            });

            foreach (var Item in array)
            {
                Item.IsDisposed = true;
                Item.DisposeCache();
            }
        }

        /// <summary>
        /// Gets or sets the rounding mode.
        /// </summary>
        public mpfr_rnd_t Rounding { get; set; } = DefaultRounding;

#pragma warning disable SA1401 // Fields should be private
#pragma warning disable SA1600 // Elements should be documented
        internal __mpfr_t Value;
#pragma warning restore SA1401 // Fields should be private
#pragma warning restore SA1600 // Elements should be documented
    }
}
