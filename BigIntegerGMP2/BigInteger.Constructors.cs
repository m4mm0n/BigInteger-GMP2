using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigIntegerGMP2.Internals;
using BigIntegerGMP2.Internals.mpir;
using BigIntegerGMP2.Internals.mpz_t;
using BigIntegerGMP2.Native.Mpir;

namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        static BigInteger()
        {
            _randState = randstate_t.Create();
            gmp.randinit_mt(_randState);
        }

        public BigInteger()
        {
            _value = new mpz_t();
            mpz.init(_value);
        }

        public BigInteger(byte[] value)
        {
            _value = new mpz_t(value);
            mpz.init(_value);
        }

        public BigInteger(string value)
        {
            _value = new mpz_t(value);
            mpz.init(_value);
        }

        public BigInteger(string value, int radix)
        {
            _value = new mpz_t(value, (uint)radix);
            mpz.init(_value);
        }
        public BigInteger(int numBits, Random rnd) { }
        public BigInteger(int bitLength, int certainty, Random rnd) { }
    }
}
