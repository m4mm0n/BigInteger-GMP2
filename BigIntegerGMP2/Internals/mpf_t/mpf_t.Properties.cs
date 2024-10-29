using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpf_t
{
    /// <summary>
    /// See http://mpir.org/mpir-3.0.0.pdf.
    /// </summary>
    public partial class mpf_t : IDisposable, IEquatable<mpf_t>, ICloneable, IConvertible, IComparable, IComparable<mpf_t>
    {
        /// <summary>
        /// Gets or sets the default precision.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        public static ulong DefaultPrecision
        {
            get => mpf.get_default_prec();
            set => mpf.set_default_prec(value);
        }

        /// <summary>
        /// Gets or sets the precision.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        public ulong Precision
        {
            get => mpf.get_prec(this);
            set => mpf.set_prec(this, value);
        }

        /// <summary>
        /// Gets a value indicating whether the number is an integer.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        public bool IsInteger => mpf.integer_p(this);
    }
}
