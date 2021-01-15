using IceLabs.Adaqz.Interfaces;
using System;

namespace IceLabs.Adaqz.Common
{
    public abstract class StringEnum<T> : IHasValue, IEquatable<T> where T : class, IHasValue
    {
        public string Value { get; }
        protected StringEnum(string value)
        {
            Value = value;
        }

        public bool Equals(T other)
        {
            if (ReferenceEquals(this, other))
                return true;

            if (ReferenceEquals(null, other))
                return false;

            return string.Equals(Value, other.Value, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as T);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
