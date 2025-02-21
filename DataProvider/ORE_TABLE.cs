using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class ORE_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_ORE_TYPE,
		n_ORE_GROUP,
		n_ORE_LEVEL,
		n_ORE_OPEN,
		n_ORE_VALUE,
		s_ORE_STAGE,
		n_ORE_UPMONEY,
		n_ORE_MONEY,
		n_ORE_SKILL_1,
		n_ORE_SKILL_2,
		s_ORE_TIP,
		n_ORE_ICON,
		n_ORE_CHALLENGE,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_ORE_TYPE { get; set; }

	[Preserve]
	public int n_ORE_GROUP { get; set; }

	[Preserve]
	public int n_ORE_LEVEL { get; set; }

	[Preserve]
	public int n_ORE_OPEN { get; set; }

	[Preserve]
	public int n_ORE_VALUE { get; set; }

	[Preserve]
	public string s_ORE_STAGE { get; set; }

	[Preserve]
	public int n_ORE_UPMONEY { get; set; }

	[Preserve]
	public int n_ORE_MONEY { get; set; }

	[Preserve]
	public int n_ORE_SKILL_1 { get; set; }

	[Preserve]
	public int n_ORE_SKILL_2 { get; set; }

	[Preserve]
	public string s_ORE_TIP { get; set; }

	[Preserve]
	public int n_ORE_ICON { get; set; }

	[Preserve]
	public int n_ORE_CHALLENGE { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(ORE_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_ORE_TYPE != tbl.n_ORE_TYPE)
		{
			dictionary.Add(1, n_ORE_TYPE);
		}
		if (n_ORE_GROUP != tbl.n_ORE_GROUP)
		{
			dictionary.Add(2, n_ORE_GROUP);
		}
		if (n_ORE_LEVEL != tbl.n_ORE_LEVEL)
		{
			dictionary.Add(3, n_ORE_LEVEL);
		}
		if (n_ORE_OPEN != tbl.n_ORE_OPEN)
		{
			dictionary.Add(4, n_ORE_OPEN);
		}
		if (n_ORE_VALUE != tbl.n_ORE_VALUE)
		{
			dictionary.Add(5, n_ORE_VALUE);
		}
		if (s_ORE_STAGE != tbl.s_ORE_STAGE)
		{
			dictionary.Add(6, s_ORE_STAGE);
		}
		if (n_ORE_UPMONEY != tbl.n_ORE_UPMONEY)
		{
			dictionary.Add(7, n_ORE_UPMONEY);
		}
		if (n_ORE_MONEY != tbl.n_ORE_MONEY)
		{
			dictionary.Add(8, n_ORE_MONEY);
		}
		if (n_ORE_SKILL_1 != tbl.n_ORE_SKILL_1)
		{
			dictionary.Add(9, n_ORE_SKILL_1);
		}
		if (n_ORE_SKILL_2 != tbl.n_ORE_SKILL_2)
		{
			dictionary.Add(10, n_ORE_SKILL_2);
		}
		if (s_ORE_TIP != tbl.s_ORE_TIP)
		{
			dictionary.Add(11, s_ORE_TIP);
		}
		if (n_ORE_ICON != tbl.n_ORE_ICON)
		{
			dictionary.Add(12, n_ORE_ICON);
		}
		if (n_ORE_CHALLENGE != tbl.n_ORE_CHALLENGE)
		{
			dictionary.Add(13, n_ORE_CHALLENGE);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(14, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(15, s_END_VERSION);
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
				n_ORE_TYPE = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_ORE_GROUP = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_ORE_LEVEL = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_ORE_OPEN = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_ORE_VALUE = Convert.ToInt32(item.Value);
				break;
			case 6:
				s_ORE_STAGE = item.Value.ToString();
				break;
			case 7:
				n_ORE_UPMONEY = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_ORE_MONEY = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_ORE_SKILL_1 = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_ORE_SKILL_2 = Convert.ToInt32(item.Value);
				break;
			case 11:
				s_ORE_TIP = item.Value.ToString();
				break;
			case 12:
				n_ORE_ICON = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_ORE_CHALLENGE = Convert.ToInt32(item.Value);
				break;
			case 14:
				s_START_VERSION = item.Value.ToString();
				break;
			case 15:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(ORE_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_ORE_TYPE != table.n_ORE_TYPE)
		{
			return false;
		}
		if (n_ORE_GROUP != table.n_ORE_GROUP)
		{
			return false;
		}
		if (n_ORE_LEVEL != table.n_ORE_LEVEL)
		{
			return false;
		}
		if (n_ORE_OPEN != table.n_ORE_OPEN)
		{
			return false;
		}
		if (n_ORE_VALUE != table.n_ORE_VALUE)
		{
			return false;
		}
		if (s_ORE_STAGE != table.s_ORE_STAGE)
		{
			return false;
		}
		if (n_ORE_UPMONEY != table.n_ORE_UPMONEY)
		{
			return false;
		}
		if (n_ORE_MONEY != table.n_ORE_MONEY)
		{
			return false;
		}
		if (n_ORE_SKILL_1 != table.n_ORE_SKILL_1)
		{
			return false;
		}
		if (n_ORE_SKILL_2 != table.n_ORE_SKILL_2)
		{
			return false;
		}
		if (s_ORE_TIP != table.s_ORE_TIP)
		{
			return false;
		}
		if (n_ORE_ICON != table.n_ORE_ICON)
		{
			return false;
		}
		if (n_ORE_CHALLENGE != table.n_ORE_CHALLENGE)
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
		binaryWriter.Write(n_ORE_TYPE);
		binaryWriter.Write(n_ORE_GROUP);
		binaryWriter.Write(n_ORE_LEVEL);
		binaryWriter.Write(n_ORE_OPEN);
		binaryWriter.Write(n_ORE_VALUE);
		binaryWriter.WriteExString(s_ORE_STAGE);
		binaryWriter.Write(n_ORE_UPMONEY);
		binaryWriter.Write(n_ORE_MONEY);
		binaryWriter.Write(n_ORE_SKILL_1);
		binaryWriter.Write(n_ORE_SKILL_2);
		binaryWriter.WriteExString(s_ORE_TIP);
		binaryWriter.Write(n_ORE_ICON);
		binaryWriter.Write(n_ORE_CHALLENGE);
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
		n_ORE_TYPE = binaryReader.ReadInt32();
		n_ORE_GROUP = binaryReader.ReadInt32();
		n_ORE_LEVEL = binaryReader.ReadInt32();
		n_ORE_OPEN = binaryReader.ReadInt32();
		n_ORE_VALUE = binaryReader.ReadInt32();
		s_ORE_STAGE = binaryReader.ReadExString();
		n_ORE_UPMONEY = binaryReader.ReadInt32();
		n_ORE_MONEY = binaryReader.ReadInt32();
		n_ORE_SKILL_1 = binaryReader.ReadInt32();
		n_ORE_SKILL_2 = binaryReader.ReadInt32();
		s_ORE_TIP = binaryReader.ReadExString();
		n_ORE_ICON = binaryReader.ReadInt32();
		n_ORE_CHALLENGE = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
