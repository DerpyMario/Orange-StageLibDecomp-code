using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class EVENT_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		n_TYPE_X,
		n_TYPE_Y,
		s_IMG,
		s_IMG2,
		n_BONUS_TYPE,
		n_BONUS_RATE,
		n_SP_TYPE,
		n_SP_ID,
		n_DROP_ITEM,
		n_DROP_RATE,
		n_COUNTER,
		n_LIMIT,
		n_RESET_RULE,
		n_RANKING,
		n_POINT,
		n_BOXGACHA,
		n_RESULT,
		n_SHOP,
		n_MISSION,
		n_HOMETOP,
		w_NAME,
		s_BEGIN_TIME,
		s_END_TIME,
		s_RANKING_TIME,
		s_REMAIN_TIME,
		s_BGM,
		s_START_VERSION,
		s_END_VERSION,
		n_AREA_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_TYPE_X { get; set; }

	[Preserve]
	public int n_TYPE_Y { get; set; }

	[Preserve]
	public string s_IMG { get; set; }

	[Preserve]
	public string s_IMG2 { get; set; }

	[Preserve]
	public int n_BONUS_TYPE { get; set; }

	[Preserve]
	public int n_BONUS_RATE { get; set; }

	[Preserve]
	public int n_SP_TYPE { get; set; }

	[Preserve]
	public int n_SP_ID { get; set; }

	[Preserve]
	public int n_DROP_ITEM { get; set; }

	[Preserve]
	public int n_DROP_RATE { get; set; }

	[Preserve]
	public int n_COUNTER { get; set; }

	[Preserve]
	public int n_LIMIT { get; set; }

	[Preserve]
	public int n_RESET_RULE { get; set; }

	[Preserve]
	public int n_RANKING { get; set; }

	[Preserve]
	public int n_POINT { get; set; }

	[Preserve]
	public int n_BOXGACHA { get; set; }

	[Preserve]
	public int n_RESULT { get; set; }

	[Preserve]
	public int n_SHOP { get; set; }

	[Preserve]
	public int n_MISSION { get; set; }

	[Preserve]
	public int n_HOMETOP { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string s_BEGIN_TIME { get; set; }

	[Preserve]
	public string s_END_TIME { get; set; }

	[Preserve]
	public string s_RANKING_TIME { get; set; }

	[Preserve]
	public string s_REMAIN_TIME { get; set; }

	[Preserve]
	public string s_BGM { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	[Preserve]
	public int n_AREA_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(EVENT_TABLE tbl)
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
		if (n_TYPE_X != tbl.n_TYPE_X)
		{
			dictionary.Add(2, n_TYPE_X);
		}
		if (n_TYPE_Y != tbl.n_TYPE_Y)
		{
			dictionary.Add(3, n_TYPE_Y);
		}
		if (s_IMG != tbl.s_IMG)
		{
			dictionary.Add(4, s_IMG);
		}
		if (s_IMG2 != tbl.s_IMG2)
		{
			dictionary.Add(5, s_IMG2);
		}
		if (n_BONUS_TYPE != tbl.n_BONUS_TYPE)
		{
			dictionary.Add(6, n_BONUS_TYPE);
		}
		if (n_BONUS_RATE != tbl.n_BONUS_RATE)
		{
			dictionary.Add(7, n_BONUS_RATE);
		}
		if (n_SP_TYPE != tbl.n_SP_TYPE)
		{
			dictionary.Add(8, n_SP_TYPE);
		}
		if (n_SP_ID != tbl.n_SP_ID)
		{
			dictionary.Add(9, n_SP_ID);
		}
		if (n_DROP_ITEM != tbl.n_DROP_ITEM)
		{
			dictionary.Add(10, n_DROP_ITEM);
		}
		if (n_DROP_RATE != tbl.n_DROP_RATE)
		{
			dictionary.Add(11, n_DROP_RATE);
		}
		if (n_COUNTER != tbl.n_COUNTER)
		{
			dictionary.Add(12, n_COUNTER);
		}
		if (n_LIMIT != tbl.n_LIMIT)
		{
			dictionary.Add(13, n_LIMIT);
		}
		if (n_RESET_RULE != tbl.n_RESET_RULE)
		{
			dictionary.Add(14, n_RESET_RULE);
		}
		if (n_RANKING != tbl.n_RANKING)
		{
			dictionary.Add(15, n_RANKING);
		}
		if (n_POINT != tbl.n_POINT)
		{
			dictionary.Add(16, n_POINT);
		}
		if (n_BOXGACHA != tbl.n_BOXGACHA)
		{
			dictionary.Add(17, n_BOXGACHA);
		}
		if (n_RESULT != tbl.n_RESULT)
		{
			dictionary.Add(18, n_RESULT);
		}
		if (n_SHOP != tbl.n_SHOP)
		{
			dictionary.Add(19, n_SHOP);
		}
		if (n_MISSION != tbl.n_MISSION)
		{
			dictionary.Add(20, n_MISSION);
		}
		if (n_HOMETOP != tbl.n_HOMETOP)
		{
			dictionary.Add(21, n_HOMETOP);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(22, w_NAME);
		}
		if (s_BEGIN_TIME != tbl.s_BEGIN_TIME)
		{
			dictionary.Add(23, s_BEGIN_TIME);
		}
		if (s_END_TIME != tbl.s_END_TIME)
		{
			dictionary.Add(24, s_END_TIME);
		}
		if (s_RANKING_TIME != tbl.s_RANKING_TIME)
		{
			dictionary.Add(25, s_RANKING_TIME);
		}
		if (s_REMAIN_TIME != tbl.s_REMAIN_TIME)
		{
			dictionary.Add(26, s_REMAIN_TIME);
		}
		if (s_BGM != tbl.s_BGM)
		{
			dictionary.Add(27, s_BGM);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(28, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(29, s_END_VERSION);
		}
		if (n_AREA_VERSION != tbl.n_AREA_VERSION)
		{
			dictionary.Add(30, n_AREA_VERSION);
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
				n_TYPE_X = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_TYPE_Y = Convert.ToInt32(item.Value);
				break;
			case 4:
				s_IMG = item.Value.ToString();
				break;
			case 5:
				s_IMG2 = item.Value.ToString();
				break;
			case 6:
				n_BONUS_TYPE = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_BONUS_RATE = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_SP_TYPE = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_SP_ID = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_DROP_ITEM = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_DROP_RATE = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_COUNTER = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_LIMIT = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_RESET_RULE = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_RANKING = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_POINT = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_BOXGACHA = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_RESULT = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_SHOP = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_MISSION = Convert.ToInt32(item.Value);
				break;
			case 21:
				n_HOMETOP = Convert.ToInt32(item.Value);
				break;
			case 22:
				w_NAME = item.Value.ToString();
				break;
			case 23:
				s_BEGIN_TIME = item.Value.ToString();
				break;
			case 24:
				s_END_TIME = item.Value.ToString();
				break;
			case 25:
				s_RANKING_TIME = item.Value.ToString();
				break;
			case 26:
				s_REMAIN_TIME = item.Value.ToString();
				break;
			case 27:
				s_BGM = item.Value.ToString();
				break;
			case 28:
				s_START_VERSION = item.Value.ToString();
				break;
			case 29:
				s_END_VERSION = item.Value.ToString();
				break;
			case 30:
				n_AREA_VERSION = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(EVENT_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_TYPE_X != table.n_TYPE_X)
		{
			return false;
		}
		if (n_TYPE_Y != table.n_TYPE_Y)
		{
			return false;
		}
		if (s_IMG != table.s_IMG)
		{
			return false;
		}
		if (s_IMG2 != table.s_IMG2)
		{
			return false;
		}
		if (n_BONUS_TYPE != table.n_BONUS_TYPE)
		{
			return false;
		}
		if (n_BONUS_RATE != table.n_BONUS_RATE)
		{
			return false;
		}
		if (n_SP_TYPE != table.n_SP_TYPE)
		{
			return false;
		}
		if (n_SP_ID != table.n_SP_ID)
		{
			return false;
		}
		if (n_DROP_ITEM != table.n_DROP_ITEM)
		{
			return false;
		}
		if (n_DROP_RATE != table.n_DROP_RATE)
		{
			return false;
		}
		if (n_COUNTER != table.n_COUNTER)
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
		if (n_RANKING != table.n_RANKING)
		{
			return false;
		}
		if (n_POINT != table.n_POINT)
		{
			return false;
		}
		if (n_BOXGACHA != table.n_BOXGACHA)
		{
			return false;
		}
		if (n_RESULT != table.n_RESULT)
		{
			return false;
		}
		if (n_SHOP != table.n_SHOP)
		{
			return false;
		}
		if (n_MISSION != table.n_MISSION)
		{
			return false;
		}
		if (n_HOMETOP != table.n_HOMETOP)
		{
			return false;
		}
		if (w_NAME != table.w_NAME)
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
		if (s_RANKING_TIME != table.s_RANKING_TIME)
		{
			return false;
		}
		if (s_REMAIN_TIME != table.s_REMAIN_TIME)
		{
			return false;
		}
		if (s_BGM != table.s_BGM)
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
		return true;
	}

	public string ConvertToString()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(n_ID);
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_TYPE_X);
		binaryWriter.Write(n_TYPE_Y);
		binaryWriter.WriteExString(s_IMG);
		binaryWriter.WriteExString(s_IMG2);
		binaryWriter.Write(n_BONUS_TYPE);
		binaryWriter.Write(n_BONUS_RATE);
		binaryWriter.Write(n_SP_TYPE);
		binaryWriter.Write(n_SP_ID);
		binaryWriter.Write(n_DROP_ITEM);
		binaryWriter.Write(n_DROP_RATE);
		binaryWriter.Write(n_COUNTER);
		binaryWriter.Write(n_LIMIT);
		binaryWriter.Write(n_RESET_RULE);
		binaryWriter.Write(n_RANKING);
		binaryWriter.Write(n_POINT);
		binaryWriter.Write(n_BOXGACHA);
		binaryWriter.Write(n_RESULT);
		binaryWriter.Write(n_SHOP);
		binaryWriter.Write(n_MISSION);
		binaryWriter.Write(n_HOMETOP);
		binaryWriter.WriteExString(w_NAME);
		binaryWriter.WriteExString(s_BEGIN_TIME);
		binaryWriter.WriteExString(s_END_TIME);
		binaryWriter.WriteExString(s_RANKING_TIME);
		binaryWriter.WriteExString(s_REMAIN_TIME);
		binaryWriter.WriteExString(s_BGM);
		binaryWriter.WriteExString(s_START_VERSION);
		binaryWriter.WriteExString(s_END_VERSION);
		binaryWriter.Write(n_AREA_VERSION);
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
		n_TYPE_X = binaryReader.ReadInt32();
		n_TYPE_Y = binaryReader.ReadInt32();
		s_IMG = binaryReader.ReadExString();
		s_IMG2 = binaryReader.ReadExString();
		n_BONUS_TYPE = binaryReader.ReadInt32();
		n_BONUS_RATE = binaryReader.ReadInt32();
		n_SP_TYPE = binaryReader.ReadInt32();
		n_SP_ID = binaryReader.ReadInt32();
		n_DROP_ITEM = binaryReader.ReadInt32();
		n_DROP_RATE = binaryReader.ReadInt32();
		n_COUNTER = binaryReader.ReadInt32();
		n_LIMIT = binaryReader.ReadInt32();
		n_RESET_RULE = binaryReader.ReadInt32();
		n_RANKING = binaryReader.ReadInt32();
		n_POINT = binaryReader.ReadInt32();
		n_BOXGACHA = binaryReader.ReadInt32();
		n_RESULT = binaryReader.ReadInt32();
		n_SHOP = binaryReader.ReadInt32();
		n_MISSION = binaryReader.ReadInt32();
		n_HOMETOP = binaryReader.ReadInt32();
		w_NAME = binaryReader.ReadExString();
		s_BEGIN_TIME = binaryReader.ReadExString();
		s_END_TIME = binaryReader.ReadExString();
		s_RANKING_TIME = binaryReader.ReadExString();
		s_REMAIN_TIME = binaryReader.ReadExString();
		s_BGM = binaryReader.ReadExString();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		n_AREA_VERSION = binaryReader.ReadInt32();
	}
}
