using System.Runtime.InteropServices;

namespace BigIntegerGMP2.Native.Mpir
{
    internal static partial class NativeMethods
    {
        #region Random State Initialization
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mp_randinit_default(ref __gmp_randstate_t state);
        public static __mp_randinit_default mp_randinit_default { get; } = Marshal.GetDelegateForFunctionPointer<__mp_randinit_default>(GetMpirPointer(nameof(mp_randinit_default)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mp_randinit_mt(ref __gmp_randstate_t state);
        public static __mp_randinit_mt mp_randinit_mt { get; } = Marshal.GetDelegateForFunctionPointer<__mp_randinit_mt>(GetMpirPointer(nameof(mp_randinit_mt)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mp_randinit_lc_2exp(ref __gmp_randstate_t state, ref __mpz_t a, mpir_ui c, mp_bitcnt_t m2exp);
        public static __mp_randinit_lc_2exp mp_randinit_lc_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mp_randinit_lc_2exp>(GetMpirPointer(nameof(mp_randinit_lc_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mp_randinit_lc_2exp_size(ref __gmp_randstate_t state, mp_bitcnt_t size);
        public static __mp_randinit_lc_2exp_size mp_randinit_lc_2exp_size { get; } = Marshal.GetDelegateForFunctionPointer<__mp_randinit_lc_2exp_size>(GetMpirPointer(nameof(mp_randinit_lc_2exp_size)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mp_randinit_set(ref __gmp_randstate_t rop, ref __gmp_randstate_t op);
        public static __mp_randinit_set mp_randinit_set { get; } = Marshal.GetDelegateForFunctionPointer<__mp_randinit_set>(GetMpirPointer(nameof(mp_randinit_set)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mp_randclear(ref __gmp_randstate_t state);
        public static __mp_randclear mp_randclear { get; } = Marshal.GetDelegateForFunctionPointer<__mp_randclear>(GetMpirPointer(nameof(mp_randclear)));
        #endregion

        #region Random State Seeding
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mp_randseed(ref __gmp_randstate_t state, ref __mpz_t seed);
        public static __mp_randseed mp_randseed { get; } = Marshal.GetDelegateForFunctionPointer<__mp_randseed>(GetMpirPointer(nameof(mp_randseed)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mp_randseed_ui(ref __gmp_randstate_t state, mpir_ui seed);
        public static __mp_randseed_ui mp_randseed_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mp_randseed_ui>(GetMpirPointer(nameof(mp_randseed_ui)));
        #endregion

        #region Random State Miscellaneous
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mp_urandomb_ui(ref __gmp_randstate_t state, mpir_ui m2exp);
        public static __mp_urandomb_ui mp_urandomb_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mp_urandomb_ui>(GetMpirPointer(nameof(mp_urandomb_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mp_urandomm_ui(ref __gmp_randstate_t state, mpir_ui n);
        public static __mp_urandomm_ui mp_urandomm_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mp_urandomm_ui>(GetMpirPointer(nameof(mp_urandomm_ui)));
        #endregion
    }
}
