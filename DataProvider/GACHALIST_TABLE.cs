using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class GACHALIST_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		s_NAME,
		n_TYPE,
		n_GROUP,
		n_SORT,
		s_IMG,
		n_COIN_ID,
		n_COIN_MOUNT,
		n_LIMIT,
		n_RESET_RULE,
		n_PRE,
		n_SHOWTYPE,
		n_RANKING_BONUS,
		n_BONUS,
		n_BONUS_COUNT,
		n_SHOPID,
		n_GACHAID_1,
		n_GACHACOUNT_1,
		n_GACHAID_2,
		n_GACHACOUNT_2,
		n_LUCKY,
		n_LUCKY_GACHA,
		n_BUTTON_IMG,
		n_SHOWRATE,
		n_PERFORM,
		w_BUTTON_TEXT,
		w_BUTTON_TIP,
		w_CONFIRM_TIP,
		s_BEGIN_TIME,
		s_END_TIME,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_SORT { get; set; }

	[Preserve]
	public string s_IMG { get; set; }

	[Preserve]
	public int n_COIN_ID { get; set; }

	[Preserve]
	public int n_COIN_MOUNT { get; set; }

	[Preserve]
	public int n_LIMIT { get; set; }

	[Preserve]
	public int n_RESET_RULE { get; set; }

	[Preserve]
	public int n_PRE { get; set; }

	[Preserve]
	public int n_SHOWTYPE { get; set; }

	[Preserve]
	public int n_RANKING_BONUS { get; set; }

	[Preserve]
	public int n_BONUS { get; set; }

	[Preserve]
	public int n_BONUS_COUNT { get; set; }

	[Preserve]
	public int n_SHOPID { get; set; }

	[Preserve]
	public int n_GACHAID_1 { get; set; }

	[Preserve]
	public int n_GACHACOUNT_1 { get; set; }

	[Preserve]
	public int n_GACHAID_2 { get; set; }

	[Preserve]
	public int n_GACHACOUNT_2 { get; set; }

	[Preserve]
	public int n_LUCKY { get; set; }

	[Preserve]
	public int n_LUCKY_GACHA { get; set; }

	[Preserve]
	public int n_BUTTON_IMG { get; set; }

	[Preserve]
	public int n_SHOWRATE { get; set; }

	[Preserve]
	public int n_PERFORM { get; set; }

	[Preserve]
	public string w_BUTTON_TEXT { get; set; }

	[Preserve]
	public string w_BUTTON_TIP { get; set; }

	[Preserve]
	public string w_CONFIRM_TIP { get; set; }

	[Preserve]
	public string s_BEGIN_TIME { get; set; }

	[Preserve]
	public string s_END_TIME { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(GACHALIST_TABLE tbl)
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
		if (n_TYPE != tbl.n_TYPE)
		{
			dictionary.Add(2, n_TYPE);
		}
		if (n_GROUP != tbl.n_GROUP)
		{
			dictionary.Add(3, n_GROUP);
		}
		if (n_SORT != tbl.n_SORT)
		{
			dictionary.Add(4, n_SORT);
		}
		if (s_IMG != tbl.s_IMG)
		{
			dictionary.Add(5, s_IMG);
		}
		if (n_COIN_ID != tbl.n_COIN_ID)
		{
			dictionary.Add(6, n_COIN_ID);
		}
		if (n_COIN_MOUNT != tbl.n_COIN_MOUNT)
		{
			dictionary.Add(7, n_COIN_MOUNT);
		}
		if (n_LIMIT != tbl.n_LIMIT)
		{
			dictionary.Add(8, n_LIMIT);
		}
		if (n_RESET_RULE != tbl.n_RESET_RULE)
		{
			dictionary.Add(9, n_RESET_RULE);
		}
		if (n_PRE != tbl.n_PRE)
		{
			dictionary.Add(10, n_PRE);
		}
		if (n_SHOWTYPE != tbl.n_SHOWTYPE)
		{
			dictionary.Add(11, n_SHOWTYPE);
		}
		if (n_RANKING_BONUS != tbl.n_RANKING_BONUS)
		{
			dictionary.Add(12, n_RANKING_BONUS);
		}
		if (n_BONUS != tbl.n_BONUS)
		{
			dictionary.Add(13, n_BONUS);
		}
		if (n_BONUS_COUNT != tbl.n_BONUS_COUNT)
		{
			dictionary.Add(14, n_BONUS_COUNT);
		}
		if (n_SHOPID != tbl.n_SHOPID)
		{
			dictionary.Add(15, n_SHOPID);
		}
		if (n_GACHAID_1 != tbl.n_GACHAID_1)
		{
			dictionary.Add(16, n_GACHAID_1);
		}
		if (n_GACHACOUNT_1 != tbl.n_GACHACOUNT_1)
		{
			dictionary.Add(17, n_GACHACOUNT_1);
		}
		if (n_GACHAID_2 != tbl.n_GACHAID_2)
		{
			dictionary.Add(18, n_GACHAID_2);
		}
		if (n_GACHACOUNT_2 != tbl.n_GACHACOUNT_2)
		{
			dictionary.Add(19, n_GACHACOUNT_2);
		}
		if (n_LUCKY != tbl.n_LUCKY)
		{
			dictionary.Add(20, n_LUCKY);
		}
		if (n_LUCKY_GACHA != tbl.n_LUCKY_GACHA)
		{
			dictionary.Add(21, n_LUCKY_GACHA);
		}
		if (n_BUTTON_IMG != tbl.n_BUTTON_IMG)
		{
			dictionary.Add(22, n_BUTTON_IMG);
		}
		if (n_SHOWRATE != tbl.n_SHOWRATE)
		{
			dictionary.Add(23, n_SHOWRATE);
		}
		if (n_PERFORM != tbl.n_PERFORM)
		{
			dictionary.Add(24, n_PERFORM);
		}
		if (w_BUTTON_TEXT != tbl.w_BUTTON_TEXT)
		{
			dictionary.Add(25, w_BUTTON_TEXT);
		}
		if (w_BUTTON_TIP != tbl.w_BUTTON_TIP)
		{
			dictionary.Add(26, w_BUTTON_TIP);
		}
		if (w_CONFIRM_TIP != tbl.w_CONFIRM_TIP)
		{
			dictionary.Add(27, w_CONFIRM_TIP);
		}
		if (s_BEGIN_TIME != tbl.s_BEGIN_TIME)
		{
			dictionary.Add(28, s_BEGIN_TIME);
		}
		if (s_END_TIME != tbl.s_END_TIME)
		{
			dictionary.Add(29, s_END_TIME);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(30, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(31, s_END_VERSION);
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
				n_TYPE = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_GROUP = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_SORT = Convert.ToInt32(item.Value);
				break;
			case 5:
				s_IMG = item.Value.ToString();
				break;
			case 6:
				n_COIN_ID = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_COIN_MOUNT = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_LIMIT = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_RESET_RULE = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_PRE = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_SHOWTYPE = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_RANKING_BONUS = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_BONUS = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_BONUS_COUNT = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_SHOPID = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_GACHAID_1 = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_GACHACOUNT_1 = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_GACHAID_2 = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_GACHACOUNT_2 = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_LUCKY = Convert.ToInt32(item.Value);
				break;
			case 21:
				n_LUCKY_GACHA = Convert.ToInt32(item.Value);
				break;
			case 22:
				n_BUTTON_IMG = Convert.ToInt32(item.Value);
				break;
			case 23:
				n_SHOWRATE = Convert.ToInt32(item.Value);
				break;
			case 24:
				n_PERFORM = Convert.ToInt32(item.Value);
				break;
			case 25:
				w_BUTTON_TEXT = item.Value.ToString();
				break;
			case 26:
				w_BUTTON_TIP = item.Value.ToString();
				break;
			case 27:
				w_CONFIRM_TIP = item.Value.ToString();
				break;
			case 28:
				s_BEGIN_TIME = item.Value.ToString();
				break;
			case 29:
				s_END_TIME = item.Value.ToString();
				break;
			case 30:
				s_START_VERSION = item.Value.ToString();
				break;
			case 31:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(GACHALIST_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (s_NAME != table.s_NAME)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (n_SORT != table.n_SORT)
		{
			return false;
		}
		if (s_IMG != table.s_IMG)
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
		if (n_SHOWTYPE != table.n_SHOWTYPE)
		{
			return false;
		}
		if (n_RANKING_BONUS != table.n_RANKING_BONUS)
		{
			return false;
		}
		if (n_BONUS != table.n_BONUS)
		{
			return false;
		}
		if (n_BONUS_COUNT != table.n_BONUS_COUNT)
		{
			return false;
		}
		if (n_SHOPID != table.n_SHOPID)
		{
			return false;
		}
		if (n_GACHAID_1 != table.n_GACHAID_1)
		{
			return false;
		}
		if (n_GACHACOUNT_1 != table.n_GACHACOUNT_1)
		{
			return false;
		}
		if (n_GACHAID_2 != table.n_GACHAID_2)
		{
			return false;
		}
		if (n_GACHACOUNT_2 != table.n_GACHACOUNT_2)
		{
			return false;
		}
		if (n_LUCKY != table.n_LUCKY)
		{
			return false;
		}
		if (n_LUCKY_GACHA != table.n_LUCKY_GACHA)
		{
			return false;
		}
		if (n_BUTTON_IMG != table.n_BUTTON_IMG)
		{
			return false;
		}
		if (n_SHOWRATE != table.n_SHOWRATE)
		{
			return false;
		}
		if (n_PERFORM != table.n_PERFORM)
		{
			return false;
		}
		if (w_BUTTON_TEXT != table.w_BUTTON_TEXT)
		{
			return false;
		}
		if (w_BUTTON_TIP != table.w_BUTTON_TIP)
		{
			return false;
		}
		if (w_CONFIRM_TIP != table.w_CONFIRM_TIP)
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
		return true;
	}

	public string ConvertToString()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(n_ID);
		binaryWriter.WriteExString(s_NAME);
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_GROUP);
		binaryWriter.Write(n_SORT);
		binaryWriter.WriteExString(s_IMG);
		binaryWriter.Write(n_COIN_ID);
		binaryWriter.Write(n_COIN_MOUNT);
		binaryWriter.Write(n_LIMIT);
		binaryWriter.Write(n_RESET_RULE);
		binaryWriter.Write(n_PRE);
		binaryWriter.Write(n_SHOWTYPE);
		binaryWriter.Write(n_RANKING_BONUS);
		binaryWriter.Write(n_BONUS);
		binaryWriter.Write(n_BONUS_COUNT);
		binaryWriter.Write(n_SHOPID);
		binaryWriter.Write(n_GACHAID_1);
		binaryWriter.Write(n_GACHACOUNT_1);
		binaryWriter.Write(n_GACHAID_2);
		binaryWriter.Write(n_GACHACOUNT_2);
		binaryWriter.Write(n_LUCKY);
		binaryWriter.Write(n_LUCKY_GACHA);
		binaryWriter.Write(n_BUTTON_IMG);
		binaryWriter.Write(n_SHOWRATE);
		binaryWriter.Write(n_PERFORM);
		binaryWriter.WriteExString(w_BUTTON_TEXT);
		binaryWriter.WriteExString(w_BUTTON_TIP);
		binaryWriter.WriteExString(w_CONFIRM_TIP);
		binaryWriter.WriteExString(s_BEGIN_TIME);
		binaryWriter.WriteExString(s_END_TIME);
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
		s_NAME = binaryReader.ReadExString();
		n_TYPE = binaryReader.ReadInt32();
		n_GROUP = binaryReader.ReadInt32();
		n_SORT = binaryReader.ReadInt32();
		s_IMG = binaryReader.ReadExString();
		n_COIN_ID = binaryReader.ReadInt32();
		n_COIN_MOUNT = binaryReader.ReadInt32();
		n_LIMIT = binaryReader.ReadInt32();
		n_RESET_RULE = binaryReader.ReadInt32();
		n_PRE = binaryReader.ReadInt32();
		n_SHOWTYPE = binaryReader.ReadInt32();
		n_RANKING_BONUS = binaryReader.ReadInt32();
		n_BONUS = binaryReader.ReadInt32();
		n_BONUS_COUNT = binaryReader.ReadInt32();
		n_SHOPID = binaryReader.ReadInt32();
		n_GACHAID_1 = binaryReader.ReadInt32();
		n_GACHACOUNT_1 = binaryReader.ReadInt32();
		n_GACHAID_2 = binaryReader.ReadInt32();
		n_GACHACOUNT_2 = binaryReader.ReadInt32();
		n_LUCKY = binaryReader.ReadInt32();
		n_LUCKY_GACHA = binaryReader.ReadInt32();
		n_BUTTON_IMG = binaryReader.ReadInt32();
		n_SHOWRATE = binaryReader.ReadInt32();
		n_PERFORM = binaryReader.ReadInt32();
		w_BUTTON_TEXT = binaryReader.ReadExString();
		w_BUTTON_TIP = binaryReader.ReadExString();
		w_CONFIRM_TIP = binaryReader.ReadExString();
		s_BEGIN_TIME = binaryReader.ReadExString();
		s_END_TIME = binaryReader.ReadExString();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
