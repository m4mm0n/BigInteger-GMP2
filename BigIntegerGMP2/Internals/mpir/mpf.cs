using System.Text;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Internals.mpir
{
    /// <summary>
    /// See http://mpir.org/mpir-3.0.0.pdf.
    /// </summary>
    public static class mpf
    {
        #region Initialization Functions
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="prec">The default precision.</param>
        public static void set_default_prec(ulong prec)
        {
            mpf_set_default_prec((mp_bitcnt_t)prec);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        public static ulong get_default_prec() => (ulong)mpf_get_default_prec();

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="x">The value.</param>
        public static void init(mpf_t.mpf_t x)
        {
            mpf_init(ref x.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="x">The value.</param>
        /// <param name="prec">The precision.</param>
        public static void init2(mpf_t.mpf_t x, ulong prec)
        {
            mpf_init2(ref x.Value, (mp_bitcnt_t)prec);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="floatings">Values.</param>
        public static void inits(params mpf_t.mpf_t[] floatings)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="x">The value.</param>
        public static void clear(mpf_t.mpf_t x)
        {
            mpf_clear(ref x.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="floatings">Values.</param>
        public static void clears(params mpf_t.mpf_t[] floatings)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static ulong get_prec(mpf_t.mpf_t op) => (ulong)mpf_get_prec(ref op.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="prec">The precision.</param>
        public static void set_prec(mpf_t.mpf_t op, ulong prec)
        {
            mpf_set_prec(ref op.Value, (mp_bitcnt_t)prec);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="prec">The precision.</param>
        public static void set_prec_raw(mpf_t.mpf_t op, ulong prec)
        {
            mpf_set_prec_raw(ref op.Value, (mp_bitcnt_t)prec);
        }
        #endregion

        #region Assignment Functions
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void set(mpf_t.mpf_t rop, mpf_t.mpf_t op)
        {
            mpf_set(ref rop.Value, ref op.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void set_ui(mpf_t.mpf_t rop, ulong op)
        {
            mpf_set_ui(ref rop.Value, (mpir_ui)op);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void set_si(mpf_t.mpf_t rop, long op)
        {
            mpf_set_si(ref rop.Value, (mpir_si)op);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void set_d(mpf_t.mpf_t rop, double op)
        {
            mpf_set_d(ref rop.Value, op);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void set_z(mpf_t.mpf_t rop, mpz_t.mpz_t op)
        {
            mpf_set_z(ref rop.Value, ref op.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void set_q(mpf_t.mpf_t rop, mpq_t.mpq_t op)
        {
            mpf_set_q(ref rop.Value, ref op.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="str">The string.</param>
        /// <param name="strbase">The base.</param>
        public static int set_str(mpf_t.mpf_t rop, string str, uint strbase) => mpf_set_str(ref rop.Value, str, strbase);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop1">The first result operand.</param>
        /// <param name="rop2">The second result operand.</param>
        public static void swap(mpf_t.mpf_t rop1, mpf_t.mpf_t rop2)
        {
            mpf_swap(ref rop1.Value, ref rop2.Value);
        }
        #endregion

        #region Combined Initialization and Assignment Functions
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void init_set(mpf_t.mpf_t rop, mpf_t.mpf_t op)
        {
            mpf_init_set(ref rop.Value, ref op.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void init_set_ui(mpf_t.mpf_t rop, ulong op)
        {
            mpf_init_set_ui(ref rop.Value, (mpir_ui)op);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void init_set_si(mpf_t.mpf_t rop, long op)
        {
            mpf_init_set_si(ref rop.Value, (mpir_si)op);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void init_set_d(mpf_t.mpf_t rop, double op)
        {
            mpf_init_set_d(ref rop.Value, op);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="str">The string.</param>
        /// <param name="strbase">The base.</param>
        public static int init_set_str(mpf_t.mpf_t rop, string str, uint strbase) => mpf_init_set_str(ref rop.Value, str, strbase);

        #endregion

        #region Conversion Functions
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static double get_d(mpf_t.mpf_t op) => mpf_get_d(ref op.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        /// <param name="d">The double value.</param>
        /// <param name="exp">The exponent.</param>
        public static void get_d_2exp(mpf_t.mpf_t op, out double d, out long exp)
        {
            d = mpf_get_d_2exp(out mpir_si expStr, ref op.Value);
            exp = (long)expStr;
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static ulong get_ui(mpf_t.mpf_t op) => (ulong)mpf_get_ui(ref op.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static long get_si(mpf_t.mpf_t op) => (long)mpf_get_si(ref op.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="expptr">The exponent.</param>
        /// <param name="strBase">The base.</param>
        /// <param name="n_digits">The count of digits.</param>
        /// <param name="op">The operand.</param>
        public static void get_str(StringBuilder str, out int expptr, int strBase, ulong n_digits, mpf_t.mpf_t op)
        {
            mpf_get_str(str, out mp_exp_t expstr, strBase, (size_t)n_digits, ref op.Value);
            expptr = (int)expstr;
        }
        #endregion

        #region Arithmetic Functions
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void add(mpf_t.mpf_t rop, mpf_t.mpf_t op1, mpf_t.mpf_t op2)
        {
            mpf_add(ref rop.Value, ref op1.Value, ref op2.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void add_ui(mpf_t.mpf_t rop, mpf_t.mpf_t op1, ulong op2)
        {
            mpf_add_ui(ref rop.Value, ref op1.Value, (mpir_ui)op2);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void sub(mpf_t.mpf_t rop, mpf_t.mpf_t op1, mpf_t.mpf_t op2)
        {
            mpf_sub(ref rop.Value, ref op1.Value, ref op2.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void ui_sub(mpf_t.mpf_t rop, ulong op1, mpf_t.mpf_t op2)
        {
            mpf_ui_sub(ref rop.Value, (mpir_ui)op1, ref op2.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void sub_ui(mpf_t.mpf_t rop, mpf_t.mpf_t op1, ulong op2)
        {
            mpf_sub_ui(ref rop.Value, ref op1.Value, (mpir_ui)op2);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void mul(mpf_t.mpf_t rop, mpf_t.mpf_t op1, mpf_t.mpf_t op2)
        {
            mpf_mul(ref rop.Value, ref op1.Value, ref op2.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void mul_ui(mpf_t.mpf_t rop, mpf_t.mpf_t op1, ulong op2)
        {
            mpf_mul_ui(ref rop.Value, ref op1.Value, (mpir_ui)op2);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void div(mpf_t.mpf_t rop, mpf_t.mpf_t op1, mpf_t.mpf_t op2)
        {
            mpf_div(ref rop.Value, ref op1.Value, ref op2.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void ui_div(mpf_t.mpf_t rop, ulong op1, mpf_t.mpf_t op2)
        {
            mpf_ui_div(ref rop.Value, (mpir_ui)op1, ref op2.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void div_ui(mpf_t.mpf_t rop, mpf_t.mpf_t op1, ulong op2)
        {
            mpf_div_ui(ref rop.Value, ref op1.Value, (mpir_ui)op2);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void sqrt(mpf_t.mpf_t rop, mpf_t.mpf_t op)
        {
            mpf_sqrt(ref rop.Value, ref op.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void sqrt_ui(mpf_t.mpf_t rop, ulong op)
        {
            mpf_sqrt_ui(ref rop.Value, (mpir_ui)op);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void pow_ui(mpf_t.mpf_t rop, mpf_t.mpf_t op1, ulong op2)
        {
            mpf_pow_ui(ref rop.Value, ref op1.Value, (mpir_ui)op2);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void neg(mpf_t.mpf_t rop, mpf_t.mpf_t op)
        {
            mpf_neg(ref rop.Value, ref op.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void abs(mpf_t.mpf_t rop, mpf_t.mpf_t op)
        {
            mpf_abs(ref rop.Value, ref op.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void mul_2exp(mpf_t.mpf_t rop, mpf_t.mpf_t op1, ulong op2)
        {
            mpf_mul_2exp(ref rop.Value, ref op1.Value, (mp_bitcnt_t)op2);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void div_2exp(mpf_t.mpf_t rop, mpf_t.mpf_t op1, ulong op2)
        {
            mpf_div_2exp(ref rop.Value, ref op1.Value, (mp_bitcnt_t)op2);
        }
        #endregion

        #region Conversion Functions
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp(mpf_t.mpf_t op1, mpf_t.mpf_t op2) => mpf_cmp(ref op1.Value, ref op2.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp_d(mpf_t.mpf_t op1, double op2) => mpf_cmp_d(ref op1.Value, op2);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp_si(mpf_t.mpf_t op1, long op2) => mpf_cmp_si(ref op1.Value, (mpir_si)op2);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp_ui(mpf_t.mpf_t op1, ulong op2) => mpf_cmp_ui(ref op1.Value, (mpir_ui)op2);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        /// <param name="op3">The third operand.</param>
        public static int eq(mpf_t.mpf_t op1, mpf_t.mpf_t op2, ulong op3) => mpf_eq(ref op1.Value, ref op2.Value, (mp_bitcnt_t)op3);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void reldiff(mpf_t.mpf_t rop, mpf_t.mpf_t op1, mpf_t.mpf_t op2)
        {
            mpf_reldiff(ref rop.Value, ref op1.Value, ref op2.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static int sgn(mpf_t.mpf_t op) => mpf_sgn(ref op.Value);

        #endregion

        #region Miscellaneous Functions
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void ceil(mpf_t.mpf_t rop, mpf_t.mpf_t op)
        {
            mpf_ceil(ref rop.Value, ref op.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void floor(mpf_t.mpf_t rop, mpf_t.mpf_t op)
        {
            mpf_floor(ref rop.Value, ref op.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void trunc(mpf_t.mpf_t rop, mpf_t.mpf_t op)
        {
            mpf_trunc(ref rop.Value, ref op.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static bool integer_p(mpf_t.mpf_t op) => mpf_integer_p(ref op.Value) != 0;

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static bool fits_ulong_p(mpf_t.mpf_t op) => mpf_fits_ulong_p(ref op.Value) != 0;

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static bool fits_slong_p(mpf_t.mpf_t op) => mpf_fits_slong_p(ref op.Value) != 0;

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static bool fits_uint_p(mpf_t.mpf_t op) => mpf_fits_uint_p(ref op.Value) != 0;

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static bool fits_sint_p(mpf_t.mpf_t op) => mpf_fits_sint_p(ref op.Value) != 0;

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static bool fits_ushort_p(mpf_t.mpf_t op) => mpf_fits_ushort_p(ref op.Value) != 0;

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static bool fits_sshort_p(mpf_t.mpf_t op) => mpf_fits_sshort_p(ref op.Value) != 0;

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="state">The state.</param>
        /// <param name="nbits">The count of bits.</param>
        public static void urandomb(mpf_t.mpf_t rop, randstate_t state, ulong nbits)
        {
            mpf_urandomb(ref rop.Value, ref state.Value, (mp_bitcnt_t)nbits);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="state">The state.</param>
        /// <param name="max_size">The max size.</param>
        /// <param name="exp">The exponent.</param>
        public static void rrandomb(mpf_t.mpf_t rop, randstate_t state, ulong max_size, int exp)
        {
            mp_exp_t e = (mp_exp_t)exp;
            mpf_rrandomb(ref rop.Value, ref state.Value, (size_t)max_size, e);
        }
        #endregion
    }
}
