using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class BANNER_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_SORT,
		s_IMG,
		n_UILINK,
		s_URL,
		n_DISABLETYPE,
		n_DISABLETYPE_X,
		s_BEGIN_TIME,
		s_END_TIME,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_SORT { get; set; }

	[Preserve]
	public string s_IMG { get; set; }

	[Preserve]
	public int n_UILINK { get; set; }

	[Preserve]
	public string s_URL { get; set; }

	[Preserve]
	public int n_DISABLETYPE { get; set; }

	[Preserve]
	public int n_DISABLETYPE_X { get; set; }

	[Preserve]
	public string s_BEGIN_TIME { get; set; }

	[Preserve]
	public string s_END_TIME { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(BANNER_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_SORT != tbl.n_SORT)
		{
			dictionary.Add(1, n_SORT);
		}
		if (s_IMG != tbl.s_IMG)
		{
			dictionary.Add(2, s_IMG);
		}
		if (n_UILINK != tbl.n_UILINK)
		{
			dictionary.Add(3, n_UILINK);
		}
		if (s_URL != tbl.s_URL)
		{
			dictionary.Add(4, s_URL);
		}
		if (n_DISABLETYPE != tbl.n_DISABLETYPE)
		{
			dictionary.Add(5, n_DISABLETYPE);
		}
		if (n_DISABLETYPE_X != tbl.n_DISABLETYPE_X)
		{
			dictionary.Add(6, n_DISABLETYPE_X);
		}
		if (s_BEGIN_TIME != tbl.s_BEGIN_TIME)
		{
			dictionary.Add(7, s_BEGIN_TIME);
		}
		if (s_END_TIME != tbl.s_END_TIME)
		{
			dictionary.Add(8, s_END_TIME);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(9, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(10, s_END_VERSION);
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
				n_SORT = Convert.ToInt32(item.Value);
				break;
			case 2:
				s_IMG = item.Value.ToString();
				break;
			case 3:
				n_UILINK = Convert.ToInt32(item.Value);
				break;
			case 4:
				s_URL = item.Value.ToString();
				break;
			case 5:
				n_DISABLETYPE = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_DISABLETYPE_X = Convert.ToInt32(item.Value);
				break;
			case 7:
				s_BEGIN_TIME = item.Value.ToString();
				break;
			case 8:
				s_END_TIME = item.Value.ToString();
				break;
			case 9:
				s_START_VERSION = item.Value.ToString();
				break;
			case 10:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(BANNER_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_SORT != table.n_SORT)
		{
			return false;
		}
		if (s_IMG != table.s_IMG)
		{
			return false;
		}
		if (n_UILINK != table.n_UILINK)
		{
			return false;
		}
		if (s_URL != table.s_URL)
		{
			return false;
		}
		if (n_DISABLETYPE != table.n_DISABLETYPE)
		{
			return false;
		}
		if (n_DISABLETYPE_X != table.n_DISABLETYPE_X)
		{
			return false;
		}
		if (s_BEGIN_TIME != table.s_BEGIN_TIME)
		{
			return false;
		}
		if (s_END_TIME != table.s_END_TIME)
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
		binaryWriter.Write(n_SORT);
		binaryWriter.WriteExString(s_IMG);
		binaryWriter.Write(n_UILINK);
		binaryWriter.WriteExString(s_URL);
		binaryWriter.Write(n_DISABLETYPE);
		binaryWriter.Write(n_DISABLETYPE_X);
		binaryWriter.WriteExString(s_BEGIN_TIME);
		binaryWriter.WriteExString(s_END_TIME);
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
		n_SORT = binaryReader.ReadInt32();
		s_IMG = binaryReader.ReadExString();
		n_UILINK = binaryReader.ReadInt32();
		s_URL = binaryReader.ReadExString();
		n_DISABLETYPE = binaryReader.ReadInt32();
		n_DISABLETYPE_X = binaryReader.ReadInt32();
		s_BEGIN_TIME = binaryReader.ReadExString();
		s_END_TIME = binaryReader.ReadExString();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
