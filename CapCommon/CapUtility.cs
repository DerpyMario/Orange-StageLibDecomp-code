using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using Better;

public static class CapUtility
{
	private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	private static readonly Func<int, IEnumerable<int>> FindBits = (int value) => from i in Enumerable.Range(0, 31)
		select 2 << i into i
		where (value & i) == i
		select i;

	public static long DateToUnixTime(DateTime date)
	{
		return Convert.ToInt64((date - epoch).TotalSeconds);
	}

	public static DateTime UnixTimeToDate(long unixTimeStamp)
	{
		return epoch.AddSeconds(unixTimeStamp).ToUniversalTime();
	}

	public static T CreateItemFromRow<T>(DataRow row, RowDataConverter converter = null) where T : new()
	{
		T val = new T();
		SetItemFromRow(val, row, converter);
		return val;
	}

	public static void SetItemFromRow<T>(T item, DataRow row, RowDataConverter converter) where T : new()
	{
		foreach (DataColumn column in row.Table.Columns)
		{
			PropertyInfo property = item.GetType().GetProperty(column.ColumnName);
			if ((object)property != null && row[column] != DBNull.Value)
			{
				object value = row[column];
				if (converter != null)
				{
					value = converter.Convert(property, row[column]);
				}
				property.SetValue(item, value, null);
			}
		}
	}

	public static string BinaryToString(string data)
	{
		List<byte> list = new List<byte>();
		for (int i = 0; i < data.Length; i += 2)
		{
			list.Add(Convert.ToByte(data.Substring(i, 2), 16));
		}
		return Encoding.ASCII.GetString(list.ToArray());
	}

	public static string EncryptDecryptStr(string p, string key)
	{
		byte[] bytes = Encoding.Default.GetBytes(p);
		byte[] bytes2 = Encoding.Default.GetBytes(key);
		int num = bytes2.Length;
		int num2 = 0;
		for (int i = 0; i < bytes.Length; i++)
		{
			bytes[i] ^= bytes2[num2];
			num2 = ((++num2 < num) ? num2 : 0);
		}
		return Encoding.Default.GetString(bytes);
	}

	public static string EncryptStringToBase64(string p, string key)
	{
		byte[] bytes = Encoding.Default.GetBytes(p);
		byte[] bytes2 = Encoding.Default.GetBytes(key);
		int num = bytes2.Length;
		int num2 = 0;
		for (int i = 0; i < bytes.Length; i++)
		{
			bytes[i] ^= bytes2[num2];
			num2 = ((++num2 < num) ? num2 : 0);
		}
		return Convert.ToBase64String(bytes);
	}

	public static byte[] EncryptDecryptByte(byte[] p, string key)
	{
		byte[] bytes = Encoding.Default.GetBytes(key);
		int num = bytes.Length;
		int num2 = 0;
		for (int i = 0; i < p.Length; i++)
		{
			p[i] ^= bytes[num2];
			num2 = ((++num2 < num) ? num2 : 0);
		}
		return p;
	}

	public static int Random(int min, int max)
	{
		return new Random(Guid.NewGuid().GetHashCode()).Next(min, max + 1);
	}

	public static void PrintBytes(byte[] bytes)
	{
		Console.WriteLine();
		Console.Write(" {");
		foreach (byte b in bytes)
		{
			Console.Write(b + ", ");
		}
		Console.Write("} ");
		Console.WriteLine();
	}

	public static List<Type> CollectSubTypeOf(List<Type> listType, bool isClass = true, bool isGeneric = false)
	{
		List<Type> list = new List<Type>();
		foreach (Type item in listType)
		{
			list.AddRange(CollectSubTypeOf(item, isClass, isGeneric));
		}
		return list;
	}

	public static List<Type> CollectSubTypeOf(Type type, bool isClass = true, bool isGeneric = false)
	{
		List<Type> list = new List<Type>();
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		for (int i = 0; i < assemblies.Length; i++)
		{
			Type[] types = assemblies[i].GetTypes();
			foreach (Type type2 in types)
			{
				if (type2.IsClass == isClass && type2.IsGenericType == isGeneric)
				{
					if (type.IsInterface && (object)type2.GetInterface(type.Name) != null)
					{
						list.Add(type2);
					}
					else if (type2.IsSubclassOf(type))
					{
						list.Add(type2);
					}
				}
			}
		}
		return list;
	}

	public static Type GetTypeByName(string name, bool isClass = true, bool isGeneric = false, bool isInterface = false)
	{
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		for (int i = 0; i < assemblies.Length; i++)
		{
			Type[] types = assemblies[i].GetTypes();
			foreach (Type type in types)
			{
				if (type.IsClass == isClass && type.IsGenericType == isGeneric && type.IsInterface == isInterface && type.Name == name)
				{
					return type;
				}
			}
		}
		return null;
	}

	public static System.Collections.Generic.Dictionary<string, Type> CollectSubTypeToDictionary(Type type)
	{
		List<Type> list = CollectSubTypeOf(type);
		System.Collections.Generic.Dictionary<string, Type> dictionary = new Better.Dictionary<string, Type>();
		foreach (Type item in list)
		{
			dictionary.Add(item.Name, item);
		}
		return dictionary;
	}

	public static PropertyInfo GetPropertyRecursive(string propertyName, Type srcType, Type limitedType, BindingFlags flags)
	{
		if ((object)srcType == typeof(object) || (object)srcType == limitedType)
		{
			return null;
		}
		PropertyInfo property = srcType.GetProperty(propertyName, flags);
		if ((object)property != null)
		{
			return property;
		}
		return GetPropertyRecursive(propertyName, srcType.BaseType, limitedType, flags);
	}

	public static double GetDistanceSqrt(float x1, float y1, float x2, float y2)
	{
		return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
	}

	public static float GetDistance(float x1, float y1, float x2, float y2)
	{
		return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
	}

	public static int GetTimeZoneOffSet()
	{
		DateTime now = DateTime.Now;
		DateTime dateTime = now.ToLocalTime();
		DateTime dateTime2 = now.ToUniversalTime();
		return (dateTime - dateTime2).Hours;
	}

	public static T GetRandomOneFromEnumType<T>()
	{
		Array values = Enum.GetValues(typeof(T));
		Random random = new Random();
		return (T)values.GetValue(random.Next(values.Length));
	}

	public static string GetRandomString(int length)
	{
		string text = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
		Random random = new Random();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < length; i++)
		{
			stringBuilder.Append(text[random.Next(0, text.Length)]);
		}
		return stringBuilder.ToString();
	}

	public static string GetSubString(string beginTag, string endTag, string sourceString, bool includeBeginTag = true, bool includeEndTag = false)
	{
		int num = sourceString.IndexOf(beginTag);
		if (num < 0)
		{
			return string.Empty;
		}
		int num2 = sourceString.IndexOf(endTag, num);
		if (num2 < 0)
		{
			return string.Empty;
		}
		int startIndex = num + ((!includeBeginTag) ? beginTag.Length : 0);
		int length = num2 - num - ((!includeBeginTag) ? beginTag.Length : 0) + (includeEndTag ? endTag.Length : 0);
		return sourceString.Substring(startIndex, length);
	}

	public static void CopyPropertiesFrom(this object self, object parent)
	{
		PropertyInfo[] properties = parent.GetType().GetProperties();
		PropertyInfo[] properties2 = self.GetType().GetProperties();
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			PropertyInfo[] array2 = properties2;
			foreach (PropertyInfo propertyInfo2 in array2)
			{
				if (propertyInfo.Name == propertyInfo2.Name && (object)propertyInfo.PropertyType == propertyInfo2.PropertyType)
				{
					propertyInfo2.SetValue(self, propertyInfo.GetValue(parent, null), null);
					break;
				}
			}
		}
	}

	public static void CopyFieldsFrom(this object self, object parent)
	{
		FieldInfo[] fields = parent.GetType().GetFields();
		FieldInfo[] fields2 = self.GetType().GetFields();
		FieldInfo[] array = fields;
		foreach (FieldInfo fieldInfo in array)
		{
			FieldInfo[] array2 = fields2;
			foreach (FieldInfo fieldInfo2 in array2)
			{
				if (fieldInfo.Name == fieldInfo2.Name)
				{
					fieldInfo2.SetValue(self, fieldInfo.GetValue(parent));
					break;
				}
			}
		}
	}

	public static int GetIndexFromBitwise(int bitwise)
	{
		IEnumerable<int> source = FindBits(bitwise);
		if (source.Count() != 1)
		{
			return -1;
		}
		return source.First();
	}

	public static int[] GetBitsFromBitwise(int bitwise)
	{
		return FindBits(bitwise).ToArray();
	}
}
