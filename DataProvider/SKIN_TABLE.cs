using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class SKIN_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		n_SUBTYPE,
		n_MAINID,
		s_NAME,
		s_ICON,
		s_MODEL,
		s_MOTION,
		s_ANIMATOR,
		s_CHARA_PIVOT,
		n_RARITY,
		n_UNLOCK_ID,
		n_UNLOCK_COUNT,
		n_HP,
		n_ATK,
		n_DEF,
		s_START_VERSION,
		s_END_VERSION,
		w_NAME
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_SUBTYPE { get; set; }

	[Preserve]
	public int n_MAINID { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public string s_MODEL { get; set; }

	[Preserve]
	public string s_MOTION { get; set; }

	[Preserve]
	public string s_ANIMATOR { get; set; }

	[Preserve]
	public string s_CHARA_PIVOT { get; set; }

	[Preserve]
	public int n_RARITY { get; set; }

	[Preserve]
	public int n_UNLOCK_ID { get; set; }

	[Preserve]
	public int n_UNLOCK_COUNT { get; set; }

	[Preserve]
	public int n_HP { get; set; }

	[Preserve]
	public int n_ATK { get; set; }

	[Preserve]
	public int n_DEF { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(SKIN_TABLE tbl)
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
		if (n_SUBTYPE != tbl.n_SUBTYPE)
		{
			dictionary.Add(2, n_SUBTYPE);
		}
		if (n_MAINID != tbl.n_MAINID)
		{
			dictionary.Add(3, n_MAINID);
		}
		if (s_NAME != tbl.s_NAME)
		{
			dictionary.Add(4, s_NAME);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(5, s_ICON);
		}
		if (s_MODEL != tbl.s_MODEL)
		{
			dictionary.Add(6, s_MODEL);
		}
		if (s_MOTION != tbl.s_MOTION)
		{
			dictionary.Add(7, s_MOTION);
		}
		if (s_ANIMATOR != tbl.s_ANIMATOR)
		{
			dictionary.Add(8, s_ANIMATOR);
		}
		if (s_CHARA_PIVOT != tbl.s_CHARA_PIVOT)
		{
			dictionary.Add(9, s_CHARA_PIVOT);
		}
		if (n_RARITY != tbl.n_RARITY)
		{
			dictionary.Add(10, n_RARITY);
		}
		if (n_UNLOCK_ID != tbl.n_UNLOCK_ID)
		{
			dictionary.Add(11, n_UNLOCK_ID);
		}
		if (n_UNLOCK_COUNT != tbl.n_UNLOCK_COUNT)
		{
			dictionary.Add(12, n_UNLOCK_COUNT);
		}
		if (n_HP != tbl.n_HP)
		{
			dictionary.Add(13, n_HP);
		}
		if (n_ATK != tbl.n_ATK)
		{
			dictionary.Add(14, n_ATK);
		}
		if (n_DEF != tbl.n_DEF)
		{
			dictionary.Add(15, n_DEF);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(16, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(17, s_END_VERSION);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(18, w_NAME);
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
				n_SUBTYPE = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_MAINID = Convert.ToInt32(item.Value);
				break;
			case 4:
				s_NAME = item.Value.ToString();
				break;
			case 5:
				s_ICON = item.Value.ToString();
				break;
			case 6:
				s_MODEL = item.Value.ToString();
				break;
			case 7:
				s_MOTION = item.Value.ToString();
				break;
			case 8:
				s_ANIMATOR = item.Value.ToString();
				break;
			case 9:
				s_CHARA_PIVOT = item.Value.ToString();
				break;
			case 10:
				n_RARITY = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_UNLOCK_ID = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_UNLOCK_COUNT = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_HP = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_ATK = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_DEF = Convert.ToInt32(item.Value);
				break;
			case 16:
				s_START_VERSION = item.Value.ToString();
				break;
			case 17:
				s_END_VERSION = item.Value.ToString();
				break;
			case 18:
				w_NAME = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(SKIN_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_SUBTYPE != table.n_SUBTYPE)
		{
			return false;
		}
		if (n_MAINID != table.n_MAINID)
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
		if (s_MOTION != table.s_MOTION)
		{
			return false;
		}
		if (s_ANIMATOR != table.s_ANIMATOR)
		{
			return false;
		}
		if (s_CHARA_PIVOT != table.s_CHARA_PIVOT)
		{
			return false;
		}
		if (n_RARITY != table.n_RARITY)
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
		if (n_HP != table.n_HP)
		{
			return false;
		}
		if (n_ATK != table.n_ATK)
		{
			return false;
		}
		if (n_DEF != table.n_DEF)
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
		return true;
	}

	public string ConvertToString()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(n_ID);
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_SUBTYPE);
		binaryWriter.Write(n_MAINID);
		binaryWriter.WriteExString(s_NAME);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.WriteExString(s_MODEL);
		binaryWriter.WriteExString(s_MOTION);
		binaryWriter.WriteExString(s_ANIMATOR);
		binaryWriter.WriteExString(s_CHARA_PIVOT);
		binaryWriter.Write(n_RARITY);
		binaryWriter.Write(n_UNLOCK_ID);
		binaryWriter.Write(n_UNLOCK_COUNT);
		binaryWriter.Write(n_HP);
		binaryWriter.Write(n_ATK);
		binaryWriter.Write(n_DEF);
		binaryWriter.WriteExString(s_START_VERSION);
		binaryWriter.WriteExString(s_END_VERSION);
		binaryWriter.WriteExString(w_NAME);
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
		n_SUBTYPE = binaryReader.ReadInt32();
		n_MAINID = binaryReader.ReadInt32();
		s_NAME = binaryReader.ReadExString();
		s_ICON = binaryReader.ReadExString();
		s_MODEL = binaryReader.ReadExString();
		s_MOTION = binaryReader.ReadExString();
		s_ANIMATOR = binaryReader.ReadExString();
		s_CHARA_PIVOT = binaryReader.ReadExString();
		n_RARITY = binaryReader.ReadInt32();
		n_UNLOCK_ID = binaryReader.ReadInt32();
		n_UNLOCK_COUNT = binaryReader.ReadInt32();
		n_HP = binaryReader.ReadInt32();
		n_ATK = binaryReader.ReadInt32();
		n_DEF = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		w_NAME = binaryReader.ReadExString();
	}
}
