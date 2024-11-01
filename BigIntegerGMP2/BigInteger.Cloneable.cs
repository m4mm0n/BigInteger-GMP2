namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        /// <summary>
        /// Creates a new BigInteger object that is a copy of the current instance.
        /// </summary>
        /// <returns>A new BigInteger that is a copy of this instance.</returns>
        public object Clone() => new BigInteger(this);
    }
}
