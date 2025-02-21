using System;

public abstract class ManagerBase : IManager, IDisposable
{
	public abstract void Initialize();

	public abstract void Dispose();

	public virtual void Reset()
	{
	}
}
