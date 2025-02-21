using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class EQUIP_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_PARTS,
		s_NAME,
		s_ICON,
		n_RARE,
		n_LV,
		n_DEF_MIN,
		n_DEF_MAX,
		n_HP_MIN,
		n_HP_MAX,
		n_LUK_MIN,
		n_LUK_MAX,
		n_DESTROY_MATERIAL,
		n_DESTROY_MONEY,
		n_UNLOCK_ID,
		n_UNLOCK_COUNT,
		s_START_VERSION,
		s_END_VERSION,
		w_NAME,
		w_TIP
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_PARTS { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public int n_RARE { get; set; }

	[Preserve]
	public int n_LV { get; set; }

	[Preserve]
	public int n_DEF_MIN { get; set; }

	[Preserve]
	public int n_DEF_MAX { get; set; }

	[Preserve]
	public int n_HP_MIN { get; set; }

	[Preserve]
	public int n_HP_MAX { get; set; }

	[Preserve]
	public int n_LUK_MIN { get; set; }

	[Preserve]
	public int n_LUK_MAX { get; set; }

	[Preserve]
	public int n_DESTROY_MATERIAL { get; set; }

	[Preserve]
	public int n_DESTROY_MONEY { get; set; }

	[Preserve]
	public int n_UNLOCK_ID { get; set; }

	[Preserve]
	public int n_UNLOCK_COUNT { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string w_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(EQUIP_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_PARTS != tbl.n_PARTS)
		{
			dictionary.Add(1, n_PARTS);
		}
		if (s_NAME != tbl.s_NAME)
		{
			dictionary.Add(2, s_NAME);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(3, s_ICON);
		}
		if (n_RARE != tbl.n_RARE)
		{
			dictionary.Add(4, n_RARE);
		}
		if (n_LV != tbl.n_LV)
		{
			dictionary.Add(5, n_LV);
		}
		if (n_DEF_MIN != tbl.n_DEF_MIN)
		{
			dictionary.Add(6, n_DEF_MIN);
		}
		if (n_DEF_MAX != tbl.n_DEF_MAX)
		{
			dictionary.Add(7, n_DEF_MAX);
		}
		if (n_HP_MIN != tbl.n_HP_MIN)
		{
			dictionary.Add(8, n_HP_MIN);
		}
		if (n_HP_MAX != tbl.n_HP_MAX)
		{
			dictionary.Add(9, n_HP_MAX);
		}
		if (n_LUK_MIN != tbl.n_LUK_MIN)
		{
			dictionary.Add(10, n_LUK_MIN);
		}
		if (n_LUK_MAX != tbl.n_LUK_MAX)
		{
			dictionary.Add(11, n_LUK_MAX);
		}
		if (n_DESTROY_MATERIAL != tbl.n_DESTROY_MATERIAL)
		{
			dictionary.Add(12, n_DESTROY_MATERIAL);
		}
		if (n_DESTROY_MONEY != tbl.n_DESTROY_MONEY)
		{
			dictionary.Add(13, n_DESTROY_MONEY);
		}
		if (n_UNLOCK_ID != tbl.n_UNLOCK_ID)
		{
			dictionary.Add(14, n_UNLOCK_ID);
		}
		if (n_UNLOCK_COUNT != tbl.n_UNLOCK_COUNT)
		{
			dictionary.Add(15, n_UNLOCK_COUNT);
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
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(19, w_TIP);
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
				n_PARTS = Convert.ToInt32(item.Value);
				break;
			case 2:
				s_NAME = item.Value.ToString();
				break;
			case 3:
				s_ICON = item.Value.ToString();
				break;
			case 4:
				n_RARE = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_LV = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_DEF_MIN = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_DEF_MAX = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_HP_MIN = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_HP_MAX = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_LUK_MIN = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_LUK_MAX = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_DESTROY_MATERIAL = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_DESTROY_MONEY = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_UNLOCK_ID = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_UNLOCK_COUNT = Convert.ToInt32(item.Value);
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
			case 19:
				w_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(EQUIP_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_PARTS != table.n_PARTS)
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
		if (n_RARE != table.n_RARE)
		{
			return false;
		}
		if (n_LV != table.n_LV)
		{
			return false;
		}
		if (n_DEF_MIN != table.n_DEF_MIN)
		{
			return false;
		}
		if (n_DEF_MAX != table.n_DEF_MAX)
		{
			return false;
		}
		if (n_HP_MIN != table.n_HP_MIN)
		{
			return false;
		}
		if (n_HP_MAX != table.n_HP_MAX)
		{
			return false;
		}
		if (n_LUK_MIN != table.n_LUK_MIN)
		{
			return false;
		}
		if (n_LUK_MAX != table.n_LUK_MAX)
		{
			return false;
		}
		if (n_DESTROY_MATERIAL != table.n_DESTROY_MATERIAL)
		{
			return false;
		}
		if (n_DESTROY_MONEY != table.n_DESTROY_MONEY)
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
		binaryWriter.Write(n_PARTS);
		binaryWriter.WriteExString(s_NAME);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.Write(n_RARE);
		binaryWriter.Write(n_LV);
		binaryWriter.Write(n_DEF_MIN);
		binaryWriter.Write(n_DEF_MAX);
		binaryWriter.Write(n_HP_MIN);
		binaryWriter.Write(n_HP_MAX);
		binaryWriter.Write(n_LUK_MIN);
		binaryWriter.Write(n_LUK_MAX);
		binaryWriter.Write(n_DESTROY_MATERIAL);
		binaryWriter.Write(n_DESTROY_MONEY);
		binaryWriter.Write(n_UNLOCK_ID);
		binaryWriter.Write(n_UNLOCK_COUNT);
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
		n_PARTS = binaryReader.ReadInt32();
		s_NAME = binaryReader.ReadExString();
		s_ICON = binaryReader.ReadExString();
		n_RARE = binaryReader.ReadInt32();
		n_LV = binaryReader.ReadInt32();
		n_DEF_MIN = binaryReader.ReadInt32();
		n_DEF_MAX = binaryReader.ReadInt32();
		n_HP_MIN = binaryReader.ReadInt32();
		n_HP_MAX = binaryReader.ReadInt32();
		n_LUK_MIN = binaryReader.ReadInt32();
		n_LUK_MAX = binaryReader.ReadInt32();
		n_DESTROY_MATERIAL = binaryReader.ReadInt32();
		n_DESTROY_MONEY = binaryReader.ReadInt32();
		n_UNLOCK_ID = binaryReader.ReadInt32();
		n_UNLOCK_COUNT = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		w_NAME = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
	}
}
