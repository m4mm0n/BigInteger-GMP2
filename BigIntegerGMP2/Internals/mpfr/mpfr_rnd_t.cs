namespace BigIntegerGMP2.Internals.mpfr
{
    /// <summary>
    /// Rounding mode for operations on numbers.
    /// </summary>
    public enum mpfr_rnd_t
    {
        /// <summary>
        /// Round to nearest, with ties away from zero (mpfr_round).
        /// </summary>
        MPFR_RNDNA = -1,

        /// <summary>
        /// Round to nearest, with ties to even.
        /// </summary>
        MPFR_RNDN = 0,

        /// <summary>
        /// Round toward zero.
        /// </summary>
        MPFR_RNDZ,

        /// <summary>
        /// Round toward +Inf.
        /// </summary>
        MPFR_RNDU,

        /// <summary>
        /// Round toward -Inf.
        /// </summary>
        MPFR_RNDD,

        /// <summary>
        /// Round away from zero.
        /// </summary>
        MPFR_RNDA,

        /// <summary>
        /// Faithful rounding.
        /// </summary>
        MPFR_RNDF,
    }
}
