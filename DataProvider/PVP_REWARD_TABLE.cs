using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class PVP_REWARD_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		n_COUNTER,
		n_CONDITION,
		n_CONDITION_X,
		n_CONDITION_Y,
		n_CONDITION_Z,
		n_GACHAID,
		n_GACHACOUNT,
		n_RESET_RULE,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_COUNTER { get; set; }

	[Preserve]
	public int n_CONDITION { get; set; }

	[Preserve]
	public int n_CONDITION_X { get; set; }

	[Preserve]
	public int n_CONDITION_Y { get; set; }

	[Preserve]
	public int n_CONDITION_Z { get; set; }

	[Preserve]
	public int n_GACHAID { get; set; }

	[Preserve]
	public int n_GACHACOUNT { get; set; }

	[Preserve]
	public int n_RESET_RULE { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(PVP_REWARD_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_TYPE != tbl.n_TYPE)
		{
			dictionary.Add(1, n_TYPE);
		}
		if (n_COUNTER != tbl.n_COUNTER)
		{
			dictionary.Add(2, n_COUNTER);
		}
		if (n_CONDITION != tbl.n_CONDITION)
		{
			dictionary.Add(3, n_CONDITION);
		}
		if (n_CONDITION_X != tbl.n_CONDITION_X)
		{
			dictionary.Add(4, n_CONDITION_X);
		}
		if (n_CONDITION_Y != tbl.n_CONDITION_Y)
		{
			dictionary.Add(5, n_CONDITION_Y);
		}
		if (n_CONDITION_Z != tbl.n_CONDITION_Z)
		{
			dictionary.Add(6, n_CONDITION_Z);
		}
		if (n_GACHAID != tbl.n_GACHAID)
		{
			dictionary.Add(7, n_GACHAID);
		}
		if (n_GACHACOUNT != tbl.n_GACHACOUNT)
		{
			dictionary.Add(8, n_GACHACOUNT);
		}
		if (n_RESET_RULE != tbl.n_RESET_RULE)
		{
			dictionary.Add(9, n_RESET_RULE);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(10, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(11, s_END_VERSION);
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
				n_TYPE = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_COUNTER = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_CONDITION = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_CONDITION_X = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_CONDITION_Y = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_CONDITION_Z = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_GACHAID = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_GACHACOUNT = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_RESET_RULE = Convert.ToInt32(item.Value);
				break;
			case 10:
				s_START_VERSION = item.Value.ToString();
				break;
			case 11:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(PVP_REWARD_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_COUNTER != table.n_COUNTER)
		{
			return false;
		}
		if (n_CONDITION != table.n_CONDITION)
		{
			return false;
		}
		if (n_CONDITION_X != table.n_CONDITION_X)
		{
			return false;
		}
		if (n_CONDITION_Y != table.n_CONDITION_Y)
		{
			return false;
		}
		if (n_CONDITION_Z != table.n_CONDITION_Z)
		{
			return false;
		}
		if (n_GACHAID != table.n_GACHAID)
		{
			return false;
		}
		if (n_GACHACOUNT != table.n_GACHACOUNT)
		{
			return false;
		}
		if (n_RESET_RULE != table.n_RESET_RULE)
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
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_COUNTER);
		binaryWriter.Write(n_CONDITION);
		binaryWriter.Write(n_CONDITION_X);
		binaryWriter.Write(n_CONDITION_Y);
		binaryWriter.Write(n_CONDITION_Z);
		binaryWriter.Write(n_GACHAID);
		binaryWriter.Write(n_GACHACOUNT);
		binaryWriter.Write(n_RESET_RULE);
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
		n_TYPE = binaryReader.ReadInt32();
		n_COUNTER = binaryReader.ReadInt32();
		n_CONDITION = binaryReader.ReadInt32();
		n_CONDITION_X = binaryReader.ReadInt32();
		n_CONDITION_Y = binaryReader.ReadInt32();
		n_CONDITION_Z = binaryReader.ReadInt32();
		n_GACHAID = binaryReader.ReadInt32();
		n_GACHACOUNT = binaryReader.ReadInt32();
		n_RESET_RULE = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
