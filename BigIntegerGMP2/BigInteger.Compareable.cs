using BigIntegerGMP2.Internals.mpir;
using BigIntegerGMP2.Internals.mpz_t;

namespace BigIntegerGMP2
{
    public partial class BigInteger : IDisposable, ICloneable, IComparable<BigInteger>
    {
        /// <summary>
        /// Compares the current BigInteger instance to another object.
        /// </summary>
        /// <param name="obj">The object to compare with the current BigInteger.</param>
        /// <returns>An integer that indicates the relative order of the objects being compared.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the object is null.</exception>
        /// <exception cref="ArgumentException">Thrown if the object is not a valid type for comparison.</exception>
        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            var objAsBigInt = obj as BigInteger;
            return ReferenceEquals(objAsBigInt, null)
                ? obj switch
                {
                    int i => CompareTo(i),
                    uint u => CompareTo(u),
                    long l => CompareTo(l),
                    ulong @ulong => CompareTo(@ulong),
                    double d => CompareTo(d),
                    float f => CompareTo(f),
                    short s => CompareTo(s),
                    ushort @ushort => CompareTo(@ushort),
                    byte b => CompareTo(b),
                    sbyte @sbyte => CompareTo(@sbyte),
                    string s => CompareTo(new BigInteger(s)),
                    _ => throw new ArgumentException("Cannot compare to " + obj.GetType())
                }
                : CompareTo(objAsBigInt);
        }

        /// <summary>
        /// Compares the current BigInteger instance to another BigInteger.
        /// </summary>
        /// <param name="other">The BigInteger to compare with.</param>
        /// <returns>An integer that indicates the relative order of the current instance and the other BigInteger.</returns>
        public int CompareTo(BigInteger? other) => mpz.cmp(_value, other?._value);

        /// <summary>
        /// Compares the current BigInteger instance to an integer value.
        /// </summary>
        /// <param name="other">The integer value to compare with.</param>
        /// <returns>An integer that indicates the relative order of the current instance and the integer value.</returns>
        public int CompareTo(int other) => mpz.cmp_si(_value, other);

        /// <summary>
        /// Compares the current BigInteger instance to an unsigned integer value.
        /// </summary>
        /// <param name="other">The unsigned integer value to compare with.</param>
        /// <returns>An integer that indicates the relative order of the current instance and the unsigned integer value.</returns>
        public int CompareTo(uint other) => mpz.cmp_ui(_value, other);

        /// <summary>
        /// Compares the current BigInteger instance to a long value.
        /// </summary>
        /// <param name="other">The long value to compare with.</param>
        /// <returns>An integer that indicates the relative order of the current instance and the long value.</returns>
        public int CompareTo(long other) => mpz.cmp_si(_value, other);

        /// <summary>
        /// Compares the current BigInteger instance to an unsigned long value.
        /// </summary>
        /// <param name="other">The unsigned long value to compare with.</param>
        /// <returns>An integer that indicates the relative order of the current instance and the unsigned long value.</returns>
        public int CompareTo(ulong other) => mpz.cmp_ui(_value, other);

        /// <summary>
        /// Compares the current BigInteger instance to a double value.
        /// </summary>
        /// <param name="other">The double value to compare with.</param>
        /// <returns>An integer that indicates the relative order of the current instance and the double value.</returns>
        public int CompareTo(double other) => mpz.cmp_d(_value, other);

        /// <summary>
        /// Compares the current BigInteger instance to a float value.
        /// </summary>
        /// <param name="other">The float value to compare with.</param>
        /// <returns>An integer that indicates the relative order of the current instance and the float value.</returns>
        public int CompareTo(float other) => mpz.cmp_d(_value, other);


        /// <summary>
        /// Determines whether the specified object is equal to the current BigInteger instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current BigInteger.</param>
        /// <returns>True if the specified object is equal to the current instance; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the object is null.</exception>
        public override bool Equals(object obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            if (ReferenceEquals(obj, null))
                return false;
            var objAsBigInt = obj as BigInteger;
            return ReferenceEquals(objAsBigInt, null)
                ? obj switch
                {
                    int i => this == i,
                    uint u => this == u,
                    long l => this == l,
                    ulong @ulong => this == @ulong,
                    double d => this == d,
                    float f => this == f,
                    short s => this == s,
                    ushort @ushort => this == @ushort,
                    byte b => this == b,
                    sbyte @sbyte => this == @sbyte,
                    _ => false
                }
                : CompareTo(objAsBigInt) == 0;
        }

        /// <summary>
        /// Determines whether the current BigInteger instance is equal to the specified integer value.
        /// </summary>
        /// <param name="other">The integer value to compare with.</param>
        /// <returns>True if the integer value is equal to the current instance; otherwise, false.</returns>
        public bool Equals(int other) => CompareTo(other) == 0;

        /// <summary>
        /// Determines whether the current BigInteger instance is equal to the specified unsigned integer value.
        /// </summary>
        /// <param name="other">The unsigned integer value to compare with.</param>
        /// <returns>True if the unsigned integer value is equal to the current instance; otherwise, false.</returns>
        public bool Equals(uint other) => CompareTo(other) == 0;

        /// <summary>
        /// Determines whether the current BigInteger instance is equal to the specified long value.
        /// </summary>
        /// <param name="other">The long value to compare with.</param>
        /// <returns>True if the long value is equal to the current instance; otherwise, false.</returns>
        public bool Equals(long other) => CompareTo(other) == 0;

        /// <summary>
        /// Determines whether the current BigInteger instance is equal to the specified unsigned long value.
        /// </summary>
        /// <param name="other">The unsigned long value to compare with.</param>
        /// <returns>True if the unsigned long value is equal to the current instance; otherwise, false.</returns>
        public bool Equals(ulong other) => CompareTo(other) == 0;

        /// <summary>
        /// Determines whether the current BigInteger instance is equal to the specified double value.
        /// </summary>
        /// <param name="other">The double value to compare with.</param>
        /// <returns>True if the double value is equal to the current instance; otherwise, false.</returns>
        public bool Equals(double other) => CompareTo(other) == 0;

        /// <summary>
        /// Determines whether the current BigInteger instance is equal to the specified float value.
        /// </summary>
        /// <param name="other">The float value to compare with.</param>
        /// <returns>True if the float value is equal to the current instance; otherwise, false.</returns>
        public bool Equals(float other) => CompareTo(other) == 0;


        /// <summary>
        /// Compares a BigInteger instance with another object.
        /// </summary>
        /// <param name="x">The BigInteger to compare.</param>
        /// <param name="y">The object to compare with.</param>
        /// <returns>An integer indicating the relative order of the BigInteger and the object being compared.</returns>
        public static int Compare(BigInteger x, object y) => x.CompareTo(y);

        /// <summary>
        /// Compares an object with a BigInteger instance.
        /// </summary>
        /// <param name="x">The object to compare.</param>
        /// <param name="y">The BigInteger to compare with.</param>
        /// <returns>An integer indicating the relative order of the object and the BigInteger being compared.</returns>
        public static int Compare(object x, BigInteger y) => -y.CompareTo(x);

        /// <summary>
        /// Compares two BigInteger instances.
        /// </summary>
        /// <param name="x">The first BigInteger to compare.</param>
        /// <param name="y">The second BigInteger to compare with.</param>
        /// <returns>An integer indicating the relative order of the two BigIntegers.</returns>
        public static int Compare(BigInteger x, BigInteger y) => x.CompareTo(y);

        /// <summary>
        /// Compares a BigInteger instance with an integer value.
        /// </summary>
        /// <param name="x">The BigInteger to compare.</param>
        /// <param name="y">The integer value to compare with.</param>
        /// <returns>An integer indicating the relative order of the BigInteger and the integer.</returns>
        public static int Compare(BigInteger x, int y) => x.CompareTo(y);

        /// <summary>
        /// Compares an integer value with a BigInteger instance.
        /// </summary>
        /// <param name="x">The integer value to compare.</param>
        /// <param name="y">The BigInteger to compare with.</param>
        /// <returns>An integer indicating the relative order of the integer and the BigInteger.</returns>
        public static int Compare(int x, BigInteger y) => -y.CompareTo(x);

        /// <summary>
        /// Compares a BigInteger instance with an unsigned integer value.
        /// </summary>
        /// <param name="x">The BigInteger to compare.</param>
        /// <param name="y">The unsigned integer value to compare with.</param>
        /// <returns>An integer indicating the relative order of the BigInteger and the unsigned integer.</returns>
        public static int Compare(BigInteger x, uint y) => x.CompareTo(y);

        /// <summary>
        /// Compares an unsigned integer value with a BigInteger instance.
        /// </summary>
        /// <param name="x">The unsigned integer value to compare.</param>
        /// <param name="y">The BigInteger to compare with.</param>
        /// <returns>An integer indicating the relative order of the unsigned integer and the BigInteger.</returns>
        public static int Compare(uint x, BigInteger y) => -y.CompareTo(x);

        /// <summary>
        /// Compares a BigInteger instance with a long value.
        /// </summary>
        /// <param name="x">The BigInteger to compare.</param>
        /// <param name="y">The long value to compare with.</param>
        /// <returns>An integer indicating the relative order of the BigInteger and the long value.</returns>
        public static int Compare(BigInteger x, long y) => x.CompareTo(y);

        /// <summary>
        /// Compares a long value with a BigInteger instance.
        /// </summary>
        /// <param name="x">The long value to compare.</param>
        /// <param name="y">The BigInteger to compare with.</param>
        /// <returns>An integer indicating the relative order of the long value and the BigInteger.</returns>
        public static int Compare(long x, BigInteger y) => -y.CompareTo(x);

        /// <summary>
        /// Compares a BigInteger instance with an unsigned long value.
        /// </summary>
        /// <param name="x">The BigInteger to compare.</param>
        /// <param name="y">The unsigned long value to compare with.</param>
        /// <returns>An integer indicating the relative order of the BigInteger and the unsigned long value.</returns>
        public static int Compare(BigInteger x, ulong y) => x.CompareTo(y);

        /// <summary>
        /// Compares an unsigned long value with a BigInteger instance.
        /// </summary>
        /// <param name="x">The unsigned long value to compare.</param>
        /// <param name="y">The BigInteger to compare with.</param>
        /// <returns>An integer indicating the relative order of the unsigned long value and the BigInteger.</returns>
        public static int Compare(ulong x, BigInteger y) => -y.CompareTo(x);

        /// <summary>
        /// Compares a BigInteger instance with a double value.
        /// </summary>
        /// <param name="x">The BigInteger to compare.</param>
        /// <param name="y">The double value to compare with.</param>
        /// <returns>An integer indicating the relative order of the BigInteger and the double value.</returns>
        public static int Compare(BigInteger x, double y) => x.CompareTo(y);

        /// <summary>
        /// Compares a double value with a BigInteger instance.
        /// </summary>
        /// <param name="x">The double value to compare.</param>
        /// <param name="y">The BigInteger to compare with.</param>
        /// <returns>An integer indicating the relative order of the double value and the BigInteger.</returns>
        public static int Compare(double x, BigInteger y) => -y.CompareTo(x);

        /// <summary>
        /// Compares the absolute value of a BigInteger instance with another object.
        /// </summary>
        /// <param name="x">The BigInteger whose absolute value to compare.</param>
        /// <param name="y">The object to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute value of the BigInteger and the object.</returns>
        public static int CompareAbs(BigInteger x, object y) => x.CompareAbsTo(y);

        /// <summary>
        /// Compares the absolute value of an object with a BigInteger instance.
        /// </summary>
        /// <param name="x">The object to compare.</param>
        /// <param name="y">The BigInteger whose absolute value to compare with.</param>
        /// <returns>An integer indicating the relative order of the object and the absolute value of the BigInteger.</returns>
        public static int CompareAbs(object x, BigInteger y) => -y.CompareAbsTo(x);

        /// <summary>
        /// Compares the absolute values of two BigInteger instances.
        /// </summary>
        /// <param name="x">The first BigInteger whose absolute value to compare.</param>
        /// <param name="y">The second BigInteger whose absolute value to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute values of the two BigIntegers.</returns>
        public static int CompareAbs(BigInteger x, BigInteger y) => x.CompareAbsTo(y);

        /// <summary>
        /// Compares the absolute value of a BigInteger instance with an integer value.
        /// </summary>
        /// <param name="x">The BigInteger whose absolute value to compare.</param>
        /// <param name="y">The integer value to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute value of the BigInteger and the integer.</returns>
        public static int CompareAbs(BigInteger x, int y) => x.CompareAbsTo(y);

        /// <summary>
        /// Compares the absolute value of an integer with a BigInteger instance.
        /// </summary>
        /// <param name="x">The integer value to compare.</param>
        /// <param name="y">The BigInteger whose absolute value to compare with.</param>
        /// <returns>An integer indicating the relative order of the integer and the absolute value of the BigInteger.</returns>
        public static int CompareAbs(int x, BigInteger y) => -y.CompareAbsTo(x);

        /// <summary>
        /// Compares the absolute value of a BigInteger instance with an unsigned integer value.
        /// </summary>
        /// <param name="x">The BigInteger whose absolute value to compare.</param>
        /// <param name="y">The unsigned integer value to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute value of the BigInteger and the unsigned integer.</returns>
        public static int CompareAbs(BigInteger x, uint y) => x.CompareAbsTo(y);

        /// <summary>
        /// Compares the absolute value of an unsigned integer with a BigInteger instance.
        /// </summary>
        /// <param name="x">The unsigned integer value to compare.</param>
        /// <param name="y">The BigInteger whose absolute value to compare with.</param>
        /// <returns>An integer indicating the relative order of the unsigned integer and the absolute value of the BigInteger.</returns>
        public static int CompareAbs(uint x, BigInteger y) => -y.CompareAbsTo(x);

        /// <summary>
        /// Compares the absolute value of a BigInteger instance with a long value.
        /// </summary>
        /// <param name="x">The BigInteger whose absolute value to compare.</param>
        /// <param name="y">The long value to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute value of the BigInteger and the long value.</returns>
        public static int CompareAbs(BigInteger x, long y) => x.CompareAbsTo(y);

        /// <summary>
        /// Compares the absolute value of a long value with a BigInteger instance.
        /// </summary>
        /// <param name="x">The long value to compare.</param>
        /// <param name="y">The BigInteger whose absolute value to compare with.</param>
        /// <returns>An integer indicating the relative order of the long value and the absolute value of the BigInteger.</returns>
        public static int CompareAbs(long x, BigInteger y) => -y.CompareAbsTo(x);

        /// <summary>
        /// Compares the absolute value of a BigInteger instance with an unsigned long value.
        /// </summary>
        /// <param name="x">The BigInteger whose absolute value to compare.</param>
        /// <param name="y">The unsigned long value to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute value of the BigInteger and the unsigned long value.</returns>
        public static int CompareAbs(BigInteger x, ulong y) => x.CompareAbsTo(y);

        /// <summary>
        /// Compares the absolute value of an unsigned long value with a BigInteger instance.
        /// </summary>
        /// <param name="x">The unsigned long value to compare.</param>
        /// <param name="y">The BigInteger whose absolute value to compare with.</param>
        /// <returns>An integer indicating the relative order of the unsigned long value and the absolute value of the BigInteger.</returns>
        public static int CompareAbs(ulong x, BigInteger y) => -y.CompareAbsTo(x);

        /// <summary>
        /// Compares the absolute value of a BigInteger instance with a double value.
        /// </summary>
        /// <param name="x">The BigInteger whose absolute value to compare.</param>
        /// <param name="y">The double value to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute value of the BigInteger and the double value.</returns>
        public static int CompareAbs(BigInteger x, double y) => x.CompareAbsTo(y);

        /// <summary>
        /// Compares the absolute value of a double value with a BigInteger instance.
        /// </summary>
        /// <param name="x">The double value to compare.</param>
        /// <param name="y">The BigInteger whose absolute value to compare with.</param>
        /// <returns>An integer indicating the relative order of the double value and the absolute value of the BigInteger.</returns>
        public static int CompareAbs(double x, BigInteger y) => -y.CompareAbsTo(x);

        /// <summary>
        /// Compares the absolute value of the current BigInteger instance with another object.
        /// </summary>
        /// <param name="obj">The object to compare with the absolute value of the current BigInteger instance.</param>
        /// <returns>An integer indicating the relative order of the absolute value of the current instance and the object being compared.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the object is null.</exception>
        /// <exception cref="ArgumentException">Thrown if the object is not a type that can be compared to a BigInteger.</exception>
        public int CompareAbsTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            var objAsBigInt = obj as BigInteger;
            return ReferenceEquals(objAsBigInt, null)
                ? obj switch
                {
                    int i => CompareAbsTo(i),
                    uint u => CompareAbsTo(u),
                    long l => CompareAbsTo(l),
                    ulong @ulong => CompareAbsTo(@ulong),
                    double d => CompareAbsTo(d),
                    float f => CompareAbsTo(f),
                    short s => CompareAbsTo(s),
                    ushort @ushort => CompareAbsTo(@ushort),
                    byte b => CompareAbsTo(b),
                    sbyte @sbyte => CompareAbsTo(@sbyte),
                    string s => CompareAbsTo(new mpz_t(s)),
                    _ => throw new ArgumentException("Cannot compare to " + obj.GetType())
                }
                : CompareAbsTo(objAsBigInt);
        }

        /// <summary>
        /// Compares the absolute value of the current BigInteger instance with another BigInteger.
        /// </summary>
        /// <param name="other">The other BigInteger to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute values of the current instance and the other BigInteger.</returns>
        public int CompareAbsTo(BigInteger other) => mpz.cmpabs(this, other);

        /// <summary>
        /// Compares the absolute value of the current BigInteger instance with an integer value.
        /// </summary>
        /// <param name="other">The integer value to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute value of the current instance and the integer.</returns>
        public int CompareAbsTo(int other) => mpz.cmpabs_ui(this, (uint)other);

        /// <summary>
        /// Compares the absolute value of the current BigInteger instance with an unsigned integer value.
        /// </summary>
        /// <param name="other">The unsigned integer value to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute value of the current instance and the unsigned integer.</returns>
        public int CompareAbsTo(uint other) => mpz.cmpabs_ui(this, other);

        /// <summary>
        /// Compares the absolute value of the current BigInteger instance with a long value.
        /// </summary>
        /// <param name="other">The long value to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute value of the current instance and the long value.</returns>
        public int CompareAbsTo(long other) => CompareAbsTo((mpz_t)other);

        /// <summary>
        /// Compares the absolute value of the current BigInteger instance with an unsigned long value.
        /// </summary>
        /// <param name="other">The unsigned long value to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute value of the current instance and the unsigned long value.</returns>
        public int CompareAbsTo(ulong other) => CompareAbsTo((mpz_t)other);

        /// <summary>
        /// Compares the absolute value of the current BigInteger instance with a double value.
        /// </summary>
        /// <param name="other">The double value to compare with.</param>
        /// <returns>An integer indicating the relative order of the absolute value of the current instance and the double value.</returns>
        public int CompareAbsTo(double other) => mpz.cmpabs_d(this, other);
    }
}
