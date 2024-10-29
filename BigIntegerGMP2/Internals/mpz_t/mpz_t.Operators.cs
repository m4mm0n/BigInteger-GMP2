using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpz_t
{
    /// <summary>
    /// Arbitrary precision integer.
    /// </summary>
    public partial class mpz_t : IDisposable, IEquatable<mpz_t>, ICloneable, IConvertible, IComparable, IComparable<mpz_t>
    {
        /// <summary>
        /// Adds two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator +(mpz_t x, mpz_t y)
        {
            mpz_t z = new();

            mpz.add(z, x, y);

            return z;
        }

        /// <summary>
        /// Adds two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator +(mpz_t x, long y)
        {
            mpz_t z = new();

            if (y >= 0)
                mpz.add_ui(z, x, (ulong)y);
            else
                mpz.sub_ui(z, x, (ulong)-y);

            return z;
        }

        /// <summary>
        /// Adds two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator +(long x, mpz_t y)
        {
            mpz_t z = new();

            if (x >= 0)
                mpz.add_ui(z, y, (ulong)x);
            else
                mpz.sub_ui(z, y, (ulong)-x);

            return z;
        }

        /// <summary>
        /// Adds two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator +(mpz_t x, ulong y)
        {
            var z = new mpz_t();

            mpz.add_ui(z, x, y);

            return z;
        }

        /// <summary>
        /// Adds two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator +(ulong x, mpz_t y)
        {
            var z = new mpz_t();

            mpz.add_ui(z, y, x);

            return z;
        }

        /// <summary>
        /// Increments an operand.
        /// </summary>
        /// <param name="x">The operand.</param>
        public static mpz_t operator ++(mpz_t x)
        {
            using var z = new mpz_t();

            mpz.add_ui(z, x, 1UL);
            mpz.set(x, z);

            return x;
        }

        /// <summary>
        /// Subtracts two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator -(mpz_t x, mpz_t y)
        {
            var z = new mpz_t();

            mpz.sub(z, x, y);

            return z;
        }

        /// <summary>
        /// Subtracts two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator -(long x, mpz_t y)
        {
            if (x >= 0)
            {
                var z = new mpz_t();

                mpz.ui_sub(z, (ulong)x, y);

                return z;
            }
            else
            {
                var z = new mpz_t();

                mpz.add_ui(z, y, (ulong)-x);
                mpz.neg(z, z);

                return z;
            }
        }

        /// <summary>
        /// Subtracts two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator -(mpz_t x, long y)
        {
            var z = new mpz_t();

            if (y >= 0)
                mpz.sub_ui(z, x, (ulong)y);
            else
                mpz.add_ui(z, x, (ulong)-y);

            return z;
        }

        /// <summary>
        /// Subtracts two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator -(ulong x, mpz_t y)
        {
            var z = new mpz_t();

            mpz.ui_sub(z, x, y);

            return z;
        }

        /// <summary>
        /// Subtracts two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator -(mpz_t x, ulong y)
        {
            var z = new mpz_t();

            mpz.sub_ui(z, x, y);

            return z;
        }

        /// <summary>
        /// Decrements an operand.
        /// </summary>
        /// <param name="x">The operand.</param>
        public static mpz_t operator --(mpz_t x)
        {
            using var z = new mpz_t();

            mpz.sub_ui(z, x, 1UL);
            mpz.set(x, z);

            return x;
        }

        /// <summary>
        /// Multiplies two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator *(mpz_t x, mpz_t y)
        {
            var z = new mpz_t();

            mpz.mul(z, x, y);

            return z;
        }

        /// <summary>
        /// Multiplies two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator *(long x, mpz_t y)
        {
            var z = new mpz_t();

            mpz.mul_si(z, y, x);

            return z;
        }

        /// <summary>
        /// Multiplies two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator *(mpz_t x, long y)
        {
            var z = new mpz_t();

            mpz.mul_si(z, x, y);

            return z;
        }

        /// <summary>
        /// Multiplies two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator *(ulong x, mpz_t y)
        {
            var z = new mpz_t();

            mpz.mul_ui(z, y, x);

            return z;
        }

        /// <summary>
        /// Multiplies two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator *(mpz_t x, ulong y)
        {
            var z = new mpz_t();

            mpz.mul_ui(z, x, y);

            return z;
        }

        /// <summary>
        /// Shifts an operand to the left.
        /// </summary>
        /// <param name="x">The operand.</param>
        /// <param name="count">The number of bits to shift.</param>
        public static mpz_t operator <<(mpz_t x, int count)
        {
            var z = new mpz_t();

            if (count >= 0)
                mpz.mul_2exp(z, x, (ulong)count);

            return z;
        }

        /// <summary>
        /// Shifts an operand to the right.
        /// </summary>
        /// <param name="x">The operand.</param>
        /// <param name="count">The number of bits to shift.</param>
        public static mpz_t operator >>(mpz_t x, int count)
        {
            var z = new mpz_t();

            if (count >= 0)
                mpz.tdiv_q_2exp(z, x, (ulong)count);

            return z;
        }

        /// <summary>
        /// Negates an operand.
        /// </summary>
        /// <param name="x">The operand.</param>
        public static mpz_t operator -(mpz_t x)
        {
            var z = new mpz_t();

            mpz.neg(z, x);

            return z;
        }

        /// <summary>
        /// Divides two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator /(mpz_t x, mpz_t y)
        {
            var quotient = new mpz_t();

            mpz.tdiv_q(quotient, x, y);

            return quotient;
        }

        /// <summary>
        /// Divides two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator /(mpz_t x, long y)
        {
            if (y >= 0)
            {
                var quotient = new mpz_t();

                mpz.tdiv_q_ui(quotient, x, (ulong)y);

                return quotient;
            }
            else
            {
                var quotient = new mpz_t();

                mpz.tdiv_q_ui(quotient, x, (ulong)-y);
                mpz.neg(quotient, quotient);

                return quotient;
            }
        }

        /// <summary>
        /// Divides two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator /(mpz_t x, ulong y)
        {
            var quotient = new mpz_t();

            mpz.tdiv_q_ui(quotient, x, y);

            return quotient;
        }

        /// <summary>
        /// Gets the modulo of an operand.
        /// </summary>
        /// <param name="x">The operand.</param>
        /// <param name="mod">The modulo.</param>
        public static mpz_t operator %(mpz_t x, mpz_t mod)
        {
            var z = new mpz_t();

            mpz.mod(z, x, mod);

            return z;
        }

        /// <summary>
        /// Gets the modulo of an operand.
        /// </summary>
        /// <param name="x">The operand.</param>
        /// <param name="mod">The modulo.</param>
        public static mpz_t operator %(mpz_t x, long mod)
        {
            if (mod < 0)
                throw new ArgumentOutOfRangeException(nameof(mod));

            var z = new mpz_t();

            mpz.fdiv_r_ui(z, x, (ulong)mod);

            return z;
        }

        /// <summary>
        /// Gets the modulo of an operand.
        /// </summary>
        /// <param name="x">The operand.</param>
        /// <param name="mod">The modulo.</param>
        public static mpz_t operator %(mpz_t x, ulong mod)
        {
            var z = new mpz_t();

            mpz.fdiv_r_ui(z, x, mod);

            return z;
        }

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpz_t x, mpz_t y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(int x, mpz_t y) => y.CompareTo(x) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpz_t x, int y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(uint x, mpz_t y) => y.CompareTo(x) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpz_t x, uint y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(long x, mpz_t y) => y.CompareTo(x) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpz_t x, long y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(ulong x, mpz_t y) => y.CompareTo(x) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpz_t x, ulong y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(float x, mpz_t y) => y.CompareTo(x) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpz_t x, float y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(double x, mpz_t y) => y.CompareTo(x) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <(mpz_t x, double y) => x.CompareTo(y) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpz_t x, mpz_t y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(int x, mpz_t y) => y.CompareTo(x) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpz_t x, int y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(uint x, mpz_t y) => y.CompareTo(x) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpz_t x, uint y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(long x, mpz_t y) => y.CompareTo(x) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpz_t x, long y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(ulong x, mpz_t y) => y.CompareTo(x) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpz_t x, ulong y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(float x, mpz_t y) => y.CompareTo(x) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpz_t x, float y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(double x, mpz_t y) => y.CompareTo(x) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator <=(mpz_t x, double y) => x.CompareTo(y) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpz_t x, mpz_t y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(int x, mpz_t y) => y.CompareTo(x) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpz_t x, int y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(uint x, mpz_t y) => y.CompareTo(x) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpz_t x, uint y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(long x, mpz_t y) => y.CompareTo(x) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpz_t x, long y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(ulong x, mpz_t y) => y.CompareTo(x) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpz_t x, ulong y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(float x, mpz_t y) => y.CompareTo(x) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpz_t x, float y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(double x, mpz_t y) => y.CompareTo(x) < 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >(mpz_t x, double y) => x.CompareTo(y) > 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpz_t x, mpz_t y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(int x, mpz_t y) => y.CompareTo(x) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpz_t x, int y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(uint x, mpz_t y) => y.CompareTo(x) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpz_t x, uint y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(long x, mpz_t y) => y.CompareTo(x) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpz_t x, long y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(ulong x, mpz_t y) => y.CompareTo(x) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpz_t x, ulong y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(float x, mpz_t y) => y.CompareTo(x) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpz_t x, float y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(double x, mpz_t y) => y.CompareTo(x) <= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator >=(mpz_t x, double y) => x.CompareTo(y) >= 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpz_t x, mpz_t y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(int x, mpz_t y) => y.CompareTo(x) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpz_t x, int y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(uint x, mpz_t y) => y.CompareTo(x) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpz_t x, uint y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(long x, mpz_t y) => y.CompareTo(x) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpz_t x, long y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(ulong x, mpz_t y) => y.CompareTo(x) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpz_t x, ulong y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(float x, mpz_t y) => y.CompareTo(x) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpz_t x, float y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(double x, mpz_t y) => y.CompareTo(x) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator ==(mpz_t x, double y) => x.CompareTo(y) == 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpz_t x, mpz_t y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(int x, mpz_t y) => y.CompareTo(x) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpz_t x, int y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(uint x, mpz_t y) => y.CompareTo(x) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpz_t x, uint y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(long x, mpz_t y) => y.CompareTo(x) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpz_t x, long y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(ulong x, mpz_t y) => y.CompareTo(x) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpz_t x, ulong y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(float x, mpz_t y) => y.CompareTo(x) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpz_t x, float y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(double x, mpz_t y) => y.CompareTo(x) != 0;

        /// <summary>
        /// Compares two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static bool operator !=(mpz_t x, double y) => x.CompareTo(y) != 0;

        /// <summary>
        /// Gets the bitwise and of two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator &(mpz_t x, mpz_t y)
        {
            var z = new mpz_t();

            mpz.and(z, x, y);

            return z;
        }

        /// <summary>
        /// Gets the bitwise or of two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator |(mpz_t x, mpz_t y)
        {
            var z = new mpz_t();

            mpz.ior(z, x, y);

            return z;
        }

        /// <summary>
        /// Gets the bitwise xor of two operands.
        /// </summary>
        /// <param name="x">The first operand.</param>
        /// <param name="y">The second operand.</param>
        public static mpz_t operator ^(mpz_t x, mpz_t y)
        {
            var z = new mpz_t();

            mpz.xor(z, x, y);

            return z;
        }

        /// <summary>
        /// Gets the two's-complement of an operand.
        /// </summary>
        /// <param name="x">The operand.</param>
        public static mpz_t operator ~(mpz_t x)
        {
            var z = new mpz_t();

            mpz.com(z, x);

            return z;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object..</param>
        public override bool Equals(object? obj) => obj is mpz_t other && CompareTo(other) == 0;

        /// <summary>
        /// Gets the hash of the object.
        /// </summary>
        public override int GetHashCode() => Convert.ToBase64String(ToByteArray()).GetHashCode();
    }
}
