using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class WEAPON_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		n_SUB_TYPE,
		s_NAME,
		n_RARITY,
		n_STAR,
		s_MODEL,
		s_ICON,
		n_UPGRADE,
		n_SPEED,
		n_UNLOCK_ID,
		n_UNLOCK_COUNT,
		f_PARAM,
		n_ENABLE_FLAG,
		n_SUB_LINK,
		s_WEAPON_PIVOT,
		n_SKILL,
		n_PASSIVE_1,
		n_PASSIVE_UNLOCK1,
		n_PASSIVE_MATERIAL1,
		n_PASSIVE_2,
		n_PASSIVE_UNLOCK2,
		n_PASSIVE_MATERIAL2,
		n_PASSIVE_3,
		n_PASSIVE_UNLOCK3,
		n_PASSIVE_MATERIAL3,
		n_PASSIVE_4,
		n_PASSIVE_UNLOCK4,
		n_PASSIVE_MATERIAL4,
		n_PASSIVE_5,
		n_PASSIVE_UNLOCK5,
		n_PASSIVE_MATERIAL5,
		n_PASSIVE_6,
		n_PASSIVE_UNLOCK6,
		n_PASSIVE_MATERIAL6,
		n_DIVE,
		n_DIVE_UNLOCK,
		n_DIVE_MATERIAL,
		n_RECORD_BATTLE,
		n_RECORD_EXPLORE,
		n_RECORD_ACTION,
		s_START_VERSION,
		s_END_VERSION,
		w_NAME,
		w_TIP
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_SUB_TYPE { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public int n_RARITY { get; set; }

	[Preserve]
	public int n_STAR { get; set; }

	[Preserve]
	public string s_MODEL { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public int n_UPGRADE { get; set; }

	[Preserve]
	public int n_SPEED { get; set; }

	[Preserve]
	public int n_UNLOCK_ID { get; set; }

	[Preserve]
	public int n_UNLOCK_COUNT { get; set; }

	[Preserve]
	public float f_PARAM { get; set; }

	[Preserve]
	public int n_ENABLE_FLAG { get; set; }

	[Preserve]
	public int n_SUB_LINK { get; set; }

	[Preserve]
	public string s_WEAPON_PIVOT { get; set; }

	[Preserve]
	public int n_SKILL { get; set; }

	[Preserve]
	public int n_PASSIVE_1 { get; set; }

	[Preserve]
	public int n_PASSIVE_UNLOCK1 { get; set; }

	[Preserve]
	public int n_PASSIVE_MATERIAL1 { get; set; }

	[Preserve]
	public int n_PASSIVE_2 { get; set; }

	[Preserve]
	public int n_PASSIVE_UNLOCK2 { get; set; }

	[Preserve]
	public int n_PASSIVE_MATERIAL2 { get; set; }

	[Preserve]
	public int n_PASSIVE_3 { get; set; }

	[Preserve]
	public int n_PASSIVE_UNLOCK3 { get; set; }

	[Preserve]
	public int n_PASSIVE_MATERIAL3 { get; set; }

	[Preserve]
	public int n_PASSIVE_4 { get; set; }

	[Preserve]
	public int n_PASSIVE_UNLOCK4 { get; set; }

	[Preserve]
	public int n_PASSIVE_MATERIAL4 { get; set; }

	[Preserve]
	public int n_PASSIVE_5 { get; set; }

	[Preserve]
	public int n_PASSIVE_UNLOCK5 { get; set; }

	[Preserve]
	public int n_PASSIVE_MATERIAL5 { get; set; }

	[Preserve]
	public int n_PASSIVE_6 { get; set; }

	[Preserve]
	public int n_PASSIVE_UNLOCK6 { get; set; }

	[Preserve]
	public int n_PASSIVE_MATERIAL6 { get; set; }

	[Preserve]
	public int n_DIVE { get; set; }

	[Preserve]
	public int n_DIVE_UNLOCK { get; set; }

	[Preserve]
	public int n_DIVE_MATERIAL { get; set; }

	[Preserve]
	public int n_RECORD_BATTLE { get; set; }

	[Preserve]
	public int n_RECORD_EXPLORE { get; set; }

	[Preserve]
	public int n_RECORD_ACTION { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string w_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(WEAPON_TABLE tbl)
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
		if (n_SUB_TYPE != tbl.n_SUB_TYPE)
		{
			dictionary.Add(2, n_SUB_TYPE);
		}
		if (s_NAME != tbl.s_NAME)
		{
			dictionary.Add(3, s_NAME);
		}
		if (n_RARITY != tbl.n_RARITY)
		{
			dictionary.Add(4, n_RARITY);
		}
		if (n_STAR != tbl.n_STAR)
		{
			dictionary.Add(5, n_STAR);
		}
		if (s_MODEL != tbl.s_MODEL)
		{
			dictionary.Add(6, s_MODEL);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(7, s_ICON);
		}
		if (n_UPGRADE != tbl.n_UPGRADE)
		{
			dictionary.Add(8, n_UPGRADE);
		}
		if (n_SPEED != tbl.n_SPEED)
		{
			dictionary.Add(9, n_SPEED);
		}
		if (n_UNLOCK_ID != tbl.n_UNLOCK_ID)
		{
			dictionary.Add(10, n_UNLOCK_ID);
		}
		if (n_UNLOCK_COUNT != tbl.n_UNLOCK_COUNT)
		{
			dictionary.Add(11, n_UNLOCK_COUNT);
		}
		if (f_PARAM != tbl.f_PARAM)
		{
			dictionary.Add(12, f_PARAM);
		}
		if (n_ENABLE_FLAG != tbl.n_ENABLE_FLAG)
		{
			dictionary.Add(13, n_ENABLE_FLAG);
		}
		if (n_SUB_LINK != tbl.n_SUB_LINK)
		{
			dictionary.Add(14, n_SUB_LINK);
		}
		if (s_WEAPON_PIVOT != tbl.s_WEAPON_PIVOT)
		{
			dictionary.Add(15, s_WEAPON_PIVOT);
		}
		if (n_SKILL != tbl.n_SKILL)
		{
			dictionary.Add(16, n_SKILL);
		}
		if (n_PASSIVE_1 != tbl.n_PASSIVE_1)
		{
			dictionary.Add(17, n_PASSIVE_1);
		}
		if (n_PASSIVE_UNLOCK1 != tbl.n_PASSIVE_UNLOCK1)
		{
			dictionary.Add(18, n_PASSIVE_UNLOCK1);
		}
		if (n_PASSIVE_MATERIAL1 != tbl.n_PASSIVE_MATERIAL1)
		{
			dictionary.Add(19, n_PASSIVE_MATERIAL1);
		}
		if (n_PASSIVE_2 != tbl.n_PASSIVE_2)
		{
			dictionary.Add(20, n_PASSIVE_2);
		}
		if (n_PASSIVE_UNLOCK2 != tbl.n_PASSIVE_UNLOCK2)
		{
			dictionary.Add(21, n_PASSIVE_UNLOCK2);
		}
		if (n_PASSIVE_MATERIAL2 != tbl.n_PASSIVE_MATERIAL2)
		{
			dictionary.Add(22, n_PASSIVE_MATERIAL2);
		}
		if (n_PASSIVE_3 != tbl.n_PASSIVE_3)
		{
			dictionary.Add(23, n_PASSIVE_3);
		}
		if (n_PASSIVE_UNLOCK3 != tbl.n_PASSIVE_UNLOCK3)
		{
			dictionary.Add(24, n_PASSIVE_UNLOCK3);
		}
		if (n_PASSIVE_MATERIAL3 != tbl.n_PASSIVE_MATERIAL3)
		{
			dictionary.Add(25, n_PASSIVE_MATERIAL3);
		}
		if (n_PASSIVE_4 != tbl.n_PASSIVE_4)
		{
			dictionary.Add(26, n_PASSIVE_4);
		}
		if (n_PASSIVE_UNLOCK4 != tbl.n_PASSIVE_UNLOCK4)
		{
			dictionary.Add(27, n_PASSIVE_UNLOCK4);
		}
		if (n_PASSIVE_MATERIAL4 != tbl.n_PASSIVE_MATERIAL4)
		{
			dictionary.Add(28, n_PASSIVE_MATERIAL4);
		}
		if (n_PASSIVE_5 != tbl.n_PASSIVE_5)
		{
			dictionary.Add(29, n_PASSIVE_5);
		}
		if (n_PASSIVE_UNLOCK5 != tbl.n_PASSIVE_UNLOCK5)
		{
			dictionary.Add(30, n_PASSIVE_UNLOCK5);
		}
		if (n_PASSIVE_MATERIAL5 != tbl.n_PASSIVE_MATERIAL5)
		{
			dictionary.Add(31, n_PASSIVE_MATERIAL5);
		}
		if (n_PASSIVE_6 != tbl.n_PASSIVE_6)
		{
			dictionary.Add(32, n_PASSIVE_6);
		}
		if (n_PASSIVE_UNLOCK6 != tbl.n_PASSIVE_UNLOCK6)
		{
			dictionary.Add(33, n_PASSIVE_UNLOCK6);
		}
		if (n_PASSIVE_MATERIAL6 != tbl.n_PASSIVE_MATERIAL6)
		{
			dictionary.Add(34, n_PASSIVE_MATERIAL6);
		}
		if (n_DIVE != tbl.n_DIVE)
		{
			dictionary.Add(35, n_DIVE);
		}
		if (n_DIVE_UNLOCK != tbl.n_DIVE_UNLOCK)
		{
			dictionary.Add(36, n_DIVE_UNLOCK);
		}
		if (n_DIVE_MATERIAL != tbl.n_DIVE_MATERIAL)
		{
			dictionary.Add(37, n_DIVE_MATERIAL);
		}
		if (n_RECORD_BATTLE != tbl.n_RECORD_BATTLE)
		{
			dictionary.Add(38, n_RECORD_BATTLE);
		}
		if (n_RECORD_EXPLORE != tbl.n_RECORD_EXPLORE)
		{
			dictionary.Add(39, n_RECORD_EXPLORE);
		}
		if (n_RECORD_ACTION != tbl.n_RECORD_ACTION)
		{
			dictionary.Add(40, n_RECORD_ACTION);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(41, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(42, s_END_VERSION);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(43, w_NAME);
		}
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(44, w_TIP);
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
				n_SUB_TYPE = Convert.ToInt32(item.Value);
				break;
			case 3:
				s_NAME = item.Value.ToString();
				break;
			case 4:
				n_RARITY = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_STAR = Convert.ToInt32(item.Value);
				break;
			case 6:
				s_MODEL = item.Value.ToString();
				break;
			case 7:
				s_ICON = item.Value.ToString();
				break;
			case 8:
				n_UPGRADE = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_SPEED = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_UNLOCK_ID = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_UNLOCK_COUNT = Convert.ToInt32(item.Value);
				break;
			case 12:
				f_PARAM = Convert.ToSingle(item.Value);
				break;
			case 13:
				n_ENABLE_FLAG = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_SUB_LINK = Convert.ToInt32(item.Value);
				break;
			case 15:
				s_WEAPON_PIVOT = item.Value.ToString();
				break;
			case 16:
				n_SKILL = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_PASSIVE_1 = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_PASSIVE_UNLOCK1 = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_PASSIVE_MATERIAL1 = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_PASSIVE_2 = Convert.ToInt32(item.Value);
				break;
			case 21:
				n_PASSIVE_UNLOCK2 = Convert.ToInt32(item.Value);
				break;
			case 22:
				n_PASSIVE_MATERIAL2 = Convert.ToInt32(item.Value);
				break;
			case 23:
				n_PASSIVE_3 = Convert.ToInt32(item.Value);
				break;
			case 24:
				n_PASSIVE_UNLOCK3 = Convert.ToInt32(item.Value);
				break;
			case 25:
				n_PASSIVE_MATERIAL3 = Convert.ToInt32(item.Value);
				break;
			case 26:
				n_PASSIVE_4 = Convert.ToInt32(item.Value);
				break;
			case 27:
				n_PASSIVE_UNLOCK4 = Convert.ToInt32(item.Value);
				break;
			case 28:
				n_PASSIVE_MATERIAL4 = Convert.ToInt32(item.Value);
				break;
			case 29:
				n_PASSIVE_5 = Convert.ToInt32(item.Value);
				break;
			case 30:
				n_PASSIVE_UNLOCK5 = Convert.ToInt32(item.Value);
				break;
			case 31:
				n_PASSIVE_MATERIAL5 = Convert.ToInt32(item.Value);
				break;
			case 32:
				n_PASSIVE_6 = Convert.ToInt32(item.Value);
				break;
			case 33:
				n_PASSIVE_UNLOCK6 = Convert.ToInt32(item.Value);
				break;
			case 34:
				n_PASSIVE_MATERIAL6 = Convert.ToInt32(item.Value);
				break;
			case 35:
				n_DIVE = Convert.ToInt32(item.Value);
				break;
			case 36:
				n_DIVE_UNLOCK = Convert.ToInt32(item.Value);
				break;
			case 37:
				n_DIVE_MATERIAL = Convert.ToInt32(item.Value);
				break;
			case 38:
				n_RECORD_BATTLE = Convert.ToInt32(item.Value);
				break;
			case 39:
				n_RECORD_EXPLORE = Convert.ToInt32(item.Value);
				break;
			case 40:
				n_RECORD_ACTION = Convert.ToInt32(item.Value);
				break;
			case 41:
				s_START_VERSION = item.Value.ToString();
				break;
			case 42:
				s_END_VERSION = item.Value.ToString();
				break;
			case 43:
				w_NAME = item.Value.ToString();
				break;
			case 44:
				w_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(WEAPON_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_SUB_TYPE != table.n_SUB_TYPE)
		{
			return false;
		}
		if (s_NAME != table.s_NAME)
		{
			return false;
		}
		if (n_RARITY != table.n_RARITY)
		{
			return false;
		}
		if (n_STAR != table.n_STAR)
		{
			return false;
		}
		if (s_MODEL != table.s_MODEL)
		{
			return false;
		}
		if (s_ICON != table.s_ICON)
		{
			return false;
		}
		if (n_UPGRADE != table.n_UPGRADE)
		{
			return false;
		}
		if (n_SPEED != table.n_SPEED)
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
		if (f_PARAM != table.f_PARAM)
		{
			return false;
		}
		if (n_ENABLE_FLAG != table.n_ENABLE_FLAG)
		{
			return false;
		}
		if (n_SUB_LINK != table.n_SUB_LINK)
		{
			return false;
		}
		if (s_WEAPON_PIVOT != table.s_WEAPON_PIVOT)
		{
			return false;
		}
		if (n_SKILL != table.n_SKILL)
		{
			return false;
		}
		if (n_PASSIVE_1 != table.n_PASSIVE_1)
		{
			return false;
		}
		if (n_PASSIVE_UNLOCK1 != table.n_PASSIVE_UNLOCK1)
		{
			return false;
		}
		if (n_PASSIVE_MATERIAL1 != table.n_PASSIVE_MATERIAL1)
		{
			return false;
		}
		if (n_PASSIVE_2 != table.n_PASSIVE_2)
		{
			return false;
		}
		if (n_PASSIVE_UNLOCK2 != table.n_PASSIVE_UNLOCK2)
		{
			return false;
		}
		if (n_PASSIVE_MATERIAL2 != table.n_PASSIVE_MATERIAL2)
		{
			return false;
		}
		if (n_PASSIVE_3 != table.n_PASSIVE_3)
		{
			return false;
		}
		if (n_PASSIVE_UNLOCK3 != table.n_PASSIVE_UNLOCK3)
		{
			return false;
		}
		if (n_PASSIVE_MATERIAL3 != table.n_PASSIVE_MATERIAL3)
		{
			return false;
		}
		if (n_PASSIVE_4 != table.n_PASSIVE_4)
		{
			return false;
		}
		if (n_PASSIVE_UNLOCK4 != table.n_PASSIVE_UNLOCK4)
		{
			return false;
		}
		if (n_PASSIVE_MATERIAL4 != table.n_PASSIVE_MATERIAL4)
		{
			return false;
		}
		if (n_PASSIVE_5 != table.n_PASSIVE_5)
		{
			return false;
		}
		if (n_PASSIVE_UNLOCK5 != table.n_PASSIVE_UNLOCK5)
		{
			return false;
		}
		if (n_PASSIVE_MATERIAL5 != table.n_PASSIVE_MATERIAL5)
		{
			return false;
		}
		if (n_PASSIVE_6 != table.n_PASSIVE_6)
		{
			return false;
		}
		if (n_PASSIVE_UNLOCK6 != table.n_PASSIVE_UNLOCK6)
		{
			return false;
		}
		if (n_PASSIVE_MATERIAL6 != table.n_PASSIVE_MATERIAL6)
		{
			return false;
		}
		if (n_DIVE != table.n_DIVE)
		{
			return false;
		}
		if (n_DIVE_UNLOCK != table.n_DIVE_UNLOCK)
		{
			return false;
		}
		if (n_DIVE_MATERIAL != table.n_DIVE_MATERIAL)
		{
			return false;
		}
		if (n_RECORD_BATTLE != table.n_RECORD_BATTLE)
		{
			return false;
		}
		if (n_RECORD_EXPLORE != table.n_RECORD_EXPLORE)
		{
			return false;
		}
		if (n_RECORD_ACTION != table.n_RECORD_ACTION)
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
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_SUB_TYPE);
		binaryWriter.WriteExString(s_NAME);
		binaryWriter.Write(n_RARITY);
		binaryWriter.Write(n_STAR);
		binaryWriter.WriteExString(s_MODEL);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.Write(n_UPGRADE);
		binaryWriter.Write(n_SPEED);
		binaryWriter.Write(n_UNLOCK_ID);
		binaryWriter.Write(n_UNLOCK_COUNT);
		binaryWriter.Write(f_PARAM);
		binaryWriter.Write(n_ENABLE_FLAG);
		binaryWriter.Write(n_SUB_LINK);
		binaryWriter.WriteExString(s_WEAPON_PIVOT);
		binaryWriter.Write(n_SKILL);
		binaryWriter.Write(n_PASSIVE_1);
		binaryWriter.Write(n_PASSIVE_UNLOCK1);
		binaryWriter.Write(n_PASSIVE_MATERIAL1);
		binaryWriter.Write(n_PASSIVE_2);
		binaryWriter.Write(n_PASSIVE_UNLOCK2);
		binaryWriter.Write(n_PASSIVE_MATERIAL2);
		binaryWriter.Write(n_PASSIVE_3);
		binaryWriter.Write(n_PASSIVE_UNLOCK3);
		binaryWriter.Write(n_PASSIVE_MATERIAL3);
		binaryWriter.Write(n_PASSIVE_4);
		binaryWriter.Write(n_PASSIVE_UNLOCK4);
		binaryWriter.Write(n_PASSIVE_MATERIAL4);
		binaryWriter.Write(n_PASSIVE_5);
		binaryWriter.Write(n_PASSIVE_UNLOCK5);
		binaryWriter.Write(n_PASSIVE_MATERIAL5);
		binaryWriter.Write(n_PASSIVE_6);
		binaryWriter.Write(n_PASSIVE_UNLOCK6);
		binaryWriter.Write(n_PASSIVE_MATERIAL6);
		binaryWriter.Write(n_DIVE);
		binaryWriter.Write(n_DIVE_UNLOCK);
		binaryWriter.Write(n_DIVE_MATERIAL);
		binaryWriter.Write(n_RECORD_BATTLE);
		binaryWriter.Write(n_RECORD_EXPLORE);
		binaryWriter.Write(n_RECORD_ACTION);
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
		n_TYPE = binaryReader.ReadInt32();
		n_SUB_TYPE = binaryReader.ReadInt32();
		s_NAME = binaryReader.ReadExString();
		n_RARITY = binaryReader.ReadInt32();
		n_STAR = binaryReader.ReadInt32();
		s_MODEL = binaryReader.ReadExString();
		s_ICON = binaryReader.ReadExString();
		n_UPGRADE = binaryReader.ReadInt32();
		n_SPEED = binaryReader.ReadInt32();
		n_UNLOCK_ID = binaryReader.ReadInt32();
		n_UNLOCK_COUNT = binaryReader.ReadInt32();
		f_PARAM = binaryReader.ReadSingle();
		n_ENABLE_FLAG = binaryReader.ReadInt32();
		n_SUB_LINK = binaryReader.ReadInt32();
		s_WEAPON_PIVOT = binaryReader.ReadExString();
		n_SKILL = binaryReader.ReadInt32();
		n_PASSIVE_1 = binaryReader.ReadInt32();
		n_PASSIVE_UNLOCK1 = binaryReader.ReadInt32();
		n_PASSIVE_MATERIAL1 = binaryReader.ReadInt32();
		n_PASSIVE_2 = binaryReader.ReadInt32();
		n_PASSIVE_UNLOCK2 = binaryReader.ReadInt32();
		n_PASSIVE_MATERIAL2 = binaryReader.ReadInt32();
		n_PASSIVE_3 = binaryReader.ReadInt32();
		n_PASSIVE_UNLOCK3 = binaryReader.ReadInt32();
		n_PASSIVE_MATERIAL3 = binaryReader.ReadInt32();
		n_PASSIVE_4 = binaryReader.ReadInt32();
		n_PASSIVE_UNLOCK4 = binaryReader.ReadInt32();
		n_PASSIVE_MATERIAL4 = binaryReader.ReadInt32();
		n_PASSIVE_5 = binaryReader.ReadInt32();
		n_PASSIVE_UNLOCK5 = binaryReader.ReadInt32();
		n_PASSIVE_MATERIAL5 = binaryReader.ReadInt32();
		n_PASSIVE_6 = binaryReader.ReadInt32();
		n_PASSIVE_UNLOCK6 = binaryReader.ReadInt32();
		n_PASSIVE_MATERIAL6 = binaryReader.ReadInt32();
		n_DIVE = binaryReader.ReadInt32();
		n_DIVE_UNLOCK = binaryReader.ReadInt32();
		n_DIVE_MATERIAL = binaryReader.ReadInt32();
		n_RECORD_BATTLE = binaryReader.ReadInt32();
		n_RECORD_EXPLORE = binaryReader.ReadInt32();
		n_RECORD_ACTION = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		w_NAME = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
	}
}
