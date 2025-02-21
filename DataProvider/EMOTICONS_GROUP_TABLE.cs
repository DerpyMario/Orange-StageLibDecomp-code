using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class EMOTICONS_GROUP_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		s_GROUP_ICON,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public string s_GROUP_ICON { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(EMOTICONS_GROUP_TABLE tbl)
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
		if (s_GROUP_ICON != tbl.s_GROUP_ICON)
		{
			dictionary.Add(2, s_GROUP_ICON);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(3, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(4, s_END_VERSION);
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
				s_GROUP_ICON = item.Value.ToString();
				break;
			case 3:
				s_START_VERSION = item.Value.ToString();
				break;
			case 4:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(EMOTICONS_GROUP_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (s_GROUP_ICON != table.s_GROUP_ICON)
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
		binaryWriter.WriteExString(s_GROUP_ICON);
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
		s_GROUP_ICON = binaryReader.ReadExString();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
