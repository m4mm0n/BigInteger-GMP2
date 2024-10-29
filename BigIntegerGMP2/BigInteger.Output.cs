using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BigIntegerGMP2.Internals.mpir;
using BigIntegerGMP2.Native.Mpir;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        public byte[] ToByteArray(bool isLittleEndian = true)
        {
            try
            {
                var byteLen = mpz.sizeinbase(_value, 2);
                var byteArr = new byte[byteLen];
                var refSize = 0UL;
                mpz.export(byteArr, out refSize, isLittleEndian ? 1 : 0, 1, 0, 0, _value);
                return byteArr;
            }catch (Exception e)
            {
                throw new Exception("Failed to convert to byte array", e);
            }
        }
    }
}
