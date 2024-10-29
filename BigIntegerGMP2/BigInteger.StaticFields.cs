using BigIntegerGMP2.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigIntegerGMP2.Internals.mpz_t;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        #region Private Fields
        private static randstate_t _randState;
        private static mpz_t _value;
        #endregion

        #region Public Properties
        public static bool ShouldLog { get; set; }
        #endregion
    }
}
