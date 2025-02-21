using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class CUSTOMIZE_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		s_ICON,
		n_RARITY,
		n_GET_TYPE,
		n_GET_VALUE1,
		n_GET_VALUE2,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public int n_RARITY { get; set; }

	[Preserve]
	public int n_GET_TYPE { get; set; }

	[Preserve]
	public int n_GET_VALUE1 { get; set; }

	[Preserve]
	public int n_GET_VALUE2 { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(CUSTOMIZE_TABLE tbl)
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
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(2, s_ICON);
		}
		if (n_RARITY != tbl.n_RARITY)
		{
			dictionary.Add(3, n_RARITY);
		}
		if (n_GET_TYPE != tbl.n_GET_TYPE)
		{
			dictionary.Add(4, n_GET_TYPE);
		}
		if (n_GET_VALUE1 != tbl.n_GET_VALUE1)
		{
			dictionary.Add(5, n_GET_VALUE1);
		}
		if (n_GET_VALUE2 != tbl.n_GET_VALUE2)
		{
			dictionary.Add(6, n_GET_VALUE2);
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
				n_TYPE = Convert.ToInt32(item.Value);
				break;
			case 2:
				s_ICON = item.Value.ToString();
				break;
			case 3:
				n_RARITY = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_GET_TYPE = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_GET_VALUE1 = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_GET_VALUE2 = Convert.ToInt32(item.Value);
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

	public bool EqualValue(CUSTOMIZE_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (s_ICON != table.s_ICON)
		{
			return false;
		}
		if (n_RARITY != table.n_RARITY)
		{
			return false;
		}
		if (n_GET_TYPE != table.n_GET_TYPE)
		{
			return false;
		}
		if (n_GET_VALUE1 != table.n_GET_VALUE1)
		{
			return false;
		}
		if (n_GET_VALUE2 != table.n_GET_VALUE2)
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
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.Write(n_RARITY);
		binaryWriter.Write(n_GET_TYPE);
		binaryWriter.Write(n_GET_VALUE1);
		binaryWriter.Write(n_GET_VALUE2);
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
		s_ICON = binaryReader.ReadExString();
		n_RARITY = binaryReader.ReadInt32();
		n_GET_TYPE = binaryReader.ReadInt32();
		n_GET_VALUE1 = binaryReader.ReadInt32();
		n_GET_VALUE2 = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
