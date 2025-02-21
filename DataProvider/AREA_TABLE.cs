using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class AREA_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		s_CODE,
		s_RULE,
		s_PRIVACY,
		n_FLAG,
		s_REGION,
		s_TEXT
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public string s_CODE { get; set; }

	[Preserve]
	public string s_RULE { get; set; }

	[Preserve]
	public string s_PRIVACY { get; set; }

	[Preserve]
	public int n_FLAG { get; set; }

	[Preserve]
	public string s_REGION { get; set; }

	[Preserve]
	public string s_TEXT { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(AREA_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (s_CODE != tbl.s_CODE)
		{
			dictionary.Add(1, s_CODE);
		}
		if (s_RULE != tbl.s_RULE)
		{
			dictionary.Add(2, s_RULE);
		}
		if (s_PRIVACY != tbl.s_PRIVACY)
		{
			dictionary.Add(3, s_PRIVACY);
		}
		if (n_FLAG != tbl.n_FLAG)
		{
			dictionary.Add(4, n_FLAG);
		}
		if (s_REGION != tbl.s_REGION)
		{
			dictionary.Add(5, s_REGION);
		}
		if (s_TEXT != tbl.s_TEXT)
		{
			dictionary.Add(6, s_TEXT);
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
				s_CODE = item.Value.ToString();
				break;
			case 2:
				s_RULE = item.Value.ToString();
				break;
			case 3:
				s_PRIVACY = item.Value.ToString();
				break;
			case 4:
				n_FLAG = Convert.ToInt32(item.Value);
				break;
			case 5:
				s_REGION = item.Value.ToString();
				break;
			case 6:
				s_TEXT = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(AREA_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (s_CODE != table.s_CODE)
		{
			return false;
		}
		if (s_RULE != table.s_RULE)
		{
			return false;
		}
		if (s_PRIVACY != table.s_PRIVACY)
		{
			return false;
		}
		if (n_FLAG != table.n_FLAG)
		{
			return false;
		}
		if (s_REGION != table.s_REGION)
		{
			return false;
		}
		if (s_TEXT != table.s_TEXT)
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
		binaryWriter.WriteExString(s_CODE);
		binaryWriter.WriteExString(s_RULE);
		binaryWriter.WriteExString(s_PRIVACY);
		binaryWriter.Write(n_FLAG);
		binaryWriter.WriteExString(s_REGION);
		binaryWriter.WriteExString(s_TEXT);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		s_CODE = binaryReader.ReadExString();
		s_RULE = binaryReader.ReadExString();
		s_PRIVACY = binaryReader.ReadExString();
		n_FLAG = binaryReader.ReadInt32();
		s_REGION = binaryReader.ReadExString();
		s_TEXT = binaryReader.ReadExString();
	}
}
