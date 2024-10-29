using System.Runtime.InteropServices;

namespace BigIntegerGMP2.Native.Mpir
{
    internal static partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_init(ref __mpz_t integer);
        public static __mpz_init mpz_init { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_init>(GetMpirPointer(nameof(mpz_init)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_inits(nint arg000,
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
        public static __mpz_inits mpz_inits { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_inits>(GetMpirPointer(nameof(mpz_inits)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_init2(ref __mpz_t integer, mp_bitcnt_t n);
        public static __mpz_init2 mpz_init2 { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_init2>(GetMpirPointer(nameof(mpz_init2)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_clear(ref __mpz_t integer);
        public static __mpz_clear mpz_clear { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_clear>(GetMpirPointer(nameof(mpz_clear)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_realloc2(ref __mpz_t integer, mp_bitcnt_t n);
        public static __mpz_realloc2 mpz_realloc2 { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_realloc2>(GetMpirPointer(nameof(mpz_realloc2)));
    }
}
