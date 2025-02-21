using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class LABOEVENT_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		n_MIN_1,
		n_MAX_1,
		n_MIN_2,
		n_MAX_2,
		n_MIN_3,
		n_MAX_3,
		n_MIN_4,
		n_MAX_4,
		n_ITEM,
		n_ITEM_COUNT,
		n_ITEM_LIMIT,
		n_COUNTER,
		n_REPLACEITEM,
		n_REPLACEITEM_COUNT,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_MIN_1 { get; set; }

	[Preserve]
	public int n_MAX_1 { get; set; }

	[Preserve]
	public int n_MIN_2 { get; set; }

	[Preserve]
	public int n_MAX_2 { get; set; }

	[Preserve]
	public int n_MIN_3 { get; set; }

	[Preserve]
	public int n_MAX_3 { get; set; }

	[Preserve]
	public int n_MIN_4 { get; set; }

	[Preserve]
	public int n_MAX_4 { get; set; }

	[Preserve]
	public int n_ITEM { get; set; }

	[Preserve]
	public int n_ITEM_COUNT { get; set; }

	[Preserve]
	public int n_ITEM_LIMIT { get; set; }

	[Preserve]
	public int n_COUNTER { get; set; }

	[Preserve]
	public int n_REPLACEITEM { get; set; }

	[Preserve]
	public int n_REPLACEITEM_COUNT { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(LABOEVENT_TABLE tbl)
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
		if (n_MIN_1 != tbl.n_MIN_1)
		{
			dictionary.Add(2, n_MIN_1);
		}
		if (n_MAX_1 != tbl.n_MAX_1)
		{
			dictionary.Add(3, n_MAX_1);
		}
		if (n_MIN_2 != tbl.n_MIN_2)
		{
			dictionary.Add(4, n_MIN_2);
		}
		if (n_MAX_2 != tbl.n_MAX_2)
		{
			dictionary.Add(5, n_MAX_2);
		}
		if (n_MIN_3 != tbl.n_MIN_3)
		{
			dictionary.Add(6, n_MIN_3);
		}
		if (n_MAX_3 != tbl.n_MAX_3)
		{
			dictionary.Add(7, n_MAX_3);
		}
		if (n_MIN_4 != tbl.n_MIN_4)
		{
			dictionary.Add(8, n_MIN_4);
		}
		if (n_MAX_4 != tbl.n_MAX_4)
		{
			dictionary.Add(9, n_MAX_4);
		}
		if (n_ITEM != tbl.n_ITEM)
		{
			dictionary.Add(10, n_ITEM);
		}
		if (n_ITEM_COUNT != tbl.n_ITEM_COUNT)
		{
			dictionary.Add(11, n_ITEM_COUNT);
		}
		if (n_ITEM_LIMIT != tbl.n_ITEM_LIMIT)
		{
			dictionary.Add(12, n_ITEM_LIMIT);
		}
		if (n_COUNTER != tbl.n_COUNTER)
		{
			dictionary.Add(13, n_COUNTER);
		}
		if (n_REPLACEITEM != tbl.n_REPLACEITEM)
		{
			dictionary.Add(14, n_REPLACEITEM);
		}
		if (n_REPLACEITEM_COUNT != tbl.n_REPLACEITEM_COUNT)
		{
			dictionary.Add(15, n_REPLACEITEM_COUNT);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(16, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(17, s_END_VERSION);
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
				n_MIN_1 = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_MAX_1 = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_MIN_2 = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_MAX_2 = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_MIN_3 = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_MAX_3 = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_MIN_4 = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_MAX_4 = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_ITEM = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_ITEM_COUNT = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_ITEM_LIMIT = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_COUNTER = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_REPLACEITEM = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_REPLACEITEM_COUNT = Convert.ToInt32(item.Value);
				break;
			case 16:
				s_START_VERSION = item.Value.ToString();
				break;
			case 17:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(LABOEVENT_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (n_MIN_1 != table.n_MIN_1)
		{
			return false;
		}
		if (n_MAX_1 != table.n_MAX_1)
		{
			return false;
		}
		if (n_MIN_2 != table.n_MIN_2)
		{
			return false;
		}
		if (n_MAX_2 != table.n_MAX_2)
		{
			return false;
		}
		if (n_MIN_3 != table.n_MIN_3)
		{
			return false;
		}
		if (n_MAX_3 != table.n_MAX_3)
		{
			return false;
		}
		if (n_MIN_4 != table.n_MIN_4)
		{
			return false;
		}
		if (n_MAX_4 != table.n_MAX_4)
		{
			return false;
		}
		if (n_ITEM != table.n_ITEM)
		{
			return false;
		}
		if (n_ITEM_COUNT != table.n_ITEM_COUNT)
		{
			return false;
		}
		if (n_ITEM_LIMIT != table.n_ITEM_LIMIT)
		{
			return false;
		}
		if (n_COUNTER != table.n_COUNTER)
		{
			return false;
		}
		if (n_REPLACEITEM != table.n_REPLACEITEM)
		{
			return false;
		}
		if (n_REPLACEITEM_COUNT != table.n_REPLACEITEM_COUNT)
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
		binaryWriter.Write(n_MIN_1);
		binaryWriter.Write(n_MAX_1);
		binaryWriter.Write(n_MIN_2);
		binaryWriter.Write(n_MAX_2);
		binaryWriter.Write(n_MIN_3);
		binaryWriter.Write(n_MAX_3);
		binaryWriter.Write(n_MIN_4);
		binaryWriter.Write(n_MAX_4);
		binaryWriter.Write(n_ITEM);
		binaryWriter.Write(n_ITEM_COUNT);
		binaryWriter.Write(n_ITEM_LIMIT);
		binaryWriter.Write(n_COUNTER);
		binaryWriter.Write(n_REPLACEITEM);
		binaryWriter.Write(n_REPLACEITEM_COUNT);
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
		n_MIN_1 = binaryReader.ReadInt32();
		n_MAX_1 = binaryReader.ReadInt32();
		n_MIN_2 = binaryReader.ReadInt32();
		n_MAX_2 = binaryReader.ReadInt32();
		n_MIN_3 = binaryReader.ReadInt32();
		n_MAX_3 = binaryReader.ReadInt32();
		n_MIN_4 = binaryReader.ReadInt32();
		n_MAX_4 = binaryReader.ReadInt32();
		n_ITEM = binaryReader.ReadInt32();
		n_ITEM_COUNT = binaryReader.ReadInt32();
		n_ITEM_LIMIT = binaryReader.ReadInt32();
		n_COUNTER = binaryReader.ReadInt32();
		n_REPLACEITEM = binaryReader.ReadInt32();
		n_REPLACEITEM_COUNT = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
