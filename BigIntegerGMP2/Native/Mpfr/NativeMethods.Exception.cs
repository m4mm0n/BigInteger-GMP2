using System.Runtime.InteropServices;

namespace BigIntegerGMP2.Native.Mpfr
{
    internal static partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_get_emin();
        public static __mpfr_get_emin mpfr_get_emin { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_emin>(GetMpfrPointer(nameof(mpfr_get_emin)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_get_emax();
        public static __mpfr_get_emax mpfr_get_emax { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_emax>(GetMpfrPointer(nameof(mpfr_get_emax)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_emin(int exp);
        public static __mpfr_set_emin mpfr_set_emin { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_emin>(GetMpfrPointer(nameof(mpfr_set_emin)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_set_emax(int exp);
        public static __mpfr_set_emax mpfr_set_emax { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_emax>(GetMpfrPointer(nameof(mpfr_set_emax)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_get_emin_min();
        public static __mpfr_get_emin_min mpfr_get_emin_min { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_emin_min>(GetMpfrPointer(nameof(mpfr_get_emin_min)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_get_emin_max();
        public static __mpfr_get_emin_max mpfr_get_emin_max { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_emin_max>(GetMpfrPointer(nameof(mpfr_get_emin_max)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_get_emax_min();
        public static __mpfr_get_emax_min mpfr_get_emax_min { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_emax_min>(GetMpfrPointer(nameof(mpfr_get_emax_min)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_get_emax_max();
        public static __mpfr_get_emax_max mpfr_get_emax_max { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_emax_max>(GetMpfrPointer(nameof(mpfr_get_emax_max)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_check_range(ref __mpfr_t x, int t, __mpfr_rnd_t rnd);
        public static __mpfr_check_range mpfr_check_range { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_check_range>(GetMpfrPointer(nameof(mpfr_check_range)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_subnormalize(ref __mpfr_t x, int t, __mpfr_rnd_t rnd);
        public static __mpfr_subnormalize mpfr_subnormalize { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_subnormalize>(GetMpfrPointer(nameof(mpfr_subnormalize)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_clear_underflow();
        public static __mpfr_clear_underflow mpfr_clear_underflow { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_clear_underflow>(GetMpfrPointer(nameof(mpfr_clear_underflow)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_clear_overflow();
        public static __mpfr_clear_overflow mpfr_clear_overflow { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_clear_overflow>(GetMpfrPointer(nameof(mpfr_clear_overflow)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_clear_divby0();
        public static __mpfr_clear_divby0 mpfr_clear_divby0 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_clear_divby0>(GetMpfrPointer(nameof(mpfr_clear_divby0)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_clear_nanflag();
        public static __mpfr_clear_nanflag mpfr_clear_nanflag { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_clear_nanflag>(GetMpfrPointer(nameof(mpfr_clear_nanflag)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_clear_inexflag();
        public static __mpfr_clear_inexflag mpfr_clear_inexflag { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_clear_inexflag>(GetMpfrPointer(nameof(mpfr_clear_inexflag)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_clear_erangeflag();
        public static __mpfr_clear_erangeflag mpfr_clear_erangeflag { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_clear_erangeflag>(GetMpfrPointer(nameof(mpfr_clear_erangeflag)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_clear_flags();
        public static __mpfr_clear_flags mpfr_clear_flags { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_clear_flags>(GetMpfrPointer(nameof(mpfr_clear_flags)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_set_underflow();
        public static __mpfr_set_underflow mpfr_set_underflow { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_underflow>(GetMpfrPointer(nameof(mpfr_set_underflow)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_set_overflow();
        public static __mpfr_set_overflow mpfr_set_overflow { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_overflow>(GetMpfrPointer(nameof(mpfr_set_overflow)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_set_divby0();
        public static __mpfr_set_divby0 mpfr_set_divby0 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_divby0>(GetMpfrPointer(nameof(mpfr_set_divby0)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_set_nanflag();
        public static __mpfr_set_nanflag mpfr_set_nanflag { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_nanflag>(GetMpfrPointer(nameof(mpfr_set_nanflag)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_set_inexflag();
        public static __mpfr_set_inexflag mpfr_set_inexflag { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_inexflag>(GetMpfrPointer(nameof(mpfr_set_inexflag)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_set_erangeflag();
        public static __mpfr_set_erangeflag mpfr_set_erangeflag { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_erangeflag>(GetMpfrPointer(nameof(mpfr_set_erangeflag)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_underflow_p();
        public static __mpfr_underflow_p mpfr_underflow_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_underflow_p>(GetMpfrPointer(nameof(mpfr_underflow_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_overflow_p();
        public static __mpfr_overflow_p mpfr_overflow_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_overflow_p>(GetMpfrPointer(nameof(mpfr_overflow_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_divby0_p();
        public static __mpfr_divby0_p mpfr_divby0_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_divby0_p>(GetMpfrPointer(nameof(mpfr_divby0_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_nanflag_p();
        public static __mpfr_nanflag_p mpfr_nanflag_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_nanflag_p>(GetMpfrPointer(nameof(mpfr_nanflag_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_inexflag_p();
        public static __mpfr_inexflag_p mpfr_inexflag_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_inexflag_p>(GetMpfrPointer(nameof(mpfr_inexflag_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_erangeflag_p();
        public static __mpfr_erangeflag_p mpfr_erangeflag_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_erangeflag_p>(GetMpfrPointer(nameof(mpfr_erangeflag_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_flags_clear(uint mask);
        public static __mpfr_flags_clear mpfr_flags_clear { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_flags_clear>(GetMpfrPointer(nameof(mpfr_flags_clear)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_flags_set(uint mask);
        public static __mpfr_flags_set mpfr_flags_set { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_flags_set>(GetMpfrPointer(nameof(mpfr_flags_set)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint __mpfr_flags_test(uint mask);
        public static __mpfr_flags_test mpfr_flags_test { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_flags_test>(GetMpfrPointer(nameof(mpfr_flags_test)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint __mpfr_flags_save();
        public static __mpfr_flags_save mpfr_flags_save { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_flags_save>(GetMpfrPointer(nameof(mpfr_flags_save)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_flags_restore(uint flags, uint mask);
        public static __mpfr_flags_restore mpfr_flags_restore { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_flags_restore>(GetMpfrPointer(nameof(mpfr_flags_restore)));
    }
}
