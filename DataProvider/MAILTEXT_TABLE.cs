using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class MAILTEXT_TABLE : CapTableBase
{
	private enum eSerial
	{
		w_KEY,
		w_CHT,
		w_JP,
		w_ENG,
		w_THA
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

	public Dictionary<int, object> MakeDiffDictionary(MAILTEXT_TABLE tbl)
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
			}
		}
	}

	public bool EqualValue(MAILTEXT_TABLE table)
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
	}
}
