using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class SHOP_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_MAIN_TYPE,
		n_SUB_TYPE,
		w_SHEET_NAME,
		n_SORT,
		n_TAG,
		s_ICON,
		n_PLATFORM,
		s_PRODUCT_ID,
		n_PRODUCT_TYPE,
		n_AUTO_OPEN,
		n_PRODUCT_ID,
		n_PRODUCT_MOUNT,
		n_VIP,
		n_LIMIT,
		n_RESET_RULE,
		n_PRE,
		n_COIN_ID,
		n_COIN_MOUNT,
		n_DISCOUNT,
		n_BONUS_COIN,
		s_BEGIN_TIME,
		s_END_TIME,
		s_START_VERSION,
		s_END_VERSION,
		n_AREA_VERSION,
		w_PRODUCT_NAME,
		w_PRODUCT_TIP
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_MAIN_TYPE { get; set; }

	[Preserve]
	public int n_SUB_TYPE { get; set; }

	[Preserve]
	public string w_SHEET_NAME { get; set; }

	[Preserve]
	public int n_SORT { get; set; }

	[Preserve]
	public int n_TAG { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public int n_PLATFORM { get; set; }

	[Preserve]
	public string s_PRODUCT_ID { get; set; }

	[Preserve]
	public int n_PRODUCT_TYPE { get; set; }

	[Preserve]
	public int n_AUTO_OPEN { get; set; }

	[Preserve]
	public int n_PRODUCT_ID { get; set; }

	[Preserve]
	public int n_PRODUCT_MOUNT { get; set; }

	[Preserve]
	public int n_VIP { get; set; }

	[Preserve]
	public int n_LIMIT { get; set; }

	[Preserve]
	public int n_RESET_RULE { get; set; }

	[Preserve]
	public int n_PRE { get; set; }

	[Preserve]
	public int n_COIN_ID { get; set; }

	[Preserve]
	public int n_COIN_MOUNT { get; set; }

	[Preserve]
	public int n_DISCOUNT { get; set; }

	[Preserve]
	public int n_BONUS_COIN { get; set; }

	[Preserve]
	public string s_BEGIN_TIME { get; set; }

	[Preserve]
	public string s_END_TIME { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	[Preserve]
	public int n_AREA_VERSION { get; set; }

	[Preserve]
	public string w_PRODUCT_NAME { get; set; }

	[Preserve]
	public string w_PRODUCT_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(SHOP_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_MAIN_TYPE != tbl.n_MAIN_TYPE)
		{
			dictionary.Add(1, n_MAIN_TYPE);
		}
		if (n_SUB_TYPE != tbl.n_SUB_TYPE)
		{
			dictionary.Add(2, n_SUB_TYPE);
		}
		if (w_SHEET_NAME != tbl.w_SHEET_NAME)
		{
			dictionary.Add(3, w_SHEET_NAME);
		}
		if (n_SORT != tbl.n_SORT)
		{
			dictionary.Add(4, n_SORT);
		}
		if (n_TAG != tbl.n_TAG)
		{
			dictionary.Add(5, n_TAG);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(6, s_ICON);
		}
		if (n_PLATFORM != tbl.n_PLATFORM)
		{
			dictionary.Add(7, n_PLATFORM);
		}
		if (s_PRODUCT_ID != tbl.s_PRODUCT_ID)
		{
			dictionary.Add(8, s_PRODUCT_ID);
		}
		if (n_PRODUCT_TYPE != tbl.n_PRODUCT_TYPE)
		{
			dictionary.Add(9, n_PRODUCT_TYPE);
		}
		if (n_AUTO_OPEN != tbl.n_AUTO_OPEN)
		{
			dictionary.Add(10, n_AUTO_OPEN);
		}
		if (n_PRODUCT_ID != tbl.n_PRODUCT_ID)
		{
			dictionary.Add(11, n_PRODUCT_ID);
		}
		if (n_PRODUCT_MOUNT != tbl.n_PRODUCT_MOUNT)
		{
			dictionary.Add(12, n_PRODUCT_MOUNT);
		}
		if (n_VIP != tbl.n_VIP)
		{
			dictionary.Add(13, n_VIP);
		}
		if (n_LIMIT != tbl.n_LIMIT)
		{
			dictionary.Add(14, n_LIMIT);
		}
		if (n_RESET_RULE != tbl.n_RESET_RULE)
		{
			dictionary.Add(15, n_RESET_RULE);
		}
		if (n_PRE != tbl.n_PRE)
		{
			dictionary.Add(16, n_PRE);
		}
		if (n_COIN_ID != tbl.n_COIN_ID)
		{
			dictionary.Add(17, n_COIN_ID);
		}
		if (n_COIN_MOUNT != tbl.n_COIN_MOUNT)
		{
			dictionary.Add(18, n_COIN_MOUNT);
		}
		if (n_DISCOUNT != tbl.n_DISCOUNT)
		{
			dictionary.Add(19, n_DISCOUNT);
		}
		if (n_BONUS_COIN != tbl.n_BONUS_COIN)
		{
			dictionary.Add(20, n_BONUS_COIN);
		}
		if (s_BEGIN_TIME != tbl.s_BEGIN_TIME)
		{
			dictionary.Add(21, s_BEGIN_TIME);
		}
		if (s_END_TIME != tbl.s_END_TIME)
		{
			dictionary.Add(22, s_END_TIME);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(23, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(24, s_END_VERSION);
		}
		if (n_AREA_VERSION != tbl.n_AREA_VERSION)
		{
			dictionary.Add(25, n_AREA_VERSION);
		}
		if (w_PRODUCT_NAME != tbl.w_PRODUCT_NAME)
		{
			dictionary.Add(26, w_PRODUCT_NAME);
		}
		if (w_PRODUCT_TIP != tbl.w_PRODUCT_TIP)
		{
			dictionary.Add(27, w_PRODUCT_TIP);
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
				n_MAIN_TYPE = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_SUB_TYPE = Convert.ToInt32(item.Value);
				break;
			case 3:
				w_SHEET_NAME = item.Value.ToString();
				break;
			case 4:
				n_SORT = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_TAG = Convert.ToInt32(item.Value);
				break;
			case 6:
				s_ICON = item.Value.ToString();
				break;
			case 7:
				n_PLATFORM = Convert.ToInt32(item.Value);
				break;
			case 8:
				s_PRODUCT_ID = item.Value.ToString();
				break;
			case 9:
				n_PRODUCT_TYPE = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_AUTO_OPEN = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_PRODUCT_ID = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_PRODUCT_MOUNT = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_VIP = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_LIMIT = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_RESET_RULE = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_PRE = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_COIN_ID = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_COIN_MOUNT = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_DISCOUNT = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_BONUS_COIN = Convert.ToInt32(item.Value);
				break;
			case 21:
				s_BEGIN_TIME = item.Value.ToString();
				break;
			case 22:
				s_END_TIME = item.Value.ToString();
				break;
			case 23:
				s_START_VERSION = item.Value.ToString();
				break;
			case 24:
				s_END_VERSION = item.Value.ToString();
				break;
			case 25:
				n_AREA_VERSION = Convert.ToInt32(item.Value);
				break;
			case 26:
				w_PRODUCT_NAME = item.Value.ToString();
				break;
			case 27:
				w_PRODUCT_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(SHOP_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_MAIN_TYPE != table.n_MAIN_TYPE)
		{
			return false;
		}
		if (n_SUB_TYPE != table.n_SUB_TYPE)
		{
			return false;
		}
		if (w_SHEET_NAME != table.w_SHEET_NAME)
		{
			return false;
		}
		if (n_SORT != table.n_SORT)
		{
			return false;
		}
		if (n_TAG != table.n_TAG)
		{
			return false;
		}
		if (s_ICON != table.s_ICON)
		{
			return false;
		}
		if (n_PLATFORM != table.n_PLATFORM)
		{
			return false;
		}
		if (s_PRODUCT_ID != table.s_PRODUCT_ID)
		{
			return false;
		}
		if (n_PRODUCT_TYPE != table.n_PRODUCT_TYPE)
		{
			return false;
		}
		if (n_AUTO_OPEN != table.n_AUTO_OPEN)
		{
			return false;
		}
		if (n_PRODUCT_ID != table.n_PRODUCT_ID)
		{
			return false;
		}
		if (n_PRODUCT_MOUNT != table.n_PRODUCT_MOUNT)
		{
			return false;
		}
		if (n_VIP != table.n_VIP)
		{
			return false;
		}
		if (n_LIMIT != table.n_LIMIT)
		{
			return false;
		}
		if (n_RESET_RULE != table.n_RESET_RULE)
		{
			return false;
		}
		if (n_PRE != table.n_PRE)
		{
			return false;
		}
		if (n_COIN_ID != table.n_COIN_ID)
		{
			return false;
		}
		if (n_COIN_MOUNT != table.n_COIN_MOUNT)
		{
			return false;
		}
		if (n_DISCOUNT != table.n_DISCOUNT)
		{
			return false;
		}
		if (n_BONUS_COIN != table.n_BONUS_COIN)
		{
			return false;
		}
		if (s_BEGIN_TIME != table.s_BEGIN_TIME)
		{
			return false;
		}
		if (s_END_TIME != table.s_END_TIME)
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
		if (n_AREA_VERSION != table.n_AREA_VERSION)
		{
			return false;
		}
		if (w_PRODUCT_NAME != table.w_PRODUCT_NAME)
		{
			return false;
		}
		if (w_PRODUCT_TIP != table.w_PRODUCT_TIP)
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
		binaryWriter.Write(n_MAIN_TYPE);
		binaryWriter.Write(n_SUB_TYPE);
		binaryWriter.WriteExString(w_SHEET_NAME);
		binaryWriter.Write(n_SORT);
		binaryWriter.Write(n_TAG);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.Write(n_PLATFORM);
		binaryWriter.WriteExString(s_PRODUCT_ID);
		binaryWriter.Write(n_PRODUCT_TYPE);
		binaryWriter.Write(n_AUTO_OPEN);
		binaryWriter.Write(n_PRODUCT_ID);
		binaryWriter.Write(n_PRODUCT_MOUNT);
		binaryWriter.Write(n_VIP);
		binaryWriter.Write(n_LIMIT);
		binaryWriter.Write(n_RESET_RULE);
		binaryWriter.Write(n_PRE);
		binaryWriter.Write(n_COIN_ID);
		binaryWriter.Write(n_COIN_MOUNT);
		binaryWriter.Write(n_DISCOUNT);
		binaryWriter.Write(n_BONUS_COIN);
		binaryWriter.WriteExString(s_BEGIN_TIME);
		binaryWriter.WriteExString(s_END_TIME);
		binaryWriter.WriteExString(s_START_VERSION);
		binaryWriter.WriteExString(s_END_VERSION);
		binaryWriter.Write(n_AREA_VERSION);
		binaryWriter.WriteExString(w_PRODUCT_NAME);
		binaryWriter.WriteExString(w_PRODUCT_TIP);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_MAIN_TYPE = binaryReader.ReadInt32();
		n_SUB_TYPE = binaryReader.ReadInt32();
		w_SHEET_NAME = binaryReader.ReadExString();
		n_SORT = binaryReader.ReadInt32();
		n_TAG = binaryReader.ReadInt32();
		s_ICON = binaryReader.ReadExString();
		n_PLATFORM = binaryReader.ReadInt32();
		s_PRODUCT_ID = binaryReader.ReadExString();
		n_PRODUCT_TYPE = binaryReader.ReadInt32();
		n_AUTO_OPEN = binaryReader.ReadInt32();
		n_PRODUCT_ID = binaryReader.ReadInt32();
		n_PRODUCT_MOUNT = binaryReader.ReadInt32();
		n_VIP = binaryReader.ReadInt32();
		n_LIMIT = binaryReader.ReadInt32();
		n_RESET_RULE = binaryReader.ReadInt32();
		n_PRE = binaryReader.ReadInt32();
		n_COIN_ID = binaryReader.ReadInt32();
		n_COIN_MOUNT = binaryReader.ReadInt32();
		n_DISCOUNT = binaryReader.ReadInt32();
		n_BONUS_COIN = binaryReader.ReadInt32();
		s_BEGIN_TIME = binaryReader.ReadExString();
		s_END_TIME = binaryReader.ReadExString();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		n_AREA_VERSION = binaryReader.ReadInt32();
		w_PRODUCT_NAME = binaryReader.ReadExString();
		w_PRODUCT_TIP = binaryReader.ReadExString();
	}
}
