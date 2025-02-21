using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class MISSIONTEXT_TABLE : CapTableBase
{
	private enum eSerial
	{
		w_KEY,
		w_CHT,
		w_JP,
		w_ENG,
		w_THA,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public string w_KEY { get; set; }

	[Preserve]
	public string w_CHT { get; set; }

	[Preserve]
	public string w_JP { get; set; }

	[Preserve]
	public string w_ENG { get; set; }

	[Preserve]
	public string w_THA { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(MISSIONTEXT_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (w_KEY != tbl.w_KEY)
		{
			dictionary.Add(0, w_KEY);
		}
		if (w_CHT != tbl.w_CHT)
		{
			dictionary.Add(1, w_CHT);
		}
		if (w_JP != tbl.w_JP)
		{
			dictionary.Add(2, w_JP);
		}
		if (w_ENG != tbl.w_ENG)
		{
			dictionary.Add(3, w_ENG);
		}
		if (w_THA != tbl.w_THA)
		{
			dictionary.Add(4, w_THA);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(5, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(6, s_END_VERSION);
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
				w_KEY = item.Value.ToString();
				break;
			case 1:
				w_CHT = item.Value.ToString();
				break;
			case 2:
				w_JP = item.Value.ToString();
				break;
			case 3:
				w_ENG = item.Value.ToString();
				break;
			case 4:
				w_THA = item.Value.ToString();
				break;
			case 5:
				s_START_VERSION = item.Value.ToString();
				break;
			case 6:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(MISSIONTEXT_TABLE table)
	{
		if (w_KEY != table.w_KEY)
		{
			return false;
		}
		if (w_CHT != table.w_CHT)
		{
			return false;
		}
		if (w_JP != table.w_JP)
		{
			return false;
		}
		if (w_ENG != table.w_ENG)
		{
			return false;
		}
		if (w_THA != table.w_THA)
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
		BinaryWriter bw = new BinaryWriter(memoryStream);
		bw.WriteExString(w_KEY);
		bw.WriteExString(w_CHT);
		bw.WriteExString(w_JP);
		bw.WriteExString(w_ENG);
		bw.WriteExString(w_THA);
		bw.WriteExString(s_START_VERSION);
		bw.WriteExString(s_END_VERSION);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		w_KEY = binaryReader.ReadExString();
		w_CHT = binaryReader.ReadExString();
		w_JP = binaryReader.ReadExString();
		w_ENG = binaryReader.ReadExString();
		w_THA = binaryReader.ReadExString();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
