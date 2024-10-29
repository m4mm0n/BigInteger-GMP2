using System.Runtime.InteropServices;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Native.Mpfr
{
    internal static partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cmp(ref __mpfr_t op1, ref __mpfr_t op2);
        public static __mpfr_cmp mpfr_cmp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cmp>(GetMpfrPointer(nameof(mpfr_cmp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cmp_ui(ref __mpfr_t op1, ulong op2);
        public static __mpfr_cmp_ui mpfr_cmp_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cmp_ui>(GetMpfrPointer(nameof(mpfr_cmp_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cmp_si(ref __mpfr_t op1, long op2);
        public static __mpfr_cmp_si mpfr_cmp_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cmp_si>(GetMpfrPointer(nameof(mpfr_cmp_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cmp_d(ref __mpfr_t op1, double op2);
        public static __mpfr_cmp_d mpfr_cmp_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cmp_d>(GetMpfrPointer(nameof(mpfr_cmp_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cmp_z(ref __mpfr_t op1, ref __mpz_t op2);
        public static __mpfr_cmp_z mpfr_cmp_z { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cmp_z>(GetMpfrPointer(nameof(mpfr_cmp_z)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cmp_q(ref __mpfr_t op1, ref __mpq_t op2);
        public static __mpfr_cmp_q mpfr_cmp_q { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cmp_q>(GetMpfrPointer(nameof(mpfr_cmp_q)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cmp_f(ref __mpfr_t op1, ref __mpf_t op2);
        public static __mpfr_cmp_f mpfr_cmp_f { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cmp_f>(GetMpfrPointer(nameof(mpfr_cmp_f)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cmp_ui_2exp(ref __mpfr_t op1, ulong op2, int e);
        public static __mpfr_cmp_ui_2exp mpfr_cmp_ui_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cmp_ui_2exp>(GetMpfrPointer(nameof(mpfr_cmp_ui_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cmp_si_2exp(ref __mpfr_t op1, long op2, int e);
        public static __mpfr_cmp_si_2exp mpfr_cmp_si_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cmp_si_2exp>(GetMpfrPointer(nameof(mpfr_cmp_si_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cmpabs(ref __mpfr_t op1, ref __mpfr_t op2);
        public static __mpfr_cmpabs mpfr_cmpabs { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cmpabs>(GetMpfrPointer(nameof(mpfr_cmpabs)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_nan_p(ref __mpfr_t op);
        public static __mpfr_nan_p mpfr_nan_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_nan_p>(GetMpfrPointer(nameof(mpfr_nan_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_inf_p(ref __mpfr_t op);
        public static __mpfr_inf_p mpfr_inf_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_inf_p>(GetMpfrPointer(nameof(mpfr_inf_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_number_p(ref __mpfr_t op);
        public static __mpfr_number_p mpfr_number_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_number_p>(GetMpfrPointer(nameof(mpfr_number_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_zero_p(ref __mpfr_t op);
        public static __mpfr_zero_p mpfr_zero_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_zero_p>(GetMpfrPointer(nameof(mpfr_zero_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_regular_p(ref __mpfr_t op);
        public static __mpfr_regular_p mpfr_regular_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_regular_p>(GetMpfrPointer(nameof(mpfr_regular_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sgn(ref __mpfr_t op);
        public static __mpfr_sgn mpfr_sgn { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sgn>(GetMpfrPointer(nameof(mpfr_sgn)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_greater_p(ref __mpfr_t op1, ref __mpfr_t op2);
        public static __mpfr_greater_p mpfr_greater_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_greater_p>(GetMpfrPointer(nameof(mpfr_greater_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_greaterequal_p(ref __mpfr_t op1, ref __mpfr_t op2);
        public static __mpfr_greaterequal_p mpfr_greaterequal_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_greaterequal_p>(GetMpfrPointer(nameof(mpfr_greaterequal_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_less_p(ref __mpfr_t op1, ref __mpfr_t op2);
        public static __mpfr_less_p mpfr_less_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_less_p>(GetMpfrPointer(nameof(mpfr_less_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_lessequal_p(ref __mpfr_t op1, ref __mpfr_t op2);
        public static __mpfr_lessequal_p mpfr_lessequal_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_lessequal_p>(GetMpfrPointer(nameof(mpfr_lessequal_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_equal_p(ref __mpfr_t op1, ref __mpfr_t op2);
        public static __mpfr_equal_p mpfr_equal_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_equal_p>(GetMpfrPointer(nameof(mpfr_equal_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_lessgreater_p(ref __mpfr_t op1, ref __mpfr_t op2);
        public static __mpfr_lessgreater_p mpfr_lessgreater_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_lessgreater_p>(GetMpfrPointer(nameof(mpfr_lessgreater_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_unordered_p(ref __mpfr_t op1, ref __mpfr_t op2);
        public static __mpfr_unordered_p mpfr_unordered_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_unordered_p>(GetMpfrPointer(nameof(mpfr_unordered_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_total_order_p(ref __mpfr_t x, ref __mpfr_t y);
        public static __mpfr_total_order_p mpfr_total_order_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_total_order_p>(GetMpfrPointer(nameof(mpfr_total_order_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_eq(ref __mpfr_t op1, ref __mpfr_t op2, uint op3);
        public static __mpfr_eq mpfr_eq { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_eq>(GetMpfrPointer(nameof(mpfr_eq)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_reldiff(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_reldiff mpfr_reldiff { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_reldiff>(GetMpfrPointer(nameof(mpfr_reldiff)));
    }
}
