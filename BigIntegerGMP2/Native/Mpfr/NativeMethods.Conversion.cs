using System.Runtime.InteropServices;
using System.Text;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Native.Mpfr
{
    internal static partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float __mpfr_get_flt(ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_get_flt mpfr_get_flt { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_flt>(GetMpfrPointer(nameof(mpfr_get_flt)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double __mpfr_get_d(ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_get_d mpfr_get_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_d>(GetMpfrPointer(nameof(mpfr_get_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate long __mpfr_get_si(ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_get_si mpfr_get_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_si>(GetMpfrPointer(nameof(mpfr_get_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong __mpfr_get_ui(ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_get_ui mpfr_get_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_ui>(GetMpfrPointer(nameof(mpfr_get_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_get_sj(ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_get_sj mpfr_get_sj { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_sj>(GetMpfrPointer($"__gmpfr_{nameof(mpfr_get_sj)}"));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint __mpfr_get_uj(ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_get_uj mpfr_get_uj { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_uj>(GetMpfrPointer($"__gmpfr_{nameof(mpfr_get_uj)}"));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double __mpfr_get_d_2exp(out int exp, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_get_d_2exp mpfr_get_d_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_d_2exp>(GetMpfrPointer(nameof(mpfr_get_d_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_frexp(out int exp, ref __mpfr_t x, ref __mpfr_t y, __mpfr_rnd_t rnd);
        public static __mpfr_frexp mpfr_frexp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_frexp>(GetMpfrPointer(nameof(mpfr_frexp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_get_z_2exp(ref __mpz_t rop, ref __mpfr_t op);
        public static __mpfr_get_z_2exp mpfr_get_z_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_z_2exp>(GetMpfrPointer(nameof(mpfr_get_z_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_get_z(ref __mpz_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_get_z mpfr_get_z { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_z>(GetMpfrPointer(nameof(mpfr_get_z)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_get_q(ref __mpq_t rop, ref __mpfr_t op);
        public static __mpfr_get_q mpfr_get_q { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_q>(GetMpfrPointer(nameof(mpfr_get_q)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_get_f(ref __mpf_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_get_f mpfr_get_f { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_f>(GetMpfrPointer(nameof(mpfr_get_f)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong __mpfr_get_str_ndigits(int b, ulong p);
        public static __mpfr_get_str_ndigits mpfr_get_str_ndigits { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_str_ndigits>(GetMpfrPointer(nameof(mpfr_get_str_ndigits)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpfr_get_str(StringBuilder str, out int expptr, int _base, ulong n, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_get_str mpfr_get_str { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_get_str>(GetMpfrPointer(nameof(mpfr_get_str)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_fits_ulong_p(ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_fits_ulong_p mpfr_fits_ulong_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_fits_ulong_p>(GetMpfrPointer(nameof(mpfr_fits_ulong_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_fits_slong_p(ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_fits_slong_p mpfr_fits_slong_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_fits_slong_p>(GetMpfrPointer(nameof(mpfr_fits_slong_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_fits_uint_p(ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_fits_uint_p mpfr_fits_uint_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_fits_uint_p>(GetMpfrPointer(nameof(mpfr_fits_uint_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_fits_sint_p(ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_fits_sint_p mpfr_fits_sint_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_fits_sint_p>(GetMpfrPointer(nameof(mpfr_fits_sint_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_fits_ushort_p(ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_fits_ushort_p mpfr_fits_ushort_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_fits_ushort_p>(GetMpfrPointer(nameof(mpfr_fits_ushort_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_fits_sshort_p(ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_fits_sshort_p mpfr_fits_sshort_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_fits_sshort_p>(GetMpfrPointer(nameof(mpfr_fits_sshort_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate int __mpfr_sprintf(StringBuilder buf, string format, ref __mpfr_t op, nint end);
        public static __mpfr_sprintf mpfr_sprintf { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sprintf>(GetMpfrPointer(nameof(mpfr_sprintf)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate int __mpfr_snprintf(StringBuilder buf, ulong n, string format, ref __mpfr_t op, nint end);
        public static __mpfr_snprintf mpfr_snprintf { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_snprintf>(GetMpfrPointer(nameof(mpfr_snprintf)));
    }
}
