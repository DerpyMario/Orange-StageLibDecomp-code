using System.Collections.Generic;
using System.IO;
using System.Text;

public static class BinaryReaderExtender
{
	private static readonly float CapFloatDigits = 1000f;

	public static float ReadExFloat(this BinaryReader br)
	{
		return (float)br.ReadInt32() / CapFloatDigits;
	}

	public static string ReadASCIIString(this BinaryReader br)
	{
		uint count = br.ReadUInt32();
		return Encoding.ASCII.GetString(br.ReadBytes((int)count));
	}

	public static string ReadExString(this BinaryReader br)
	{
		uint count = br.ReadUInt32();
		return Encoding.Unicode.GetString(br.ReadBytes((int)count));
	}

	public static List<sbyte> ReadSByteList(this BinaryReader br)
	{
		List<sbyte> list = new List<sbyte>();
		int num = br.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			sbyte item = br.ReadSByte();
			list.Add(item);
		}
		return list;
	}

	public static List<byte> ReadByteList(this BinaryReader br)
	{
		List<byte> list = new List<byte>();
		int num = br.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			byte item = br.ReadByte();
			list.Add(item);
		}
		return list;
	}

	public static List<short> ReadInt16List(this BinaryReader br)
	{
		List<short> list = new List<short>();
		int num = br.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			short item = br.ReadInt16();
			list.Add(item);
		}
		return list;
	}

	public static List<ushort> ReadUInt16List(this BinaryReader br)
	{
		List<ushort> list = new List<ushort>();
		int num = br.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			ushort item = br.ReadUInt16();
			list.Add(item);
		}
		return list;
	}

	public static List<int> ReadInt32List(this BinaryReader br)
	{
		List<int> list = new List<int>();
		int num = br.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			int item = br.ReadInt32();
			list.Add(item);
		}
		return list;
	}

	public static List<long> ReadInt64List(this BinaryReader br)
	{
		List<long> list = new List<long>();
		int num = br.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			long item = br.ReadInt64();
			list.Add(item);
		}
		return list;
	}

	public static List<uint> ReadUInt32List(this BinaryReader br)
	{
		List<uint> list = new List<uint>();
		int num = br.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			uint item = br.ReadUInt32();
			list.Add(item);
		}
		return list;
	}

	public static List<ulong> ReadUInt64List(this BinaryReader br)
	{
		List<ulong> list = new List<ulong>();
		int num = br.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			ulong item = br.ReadUInt64();
			list.Add(item);
		}
		return list;
	}

	public static List<string> ReadListString(this BinaryReader br)
	{
		List<string> list = new List<string>();
		int num = br.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			string item = br.ReadExString();
			list.Add(item);
		}
		return list;
	}
}
