using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class GACHA_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		n_TYPE,
		n_RANK,
		n_INITIAL_STATUS,
		n_REWARD_TYPE,
		n_REWARD_ID,
		n_AMOUNT_MIN,
		n_AMOUNT_MAX,
		n_PICKUP,
		n_VALUE,
		n_BONUS_ITEMID,
		n_BONUS_ITEMCOUNT,
		n_AMOUNT_MODIFY,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_RANK { get; set; }

	[Preserve]
	public int n_INITIAL_STATUS { get; set; }

	[Preserve]
	public int n_REWARD_TYPE { get; set; }

	[Preserve]
	public int n_REWARD_ID { get; set; }

	[Preserve]
	public int n_AMOUNT_MIN { get; set; }

	[Preserve]
	public int n_AMOUNT_MAX { get; set; }

	[Preserve]
	public int n_PICKUP { get; set; }

	[Preserve]
	public int n_VALUE { get; set; }

	[Preserve]
	public int n_BONUS_ITEMID { get; set; }

	[Preserve]
	public int n_BONUS_ITEMCOUNT { get; set; }

	[Preserve]
	public int n_AMOUNT_MODIFY { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(GACHA_TABLE tbl)
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
		if (n_TYPE != tbl.n_TYPE)
		{
			dictionary.Add(2, n_TYPE);
		}
		if (n_RANK != tbl.n_RANK)
		{
			dictionary.Add(3, n_RANK);
		}
		if (n_INITIAL_STATUS != tbl.n_INITIAL_STATUS)
		{
			dictionary.Add(4, n_INITIAL_STATUS);
		}
		if (n_REWARD_TYPE != tbl.n_REWARD_TYPE)
		{
			dictionary.Add(5, n_REWARD_TYPE);
		}
		if (n_REWARD_ID != tbl.n_REWARD_ID)
		{
			dictionary.Add(6, n_REWARD_ID);
		}
		if (n_AMOUNT_MIN != tbl.n_AMOUNT_MIN)
		{
			dictionary.Add(7, n_AMOUNT_MIN);
		}
		if (n_AMOUNT_MAX != tbl.n_AMOUNT_MAX)
		{
			dictionary.Add(8, n_AMOUNT_MAX);
		}
		if (n_PICKUP != tbl.n_PICKUP)
		{
			dictionary.Add(9, n_PICKUP);
		}
		if (n_VALUE != tbl.n_VALUE)
		{
			dictionary.Add(10, n_VALUE);
		}
		if (n_BONUS_ITEMID != tbl.n_BONUS_ITEMID)
		{
			dictionary.Add(11, n_BONUS_ITEMID);
		}
		if (n_BONUS_ITEMCOUNT != tbl.n_BONUS_ITEMCOUNT)
		{
			dictionary.Add(12, n_BONUS_ITEMCOUNT);
		}
		if (n_AMOUNT_MODIFY != tbl.n_AMOUNT_MODIFY)
		{
			dictionary.Add(13, n_AMOUNT_MODIFY);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(14, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(15, s_END_VERSION);
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
				n_TYPE = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_RANK = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_INITIAL_STATUS = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_REWARD_TYPE = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_REWARD_ID = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_AMOUNT_MIN = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_AMOUNT_MAX = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_PICKUP = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_VALUE = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_BONUS_ITEMID = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_BONUS_ITEMCOUNT = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_AMOUNT_MODIFY = Convert.ToInt32(item.Value);
				break;
			case 14:
				s_START_VERSION = item.Value.ToString();
				break;
			case 15:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(GACHA_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_RANK != table.n_RANK)
		{
			return false;
		}
		if (n_INITIAL_STATUS != table.n_INITIAL_STATUS)
		{
			return false;
		}
		if (n_REWARD_TYPE != table.n_REWARD_TYPE)
		{
			return false;
		}
		if (n_REWARD_ID != table.n_REWARD_ID)
		{
			return false;
		}
		if (n_AMOUNT_MIN != table.n_AMOUNT_MIN)
		{
			return false;
		}
		if (n_AMOUNT_MAX != table.n_AMOUNT_MAX)
		{
			return false;
		}
		if (n_PICKUP != table.n_PICKUP)
		{
			return false;
		}
		if (n_VALUE != table.n_VALUE)
		{
			return false;
		}
		if (n_BONUS_ITEMID != table.n_BONUS_ITEMID)
		{
			return false;
		}
		if (n_BONUS_ITEMCOUNT != table.n_BONUS_ITEMCOUNT)
		{
			return false;
		}
		if (n_AMOUNT_MODIFY != table.n_AMOUNT_MODIFY)
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
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_RANK);
		binaryWriter.Write(n_INITIAL_STATUS);
		binaryWriter.Write(n_REWARD_TYPE);
		binaryWriter.Write(n_REWARD_ID);
		binaryWriter.Write(n_AMOUNT_MIN);
		binaryWriter.Write(n_AMOUNT_MAX);
		binaryWriter.Write(n_PICKUP);
		binaryWriter.Write(n_VALUE);
		binaryWriter.Write(n_BONUS_ITEMID);
		binaryWriter.Write(n_BONUS_ITEMCOUNT);
		binaryWriter.Write(n_AMOUNT_MODIFY);
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
		n_TYPE = binaryReader.ReadInt32();
		n_RANK = binaryReader.ReadInt32();
		n_INITIAL_STATUS = binaryReader.ReadInt32();
		n_REWARD_TYPE = binaryReader.ReadInt32();
		n_REWARD_ID = binaryReader.ReadInt32();
		n_AMOUNT_MIN = binaryReader.ReadInt32();
		n_AMOUNT_MAX = binaryReader.ReadInt32();
		n_PICKUP = binaryReader.ReadInt32();
		n_VALUE = binaryReader.ReadInt32();
		n_BONUS_ITEMID = binaryReader.ReadInt32();
		n_BONUS_ITEMCOUNT = binaryReader.ReadInt32();
		n_AMOUNT_MODIFY = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
