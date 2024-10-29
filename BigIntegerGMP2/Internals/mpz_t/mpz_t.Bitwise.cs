using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpz_t
{
    /// <summary>
    /// Arbitrary precision integer.
    /// </summary>
    public partial class mpz_t : IDisposable, IEquatable<mpz_t>, ICloneable, IConvertible, IComparable, IComparable<mpz_t>
    {
        /// <summary>
        /// Gets a specific bit.
        /// </summary>
        /// <param name="index">The bit index.</param>
        public bool GetBit(ulong index) => mpz.tstbit(this, index);

        /// <summary>
        /// Sets a specific bit.
        /// </summary>
        /// <param name="index">The bit index.</param>
        public void SetBit(ulong index)
        {
            mpz.setbit(this, index);
        }

        /// <summary>
        /// Clears a specific bit.
        /// </summary>
        /// <param name="index">The bit index.</param>
        public void ClearBit(ulong index)
        {
            mpz.clrbit(this, index);
        }

        /// <summary>
        /// Toggles a specific bit.
        /// </summary>
        /// <param name="index">The bit index.</param>
        public void ComplementBit(ulong index)
        {
            mpz.combit(this, index);
        }

        /// <summary>
        /// Changes a specific bit.
        /// </summary>
        /// <param name="index">The bit index.</param>
        /// <param name="isSet">The bit value.</param>
        public void ChangeBit(ulong index, bool isSet)
        {
            if (isSet)
                mpz.setbit(this, index);
            else
                mpz.clrbit(this, index);
        }
    }
}
