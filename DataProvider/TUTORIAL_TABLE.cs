using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class TUTORIAL_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_PRE,
		s_TRIGGER,
		s_TRIGGER_KEY,
		s_WAIT,
		s_MASK,
		n_Index,
		s_SORT,
		n_SCENARIO,
		n_SAVE,
		n_ITEMID,
		n_ITEMCOUNT,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_PRE { get; set; }

	[Preserve]
	public string s_TRIGGER { get; set; }

	[Preserve]
	public string s_TRIGGER_KEY { get; set; }

	[Preserve]
	public string s_WAIT { get; set; }

	[Preserve]
	public string s_MASK { get; set; }

	[Preserve]
	public int n_Index { get; set; }

	[Preserve]
	public string s_SORT { get; set; }

	[Preserve]
	public int n_SCENARIO { get; set; }

	[Preserve]
	public int n_SAVE { get; set; }

	[Preserve]
	public int n_ITEMID { get; set; }

	[Preserve]
	public int n_ITEMCOUNT { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(TUTORIAL_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_PRE != tbl.n_PRE)
		{
			dictionary.Add(1, n_PRE);
		}
		if (s_TRIGGER != tbl.s_TRIGGER)
		{
			dictionary.Add(2, s_TRIGGER);
		}
		if (s_TRIGGER_KEY != tbl.s_TRIGGER_KEY)
		{
			dictionary.Add(3, s_TRIGGER_KEY);
		}
		if (s_WAIT != tbl.s_WAIT)
		{
			dictionary.Add(4, s_WAIT);
		}
		if (s_MASK != tbl.s_MASK)
		{
			dictionary.Add(5, s_MASK);
		}
		if (n_Index != tbl.n_Index)
		{
			dictionary.Add(6, n_Index);
		}
		if (s_SORT != tbl.s_SORT)
		{
			dictionary.Add(7, s_SORT);
		}
		if (n_SCENARIO != tbl.n_SCENARIO)
		{
			dictionary.Add(8, n_SCENARIO);
		}
		if (n_SAVE != tbl.n_SAVE)
		{
			dictionary.Add(9, n_SAVE);
		}
		if (n_ITEMID != tbl.n_ITEMID)
		{
			dictionary.Add(10, n_ITEMID);
		}
		if (n_ITEMCOUNT != tbl.n_ITEMCOUNT)
		{
			dictionary.Add(11, n_ITEMCOUNT);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(12, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(13, s_END_VERSION);
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
				n_PRE = Convert.ToInt32(item.Value);
				break;
			case 2:
				s_TRIGGER = item.Value.ToString();
				break;
			case 3:
				s_TRIGGER_KEY = item.Value.ToString();
				break;
			case 4:
				s_WAIT = item.Value.ToString();
				break;
			case 5:
				s_MASK = item.Value.ToString();
				break;
			case 6:
				n_Index = Convert.ToInt32(item.Value);
				break;
			case 7:
				s_SORT = item.Value.ToString();
				break;
			case 8:
				n_SCENARIO = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_SAVE = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_ITEMID = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_ITEMCOUNT = Convert.ToInt32(item.Value);
				break;
			case 12:
				s_START_VERSION = item.Value.ToString();
				break;
			case 13:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(TUTORIAL_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_PRE != table.n_PRE)
		{
			return false;
		}
		if (s_TRIGGER != table.s_TRIGGER)
		{
			return false;
		}
		if (s_TRIGGER_KEY != table.s_TRIGGER_KEY)
		{
			return false;
		}
		if (s_WAIT != table.s_WAIT)
		{
			return false;
		}
		if (s_MASK != table.s_MASK)
		{
			return false;
		}
		if (n_Index != table.n_Index)
		{
			return false;
		}
		if (s_SORT != table.s_SORT)
		{
			return false;
		}
		if (n_SCENARIO != table.n_SCENARIO)
		{
			return false;
		}
		if (n_SAVE != table.n_SAVE)
		{
			return false;
		}
		if (n_ITEMID != table.n_ITEMID)
		{
			return false;
		}
		if (n_ITEMCOUNT != table.n_ITEMCOUNT)
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
		binaryWriter.Write(n_PRE);
		binaryWriter.WriteExString(s_TRIGGER);
		binaryWriter.WriteExString(s_TRIGGER_KEY);
		binaryWriter.WriteExString(s_WAIT);
		binaryWriter.WriteExString(s_MASK);
		binaryWriter.Write(n_Index);
		binaryWriter.WriteExString(s_SORT);
		binaryWriter.Write(n_SCENARIO);
		binaryWriter.Write(n_SAVE);
		binaryWriter.Write(n_ITEMID);
		binaryWriter.Write(n_ITEMCOUNT);
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
		n_PRE = binaryReader.ReadInt32();
		s_TRIGGER = binaryReader.ReadExString();
		s_TRIGGER_KEY = binaryReader.ReadExString();
		s_WAIT = binaryReader.ReadExString();
		s_MASK = binaryReader.ReadExString();
		n_Index = binaryReader.ReadInt32();
		s_SORT = binaryReader.ReadExString();
		n_SCENARIO = binaryReader.ReadInt32();
		n_SAVE = binaryReader.ReadInt32();
		n_ITEMID = binaryReader.ReadInt32();
		n_ITEMCOUNT = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
