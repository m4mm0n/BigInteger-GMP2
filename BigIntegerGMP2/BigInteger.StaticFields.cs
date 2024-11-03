using BigIntegerGMP2.Internals;
using BigIntegerGMP2.Internals.mpz_t;

namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        #region Private Fields
        private static randstate_t _randState;
        private static Random _sysRand;
        private mpz_t _value;
        private const string Base64Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        #endregion

        #region Public Properties
        public static bool ShouldLog { get; set; }
        #endregion

        #region Predefined Values
        /// <summary>
        /// BigInteger constant representing the value 0.
        /// </summary>
        public static readonly BigInteger Zero = new(0);
        /// <summary>
        /// BigInteger constant representing the value 1.
        /// </summary>
        public static readonly BigInteger? One = new(1);
        /// <summary>
        /// BigInteger constant representing the value 2.
        /// </summary>
        public static readonly BigInteger Two = new(2);
        /// <summary>
        /// BigInteger constant representing the value 3.
        /// </summary>
        public static readonly BigInteger Three = new(3);
        /// <summary>
        /// BigInteger constant representing the value -1.
        /// </summary>
        public static readonly BigInteger MinusOne = new(-1);
        #endregion
    }
}
