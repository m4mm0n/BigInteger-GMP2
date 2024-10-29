namespace BigIntegerGMP2.Internals.mpfr_t
{
    /// <summary>
    /// Represents an arbitrary precision floating-point number.
    /// </summary>
    public partial class mpfr_t : IDisposable
    {
        private void InitCacheManagement()
        {
            // ObjectCount.IsValueCreated is always set and ObjectCount.Value is initialized to 0
            ObjectCount.Value++;

            IsCacheInitialized = true;
        }

        private void DisposeCache()
        {
            ObjectCount.Value--;

            if (ObjectCount.Value == 0)
            {
                mpfr.mpfr.free_cache();
                mpfr.mpfr.free_cache2(0);
                mpfr.mpfr.free_pool();
                mpfr.mpfr.mp_memory_cleanup();
            }
        }

        private static ThreadLocal<ulong> ObjectCount = new ThreadLocal<ulong>();

        /// <summary>
        /// Returns the number of living items in cache.
        /// </summary>
        public static ulong LiveObjectCount() => ObjectCount.Value;

        /// <summary>
        /// Gets a value indicating whether the cache is initialized.
        /// </summary>
        public bool IsCacheInitialized { get; private set; }
    }
}
