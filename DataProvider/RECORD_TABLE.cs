using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class RECORD_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_MAP_MAX_X,
		n_MAP_MAX_Y,
		n_LATTICE_DATA,
		n_BATTLE_MAX,
		n_BATTLE_MIN,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_MAP_MAX_X { get; set; }

	[Preserve]
	public int n_MAP_MAX_Y { get; set; }

	[Preserve]
	public int n_LATTICE_DATA { get; set; }

	[Preserve]
	public int n_BATTLE_MAX { get; set; }

	[Preserve]
	public int n_BATTLE_MIN { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(RECORD_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_MAP_MAX_X != tbl.n_MAP_MAX_X)
		{
			dictionary.Add(1, n_MAP_MAX_X);
		}
		if (n_MAP_MAX_Y != tbl.n_MAP_MAX_Y)
		{
			dictionary.Add(2, n_MAP_MAX_Y);
		}
		if (n_LATTICE_DATA != tbl.n_LATTICE_DATA)
		{
			dictionary.Add(3, n_LATTICE_DATA);
		}
		if (n_BATTLE_MAX != tbl.n_BATTLE_MAX)
		{
			dictionary.Add(4, n_BATTLE_MAX);
		}
		if (n_BATTLE_MIN != tbl.n_BATTLE_MIN)
		{
			dictionary.Add(5, n_BATTLE_MIN);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(6, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(7, s_END_VERSION);
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
				n_MAP_MAX_X = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_MAP_MAX_Y = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_LATTICE_DATA = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_BATTLE_MAX = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_BATTLE_MIN = Convert.ToInt32(item.Value);
				break;
			case 6:
				s_START_VERSION = item.Value.ToString();
				break;
			case 7:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(RECORD_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_MAP_MAX_X != table.n_MAP_MAX_X)
		{
			return false;
		}
		if (n_MAP_MAX_Y != table.n_MAP_MAX_Y)
		{
			return false;
		}
		if (n_LATTICE_DATA != table.n_LATTICE_DATA)
		{
			return false;
		}
		if (n_BATTLE_MAX != table.n_BATTLE_MAX)
		{
			return false;
		}
		if (n_BATTLE_MIN != table.n_BATTLE_MIN)
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
		binaryWriter.Write(n_MAP_MAX_X);
		binaryWriter.Write(n_MAP_MAX_Y);
		binaryWriter.Write(n_LATTICE_DATA);
		binaryWriter.Write(n_BATTLE_MAX);
		binaryWriter.Write(n_BATTLE_MIN);
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
		n_MAP_MAX_X = binaryReader.ReadInt32();
		n_MAP_MAX_Y = binaryReader.ReadInt32();
		n_LATTICE_DATA = binaryReader.ReadInt32();
		n_BATTLE_MAX = binaryReader.ReadInt32();
		n_BATTLE_MIN = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
