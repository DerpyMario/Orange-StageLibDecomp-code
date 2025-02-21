using System;
using UnsafeGeneric;

namespace Better
{
	public struct StringKey : IEquatable<StringKey>
	{
		public readonly string Value;

		public readonly int HashCode;

		public StringKey(string str)
		{
			Value = str;
			HashCode = StringHashCode.Calculate(str);
		}

		public bool Equals(StringKey key)
		{
			return Value.Equals(key.Value);
		}

		public override bool Equals(object obj)
		{
			if (obj is StringKey)
			{
				return Equals((StringKey)obj);
			}
			return this == null;
		}

		public override int GetHashCode()
		{
			return HashCode;
		}

		public static bool operator ==(StringKey a, StringKey b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(StringKey a, StringKey b)
		{
			return !a.Equals(b);
		}

		public static implicit operator StringKey(string str)
		{
			return new StringKey(str);
		}

		public static implicit operator string(StringKey str)
		{
			return str.Value;
		}
	}
}
