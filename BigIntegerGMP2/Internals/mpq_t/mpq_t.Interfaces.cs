using BigIntegerGMP2.Internals.mpir;

namespace BigIntegerGMP2.Internals.mpq_t
{
    /// <summary>
    /// Arbitrary precision rational number.
    /// </summary>
    public partial class mpq_t : IDisposable, IEquatable<mpq_t>, ICloneable, IConvertible, IComparable, IComparable<mpq_t>
    {
        #region Implementation of IDisposable
        /// <summary>
        /// Called when an object should release its resources.
        /// </summary>
        /// <param name="isDisposing">Indicates if resources must be disposed now.</param>
        protected virtual void Dispose(bool isDisposing)
        {
            if (!IsDisposed)
            {
                IsDisposed = true;

                if (isDisposing)
                    DisposeNow();
            }
        }

        /// <summary>
        /// Called when an object should release its resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="mpq_t"/> class.
        /// </summary>
        ~mpq_t()
        {
            Dispose(false);
        }

        /// <summary>
        /// True after <see cref="Dispose(bool)"/> has been invoked.
        /// </summary>
        private bool IsDisposed;

        /// <summary>
        /// Disposes of every reference that must be cleaned up.
        /// </summary>
        private void DisposeNow()
        {
            mpq.clear(this);
        }
        #endregion

        #region Implementation of IEquatable<mpq_t>
        /// <summary>
        /// Compares with another number.
        /// </summary>
        /// <param name="other">The other number.</param>
        public bool Equals(mpq_t? other)
        {
            if (ReferenceEquals(other, null))
                throw new ArgumentNullException(nameof(other));
            else
                return mpq.cmp(this, other) == 0;
        }

        /// <summary>
        /// Compares with another number.
        /// </summary>
        /// <param name="other">The other number.</param>
        bool IEquatable<mpq_t>.Equals(mpq_t? other) => Equals(other);

        #endregion

        #region Implementation of ICloneable
        /// <summary>
        /// Gets a clone of the object.
        /// </summary>
        public object Clone() => new mpq_t(this);

        /// <summary>
        /// Gets a clone of the object.
        /// </summary>
        object ICloneable.Clone() => Clone();

        #endregion

        #region Implementation of IConvertible
        /// <summary>
        /// Returns the <see cref="TypeCode"/> for this instance.
        /// </summary>
        TypeCode IConvertible.GetTypeCode() => TypeCode.Object;

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="bool"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public bool ToBoolean(IFormatProvider? provider) => throw new InvalidCastException();

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="bool"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        bool IConvertible.ToBoolean(IFormatProvider? provider) => throw new InvalidCastException();

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="byte"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public byte ToByte(IFormatProvider? provider) => (byte)this;

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="byte"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        byte IConvertible.ToByte(IFormatProvider? provider) => ToByte(provider);

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="char"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public char ToChar(IFormatProvider? provider) => throw new InvalidCastException();

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="char"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        char IConvertible.ToChar(IFormatProvider? provider) => throw new InvalidCastException();

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="DateTime"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public DateTime ToDateTime(IFormatProvider? provider) => throw new InvalidCastException();

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="DateTime"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        DateTime IConvertible.ToDateTime(IFormatProvider? provider) => throw new InvalidCastException();

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="decimal"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public decimal ToDecimal(IFormatProvider? provider) => throw new InvalidCastException();

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="decimal"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        decimal IConvertible.ToDecimal(IFormatProvider? provider) => throw new InvalidCastException();

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="decimal"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public double ToDouble(IFormatProvider? provider) => (double)this;

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="decimal"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        double IConvertible.ToDouble(IFormatProvider? provider) => ToDouble(provider);

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="short"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public short ToInt16(IFormatProvider? provider) => (short)this;

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="short"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        short IConvertible.ToInt16(IFormatProvider? provider) => ToInt16(provider);

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="int"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public int ToInt32(IFormatProvider? provider) => (int)this;

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="int"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        int IConvertible.ToInt32(IFormatProvider? provider) => ToInt32(provider);

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="long"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public long ToInt64(IFormatProvider? provider) => (long)this;

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="long"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        long IConvertible.ToInt64(IFormatProvider? provider) => ToInt64(provider);

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="sbyte"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public sbyte ToSByte(IFormatProvider? provider) => (sbyte)this;

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="sbyte"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        sbyte IConvertible.ToSByte(IFormatProvider? provider) => ToSByte(provider);

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="float"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public float ToSingle(IFormatProvider? provider) => (float)this;

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="float"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        float IConvertible.ToSingle(IFormatProvider? provider) => ToSingle(provider);

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="string"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public string ToString(IFormatProvider? provider) => ToString();

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="string"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        string IConvertible.ToString(IFormatProvider? provider) => ToString(provider);

        /// <summary>
        /// Converts the value of this instance to an object of the specified type.
        /// </summary>
        /// <param name="targetType">The type to which the value of this instance is converted.</param>
        /// <param name="provider">Culture-specific formatting information.</param>
        public object ToType(Type targetType, IFormatProvider? provider)
        {
            if (targetType == typeof(mpq_t))
                return this;

            IConvertible value = this;

            if (targetType == typeof(sbyte))
                return value.ToSByte(provider);
            else if (targetType == typeof(byte))
                return value.ToByte(provider);
            else if (targetType == typeof(short))
                return value.ToInt16(provider);
            else if (targetType == typeof(ushort))
                return value.ToUInt16(provider);
            else if (targetType == typeof(int))
                return value.ToInt32(provider);
            else if (targetType == typeof(uint))
                return value.ToUInt32(provider);
            else if (targetType == typeof(long))
                return value.ToInt64(provider);
            else if (targetType == typeof(ulong))
                return value.ToUInt64(provider);
            else if (targetType == typeof(float))
                return value.ToSingle(provider);
            else if (targetType == typeof(double))
                return value.ToDouble(provider);
            else if (targetType == typeof(decimal))
                return value.ToDecimal(provider);
            else if (targetType == typeof(string))
                return value.ToString(provider);
            else if (targetType == typeof(object))
                return value;
            else
                throw new InvalidCastException();
        }

        /// <summary>
        /// Converts the value of this instance to an object of the specified type.
        /// </summary>
        /// <param name="targetType">The type to which the value of this instance is converted.</param>
        /// <param name="provider">Culture-specific formatting information.</param>
        object IConvertible.ToType(Type targetType, IFormatProvider? provider) => ToType(targetType, provider);

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="ushort"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public ushort ToUInt16(IFormatProvider? provider) => (ushort)this;

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="ushort"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        ushort IConvertible.ToUInt16(IFormatProvider? provider) => ToUInt16(provider);

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="uint"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public uint ToUInt32(IFormatProvider? provider) => (uint)this;

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="uint"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        uint IConvertible.ToUInt32(IFormatProvider? provider) => ToUInt32(provider);

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="ulong"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        public ulong ToUInt64(IFormatProvider? provider) => (ulong)this;

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="ulong"/> value.
        /// </summary>
        /// <param name="provider">Culture-specific formatting information.</param>
        ulong IConvertible.ToUInt64(IFormatProvider? provider) => ToUInt64(provider);

        #endregion

        #region Implementation of IComparable
        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        public int CompareTo(object? obj) => obj is mpq_t other ? CompareTo(other) : throw new ArgumentException();

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        int IComparable.CompareTo(object? obj) => CompareTo(obj);

        #endregion
    }
}
