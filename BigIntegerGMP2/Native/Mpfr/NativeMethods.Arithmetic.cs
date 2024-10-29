using System.Runtime.InteropServices;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Native.Mpfr
{
    internal static partial class NativeMethods
    {
        #region Add
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_add(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_add mpfr_add { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_add>(GetMpfrPointer(nameof(mpfr_add)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_add_ui(ref __mpfr_t rop, ref __mpfr_t op1, ulong op2, __mpfr_rnd_t rnd);
        public static __mpfr_add_ui mpfr_add_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_add_ui>(GetMpfrPointer(nameof(mpfr_add_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_add_si(ref __mpfr_t rop, ref __mpfr_t op1, long op2, __mpfr_rnd_t rnd);
        public static __mpfr_add_si mpfr_add_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_add_si>(GetMpfrPointer(nameof(mpfr_add_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_add_d(ref __mpfr_t rop, ref __mpfr_t op1, double op2, __mpfr_rnd_t rnd);
        public static __mpfr_add_d mpfr_add_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_add_d>(GetMpfrPointer(nameof(mpfr_add_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_add_z(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpz_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_add_z mpfr_add_z { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_add_z>(GetMpfrPointer(nameof(mpfr_add_z)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_add_q(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpq_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_add_q mpfr_add_q { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_add_q>(GetMpfrPointer(nameof(mpfr_add_q)));
        #endregion

        #region Sub
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sub(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_sub mpfr_sub { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sub>(GetMpfrPointer(nameof(mpfr_sub)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_ui_sub(ref __mpfr_t rop, ulong op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_ui_sub mpfr_ui_sub { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_ui_sub>(GetMpfrPointer(nameof(mpfr_ui_sub)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sub_ui(ref __mpfr_t rop, ref __mpfr_t op1, ulong op2, __mpfr_rnd_t rnd);
        public static __mpfr_sub_ui mpfr_sub_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sub_ui>(GetMpfrPointer(nameof(mpfr_sub_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_si_sub(ref __mpfr_t rop, long op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_si_sub mpfr_si_sub { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_si_sub>(GetMpfrPointer(nameof(mpfr_si_sub)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sub_si(ref __mpfr_t rop, ref __mpfr_t op1, long op2, __mpfr_rnd_t rnd);
        public static __mpfr_sub_si mpfr_sub_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sub_si>(GetMpfrPointer(nameof(mpfr_sub_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_d_sub(ref __mpfr_t rop, double op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_d_sub mpfr_d_sub { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_d_sub>(GetMpfrPointer(nameof(mpfr_d_sub)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sub_d(ref __mpfr_t rop, ref __mpfr_t op1, double op2, __mpfr_rnd_t rnd);
        public static __mpfr_sub_d mpfr_sub_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sub_d>(GetMpfrPointer(nameof(mpfr_sub_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_z_sub(ref __mpfr_t rop, ref __mpz_t op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_z_sub mpfr_z_sub { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_z_sub>(GetMpfrPointer(nameof(mpfr_z_sub)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sub_z(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpz_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_sub_z mpfr_sub_z { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sub_z>(GetMpfrPointer(nameof(mpfr_sub_z)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sub_q(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpq_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_sub_q mpfr_sub_q { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sub_q>(GetMpfrPointer(nameof(mpfr_sub_q)));
        #endregion

        #region Mul
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_mul(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_mul mpfr_mul { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_mul>(GetMpfrPointer(nameof(mpfr_mul)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_mul_ui(ref __mpfr_t rop, ref __mpfr_t op1, ulong op2, __mpfr_rnd_t rnd);
        public static __mpfr_mul_ui mpfr_mul_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_mul_ui>(GetMpfrPointer(nameof(mpfr_mul_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_mul_2ui(ref __mpfr_t rop, ref __mpfr_t op1, ulong op2, __mpfr_rnd_t rnd);
        public static __mpfr_mul_2ui mpfr_mul_2ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_mul_2ui>(GetMpfrPointer(nameof(mpfr_mul_2ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_mul_2si(ref __mpfr_t rop, ref __mpfr_t op1, long op2, __mpfr_rnd_t rnd);
        public static __mpfr_mul_2si mpfr_mul_2si { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_mul_2si>(GetMpfrPointer(nameof(mpfr_mul_2si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_mul_si(ref __mpfr_t rop, ref __mpfr_t op1, long op2, __mpfr_rnd_t rnd);
        public static __mpfr_mul_si mpfr_mul_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_mul_si>(GetMpfrPointer(nameof(mpfr_mul_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_mul_d(ref __mpfr_t rop, ref __mpfr_t op1, double op2, __mpfr_rnd_t rnd);
        public static __mpfr_mul_d mpfr_mul_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_mul_d>(GetMpfrPointer(nameof(mpfr_mul_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_mul_z(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpz_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_mul_z mpfr_mul_z { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_mul_z>(GetMpfrPointer(nameof(mpfr_mul_z)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_mul_q(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpq_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_mul_q mpfr_mul_q { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_mul_q>(GetMpfrPointer(nameof(mpfr_mul_q)));
        #endregion

        #region Div
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_div(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_div mpfr_div { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_div>(GetMpfrPointer(nameof(mpfr_div)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_ui_div(ref __mpfr_t rop, ulong op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_ui_div mpfr_ui_div { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_ui_div>(GetMpfrPointer(nameof(mpfr_ui_div)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_div_ui(ref __mpfr_t rop, ref __mpfr_t op1, ulong op2, __mpfr_rnd_t rnd);
        public static __mpfr_div_ui mpfr_div_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_div_ui>(GetMpfrPointer(nameof(mpfr_div_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_div_2ui(ref __mpfr_t rop, ref __mpfr_t op1, ulong op2, __mpfr_rnd_t rnd);
        public static __mpfr_div_2ui mpfr_div_2ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_div_2ui>(GetMpfrPointer(nameof(mpfr_div_2ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_div_2si(ref __mpfr_t rop, ref __mpfr_t op1, long op2, __mpfr_rnd_t rnd);
        public static __mpfr_div_2si mpfr_div_2si { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_div_2si>(GetMpfrPointer(nameof(mpfr_div_2si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_si_div(ref __mpfr_t rop, long op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_si_div mpfr_si_div { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_si_div>(GetMpfrPointer(nameof(mpfr_si_div)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_div_si(ref __mpfr_t rop, ref __mpfr_t op1, long op2, __mpfr_rnd_t rnd);
        public static __mpfr_div_si mpfr_div_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_div_si>(GetMpfrPointer(nameof(mpfr_div_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_d_div(ref __mpfr_t rop, double op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_d_div mpfr_d_div { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_d_div>(GetMpfrPointer(nameof(mpfr_d_div)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_div_d(ref __mpfr_t rop, ref __mpfr_t op1, double op2, __mpfr_rnd_t rnd);
        public static __mpfr_div_d mpfr_div_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_div_d>(GetMpfrPointer(nameof(mpfr_div_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_div_z(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpz_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_div_z mpfr_div_z { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_div_z>(GetMpfrPointer(nameof(mpfr_div_z)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_div_q(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpq_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_div_q mpfr_div_q { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_div_q>(GetMpfrPointer(nameof(mpfr_div_q)));
        #endregion

        #region Pow
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sqr(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_sqr mpfr_sqr { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sqr>(GetMpfrPointer(nameof(mpfr_sqr)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sqrt(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_sqrt mpfr_sqrt { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sqrt>(GetMpfrPointer(nameof(mpfr_sqrt)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sqrt_ui(ref __mpfr_t rop, ulong op, __mpfr_rnd_t rnd);
        public static __mpfr_sqrt_ui mpfr_sqrt_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sqrt_ui>(GetMpfrPointer(nameof(mpfr_sqrt_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_rec_sqrt(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_rec_sqrt mpfr_rec_sqrt { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_rec_sqrt>(GetMpfrPointer(nameof(mpfr_rec_sqrt)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cbrt(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_cbrt mpfr_cbrt { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cbrt>(GetMpfrPointer(nameof(mpfr_cbrt)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_rootn_ui(ref __mpfr_t rop, ref __mpfr_t op, ulong n, __mpfr_rnd_t rnd);
        public static __mpfr_rootn_ui mpfr_rootn_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_rootn_ui>(GetMpfrPointer(nameof(mpfr_rootn_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_rootn_si(ref __mpfr_t rop, ref __mpfr_t op, long n, __mpfr_rnd_t rnd);
        public static __mpfr_rootn_si mpfr_rootn_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_rootn_si>(GetMpfrPointer(nameof(mpfr_rootn_si)));
        #endregion

        #region Misc
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_neg(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_neg mpfr_neg { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_neg>(GetMpfrPointer(nameof(mpfr_neg)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_abs(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_abs mpfr_abs { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_abs>(GetMpfrPointer(nameof(mpfr_abs)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_dim(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_dim mpfr_dim { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_dim>(GetMpfrPointer(nameof(mpfr_dim)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_fac_ui(ref __mpfr_t rop, ulong op, __mpfr_rnd_t rnd);
        public static __mpfr_fac_ui mpfr_fac_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_fac_ui>(GetMpfrPointer(nameof(mpfr_fac_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_fma(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, ref __mpfr_t op3, __mpfr_rnd_t rnd);
        public static __mpfr_fma mpfr_fma { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_fma>(GetMpfrPointer(nameof(mpfr_fma)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_fms(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, ref __mpfr_t op3, __mpfr_rnd_t rnd);
        public static __mpfr_fms mpfr_fms { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_fms>(GetMpfrPointer(nameof(mpfr_fms)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_fmma(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, ref __mpfr_t op3, ref __mpfr_t op4, __mpfr_rnd_t rnd);
        public static __mpfr_fmma mpfr_fmma { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_fmma>(GetMpfrPointer(nameof(mpfr_fmma)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_fmms(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, ref __mpfr_t op3, ref __mpfr_t op4, __mpfr_rnd_t rnd);
        public static __mpfr_fmms mpfr_fmms { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_fmms>(GetMpfrPointer(nameof(mpfr_fmms)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_hypot(ref __mpfr_t rop, ref __mpfr_t x, ref __mpfr_t y, __mpfr_rnd_t rnd);
        public static __mpfr_hypot mpfr_hypot { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_hypot>(GetMpfrPointer(nameof(mpfr_hypot)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_mul_2exp(ref __mpfr_t rop, ref __mpfr_t op1, ulong op2, __mpfr_rnd_t rnd);
        public static __mpfr_mul_2exp mpfr_mul_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_mul_2exp>(GetMpfrPointer(nameof(mpfr_mul_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_div_2exp(ref __mpfr_t rop, ref __mpfr_t op1, ulong op2, __mpfr_rnd_t rnd);
        public static __mpfr_div_2exp mpfr_div_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_div_2exp>(GetMpfrPointer(nameof(mpfr_div_2exp)));
        #endregion
    }
}
