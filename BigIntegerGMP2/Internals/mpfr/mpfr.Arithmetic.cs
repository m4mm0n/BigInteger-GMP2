using static BigIntegerGMP2.Native.Mpfr.NativeMethods;

namespace BigIntegerGMP2.Internals.mpfr
{
    /// <summary>
    /// Represents an arbitrary precision floating-point number.
    /// </summary>
    public static partial class mpfr
    {
        #region Add
        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int add(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_add(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int add_ui(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, ulong op2, mpfr_rnd_t rnd) => mpfr_add_ui(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int add_si(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, long op2, mpfr_rnd_t rnd) => mpfr_add_si(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int add_d(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, double op2, mpfr_rnd_t rnd) => mpfr_add_d(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int add_z(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpz_t.mpz_t op2, mpfr_rnd_t rnd) => mpfr_add_z(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int add_q(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpq_t.mpq_t op2, mpfr_rnd_t rnd) => mpfr_add_q(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        #endregion

        #region Sub
        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int sub(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_sub(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int ui_sub(mpfr_t.mpfr_t rop, ulong op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_ui_sub(ref rop.Value, op1, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int sub_ui(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, ulong op2, mpfr_rnd_t rnd) => mpfr_sub_ui(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int si_sub(mpfr_t.mpfr_t rop, long op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_si_sub(ref rop.Value, op1, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int sub_si(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, long op2, mpfr_rnd_t rnd) => mpfr_sub_si(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int d_sub(mpfr_t.mpfr_t rop, double op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_d_sub(ref rop.Value, op1, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int sub_d(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, double op2, mpfr_rnd_t rnd) => mpfr_sub_d(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int z_sub(mpfr_t.mpfr_t rop, mpz_t.mpz_t op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_z_sub(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int sub_z(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpz_t.mpz_t op2, mpfr_rnd_t rnd) => mpfr_sub_z(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int sub_q(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpq_t.mpq_t op2, mpfr_rnd_t rnd) => mpfr_sub_q(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        #endregion

        #region Mul
        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int mul(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_mul(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int mul_ui(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, ulong op2, mpfr_rnd_t rnd) => mpfr_mul_ui(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int mul_2ui(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, ulong op2, mpfr_rnd_t rnd) => mpfr_mul_2ui(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int mul_2si(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, long op2, mpfr_rnd_t rnd) => mpfr_mul_2si(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int mul_si(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, long op2, mpfr_rnd_t rnd) => mpfr_mul_si(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int mul_d(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, double op2, mpfr_rnd_t rnd) => mpfr_mul_d(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int mul_z(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpz_t.mpz_t op2, mpfr_rnd_t rnd) => mpfr_mul_z(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int mul_q(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpq_t.mpq_t op2, mpfr_rnd_t rnd) => mpfr_mul_q(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        #endregion

        #region Div
        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int div(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_div(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int ui_div(mpfr_t.mpfr_t rop, ulong op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_ui_div(ref rop.Value, op1, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int div_ui(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, ulong op2, mpfr_rnd_t rnd) => mpfr_div_ui(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int div_2ui(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, ulong op2, mpfr_rnd_t rnd) => mpfr_div_2ui(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int div_2si(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, long op2, mpfr_rnd_t rnd) => mpfr_div_2si(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int si_div(mpfr_t.mpfr_t rop, long op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_si_div(ref rop.Value, op1, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int div_si(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, long op2, mpfr_rnd_t rnd) => mpfr_div_si(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int d_div(mpfr_t.mpfr_t rop, double op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_d_div(ref rop.Value, op1, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int div_d(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, double op2, mpfr_rnd_t rnd) => mpfr_div_d(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int div_z(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpz_t.mpz_t op2, mpfr_rnd_t rnd) => mpfr_div_z(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int div_q(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpq_t.mpq_t op2, mpfr_rnd_t rnd) => mpfr_div_q(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        #endregion

        #region Pow
        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int sqr(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_sqr(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int sqrt(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_sqrt(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int sqrt_ui(mpfr_t.mpfr_t rop, ulong op, mpfr_rnd_t rnd) => mpfr_sqrt_ui(ref rop.Value, op, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int rec_sqrt(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_rec_sqrt(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int cbrt(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_cbrt(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="n">The n.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int rootn_ui(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, ulong n, mpfr_rnd_t rnd) => mpfr_rootn_ui(ref rop.Value, ref op.Value, n, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="n">The n.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int rootn_si(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, long n, mpfr_rnd_t rnd) => mpfr_rootn_si(ref rop.Value, ref op.Value, n, (__mpfr_rnd_t)rnd);

        #endregion

        #region Misc
        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int neg(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_neg(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int abs(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op, mpfr_rnd_t rnd) => mpfr_abs(ref rop.Value, ref op.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int dim(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_rnd_t rnd) => mpfr_dim(ref rop.Value, ref op1.Value, ref op2.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int fac_ui(mpfr_t.mpfr_t rop, ulong op, mpfr_rnd_t rnd) => mpfr_fac_ui(ref rop.Value, op, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="op3">The third operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int fma(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_t.mpfr_t op3, mpfr_rnd_t rnd) => mpfr_fma(ref rop.Value, ref op1.Value, ref op2.Value, ref op3.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="op3">The third operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int fms(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_t.mpfr_t op3, mpfr_rnd_t rnd) => mpfr_fms(ref rop.Value, ref op1.Value, ref op2.Value, ref op3.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="op3">The third operand.</param>
        /// <param name="op4">The fourth operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int fmma(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_t.mpfr_t op3, mpfr_t.mpfr_t op4, mpfr_rnd_t rnd) => mpfr_fmma(ref rop.Value, ref op1.Value, ref op2.Value, ref op3.Value, ref op4.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="op3">The third operand.</param>
        /// <param name="op4">The fourth operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int fmms(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, mpfr_t.mpfr_t op2, mpfr_t.mpfr_t op3, mpfr_t.mpfr_t op4, mpfr_rnd_t rnd) => mpfr_fmms(ref rop.Value, ref op1.Value, ref op2.Value, ref op3.Value, ref op4.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int hypot(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t x, mpfr_t.mpfr_t y, mpfr_rnd_t rnd) => mpfr_hypot(ref rop.Value, ref x.Value, ref y.Value, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="tab">The values.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int sum(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t[] tab, mpfr_rnd_t rnd) => throw new NotImplementedException();

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="tab">The tab values.</param>
        /// <param name="b">The b values.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int dot(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t[] tab, mpfr_t.mpfr_t[] b, mpfr_rnd_t rnd) => throw new NotImplementedException();

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int mul_2exp(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, ulong op2, mpfr_rnd_t rnd) => mpfr_mul_2exp(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        /// <summary>
        /// See https://www.mpfr.org/mpfr-current/mpfr.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="rnd">The rounding mode.</param>
        public static int div_2exp(mpfr_t.mpfr_t rop, mpfr_t.mpfr_t op1, ulong op2, mpfr_rnd_t rnd) => mpfr_div_2exp(ref rop.Value, ref op1.Value, op2, (__mpfr_rnd_t)rnd);

        #endregion
    }
}
