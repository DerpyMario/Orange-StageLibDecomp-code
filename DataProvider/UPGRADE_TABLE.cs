using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class UPGRADE_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		n_LV,
		n_WEAPON_LV,
		n_PROF,
		n_MONEY,
		n_ATK,
		n_HP,
		n_CRI,
		n_HIT,
		n_LUK,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_LV { get; set; }

	[Preserve]
	public int n_WEAPON_LV { get; set; }

	[Preserve]
	public int n_PROF { get; set; }

	[Preserve]
	public int n_MONEY { get; set; }

	[Preserve]
	public int n_ATK { get; set; }

	[Preserve]
	public int n_HP { get; set; }

	[Preserve]
	public int n_CRI { get; set; }

	[Preserve]
	public int n_HIT { get; set; }

	[Preserve]
	public int n_LUK { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(UPGRADE_TABLE tbl)
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
		if (n_LV != tbl.n_LV)
		{
			dictionary.Add(2, n_LV);
		}
		if (n_WEAPON_LV != tbl.n_WEAPON_LV)
		{
			dictionary.Add(3, n_WEAPON_LV);
		}
		if (n_PROF != tbl.n_PROF)
		{
			dictionary.Add(4, n_PROF);
		}
		if (n_MONEY != tbl.n_MONEY)
		{
			dictionary.Add(5, n_MONEY);
		}
		if (n_ATK != tbl.n_ATK)
		{
			dictionary.Add(6, n_ATK);
		}
		if (n_HP != tbl.n_HP)
		{
			dictionary.Add(7, n_HP);
		}
		if (n_CRI != tbl.n_CRI)
		{
			dictionary.Add(8, n_CRI);
		}
		if (n_HIT != tbl.n_HIT)
		{
			dictionary.Add(9, n_HIT);
		}
		if (n_LUK != tbl.n_LUK)
		{
			dictionary.Add(10, n_LUK);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(11, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(12, s_END_VERSION);
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
				n_LV = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_WEAPON_LV = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_PROF = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_MONEY = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_ATK = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_HP = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_CRI = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_HIT = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_LUK = Convert.ToInt32(item.Value);
				break;
			case 11:
				s_START_VERSION = item.Value.ToString();
				break;
			case 12:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(UPGRADE_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (n_LV != table.n_LV)
		{
			return false;
		}
		if (n_WEAPON_LV != table.n_WEAPON_LV)
		{
			return false;
		}
		if (n_PROF != table.n_PROF)
		{
			return false;
		}
		if (n_MONEY != table.n_MONEY)
		{
			return false;
		}
		if (n_ATK != table.n_ATK)
		{
			return false;
		}
		if (n_HP != table.n_HP)
		{
			return false;
		}
		if (n_CRI != table.n_CRI)
		{
			return false;
		}
		if (n_HIT != table.n_HIT)
		{
			return false;
		}
		if (n_LUK != table.n_LUK)
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
		binaryWriter.Write(n_LV);
		binaryWriter.Write(n_WEAPON_LV);
		binaryWriter.Write(n_PROF);
		binaryWriter.Write(n_MONEY);
		binaryWriter.Write(n_ATK);
		binaryWriter.Write(n_HP);
		binaryWriter.Write(n_CRI);
		binaryWriter.Write(n_HIT);
		binaryWriter.Write(n_LUK);
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
		n_LV = binaryReader.ReadInt32();
		n_WEAPON_LV = binaryReader.ReadInt32();
		n_PROF = binaryReader.ReadInt32();
		n_MONEY = binaryReader.ReadInt32();
		n_ATK = binaryReader.ReadInt32();
		n_HP = binaryReader.ReadInt32();
		n_CRI = binaryReader.ReadInt32();
		n_HIT = binaryReader.ReadInt32();
		n_LUK = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
