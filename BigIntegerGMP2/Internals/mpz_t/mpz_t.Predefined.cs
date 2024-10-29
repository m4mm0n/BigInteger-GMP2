namespace BigIntegerGMP2.Internals.mpz_t
{
    /// <summary>
    /// Arbitrary precision integer.
    /// </summary>
    public partial class mpz_t : IDisposable, IEquatable<mpz_t>, ICloneable, IConvertible, IComparable, IComparable<mpz_t>
    {
        /// <summary>
        /// Gets the value -10.
        /// </summary>
        public static mpz_t NegativeTen { get; } = new(-10);

        /// <summary>
        /// Gets the value -3.
        /// </summary>
        public static mpz_t NegativeThree { get; } = new(-3);

        /// <summary>
        /// Gets the value -2.
        /// </summary>
        public static mpz_t NegativeTwo { get; } = new(-2);

        /// <summary>
        /// Gets the value -1.
        /// </summary>
        public static mpz_t NegativeOne { get; } = new(-1);

        /// <summary>
        /// Gets the value 0.
        /// </summary>
        public static mpz_t Zero { get; } = new(0);

        /// <summary>
        /// Gets the value 1.
        /// </summary>
        public static mpz_t One { get; } = new(1);

        /// <summary>
        /// Gets the value 2.
        /// </summary>
        public static mpz_t Two { get; } = new(2);

        /// <summary>
        /// Gets the value 3.
        /// </summary>
        public static mpz_t Three { get; } = new(3);

        /// <summary>
        /// Gets the value 10.
        /// </summary>
        public static mpz_t Ten { get; } = new(10);
    }
}
