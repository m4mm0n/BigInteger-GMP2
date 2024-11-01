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
    }
}
