using System.Collections.Generic;
using CallbackDefs;

public static class DictionaryExtender
{
	public static T_KEY Key<T_KEY, T_VALUE>(this Dictionary<T_KEY, T_VALUE> p_dict, T_KEY p_key) where T_VALUE : new()
	{
		if (!p_dict.ContainsKey(p_key))
		{
			p_dict.Add(p_key, new T_VALUE());
		}
		return p_key;
	}

	public static T_VALUE Value<T_KEY, T_VALUE>(this Dictionary<T_KEY, T_VALUE> p_dict, T_KEY p_key) where T_VALUE : new()
	{
		if (!p_dict.ContainsKey(p_key))
		{
			p_dict.Add(p_key, new T_VALUE());
		}
		return p_dict[p_key];
	}

	public static void ContainsAdd<T_KEY, T_VALUE>(this Dictionary<T_KEY, T_VALUE> p_dict, T_KEY p_key, T_VALUE p_value) where T_VALUE : new()
	{
		if (!p_dict.ContainsKey(p_key))
		{
			p_dict.Add(p_key, p_value);
		}
		else
		{
			p_dict[p_key] = p_value;
		}
	}

	public static void ContainsAdd<T_KEY, T_VALUE>(this SortedDictionary<T_KEY, T_VALUE> p_dict, T_KEY p_key, T_VALUE p_value) where T_VALUE : new()
	{
		if (!p_dict.ContainsKey(p_key))
		{
			p_dict.Add(p_key, p_value);
		}
		else
		{
			p_dict[p_key] = p_value;
		}
	}

	public static void CheckTargetToInvoke(this Callback p_cb)
	{
		if (p_cb != null && (p_cb.Target != null || (object)p_cb.Method != null))
		{
			p_cb();
		}
	}

	public static void CheckTargetToInvoke<T>(this Callback<T> p_cb, T p_param)
	{
		if (p_cb != null && (p_cb.Target != null || (object)p_cb.Method != null))
		{
			p_cb(p_param);
		}
	}

	public static void CheckTargetToInvoke<T1, T2>(this Callback<T1, T2> p_cb, T1 p_param1, T2 p_param2)
	{
		if (p_cb != null && (p_cb.Target != null || (object)p_cb.Method != null))
		{
			p_cb(p_param1, p_param2);
		}
	}

	public static void CheckTargetToInvoke<T1, T2, T3>(this Callback<T1, T2, T3> p_cb, T1 p_param1, T2 p_param2, T3 p_param3)
	{
		if (p_cb != null && (p_cb.Target != null || (object)p_cb.Method != null))
		{
			p_cb(p_param1, p_param2, p_param3);
		}
	}

	public static void CheckTargetToInvoke<T1, T2, T3, T4>(this Callback<T1, T2, T3, T4> p_cb, T1 p_param1, T2 p_param2, T3 p_param3, T4 p_param4)
	{
		if (p_cb != null && (p_cb.Target != null || (object)p_cb.Method != null))
		{
			p_cb(p_param1, p_param2, p_param3, p_param4);
		}
	}

	public static void CheckTargetToInvoke<T1, T2, T3, T4, T5>(this Callback<T1, T2, T3, T4, T5> p_cb, T1 p_param1, T2 p_param2, T3 p_param3, T4 p_param4, T5 p_param5)
	{
		if (p_cb != null && (p_cb.Target != null || (object)p_cb.Method != null))
		{
			p_cb(p_param1, p_param2, p_param3, p_param4, p_param5);
		}
	}

	public static void CheckTargetToInvoke(this CallbackObj p_cb, object p_param)
	{
		if (p_cb != null && (p_cb.Target != null || (object)p_cb.Method != null))
		{
			p_cb(p_param);
		}
	}

	public static void CheckTargetToInvoke(this CallbackObjs p_cb, params object[] p_param)
	{
		if (p_cb != null && (p_cb.Target != null || (object)p_cb.Method != null))
		{
			p_cb(p_param);
		}
	}

	public static void CheckTargetToInvoke(this CallbackIdx p_cb, int p_idx)
	{
		if (p_cb != null && (p_cb.Target != null || (object)p_cb.Method != null))
		{
			p_cb(p_idx);
		}
	}

	public static T_VALUE RandomOne<T_KEY, T_VALUE>(this Dictionary<T_KEY, T_VALUE> p_dict)
	{
		if (p_dict.Count <= 0)
		{
			return default(T_VALUE);
		}
		List<T_VALUE> list = new List<T_VALUE>();
		list.AddRange(p_dict.Values);
		int index = CapUtility.Random(0, list.Count - 1);
		return list[index];
	}
}
