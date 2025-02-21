using System.Collections.Generic;

namespace Better
{
	public class HashSet<T> : System.Collections.Generic.HashSet<T>
	{
		public HashSet()
			: this((IEqualityComparer<T>)null)
		{
		}

		public HashSet(IEqualityComparer<T> comparer)
			: base(comparer ?? EqualityComparerFactory<T>.Comparer)
		{
		}

		public HashSet(IEnumerable<T> collection)
			: this(collection, (IEqualityComparer<T>)null)
		{
		}

		public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
			: base(collection, comparer ?? EqualityComparerFactory<T>.Comparer)
		{
		}
	}
}
