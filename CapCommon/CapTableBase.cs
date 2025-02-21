using System;
using System.Collections.Generic;

public abstract class CapTableBase
{
	private Dictionary<string, int> arrInt = new Dictionary<string, int>();

	private Dictionary<string, long> arrInt64 = new Dictionary<string, long>();

	private Dictionary<string, float> arrFloat = new Dictionary<string, float>();

	private Dictionary<string, string> arrString = new Dictionary<string, string>();

	public T Value<T>(string key) where T : IConvertible
	{
		try
		{
			Type typeFromHandle = typeof(T);
			if ((object)typeFromHandle == typeof(int))
			{
				if (arrInt.ContainsKey(key))
				{
					return (T)Convert.ChangeType(arrInt[key], typeFromHandle);
				}
				T val = (T)GetType().GetProperty(key).GetValue(this, null);
				arrInt[key] = Convert.ToInt32(val);
				return val;
			}
			if ((object)typeFromHandle == typeof(float))
			{
				if (arrFloat.ContainsKey(key))
				{
					return (T)Convert.ChangeType(arrFloat[key], typeFromHandle);
				}
				T val2 = (T)GetType().GetProperty(key).GetValue(this, null);
				arrFloat[key] = (float)Convert.ToDouble(val2);
				return val2;
			}
			if ((object)typeFromHandle == typeof(string))
			{
				if (arrString.ContainsKey(key))
				{
					return (T)Convert.ChangeType(arrString[key], typeFromHandle);
				}
				T val3 = (T)GetType().GetProperty(key).GetValue(this, null);
				arrString[key] = Convert.ToString(val3);
				return val3;
			}
			if ((object)typeFromHandle == typeof(long))
			{
				if (arrInt64.ContainsKey(key))
				{
					return (T)Convert.ChangeType(arrInt64[key], typeFromHandle);
				}
				T val4 = (T)GetType().GetProperty(key).GetValue(this, null);
				arrInt64[key] = Convert.ToInt64(val4);
				return val4;
			}
		}
		catch (Exception ex)
		{
			Console.Write(GetType().Name + " key[" + key + "] err=" + ex.Message + " stack=" + ex.StackTrace);
		}
		return default(T);
	}
}
