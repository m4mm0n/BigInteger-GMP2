using System.Runtime.InteropServices;
using System.Text;

namespace BigIntegerGMP2.Native.Mpir
{
    internal static partial class NativeMethods
    {
        #region Miscellaneous
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_canonicalize(ref __mpq_t op);
        public static __mpq_canonicalize mpq_canonicalize { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_canonicalize>(GetMpirPointer(nameof(mpq_canonicalize)));

        public static int mpq_sgn(ref __mpq_t op) => (op.Numerator.LimbCount < 0) ? -1 : ((op.Numerator.LimbCount > 0) ? 1 : 0);

        #endregion

        #region Initialization Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_init(ref __mpq_t dest_rational);
        public static __mpq_init mpq_init { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_init>(GetMpirPointer(nameof(mpq_init)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_inits(nint arg000,
                                         nint arg001,
                                         nint arg002,
                                         nint arg003,
                                         nint arg004,
                                         nint arg005,
                                         nint arg006,
                                         nint arg007,
                                         nint arg078,
                                         nint arg009,
                                         nint arg00A,
                                         nint arg00B,
                                         nint arg00C,
                                         nint arg00D,
                                         nint arg00E,
                                         nint arg00F,
                                         nint arg010,
                                         nint arg011,
                                         nint arg012,
                                         nint arg013,
                                         nint arg014,
                                         nint arg015,
                                         nint arg016,
                                         nint arg017,
                                         nint arg018,
                                         nint arg019,
                                         nint arg01A,
                                         nint arg01B,
                                         nint arg01C,
                                         nint arg01D,
                                         nint arg01E,
                                         nint arg01F);
        public static __mpq_inits mpq_inits { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_inits>(GetMpirPointer(nameof(mpq_inits)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_clear(ref __mpq_t rational_number);
        public static __mpq_clear mpq_clear { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_clear>(GetMpirPointer(nameof(mpq_clear)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_clears(nint arg000,
                                          nint arg001,
                                          nint arg002,
                                          nint arg003,
                                          nint arg004,
                                          nint arg005,
                                          nint arg006,
                                          nint arg007,
                                          nint arg078,
                                          nint arg009,
                                          nint arg00A,
                                          nint arg00B,
                                          nint arg00C,
                                          nint arg00D,
                                          nint arg00E,
                                          nint arg00F,
                                          nint arg010,
                                          nint arg011,
                                          nint arg012,
                                          nint arg013,
                                          nint arg014,
                                          nint arg015,
                                          nint arg016,
                                          nint arg017,
                                          nint arg018,
                                          nint arg019,
                                          nint arg01A,
                                          nint arg01B,
                                          nint arg01C,
                                          nint arg01D,
                                          nint arg01E,
                                          nint arg01F);
        public static __mpq_clears mpq_clears { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_clears>(GetMpirPointer(nameof(mpq_clears)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_set(ref __mpq_t rop, ref __mpq_t op);
        public static __mpq_set mpq_set { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_set>(GetMpirPointer(nameof(mpq_set)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_set_z(ref __mpq_t rop, ref __mpz_t op);
        public static __mpq_set_z mpq_set_z { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_set_z>(GetMpirPointer(nameof(mpq_set_z)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_set_ui(ref __mpq_t rop, mpir_ui op1, mpir_ui op2);
        public static __mpq_set_ui mpq_set_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_set_ui>(GetMpirPointer(nameof(mpq_set_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_set_si(ref __mpq_t rop, mpir_si op1, mpir_ui op2);
        public static __mpq_set_si mpq_set_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_set_si>(GetMpirPointer(nameof(mpq_set_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate int __mpq_set_str(ref __mpq_t rop, string str, int strbase);
        public static __mpq_set_str mpq_set_str { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_set_str>(GetMpirPointer(nameof(mpq_set_str)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_swap(ref __mpq_t rop1, ref __mpq_t rop2);
        public static __mpq_swap mpq_swap { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_swap>(GetMpirPointer(nameof(mpq_swap)));
        #endregion

        #region Conversion Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double __mpq_get_d(ref __mpq_t op);
        public static __mpq_get_d mpq_get_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_get_d>(GetMpirPointer(nameof(mpq_get_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_set_d(ref __mpq_t rop, double op);
        public static __mpq_set_d mpq_set_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_set_d>(GetMpirPointer(nameof(mpq_set_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_set_f(ref __mpq_t rop, ref __mpf_t op);
        public static __mpq_set_f mpq_set_f { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_set_f>(GetMpirPointer(nameof(mpq_set_f)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate nint __mpq_get_str(StringBuilder str, int _base, ref __mpq_t op);
        public static __mpq_get_str mpq_get_str { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_get_str>(GetMpirPointer(nameof(mpq_get_str)));
        #endregion

        #region Arithmetic Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_add(ref __mpq_t rop, ref __mpq_t op1, ref __mpq_t op2);
        public static __mpq_add mpq_add { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_add>(GetMpirPointer(nameof(mpq_add)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_sub(ref __mpq_t rop, ref __mpq_t op1, ref __mpq_t op2);
        public static __mpq_sub mpq_sub { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_sub>(GetMpirPointer(nameof(mpq_sub)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_mul(ref __mpq_t rop, ref __mpq_t op1, ref __mpq_t op2);
        public static __mpq_mul mpq_mul { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_mul>(GetMpirPointer(nameof(mpq_mul)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_mul_2exp(ref __mpq_t rop, ref __mpq_t op1, mp_bitcnt_t op2);
        public static __mpq_mul_2exp mpq_mul_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_mul_2exp>(GetMpirPointer(nameof(mpq_mul_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_div(ref __mpq_t rop, ref __mpq_t op1, ref __mpq_t op2);
        public static __mpq_div mpq_div { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_div>(GetMpirPointer(nameof(mpq_div)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_div_2exp(ref __mpq_t rop, ref __mpq_t op1, mp_bitcnt_t op2);
        public static __mpq_div_2exp mpq_div_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_div_2exp>(GetMpirPointer(nameof(mpq_div_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_neg(ref __mpq_t rop, ref __mpq_t op);
        public static __mpq_neg mpq_neg { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_neg>(GetMpirPointer(nameof(mpq_neg)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_abs(ref __mpq_t rop, ref __mpq_t op);
        public static __mpq_abs mpq_abs { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_abs>(GetMpirPointer(nameof(mpq_abs)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_inv(ref __mpq_t rop, ref __mpq_t op);
        public static __mpq_inv mpq_inv { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_inv>(GetMpirPointer(nameof(mpq_inv)));
        #endregion

        #region Comparison Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpq_cmp(ref __mpq_t op1, ref __mpq_t op2);
        public static __mpq_cmp mpq_cmp { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_cmp>(GetMpirPointer(nameof(mpq_cmp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpq_cmp_z(ref __mpq_t op1, ref __mpz_t op2);
        public static __mpq_cmp_z mpq_cmp_z { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_cmp_z>(GetMpirPointer(nameof(mpq_cmp_z)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpq_cmp_ui(ref __mpq_t op1, mpir_ui num2, mpir_ui den2);
        public static __mpq_cmp_ui mpq_cmp_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_cmp_ui>(GetMpirPointer(nameof(mpq_cmp_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpq_cmp_si(ref __mpq_t op1, mpir_si num2, mpir_ui den2);
        public static __mpq_cmp_si mpq_cmp_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_cmp_si>(GetMpirPointer(nameof(mpq_cmp_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpq_equal(ref __mpq_t op1, ref __mpq_t op2);
        public static __mpq_equal mpq_equal { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_equal>(GetMpirPointer(nameof(mpq_equal)));
        #endregion

        #region Applying Integer Functions to Rationals
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_get_num(ref __mpz_t numerator, ref __mpq_t rational);
        public static __mpq_get_num mpq_get_num { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_get_num>(GetMpirPointer(nameof(mpq_get_num)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_get_den(ref __mpz_t denominator, ref __mpq_t rational);
        public static __mpq_get_den mpq_get_den { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_get_den>(GetMpirPointer(nameof(mpq_get_den)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_set_num(ref __mpq_t rational, ref __mpz_t numerator);
        public static __mpq_set_num mpq_set_num { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_set_num>(GetMpirPointer(nameof(mpq_set_num)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpq_set_den(ref __mpq_t rational, ref __mpz_t denominator);
        public static __mpq_set_den mpq_set_den { get; } = Marshal.GetDelegateForFunctionPointer<__mpq_set_den>(GetMpirPointer(nameof(mpq_set_den)));
        #endregion
    }
}
