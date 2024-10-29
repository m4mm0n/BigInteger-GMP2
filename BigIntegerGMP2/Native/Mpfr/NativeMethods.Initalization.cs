using System.Runtime.InteropServices;

namespace BigIntegerGMP2.Native.Mpfr
{
    internal static partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_init2(ref __mpfr_t x, ulong prec);
        public static __mpfr_init2 mpfr_init2 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_init2>(GetMpfrPointer(nameof(mpfr_init2)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_inits2(ulong prec,
            nint arg000,
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
        public static __mpfr_inits2 mpfr_inits2 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_inits2>(GetMpfrPointer(nameof(mpfr_inits2)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_clear(ref __mpfr_t x);
        public static __mpfr_clear mpfr_clear { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_clear>(GetMpfrPointer(nameof(mpfr_clear)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_clears(
            nint arg000,
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
        public static __mpfr_clears mpfr_clears { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_clears>(GetMpfrPointer(nameof(mpfr_clears)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_init(ref __mpfr_t x);
        public static __mpfr_init mpfr_init { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_init>(GetMpfrPointer(nameof(mpfr_init)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_inits(
            nint arg000,
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
        public static __mpfr_inits mpfr_inits { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_inits>(GetMpfrPointer(nameof(mpfr_inits)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_set_default_prec(ulong prec);
        public static __mpfr_set_default_prec mpfr_set_default_prec { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_default_prec>(GetMpfrPointer(nameof(mpfr_set_default_prec)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_set_prec(ref __mpfr_t x, ulong prec);
        public static __mpfr_set_prec mpfr_set_prec { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_prec>(GetMpfrPointer(nameof(mpfr_set_prec)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong __mpfr_get_prec(ref __mpfr_t x);
        public static __mpfr_get_prec mpfr_get_prec { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_prec>(GetMpfrPointer(nameof(mpfr_get_prec)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_set_prec_raw(ref __mpfr_t x, ulong prec);
        public static __mpfr_set_prec_raw mpfr_set_prec_raw { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_set_prec_raw>(GetMpfrPointer(nameof(mpfr_set_prec_raw)));
    }
}
