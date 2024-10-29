namespace BigIntegerGMP2.Internals.mpfr_t
{
    /// <summary>
    /// Represents an arbitrary precision floating-point number.
    /// </summary>
    public partial class mpfr_t : IDisposable
    {
        /// <summary>
        /// Gets the minimum precision.
        /// </summary>
        public ulong MinPrecision => mpfr.mpfr.PrecisionMin;

        /// <summary>
        /// Gets the maximum precision.
        /// </summary>
        public ulong MaxPrecision => mpfr.mpfr.PrecisionMax;

        /// <summary>
        /// Gets or sets the precision.
        /// </summary>
        public ulong Precision
        {
            get => mpfr.mpfr.get_prec(this);
            set => mpfr.mpfr.set_prec(this, value);
        }

        /// <summary>
        /// Gets the minimum significand precision.
        /// </summary>
        public int MinSignificandPrecision => mpfr.mpfr.min_prec(this);

        /// <summary>
        /// Sets the exact precision.
        /// </summary>
        /// <param name="value">The precision.</param>
        public void SetPrecisionRaw(ulong value)
        {
            mpfr.mpfr.set_prec_raw(this, value);
        }

        /// <summary>
        /// Gets or sets the default precision.
        /// </summary>
        public static ulong DefaultPrecision
        {
            get => mpfr.mpfr.get_default_prec();
            set => mpfr.mpfr.set_default_prec(value);
        }

        /// <summary>
        /// Gets the first value of the default precision.
        /// </summary>
        public static ulong DefaultPrecisionInit => mpfr.mpfr.PrecisionDefault;
    }
}
