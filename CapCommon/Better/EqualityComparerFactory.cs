using System;
using System.Collections.Generic;
using UnsafeGeneric;

namespace Better
{
	public static class EqualityComparerFactory<T>
	{
		public static IEqualityComparer<T> Comparer;

		static EqualityComparerFactory()
		{
			Type type = typeof(T);
			if (type.IsEnum)
			{
				type = Enum.GetUnderlyingType(type);
			}
			if ((object)type == typeof(sbyte) || (object)type == typeof(byte) || (object)type == typeof(short) || (object)type == typeof(ushort) || (object)type == typeof(int) || (object)type == typeof(uint) || (object)type == typeof(char))
			{
				Comparer = default(Int32EqualityComparer<T>);
			}
			else if ((object)type == typeof(long))
			{
				Comparer = default(Int64EqualityComparer<T>);
			}
			else if ((object)type == typeof(ulong))
			{
				Comparer = default(UInt64EqualityComparer<T>);
			}
			else if ((object)type == typeof(string))
			{
				Comparer = (IEqualityComparer<T>)(object)default(StringEqualityComparer);
			}
			else if ((object)type == typeof(StringKey))
			{
				Comparer = (IEqualityComparer<T>)(object)default(StringKeyEqualityComparer);
			}
			else
			{
				Comparer = null;
			}
		}
	}
}
