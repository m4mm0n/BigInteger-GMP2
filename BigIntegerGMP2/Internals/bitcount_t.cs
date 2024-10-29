namespace BigIntegerGMP2.Internals
{
    /// <summary>
    /// See http://mpir.org/mpir-3.0.0.pdf.
    /// </summary>
    public class bitcount_t
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="bitcount_t"/> class.
        /// See http://mpir.org/mpir-3.0.0.pdf.
        /// </summary>
        /// <param name="count">The count.</param>
        public bitcount_t(ulong count)
        {
            Count = count;
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        public ulong Count { get; }
    }
}
