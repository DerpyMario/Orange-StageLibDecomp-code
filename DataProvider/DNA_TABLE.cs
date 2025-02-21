using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class DNA_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_CHARACTER,
		n_SLOT,
		n_TYPE,
		n_GROUP,
		n_STAR,
		n_COST_ID,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_CHARACTER { get; set; }

	[Preserve]
	public int n_SLOT { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_STAR { get; set; }

	[Preserve]
	public int n_COST_ID { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(DNA_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_CHARACTER != tbl.n_CHARACTER)
		{
			dictionary.Add(1, n_CHARACTER);
		}
		if (n_SLOT != tbl.n_SLOT)
		{
			dictionary.Add(2, n_SLOT);
		}
		if (n_TYPE != tbl.n_TYPE)
		{
			dictionary.Add(3, n_TYPE);
		}
		if (n_GROUP != tbl.n_GROUP)
		{
			dictionary.Add(4, n_GROUP);
		}
		if (n_STAR != tbl.n_STAR)
		{
			dictionary.Add(5, n_STAR);
		}
		if (n_COST_ID != tbl.n_COST_ID)
		{
			dictionary.Add(6, n_COST_ID);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(7, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(8, s_END_VERSION);
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
				n_CHARACTER = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_SLOT = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_TYPE = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_GROUP = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_STAR = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_COST_ID = Convert.ToInt32(item.Value);
				break;
			case 7:
				s_START_VERSION = item.Value.ToString();
				break;
			case 8:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(DNA_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_CHARACTER != table.n_CHARACTER)
		{
			return false;
		}
		if (n_SLOT != table.n_SLOT)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (n_STAR != table.n_STAR)
		{
			return false;
		}
		if (n_COST_ID != table.n_COST_ID)
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
		binaryWriter.Write(n_CHARACTER);
		binaryWriter.Write(n_SLOT);
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_GROUP);
		binaryWriter.Write(n_STAR);
		binaryWriter.Write(n_COST_ID);
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
		n_CHARACTER = binaryReader.ReadInt32();
		n_SLOT = binaryReader.ReadInt32();
		n_TYPE = binaryReader.ReadInt32();
		n_GROUP = binaryReader.ReadInt32();
		n_STAR = binaryReader.ReadInt32();
		n_COST_ID = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
