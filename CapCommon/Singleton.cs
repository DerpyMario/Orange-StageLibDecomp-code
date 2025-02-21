using System;

public class Singleton<T>
{
	private static readonly object CriticalSession = new object();

	private static T _instance;

	public static T Instance
	{
		get
		{
			if (_instance == null)
			{
				lock (CriticalSession)
				{
					if (_instance == null)
					{
						_instance = Activator.CreateInstance<T>();
					}
				}
			}
			return _instance;
		}
	}
}
