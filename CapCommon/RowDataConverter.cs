using System.Reflection;

public abstract class RowDataConverter
{
	public abstract object Convert(PropertyInfo p, object obj);
}
