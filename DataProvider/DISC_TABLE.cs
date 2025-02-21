using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class DISC_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		s_NAME,
		s_ICON,
		s_MODEL,
		n_RARITY,
		n_WEAPON_TYPE,
		s_PIVOT,
		f_PARAM,
		n_UNLOCK_ID,
		n_UNLOCK_COUNT,
		n_ANALYSE_1,
		n_ANALYSE_2,
		n_ANALYSE_3,
		n_ANALYSE_4,
		n_ANALYSE_5,
		n_ENABLE_FLAG,
		n_SKILL_0,
		n_SKILL_1,
		n_SKILL_2,
		n_SKILL_3,
		n_SKILL_4,
		n_SKILL_5,
		n_SKILL_6,
		s_START_VERSION,
		s_END_VERSION,
		w_NAME,
		w_TIP
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public string s_MODEL { get; set; }

	[Preserve]
	public int n_RARITY { get; set; }

	[Preserve]
	public int n_WEAPON_TYPE { get; set; }

	[Preserve]
	public string s_PIVOT { get; set; }

	[Preserve]
	public float f_PARAM { get; set; }

	[Preserve]
	public int n_UNLOCK_ID { get; set; }

	[Preserve]
	public int n_UNLOCK_COUNT { get; set; }

	[Preserve]
	public int n_ANALYSE_1 { get; set; }

	[Preserve]
	public int n_ANALYSE_2 { get; set; }

	[Preserve]
	public int n_ANALYSE_3 { get; set; }

	[Preserve]
	public int n_ANALYSE_4 { get; set; }

	[Preserve]
	public int n_ANALYSE_5 { get; set; }

	[Preserve]
	public int n_ENABLE_FLAG { get; set; }

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

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string w_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(DISC_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (s_NAME != tbl.s_NAME)
		{
			dictionary.Add(1, s_NAME);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(2, s_ICON);
		}
		if (s_MODEL != tbl.s_MODEL)
		{
			dictionary.Add(3, s_MODEL);
		}
		if (n_RARITY != tbl.n_RARITY)
		{
			dictionary.Add(4, n_RARITY);
		}
		if (n_WEAPON_TYPE != tbl.n_WEAPON_TYPE)
		{
			dictionary.Add(5, n_WEAPON_TYPE);
		}
		if (s_PIVOT != tbl.s_PIVOT)
		{
			dictionary.Add(6, s_PIVOT);
		}
		if (f_PARAM != tbl.f_PARAM)
		{
			dictionary.Add(7, f_PARAM);
		}
		if (n_UNLOCK_ID != tbl.n_UNLOCK_ID)
		{
			dictionary.Add(8, n_UNLOCK_ID);
		}
		if (n_UNLOCK_COUNT != tbl.n_UNLOCK_COUNT)
		{
			dictionary.Add(9, n_UNLOCK_COUNT);
		}
		if (n_ANALYSE_1 != tbl.n_ANALYSE_1)
		{
			dictionary.Add(10, n_ANALYSE_1);
		}
		if (n_ANALYSE_2 != tbl.n_ANALYSE_2)
		{
			dictionary.Add(11, n_ANALYSE_2);
		}
		if (n_ANALYSE_3 != tbl.n_ANALYSE_3)
		{
			dictionary.Add(12, n_ANALYSE_3);
		}
		if (n_ANALYSE_4 != tbl.n_ANALYSE_4)
		{
			dictionary.Add(13, n_ANALYSE_4);
		}
		if (n_ANALYSE_5 != tbl.n_ANALYSE_5)
		{
			dictionary.Add(14, n_ANALYSE_5);
		}
		if (n_ENABLE_FLAG != tbl.n_ENABLE_FLAG)
		{
			dictionary.Add(15, n_ENABLE_FLAG);
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
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(25, w_NAME);
		}
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(26, w_TIP);
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
				s_NAME = item.Value.ToString();
				break;
			case 2:
				s_ICON = item.Value.ToString();
				break;
			case 3:
				s_MODEL = item.Value.ToString();
				break;
			case 4:
				n_RARITY = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_WEAPON_TYPE = Convert.ToInt32(item.Value);
				break;
			case 6:
				s_PIVOT = item.Value.ToString();
				break;
			case 7:
				f_PARAM = Convert.ToSingle(item.Value);
				break;
			case 8:
				n_UNLOCK_ID = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_UNLOCK_COUNT = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_ANALYSE_1 = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_ANALYSE_2 = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_ANALYSE_3 = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_ANALYSE_4 = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_ANALYSE_5 = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_ENABLE_FLAG = Convert.ToInt32(item.Value);
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
			case 25:
				w_NAME = item.Value.ToString();
				break;
			case 26:
				w_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(DISC_TABLE table)
	{
		if (n_ID != table.n_ID)
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
		if (s_MODEL != table.s_MODEL)
		{
			return false;
		}
		if (n_RARITY != table.n_RARITY)
		{
			return false;
		}
		if (n_WEAPON_TYPE != table.n_WEAPON_TYPE)
		{
			return false;
		}
		if (s_PIVOT != table.s_PIVOT)
		{
			return false;
		}
		if (f_PARAM != table.f_PARAM)
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
		if (n_ANALYSE_1 != table.n_ANALYSE_1)
		{
			return false;
		}
		if (n_ANALYSE_2 != table.n_ANALYSE_2)
		{
			return false;
		}
		if (n_ANALYSE_3 != table.n_ANALYSE_3)
		{
			return false;
		}
		if (n_ANALYSE_4 != table.n_ANALYSE_4)
		{
			return false;
		}
		if (n_ANALYSE_5 != table.n_ANALYSE_5)
		{
			return false;
		}
		if (n_ENABLE_FLAG != table.n_ENABLE_FLAG)
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
		if (w_NAME != table.w_NAME)
		{
			return false;
		}
		if (w_TIP != table.w_TIP)
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
		binaryWriter.WriteExString(s_NAME);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.WriteExString(s_MODEL);
		binaryWriter.Write(n_RARITY);
		binaryWriter.Write(n_WEAPON_TYPE);
		binaryWriter.WriteExString(s_PIVOT);
		binaryWriter.Write(f_PARAM);
		binaryWriter.Write(n_UNLOCK_ID);
		binaryWriter.Write(n_UNLOCK_COUNT);
		binaryWriter.Write(n_ANALYSE_1);
		binaryWriter.Write(n_ANALYSE_2);
		binaryWriter.Write(n_ANALYSE_3);
		binaryWriter.Write(n_ANALYSE_4);
		binaryWriter.Write(n_ANALYSE_5);
		binaryWriter.Write(n_ENABLE_FLAG);
		binaryWriter.Write(n_SKILL_0);
		binaryWriter.Write(n_SKILL_1);
		binaryWriter.Write(n_SKILL_2);
		binaryWriter.Write(n_SKILL_3);
		binaryWriter.Write(n_SKILL_4);
		binaryWriter.Write(n_SKILL_5);
		binaryWriter.Write(n_SKILL_6);
		binaryWriter.WriteExString(s_START_VERSION);
		binaryWriter.WriteExString(s_END_VERSION);
		binaryWriter.WriteExString(w_NAME);
		binaryWriter.WriteExString(w_TIP);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		s_NAME = binaryReader.ReadExString();
		s_ICON = binaryReader.ReadExString();
		s_MODEL = binaryReader.ReadExString();
		n_RARITY = binaryReader.ReadInt32();
		n_WEAPON_TYPE = binaryReader.ReadInt32();
		s_PIVOT = binaryReader.ReadExString();
		f_PARAM = binaryReader.ReadSingle();
		n_UNLOCK_ID = binaryReader.ReadInt32();
		n_UNLOCK_COUNT = binaryReader.ReadInt32();
		n_ANALYSE_1 = binaryReader.ReadInt32();
		n_ANALYSE_2 = binaryReader.ReadInt32();
		n_ANALYSE_3 = binaryReader.ReadInt32();
		n_ANALYSE_4 = binaryReader.ReadInt32();
		n_ANALYSE_5 = binaryReader.ReadInt32();
		n_ENABLE_FLAG = binaryReader.ReadInt32();
		n_SKILL_0 = binaryReader.ReadInt32();
		n_SKILL_1 = binaryReader.ReadInt32();
		n_SKILL_2 = binaryReader.ReadInt32();
		n_SKILL_3 = binaryReader.ReadInt32();
		n_SKILL_4 = binaryReader.ReadInt32();
		n_SKILL_5 = binaryReader.ReadInt32();
		n_SKILL_6 = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		w_NAME = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
	}
}
