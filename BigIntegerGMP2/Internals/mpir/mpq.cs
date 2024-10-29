using System.Text;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Internals.mpir
{
    /// <summary>
    /// See http://mpir.org/mpir-3.0.0.pdf.
    /// </summary>
    public static class mpq
    {
        #region Initialization Functions
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="dest_rational">The value.</param>
        public static void init(mpq_t.mpq_t dest_rational) => mpq_init(ref dest_rational.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rationals">The values.</param>
        /// <exception cref="NotImplementedException"></exception>
        public static void inits(params mpq_t.mpq_t[] rationals) => throw new NotImplementedException();

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rational_number">The values.</param>
        public static void clear(mpq_t.mpq_t rational_number) => mpq_clear(ref rational_number.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rationals">The values.</param>
        /// <exception cref="NotImplementedException"></exception>
        public static void clears(params mpq_t.mpq_t[] rationals) => throw new NotImplementedException();

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void set(mpq_t.mpq_t rop, mpq_t.mpq_t op) => mpq_set(ref rop.Value, ref op.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void set_z(mpq_t.mpq_t rop, mpz_t.mpz_t op) => mpq_set_z(ref rop.Value, ref op.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void set_ui(mpq_t.mpq_t rop, ulong op1, ulong op2) => mpq_set_ui(ref rop.Value, (mpir_ui)op1, (mpir_ui)op2);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void set_si(mpq_t.mpq_t rop, long op1, ulong op2) => mpq_set_si(ref rop.Value, (mpir_si)op1, (mpir_ui)op2);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="str">The string.</param>
        /// <param name="strBase">The base.</param>
        public static bool set_str(mpq_t.mpq_t rop, string str, int strBase) => mpq_set_str(ref rop.Value, str, strBase) == 0;

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop1">The first result operand.</param>
        /// <param name="rop2">The second result operand.</param>
        public static void swap(mpq_t.mpq_t rop1, mpq_t.mpq_t rop2) => mpq_swap(ref rop1.Value, ref rop2.Value);

        #endregion

        #region Conversion Functions
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static double get_d(mpq_t.mpq_t op) => mpq_get_d(ref op.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void set_d(mpq_t.mpq_t rop, double op) => mpq_set_d(ref rop.Value, op);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void set_f(mpq_t.mpq_t rop, mpf_t.mpf_t op) => mpq_set_f(ref rop.Value, ref op.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="strBase">The base.</param>
        /// <param name="op">The operand.</param>
        public static void get_str(StringBuilder str, int strBase, mpq_t.mpq_t op) => mpq_get_str(str, strBase, ref op.Value);

        #endregion

        #region Arithmetic Functions
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void add(mpq_t.mpq_t rop, mpq_t.mpq_t op1, mpq_t.mpq_t op2) => mpq_add(ref rop.Value, ref op1.Value, ref op2.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void sub(mpq_t.mpq_t rop, mpq_t.mpq_t op1, mpq_t.mpq_t op2) => mpq_sub(ref rop.Value, ref op1.Value, ref op2.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void mul(mpq_t.mpq_t rop, mpq_t.mpq_t op1, mpq_t.mpq_t op2) => mpq_mul(ref rop.Value, ref op1.Value, ref op2.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void mul_2exp(mpq_t.mpq_t rop, mpq_t.mpq_t op1, ulong op2) => mpq_mul_2exp(ref rop.Value, ref op1.Value, (mp_bitcnt_t)op2);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void div(mpq_t.mpq_t rop, mpq_t.mpq_t op1, mpq_t.mpq_t op2) => mpq_div(ref rop.Value, ref op1.Value, ref op2.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static void div_2exp(mpq_t.mpq_t rop, mpq_t.mpq_t op1, ulong op2)
        {
            mpq_div_2exp(ref rop.Value, ref op1.Value, (mp_bitcnt_t)op2);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void neg(mpq_t.mpq_t rop, mpq_t.mpq_t op)
        {
            mpq_neg(ref rop.Value, ref op.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void abs(mpq_t.mpq_t rop, mpq_t.mpq_t op)
        {
            mpq_abs(ref rop.Value, ref op.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rop">The result operand.</param>
        /// <param name="op">The operand.</param>
        public static void inv(mpq_t.mpq_t rop, mpq_t.mpq_t op)
        {
            mpq_inv(ref rop.Value, ref op.Value);
        }
        #endregion

        #region Comparison Functions
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp(mpq_t.mpq_t op1, mpq_t.mpq_t op2) => mpq_cmp(ref op1.Value, ref op2.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static int cmp_z(mpq_t.mpq_t op1, mpz_t.mpz_t op2) => mpq_cmp_z(ref op1.Value, ref op2.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="num2">The numerator.</param>
        /// <param name="den2">The denominator.</param>
        public static int cmp_ui(mpq_t.mpq_t op1, ulong num2, ulong den2) => mpq_cmp_ui(ref op1.Value, (mpir_ui)num2, (mpir_ui)den2);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="num2">The numerator.</param>
        /// <param name="den2">The denominator.</param>
        public static int cmp_si(mpq_t.mpq_t op1, long num2, ulong den2) => mpq_cmp_si(ref op1.Value, (mpir_si)num2, (mpir_ui)den2);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op">The operand.</param>
        public static int sgn(mpq_t.mpq_t op) => mpq_sgn(ref op.Value);

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="op1">The first operand.</param>
        /// <param name="op2">The second operand.</param>
        public static bool equal(mpq_t.mpq_t op1, mpq_t.mpq_t op2) => mpq_equal(ref op1.Value, ref op2.Value) != 0;

        #endregion

        #region Applying Integer Functions to Rationals
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="numerator">The numerator.</param>
        /// <param name="rational">The value.</param>
        public static void get_num(mpz_t.mpz_t numerator, mpq_t.mpq_t rational)
        {
            mpq_get_num(ref numerator.Value, ref rational.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="denominator">The denominator.</param>
        /// <param name="rational">The value.</param>
        public static void get_den(mpz_t.mpz_t denominator, mpq_t.mpq_t rational)
        {
            mpq_get_den(ref denominator.Value, ref rational.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rational">The value.</param>
        /// <param name="numerator">The numerator.</param>
        public static void set_num(mpq_t.mpq_t rational, mpz_t.mpz_t numerator)
        {
            mpq_set_num(ref rational.Value, ref numerator.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rational">The value.</param>
        /// <param name="denominator">The denominator.</param>
        public static void set_den(mpq_t.mpq_t rational, mpz_t.mpz_t denominator)
        {
            mpq_set_den(ref rational.Value, ref denominator.Value);
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="rational">The value.</param>
        public static void canonicalize(mpq_t.mpq_t rational)
        {
            mpq_canonicalize(ref rational.Value);
        }
        #endregion
    }
}
