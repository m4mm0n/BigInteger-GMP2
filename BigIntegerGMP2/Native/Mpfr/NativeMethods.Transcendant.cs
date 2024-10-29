using System.Runtime.InteropServices;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Native.Mpfr
{
    internal static partial class NativeMethods
    {
        #region Log
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_log(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_log mpfr_log { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_log>(GetMpfrPointer(nameof(mpfr_log)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_log_ui(ref __mpfr_t rop, uint op, __mpfr_rnd_t rnd);
        public static __mpfr_log_ui mpfr_log_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_log_ui>(GetMpfrPointer(nameof(mpfr_log_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_log2(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_log2 mpfr_log2 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_log2>(GetMpfrPointer(nameof(mpfr_log2)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_log10(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_log10 mpfr_log10 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_log10>(GetMpfrPointer(nameof(mpfr_log10)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_log1p(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_log1p mpfr_log1p { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_log1p>(GetMpfrPointer(nameof(mpfr_log1p)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_log2p1(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_log2p1 mpfr_log2p1 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_log2p1>(GetMpfrPointer(nameof(mpfr_log2p1)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_log10p1(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_log10p1 mpfr_log10p1 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_log10p1>(GetMpfrPointer(nameof(mpfr_log10p1)));
        #endregion

        #region Exp
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_exp(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_exp mpfr_exp { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_exp>(GetMpfrPointer(nameof(mpfr_exp)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_exp2(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_exp2 mpfr_exp2 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_exp2>(GetMpfrPointer(nameof(mpfr_exp2)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_exp10(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_exp10 mpfr_exp10 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_exp10>(GetMpfrPointer(nameof(mpfr_exp10)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_expm1(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_expm1 mpfr_expm1 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_expm1>(GetMpfrPointer(nameof(mpfr_expm1)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_exp2m1(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_exp2m1 mpfr_exp2m1 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_exp2m1>(GetMpfrPointer(nameof(mpfr_exp2m1)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_exp10m1(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_exp10m1 mpfr_exp10m1 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_exp10m1>(GetMpfrPointer(nameof(mpfr_exp10m1)));
        #endregion

        #region Pow
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_pow(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_pow mpfr_pow { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_pow>(GetMpfrPointer(nameof(mpfr_pow)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_pow_ui(ref __mpfr_t rop, ref __mpfr_t op1, ulong op2, __mpfr_rnd_t rnd);
        public static __mpfr_pow_ui mpfr_pow_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_pow_ui>(GetMpfrPointer(nameof(mpfr_pow_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_pow_si(ref __mpfr_t rop, ref __mpfr_t op1, long op2, __mpfr_rnd_t rnd);
        public static __mpfr_pow_si mpfr_pow_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_pow_si>(GetMpfrPointer(nameof(mpfr_pow_si)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_pow_z(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpz_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_pow_z mpfr_pow_z { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_pow_z>(GetMpfrPointer(nameof(mpfr_pow_z)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_ui_pow_ui(ref __mpfr_t rop, ulong op1, ulong op2, __mpfr_rnd_t rnd);
        public static __mpfr_ui_pow_ui mpfr_ui_pow_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_ui_pow_ui>(GetMpfrPointer(nameof(mpfr_ui_pow_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_ui_pow(ref __mpfr_t rop, ulong op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_ui_pow mpfr_ui_pow { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_ui_pow>(GetMpfrPointer(nameof(mpfr_ui_pow)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_powr(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_powr mpfr_powr { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_powr>(GetMpfrPointer(nameof(mpfr_powr)));
        #endregion

        #region Trigonometric
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cos(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_cos mpfr_cos { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cos>(GetMpfrPointer(nameof(mpfr_cos)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sin(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_sin mpfr_sin { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sin>(GetMpfrPointer(nameof(mpfr_sin)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_tan(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_tan mpfr_tan { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_tan>(GetMpfrPointer(nameof(mpfr_tan)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sin_cos(ref __mpfr_t sop, ref __mpfr_t cop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_sin_cos mpfr_sin_cos { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sin_cos>(GetMpfrPointer(nameof(mpfr_sin_cos)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sec(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_sec mpfr_sec { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sec>(GetMpfrPointer(nameof(mpfr_sec)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_csc(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_csc mpfr_csc { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_csc>(GetMpfrPointer(nameof(mpfr_csc)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cot(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_cot mpfr_cot { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cot>(GetMpfrPointer(nameof(mpfr_cot)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_acos(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_acos mpfr_acos { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_acos>(GetMpfrPointer(nameof(mpfr_acos)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_asin(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_asin mpfr_asin { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_asin>(GetMpfrPointer(nameof(mpfr_asin)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_atan(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_atan mpfr_atan { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_atan>(GetMpfrPointer(nameof(mpfr_atan)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_atan2(ref __mpfr_t rop, ref __mpfr_t x, ref __mpfr_t y, __mpfr_rnd_t rnd);
        public static __mpfr_atan2 mpfr_atan2 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_atan2>(GetMpfrPointer(nameof(mpfr_atan2)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cosh(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_cosh mpfr_cosh { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cosh>(GetMpfrPointer(nameof(mpfr_cosh)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sinh(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_sinh mpfr_sinh { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sinh>(GetMpfrPointer(nameof(mpfr_sinh)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_tanh(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_tanh mpfr_tanh { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_tanh>(GetMpfrPointer(nameof(mpfr_tanh)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sinh_cosh(ref __mpfr_t sop, ref __mpfr_t cop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_sinh_cosh mpfr_sinh_cosh { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sinh_cosh>(GetMpfrPointer(nameof(mpfr_sinh_cosh)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sech(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_sech mpfr_sech { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sech>(GetMpfrPointer(nameof(mpfr_sech)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_csch(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_csch mpfr_csch { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_csch>(GetMpfrPointer(nameof(mpfr_csch)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_coth(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_coth mpfr_coth { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_coth>(GetMpfrPointer(nameof(mpfr_coth)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_acosh(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_acosh mpfr_acosh { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_acosh>(GetMpfrPointer(nameof(mpfr_acosh)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_asinh(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_asinh mpfr_asinh { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_asinh>(GetMpfrPointer(nameof(mpfr_asinh)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_atanh(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_atanh mpfr_atanh { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_atanh>(GetMpfrPointer(nameof(mpfr_atanh)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cosu(ref __mpfr_t rop, ref __mpfr_t op, ulong u, __mpfr_rnd_t rnd);
        public static __mpfr_cosu mpfr_cosu { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cosu>(GetMpfrPointer(nameof(mpfr_cosu)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sinu(ref __mpfr_t rop, ref __mpfr_t op, ulong u, __mpfr_rnd_t rnd);
        public static __mpfr_sinu mpfr_sinu { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sinu>(GetMpfrPointer(nameof(mpfr_sinu)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_tanu(ref __mpfr_t rop, ref __mpfr_t op, ulong u, __mpfr_rnd_t rnd);
        public static __mpfr_tanu mpfr_tanu { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_tanu>(GetMpfrPointer(nameof(mpfr_tanu)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_acosu(ref __mpfr_t rop, ref __mpfr_t op, ulong u, __mpfr_rnd_t rnd);
        public static __mpfr_acosu mpfr_acosu { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_acosu>(GetMpfrPointer(nameof(mpfr_acosu)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_asinu(ref __mpfr_t rop, ref __mpfr_t op, ulong u, __mpfr_rnd_t rnd);
        public static __mpfr_asinu mpfr_asinu { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_asinu>(GetMpfrPointer(nameof(mpfr_asinu)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_atanu(ref __mpfr_t rop, ref __mpfr_t op, ulong u, __mpfr_rnd_t rnd);
        public static __mpfr_atanu mpfr_atanu { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_atanu>(GetMpfrPointer(nameof(mpfr_atanu)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_atan2u(ref __mpfr_t rop, ref __mpfr_t x, ref __mpfr_t y, ulong u, __mpfr_rnd_t rnd);
        public static __mpfr_atan2u mpfr_atan2u { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_atan2u>(GetMpfrPointer(nameof(mpfr_atan2u)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_cospi(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_cospi mpfr_cospi { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_cospi>(GetMpfrPointer(nameof(mpfr_cospi)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_sinpi(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_sinpi mpfr_sinpi { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_sinpi>(GetMpfrPointer(nameof(mpfr_sinpi)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_tanpi(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_tanpi mpfr_tanpi { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_tanpi>(GetMpfrPointer(nameof(mpfr_tanpi)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_acospi(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_acospi mpfr_acospi { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_acospi>(GetMpfrPointer(nameof(mpfr_acospi)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_asinpi(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_asinpi mpfr_asinpi { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_asinpi>(GetMpfrPointer(nameof(mpfr_asinpi)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_atanpi(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_atanpi mpfr_atanpi { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_atanpi>(GetMpfrPointer(nameof(mpfr_atanpi)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_atan2pi(ref __mpfr_t rop, ref __mpfr_t x, ref __mpfr_t y, __mpfr_rnd_t rnd);
        public static __mpfr_atan2pi mpfr_atan2pi { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_atan2pi>(GetMpfrPointer(nameof(mpfr_atan2pi)));
        #endregion

        #region Other
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_eint(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_eint mpfr_eint { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_eint>(GetMpfrPointer(nameof(mpfr_eint)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_li2(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_li2 mpfr_li2 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_li2>(GetMpfrPointer(nameof(mpfr_li2)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_gamma(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_gamma mpfr_gamma { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_gamma>(GetMpfrPointer(nameof(mpfr_gamma)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_gamma_inc(ref __mpfr_t rop, ref __mpfr_t op, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_gamma_inc mpfr_gamma_inc { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_gamma_inc>(GetMpfrPointer(nameof(mpfr_gamma_inc)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_lngamma(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_lngamma mpfr_lngamma { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_lngamma>(GetMpfrPointer(nameof(mpfr_lngamma)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_lgamma(ref __mpfr_t rop, out int sign, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_lgamma mpfr_lgamma { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_lgamma>(GetMpfrPointer(nameof(mpfr_lgamma)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_digamma(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_digamma mpfr_digamma { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_digamma>(GetMpfrPointer(nameof(mpfr_digamma)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_beta(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_beta mpfr_beta { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_beta>(GetMpfrPointer(nameof(mpfr_beta)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_zeta(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_zeta mpfr_zeta { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_zeta>(GetMpfrPointer(nameof(mpfr_zeta)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_zeta_ui(ref __mpfr_t rop, ulong op, __mpfr_rnd_t rnd);
        public static __mpfr_zeta_ui mpfr_zeta_ui { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_zeta_ui>(GetMpfrPointer(nameof(mpfr_zeta_ui)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_erf(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_erf mpfr_erf { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_erf>(GetMpfrPointer(nameof(mpfr_erf)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_erfc(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_erfc mpfr_erfc { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_erfc>(GetMpfrPointer(nameof(mpfr_erfc)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_j0(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_j0 mpfr_j0 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_j0>(GetMpfrPointer(nameof(mpfr_j0)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_j1(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_j1 mpfr_j1 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_j1>(GetMpfrPointer(nameof(mpfr_j1)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_jn(ref __mpfr_t rop, long n, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_jn mpfr_jn { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_jn>(GetMpfrPointer(nameof(mpfr_jn)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_y0(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_y0 mpfr_y0 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_y0>(GetMpfrPointer(nameof(mpfr_y0)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_y1(ref __mpfr_t rop, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_y1 mpfr_y1 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_y1>(GetMpfrPointer(nameof(mpfr_y1)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_yn(ref __mpfr_t rop, long n, ref __mpfr_t op, __mpfr_rnd_t rnd);
        public static __mpfr_yn mpfr_yn { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_yn>(GetMpfrPointer(nameof(mpfr_yn)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_agm(ref __mpfr_t rop, ref __mpfr_t op1, ref __mpfr_t op2, __mpfr_rnd_t rnd);
        public static __mpfr_agm mpfr_agm { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_agm>(GetMpfrPointer(nameof(mpfr_agm)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_ai(ref __mpfr_t rop, ref __mpfr_t x, __mpfr_rnd_t rnd);
        public static __mpfr_ai mpfr_ai { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_ai>(GetMpfrPointer(nameof(mpfr_ai)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_const_log2(ref __mpfr_t rop, __mpfr_rnd_t rnd);
        public static __mpfr_const_log2 mpfr_const_log2 { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_const_log2>(GetMpfrPointer(nameof(mpfr_const_log2)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_const_pi(ref __mpfr_t rop, __mpfr_rnd_t rnd);
        public static __mpfr_const_pi mpfr_const_pi { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_const_pi>(GetMpfrPointer(nameof(mpfr_const_pi)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_const_euler(ref __mpfr_t rop, __mpfr_rnd_t rnd);
        public static __mpfr_const_euler mpfr_const_euler { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_const_euler>(GetMpfrPointer(nameof(mpfr_const_euler)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_const_catalan(ref __mpfr_t rop, __mpfr_rnd_t rnd);
        public static __mpfr_const_catalan mpfr_const_catalan { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_const_catalan>(GetMpfrPointer(nameof(mpfr_const_catalan)));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int __mpfr_compound_si(ref __mpfr_t rop, ref __mpfr_t op, long n, __mpfr_rnd_t rnd);
        public static __mpfr_compound_si mpfr_compound_si { get; } = Marshal.GetDelegateForFunctionPointer<__mpfr_compound_si>(GetMpfrPointer(nameof(mpfr_compound_si)));
        #endregion
    }
}
