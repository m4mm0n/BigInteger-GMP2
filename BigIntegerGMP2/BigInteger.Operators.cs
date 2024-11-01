using BigIntegerGMP2.Internals.mpir;
using BigIntegerGMP2.Internals.mpz_t;

namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        /// <summary>
        /// Explicitly converts an mpz_t value to a BigInteger.
        /// </summary>
        /// <param name="value">The mpz_t value to convert.</param>
        /// <returns>A new BigInteger representing the given mpz_t value.</returns>
        public static explicit operator BigInteger(mpz_t value) => new(value);

        /// <summary>
        /// Implicitly converts a BigInteger to an mpz_t value.
        /// </summary>
        /// <param name="value">The BigInteger value to convert.</param>
        /// <returns>The mpz_t representation of the given BigInteger value.</returns>
        public static implicit operator mpz_t(BigInteger value) => value._value;

        /// <summary>
        /// Converts a byte array to a BigInteger explicitly.
        /// </summary>
        /// <param name="value">The byte array to convert to BigInteger.</param>
        /// <returns>A BigInteger representation of the given byte array.</returns>
        public static explicit operator BigInteger(byte[] value) => new(value);

        /// <summary>
        /// Converts a BigInteger to a byte array implicitly.
        /// </summary>
        /// <param name="value">The BigInteger to convert to a byte array.</param>
        /// <returns>A byte array representation of the given BigInteger.</returns>
        public static implicit operator byte[](BigInteger value) => value.ToByteArray();

        /// <summary>
        /// Converts a string to a BigInteger explicitly.
        /// </summary>
        /// <param name="value">The string to convert to BigInteger.</param>
        /// <returns>A BigInteger representation of the given string.</returns>
        public static explicit operator BigInteger(string value) => new(value);

        /// <summary>
        /// Converts a BigInteger to a string implicitly.
        /// </summary>
        /// <param name="value">The BigInteger to convert to a string.</param>
        /// <returns>A string representation of the given BigInteger.</returns>
        public static implicit operator string(BigInteger value) => value.ToString();

        /// <summary>
        /// Converts an integer to a BigInteger explicitly.
        /// </summary>
        /// <param name="value">The integer value to convert to BigInteger.</param>
        /// <returns>A BigInteger representation of the given integer.</returns>
        public static explicit operator BigInteger(int value) => new(value);

        /// <summary>
        /// Converts a BigInteger to an integer implicitly.
        /// </summary>
        /// <param name="value">The BigInteger to convert to an integer.</param>
        /// <returns>An integer representation of the given BigInteger.</returns>
        public static implicit operator int(BigInteger value) => value.ToInt32();

        /// <summary>
        /// Converts a long value to a BigInteger explicitly.
        /// </summary>
        /// <param name="value">The long value to convert to BigInteger.</param>
        /// <returns>A BigInteger representation of the given long value.</returns>
        public static explicit operator BigInteger(long value) => new(value);

        /// <summary>
        /// Converts a BigInteger to a long value implicitly.
        /// </summary>
        /// <param name="value">The BigInteger to convert to a long value.</param>
        /// <returns>A long representation of the given BigInteger.</returns>
        public static implicit operator long(BigInteger value) => value.ToInt64();

        /// <summary>
        /// Converts an unsigned integer to a BigInteger explicitly.
        /// </summary>
        /// <param name="value">The unsigned integer value to convert to BigInteger.</param>
        /// <returns>A BigInteger representation of the given unsigned integer.</returns>
        public static explicit operator BigInteger(uint value) => new(value);

        /// <summary>
        /// Converts a BigInteger to an unsigned integer implicitly.
        /// </summary>
        /// <param name="value">The BigInteger to convert to an unsigned integer.</param>
        /// <returns>An unsigned integer representation of the given BigInteger.</returns>
        public static implicit operator uint(BigInteger value) => value.ToUInt32();

        /// <summary>
        /// Converts an unsigned long value to a BigInteger explicitly.
        /// </summary>
        /// <param name="value">The unsigned long value to convert to BigInteger.</param>
        /// <returns>A BigInteger representation of the given unsigned long value.</returns>
        public static explicit operator BigInteger(ulong value) => new(value);

        /// <summary>
        /// Converts a BigInteger to an unsigned long value implicitly.
        /// </summary>
        /// <param name="value">The BigInteger to convert to an unsigned long value.</param>
        /// <returns>An unsigned long representation of the given BigInteger.</returns>
        public static implicit operator ulong(BigInteger value) => value.ToUInt64();

        /// <summary>
        /// Converts a double value to a BigInteger explicitly.
        /// </summary>
        /// <param name="value">The double value to convert to BigInteger.</param>
        /// <returns>A BigInteger representation of the given double value.</returns>
        public static explicit operator BigInteger(double value) => new(value);

        /// <summary>
        /// Converts a BigInteger to a double implicitly.
        /// </summary>
        /// <param name="value">The BigInteger to convert to a double.</param>
        /// <returns>A double representation of the given BigInteger.</returns>
        public static implicit operator double(BigInteger value) => value.ToDouble();

        /// <summary>
        /// Converts a float value to a BigInteger explicitly.
        /// </summary>
        /// <param name="value">The float value to convert to BigInteger.</param>
        /// <returns>A BigInteger representation of the given float value.</returns>
        public static explicit operator BigInteger(float value) => new(value);

        /// <summary>
        /// Converts a BigInteger to a float implicitly.
        /// </summary>
        /// <param name="value">The BigInteger to convert to a float.</param>
        /// <returns>A float representation of the given BigInteger.</returns>
        public static implicit operator float(BigInteger value) => value.ToSingle();
        /// <summary>
        /// Checks if two BigInteger instances are equal.
        /// </summary>
        /// <param name="left">The first BigInteger instance.</param>
        /// <param name="right">The second BigInteger instance.</param>
        /// <returns>True if both instances are equal; otherwise, false.</returns>
        public static bool operator ==(BigInteger? left, BigInteger? right) =>
            left is not null && right is not null && mpz.cmp(left._value, right._value) == 0;

        /// <summary>
        /// Checks if a BigInteger instance is equal to an integer value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>True if both are equal; otherwise, false.</returns>
        public static bool operator ==(BigInteger? left, int right) =>
            left is not null && mpz.cmp_si(left._value, right) == 0;

        /// <summary>
        /// Checks if an integer value is equal to a BigInteger instance.
        /// </summary>
        /// <param name="left">The integer value.</param>
        /// <param name="right">The BigInteger instance.</param>
        /// <returns>True if both are equal; otherwise, false.</returns>
        public static bool operator ==(int left, BigInteger? right) =>
            right is not null && mpz.cmp_si(right._value, left) == 0;

        /// <summary>
        /// Checks if two BigInteger instances are not equal.
        /// </summary>
        /// <param name="left">The first BigInteger instance.</param>
        /// <param name="right">The second BigInteger instance.</param>
        /// <returns>True if both instances are not equal; otherwise, false.</returns>
        public static bool operator !=(BigInteger? left, BigInteger? right) =>
            left is not null && right is not null && mpz.cmp(left._value, right._value) != 0;

        /// <summary>
        /// Checks if a BigInteger instance is not equal to an integer value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>True if both are not equal; otherwise, false.</returns>
        public static bool operator !=(BigInteger? left, int right) =>
            left is not null && mpz.cmp_si(left._value, right) != 0;

        /// <summary>
        /// Checks if an integer value is not equal to a BigInteger instance.
        /// </summary>
        /// <param name="left">The integer value.</param>
        /// <param name="right">The BigInteger instance.</param>
        /// <returns>True if both are not equal; otherwise, false.</returns>
        public static bool operator !=(int left, BigInteger? right) =>
            right is not null && mpz.cmp_si(right._value, left) != 0;

        /// <summary>
        /// Checks if a BigInteger instance is less than another BigInteger instance.
        /// </summary>
        /// <param name="left">The first BigInteger instance.</param>
        /// <param name="right">The second BigInteger instance.</param>
        /// <returns>True if the first instance is less than the second; otherwise, false.</returns>
        public static bool operator <(BigInteger? left, BigInteger? right) =>
            left is not null && right is not null && mpz.cmp(left._value, right._value) < 0;

        /// <summary>
        /// Checks if a BigInteger instance is less than an integer value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>True if the BigInteger is less than the integer; otherwise, false.</returns>
        public static bool operator <(BigInteger? left, int right) => left is not null && mpz.cmp_si(left._value, right) < 0;

        /// <summary>
        /// Checks if an integer value is less than a BigInteger instance.
        /// </summary>
        /// <param name="left">The integer value.</param>
        /// <param name="right">The BigInteger instance.</param>
        /// <returns>True if the integer is less than the BigInteger; otherwise, false.</returns>
        public static bool operator <(int left, BigInteger? right) =>
            right is not null && mpz.cmp_si(right._value, left) > 0;

        /// <summary>
        /// Checks if a BigInteger instance is less than a long value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The long value.</param>
        /// <returns>True if the BigInteger is less than the long value; otherwise, false.</returns>
        public static bool operator <(BigInteger? left, long right) =>
            left is not null && mpz.cmp_ui(left._value, (uint)right) < 0;

        /// <summary>
        /// Checks if a BigInteger instance is greater than another BigInteger instance.
        /// </summary>
        /// <param name="left">The first BigInteger instance.</param>
        /// <param name="right">The second BigInteger instance.</param>
        /// <returns>True if the first instance is greater than the second; otherwise, false.</returns>
        public static bool operator >(BigInteger? left, BigInteger? right) =>
            left is not null && right is not null && mpz.cmp(left._value, right._value) > 0;

        /// <summary>
        /// Checks if an integer value is greater than a BigInteger instance.
        /// </summary>
        /// <param name="left">The integer value.</param>
        /// <param name="right">The BigInteger instance.</param>
        /// <returns>True if the integer is greater than the BigInteger; otherwise, false.</returns>
        public static bool operator >(int left, BigInteger? right) =>
            right is not null && mpz.cmp_si(right._value, left) < 0;

        /// <summary>
        /// Checks if a BigInteger instance is greater than an integer value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>True if the BigInteger is greater than the integer; otherwise, false.</returns>
        public static bool operator >(BigInteger? left, int right) =>
            left is not null && mpz.cmp_si(left._value, right) > 0;

        /// <summary>
        /// Checks if a BigInteger instance is greater than a double value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The double value.</param>
        /// <returns>True if the BigInteger is greater than the double value; otherwise, false.</returns>
        public static bool operator >(BigInteger? left, double right) =>
            left is not null && mpz.cmp_d(left._value, right) > 0;

        /// <summary>
        /// Checks if a BigInteger instance is greater than a long value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The long value.</param>
        /// <returns>True if the BigInteger is greater than the long value; otherwise, false.</returns>
        public static bool operator >(BigInteger? left, long right) =>
            left is not null && mpz.cmp_ui(left._value, (uint)right) > 0;

        /// <summary>
        /// Checks if a BigInteger instance is less than a double value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The double value.</param>
        /// <returns>True if the BigInteger is less than the double value; otherwise, false.</returns>
        public static bool operator <(BigInteger? left, double right) =>
            left is not null && mpz.cmp_d(left._value, right) < 0;

        /// <summary>
        /// Checks if a BigInteger instance is less than or equal to another BigInteger instance.
        /// </summary>
        /// <param name="left">The first BigInteger instance.</param>
        /// <param name="right">The second BigInteger instance.</param>
        /// <returns>True if the first instance is less than or equal to the second; otherwise, false.</returns>
        public static bool operator <=(BigInteger? left, BigInteger? right) =>
            left is not null && right is not null && mpz.cmp(left._value, right._value) <= 0;

        /// <summary>
        /// Checks if a BigInteger instance is less than or equal to an integer value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>True if the BigInteger is less than or equal to the integer; otherwise, false.</returns>
        public static bool operator <=(BigInteger? left, int right) =>
            left is not null && mpz.cmp_si(left._value, right) <= 0;

        /// <summary>
        /// Checks if an integer value is less than or equal to a BigInteger instance.
        /// </summary>
        /// <param name="left">The integer value.</param>
        /// <param name="right">The BigInteger instance.</param>
        /// <returns>True if the integer is less than or equal to the BigInteger; otherwise, false.</returns>
        public static bool operator <=(int left, BigInteger? right) =>
            right is not null && mpz.cmp_si(right._value, left) >= 0;

        /// <summary>
        /// Checks if a BigInteger instance is greater than or equal to another BigInteger instance.
        /// </summary>
        /// <param name="left">The first BigInteger instance.</param>
        /// <param name="right">The second BigInteger instance.</param>
        /// <returns>True if the first instance is greater than or equal to the second; otherwise, false.</returns>
        public static bool operator >=(BigInteger? left, BigInteger? right) =>
            left is not null && right is not null && mpz.cmp(left._value, right._value) >= 0;

        /// <summary>
        /// Checks if a BigInteger instance is greater than or equal to an integer value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>True if the BigInteger is greater than or equal to the integer; otherwise, false.</returns>
        public static bool operator >=(BigInteger? left, int right) =>
            left is not null && mpz.cmp_si(left._value, right) >= 0;

        /// <summary>
        /// Checks if an integer value is greater than or equal to a BigInteger instance.
        /// </summary>
        /// <param name="left">The integer value.</param>
        /// <param name="right">The BigInteger instance.</param>
        /// <returns>True if the integer is greater than or equal to the BigInteger; otherwise, false.</returns>
        public static bool operator >=(int left, BigInteger? right) =>
            right is not null && mpz.cmp_si(right._value, left) <= 0;

        /// <summary>
        /// Shifts a BigInteger value to the left by a specified number of bits.
        /// </summary>
        /// <param name="left">The BigInteger value to shift.</param>
        /// <param name="right">The number of bits to shift left.</param>
        /// <returns>A new BigInteger representing the result of the left shift operation.</returns>
        public static BigInteger? operator <<(BigInteger? left, BigInteger? right)
        {
            if (left is null || right is null)
                return null;
            var result = new BigInteger();
            mpz.mul_2exp(result._value, left._value, mpz.get_ui(right._value));
            return result;
        }

        /// <summary>
        /// Shifts a BigInteger value to the left by a specified number of bits.
        /// </summary>
        /// <param name="left">The BigInteger value to shift.</param>
        /// <param name="right">The number of bits to shift left.</param>
        /// <returns>A new BigInteger representing the result of the left shift operation.</returns>
        public static BigInteger? operator <<(BigInteger? left, int right)
        {
            if (left is null)
                return null;
            var result = new BigInteger();
            mpz.mul_2exp(result._value, left._value, (uint)right);
            return result;
        }

        /// <summary>
        /// Shifts a BigInteger value to the right by a specified number of bits.
        /// </summary>
        /// <param name="left">The BigInteger value to shift.</param>
        /// <param name="right">The number of bits to shift right.</param>
        /// <returns>A new BigInteger representing the result of the right shift operation.</returns>
        public static BigInteger? operator >>(BigInteger? left, BigInteger? right)
        {
            if (left is null || right is null)
                return null;
            var result = new BigInteger();
            mpz.fdiv_q_2exp(result._value, left._value, mpz.get_ui(right._value));
            return result;
        }

        /// <summary>
        /// Shifts a BigInteger value to the right by a specified number of bits.
        /// </summary>
        /// <param name="left">The BigInteger value to shift.</param>
        /// <param name="right">The number of bits to shift right.</param>
        /// <returns>A new BigInteger representing the result of the right shift operation.</returns>
        public static BigInteger? operator >>(BigInteger? left, int right)
        {
            if (left is null)
                return null;
            var result = new BigInteger();
            mpz.fdiv_q_2exp(result._value, left._value, (uint)right);
            return result;
        }

        /// <summary>
        /// Adds two BigInteger instances.
        /// </summary>
        /// <param name="left">The first BigInteger instance.</param>
        /// <param name="right">The second BigInteger instance.</param>
        /// <returns>A new BigInteger representing the sum of the two instances.</returns>
        public static BigInteger? operator +(BigInteger? left, BigInteger? right)
        {
            if (left is null || right is null)
                return null;
            var result = new BigInteger();
            mpz.add(result._value, left._value, right._value);
            return result;
        }

        /// <summary>
        /// Adds a BigInteger instance and an integer value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>A new BigInteger representing the sum of the instance and the value.</returns>
        public static BigInteger? operator +(BigInteger? left, int right)
        {
            if (left is null)
                return null;
            var result = new BigInteger();
            mpz.add_ui(result._value, left._value, (uint)right);
            return result;
        }

        /// <summary>
        /// Returns the unary plus of a BigInteger instance.
        /// </summary>
        /// <param name="value">The BigInteger instance.</param>
        /// <returns>A new BigInteger representing the unary plus of the instance.</returns>
        public static BigInteger? operator +(BigInteger? value)
        {
            if (value is null)
                return null;
            var result = new BigInteger();
            mpz.add(result._value, value._value, result._value);
            return result;
        }

        /// <summary>
        /// Increments a BigInteger instance by one.
        /// </summary>
        /// <param name="value">The BigInteger instance to increment.</param>
        /// <returns>A new BigInteger representing the incremented value.</returns>
        public static BigInteger? operator ++(BigInteger? value)
        {
            if (value is null)
                return null;
            var result = new BigInteger();
            mpz.add_ui(result._value, value._value, 1);
            return result;
        }

        /// <summary>
        /// Decrements a BigInteger instance by one.
        /// </summary>
        /// <param name="value">The BigInteger instance to decrement.</param>
        /// <returns>A new BigInteger representing the decremented value.</returns>
        public static BigInteger? operator --(BigInteger? value)
        {
            if (value is null)
                return null;
            var result = new BigInteger();
            mpz.sub_ui(result._value, value._value, 1);
            return result;
        }

        /// <summary>
        /// Subtracts one BigInteger instance from another.
        /// </summary>
        /// <param name="left">The first BigInteger instance.</param>
        /// <param name="right">The second BigInteger instance.</param>
        /// <returns>A new BigInteger representing the result of the subtraction.</returns>
        public static BigInteger? operator -(BigInteger? left, BigInteger? right)
        {
            if (left is null || right is null)
                return null;
            var result = new BigInteger();
            mpz.sub(result._value, left._value, right._value);
            return result;
        }

        /// <summary>
        /// Subtracts an integer value from a BigInteger instance.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>A new BigInteger representing the result of the subtraction.</returns>
        public static BigInteger? operator -(BigInteger? left, int right)
        {
            if (left is null)
                return null;
            var result = new BigInteger();
            mpz.sub_ui(result._value, left._value, (uint)right);
            return result;
        }

        /// <summary>
        /// Subtracts an integer value from a BigInteger instance.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>A new BigInteger representing the result of the subtraction.</returns>
        public static BigInteger? operator -(BigInteger? left, uint right)
        {
            if (left is null)
                return null;
            var result = new BigInteger();
            mpz.sub_ui(result._value, left._value, right);
            return result;
        }

        /// <summary>
        /// Returns the negation of a BigInteger instance.
        /// </summary>
        /// <param name="value">The BigInteger instance to negate.</param>
        /// <returns>A new BigInteger representing the negated value.</returns>
        public static BigInteger? operator -(BigInteger? value)
        {
            if (value is null)
                return null;
            var result = new BigInteger();
            mpz.neg(result._value, value._value);
            return result;
        }

        /// <summary>
        /// Multiplies two BigInteger instances.
        /// </summary>
        /// <param name="left">The first BigInteger instance.</param>
        /// <param name="right">The second BigInteger instance.</param>
        /// <returns>A new BigInteger representing the product of the two instances.</returns>
        public static BigInteger? operator *(BigInteger? left, BigInteger? right)
        {
            if (left is null || right is null)
                return null;
            var result = new BigInteger();
            mpz.mul(result._value, left._value, right._value);
            return result;
        }

        /// <summary>
        /// Multiplies a BigInteger instance by an integer value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>A new BigInteger representing the product of the instance and the value.</returns>
        public static BigInteger? operator *(BigInteger? left, int right)
        {
            if (left is null)
                return null;
            var result = new BigInteger();
            mpz.mul_si(result._value, left._value, right);
            return result;
        }

        /// <summary>
        /// Multiplies a BigInteger instance by an integer value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>A new BigInteger representing the product of the instance and the value.</returns>
        public static BigInteger? operator *(BigInteger? left, uint right)
        {
            if (left is null)
                return null;
            var result = new BigInteger();
            mpz.mul_ui(result._value, left._value, right);
            return result;
        }

        /// <summary>
        /// Divides one BigInteger instance by another.
        /// </summary>
        /// <param name="left">The dividend BigInteger instance.</param>
        /// <param name="right">The divisor BigInteger instance.</param>
        /// <returns>A new BigInteger representing the quotient.</returns>
        public static BigInteger? operator /(BigInteger? left, BigInteger? right)
        {
            if (left is null || right is null)
                return null;
            var result = new BigInteger();
            mpz.fdiv_q(result._value, left._value, right._value);
            return result;
        }

        /// <summary>
        /// Divides a BigInteger instance by an integer value.
        /// </summary>
        /// <param name="left">The dividend BigInteger instance.</param>
        /// <param name="right">The divisor integer value.</param>
        /// <returns>A new BigInteger representing the quotient.</returns>
        public static BigInteger? operator /(BigInteger? left, int right)
        {
            if (left is null)
                return null;
            var result = new BigInteger();
            mpz.fdiv_q_ui(result._value, left._value, (uint)right);
            return result;
        }

        /// <summary>
        /// Calculates the remainder when dividing one BigInteger instance by another.
        /// </summary>
        /// <param name="left">The dividend BigInteger instance.</param>
        /// <param name="right">The divisor BigInteger instance.</param>
        /// <returns>A new BigInteger representing the remainder.</returns>
        public static BigInteger? operator %(BigInteger? left, BigInteger? right)
        {
            if (left is null || right is null)
                return null;
            var result = new BigInteger();
            mpz.mod(result._value, left._value, right._value);
            return result;
        }

        /// <summary>
        /// Calculates the remainder when dividing a BigInteger instance by an integer value.
        /// </summary>
        /// <param name="left">The dividend BigInteger instance.</param>
        /// <param name="right">The divisor integer value.</param>
        /// <returns>A new BigInteger representing the remainder.</returns>
        public static BigInteger? operator %(BigInteger? left, int right)
        {
            if (left is null)
                return null;
            var result = new BigInteger();
            mpz.mod(result._value, left._value, (uint)right);
            return result;
        }

        /// <summary>
        /// Calculates the remainder when dividing a BigInteger instance by an unsigned integer value.
        /// </summary>
        /// <param name="left">The dividend BigInteger instance.</param>
        /// <param name="right">The divisor unsigned integer value.</param>
        /// <returns>A new BigInteger representing the remainder.</returns>
        public static BigInteger? operator %(BigInteger? left, uint right)
        {
            if (left is null)
                return null;
            var result = new BigInteger();
            mpz.mod(result._value, left._value, right);
            return result;
        }

        /// <summary>
        /// Performs a bitwise AND operation between two BigInteger instances.
        /// </summary>
        /// <param name="left">The first BigInteger instance.</param>
        /// <param name="right">The second BigInteger instance.</param>
        /// <returns>A new BigInteger representing the result of the bitwise AND operation.</returns>
        public static BigInteger? operator &(BigInteger? left, BigInteger? right)
        {
            if (left is null || right is null)
                return null;
            var result = new BigInteger();
            mpz.and(result._value, left._value, right._value);
            return result;
        }

        /// <summary>
        /// Performs a bitwise AND operation between a BigInteger instance and an integer value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>A new BigInteger representing the result of the bitwise AND operation.</returns>
        public static BigInteger? operator &(BigInteger? left, int right)
        {
            if (left is null)
                return null;
            var _right = new BigInteger();
            var result = new BigInteger();

            mpz.set_si(_right._value, right);
            mpz.and(result._value, left._value, _right._value);
            return result;
        }

        /// <summary>
        /// Performs a bitwise NOT operation on a BigInteger instance.
        /// </summary>
        /// <param name="value">The BigInteger instance.</param>
        /// <returns>A new BigInteger representing the result of the bitwise NOT operation.</returns>
        public static BigInteger? operator ~(BigInteger? value)
        {
            if (value is null)
                return null;
            var result = new BigInteger();
            mpz.com(result._value, value._value);
            return result;
        }

        /// <summary>
        /// Performs a bitwise OR operation between two BigInteger instances.
        /// </summary>
        /// <param name="left">The first BigInteger instance.</param>
        /// <param name="right">The second BigInteger instance.</param>
        /// <returns>A new BigInteger representing the result of the bitwise OR operation.</returns>
        public static BigInteger? operator |(BigInteger? left, BigInteger? right)
        {
            if (left is null || right is null)
                return null;
            var result = new BigInteger();
            mpz.ior(result._value, left._value, right._value);
            return result;
        }

        /// <summary>
        /// Performs a bitwise OR operation between a BigInteger instance and an integer value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>A new BigInteger representing the result of the bitwise OR operation.</returns>
        public static BigInteger? operator |(BigInteger? left, int right)
        {
            if (left is null)
                return null;
            var _right = new BigInteger();
            var result = new BigInteger();

            mpz.set_si(_right._value, right);
            mpz.ior(result._value, left._value, _right._value);
            return result;
        }

        /// <summary>
        /// Performs a bitwise XOR operation between two BigInteger instances.
        /// </summary>
        /// <param name="left">The first BigInteger instance.</param>
        /// <param name="right">The second BigInteger instance.</param>
        /// <returns>A new BigInteger representing the result of the bitwise XOR operation.</returns>
        public static BigInteger? operator ^(BigInteger? left, BigInteger? right)
        {
            if (left is null || right is null)
                return null;
            var result = new BigInteger();
            mpz.xor(result._value, left._value, right._value);
            return result;
        }

        /// <summary>
        /// Performs a bitwise XOR operation between a BigInteger instance and an integer value.
        /// </summary>
        /// <param name="left">The BigInteger instance.</param>
        /// <param name="right">The integer value.</param>
        /// <returns>A new BigInteger representing the result of the bitwise XOR operation.</returns>
        public static BigInteger? operator ^(BigInteger? left, int right)
        {
            if (left is null)
                return null;
            var _right = new BigInteger();
            var result = new BigInteger();

            mpz.set_si(_right._value, right);
            mpz.xor(result._value, left._value, _right._value);
            return result;
        }
    }
}
