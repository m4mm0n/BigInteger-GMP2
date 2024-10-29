using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpf_t
{
    /// <summary>
    /// See http://mpir.org/mpir-3.0.0.pdf.
    /// </summary>
    public partial class mpf_t : IDisposable, IEquatable<mpf_t>, ICloneable, IConvertible, IComparable, IComparable<mpf_t>
    {
        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        public mpf_t Ceil()
        {
            var z = new mpf_t(Precision);

            mpf.ceil(z, this);

            return z;
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        public mpf_t Floor()
        {
            var z = new mpf_t(Precision);

            mpf.floor(z, this);

            return z;
        }

        /// <summary>
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        public mpf_t Trunc()
        {
            var z = new mpf_t(Precision);

            mpf.trunc(z, this);

            return z;
        }
    }
}
