using System.Runtime.InteropServices;

namespace BigIntegerGMP2.Native.Mpir
{
    internal static partial class NativeMethods
    {
        #region Arithmetic Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_add(ref __mpz_t rop, ref __mpz_t op1, ref __mpz_t op2);
        public static __mpz_add mpz_add { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_add>(GetMpirPointer(nameof(mpz_add)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_add_ui(ref __mpz_t rop, ref __mpz_t op1, mpir_ui op2);
        public static __mpz_add_ui mpz_add_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_add_ui>(GetMpirPointer(nameof(mpz_add_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_sub(ref __mpz_t rop, ref __mpz_t op1, ref __mpz_t op2);
        public static __mpz_sub mpz_sub { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_sub>(GetMpirPointer(nameof(mpz_sub)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_sub_ui(ref __mpz_t rop, ref __mpz_t op1, mpir_ui op2);
        public static __mpz_sub_ui mpz_sub_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_sub_ui>(GetMpirPointer(nameof(mpz_sub_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_ui_sub(ref __mpz_t rop, mpir_ui op1, ref __mpz_t op2);
        public static __mpz_ui_sub mpz_ui_sub { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_ui_sub>(GetMpirPointer(nameof(mpz_ui_sub)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_mul(ref __mpz_t rop, ref __mpz_t op1, ref __mpz_t op2);
        public static __mpz_mul mpz_mul { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_mul>(GetMpirPointer(nameof(mpz_mul)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_mul_si(ref __mpz_t rop, ref __mpz_t op1, mpir_si op2);
        public static __mpz_mul_si mpz_mul_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_mul_si>(GetMpirPointer(nameof(mpz_mul_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_mul_ui(ref __mpz_t rop, ref __mpz_t op1, mpir_ui op2);
        public static __mpz_mul_ui mpz_mul_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_mul_ui>(GetMpirPointer(nameof(mpz_mul_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_addmul(ref __mpz_t rop, ref __mpz_t op1, ref __mpz_t op2);
        public static __mpz_addmul mpz_addmul { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_addmul>(GetMpirPointer(nameof(mpz_addmul)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_addmul_ui(ref __mpz_t rop, ref __mpz_t op1, mpir_ui op2);
        public static __mpz_addmul_ui mpz_addmul_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_addmul_ui>(GetMpirPointer(nameof(mpz_addmul_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_submul(ref __mpz_t rop, ref __mpz_t op1, ref __mpz_t op2);
        public static __mpz_submul mpz_submul { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_submul>(GetMpirPointer(nameof(mpz_submul)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_submul_ui(ref __mpz_t rop, ref __mpz_t op1, mpir_ui op2);
        public static __mpz_submul_ui mpz_submul_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_submul_ui>(GetMpirPointer(nameof(mpz_submul_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_mul_2exp(ref __mpz_t rop, ref __mpz_t op1, mp_bitcnt_t op2);
        public static __mpz_mul_2exp mpz_mul_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_mul_2exp>(GetMpirPointer(nameof(mpz_mul_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_neg(ref __mpz_t rop, ref __mpz_t op);
        public static __mpz_neg mpz_neg { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_neg>(GetMpirPointer(nameof(mpz_neg)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_abs(ref __mpz_t rop, ref __mpz_t op);
        public static __mpz_abs mpz_abs { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_abs>(GetMpirPointer(nameof(mpz_abs)));
        #endregion

        #region Division Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_cdiv_q(ref __mpz_t q, ref __mpz_t n, ref __mpz_t d);
        public static __mpz_cdiv_q mpz_cdiv_q { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cdiv_q>(GetMpirPointer(nameof(mpz_cdiv_q)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_cdiv_r(ref __mpz_t r, ref __mpz_t n, ref __mpz_t d);
        public static __mpz_cdiv_r mpz_cdiv_r { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cdiv_r>(GetMpirPointer(nameof(mpz_cdiv_r)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_cdiv_qr(ref __mpz_t q, ref __mpz_t r, ref __mpz_t n, ref __mpz_t d);
        public static __mpz_cdiv_qr mpz_cdiv_qr { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cdiv_qr>(GetMpirPointer(nameof(mpz_cdiv_qr)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_cdiv_q_ui(ref __mpz_t q, ref __mpz_t n, mpir_ui d);
        public static __mpz_cdiv_q_ui mpz_cdiv_q_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cdiv_q_ui>(GetMpirPointer(nameof(mpz_cdiv_q_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_cdiv_r_ui(ref __mpz_t r, ref __mpz_t n, mpir_ui d);
        public static __mpz_cdiv_r_ui mpz_cdiv_r_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cdiv_r_ui>(GetMpirPointer(nameof(mpz_cdiv_r_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_cdiv_qr_ui(ref __mpz_t q, ref __mpz_t r, ref __mpz_t n, mpir_ui d);
        public static __mpz_cdiv_qr_ui mpz_cdiv_qr_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cdiv_qr_ui>(GetMpirPointer(nameof(mpz_cdiv_qr_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_cdiv_ui(ref __mpz_t n, mpir_ui d);
        public static __mpz_cdiv_ui mpz_cdiv_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cdiv_ui>(GetMpirPointer(nameof(mpz_cdiv_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_cdiv_q_2exp(ref __mpz_t q, ref __mpz_t n, mp_bitcnt_t b);
        public static __mpz_cdiv_q_2exp mpz_cdiv_q_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cdiv_q_2exp>(GetMpirPointer(nameof(mpz_cdiv_q_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_cdiv_r_2exp(ref __mpz_t r, ref __mpz_t n, mp_bitcnt_t b);
        public static __mpz_cdiv_r_2exp mpz_cdiv_r_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_cdiv_r_2exp>(GetMpirPointer(nameof(mpz_cdiv_r_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_fdiv_q(ref __mpz_t q, ref __mpz_t n, ref __mpz_t d);
        public static __mpz_fdiv_q mpz_fdiv_q { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fdiv_q>(GetMpirPointer(nameof(mpz_fdiv_q)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_fdiv_r(ref __mpz_t r, ref __mpz_t n, ref __mpz_t d);
        public static __mpz_fdiv_r mpz_fdiv_r { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fdiv_r>(GetMpirPointer(nameof(mpz_fdiv_r)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_fdiv_qr(ref __mpz_t q, ref __mpz_t r, ref __mpz_t n, ref __mpz_t d);
        public static __mpz_fdiv_qr mpz_fdiv_qr { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fdiv_qr>(GetMpirPointer(nameof(mpz_fdiv_qr)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_fdiv_q_ui(ref __mpz_t q, ref __mpz_t n, mpir_ui d);
        public static __mpz_fdiv_q_ui mpz_fdiv_q_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fdiv_q_ui>(GetMpirPointer(nameof(mpz_fdiv_q_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_fdiv_r_ui(ref __mpz_t r, ref __mpz_t n, mpir_ui d);
        public static __mpz_fdiv_r_ui mpz_fdiv_r_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fdiv_r_ui>(GetMpirPointer(nameof(mpz_fdiv_r_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_fdiv_qr_ui(ref __mpz_t q, ref __mpz_t r, ref __mpz_t n, mpir_ui d);
        public static __mpz_fdiv_qr_ui mpz_fdiv_qr_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fdiv_qr_ui>(GetMpirPointer(nameof(mpz_fdiv_qr_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_fdiv_ui(ref __mpz_t n, mpir_ui d);
        public static __mpz_fdiv_ui mpz_fdiv_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fdiv_ui>(GetMpirPointer(nameof(mpz_fdiv_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_fdiv_q_2exp(ref __mpz_t q, ref __mpz_t n, mp_bitcnt_t b);
        public static __mpz_fdiv_q_2exp mpz_fdiv_q_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fdiv_q_2exp>(GetMpirPointer(nameof(mpz_fdiv_q_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_fdiv_r_2exp(ref __mpz_t r, ref __mpz_t n, mp_bitcnt_t b);
        public static __mpz_fdiv_r_2exp mpz_fdiv_r_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_fdiv_r_2exp>(GetMpirPointer(nameof(mpz_fdiv_r_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_tdiv_q(ref __mpz_t q, ref __mpz_t n, ref __mpz_t d);
        public static __mpz_tdiv_q mpz_tdiv_q { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_tdiv_q>(GetMpirPointer(nameof(mpz_tdiv_q)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_tdiv_r(ref __mpz_t r, ref __mpz_t n, ref __mpz_t d);
        public static __mpz_tdiv_r mpz_tdiv_r { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_tdiv_r>(GetMpirPointer(nameof(mpz_tdiv_r)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_tdiv_qr(ref __mpz_t q, ref __mpz_t r, ref __mpz_t n, ref __mpz_t d);
        public static __mpz_tdiv_qr mpz_tdiv_qr { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_tdiv_qr>(GetMpirPointer(nameof(mpz_tdiv_qr)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_tdiv_q_ui(ref __mpz_t q, ref __mpz_t n, mpir_ui d);
        public static __mpz_tdiv_q_ui mpz_tdiv_q_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_tdiv_q_ui>(GetMpirPointer(nameof(mpz_tdiv_q_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_tdiv_r_ui(ref __mpz_t r, ref __mpz_t n, mpir_ui d);
        public static __mpz_tdiv_r_ui mpz_tdiv_r_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_tdiv_r_ui>(GetMpirPointer(nameof(mpz_tdiv_r_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_tdiv_qr_ui(ref __mpz_t q, ref __mpz_t r, ref __mpz_t n, mpir_ui d);
        public static __mpz_tdiv_qr_ui mpz_tdiv_qr_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_tdiv_qr_ui>(GetMpirPointer(nameof(mpz_tdiv_qr_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate mpir_ui __mpz_tdiv_ui(ref __mpz_t n, mpir_ui d);
        public static __mpz_tdiv_ui mpz_tdiv_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_tdiv_ui>(GetMpirPointer(nameof(mpz_tdiv_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_tdiv_q_2exp(ref __mpz_t q, ref __mpz_t n, mp_bitcnt_t b);
        public static __mpz_tdiv_q_2exp mpz_tdiv_q_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_tdiv_q_2exp>(GetMpirPointer(nameof(mpz_tdiv_q_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_tdiv_r_2exp(ref __mpz_t r, ref __mpz_t n, mp_bitcnt_t b);
        public static __mpz_tdiv_r_2exp mpz_tdiv_r_2exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_tdiv_r_2exp>(GetMpirPointer(nameof(mpz_tdiv_r_2exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_mod(ref __mpz_t r, ref __mpz_t n, ref __mpz_t d);
        public static __mpz_mod mpz_mod { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_mod>(GetMpirPointer(nameof(mpz_mod)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_divexact(ref __mpz_t q, ref __mpz_t n, ref __mpz_t d);
        public static __mpz_divexact mpz_divexact { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_divexact>(GetMpirPointer(nameof(mpz_divexact)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_divexact_ui(ref __mpz_t q, ref __mpz_t n, mpir_ui d);
        public static __mpz_divexact_ui mpz_divexact_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_divexact_ui>(GetMpirPointer(nameof(mpz_divexact_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_divisible_p(ref __mpz_t n, ref __mpz_t d);
        public static __mpz_divisible_p mpz_divisible_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_divisible_p>(GetMpirPointer(nameof(mpz_divisible_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_divisible_ui_p(ref __mpz_t n, mpir_ui d);
        public static __mpz_divisible_ui_p mpz_divisible_ui_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_divisible_ui_p>(GetMpirPointer(nameof(mpz_divisible_ui_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_divisible_2exp_p(ref __mpz_t n, mp_bitcnt_t b);
        public static __mpz_divisible_2exp_p mpz_divisible_2exp_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_divisible_2exp_p>(GetMpirPointer(nameof(mpz_divisible_2exp_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_congruent_p(ref __mpz_t n, ref __mpz_t c, ref __mpz_t d);
        public static __mpz_congruent_p mpz_congruent_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_congruent_p>(GetMpirPointer(nameof(mpz_congruent_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_congruent_ui_p(ref __mpz_t n, mpir_ui c, mpir_ui d);
        public static __mpz_congruent_ui_p mpz_congruent_ui_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_congruent_ui_p>(GetMpirPointer(nameof(mpz_congruent_ui_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_congruent_2exp_p(ref __mpz_t n, ref __mpz_t c, mp_bitcnt_t b);
        public static __mpz_congruent_2exp_p mpz_congruent_2exp_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_congruent_2exp_p>(GetMpirPointer(nameof(mpz_congruent_2exp_p)));
        #endregion

        #region Exponentiation Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_powm(ref __mpz_t rop, ref __mpz_t _base, ref __mpz_t exp, ref __mpz_t mod);
        public static __mpz_powm mpz_powm { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_powm>(GetMpirPointer(nameof(mpz_powm)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_powm_ui(ref __mpz_t rop, ref __mpz_t _base, mpir_ui exp, ref __mpz_t mod);
        public static __mpz_powm_ui mpz_powm_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_powm_ui>(GetMpirPointer(nameof(mpz_powm_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_pow_ui(ref __mpz_t rop, ref __mpz_t _base, mpir_ui exp);
        public static __mpz_pow_ui mpz_pow_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_pow_ui>(GetMpirPointer(nameof(mpz_pow_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_ui_pow_ui(ref __mpz_t rop, mpir_ui _base, mpir_ui exp);
        public static __mpz_ui_pow_ui mpz_ui_pow_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_ui_pow_ui>(GetMpirPointer(nameof(mpz_ui_pow_ui)));
        #endregion

        #region Root Extraction Functions
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_root(ref __mpz_t rop, ref __mpz_t op, mpir_ui n);
        public static __mpz_root mpz_root { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_root>(GetMpirPointer(nameof(mpz_root)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_nthroot(ref __mpz_t rop, ref __mpz_t op, mpir_ui n);
        public static __mpz_nthroot mpz_nthroot { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_nthroot>(GetMpirPointer(nameof(mpz_nthroot)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_rootrem(ref __mpz_t root, ref __mpz_t rem, ref __mpz_t u, mpir_ui n);
        public static __mpz_rootrem mpz_rootrem { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_rootrem>(GetMpirPointer(nameof(mpz_rootrem)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_sqrt(ref __mpz_t rop, ref __mpz_t op);
        public static __mpz_sqrt mpz_sqrt { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_sqrt>(GetMpirPointer(nameof(mpz_sqrt)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void __mpz_sqrtrem(ref __mpz_t rop1, ref __mpz_t rop2, ref __mpz_t op);
        public static __mpz_sqrtrem mpz_sqrtrem { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_sqrtrem>(GetMpirPointer(nameof(mpz_sqrtrem)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_perfect_power_p(ref __mpz_t rop);
        public static __mpz_perfect_power_p mpz_perfect_power_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_perfect_power_p>(GetMpirPointer(nameof(mpz_perfect_power_p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpz_perfect_square_p(ref __mpz_t rop);
        public static __mpz_perfect_square_p mpz_perfect_square_p { get; } = Marshal.GetDelegateForFunctionPointer<__mpz_perfect_square_p>(GetMpirPointer(nameof(mpz_perfect_square_p)));
        #endregion
    }
}
