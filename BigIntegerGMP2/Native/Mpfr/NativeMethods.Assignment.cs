using System.Runtime.InteropServices;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Native.Mpfr
{
    internal static partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_set mpfr_set { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set>(GetMpfrPointer(nameof(mpfr_set)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_ui(ref __mpfr_t rop, ulong op, __mpfr_rnd_t rnd);
        public static __mpfr_set_ui mpfr_set_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_ui>(GetMpfrPointer(nameof(mpfr_set_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_si(ref __mpfr_t rop, long op, __mpfr_rnd_t rnd);
        public static __mpfr_set_si mpfr_set_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_si>(GetMpfrPointer(nameof(mpfr_set_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_uj(ref __mpfr_t rop, uint op, __mpfr_rnd_t rnd);
        public static __mpfr_set_uj mpfr_set_uj { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_uj>(GetMpfrPointer($"__g{nameof(mpfr_set_uj)}"));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_sj(ref __mpfr_t rop, int op, __mpfr_rnd_t rnd);
        public static __mpfr_set_sj mpfr_set_sj { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_sj>(GetMpfrPointer($"__g{nameof(mpfr_set_sj)}"));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_flt(ref __mpfr_t rop, float op, __mpfr_rnd_t rnd);
        public static __mpfr_set_flt mpfr_set_flt { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_flt>(GetMpfrPointer(nameof(mpfr_set_flt)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_d(ref __mpfr_t rop, double op, __mpfr_rnd_t rnd);
        public static __mpfr_set_d mpfr_set_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_d>(GetMpfrPointer(nameof(mpfr_set_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_z(ref __mpfr_t rop, ref __mpz_t op, __mpfr_rnd_t rnd);
        public static __mpfr_set_z mpfr_set_z { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_z>(GetMpfrPointer(nameof(mpfr_set_z)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_q(ref __mpfr_t rop, ref __mpq_t op, __mpfr_rnd_t rnd);
        public static __mpfr_set_q mpfr_set_q { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_q>(GetMpfrPointer(nameof(mpfr_set_q)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_f(ref __mpfr_t rop, ref __mpf_t op, __mpfr_rnd_t rnd);
        public static __mpfr_set_f mpfr_set_f { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_f>(GetMpfrPointer(nameof(mpfr_set_f)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_ui_2exp(ref __mpfr_t rop, ulong op, long e, __mpfr_rnd_t rnd);
        public static __mpfr_set_ui_2exp mpfr_set_ui_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_ui_2exp>(GetMpfrPointer(nameof(mpfr_set_ui_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_si_2exp(ref __mpfr_t rop, long op, long e, __mpfr_rnd_t rnd);
        public static __mpfr_set_si_2exp mpfr_set_si_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_si_2exp>(GetMpfrPointer(nameof(mpfr_set_si_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_uj_2exp(ref __mpfr_t rop, uint op, long e, __mpfr_rnd_t rnd);
        public static __mpfr_set_uj_2exp mpfr_set_uj_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_uj_2exp>(GetMpfrPointer($"__g{nameof(mpfr_set_uj_2exp)}"));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_sj_2exp(ref __mpfr_t rop, int op, long e, __mpfr_rnd_t rnd);
        public static __mpfr_set_sj_2exp mpfr_set_sj_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_sj_2exp>(GetMpfrPointer($"__g{nameof(mpfr_set_sj_2exp)}"));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_z_2exp(ref __mpfr_t rop, ref __mpz_t op, long e, __mpfr_rnd_t rnd);
        public static __mpfr_set_z_2exp mpfr_set_z_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_z_2exp>(GetMpfrPointer(nameof(mpfr_set_z_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate int __mpfr_set_str(ref __mpfr_t rop, string str, uint strbase, __mpfr_rnd_t rnd);
        public static __mpfr_set_str mpfr_set_str { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_str>(GetMpfrPointer(nameof(mpfr_set_str)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate int __mpfr_set_nan(ref __mpfr_t x);
        public static __mpfr_set_nan mpfr_set_nan { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_nan>(GetMpfrPointer(nameof(mpfr_set_nan)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate int __mpfr_set_inf(ref __mpfr_t x, int sign);
        public static __mpfr_set_inf mpfr_set_inf { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_inf>(GetMpfrPointer(nameof(mpfr_set_inf)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate int __mpfr_set_zero(ref __mpfr_t x, int sign);
        public static __mpfr_set_zero mpfr_set_zero { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_zero>(GetMpfrPointer(nameof(mpfr_set_zero)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_swap(ref __mpfr_t x, ref __mpfr_t y);
        public static __mpfr_swap mpfr_swap { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_swap>(GetMpfrPointer(nameof(mpfr_swap)));
    }
}
