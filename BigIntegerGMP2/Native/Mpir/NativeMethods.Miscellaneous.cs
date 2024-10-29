using System.Runtime.InteropServices;

namespace BigIntegerGMP2.Native.Mpir
{
    internal static partial class NativeMethods
    {
        #region Combined Initialization and Assignment Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_init_set(ref __mpz_t rop, ref __mpz_t op);
        public static __mpz_init_set mpz_init_set { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_init_set>(GetMpirPointer(nameof(mpz_init_set)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_init_set_ui(ref __mpz_t rop, mpir_ui op);
        public static __mpz_init_set_ui mpz_init_set_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_init_set_ui>(GetMpirPointer(nameof(mpz_init_set_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_init_set_si(ref __mpz_t rop, mpir_si op);
        public static __mpz_init_set_si mpz_init_set_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_init_set_si>(GetMpirPointer(nameof(mpz_init_set_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_init_set_ux(ref __mpz_t rop, uintmax_t op);
        public static __mpz_init_set_ux mpz_init_set_ux { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_init_set_ux>(GetMpirPointer(nameof(mpz_init_set_ux)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_init_set_sx(ref __mpz_t rop, intmax_t op);
        public static __mpz_init_set_sx mpz_init_set_sx { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_init_set_sx>(GetMpirPointer(nameof(mpz_init_set_sx)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_init_set_d(ref __mpz_t rop, double op);
        public static __mpz_init_set_d mpz_init_set_d { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_init_set_d>(GetMpirPointer(nameof(mpz_init_set_d)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate int __mpz_init_set_str(ref __mpz_t rop, string str, uint strbase);
        public static __mpz_init_set_str mpz_init_set_str { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_init_set_str>(GetMpirPointer(nameof(mpz_init_set_str)));
        #endregion

        #region Number Theoretic Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_probable_prime_p(ref __mpz_t n, ref __gmp_randstate_t state, int prob, mpir_ui div);
        public static __mpz_probable_prime_p mpz_probable_prime_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_probable_prime_p>(GetMpirPointer(nameof(mpz_probable_prime_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_likely_prime_p(ref __mpz_t n, ref __gmp_randstate_t state, mpir_ui div);
        public static __mpz_likely_prime_p mpz_likely_prime_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_likely_prime_p>(GetMpirPointer(nameof(mpz_likely_prime_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_next_prime_candidate(ref __mpz_t rop, ref __mpz_t op, ref __gmp_randstate_t state);
        public static __mpz_next_prime_candidate mpz_next_prime_candidate { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_next_prime_candidate>(GetMpirPointer(nameof(mpz_next_prime_candidate)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_gcd(ref __mpz_t rop, ref __mpz_t op1, ref __mpz_t op2);
        public static __mpz_gcd mpz_gcd { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_gcd>(GetMpirPointer(nameof(mpz_gcd)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_gcd_ui(ref __mpz_t rop, ref __mpz_t op1, mpir_ui op2);
        public static __mpz_gcd_ui mpz_gcd_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_gcd_ui>(GetMpirPointer(nameof(mpz_gcd_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_gcdext(ref __mpz_t g, ref __mpz_t s, ref __mpz_t t, ref __mpz_t a, ref __mpz_t b);
        public static __mpz_gcdext mpz_gcdext { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_gcdext>(GetMpirPointer(nameof(mpz_gcdext)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_lcm(ref __mpz_t rop, ref __mpz_t op1, ref __mpz_t op2);
        public static __mpz_lcm mpz_lcm { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_lcm>(GetMpirPointer(nameof(mpz_lcm)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_lcm_ui(ref __mpz_t rop, ref __mpz_t op1, mpir_ui op2);
        public static __mpz_lcm_ui mpz_lcm_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_lcm_ui>(GetMpirPointer(nameof(mpz_lcm_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_invert(ref __mpz_t rop, ref __mpz_t op1, ref __mpz_t op2);
        public static __mpz_invert mpz_invert { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_invert>(GetMpirPointer(nameof(mpz_invert)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_jacobi(ref __mpz_t a, ref __mpz_t b);
        public static __mpz_jacobi mpz_jacobi { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_jacobi>(GetMpirPointer(nameof(mpz_jacobi)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_kronecker_si(ref __mpz_t a, mpir_si b);
        public static __mpz_kronecker_si mpz_kronecker_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_kronecker_si>(GetMpirPointer(nameof(mpz_kronecker_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_kronecker_ui(ref __mpz_t a, mpir_ui b);
        public static __mpz_kronecker_ui mpz_kronecker_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_kronecker_ui>(GetMpirPointer(nameof(mpz_kronecker_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_si_kronecker(mpir_si a, ref __mpz_t b);
        public static __mpz_si_kronecker mpz_si_kronecker { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_si_kronecker>(GetMpirPointer(nameof(mpz_si_kronecker)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_ui_kronecker(mpir_ui a, ref __mpz_t b);
        public static __mpz_ui_kronecker mpz_ui_kronecker { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_ui_kronecker>(GetMpirPointer(nameof(mpz_ui_kronecker)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mp_bitcnt_t __mpz_remove(ref __mpz_t rop, ref __mpz_t op, ref __mpz_t f);
        public static __mpz_remove mpz_remove { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_remove>(GetMpirPointer(nameof(mpz_remove)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_fac_ui(ref __mpz_t rop, unsignedlongint n);
        public static __mpz_fac_ui mpz_fac_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fac_ui>(GetMpirPointer(nameof(mpz_fac_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_2fac_ui(ref __mpz_t rop, unsignedlongint n);
        public static __mpz_2fac_ui mpz_2fac_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_2fac_ui>(GetMpirPointer(nameof(mpz_2fac_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_mfac_uiui(ref __mpz_t rop, unsignedlongint n, unsignedlongint m);
        public static __mpz_mfac_uiui mpz_mfac_uiui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_mfac_uiui>(GetMpirPointer(nameof(mpz_mfac_uiui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_primorial_ui(ref __mpz_t rop, unsignedlongint n);
        public static __mpz_primorial_ui mpz_primorial_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_primorial_ui>(GetMpirPointer(nameof(mpz_primorial_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_bin_ui(ref __mpz_t rop, ref __mpz_t n, mpir_ui k);
        public static __mpz_bin_ui mpz_bin_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_bin_ui>(GetMpirPointer(nameof(mpz_bin_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_bin_uiui(ref __mpz_t rop, mpir_ui n, mpir_ui k);
        public static __mpz_bin_uiui mpz_bin_uiui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_bin_uiui>(GetMpirPointer(nameof(mpz_bin_uiui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_fib_ui(ref __mpz_t fn, mpir_ui n);
        public static __mpz_fib_ui mpz_fib_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fib_ui>(GetMpirPointer(nameof(mpz_fib_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_fib2_ui(ref __mpz_t fn, ref __mpz_t fnsub1, mpir_ui n);
        public static __mpz_fib2_ui mpz_fib2_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fib2_ui>(GetMpirPointer(nameof(mpz_fib2_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_lucnum_ui(ref __mpz_t ln, mpir_ui n);
        public static __mpz_lucnum_ui mpz_lucnum_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_lucnum_ui>(GetMpirPointer(nameof(mpz_lucnum_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_lucnum2_ui(ref __mpz_t ln, ref __mpz_t lnsub1, mpir_ui n);
        public static __mpz_lucnum2_ui mpz_lucnum2_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_lucnum2_ui>(GetMpirPointer(nameof(mpz_lucnum2_ui)));
        #endregion

        #region Logical and Bit Manipulation Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void BitwizeOperationHandler(ref __mpz_t rop, ref __mpz_t op1, ref __mpz_t op2);
        public static BitwizeOperationHandler mpz_and { get; } = Marshal.GetDelegateForFunctionPointer<BitwizeOperationHandler>(GetMpirPointer(nameof(mpz_and)));
        public static BitwizeOperationHandler mpz_ior { get; } = Marshal.GetDelegateForFunctionPointer<BitwizeOperationHandler>(GetMpirPointer(nameof(mpz_ior)));
        public static BitwizeOperationHandler mpz_xor { get; } = Marshal.GetDelegateForFunctionPointer<BitwizeOperationHandler>(GetMpirPointer(nameof(mpz_xor)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_com(ref __mpz_t rop, ref __mpz_t op);
        public static __mpz_com mpz_com { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_com>(GetMpirPointer(nameof(mpz_com)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mp_bitcnt_t __mpz_popcount(ref __mpz_t op);
        public static __mpz_popcount mpz_popcount { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_popcount>(GetMpirPointer(nameof(mpz_popcount)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mp_bitcnt_t __mpz_hamdist(ref __mpz_t op1, ref __mpz_t op2);
        public static __mpz_hamdist mpz_hamdist { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_hamdist>(GetMpirPointer(nameof(mpz_hamdist)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mp_bitcnt_t __mpz_scan0(ref __mpz_t op, mp_bitcnt_t starting_bit);
        public static __mpz_scan0 mpz_scan0 { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_scan0>(GetMpirPointer(nameof(mpz_scan0)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mp_bitcnt_t __mpz_scan1(ref __mpz_t op, mp_bitcnt_t starting_bit);
        public static __mpz_scan1 mpz_scan1 { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_scan1>(GetMpirPointer(nameof(mpz_scan1)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_setbit(ref __mpz_t rop, mp_bitcnt_t bit_index);
        public static __mpz_setbit mpz_setbit { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_setbit>(GetMpirPointer(nameof(mpz_setbit)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_clrbit(ref __mpz_t rop, mp_bitcnt_t bit_index);
        public static __mpz_clrbit mpz_clrbit { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_clrbit>(GetMpirPointer(nameof(mpz_clrbit)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_combit(ref __mpz_t rop, mp_bitcnt_t bit_index);
        public static __mpz_combit mpz_combit { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_combit>(GetMpirPointer(nameof(mpz_combit)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_tstbit(ref __mpz_t op, mp_bitcnt_t bit_index);
        public static __mpz_tstbit mpz_tstbit { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_tstbit>(GetMpirPointer(nameof(mpz_tstbit)));
        #endregion

        #region Random Number Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_urandomb(ref __mpz_t rop, ref __gmp_randstate_t state, mp_bitcnt_t n);
        public static __mpz_urandomb mpz_urandomb { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_urandomb>(GetMpirPointer(nameof(mpz_urandomb)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_urandomm(ref __mpz_t rop, ref __gmp_randstate_t state, ref __mpz_t n);
        public static __mpz_urandomm mpz_urandomm { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_urandomm>(GetMpirPointer(nameof(mpz_urandomm)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_rrandomb(ref __mpz_t rop, ref __gmp_randstate_t state, mp_bitcnt_t n);
        public static __mpz_rrandomb mpz_rrandomb { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_rrandomb>(GetMpirPointer(nameof(mpz_rrandomb)));
        #endregion

        #region Integer Import and Export
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_import(ref __mpz_t rop, size_t count, int order, size_t size, int endian, size_t nails, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] op);
        public static __mpz_import mpz_import { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_import>(GetMpirPointer(nameof(mpz_import)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_export([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] rop, out size_t countp, int order, size_t size, int endian, size_t nails, ref __mpz_t op);
        public static __mpz_export mpz_export { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_export>(GetMpirPointer(nameof(mpz_export)));
        #endregion

        #region Miscellaneous Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_fits_ulong_p(ref __mpz_t op);
        public static __mpz_fits_ulong_p mpz_fits_ulong_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fits_ulong_p>(GetMpirPointer(nameof(mpz_fits_ulong_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_fits_slong_p(ref __mpz_t op);
        public static __mpz_fits_slong_p mpz_fits_slong_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fits_slong_p>(GetMpirPointer(nameof(mpz_fits_slong_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_fits_uint_p(ref __mpz_t op);
        public static __mpz_fits_uint_p mpz_fits_uint_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fits_uint_p>(GetMpirPointer(nameof(mpz_fits_uint_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_fits_sint_p(ref __mpz_t op);
        public static __mpz_fits_sint_p mpz_fits_sint_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fits_sint_p>(GetMpirPointer(nameof(mpz_fits_sint_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_fits_ushort_p(ref __mpz_t op);
        public static __mpz_fits_ushort_p mpz_fits_ushort_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fits_ushort_p>(GetMpirPointer(nameof(mpz_fits_ushort_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_fits_sshort_p(ref __mpz_t op);
        public static __mpz_fits_sshort_p mpz_fits_sshort_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fits_sshort_p>(GetMpirPointer(nameof(mpz_fits_sshort_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate size_t __mpz_sizeinbase(ref __mpz_t op, uint resultbase);
        public static __mpz_sizeinbase mpz_sizeinbase { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_sizeinbase>(GetMpirPointer(nameof(mpz_sizeinbase)));

        public static int mpz_sgn(ref __mpz_t op) => (op.LimbCount < 0) ? -1 : ((op.LimbCount > 0) ? 1 : 0);

        #endregion
    }
}
