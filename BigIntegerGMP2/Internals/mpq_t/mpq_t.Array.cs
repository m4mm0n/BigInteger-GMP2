using System.Diagnostics;
using static BigIntegerGMP2.Native.Mpir.NativeMethods;

namespace BigIntegerGMP2.Internals.mpq_t
{
    /// <summary>
    /// Arbitrary precision rational number.
    /// </summary>
    public partial class mpq_t : IDisposable, IEquatable<mpq_t>, ICloneable, IConvertible, IComparable, IComparable<mpq_t>
    {
        private const int MaxArrayLength = 32;

        private static void ProcessArray(mpq_t[] numbers, Action<nint[]> action)
        {
            var Args = new nint[MaxArrayLength];

            FillArray(Args, numbers, 0, action);
        }

        private static void FillArray(nint[] args, mpq_t[] numbers, int index, Action<nint[]> action)
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
                    fixed (__mpq_t* ValueAddress = &numbers[index].Value)
                    {
                        args[index] = (nint)ValueAddress;
                        FillArray(args, numbers, index + 1, action);
                    }
                }
            }
        }
    }
}
