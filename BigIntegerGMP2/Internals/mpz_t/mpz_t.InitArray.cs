using System.Diagnostics;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Internals.mpz_t
{
    /// <summary>
    /// Arbitrary precision integer.
    /// </summary>
    public partial class mpz_t : IDisposable, IEquatable<mpz_t>, ICloneable, IConvertible, IComparable, IComparable<mpz_t>
    {
        private const int MaxArrayLength = 32;

        private static void ProcessArray(mpz_t[] numbers, Action<nint[]> action)
        {
            var Args = new nint[MaxArrayLength];

            FillArray(Args, numbers, 0, action);
        }

        private static void FillArray(nint[] args, mpz_t[] numbers, int index, Action<nint[]> action)
        {
            Debug.Assert(index < MaxArrayLength);

            if (index >= numbers.Length)
            {
                for (var i = index; i < MaxArrayLength; i++)
                    args[i] = nint.Zero;

                action(args);
            }
            else
            {
                unsafe
                {
                    fixed (__mpz_t* ValueAddress = &numbers[index].Value)
                    {
                        args[index] = (nint)ValueAddress;
                        FillArray(args, numbers, index + 1, action);
                    }
                }
            }
        }
    }
}
