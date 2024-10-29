using System.Runtime.InteropServices;
using System.Text;

namespace BigIntegerGMP2.Native.Mpir
{
    internal static partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_get_ui(ref __mpz_t op);
        public static __mpz_get_ui mpz_get_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_get_ui>(GetMpirPointer(nameof(mpz_get_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_si __mpz_get_si(ref __mpz_t op);
        public static __mpz_get_si mpz_get_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_get_si>(GetMpirPointer(nameof(mpz_get_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uintmax_t __mpz_get_ux(ref __mpz_t op);
        public static __mpz_get_ux mpz_get_ux { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_get_ux>(GetMpirPointer(nameof(mpz_get_ux)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate intmax_t __mpz_get_sx(ref __mpz_t op);
        public static __mpz_get_sx mpz_get_sx { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_get_sx>(GetMpirPointer(nameof(mpz_get_sx)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double __mpz_get_d(ref __mpz_t op);
        public static __mpz_get_d mpz_get_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_get_d>(GetMpirPointer(nameof(mpz_get_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double __mpz_get_d_2exp(out mpir_si exp, ref __mpz_t op);
        public static __mpz_get_d_2exp mpz_get_d_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_get_d_2exp>(GetMpirPointer(nameof(mpz_get_d_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate nint __mpz_get_str(StringBuilder str, int _base, ref __mpz_t op);
        public static __mpz_get_str mpz_get_str { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_get_str>(GetMpirPointer(nameof(mpz_get_str)));
    }
}
