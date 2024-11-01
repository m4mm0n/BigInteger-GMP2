using BigIntegerGMP2.Internals.mpir;
using BigIntegerGMP2.Internals.mpz_t;

namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        /// <summary>
        /// Computes the Jacobi symbol (x/y), which is a generalization of the Legendre symbol.
        /// </summary>
        /// <param name="x">The numerator BigInteger.</param>
        /// <param name="y">The denominator BigInteger.</param>
        /// <returns>The value of the Jacobi symbol (x/y).</returns>
        public static int JacobiSymbol(BigInteger x, BigInteger y) => mpz.jacobi(x, y);

        /// <summary>
        /// Computes the Jacobi symbol (x/y), where y is an integer.
        /// </summary>
        /// <param name="x">The numerator BigInteger.</param>
        /// <param name="y">The denominator integer.</param>
        /// <returns>The value of the Jacobi symbol (x/y).</returns>
        /// <exception cref="ArgumentException">Thrown if y is even or negative.</exception>
        public static int JacobiSymbol(BigInteger x, int y) => (y & 1) == 0 || y < 0 ? throw new ArgumentException() : mpz.kronecker_si(x, y);

        /// <summary>
        /// Computes the Jacobi symbol (x/y), where x is an integer and y is a BigInteger.
        /// </summary>
        /// <param name="x">The numerator integer.</param>
        /// <param name="y">The denominator BigInteger.</param>
        /// <returns>The value of the Jacobi symbol (x/y).</returns>
        public static int JacobiSymbol(int x, BigInteger y) => mpz.si_kronecker(x, y);

        /// <summary>
        /// Computes the Jacobi symbol (x/y), where y is an unsigned integer.
        /// </summary>
        /// <param name="x">The numerator BigInteger.</param>
        /// <param name="y">The denominator unsigned integer.</param>
        /// <returns>The value of the Jacobi symbol (x/y).</returns>
        /// <exception cref="ArgumentException">Thrown if y is even.</exception>
        public static int JacobiSymbol(BigInteger x, uint y) => (y & 1) == 0 ? throw new ArgumentException() : mpz.kronecker_ui(x, y);

        /// <summary>
        /// Computes the Jacobi symbol (x/y), where x is an unsigned integer and y is a BigInteger.
        /// </summary>
        /// <param name="x">The numerator unsigned integer.</param>
        /// <param name="y">The denominator BigInteger.</param>
        /// <returns>The value of the Jacobi symbol (x/y).</returns>
        public static int JacobiSymbol(uint x, BigInteger y) => mpz.ui_kronecker(x, y);

        /// <summary>
        /// Computes the Kronecker symbol (x/y), which is a generalization of the Jacobi symbol.
        /// </summary>
        /// <param name="x">The numerator BigInteger.</param>
        /// <param name="y">The denominator BigInteger.</param>
        /// <returns>The value of the Kronecker symbol (x/y).</returns>
        public static int KroneckerSymbol(BigInteger x, BigInteger y) => mpz.kronecker(x, y);

        /// <summary>
        /// Computes the Kronecker symbol (x/y), where y is an integer.
        /// </summary>
        /// <param name="x">The numerator BigInteger.</param>
        /// <param name="y">The denominator integer.</param>
        /// <returns>The value of the Kronecker symbol (x/y).</returns>
        public static int KroneckerSymbol(BigInteger x, int y) => mpz.kronecker_si(x, y);

        /// <summary>
        /// Computes the Kronecker symbol (x/y), where x is an integer and y is a BigInteger.
        /// </summary>
        /// <param name="x">The numerator integer.</param>
        /// <param name="y">The denominator BigInteger.</param>
        /// <returns>The value of the Kronecker symbol (x/y).</returns>
        public static int KroneckerSymbol(int x, BigInteger y) => mpz.si_kronecker(x, y);

        /// <summary>
        /// Computes the Kronecker symbol (x/y), where y is an unsigned integer.
        /// </summary>
        /// <param name="x">The numerator BigInteger.</param>
        /// <param name="y">The denominator unsigned integer.</param>
        /// <returns>The value of the Kronecker symbol (x/y).</returns>
        public static int KroneckerSymbol(BigInteger x, uint y) => mpz.kronecker_ui(x, y);

        /// <summary>
        /// Computes the Kronecker symbol (x/y), where x is an unsigned integer and y is a BigInteger.
        /// </summary>
        /// <param name="x">The numerator unsigned integer.</param>
        /// <param name="y">The denominator BigInteger.</param>
        /// <returns>The value of the Kronecker symbol (x/y).</returns>
        public static int KroneckerSymbol(uint x, BigInteger y) => mpz.ui_kronecker(x, y);

        /// <summary>
        /// Computes the least common multiple (LCM) of two BigInteger values.
        /// </summary>
        /// <param name="x">The first BigInteger value.</param>
        /// <param name="y">The second BigInteger value.</param>
        /// <returns>A BigInteger representing the LCM of the two values.</returns>
        public static BigInteger Lcm(BigInteger x, BigInteger y)
        {
            var z = new mpz_t();
            mpz.lcm(z, x, y);
            return new BigInteger(z);
        }

        /// <summary>
        /// Computes the least common multiple (LCM) of a BigInteger value and an integer.
        /// </summary>
        /// <param name="x">The BigInteger value.</param>
        /// <param name="y">The integer value.</param>
        /// <returns>A BigInteger representing the LCM of the two values.</returns>
        public static BigInteger Lcm(BigInteger x, int y)
        {
            var z = new mpz_t();
            if (y >= 0)
                mpz.lcm_ui(z, x, (uint)y);
            else
                mpz.lcm_ui(z, x, (uint)(-y));
            return new BigInteger(z);
        }

        /// <summary>
        /// Computes the least common multiple (LCM) of an integer and a BigInteger value.
        /// </summary>
        /// <param name="x">The integer value.</param>
        /// <param name="y">The BigInteger value.</param>
        /// <returns>A BigInteger representing the LCM of the two values.</returns>
        public static BigInteger Lcm(int x, BigInteger y)
        {
            var z = new mpz_t();
            if (x >= 0)
                mpz.lcm_ui(z, y, (uint)x);
            else
                mpz.lcm_ui(z, y, (uint)(-x));
            return new BigInteger(z);
        }

        /// <summary>
        /// Computes the least common multiple (LCM) of a BigInteger value and an unsigned integer.
        /// </summary>
        /// <param name="x">The BigInteger value.</param>
        /// <param name="y">The unsigned integer value.</param>
        /// <returns>A BigInteger representing the LCM of the two values.</returns>
        public static BigInteger Lcm(BigInteger x, uint y)
        {
            var z = new mpz_t();
            mpz.lcm_ui(z, x, y);
            return new BigInteger(z);
        }

        /// <summary>
        /// Computes the least common multiple (LCM) of an unsigned integer and a BigInteger value.
        /// </summary>
        /// <param name="x">The unsigned integer value.</param>
        /// <param name="y">The BigInteger value.</param>
        /// <returns>A BigInteger representing the LCM of the two values.</returns>
        public static BigInteger Lcm(uint x, BigInteger y)
        {
            var z = new mpz_t();
            mpz.lcm_ui(z, y, x);
            return new BigInteger(z);
        }

        /// <summary>
        /// Computes the Legendre symbol (x/primeY), which is used to determine whether x is a quadratic residue modulo primeY.
        /// </summary>
        /// <param name="x">The numerator BigInteger.</param>
        /// <param name="primeY">The prime denominator BigInteger.</param>
        /// <returns>The value of the Legendre symbol (x/primeY).</returns>
        public static int LegendreSymbol(BigInteger x, BigInteger primeY) => mpz.jacobi(x, primeY);

        /// <summary>
        /// Computes the n-th Lucas number.
        /// </summary>
        /// <param name="n">The index of the Lucas number to compute. Must be non-negative.</param>
        /// <returns>A BigInteger representing the n-th Lucas number.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if n is negative.</exception>
        public static BigInteger Lucas(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException();
            var z = new mpz_t();
            mpz.lucnum_ui(z, (uint)n);
            return new BigInteger(z);
        }

        /// <summary>
        /// Computes the n-th Lucas number.
        /// </summary>
        /// <param name="n">The index of the Lucas number to compute.</param>
        /// <returns>A BigInteger representing the n-th Lucas number.</returns>
        public static BigInteger Lucas(uint n)
        {
            var z = new mpz_t();
            mpz.lucnum_ui(z, n);
            return new BigInteger(z);
        }

        /// <summary>
        /// Computes the n-th Lucas number and the (n-1)-th Lucas number.
        /// </summary>
        /// <param name="n">The index of the Lucas number to compute. Must be non-negative.</param>
        /// <param name="previous">Outputs the (n-1)-th Lucas number.</param>
        /// <returns>A BigInteger representing the n-th Lucas number.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if n is negative.</exception>
        public static BigInteger Lucas(int n, out BigInteger previous)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException();
            var z = new mpz_t();
            previous = new BigInteger();
            mpz.lucnum2_ui(z, previous, (uint)n);
            return new BigInteger(z);
        }

        /// <summary>
        /// Computes the n-th Lucas number and the (n-1)-th Lucas number.
        /// </summary>
        /// <param name="n">The index of the Lucas number to compute.</param>
        /// <param name="previous">Outputs the (n-1)-th Lucas number.</param>
        /// <returns>A BigInteger representing the n-th Lucas number.</returns>
        public static BigInteger Lucas(uint n, out BigInteger previous)
        {
            var z = new mpz_t();
            previous = new BigInteger();
            mpz.lucnum2_ui(z, previous, n);
            return new BigInteger(z);
        }

        /// <summary>
        /// Computes the Fibonacci number for a specified non-negative integer.
        /// </summary>
        /// <param name="n">The integer value for which to compute the Fibonacci number.</param>
        /// <returns>A BigInteger representing the nth Fibonacci number.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if n is negative.</exception>
        public static BigInteger Fibonacci(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException();
            var z = new BigInteger();
            mpz.fib_ui(z, (uint)n);
            return z;
        }

        /// <summary>
        /// Computes the Fibonacci number for a specified unsigned integer.
        /// </summary>
        /// <param name="n">The unsigned integer value for which to compute the Fibonacci number.</param>
        /// <returns>A BigInteger representing the nth Fibonacci number.</returns>
        public static BigInteger Fibonacci(uint n)
        {
            var z = new BigInteger();
            mpz.fib_ui(z, n);
            return z;
        }

        /// <summary>
        /// Computes the Fibonacci number for a specified non-negative integer and also outputs the previous Fibonacci number.
        /// </summary>
        /// <param name="n">The integer value for which to compute the Fibonacci number.</param>
        /// <param name="previous">Outputs the (n-1)th Fibonacci number.</param>
        /// <returns>A BigInteger representing the nth Fibonacci number.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if n is negative.</exception>
        public static BigInteger Fibonacci(int n, out BigInteger previous)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException();
            var z = new BigInteger();
            previous = new BigInteger();
            mpz.fib2_ui(z, previous, (uint)n);
            return z;
        }

        /// <summary>
        /// Computes the Fibonacci number for a specified unsigned integer and also outputs the previous Fibonacci number.
        /// </summary>
        /// <param name="n">The unsigned integer value for which to compute the Fibonacci number.</param>
        /// <param name="previous">Outputs the (n-1)th Fibonacci number.</param>
        /// <returns>A BigInteger representing the nth Fibonacci number.</returns>
        public static BigInteger Fibonacci(uint n, out BigInteger previous)
        {
            var z = new BigInteger();
            previous = new BigInteger();
            mpz.fib2_ui(z, previous, n);
            return z;
        }
        /// <summary>
        /// Computes the Hamming distance between two BigInteger values.
        /// </summary>
        /// <param name="x">The first BigInteger value.</param>
        /// <param name="y">The second BigInteger value.</param>
        /// <returns>An integer representing the Hamming distance between x and y.</returns>
        public int HammingDistance(BigInteger x, BigInteger y) => (int)mpz.hamdist(x, y);
    }
}
