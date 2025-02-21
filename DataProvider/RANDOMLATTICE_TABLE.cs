using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class RANDOMLATTICE_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		n_SCALE,
		n_TYPE,
		n_VALUE_X,
		n_VALUE_Y,
		n_VALUE_Z,
		s_RANDOM_TIP,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_SCALE { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_VALUE_X { get; set; }

	[Preserve]
	public int n_VALUE_Y { get; set; }

	[Preserve]
	public int n_VALUE_Z { get; set; }

	[Preserve]
	public string s_RANDOM_TIP { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(RANDOMLATTICE_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_GROUP != tbl.n_GROUP)
		{
			dictionary.Add(1, n_GROUP);
		}
		if (n_SCALE != tbl.n_SCALE)
		{
			dictionary.Add(2, n_SCALE);
		}
		if (n_TYPE != tbl.n_TYPE)
		{
			dictionary.Add(3, n_TYPE);
		}
		if (n_VALUE_X != tbl.n_VALUE_X)
		{
			dictionary.Add(4, n_VALUE_X);
		}
		if (n_VALUE_Y != tbl.n_VALUE_Y)
		{
			dictionary.Add(5, n_VALUE_Y);
		}
		if (n_VALUE_Z != tbl.n_VALUE_Z)
		{
			dictionary.Add(6, n_VALUE_Z);
		}
		if (s_RANDOM_TIP != tbl.s_RANDOM_TIP)
		{
			dictionary.Add(7, s_RANDOM_TIP);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(8, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(9, s_END_VERSION);
		}
		return dictionary;
	}

	public void CombineDiffDictionary(Dictionary<int, object> dic)
	{
		foreach (KeyValuePair<int, object> item in dic)
		{
			switch (item.Key)
			{
			case 0:
				n_ID = Convert.ToInt32(item.Value);
				break;
			case 1:
				n_GROUP = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_SCALE = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_TYPE = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_VALUE_X = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_VALUE_Y = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_VALUE_Z = Convert.ToInt32(item.Value);
				break;
			case 7:
				s_RANDOM_TIP = item.Value.ToString();
				break;
			case 8:
				s_START_VERSION = item.Value.ToString();
				break;
			case 9:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(RANDOMLATTICE_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (n_SCALE != table.n_SCALE)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_VALUE_X != table.n_VALUE_X)
		{
			return false;
		}
		if (n_VALUE_Y != table.n_VALUE_Y)
		{
			return false;
		}
		if (n_VALUE_Z != table.n_VALUE_Z)
		{
			return false;
		}
		if (s_RANDOM_TIP != table.s_RANDOM_TIP)
		{
			return false;
		}
		if (s_START_VERSION != table.s_START_VERSION)
		{
			return false;
		}
		if (s_END_VERSION != table.s_END_VERSION)
		{
			return false;
		}
		return true;
	}

	public string ConvertToString()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(n_ID);
		binaryWriter.Write(n_GROUP);
		binaryWriter.Write(n_SCALE);
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_VALUE_X);
		binaryWriter.Write(n_VALUE_Y);
		binaryWriter.Write(n_VALUE_Z);
		binaryWriter.WriteExString(s_RANDOM_TIP);
		binaryWriter.WriteExString(s_START_VERSION);
		binaryWriter.WriteExString(s_END_VERSION);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_GROUP = binaryReader.ReadInt32();
		n_SCALE = binaryReader.ReadInt32();
		n_TYPE = binaryReader.ReadInt32();
		n_VALUE_X = binaryReader.ReadInt32();
		n_VALUE_Y = binaryReader.ReadInt32();
		n_VALUE_Z = binaryReader.ReadInt32();
		s_RANDOM_TIP = binaryReader.ReadExString();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
