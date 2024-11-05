using BigIntegerGMP2.Internals.mpir;
using BigIntegerGMP2.Internals.mpz_t;

namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        /// <summary>
        /// Returns the absolute value of the current BigInteger instance.
        /// </summary>
        /// <returns>A BigInteger representing the absolute value of the current instance.</returns>
        public BigInteger Abs()
        {
            var result = new BigInteger();
            mpz.abs(result, this);
            return result;
        }
        /// <summary>
        /// Returns the absolute value of the current BigInteger instance.
        /// </summary>
        /// <param name="value">The BigInteger value to get the absolute value of.</param>
        /// <returns>A BigInteger representing the absolute value of the current instance.</returns>
        public static BigInteger Abs(BigInteger value)
        {
            var result = new BigInteger();
            mpz.abs(result._value, value._value);
            return result;
        }

        /// <summary>
        /// Adds a BigInteger to the current instance.
        /// </summary>
        /// <param name="x">The BigInteger to add.</param>
        /// <returns>A BigInteger representing the sum of the current instance and the specified BigInteger.</returns>
        public BigInteger Add(BigInteger x) => this + x;

        /// <summary>
        /// Adds an integer to the current BigInteger instance.
        /// </summary>
        /// <param name="x">The integer to add.</param>
        /// <returns>A BigInteger representing the sum of the current instance and the specified integer.</returns>
        public BigInteger Add(int x) => this + x;

        /// <summary>
        /// Adds an unsigned integer to the current BigInteger instance.
        /// </summary>
        /// <param name="x">The unsigned integer to add.</param>
        /// <returns>A BigInteger representing the sum of the current instance and the specified unsigned integer.</returns>
        public BigInteger Add(uint x) => (BigInteger)(this + x);

        /// <summary>
        /// Performs a bitwise AND operation between the current BigInteger instance and another BigInteger.
        /// </summary>
        /// <param name="x">The BigInteger to AND with the current instance.</param>
        /// <returns>A BigInteger representing the result of the bitwise AND operation.</returns>
        public BigInteger And(BigInteger x) => this & x;

        /// <summary>
        /// Computes the binomial coefficient (n choose k) for the specified BigInteger n and unsigned integer k.
        /// </summary>
        /// <param name="n">The BigInteger value representing n.</param>
        /// <param name="k">The unsigned integer value representing k.</param>
        /// <returns>A BigInteger representing the binomial coefficient.</returns>
        public static BigInteger Binomial(BigInteger n, uint k)
        {
            var z = new BigInteger();
            mpz.bin_ui(z, n, k);
            return z;
        }

        /// <summary>
        /// Computes the binomial coefficient (n choose k) for the specified BigInteger n and integer k.
        /// </summary>
        /// <param name="n">The BigInteger value representing n.</param>
        /// <param name="k">The integer value representing k.</param>
        /// <returns>A BigInteger representing the binomial coefficient.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if k is negative.</exception>
        public static BigInteger Binomial(BigInteger n, int k)
        {
            if (k < 0)
                throw new ArgumentOutOfRangeException();
            var z = new BigInteger();
            mpz.bin_ui(z, n, (uint)k);
            return z;
        }

        /// <summary>
        /// Computes the binomial coefficient (n choose k) for the specified unsigned integers n and k.
        /// </summary>
        /// <param name="n">The unsigned integer value representing n.</param>
        /// <param name="k">The unsigned integer value representing k.</param>
        /// <returns>A BigInteger representing the binomial coefficient.</returns>
        public static BigInteger Binomial(uint n, uint k)
        {
            var z = new BigInteger();
            mpz.bin_uiui(z, n, k);
            return z;
        }

        /// <summary>
        /// Computes the binomial coefficient (n choose k) for the specified integers n and k.
        /// </summary>
        /// <param name="n">The integer value representing n.</param>
        /// <param name="k">The integer value representing k.</param>
        /// <returns>A BigInteger representing the binomial coefficient.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if k is negative.</exception>
        public static BigInteger Binomial(int n, int k)
        {
            if (k < 0)
                throw new ArgumentOutOfRangeException();
            var z = new BigInteger();
            if (n >= 0)
            {
                mpz.bin_uiui(z, (uint)n, (uint)k);
                return z;
            }
            mpz.bin_uiui(z, (uint)(-n + k - 1), (uint)k);
            if (((uint)k & (true ? 1u : 0u)) != 0)
            {
                var res = -z;
                z.Dispose();
                return res;
            }
            return z;
        }

        /// <summary>
        /// Divides the current BigInteger instance by another BigInteger.
        /// </summary>
        /// <param name="x">The BigInteger to divide by.</param>
        /// <returns>A BigInteger representing the quotient.</returns>
        public BigInteger Divide(BigInteger x) => this / x;

        /// <summary>
        /// Divides the current BigInteger instance by an integer.
        /// </summary>
        /// <param name="x">The integer to divide by.</param>
        /// <returns>A BigInteger representing the quotient.</returns>
        public BigInteger Divide(int x) => this / x;

        /// <summary>
        /// Divides the current BigInteger instance by an unsigned integer.
        /// </summary>
        /// <param name="x">The unsigned integer to divide by.</param>
        /// <returns>A BigInteger representing the quotient.</returns>
        public BigInteger Divide(uint x) => (BigInteger)(this / x);

        /// <summary>
        /// Divides the current BigInteger instance by another mpz_t value and returns the quotient and remainder.
        /// </summary>
        /// <param name="x">The mpz_t value to divide by.</param>
        /// <param name="remainder">Outputs the remainder of the division.</param>
        /// <returns>A BigInteger representing the quotient.</returns>
        public BigInteger Divide(mpz_t x, out BigInteger remainder)
        {
            var quotient = new BigInteger();
            remainder = new BigInteger();
            mpz.tdiv_qr(quotient, remainder, this, x);
            return quotient;
        }

        /// <summary>
        /// Divides the current BigInteger instance by an integer and returns the quotient and remainder.
        /// </summary>
        /// <param name="x">The integer value to divide by.</param>
        /// <param name="remainder">Outputs the remainder of the division.</param>
        /// <returns>A BigInteger representing the quotient.</returns>
        public BigInteger Divide(int x, out BigInteger remainder)
        {
            var quotient = new BigInteger();
            remainder = new BigInteger();
            if (x >= 0)
            {
                mpz.tdiv_qr_ui(quotient, remainder, this, (uint)x);
                return quotient;
            }
            mpz.tdiv_qr_ui(quotient, remainder, this, (uint)(-x));
            var res = -quotient;
            quotient.Dispose();
            return res;
        }

        /// <summary>
        /// Divides the current BigInteger instance by an integer and returns the quotient and remainder as an integer.
        /// </summary>
        /// <param name="x">The integer value to divide by.</param>
        /// <param name="remainder">Outputs the remainder of the division as an integer.</param>
        /// <returns>A BigInteger representing the quotient.</returns>
        public BigInteger Divide(int x, out int remainder)
        {
            var quotient = new BigInteger();
            if (x >= 0)
            {
                remainder = (int)mpz.tdiv_q_ui(quotient, this, (uint)x);
                return quotient;
            }
            remainder = (int)(0 - mpz.tdiv_q_ui(quotient, this, (uint)(-x)));
            var res = -quotient;
            quotient.Dispose();
            return res;
        }

        /// <summary>
        /// Divides the current BigInteger instance by an unsigned integer and returns the quotient and remainder.
        /// </summary>
        /// <param name="x">The unsigned integer value to divide by.</param>
        /// <param name="remainder">Outputs the remainder of the division as a BigInteger.</param>
        /// <returns>A BigInteger representing the quotient.</returns>
        public BigInteger Divide(uint x, out BigInteger remainder)
        {
            var quotient = new BigInteger();
            remainder = new BigInteger();
            mpz.tdiv_qr_ui(quotient, remainder, this, x);
            return quotient;
        }

        /// <summary>
        /// Divides the current BigInteger instance by an unsigned integer and returns the quotient and remainder as an unsigned integer.
        /// </summary>
        /// <param name="x">The unsigned integer value to divide by.</param>
        /// <param name="remainder">Outputs the remainder of the division as an unsigned integer.</param>
        /// <returns>A BigInteger representing the quotient.</returns>
        public BigInteger Divide(uint x, out uint remainder)
        {
            var quotient = new BigInteger();
            remainder = (uint)mpz.tdiv_q_ui(quotient, this, x);
            return quotient;
        }

        /// <summary>
        /// Divides the current BigInteger instance by an unsigned integer and returns the quotient and remainder as an integer.
        /// </summary>
        /// <param name="x">The unsigned integer value to divide by.</param>
        /// <param name="remainder">Outputs the remainder of the division as an integer.</param>
        /// <returns>A BigInteger representing the quotient.</returns>
        /// <exception cref="OverflowException">Thrown if the remainder exceeds the maximum value of an integer.</exception>
        public BigInteger Divide(uint x, out int remainder)
        {
            var quotient = new BigInteger();
            var uintRemainder = mpz.tdiv_q_ui(quotient, this, x);
            if (uintRemainder > int.MaxValue)
                throw new OverflowException();
            remainder = this >= 0 ? (int)uintRemainder : (int)(0 - uintRemainder);
            return quotient;
        }

        /// <summary>
        /// Divides the current BigInteger instance exactly by another BigInteger.
        /// </summary>
        /// <param name="x">The BigInteger to divide by.</param>
        /// <returns>A BigInteger representing the exact quotient.</returns>
        public BigInteger DivideExactly(BigInteger x)
        {
            var z = new BigInteger();
            mpz.divexact(z, this, x);
            return z;
        }

        /// <summary>
        /// Divides the current BigInteger instance exactly by an integer.
        /// </summary>
        /// <param name="x">The integer to divide by.</param>
        /// <returns>A BigInteger representing the exact quotient.</returns>
        public BigInteger DivideExactly(int x)
        {
            var z = new BigInteger();
            mpz.divexact_ui(z, this, (uint)x);
            if (x < 0)
            {
                var res = -z;
                z.Dispose();
                return res;
            }
            return z;
        }

        /// <summary>
        /// Divides the current BigInteger instance exactly by an unsigned integer.
        /// </summary>
        /// <param name="x">The unsigned integer to divide by.</param>
        /// <returns>A BigInteger representing the exact quotient.</returns>
        public BigInteger DivideExactly(uint x)
        {
            var z = new BigInteger();
            mpz.divexact_ui(z, this, x);
            return z;
        }

        /// <summary>
        /// Divides the current BigInteger instance by another BigInteger and then takes the modulus of a specified value.
        /// </summary>
        /// <param name="x">The BigInteger to divide by.</param>
        /// <param name="mod">The modulus to apply after division.</param>
        /// <returns>A BigInteger representing the result of the division followed by the modulus operation.</returns>
        public BigInteger DivideMod(BigInteger x, BigInteger mod) => this * x.InvertMod(mod) % mod;

        /// <summary>
        /// Checks if the modular inverse exists for the current BigInteger instance with respect to a modulus.
        /// </summary>
        /// <param name="mod">The modulus to use in the inverse check.</param>
        /// <returns>A boolean value indicating whether the modular inverse exists.</returns>
        public bool InverseModExists(BigInteger mod)
        {
            TryInvertMod(mod, out var _);
            return true;
        }

        /// <summary>
        /// Calculates the modular inverse of the current BigInteger instance with respect to a specified modulus.
        /// </summary>
        /// <param name="mod">The modulus to use in the inversion.</param>
        /// <returns>A BigInteger representing the modular inverse.</returns>
        /// <exception cref="ArithmeticException">Thrown if the modular inverse does not exist.</exception>
        public BigInteger InvertMod(BigInteger mod)
        {
            var z = new BigInteger();
            return !mpz.invert(z, this, mod)
                ? throw new ArithmeticException("This modular inverse does not exists.")
                : z;
        }

        /// <summary>
        /// Attempts to calculate the modular inverse of the current BigInteger instance with respect to a specified modulus.
        /// </summary>
        /// <param name="mod">The modulus to use in the inversion.</param>
        /// <param name="result">The output BigInteger representing the modular inverse if successful; otherwise, null.</param>
        /// <returns>A boolean value indicating whether the modular inverse was successfully calculated.</returns>
        public bool TryInvertMod(BigInteger mod, out BigInteger result)
        {
            var z = new BigInteger();
            if (!mpz.invert(z, this, mod))
            {
                result = null;
                return false;
            }
            result = z;
            return true;
        }

        /// <summary>
        /// Computes the factorial of a specified non-negative integer.
        /// </summary>
        /// <param name="x">The integer value for which to compute the factorial.</param>
        /// <returns>A BigInteger representing the factorial of the specified integer.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if x is negative.</exception>
        public static BigInteger Factorial(int x)
        {
            if (x < 0)
                throw new ArgumentOutOfRangeException();
            var z = new BigInteger();
            mpz.fac_ui(z, (uint)x);
            return z;
        }

        /// <summary>
        /// Computes the factorial of a specified unsigned integer.
        /// </summary>
        /// <param name="x">The unsigned integer value for which to compute the factorial.</param>
        /// <returns>A BigInteger representing the factorial of the specified unsigned integer.</returns>
        public static BigInteger Factorial(uint x)
        {
            var z = new BigInteger();
            mpz.fac_ui(z, x);
            return z;
        }

        /// <summary>
        /// Computes the greatest common divisor (GCD) of two BigInteger values.
        /// </summary>
        /// <param name="x">The first BigInteger value.</param>
        /// <param name="y">The second BigInteger value.</param>
        /// <returns>A BigInteger representing the GCD of x and y.</returns>
        public static BigInteger Gcd(BigInteger x, BigInteger y)
        {
            var z = new BigInteger();
            mpz.gcd(z, x, y);
            return z;
        }

        /// <summary>
        /// Computes the greatest common divisor (GCD) of a BigInteger and an integer value.
        /// </summary>
        /// <param name="x">The BigInteger value.</param>
        /// <param name="y">The integer value.</param>
        /// <returns>A BigInteger representing the GCD of x and y.</returns>
        public static BigInteger Gcd(BigInteger x, int y)
        {
            var z = new BigInteger();
            if (y >= 0)
                mpz.gcd_ui(z, x, (uint)y);
            else
                mpz.gcd_ui(z, x, (uint)(-y));
            return z;
        }

        /// <summary>
        /// Computes the greatest common divisor (GCD) of an integer value and a BigInteger.
        /// </summary>
        /// <param name="x">The integer value.</param>
        /// <param name="y">The BigInteger value.</param>
        /// <returns>A BigInteger representing the GCD of x and y.</returns>
        public static BigInteger Gcd(int x, BigInteger y)
        {
            var z = new BigInteger();
            if (x >= 0)
                mpz.gcd_ui(z, y, (uint)x);
            else
                mpz.gcd_ui(z, y, (uint)(-x));
            return z;
        }

        /// <summary>
        /// Computes the greatest common divisor (GCD) of a BigInteger and an unsigned integer value.
        /// </summary>
        /// <param name="x">The BigInteger value.</param>
        /// <param name="y">The unsigned integer value.</param>
        /// <returns>A BigInteger representing the GCD of x and y.</returns>
        public static BigInteger Gcd(BigInteger x, uint y)
        {
            var z = new BigInteger();
            mpz.gcd_ui(z, x, y);
            return z;
        }

        /// <summary>
        /// Computes the greatest common divisor (GCD) of an unsigned integer value and a BigInteger.
        /// </summary>
        /// <param name="x">The unsigned integer value.</param>
        /// <param name="y">The BigInteger value.</param>
        /// <returns>A BigInteger representing the GCD of x and y.</returns>
        public static BigInteger Gcd(uint x, BigInteger y)
        {
            var z = new BigInteger();
            mpz.gcd_ui(z, y, x);
            return z;
        }

        /// <summary>
        /// Computes the greatest common divisor (GCD) of two BigInteger values and also finds the coefficients of Bézout's identity.
        /// </summary>
        /// <param name="x">The first BigInteger value.</param>
        /// <param name="y">The second BigInteger value.</param>
        /// <param name="a">Outputs the coefficient a of Bézout's identity.</param>
        /// <param name="b">Outputs the coefficient b of Bézout's identity.</param>
        /// <returns>A BigInteger representing the GCD of x and y.</returns>
        public static BigInteger Gcd(BigInteger x, BigInteger y, out BigInteger a, out BigInteger b)
        {
            var z = new BigInteger();
            a = new BigInteger();
            b = new BigInteger();
            mpz.gcdext(z, a, b, x, y);
            return z;
        }

        /// <summary>
        /// Computes the greatest common divisor (GCD) of two BigInteger values and also finds one coefficient of Bézout's identity.
        /// </summary>
        /// <param name="x">The first BigInteger value.</param>
        /// <param name="y">The second BigInteger value.</param>
        /// <param name="a">Outputs the coefficient a of Bézout's identity.</param>
        /// <returns>A BigInteger representing the GCD of x and y.</returns>
        public static BigInteger Gcd(BigInteger x, BigInteger y, out BigInteger a)
        {
            var z = new BigInteger();
            a = new BigInteger();
            mpz.gcdext(z, a, null, x, y);
            return z;
        }

        /// <summary>
        /// Checks if the current BigInteger instance is divisible by another BigInteger.
        /// </summary>
        /// <param name="x">The BigInteger value to divide by.</param>
        /// <returns>True if the current instance is divisible by x; otherwise, false.</returns>
        public bool IsDivisibleBy(BigInteger x) => mpz.divisible_p(this, x);

        /// <summary>
        /// Checks if the current BigInteger instance is divisible by an integer.
        /// </summary>
        /// <param name="x">The integer value to divide by.</param>
        /// <returns>True if the current instance is divisible by x; otherwise, false.</returns>
        public bool IsDivisibleBy(int x) => x >= 0 ? mpz.divisible_ui_p(this, (uint)x) : mpz.divisible_ui_p(this, (uint)(-x));

        /// <summary>
        /// Checks if the current BigInteger instance is divisible by an unsigned integer.
        /// </summary>
        /// <param name="x">The unsigned integer value to divide by.</param>
        /// <returns>True if the current instance is divisible by x; otherwise, false.</returns>
        public bool IsDivisibleBy(uint x) => mpz.divisible_ui_p(this, x);

        /// <summary>
        /// Determines whether the current <see cref="BigInteger"/> value is even.
        /// </summary>
        /// <returns>True if the current value is even; otherwise, false.</returns>
        public bool IsEven() => !mpz.tstbit(this, 0);

        /// <summary>
        /// Determines whether the specified <see cref="BigInteger"/> value is even.
        /// </summary>
        /// <param name="value">The <see cref="BigInteger"/> value to check.</param>
        /// <returns>True if the specified value is even; otherwise, false.</returns>
        public static bool IsEven(BigInteger value) => !mpz.tstbit(value._value, 0);

        /// <summary>
        /// Checks if the current BigInteger instance is a perfect power.
        /// </summary>
        /// <returns>True if the current instance is a perfect power; otherwise, false.</returns>
        public bool IsPerfectPower() => mpz.perfect_power_p(this);

        /// <summary>
        /// Checks if the current BigInteger instance is a perfect square.
        /// </summary>
        /// <returns>True if the current instance is a perfect square; otherwise, false.</returns>
        public bool IsPerfectSquare() => mpz.perfect_square_p(this);

        /// <summary>
        /// Checks if the current BigInteger instance is a probable prime. (The probability is calculated using the Rabin-Miller primality test)
        /// </summary>
        /// <param name="probability">The probability value used to determine the accuracy of the primality test, default is 10</param>
        /// <param name="divider">An optional divider value for the test, default is 0.</param>
        /// <returns>True if the current instance is a probable prime; otherwise, false.</returns>
        public bool IsProbablePrime(int probability = 10, ulong divider = 0) => mpz.probable_prime_p(this, _randState, probability, divider);

        /// <summary>
        /// Checks if the current BigInteger instance is a probable prime. (The probability is calculated using the Rabin-Miller primality test)
        /// </summary>
        /// <param name="x">The value to check if it is a probable prime</param>
        /// <param name="probability">The probability value used to determine the accuracy of the primality test, default is 10</param>
        /// <param name="divider">An optional divider value for the test, default is 0.</param>
        /// <returns>True if the current instance is a probable prime; otherwise, false.</returns>
        public static bool IsProbablePrime(BigInteger x, int probability = 10, ulong divider = 0) => mpz.probable_prime_p(x, _randState, probability, divider);

        /// <summary>
        /// Returns the greater of two <see cref="BigInteger"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="BigInteger"/> value to compare.</param>
        /// <param name="right">The second <see cref="BigInteger"/> value to compare.</param>
        /// <returns>The larger of the two <see cref="BigInteger"/> values.</returns>
        public static BigInteger Max(BigInteger left, BigInteger right) => left >= right ? left : right;

        /// <summary>
        /// Returns the smaller of two <see cref="BigInteger"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="BigInteger"/> value to compare.</param>
        /// <param name="right">The second <see cref="BigInteger"/> value to compare.</param>
        /// <returns>The smaller of the two <see cref="BigInteger"/> values.</returns>
        public static BigInteger Min(BigInteger left, BigInteger right) => left <= right ? left : right;

        /// <summary>
        /// Computes the remainder of the current BigInteger instance divided by another BigInteger.
        /// </summary>
        /// <param name="mod">The BigInteger value to use as the modulus.</param>
        /// <returns>A BigInteger representing the remainder.</returns>
        public BigInteger Mod(BigInteger mod) => this % mod;

        /// <summary>
        /// Computes the remainder of the current BigInteger instance divided by an integer.
        /// </summary>
        /// <param name="mod">The integer value to use as the modulus.</param>
        /// <returns>A BigInteger representing the remainder.</returns>
        public BigInteger Mod(int mod) => this % mod;

        /// <summary>
        /// Computes the remainder of the current BigInteger instance divided by an unsigned integer.
        /// </summary>
        /// <param name="mod">The unsigned integer value to use as the modulus.</param>
        /// <returns>A BigInteger representing the remainder.</returns>
        public BigInteger Mod(uint mod) => this % mod;

        /// <summary>
        /// Computes the remainder of the current BigInteger instance divided by an integer and returns it as an Int32.
        /// </summary>
        /// <param name="mod">The integer value to use as the modulus. Must be non-negative.</param>
        /// <returns>An integer representing the remainder.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if mod is negative.</exception>
        public int ModAsInt32(int mod) => mod < 0 ? throw new ArgumentOutOfRangeException() : (int)mpz.fdiv_ui(this, (uint)mod);

        /// <summary>
        /// Computes the remainder of the current BigInteger instance divided by an unsigned integer and returns it as a UInt32.
        /// </summary>
        /// <param name="mod">The unsigned integer value to use as the modulus.</param>
        /// <returns>An unsigned integer representing the remainder.</returns>
        public uint ModAsUInt32(uint mod) => (uint)mpz.fdiv_ui(this, mod);

        /// <summary>
        /// Calculates the modular inverse of the current BigInteger instance with respect to a specified modulus.
        /// </summary>
        /// <param name="mod">The modulus to use in the inversion.</param>
        /// <returns>A BigInteger representing the modular inverse.</returns>
        public BigInteger ModInverse(BigInteger mod) => InvertMod(mod);

        /// <summary>
        /// Raises the current BigInteger instance to the power of the specified BigInteger exponent modulo another BigInteger.
        /// </summary>
        /// <param name="exponent">The BigInteger exponent to which to raise the current instance.</param>
        /// <param name="mod">The modulus to apply after exponentiation.</param>
        /// <returns>A BigInteger representing the result of raising the current instance to the specified power modulo mod.</returns>
        public BigInteger ModPow(BigInteger exponent, BigInteger mod) => PowerMod(exponent, mod);

        /// <summary>
        /// Multiplies the current BigInteger instance by another BigInteger.
        /// </summary>
        /// <param name="x">The BigInteger value to multiply by.</param>
        /// <returns>A BigInteger representing the product.</returns>
        public BigInteger Multiply(BigInteger x) => this * x;

        /// <summary>
        /// Multiplies the current BigInteger instance by an integer.
        /// </summary>
        /// <param name="x">The integer value to multiply by.</param>
        /// <returns>A BigInteger representing the product.</returns>
        public BigInteger Multiply(int x) => this * x;

        /// <summary>
        /// Multiplies the current BigInteger instance by an unsigned integer.
        /// </summary>
        /// <param name="x">The unsigned integer value to multiply by.</param>
        /// <returns>A BigInteger representing the product.</returns>
        public BigInteger Multiply(uint x) => this * x;

        /// <summary>
        /// Negates the current BigInteger instance.
        /// </summary>
        /// <returns>A BigInteger representing the negated value.</returns>
        public BigInteger Negate() => -this;

        /// <summary>
        /// Performs a bitwise OR operation between the current BigInteger instance and another BigInteger.
        /// </summary>
        /// <param name="x">The BigInteger value to OR with the current instance.</param>
        /// <returns>A BigInteger representing the result of the bitwise OR operation.</returns>
        public BigInteger Or(BigInteger x) => this | x;

        /// <summary>
        /// Raises the current BigInteger instance to the power of the specified non-negative integer exponent.
        /// </summary>
        /// <param name="exponent">The integer exponent to which to raise the current instance. Must be non-negative.</param>
        /// <returns>A BigInteger representing the result of raising the current instance to the specified power.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the exponent is negative.</exception>
        public BigInteger Power(int exponent)
        {
            if (exponent < 0)
                throw new ArgumentOutOfRangeException();
            var z = new BigInteger();
            mpz.pow_ui(z, this, (uint)exponent);
            return z;
        }

        /// <summary>
        /// Raises the current BigInteger instance to the power of the specified unsigned integer exponent.
        /// </summary>
        /// <param name="exponent">The unsigned integer exponent to which to raise the current instance.</param>
        /// <returns>A BigInteger representing the result of raising the current instance to the specified power.</returns>
        public BigInteger Power(uint exponent)
        {
            var z = new BigInteger();
            mpz.pow_ui(z, this, exponent);
            return z;
        }

        /// <summary>
        /// Raises an integer value to the power of the specified non-negative integer exponent.
        /// </summary>
        /// <param name="x">The base value to be raised to the power of the exponent.</param>
        /// <param name="exponent">The integer exponent. Must be non-negative.</param>
        /// <returns>A BigInteger representing the result of raising x to the specified power.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the exponent is negative.</exception>
        public static BigInteger Power(int x, int exponent)
        {
            if (exponent < 0)
                throw new ArgumentOutOfRangeException();
            var z = new BigInteger();
            mpz.ui_pow_ui(z, (uint)x, (uint)exponent);
            return z;
        }

        /// <summary>
        /// Raises an unsigned integer value to the power of the specified unsigned integer exponent.
        /// </summary>
        /// <param name="x">The base value to be raised to the power of the exponent.</param>
        /// <param name="exponent">The unsigned integer exponent.</param>
        /// <returns>A BigInteger representing the result of raising x to the specified power.</returns>
        public static BigInteger Power(uint x, uint exponent)
        {
            var z = new BigInteger();
            mpz.ui_pow_ui(z, x, exponent);
            return z;
        }

        /// <summary>
        /// Raises the current BigInteger instance to the power of the specified BigInteger exponent modulo another BigInteger.
        /// </summary>
        /// <param name="exponent">The BigInteger exponent to which to raise the current instance.</param>
        /// <param name="mod">The modulus to apply after exponentiation.</param>
        /// <returns>A BigInteger representing the result of raising the current instance to the specified power modulo mod.</returns>
        public BigInteger PowerMod(BigInteger exponent, BigInteger mod)
        {
            var z = new BigInteger();
            mpz.powm(z, this, exponent, mod);
            return z;
        }

        /// <summary>
        /// Raises the current BigInteger instance to the power of the specified integer exponent modulo another BigInteger.
        /// </summary>
        /// <param name="exponent">The integer exponent to which to raise the current instance.</param>
        /// <param name="mod">The modulus to apply after exponentiation.</param>
        /// <returns>A BigInteger representing the result of raising the current instance to the specified power modulo mod.</returns>
        public BigInteger PowerMod(int exponent, BigInteger mod)
        {
            var z = new BigInteger();
            mpz.powm(z, this, exponent, mod);
            return z;
        }

        /// <summary>
        /// Raises the current BigInteger instance to the power of the specified unsigned integer exponent modulo another BigInteger.
        /// </summary>
        /// <param name="exponent">The unsigned integer exponent to which to raise the current instance.</param>
        /// <param name="mod">The modulus to apply after exponentiation.</param>
        /// <returns>A BigInteger representing the result of raising the current instance to the specified power modulo mod.</returns>
        public BigInteger PowerMod(uint exponent, BigInteger mod)
        {
            var z = new BigInteger();
            if (exponent >= 0)
                mpz.powm_ui(z, this, exponent, mod);
            else
            {
                var bigExponent = (BigInteger)exponent;
                var inverse = bigExponent.InvertMod(mod);
                mpz.powm_ui(z, inverse, exponent, mod);
            }
            return z;
        }

        /// <summary>
        /// Computes the remainder when the current BigInteger instance is divided by another BigInteger.
        /// </summary>
        /// <param name="x">The BigInteger divisor.</param>
        /// <returns>A BigInteger representing the remainder.</returns>
        public BigInteger Remainder(BigInteger x)
        {
            var z = new BigInteger();
            mpz.tdiv_r(z, this, x);
            return z;
        }

        /// <summary>
        /// Removes all instances of a given factor from the current BigInteger instance.
        /// </summary>
        /// <param name="factor">The factor to remove.</param>
        /// <returns>A BigInteger representing the result after removing the factor.</returns>
        public BigInteger RemoveFactor(BigInteger factor)
        {
            var z = new BigInteger();
            mpz.remove(z, this, factor);
            return z;
        }

        /// <summary>
        /// Removes all instances of a given factor from the current BigInteger instance and outputs the count of times the factor was removed.
        /// </summary>
        /// <param name="factor">The factor to remove.</param>
        /// <param name="count">Outputs the count of times the factor was removed.</param>
        /// <returns>A BigInteger representing the result after removing the factor.</returns>
        public BigInteger RemoveFactor(BigInteger factor, out int count)
        {
            var z = new BigInteger();
            count = (int)mpz.remove(z, this, factor);
            return z;
        }

        /// <summary>
        /// Computes the nth root of the current BigInteger instance.
        /// </summary>
        /// <param name="n">The root to compute. Must be non-negative.</param>
        /// <returns>A BigInteger representing the nth root.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if n is negative.</exception>
        public BigInteger Root(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException();
            var z = new BigInteger();
            mpz.root(z, this, (uint)n);
            return z;
        }

        /// <summary>
        /// Computes the nth root of the current BigInteger instance.
        /// </summary>
        /// <param name="n">The root to compute.</param>
        /// <returns>A BigInteger representing the nth root.</returns>
        public BigInteger Root(uint n)
        {
            var z = new BigInteger();
            mpz.root(z, this, n);
            return z;
        }

        /// <summary>
        /// Computes the nth root of the current BigInteger instance and outputs whether the result is an exact root.
        /// </summary>
        /// <param name="n">The root to compute. Must be non-negative.</param>
        /// <param name="isExact">Outputs a boolean value indicating whether the result is an exact root.</param>
        /// <returns>A BigInteger representing the nth root.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if n is negative.</exception>
        public BigInteger Root(int n, out bool isExact)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException();
            var z = new BigInteger();
            isExact = mpz.root(z, this, (uint)n);
            return z;
        }

        /// <summary>
        /// Computes the nth root of the current BigInteger instance and outputs whether the result is an exact root.
        /// </summary>
        /// <param name="n">The root to compute.</param>
        /// <param name="isExact">Outputs a boolean value indicating whether the result is an exact root.</param>
        /// <returns>A BigInteger representing the nth root.</returns>
        public BigInteger Root(uint n, out bool isExact)
        {
            var z = new BigInteger();
            isExact = mpz.root(z, this, n);
            return z;
        }

        /// <summary>
        /// Computes the nth root of the current BigInteger instance and also outputs the remainder.
        /// </summary>
        /// <param name="n">The root to compute. Must be non-negative.</param>
        /// <param name="remainder">Outputs the remainder after computing the root.</param>
        /// <returns>A BigInteger representing the nth root.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if n is negative.</exception>
        public BigInteger Root(int n, out BigInteger remainder)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException();
            var z = new BigInteger();
            remainder = new BigInteger();
            mpz.rootrem(z, remainder, this, (uint)n);
            return z;
        }

        /// <summary>
        /// Computes the nth root of the current BigInteger instance and also outputs the remainder.
        /// </summary>
        /// <param name="n">The root to compute.</param>
        /// <param name="remainder">Outputs the remainder after computing the root.</param>
        /// <returns>A BigInteger representing the nth root.</returns>
        public BigInteger Root(uint n, out BigInteger remainder)
        {
            var z = new BigInteger();
            remainder = new BigInteger();
            mpz.rootrem(z, remainder, this, n);
            return z;
        }

        /// <summary>
        /// Shifts the current BigInteger instance to the left by a specified number of bits.
        /// </summary>
        /// <param name="shiftAmount">The number of bits to shift.</param>
        /// <returns>A BigInteger representing the result after the shift.</returns>
        public BigInteger ShiftLeft(int shiftAmount) => this << shiftAmount;

        /// <summary>
        /// Shifts the current BigInteger instance to the right by a specified number of bits.
        /// </summary>
        /// <param name="shiftAmount">The number of bits to shift.</param>
        /// <returns>A BigInteger representing the result after the shift.</returns>
        public BigInteger ShiftRight(int shiftAmount) => this >> shiftAmount;

        /// <summary>
        /// Computes the square root of the current BigInteger instance.
        /// </summary>
        /// <returns>A BigInteger representing the square root of the current instance.</returns>
        public BigInteger Sqrt()
        {
            var z = new BigInteger();
            mpz.sqrt(z, this);
            return z;
        }

        /// <summary>
        /// Computes the square root of the current BigInteger instance and outputs the remainder.
        /// </summary>
        /// <param name="remainder">Outputs the remainder after computing the square root.</param>
        /// <returns>A BigInteger representing the square root of the current instance.</returns>
        public BigInteger Sqrt(out BigInteger remainder)
        {
            var z = new BigInteger();
            remainder = new BigInteger();
            mpz.sqrtrem(z, remainder, this);
            return z;
        }

        /// <summary>
        /// Computes the square root of the current BigInteger instance and outputs whether the result is an exact square root.
        /// </summary>
        /// <param name="isExact">Outputs a boolean value indicating whether the result is an exact square root.</param>
        /// <returns>A BigInteger representing the square root of the current instance.</returns>
        public BigInteger Sqrt(out bool isExact)
        {
            var z = new BigInteger();
            isExact = mpz.root(z, this, 2u);
            return z;
        }

        /// <summary>
        /// Computes the square of the current BigInteger instance.
        /// </summary>
        /// <returns>A BigInteger representing the square of the current instance.</returns>
        public BigInteger Square() => this * this;

        /// <summary>
        /// Subtracts a BigInteger value from the current BigInteger instance.
        /// </summary>
        /// <param name="x">The BigInteger value to subtract.</param>
        /// <returns>A BigInteger representing the result of the subtraction.</returns>
        public BigInteger Subtract(BigInteger x) => this - x;

        /// <summary>
        /// Subtracts an integer value from the current BigInteger instance.
        /// </summary>
        /// <param name="x">The integer value to subtract.</param>
        /// <returns>A BigInteger representing the result of the subtraction.</returns>
        public BigInteger Subtract(int x) => this - x;

        /// <summary>
        /// Subtracts an unsigned integer value from the current BigInteger instance.
        /// </summary>
        /// <param name="x">The unsigned integer value to subtract.</param>
        /// <returns>A BigInteger representing the result of the subtraction.</returns>
        public BigInteger Subtract(uint x) => this - x;

        /// <summary>
        /// Performs a bitwise XOR operation between the current BigInteger instance and another BigInteger.
        /// </summary>
        /// <param name="x">The BigInteger value to XOR with the current instance.</param>
        /// <returns>A BigInteger representing the result of the bitwise XOR operation.</returns>
        public BigInteger Xor(BigInteger x) => this ^ x;

    }
}
