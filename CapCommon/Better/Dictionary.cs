using System.Collections.Generic;

namespace Better
{
	public class Dictionary<TKey, TValue> : System.Collections.Generic.Dictionary<TKey, TValue>
	{
		public Dictionary()
			: this(0, (IEqualityComparer<TKey>)null)
		{
		}

		public Dictionary(int capacity)
			: this(capacity, (IEqualityComparer<TKey>)null)
		{
		}

		public Dictionary(IEqualityComparer<TKey> comparer)
			: this(0, comparer)
		{
		}

		public Dictionary(int capacity, IEqualityComparer<TKey> comparer)
			: base(capacity, comparer ?? EqualityComparerFactory<TKey>.Comparer)
		{
		}

		public Dictionary(IDictionary<TKey, TValue> dictionary)
			: this(dictionary, (IEqualityComparer<TKey>)null)
		{
		}

		public Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
			: base(dictionary, comparer ?? EqualityComparerFactory<TKey>.Comparer)
		{
		}
	}
}
