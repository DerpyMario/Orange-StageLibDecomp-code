using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Better
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct StringKeyEqualityComparer : IEqualityComparer<StringKey>
	{
		public bool Equals(StringKey x, StringKey y)
		{
			return x.Equals(y);
		}

		public int GetHashCode(StringKey obj)
		{
			return obj.HashCode;
		}
	}
}
