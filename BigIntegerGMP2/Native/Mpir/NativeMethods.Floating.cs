using System.Runtime.InteropServices;
using System.Text;

namespace BigIntegerGMP2.Native.Mpir
{
    internal static partial class NativeMethods
    {
        #region Initialization Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_set_default_prec(mp_bitcnt_t prec);
        public static __mpf_set_default_prec mpf_set_default_prec { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_set_default_prec>(GetMpirPointer(nameof(mpf_set_default_prec)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mp_bitcnt_t __mpf_get_default_prec();
        public static __mpf_get_default_prec mpf_get_default_prec { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_get_default_prec>(GetMpirPointer(nameof(mpf_get_default_prec)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_init(ref __mpf_t x);
        public static __mpf_init mpf_init { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_init>(GetMpirPointer(nameof(mpf_init)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_init2(ref __mpf_t x, mp_bitcnt_t prec);
        public static __mpf_init2 mpf_init2 { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_init2>(GetMpirPointer(nameof(mpf_init2)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_inits(nint[] floatings);
        public static __mpf_inits mpf_inits { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_inits>(GetMpirPointer(nameof(mpf_inits)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_clear(ref __mpf_t x);
        public static __mpf_clear mpf_clear { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_clear>(GetMpirPointer(nameof(mpf_clear)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_clears(nint[] floatings);
        public static __mpf_clears mpf_clears { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_clears>(GetMpirPointer(nameof(mpf_clears)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mp_bitcnt_t __mpf_get_prec(ref __mpf_t x);
        public static __mpf_get_prec mpf_get_prec { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_get_prec>(GetMpirPointer(nameof(mpf_get_prec)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_set_prec(ref __mpf_t x, mp_bitcnt_t prec);
        public static __mpf_set_prec mpf_set_prec { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_set_prec>(GetMpirPointer(nameof(mpf_set_prec)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_set_prec_raw(ref __mpf_t x, mp_bitcnt_t prec);
        public static __mpf_set_prec_raw mpf_set_prec_raw { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_set_prec_raw>(GetMpirPointer(nameof(mpf_set_prec_raw)));
        #endregion

        #region Assignment Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_set(ref __mpf_t rop, ref __mpf_t op);
        public static __mpf_set mpf_set { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_set>(GetMpirPointer(nameof(mpf_set)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_set_ui(ref __mpf_t rop, mpir_ui op);
        public static __mpf_set_ui mpf_set_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_set_ui>(GetMpirPointer(nameof(mpf_set_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_set_si(ref __mpf_t rop, mpir_si op);
        public static __mpf_set_si mpf_set_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_set_si>(GetMpirPointer(nameof(mpf_set_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_set_d(ref __mpf_t rop, double op);
        public static __mpf_set_d mpf_set_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_set_d>(GetMpirPointer(nameof(mpf_set_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_set_z(ref __mpf_t rop, ref __mpz_t op);
        public static __mpf_set_z mpf_set_z { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_set_z>(GetMpirPointer(nameof(mpf_set_z)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_set_q(ref __mpf_t rop, ref __mpq_t op);
        public static __mpf_set_q mpf_set_q { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_set_q>(GetMpirPointer(nameof(mpf_set_q)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate int __mpf_set_str(ref __mpf_t rop, string str, uint strbase);
        public static __mpf_set_str mpf_set_str { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_set_str>(GetMpirPointer(nameof(mpf_set_str)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_swap(ref __mpf_t rop1, ref __mpf_t rop2);
        public static __mpf_swap mpf_swap { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_swap>(GetMpirPointer(nameof(mpf_swap)));
        #endregion

        #region Combined Initialization and Assignment Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_init_set(ref __mpf_t rop, ref __mpf_t op);
        public static __mpf_init_set mpf_init_set { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_init_set>(GetMpirPointer(nameof(mpf_init_set)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_init_set_ui(ref __mpf_t rop, mpir_ui op);
        public static __mpf_init_set_ui mpf_init_set_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_init_set_ui>(GetMpirPointer(nameof(mpf_init_set_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_init_set_si(ref __mpf_t rop, mpir_si op);
        public static __mpf_init_set_si mpf_init_set_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_init_set_si>(GetMpirPointer(nameof(mpf_init_set_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_init_set_d(ref __mpf_t rop, double op);
        public static __mpf_init_set_d mpf_init_set_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_init_set_d>(GetMpirPointer(nameof(mpf_init_set_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate int __mpf_init_set_str(ref __mpf_t rop, string str, uint strbase);
        public static __mpf_init_set_str mpf_init_set_str { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_init_set_str>(GetMpirPointer(nameof(mpf_init_set_str)));
        #endregion

        #region Conversion Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double __mpf_get_d(ref __mpf_t op);
        public static __mpf_get_d mpf_get_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_get_d>(GetMpirPointer(nameof(mpf_get_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double __mpf_get_d_2exp(out mpir_si exp, ref __mpf_t op);
        public static __mpf_get_d_2exp mpf_get_d_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_get_d_2exp>(GetMpirPointer(nameof(mpf_get_d_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_si __mpf_get_si(ref __mpf_t op);
        public static __mpf_get_si mpf_get_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_get_si>(GetMpirPointer(nameof(mpf_get_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpf_get_ui(ref __mpf_t op);
        public static __mpf_get_ui mpf_get_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_get_ui>(GetMpirPointer(nameof(mpf_get_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate nint __mpf_get_str(StringBuilder str, out mp_exp_t expptr, int _base, size_t n_digits, ref __mpf_t op);
        public static __mpf_get_str mpf_get_str { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_get_str>(GetMpirPointer(nameof(mpf_get_str)));
        #endregion

        #region Arithmetic Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_add(ref __mpf_t rop, ref __mpf_t op1, ref __mpf_t op2);
        public static __mpf_add mpf_add { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_add>(GetMpirPointer(nameof(mpf_add)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_add_ui(ref __mpf_t rop, ref __mpf_t op1, mpir_ui op2);
        public static __mpf_add_ui mpf_add_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_add_ui>(GetMpirPointer(nameof(mpf_add_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_sub(ref __mpf_t rop, ref __mpf_t op1, ref __mpf_t op2);
        public static __mpf_sub mpf_sub { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_sub>(GetMpirPointer(nameof(mpf_sub)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_ui_sub(ref __mpf_t rop, mpir_ui op1, ref __mpf_t op2);
        public static __mpf_ui_sub mpf_ui_sub { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_ui_sub>(GetMpirPointer(nameof(mpf_ui_sub)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_sub_ui(ref __mpf_t rop, ref __mpf_t op1, mpir_ui op2);
        public static __mpf_sub_ui mpf_sub_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_sub_ui>(GetMpirPointer(nameof(mpf_sub_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_mul(ref __mpf_t rop, ref __mpf_t op1, ref __mpf_t op2);
        public static __mpf_mul mpf_mul { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_mul>(GetMpirPointer(nameof(mpf_mul)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_mul_ui(ref __mpf_t rop, ref __mpf_t op1, mpir_ui op2);
        public static __mpf_mul_ui mpf_mul_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_mul_ui>(GetMpirPointer(nameof(mpf_mul_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_div(ref __mpf_t rop, ref __mpf_t op1, ref __mpf_t op2);
        public static __mpf_div mpf_div { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_div>(GetMpirPointer(nameof(mpf_div)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_ui_div(ref __mpf_t rop, mpir_ui op1, ref __mpf_t op2);
        public static __mpf_ui_div mpf_ui_div { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_ui_div>(GetMpirPointer(nameof(mpf_ui_div)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_div_ui(ref __mpf_t rop, ref __mpf_t op1, mpir_ui op2);
        public static __mpf_div_ui mpf_div_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_div_ui>(GetMpirPointer(nameof(mpf_div_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_sqrt(ref __mpf_t rop, ref __mpf_t op);
        public static __mpf_sqrt mpf_sqrt { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_sqrt>(GetMpirPointer(nameof(mpf_sqrt)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_sqrt_ui(ref __mpf_t rop, mpir_ui op);
        public static __mpf_sqrt_ui mpf_sqrt_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_sqrt_ui>(GetMpirPointer(nameof(mpf_sqrt_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_pow_ui(ref __mpf_t rop, ref __mpf_t op1, mpir_ui op2);
        public static __mpf_pow_ui mpf_pow_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_pow_ui>(GetMpirPointer(nameof(mpf_pow_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_neg(ref __mpf_t rop, ref __mpf_t op);
        public static __mpf_neg mpf_neg { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_neg>(GetMpirPointer(nameof(mpf_neg)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_abs(ref __mpf_t rop, ref __mpf_t op);
        public static __mpf_abs mpf_abs { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_abs>(GetMpirPointer(nameof(mpf_abs)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_mul_2exp(ref __mpf_t rop, ref __mpf_t op1, mp_bitcnt_t op2);
        public static __mpf_mul_2exp mpf_mul_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_mul_2exp>(GetMpirPointer(nameof(mpf_mul_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_div_2exp(ref __mpf_t rop, ref __mpf_t op1, mp_bitcnt_t op2);
        public static __mpf_div_2exp mpf_div_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_div_2exp>(GetMpirPointer(nameof(mpf_div_2exp)));
        #endregion

        #region Conversion Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_cmp(ref __mpf_t op1, ref __mpf_t op2);
        public static __mpf_cmp mpf_cmp { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_cmp>(GetMpirPointer(nameof(mpf_cmp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_cmp_d(ref __mpf_t op1, double op2);
        public static __mpf_cmp_d mpf_cmp_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_cmp_d>(GetMpirPointer(nameof(mpf_cmp_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_cmp_ui(ref __mpf_t op1, mpir_ui op2);
        public static __mpf_cmp_ui mpf_cmp_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_cmp_ui>(GetMpirPointer(nameof(mpf_cmp_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_cmp_si(ref __mpf_t op1, mpir_si op2);
        public static __mpf_cmp_si mpf_cmp_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_cmp_si>(GetMpirPointer(nameof(mpf_cmp_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_eq(ref __mpf_t op1, ref __mpf_t op2, mp_bitcnt_t op3);
        public static __mpf_eq mpf_eq { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_eq>(GetMpirPointer(nameof(mpf_eq)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_reldiff(ref __mpf_t rop, ref __mpf_t op1, ref __mpf_t op2);
        public static __mpf_reldiff mpf_reldiff { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_reldiff>(GetMpirPointer(nameof(mpf_reldiff)));

        public static int mpf_sgn(ref __mpf_t op) => (op.Size < 0) ? -1 : ((op.Size > 0) ? 1 : 0);

        #endregion

        #region Miscellaneous Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_ceil(ref __mpf_t rop, ref __mpf_t op);
        public static __mpf_ceil mpf_ceil { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_ceil>(GetMpirPointer(nameof(mpf_ceil)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_floor(ref __mpf_t rop, ref __mpf_t op);
        public static __mpf_floor mpf_floor { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_floor>(GetMpirPointer(nameof(mpf_floor)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpf_trunc(ref __mpf_t rop, ref __mpf_t op);
        public static __mpf_trunc mpf_trunc { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_trunc>(GetMpirPointer(nameof(mpf_trunc)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_integer_p(ref __mpf_t op);
        public static __mpf_integer_p mpf_integer_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_integer_p>(GetMpirPointer(nameof(mpf_integer_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_fits_ulong_p(ref __mpf_t op);
        public static __mpf_fits_ulong_p mpf_fits_ulong_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_fits_ulong_p>(GetMpirPointer(nameof(mpf_fits_ulong_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_fits_slong_p(ref __mpf_t op);
        public static __mpf_fits_slong_p mpf_fits_slong_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_fits_slong_p>(GetMpirPointer(nameof(mpf_fits_slong_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_fits_uint_p(ref __mpf_t op);
        public static __mpf_fits_uint_p mpf_fits_uint_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_fits_uint_p>(GetMpirPointer(nameof(mpf_fits_uint_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_fits_sint_p(ref __mpf_t op);
        public static __mpf_fits_sint_p mpf_fits_sint_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_fits_sint_p>(GetMpirPointer(nameof(mpf_fits_sint_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_fits_ushort_p(ref __mpf_t op);
        public static __mpf_fits_ushort_p mpf_fits_ushort_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_fits_ushort_p>(GetMpirPointer(nameof(mpf_fits_ushort_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_fits_sshort_p(ref __mpf_t op);
        public static __mpf_fits_sshort_p mpf_fits_sshort_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_fits_sshort_p>(GetMpirPointer(nameof(mpf_fits_sshort_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_urandomb(ref __mpf_t rop, ref __gmp_randstate_t state, mp_bitcnt_t nbits);
        public static __mpf_urandomb mpf_urandomb { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_urandomb>(GetMpirPointer(nameof(mpf_urandomb)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpf_rrandomb(ref __mpf_t rop, ref __gmp_randstate_t state, size_t max_size, mp_exp_t exp);
        public static __mpf_rrandomb mpf_rrandomb { get; } = Marshal.GetDelegateForFunctionPointer<__mpf_rrandomb>(GetMpirPointer(nameof(mpf_rrandomb)));
        #endregion
    }
}
