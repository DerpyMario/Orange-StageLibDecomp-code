using System;

public abstract class ManagedSingleton<T> : ManagerBase where T : ManagerBase
{
	private static readonly object CriticalSession = new object();

	private static T _instance;

	public static T Instance
	{
		get
		{
			if (_instance == null)
			{
				IManager manager = SingletonManager.FindManagerInstance<T>();
				if (manager != null)
				{
					_instance = (T)manager;
					return _instance;
				}
				lock (CriticalSession)
				{
					if (_instance == null)
					{
						_instance = Activator.CreateInstance<T>();
						_instance.Initialize();
						SingletonManager.RegistManager(_instance);
					}
				}
			}
			return _instance;
		}
	}
}
