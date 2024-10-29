using System.Runtime.InteropServices;
using static BigIntegerGMP2.Native.Mpfr.NativeMethods;

namespace BigIntegerGMP2.Internals.mpfr
{
    /// <summary>
    /// Represents an arbitrary precision floating-point number.
    /// </summary>
    public static partial class mpfr
    {
        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static void nexttoward(mpfr_t.mpfr_t x, mpfr_t.mpfr_t y)
        {
            mpfr_nexttoward(ref x.Value, ref y.Value);
        }

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="x">The operand.</param>
        public static void nextabove(mpfr_t.mpfr_t x)
        {
            mpfr_nextabove(ref x.Value);
        }

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="x">The operand.</param>
        public static void nextbelow(mpfr_t.mpfr_t x)
        {
            mpfr_nextbelow(ref x.Value);
        }

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int min(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_min(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int max(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_max(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="state">The state.</param>
        public static int urandomb(mpfr_t.mpfr_t rop, randstate_t state) => mpfr_urandomb(ref rop.Value, ref state.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="state">The state.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int urandom(mpfr_t.mpfr_t rop, randstate_t state, mpfr_rnd_t rnd) => mpfr_urandom(ref rop.Value, ref state.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop1">The result operand.</param>
        /// <param name="state">The state.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int nrandom(mpfr_t.mpfr_t rop1, randstate_t state, mpfr_rnd_t rnd) => mpfr_nrandom(ref rop1.Value, ref state.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop1">The first result operand.</param>
        /// <param name="rop2">The second result operand.</param>
        /// <param name="state">The state.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int grandom(mpfr_t.mpfr_t rop1, mpfr_t.mpfr_t rop2, randstate_t state, mpfr_rnd_t rnd) => mpfr_grandom(ref rop1.Value, ref rop2.Value, ref state.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop1">The result operand.</param>
        /// <param name="state">The state.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int erandom(mpfr_t.mpfr_t rop1, randstate_t state, mpfr_rnd_t rnd) => mpfr_erandom(ref rop1.Value, ref state.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="x">The operand.</param>
        public static int get_exp(mpfr_t.mpfr_t x) => mpfr_get_exp(ref x.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="x">The operand.</param>
        /// <param name="e">The exponent.</param>
        public static int set_exp(mpfr_t.mpfr_t x, int e) => mpfr_set_exp(ref x.Value, e);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static int signbit(mpfr_t.mpfr_t op) => mpfr_signbit(ref op.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="s">The sign.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int setsign(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, int s, mpfr_rnd_t rnd) => mpfr_setsign(ref rop.Value, ref op.Value, s, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int copysign(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_copysign(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        public static string get_version()
        {
            nint Str = mpfr_get_version();
            string Result = Marshal.PtrToStringAnsi(Str)!;

            return Result;
        }

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        public static string get_patches()
        {
            nint Str = mpfr_get_patches();
            string Result = Marshal.PtrToStringAnsi(Str)!;

            return Result;
        }

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        public static bool buildopt_tls_p() => mpfr_buildopt_tls_p() != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        public static bool buildopt_float128_p() => mpfr_buildopt_float128_p() != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        public static bool buildopt_decimal_p() => mpfr_buildopt_decimal_p() != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        public static bool buildopt_gmpinternals_p() => mpfr_buildopt_gmpinternals_p() != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        public static bool buildopt_sharedcache_p() => mpfr_buildopt_sharedcache_p() != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        public static string buildopt_tune_case()
        {
            nint Str = mpfr_buildopt_tune_case();
            string Result = Marshal.PtrToStringAnsi(Str)!;

            return Result;
        }
    }
}
