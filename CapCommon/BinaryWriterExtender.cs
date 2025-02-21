using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public static class BinaryWriterExtender
{
	private static readonly float CapFloatDigits = 1000f;

	public static void WriteExFloat(this BinaryWriter bw, float content)
	{
		int value = Convert.ToInt32(content * CapFloatDigits);
		bw.Write(value);
	}

	public static void WriteASCIIString(this BinaryWriter bw, string content)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(content);
		bw.Write(Convert.ToUInt32(bytes.Length));
		bw.Write(bytes);
	}

	public static void WriteExString(this BinaryWriter bw, string content)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(content);
		bw.Write(Convert.ToUInt32(bytes.Length));
		bw.Write(bytes);
	}

	public static void WriteList<T>(this BinaryWriter bw, List<T> list) where T : struct
	{
		bw.Write(list.Count);
		foreach (T item in list)
		{
			if (item is int)
			{
				bw.Write(Convert.ToInt32(item));
			}
			else if (item is uint)
			{
				bw.Write(Convert.ToUInt32(item));
			}
			else if (item is long)
			{
				bw.Write(Convert.ToInt64(item));
			}
			else if (item is ulong)
			{
				bw.Write(Convert.ToUInt64(item));
			}
			else if (item is byte)
			{
				bw.Write(Convert.ToByte(item));
			}
			else if (item is sbyte)
			{
				bw.Write(Convert.ToSByte(item));
			}
			else if (item is short)
			{
				bw.Write(Convert.ToInt16(item));
			}
			else if (item is ushort)
			{
				bw.Write(Convert.ToUInt16(item));
			}
		}
	}

	public static void WriteListString(this BinaryWriter bw, List<string> list)
	{
		bw.Write(list.Count);
		foreach (string item in list)
		{
			bw.WriteExString(item);
		}
	}
}
