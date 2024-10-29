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
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int rint(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_rint(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static int ceil(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op) => mpfr_ceil(ref rop.Value, ref op.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static int floor(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op) => mpfr_floor(ref rop.Value, ref op.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static int round(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op) => mpfr_round(ref rop.Value, ref op.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static int roundeven(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op) => mpfr_roundeven(ref rop.Value, ref op.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static int trunc(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op) => mpfr_trunc(ref rop.Value, ref op.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int rint_ceil(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_rint_ceil(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int rint_floor(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_rint_floor(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int rint_round(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_rint_round(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int rint_roundeven(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_rint_roundeven(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int rint_trunc(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_rint_trunc(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int frac(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_frac(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="iop">The integer result operand.</param>
        /// <param name="fop">The fractional result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int modf(mpfr_t.mpfr_t iop, mpfr_t.mpfr_t fop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_modf(ref iop.Value, ref fop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int fmod(mpfr_t.mpfr_t r, mpfr_t.mpfr_t x, mpfr_t.mpfr_t y, mpfr_rnd_t rnd) => mpfr_fmod(ref r.Value, ref x.Value, ref y.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int fmod_ui(mpfr_t.mpfr_t r, mpfr_t.mpfr_t x, ulong y, mpfr_rnd_t rnd) => mpfr_fmod_ui(ref r.Value, ref x.Value, y, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="q">The q.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int fmodquo(mpfr_t.mpfr_t r, out long q, mpfr_t.mpfr_t x, mpfr_t.mpfr_t y, mpfr_rnd_t rnd) => mpfr_fmodquo(ref r.Value, out q, ref x.Value, ref y.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int remainder(mpfr_t.mpfr_t r, mpfr_t.mpfr_t x, mpfr_t.mpfr_t y, mpfr_rnd_t rnd) => mpfr_remainder(ref r.Value, ref x.Value, ref y.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="q">The q.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int remquo(mpfr_t.mpfr_t r, out long q, mpfr_t.mpfr_t x, mpfr_t.mpfr_t y, mpfr_rnd_t rnd) => mpfr_remquo(ref r.Value, out q, ref x.Value, ref y.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rnd">The rounding mode.</param>
        public static void set_default_rounding_mode(mpfr_rnd_t rnd)
        {
            mpfr_set_default_rounding_mode((__mpfr_rnd_t)rnd);
        }

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        public static mpfr_rnd_t get_default_rounding_mode() => (mpfr_rnd_t)mpfr_get_default_rounding_mode();

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="x">The operand.</param>
        /// <param name="prec">The precision.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int prec_round(mpfr_t.mpfr_t x, ulong prec, mpfr_rnd_t rnd) => mpfr_prec_round(ref x.Value, prec, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="b">The operand.</param>
        /// <param name="err">The error.</param>
        /// <param name="rnd1">The first rounding mode.</param>
        /// <param name="rnd2">The second rounding mode.</param>
        /// <param name="prec">The precision.</param>
        public static bool can_round(mpfr_t.mpfr_t b, int err, mpfr_rnd_t rnd1, mpfr_rnd_t rnd2, ulong prec) => mpfr_can_round(ref b.Value, err, (__mpfr_rnd_t)rnd1, (__mpfr_rnd_t)rnd2, prec) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="x">The operand.</param>
        public static int min_prec(mpfr_t.mpfr_t x) => mpfr_min_prec(ref x.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rnd">The rounding mode.</param>
        public static string print_rnd_mode(mpfr_rnd_t rnd)
        {
            nint Str = mpfr_print_rnd_mode((__mpfr_rnd_t)rnd);
            string Result = Marshal.PtrToStringAnsi(Str)!;

            return Result;
        }
    }
}
