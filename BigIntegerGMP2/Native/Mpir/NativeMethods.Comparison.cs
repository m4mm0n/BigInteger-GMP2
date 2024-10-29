using System.Runtime.InteropServices;

namespace BigIntegerGMP2.Native.Mpir
{
    internal static partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_cmp(ref __mpz_t op1, ref __mpz_t op2);
        public static __mpz_cmp mpz_cmp { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cmp>(GetMpirPointer(nameof(mpz_cmp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_cmp_d(ref __mpz_t op1, double op2);
        public static __mpz_cmp_d mpz_cmp_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cmp_d>(GetMpirPointer(nameof(mpz_cmp_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_cmp_si(ref __mpz_t op1, mpir_si op2);
        public static __mpz_cmp_si mpz_cmp_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cmp_si>(GetMpirPointer(nameof(mpz_cmp_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_cmp_ui(ref __mpz_t op1, mpir_ui op2);
        public static __mpz_cmp_ui mpz_cmp_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cmp_ui>(GetMpirPointer(nameof(mpz_cmp_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_cmpabs(ref __mpz_t op1, ref __mpz_t op2);
        public static __mpz_cmpabs mpz_cmpabs { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cmpabs>(GetMpirPointer(nameof(mpz_cmpabs)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_cmpabs_d(ref __mpz_t op1, double op2);
        public static __mpz_cmpabs_d mpz_cmpabs_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cmpabs_d>(GetMpirPointer(nameof(mpz_cmpabs_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_cmpabs_ui(ref __mpz_t op1, mpir_ui op2);
        public static __mpz_cmpabs_ui mpz_cmpabs_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cmpabs_ui>(GetMpirPointer(nameof(mpz_cmpabs_ui)));
    }
}
