namespace BigIntegerGMP2.Internals
{
    /// <summary>
    /// Randomness algorithms.
    /// </summary>
    public enum RngAlgorithm
    {
        /// <summary>
        /// The default algorithm.
        /// </summary>
        Default,

        /// <summary>
        /// Mersenne Twister.
        /// </summary>
        MersenneTwister,

        /// <summary>
        /// Linear Congruential.
        /// </summary>
        LinearCongruential,
    }
}
