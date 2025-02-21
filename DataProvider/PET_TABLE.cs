using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class PET_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		s_NAME,
		s_ICON,
		s_MODEL,
		n_RARITY,
		s_PIVOT,
		n_MODE,
		n_TYPE,
		f_PARAM_HP,
		f_PARAM_ATK,
		f_PARAM_DEF,
		n_UNLOCK_ID,
		n_UNLOCK_COUNT,
		n_ENABLE_FLAG,
		n_FUSION_HP,
		n_FUSION_ATK,
		n_FUSION_DEF,
		n_FUSION_MATERIAL,
		n_SKILL_0,
		n_SKILL_1,
		n_SKILL_2,
		n_SKILL_3,
		n_SKILL_4,
		n_SKILL_5,
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
	public string s_PIVOT { get; set; }

	[Preserve]
	public int n_MODE { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public float f_PARAM_HP { get; set; }

	[Preserve]
	public float f_PARAM_ATK { get; set; }

	[Preserve]
	public float f_PARAM_DEF { get; set; }

	[Preserve]
	public int n_UNLOCK_ID { get; set; }

	[Preserve]
	public int n_UNLOCK_COUNT { get; set; }

	[Preserve]
	public int n_ENABLE_FLAG { get; set; }

	[Preserve]
	public int n_FUSION_HP { get; set; }

	[Preserve]
	public int n_FUSION_ATK { get; set; }

	[Preserve]
	public int n_FUSION_DEF { get; set; }

	[Preserve]
	public int n_FUSION_MATERIAL { get; set; }

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
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string w_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(PET_TABLE tbl)
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
		if (s_PIVOT != tbl.s_PIVOT)
		{
			dictionary.Add(5, s_PIVOT);
		}
		if (n_MODE != tbl.n_MODE)
		{
			dictionary.Add(6, n_MODE);
		}
		if (n_TYPE != tbl.n_TYPE)
		{
			dictionary.Add(7, n_TYPE);
		}
		if (f_PARAM_HP != tbl.f_PARAM_HP)
		{
			dictionary.Add(8, f_PARAM_HP);
		}
		if (f_PARAM_ATK != tbl.f_PARAM_ATK)
		{
			dictionary.Add(9, f_PARAM_ATK);
		}
		if (f_PARAM_DEF != tbl.f_PARAM_DEF)
		{
			dictionary.Add(10, f_PARAM_DEF);
		}
		if (n_UNLOCK_ID != tbl.n_UNLOCK_ID)
		{
			dictionary.Add(11, n_UNLOCK_ID);
		}
		if (n_UNLOCK_COUNT != tbl.n_UNLOCK_COUNT)
		{
			dictionary.Add(12, n_UNLOCK_COUNT);
		}
		if (n_ENABLE_FLAG != tbl.n_ENABLE_FLAG)
		{
			dictionary.Add(13, n_ENABLE_FLAG);
		}
		if (n_FUSION_HP != tbl.n_FUSION_HP)
		{
			dictionary.Add(14, n_FUSION_HP);
		}
		if (n_FUSION_ATK != tbl.n_FUSION_ATK)
		{
			dictionary.Add(15, n_FUSION_ATK);
		}
		if (n_FUSION_DEF != tbl.n_FUSION_DEF)
		{
			dictionary.Add(16, n_FUSION_DEF);
		}
		if (n_FUSION_MATERIAL != tbl.n_FUSION_MATERIAL)
		{
			dictionary.Add(17, n_FUSION_MATERIAL);
		}
		if (n_SKILL_0 != tbl.n_SKILL_0)
		{
			dictionary.Add(18, n_SKILL_0);
		}
		if (n_SKILL_1 != tbl.n_SKILL_1)
		{
			dictionary.Add(19, n_SKILL_1);
		}
		if (n_SKILL_2 != tbl.n_SKILL_2)
		{
			dictionary.Add(20, n_SKILL_2);
		}
		if (n_SKILL_3 != tbl.n_SKILL_3)
		{
			dictionary.Add(21, n_SKILL_3);
		}
		if (n_SKILL_4 != tbl.n_SKILL_4)
		{
			dictionary.Add(22, n_SKILL_4);
		}
		if (n_SKILL_5 != tbl.n_SKILL_5)
		{
			dictionary.Add(23, n_SKILL_5);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(24, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(25, s_END_VERSION);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(26, w_NAME);
		}
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(27, w_TIP);
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
				s_PIVOT = item.Value.ToString();
				break;
			case 6:
				n_MODE = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_TYPE = Convert.ToInt32(item.Value);
				break;
			case 8:
				f_PARAM_HP = Convert.ToSingle(item.Value);
				break;
			case 9:
				f_PARAM_ATK = Convert.ToSingle(item.Value);
				break;
			case 10:
				f_PARAM_DEF = Convert.ToSingle(item.Value);
				break;
			case 11:
				n_UNLOCK_ID = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_UNLOCK_COUNT = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_ENABLE_FLAG = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_FUSION_HP = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_FUSION_ATK = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_FUSION_DEF = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_FUSION_MATERIAL = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_SKILL_0 = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_SKILL_1 = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_SKILL_2 = Convert.ToInt32(item.Value);
				break;
			case 21:
				n_SKILL_3 = Convert.ToInt32(item.Value);
				break;
			case 22:
				n_SKILL_4 = Convert.ToInt32(item.Value);
				break;
			case 23:
				n_SKILL_5 = Convert.ToInt32(item.Value);
				break;
			case 24:
				s_START_VERSION = item.Value.ToString();
				break;
			case 25:
				s_END_VERSION = item.Value.ToString();
				break;
			case 26:
				w_NAME = item.Value.ToString();
				break;
			case 27:
				w_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(PET_TABLE table)
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
		if (s_PIVOT != table.s_PIVOT)
		{
			return false;
		}
		if (n_MODE != table.n_MODE)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (f_PARAM_HP != table.f_PARAM_HP)
		{
			return false;
		}
		if (f_PARAM_ATK != table.f_PARAM_ATK)
		{
			return false;
		}
		if (f_PARAM_DEF != table.f_PARAM_DEF)
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
		if (n_ENABLE_FLAG != table.n_ENABLE_FLAG)
		{
			return false;
		}
		if (n_FUSION_HP != table.n_FUSION_HP)
		{
			return false;
		}
		if (n_FUSION_ATK != table.n_FUSION_ATK)
		{
			return false;
		}
		if (n_FUSION_DEF != table.n_FUSION_DEF)
		{
			return false;
		}
		if (n_FUSION_MATERIAL != table.n_FUSION_MATERIAL)
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
		binaryWriter.WriteExString(s_PIVOT);
		binaryWriter.Write(n_MODE);
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(f_PARAM_HP);
		binaryWriter.Write(f_PARAM_ATK);
		binaryWriter.Write(f_PARAM_DEF);
		binaryWriter.Write(n_UNLOCK_ID);
		binaryWriter.Write(n_UNLOCK_COUNT);
		binaryWriter.Write(n_ENABLE_FLAG);
		binaryWriter.Write(n_FUSION_HP);
		binaryWriter.Write(n_FUSION_ATK);
		binaryWriter.Write(n_FUSION_DEF);
		binaryWriter.Write(n_FUSION_MATERIAL);
		binaryWriter.Write(n_SKILL_0);
		binaryWriter.Write(n_SKILL_1);
		binaryWriter.Write(n_SKILL_2);
		binaryWriter.Write(n_SKILL_3);
		binaryWriter.Write(n_SKILL_4);
		binaryWriter.Write(n_SKILL_5);
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
		s_PIVOT = binaryReader.ReadExString();
		n_MODE = binaryReader.ReadInt32();
		n_TYPE = binaryReader.ReadInt32();
		f_PARAM_HP = binaryReader.ReadSingle();
		f_PARAM_ATK = binaryReader.ReadSingle();
		f_PARAM_DEF = binaryReader.ReadSingle();
		n_UNLOCK_ID = binaryReader.ReadInt32();
		n_UNLOCK_COUNT = binaryReader.ReadInt32();
		n_ENABLE_FLAG = binaryReader.ReadInt32();
		n_FUSION_HP = binaryReader.ReadInt32();
		n_FUSION_ATK = binaryReader.ReadInt32();
		n_FUSION_DEF = binaryReader.ReadInt32();
		n_FUSION_MATERIAL = binaryReader.ReadInt32();
		n_SKILL_0 = binaryReader.ReadInt32();
		n_SKILL_1 = binaryReader.ReadInt32();
		n_SKILL_2 = binaryReader.ReadInt32();
		n_SKILL_3 = binaryReader.ReadInt32();
		n_SKILL_4 = binaryReader.ReadInt32();
		n_SKILL_5 = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		w_NAME = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
	}
}
