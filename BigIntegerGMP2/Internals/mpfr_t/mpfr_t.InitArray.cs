using System.Diagnostics;
using static BigIntegerGMP2.Native.Mpfr.NativeMethods;

namespace BigIntegerGMP2.Internals.mpfr_t
{
    /// <summary>
    /// Represents an arbitrary precision floating-point number.
    /// </summary>
    public partial class mpfr_t : IDisposable
    {
        private const int MaxArrayLength = 32;

        private static void ProcessArray(mpfr_t[] numbers, Action<nint[]> action)
        {
            var Args = new nint[MaxArrayLength];

            FillArray(Args, numbers, 0, action);
        }

        private static void FillArray(nint[] args, mpfr_t[] numbers, int index, Action<nint[]> action)
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
                    fixed (__mpfr_t* ValueAddress = &numbers[index].Value)
                    {
                        args[index] = (nint)ValueAddress;
                        FillArray(args, numbers, index + 1, action);
                    }
                }
            }
        }
    }
}
