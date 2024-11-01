using System.Text;
using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        /// <summary>
        /// Converts the BigInteger to a byte array.
        /// </summary>
        /// <param name="isLittleEndian">Indicates whether the byte array should be in little-endian format.</param>
        /// <returns>A byte array representation of the BigInteger.</returns>
        public byte[] ToByteArray(bool isLittleEndian = true)
        {
            try
            {
                var byteLen = mpz.sizeinbase(_value, 2);
                var byteArr = new byte[byteLen];
                var refSize = 0UL;
                mpz.export(byteArr, out refSize, isLittleEndian ? 1 : 0, 1, 0, 0, _value);
                return byteArr;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to convert to byte array", e);
            }
        }

        /// <summary>
        /// Converts the BigInteger to a string representation in the specified radix.
        /// </summary>
        /// <param name="radix">The base to use for the string representation (e.g., 10 for decimal, 16 for hexadecimal).</param>
        /// <returns>A string representation of the BigInteger in the specified radix.</returns>
        public string ToString(int radix)
        {
            try
            {
                var sb = new StringBuilder();
                mpz.get_str(sb, radix, _value);
                return sb.ToString();
            }
            catch (Exception e)
            {
                throw new Exception("Failed to convert to string", e);
            }
        }

        /// <summary>
        /// Converts the BigInteger to a string representation in base 10.
        /// </summary>
        /// <returns>A string representation of the BigInteger in base 10.</returns>
        public override string ToString() => ToString(10);

        /// <summary>
        /// Converts the current BigInteger instance to its string representation in the specified base format.
        /// </summary>
        /// <param name="format">The base format in which to represent the BigInteger value.</param>
        /// <returns>A string representation of the BigInteger in the specified base format.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the provided base format is not supported.</exception>
        public string ToString(BaseFormat format) =>
            format switch
            {
                BaseFormat.Base2 => ToString(2),
                BaseFormat.Base8 => ToString(8),
                BaseFormat.Base10 => ToString(10),
                BaseFormat.Base16 => ToString(16),
                BaseFormat.Base32 => ToString(32),
                BaseFormat.Base64 => ConvertToBase64(this),
                _ => throw new ArgumentOutOfRangeException(nameof(format), format, null)
            };

        /// <summary>
        /// Converts the BigInteger to a 32-bit signed integer.
        /// </summary>
        /// <returns>A 32-bit signed integer representation of the BigInteger.</returns>
        /// <exception cref="OverflowException">Thrown when the value is too large or too small for an Int32.</exception>
        public int ToInt32()
        {
            try
            {
                var val = mpz.get_si(_value);
                if (val > int.MaxValue || val < int.MinValue)
                    throw new OverflowException("Value was either too large or too small for an Int32.");
                return (int)val;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to convert to int32", e);
            }
        }

        /// <summary>
        /// Converts the BigInteger to a 64-bit signed integer.
        /// </summary>
        /// <returns>A 64-bit signed integer representation of the BigInteger.</returns>
        /// <exception cref="OverflowException">Thrown when the value is too large or too small for an Int64.</exception>
        public long ToInt64()
        {
            try
            {
                var val = mpz.get_si(_value);
                if (val > long.MaxValue || val < long.MinValue)
                    throw new OverflowException("Value was either too large or too small for an Int64.");
                return val;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to convert to int64", e);
            }
        }

        /// <summary>
        /// Converts the BigInteger to a 32-bit unsigned integer.
        /// </summary>
        /// <returns>A 32-bit unsigned integer representation of the BigInteger.</returns>
        /// <exception cref="OverflowException">Thrown when the value is too large for a UInt32.</exception>
        public uint ToUInt32()
        {
            try
            {
                var val = mpz.get_ui(_value);
                if (val > uint.MaxValue)
                    throw new OverflowException("Value was too large for an UInt32.");
                return (uint)val;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to convert to uint32", e);
            }
        }

        /// <summary>
        /// Converts the BigInteger to a 64-bit unsigned integer.
        /// </summary>
        /// <returns>A 64-bit unsigned integer representation of the BigInteger.</returns>
        public ulong ToUInt64()
        {
            try
            {
                var val = mpz.get_ui(_value);
                return val;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to convert to uint64", e);
            }
        }

        /// <summary>
        /// Converts the BigInteger to a double-precision floating-point number.
        /// </summary>
        /// <returns>A double-precision floating-point representation of the BigInteger.</returns>
        public double ToDouble()
        {
            try
            {
                var val = mpz.get_d(_value);
                return val;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to convert to double", e);
            }
        }

        /// <summary>
        /// Converts the BigInteger to a single-precision floating-point number.
        /// </summary>
        /// <returns>A single-precision floating-point representation of the BigInteger.</returns>
        public float ToSingle()
        {
            try
            {
                var val = mpz.get_d(_value);
                return (float)val;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to convert to float", e);
            }
        }

        //public decimal ToDecimal()
        //{
        //    try
        //    {
        //        var val = mpz.get_d(_value);
        //        return (decimal)val;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("Failed to convert to decimal", e);
        //    }
        //}
    }
}
