using BigIntegerGMP2;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start tests...");
            Console.ReadKey();
            Console.Clear();
            TestArithmeticOperations();

            TestLogicalOperators();
            TestConversions();
            TestComparisons();
            TestUtilityFunctions();
            TestRandomNumberGeneration();
            TestSpecializedMathFunctions();
            TestBitwiseOperations();
            TestMemoryManagement();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All tests completed.");
            Console.ResetColor();
            Console.ReadKey();
        }

        #region Tests
        private static void TestArithmeticOperations()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Testing Arithmetic Operations...");
            Console.ResetColor();

            var a = new BigInteger(12345);
            var b = new BigInteger(6789);

            // Addition
            var sum = a + b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{a} + {b} = {sum}");
            Console.ResetColor();

            // Subtraction
            var diff = a - b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{a} - {b} = {diff}");
            Console.ResetColor();

            // Multiplication
            var product = a * b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{a} * {b} = {product}");
            Console.ResetColor();

            // Division
            var quotient = a / b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{a} / {b} = {quotient}");
            Console.ResetColor();

            // Modulus
            var remainder = a % b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{a} % {b} = {remainder}");
            Console.ResetColor();
        }
        private static void TestLogicalOperators()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Testing Logical Operators...");
            Console.ResetColor();

            var a = new BigInteger(12345);
            var b = new BigInteger(6789);

            // Bitwise AND
            var andResult = a & b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{a} & {b} = {andResult}");
            Console.ResetColor();

            // Bitwise OR
            var orResult = a | b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{a} | {b} = {orResult}");
            Console.ResetColor();

            // Bitwise XOR
            var xorResult = a ^ b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{a} ^ {b} = {xorResult}");
            Console.ResetColor();

            // Bitwise NOT
            var notResult = ~a;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"~{a} = {notResult}");
            Console.ResetColor();
        }

        private static void TestConversions()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Testing Conversions...");
            Console.ResetColor();

            var a = new BigInteger(12345);

            // To Int32
            int intValue = a.ToInt32();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"BigInteger to Int32: {intValue}");
            Console.ResetColor();

            // To Byte Array
            var byteArray = a.ToByteArray();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"BigInteger to Byte Array: {BitConverter.ToString(byteArray)}");
            Console.ResetColor();

            // From String
            var fromString = new BigInteger("6789");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"BigInteger from string: {fromString}");
            Console.ResetColor();
        }

        private static void TestComparisons()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Testing Comparisons...");
            Console.ResetColor();

            var a = new BigInteger(12345);
            var b = new BigInteger(6789);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{a} > {b}: {a > b}");
            Console.WriteLine($"{a} < {b}: {a < b}");
            Console.WriteLine($"{a} == {b}: {a == b}");
            Console.WriteLine($"{a} != {b}: {a != b}");
            Console.ResetColor();
        }

        private static void TestUtilityFunctions()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Testing Utility Functions...");
            Console.ResetColor();

            var a = new BigInteger(12345);

            // Bit Length
            var bitLength = a.BitLength();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Bit length of {a}: {bitLength}");
            Console.ResetColor();

            // Base-64 Conversion
            var base64 = BigInteger.ConvertToBase64(a);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Base-64 representation of {a}: {base64}");
            Console.ResetColor();

            var fromBase64 = BigInteger.ConvertFromBase64(base64);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"BigInteger from Base-64: {fromBase64}");
            Console.ResetColor();
        }

        private static void TestRandomNumberGeneration()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Testing Random Number Generation...");
            Console.ResetColor();

            var randomBigInt = BigInteger.Random(128);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Random BigInteger with 128 bits: {randomBigInt}");
            Console.ResetColor();
        }

        private static void TestSpecializedMathFunctions()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Testing Specialized Math Functions...");
            Console.ResetColor();

            // Fibonacci
            var fib10 = BigInteger.Fibonacci(10);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"10th Fibonacci number: {fib10}");
            Console.ResetColor();

            // Lucas
            var lucas5 = BigInteger.Lucas(5);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"5th Lucas number: {lucas5}");
            Console.ResetColor();

            // Extended Euclidean
            var (gcd, x, y) = BigInteger.ExtendedEuclid(new BigInteger(252), new BigInteger(105));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Extended Euclid result: gcd={gcd}, x={x}, y={y}");
            Console.ResetColor();
        }

        private static void TestBitwiseOperations()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Testing Bitwise Operations...");
            Console.ResetColor();

            var a = new BigInteger(12345);
            var shiftedLeft = a << 2;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{a} << 2 = {shiftedLeft}");
            Console.ResetColor();

            var shiftedRight = a >> 2;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{a} >> 2 = {shiftedRight}");
            Console.ResetColor();
        }

        private static void TestMemoryManagement()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Testing Memory Management...");
            Console.ResetColor();

            var a = new BigInteger(12345);
            a.Dispose();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Disposed BigInteger instance.");
            Console.ResetColor();
        }

        #endregion
    }
}
