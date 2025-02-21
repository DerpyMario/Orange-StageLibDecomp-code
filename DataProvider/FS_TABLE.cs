using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class FS_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_FS_ID,
		n_LV,
		s_NAME,
		s_ICON,
		n_RARITY,
		n_DEPTH,
		n_LOCATION,
		n_ATK,
		n_HP,
		n_DEF,
		n_MATERIAL,
		n_MONEY,
		n_UNLOCK_LV,
		n_UNLOCK_ID,
		n_UNLOCK_COUNT,
		n_SKILL_0,
		n_SKILL_1,
		n_SKILL_2,
		n_SKILL_3,
		n_SKILL_4,
		n_SKILL_5,
		n_SKILL_6,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_FS_ID { get; set; }

	[Preserve]
	public int n_LV { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public int n_RARITY { get; set; }

	[Preserve]
	public int n_DEPTH { get; set; }

	[Preserve]
	public int n_LOCATION { get; set; }

	[Preserve]
	public int n_ATK { get; set; }

	[Preserve]
	public int n_HP { get; set; }

	[Preserve]
	public int n_DEF { get; set; }

	[Preserve]
	public int n_MATERIAL { get; set; }

	[Preserve]
	public int n_MONEY { get; set; }

	[Preserve]
	public int n_UNLOCK_LV { get; set; }

	[Preserve]
	public int n_UNLOCK_ID { get; set; }

	[Preserve]
	public int n_UNLOCK_COUNT { get; set; }

	[Preserve]
	public int n_SKILL_0 { get; set; }

	[Preserve]
	public int n_SKILL_1 { get; set; }

	[Preserve]
	public int n_SKILL_2 { get; set; }

	[Preserve]
	public int n_SKILL_3 { get; set; }

	[Preserve]
	public int n_SKILL_4 { get; set; }

	[Preserve]
	public int n_SKILL_5 { get; set; }

	[Preserve]
	public int n_SKILL_6 { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(FS_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_FS_ID != tbl.n_FS_ID)
		{
			dictionary.Add(1, n_FS_ID);
		}
		if (n_LV != tbl.n_LV)
		{
			dictionary.Add(2, n_LV);
		}
		if (s_NAME != tbl.s_NAME)
		{
			dictionary.Add(3, s_NAME);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(4, s_ICON);
		}
		if (n_RARITY != tbl.n_RARITY)
		{
			dictionary.Add(5, n_RARITY);
		}
		if (n_DEPTH != tbl.n_DEPTH)
		{
			dictionary.Add(6, n_DEPTH);
		}
		if (n_LOCATION != tbl.n_LOCATION)
		{
			dictionary.Add(7, n_LOCATION);
		}
		if (n_ATK != tbl.n_ATK)
		{
			dictionary.Add(8, n_ATK);
		}
		if (n_HP != tbl.n_HP)
		{
			dictionary.Add(9, n_HP);
		}
		if (n_DEF != tbl.n_DEF)
		{
			dictionary.Add(10, n_DEF);
		}
		if (n_MATERIAL != tbl.n_MATERIAL)
		{
			dictionary.Add(11, n_MATERIAL);
		}
		if (n_MONEY != tbl.n_MONEY)
		{
			dictionary.Add(12, n_MONEY);
		}
		if (n_UNLOCK_LV != tbl.n_UNLOCK_LV)
		{
			dictionary.Add(13, n_UNLOCK_LV);
		}
		if (n_UNLOCK_ID != tbl.n_UNLOCK_ID)
		{
			dictionary.Add(14, n_UNLOCK_ID);
		}
		if (n_UNLOCK_COUNT != tbl.n_UNLOCK_COUNT)
		{
			dictionary.Add(15, n_UNLOCK_COUNT);
		}
		if (n_SKILL_0 != tbl.n_SKILL_0)
		{
			dictionary.Add(16, n_SKILL_0);
		}
		if (n_SKILL_1 != tbl.n_SKILL_1)
		{
			dictionary.Add(17, n_SKILL_1);
		}
		if (n_SKILL_2 != tbl.n_SKILL_2)
		{
			dictionary.Add(18, n_SKILL_2);
		}
		if (n_SKILL_3 != tbl.n_SKILL_3)
		{
			dictionary.Add(19, n_SKILL_3);
		}
		if (n_SKILL_4 != tbl.n_SKILL_4)
		{
			dictionary.Add(20, n_SKILL_4);
		}
		if (n_SKILL_5 != tbl.n_SKILL_5)
		{
			dictionary.Add(21, n_SKILL_5);
		}
		if (n_SKILL_6 != tbl.n_SKILL_6)
		{
			dictionary.Add(22, n_SKILL_6);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(23, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(24, s_END_VERSION);
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
				n_FS_ID = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_LV = Convert.ToInt32(item.Value);
				break;
			case 3:
				s_NAME = item.Value.ToString();
				break;
			case 4:
				s_ICON = item.Value.ToString();
				break;
			case 5:
				n_RARITY = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_DEPTH = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_LOCATION = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_ATK = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_HP = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_DEF = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_MATERIAL = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_MONEY = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_UNLOCK_LV = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_UNLOCK_ID = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_UNLOCK_COUNT = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_SKILL_0 = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_SKILL_1 = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_SKILL_2 = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_SKILL_3 = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_SKILL_4 = Convert.ToInt32(item.Value);
				break;
			case 21:
				n_SKILL_5 = Convert.ToInt32(item.Value);
				break;
			case 22:
				n_SKILL_6 = Convert.ToInt32(item.Value);
				break;
			case 23:
				s_START_VERSION = item.Value.ToString();
				break;
			case 24:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(FS_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_FS_ID != table.n_FS_ID)
		{
			return false;
		}
		if (n_LV != table.n_LV)
		{
			return false;
		}
		if (s_NAME != table.s_NAME)
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
		if (n_DEPTH != table.n_DEPTH)
		{
			return false;
		}
		if (n_LOCATION != table.n_LOCATION)
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
		if (n_DEF != table.n_DEF)
		{
			return false;
		}
		if (n_MATERIAL != table.n_MATERIAL)
		{
			return false;
		}
		if (n_MONEY != table.n_MONEY)
		{
			return false;
		}
		if (n_UNLOCK_LV != table.n_UNLOCK_LV)
		{
			return false;
		}
		if (n_UNLOCK_ID != table.n_UNLOCK_ID)
		{
			return false;
		}
		if (n_UNLOCK_COUNT != table.n_UNLOCK_COUNT)
		{
			return false;
		}
		if (n_SKILL_0 != table.n_SKILL_0)
		{
			return false;
		}
		if (n_SKILL_1 != table.n_SKILL_1)
		{
			return false;
		}
		if (n_SKILL_2 != table.n_SKILL_2)
		{
			return false;
		}
		if (n_SKILL_3 != table.n_SKILL_3)
		{
			return false;
		}
		if (n_SKILL_4 != table.n_SKILL_4)
		{
			return false;
		}
		if (n_SKILL_5 != table.n_SKILL_5)
		{
			return false;
		}
		if (n_SKILL_6 != table.n_SKILL_6)
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
		binaryWriter.Write(n_FS_ID);
		binaryWriter.Write(n_LV);
		binaryWriter.WriteExString(s_NAME);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.Write(n_RARITY);
		binaryWriter.Write(n_DEPTH);
		binaryWriter.Write(n_LOCATION);
		binaryWriter.Write(n_ATK);
		binaryWriter.Write(n_HP);
		binaryWriter.Write(n_DEF);
		binaryWriter.Write(n_MATERIAL);
		binaryWriter.Write(n_MONEY);
		binaryWriter.Write(n_UNLOCK_LV);
		binaryWriter.Write(n_UNLOCK_ID);
		binaryWriter.Write(n_UNLOCK_COUNT);
		binaryWriter.Write(n_SKILL_0);
		binaryWriter.Write(n_SKILL_1);
		binaryWriter.Write(n_SKILL_2);
		binaryWriter.Write(n_SKILL_3);
		binaryWriter.Write(n_SKILL_4);
		binaryWriter.Write(n_SKILL_5);
		binaryWriter.Write(n_SKILL_6);
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
		n_FS_ID = binaryReader.ReadInt32();
		n_LV = binaryReader.ReadInt32();
		s_NAME = binaryReader.ReadExString();
		s_ICON = binaryReader.ReadExString();
		n_RARITY = binaryReader.ReadInt32();
		n_DEPTH = binaryReader.ReadInt32();
		n_LOCATION = binaryReader.ReadInt32();
		n_ATK = binaryReader.ReadInt32();
		n_HP = binaryReader.ReadInt32();
		n_DEF = binaryReader.ReadInt32();
		n_MATERIAL = binaryReader.ReadInt32();
		n_MONEY = binaryReader.ReadInt32();
		n_UNLOCK_LV = binaryReader.ReadInt32();
		n_UNLOCK_ID = binaryReader.ReadInt32();
		n_UNLOCK_COUNT = binaryReader.ReadInt32();
		n_SKILL_0 = binaryReader.ReadInt32();
		n_SKILL_1 = binaryReader.ReadInt32();
		n_SKILL_2 = binaryReader.ReadInt32();
		n_SKILL_3 = binaryReader.ReadInt32();
		n_SKILL_4 = binaryReader.ReadInt32();
		n_SKILL_5 = binaryReader.ReadInt32();
		n_SKILL_6 = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
