using System.Collections.Generic;

public class MultiMap<T, V>
{
	private Dictionary<T, List<V>> _dictionary = new Dictionary<T, List<V>>();

	public List<V> Values
	{
		get
		{
			List<V> list = new List<V>();
			foreach (KeyValuePair<T, List<V>> item in _dictionary)
			{
				if (item.Value != null)
				{
					list.AddRange(item.Value);
				}
			}
			return list;
		}
	}

	public int ValuesCount
	{
		get
		{
			int num = 0;
			foreach (KeyValuePair<T, List<V>> item in _dictionary)
			{
				if (item.Value != null)
				{
					num += item.Value.Count;
				}
			}
			return num;
		}
	}

	public IEnumerable<T> Keys => _dictionary.Keys;

	public List<V> this[T key]
	{
		get
		{
			if (!_dictionary.TryGetValue(key, out var value))
			{
				value = new List<V>();
				_dictionary[key] = value;
			}
			return value;
		}
	}

	public void Add(T key, V value)
	{
		if (_dictionary.TryGetValue(key, out var value2))
		{
			value2.Add(value);
			return;
		}
		value2 = new List<V> { value };
		_dictionary[key] = value2;
	}

	public void Remove(T key)
	{
		if (_dictionary.ContainsKey(key))
		{
			_dictionary.Remove(key);
		}
	}

	public void Replace(T key, List<V> listValue)
	{
		Remove(key);
		_dictionary[key] = listValue;
	}

	public bool ContainKey(T key)
	{
		return _dictionary.ContainsKey(key);
	}

	public bool TryGetValue(T key, out List<V> value)
	{
		if (!ContainKey(key))
		{
			value = null;
			return false;
		}
		value = _dictionary[key];
		return true;
	}

	public void Clear()
	{
		_dictionary.Clear();
	}
}
