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
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp(mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2) => mpfr_cmp(ref op1.Value, ref op2.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp_ui(mpfr_t.mpfr_t op1, ulong op2) => mpfr_cmp_ui(ref op1.Value, op2);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp_si(mpfr_t.mpfr_t op1, long op2) => mpfr_cmp_si(ref op1.Value, op2);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp_d(mpfr_t.mpfr_t op1, double op2) => mpfr_cmp_d(ref op1.Value, op2);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp_z(mpfr_t.mpfr_t op1, mpz_t.mpz_t op2) => mpfr_cmp_z(ref op1.Value, ref op2.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp_q(mpfr_t.mpfr_t op1, mpq_t.mpq_t op2) => mpfr_cmp_q(ref op1.Value, ref op2.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp_f(mpfr_t.mpfr_t op1, mpf_t.mpf_t op2) => mpfr_cmp_f(ref op1.Value, ref op2.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="e">The exponent.</param>
        public static int cmp_ui_2exp(mpfr_t.mpfr_t op1, ulong op2, int e) => mpfr_cmp_ui_2exp(ref op1.Value, op2, e);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="e">The exponent.</param>
        public static int cmp_si_2exp(mpfr_t.mpfr_t op1, long op2, int e) => mpfr_cmp_si_2exp(ref op1.Value, op2, e);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmpabs(mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2) => mpfr_cmpabs(ref op1.Value, ref op2.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static bool nan_p(mpfr_t.mpfr_t op) => mpfr_nan_p(ref op.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static bool inf_p(mpfr_t.mpfr_t op) => mpfr_inf_p(ref op.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static bool number_p(mpfr_t.mpfr_t op) => mpfr_number_p(ref op.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static bool zero_p(mpfr_t.mpfr_t op) => mpfr_zero_p(ref op.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static bool regular_p(mpfr_t.mpfr_t op) => mpfr_regular_p(ref op.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static int sgn(mpfr_t.mpfr_t op) => mpfr_sgn(ref op.Value);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static bool greater_p(mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2) => mpfr_greater_p(ref op1.Value, ref op2.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static bool greaterequal_p(mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2) => mpfr_greaterequal_p(ref op1.Value, ref op2.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static bool less_p(mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2) => mpfr_less_p(ref op1.Value, ref op2.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static bool lessequal_p(mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2) => mpfr_lessequal_p(ref op1.Value, ref op2.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static bool equal_p(mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2) => mpfr_equal_p(ref op1.Value, ref op2.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static bool lessgreater_p(mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2) => mpfr_lessgreater_p(ref op1.Value, ref op2.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static bool unordered_p(mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2) => mpfr_unordered_p(ref op1.Value, ref op2.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool total_order_p(mpfr_t.mpfr_t x, mpfr_t.mpfr_t y) => mpfr_total_order_p(ref x.Value, ref y.Value) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="op3">The third operand.</param>
        public static bool eq(mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, uint op3) => mpfr_eq(ref op1.Value, ref op2.Value, op3) != 0;

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static void reldiff(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd)
        {
            mpfr_reldiff(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);
        }
    }
}
