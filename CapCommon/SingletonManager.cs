using System;
using System.Collections.Generic;
using Better;

public static class SingletonManager
{
	private static System.Collections.Generic.Dictionary<Type, ManagerBase> dicManagerInstance = new Better.Dictionary<Type, ManagerBase>();

	private static bool Contains(Type type)
	{
		if (dicManagerInstance.ContainsKey(type))
		{
			return true;
		}
		return false;
	}

	public static IManager FindManagerInstance<T>()
	{
		Type typeFromHandle = typeof(T);
		if (Contains(typeFromHandle))
		{
			return dicManagerInstance[typeFromHandle];
		}
		return null;
	}

	public static void RegistManager(ManagerBase manager)
	{
		Type type = manager.GetType();
		if (!Contains(type))
		{
			dicManagerInstance.Add(type, manager);
		}
	}

	public static void RegisterManager<T>() where T : ManagerBase
	{
		if (!Contains(typeof(T)))
		{
			RegistManager(Activator.CreateInstance(typeof(T)) as T);
		}
	}

	public static void Startup()
	{
		foreach (KeyValuePair<Type, ManagerBase> item in dicManagerInstance)
		{
			item.Value.Initialize();
		}
	}

	public static void Reset()
	{
		foreach (KeyValuePair<Type, ManagerBase> item in dicManagerInstance)
		{
			item.Value.Reset();
		}
	}

	public static void Dispose()
	{
		foreach (KeyValuePair<Type, ManagerBase> item in dicManagerInstance)
		{
			item.Value.Dispose();
		}
	}
}
