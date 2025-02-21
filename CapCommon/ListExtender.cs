using System;
using System.Collections.Generic;

public static class ListExtender
{
	public static void Shuffle<T_VALUE>(this List<T_VALUE> lst)
	{
		Random random = new Random((int)DateTime.Now.Ticks);
		for (int i = 0; i < lst.Count - 1; i++)
		{
			int index = random.Next(i + 1, lst.Count);
			T_VALUE value = lst[index];
			lst[index] = lst[i];
			lst[i] = value;
		}
	}

	public static T_VALUE RandomOne<T_VALUE>(this List<T_VALUE> lst)
	{
		int index = CapUtility.Random(0, lst.Count - 1);
		return lst[index];
	}
}
