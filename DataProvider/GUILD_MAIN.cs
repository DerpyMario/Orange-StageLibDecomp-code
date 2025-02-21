using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class GUILD_MAIN : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GUILD_NUMBER,
		n_GUILD_CLASS,
		n_GUILD_INTEGRAL,
		n_GUILD_MONEY,
		n_GUILD_HOUSE,
		n_POWER_UPMAX,
		n_GUILD_BOX,
		s_GUILD_MODEL_1,
		s_GUILD_MODEL_2,
		s_GUILD_MODEL_3,
		s_GUILD_MODEL_4,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GUILD_NUMBER { get; set; }

	[Preserve]
	public int n_GUILD_CLASS { get; set; }

	[Preserve]
	public int n_GUILD_INTEGRAL { get; set; }

	[Preserve]
	public int n_GUILD_MONEY { get; set; }

	[Preserve]
	public int n_GUILD_HOUSE { get; set; }

	[Preserve]
	public int n_POWER_UPMAX { get; set; }

	[Preserve]
	public int n_GUILD_BOX { get; set; }

	[Preserve]
	public string s_GUILD_MODEL_1 { get; set; }

	[Preserve]
	public string s_GUILD_MODEL_2 { get; set; }

	[Preserve]
	public string s_GUILD_MODEL_3 { get; set; }

	[Preserve]
	public string s_GUILD_MODEL_4 { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(GUILD_MAIN tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_GUILD_NUMBER != tbl.n_GUILD_NUMBER)
		{
			dictionary.Add(1, n_GUILD_NUMBER);
		}
		if (n_GUILD_CLASS != tbl.n_GUILD_CLASS)
		{
			dictionary.Add(2, n_GUILD_CLASS);
		}
		if (n_GUILD_INTEGRAL != tbl.n_GUILD_INTEGRAL)
		{
			dictionary.Add(3, n_GUILD_INTEGRAL);
		}
		if (n_GUILD_MONEY != tbl.n_GUILD_MONEY)
		{
			dictionary.Add(4, n_GUILD_MONEY);
		}
		if (n_GUILD_HOUSE != tbl.n_GUILD_HOUSE)
		{
			dictionary.Add(5, n_GUILD_HOUSE);
		}
		if (n_POWER_UPMAX != tbl.n_POWER_UPMAX)
		{
			dictionary.Add(6, n_POWER_UPMAX);
		}
		if (n_GUILD_BOX != tbl.n_GUILD_BOX)
		{
			dictionary.Add(7, n_GUILD_BOX);
		}
		if (s_GUILD_MODEL_1 != tbl.s_GUILD_MODEL_1)
		{
			dictionary.Add(8, s_GUILD_MODEL_1);
		}
		if (s_GUILD_MODEL_2 != tbl.s_GUILD_MODEL_2)
		{
			dictionary.Add(9, s_GUILD_MODEL_2);
		}
		if (s_GUILD_MODEL_3 != tbl.s_GUILD_MODEL_3)
		{
			dictionary.Add(10, s_GUILD_MODEL_3);
		}
		if (s_GUILD_MODEL_4 != tbl.s_GUILD_MODEL_4)
		{
			dictionary.Add(11, s_GUILD_MODEL_4);
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
				n_GUILD_NUMBER = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_GUILD_CLASS = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_GUILD_INTEGRAL = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_GUILD_MONEY = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_GUILD_HOUSE = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_POWER_UPMAX = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_GUILD_BOX = Convert.ToInt32(item.Value);
				break;
			case 8:
				s_GUILD_MODEL_1 = item.Value.ToString();
				break;
			case 9:
				s_GUILD_MODEL_2 = item.Value.ToString();
				break;
			case 10:
				s_GUILD_MODEL_3 = item.Value.ToString();
				break;
			case 11:
				s_GUILD_MODEL_4 = item.Value.ToString();
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

	public bool EqualValue(GUILD_MAIN table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GUILD_NUMBER != table.n_GUILD_NUMBER)
		{
			return false;
		}
		if (n_GUILD_CLASS != table.n_GUILD_CLASS)
		{
			return false;
		}
		if (n_GUILD_INTEGRAL != table.n_GUILD_INTEGRAL)
		{
			return false;
		}
		if (n_GUILD_MONEY != table.n_GUILD_MONEY)
		{
			return false;
		}
		if (n_GUILD_HOUSE != table.n_GUILD_HOUSE)
		{
			return false;
		}
		if (n_POWER_UPMAX != table.n_POWER_UPMAX)
		{
			return false;
		}
		if (n_GUILD_BOX != table.n_GUILD_BOX)
		{
			return false;
		}
		if (s_GUILD_MODEL_1 != table.s_GUILD_MODEL_1)
		{
			return false;
		}
		if (s_GUILD_MODEL_2 != table.s_GUILD_MODEL_2)
		{
			return false;
		}
		if (s_GUILD_MODEL_3 != table.s_GUILD_MODEL_3)
		{
			return false;
		}
		if (s_GUILD_MODEL_4 != table.s_GUILD_MODEL_4)
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
		binaryWriter.Write(n_GUILD_NUMBER);
		binaryWriter.Write(n_GUILD_CLASS);
		binaryWriter.Write(n_GUILD_INTEGRAL);
		binaryWriter.Write(n_GUILD_MONEY);
		binaryWriter.Write(n_GUILD_HOUSE);
		binaryWriter.Write(n_POWER_UPMAX);
		binaryWriter.Write(n_GUILD_BOX);
		binaryWriter.WriteExString(s_GUILD_MODEL_1);
		binaryWriter.WriteExString(s_GUILD_MODEL_2);
		binaryWriter.WriteExString(s_GUILD_MODEL_3);
		binaryWriter.WriteExString(s_GUILD_MODEL_4);
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
		n_GUILD_NUMBER = binaryReader.ReadInt32();
		n_GUILD_CLASS = binaryReader.ReadInt32();
		n_GUILD_INTEGRAL = binaryReader.ReadInt32();
		n_GUILD_MONEY = binaryReader.ReadInt32();
		n_GUILD_HOUSE = binaryReader.ReadInt32();
		n_POWER_UPMAX = binaryReader.ReadInt32();
		n_GUILD_BOX = binaryReader.ReadInt32();
		s_GUILD_MODEL_1 = binaryReader.ReadExString();
		s_GUILD_MODEL_2 = binaryReader.ReadExString();
		s_GUILD_MODEL_3 = binaryReader.ReadExString();
		s_GUILD_MODEL_4 = binaryReader.ReadExString();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
