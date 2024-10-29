using System.Text;
using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpf_t
{
    /// <summary>
    /// See http://mpir.org/mpir-3.0.0.pdf.
    /// </summary>
    public partial class mpf_t : IDisposable, IEquatable<mpf_t>, ICloneable, IConvertible, IComparable, IComparable<mpf_t>
    {
        /// <summary>
        /// Adds two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator +(mpf_t x, mpf_t y)
        {
            mpf_t z = new();

            mpf.add(z, x, y);

            return z;
        }

        /// <summary>
        /// Adds two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator +(mpf_t x, long y)
        {
            mpf_t z = new();

            if (y >= 0)
                mpf.add_ui(z, x, (ulong)y);
            else
                mpf.sub_ui(z, x, (ulong)-y);

            return z;
        }

        /// <summary>
        /// Adds two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator +(long x, mpf_t y)
        {
            mpf_t z = new();

            if (x >= 0)
                mpf.add_ui(z, y, (ulong)x);
            else
                mpf.sub_ui(z, y, (ulong)-x);

            return z;
        }

        /// <summary>
        /// Adds two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator +(mpf_t x, ulong y)
        {
            var z = new mpf_t();

            mpf.add_ui(z, x, y);

            return z;
        }

        /// <summary>
        /// Adds two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator +(ulong x, mpf_t y)
        {
            var z = new mpf_t();

            mpf.add_ui(z, y, x);

            return z;
        }

        /// <summary>
        /// Subtracts two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator -(mpf_t x, mpf_t y)
        {
            var z = new mpf_t();

            mpf.sub(z, x, y);

            return z;
        }

        /// <summary>
        /// Subtracts two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator -(long x, mpf_t y)
        {
            if (x >= 0)
            {
                var z = new mpf_t();

                mpf.ui_sub(z, (ulong)x, y);

                return z;
            }
            else
            {
                var z = new mpf_t();

                mpf.add_ui(z, y, (ulong)-x);
                mpf.neg(z, z);

                return z;
            }
        }

        /// <summary>
        /// Subtracts two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator -(mpf_t x, long y)
        {
            var z = new mpf_t();

            if (y >= 0)
                mpf.sub_ui(z, x, (ulong)y);
            else
                mpf.add_ui(z, x, (ulong)-y);

            return z;
        }

        /// <summary>
        /// Subtracts two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator -(ulong x, mpf_t y)
        {
            var z = new mpf_t();

            mpf.ui_sub(z, x, y);

            return z;
        }

        /// <summary>
        /// Subtracts two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator -(mpf_t x, ulong y)
        {
            var z = new mpf_t();

            mpf.sub_ui(z, x, y);

            return z;
        }

        /// <summary>
        /// Subtracts two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator *(mpf_t x, mpf_t y)
        {
            var z = new mpf_t();

            mpf.mul(z, x, y);

            return z;
        }

        /// <summary>
        /// Multiplies two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator *(ulong x, mpf_t y)
        {
            var z = new mpf_t();

            mpf.mul_ui(z, y, x);

            return z;
        }

        /// <summary>
        /// Multiplies two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator *(mpf_t x, ulong y)
        {
            var z = new mpf_t();

            mpf.mul_ui(z, x, y);

            return z;
        }

        /// <summary>
        /// Shifts an operand to the left.
        /// </summary>
        /// <param name="x">The value.</param>
        /// <param name="count">The shift.</param>
        public static mpf_t operator <<(mpf_t x, int count)
        {
            var z = new mpf_t();

            if (count >= 0)
                mpf.mul_2exp(z, x, (ulong)count);

            return z;
        }

        /// <summary>
        /// Shifts an operand to the right.
        /// </summary>
        /// <param name="x">The value.</param>
        /// <param name="count">The shift.</param>
        public static mpf_t operator >>(mpf_t x, int count)
        {
            var z = new mpf_t();

            if (count >= 0)
                mpf.div_2exp(z, x, (ulong)count);

            return z;
        }

        /// <summary>
        /// Negates an operand.
        /// </summary>
        /// <param name="x">The value.</param>
        public static mpf_t operator -(mpf_t x)
        {
            var z = new mpf_t();

            mpf.neg(z, x);

            return z;
        }

        /// <summary>
        /// Divides two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator /(mpf_t x, mpf_t y)
        {
            var quotient = new mpf_t();

            mpf.div(quotient, x, y);

            return quotient;
        }

        /// <summary>
        /// Divides two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator /(mpf_t x, ulong y)
        {
            var quotient = new mpf_t();

            mpf.div_ui(quotient, x, y);

            return quotient;
        }

        /// <summary>
        /// Divides two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpf_t operator /(ulong x, mpf_t y)
        {
            var quotient = new mpf_t();

            mpf.ui_div(quotient, x, y);

            return quotient;
        }

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpf_t x, mpf_t y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(long x, mpf_t y) => y.CompareTo(x) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpf_t x, long y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(ulong x, mpf_t y) => y.CompareTo(x) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpf_t x, ulong y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(float x, mpf_t y) => y.CompareTo(x) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpf_t x, float y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(double x, mpf_t y) => y.CompareTo(x) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpf_t x, double y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpf_t x, mpf_t y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(long x, mpf_t y) => y.CompareTo(x) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpf_t x, long y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(ulong x, mpf_t y) => y.CompareTo(x) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpf_t x, ulong y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(float x, mpf_t y) => y.CompareTo(x) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpf_t x, float y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(double x, mpf_t y) => y.CompareTo(x) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpf_t x, double y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpf_t x, mpf_t y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(long x, mpf_t y) => y.CompareTo(x) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpf_t x, long y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(ulong x, mpf_t y) => y.CompareTo(x) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpf_t x, ulong y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(float x, mpf_t y) => y.CompareTo(x) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpf_t x, float y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(double x, mpf_t y) => y.CompareTo(x) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpf_t x, double y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpf_t x, mpf_t y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(long x, mpf_t y) => y.CompareTo(x) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpf_t x, long y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(ulong x, mpf_t y) => y.CompareTo(x) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpf_t x, ulong y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(float x, mpf_t y) => y.CompareTo(x) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpf_t x, float y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(double x, mpf_t y) => y.CompareTo(x) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpf_t x, double y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpf_t x, mpf_t y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(long x, mpf_t y) => y.CompareTo(x) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpf_t x, long y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(ulong x, mpf_t y) => y.CompareTo(x) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpf_t x, ulong y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(float x, mpf_t y) => y.CompareTo(x) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpf_t x, float y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(double x, mpf_t y) => y.CompareTo(x) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpf_t x, double y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpf_t x, mpf_t y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(long x, mpf_t y) => y.CompareTo(x) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpf_t x, long y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(ulong x, mpf_t y) => y.CompareTo(x) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpf_t x, ulong y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(float x, mpf_t y) => y.CompareTo(x) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpf_t x, float y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(double x, mpf_t y) => y.CompareTo(x) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpf_t x, double y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object..</param>
        public override bool Equals(object? obj) => obj is mpf_t other && CompareTo(other) != 0;

        /// <summary>
        /// Gets a hash of the value.
        /// </summary>
        public override int GetHashCode()
        {
            ulong SizeInDigits = 5;
            var Data = new StringBuilder((int)(SizeInDigits + 2));

            mpf.get_str(Data, out _, mpz_t.mpz_t.DefaultBase, SizeInDigits, this);

            return Data.ToString().GetHashCode();
        }
    }
}
