using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class ITEM_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		n_TYPE_X,
		s_NAME,
		s_ICON,
		n_RARE,
		f_VALUE_X,
		f_VALUE_Y,
		n_SELL_ID,
		n_SELL_COUNT,
		n_DNA_CONVERT,
		n_MAX,
		n_FAKEITEM,
		s_HOWTOGET,
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
	public int n_TYPE_X { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public int n_RARE { get; set; }

	[Preserve]
	public float f_VALUE_X { get; set; }

	[Preserve]
	public float f_VALUE_Y { get; set; }

	[Preserve]
	public int n_SELL_ID { get; set; }

	[Preserve]
	public int n_SELL_COUNT { get; set; }

	[Preserve]
	public int n_DNA_CONVERT { get; set; }

	[Preserve]
	public int n_MAX { get; set; }

	[Preserve]
	public int n_FAKEITEM { get; set; }

	[Preserve]
	public string s_HOWTOGET { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string w_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(ITEM_TABLE tbl)
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
		if (s_NAME != tbl.s_NAME)
		{
			dictionary.Add(3, s_NAME);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(4, s_ICON);
		}
		if (n_RARE != tbl.n_RARE)
		{
			dictionary.Add(5, n_RARE);
		}
		if (f_VALUE_X != tbl.f_VALUE_X)
		{
			dictionary.Add(6, f_VALUE_X);
		}
		if (f_VALUE_Y != tbl.f_VALUE_Y)
		{
			dictionary.Add(7, f_VALUE_Y);
		}
		if (n_SELL_ID != tbl.n_SELL_ID)
		{
			dictionary.Add(8, n_SELL_ID);
		}
		if (n_SELL_COUNT != tbl.n_SELL_COUNT)
		{
			dictionary.Add(9, n_SELL_COUNT);
		}
		if (n_DNA_CONVERT != tbl.n_DNA_CONVERT)
		{
			dictionary.Add(10, n_DNA_CONVERT);
		}
		if (n_MAX != tbl.n_MAX)
		{
			dictionary.Add(11, n_MAX);
		}
		if (n_FAKEITEM != tbl.n_FAKEITEM)
		{
			dictionary.Add(12, n_FAKEITEM);
		}
		if (s_HOWTOGET != tbl.s_HOWTOGET)
		{
			dictionary.Add(13, s_HOWTOGET);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(14, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(15, s_END_VERSION);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(16, w_NAME);
		}
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(17, w_TIP);
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
				s_NAME = item.Value.ToString();
				break;
			case 4:
				s_ICON = item.Value.ToString();
				break;
			case 5:
				n_RARE = Convert.ToInt32(item.Value);
				break;
			case 6:
				f_VALUE_X = Convert.ToSingle(item.Value);
				break;
			case 7:
				f_VALUE_Y = Convert.ToSingle(item.Value);
				break;
			case 8:
				n_SELL_ID = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_SELL_COUNT = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_DNA_CONVERT = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_MAX = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_FAKEITEM = Convert.ToInt32(item.Value);
				break;
			case 13:
				s_HOWTOGET = item.Value.ToString();
				break;
			case 14:
				s_START_VERSION = item.Value.ToString();
				break;
			case 15:
				s_END_VERSION = item.Value.ToString();
				break;
			case 16:
				w_NAME = item.Value.ToString();
				break;
			case 17:
				w_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(ITEM_TABLE table)
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
		if (f_VALUE_X != table.f_VALUE_X)
		{
			return false;
		}
		if (f_VALUE_Y != table.f_VALUE_Y)
		{
			return false;
		}
		if (n_SELL_ID != table.n_SELL_ID)
		{
			return false;
		}
		if (n_SELL_COUNT != table.n_SELL_COUNT)
		{
			return false;
		}
		if (n_DNA_CONVERT != table.n_DNA_CONVERT)
		{
			return false;
		}
		if (n_MAX != table.n_MAX)
		{
			return false;
		}
		if (n_FAKEITEM != table.n_FAKEITEM)
		{
			return false;
		}
		if (s_HOWTOGET != table.s_HOWTOGET)
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
		binaryWriter.Write(n_TYPE_X);
		binaryWriter.WriteExString(s_NAME);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.Write(n_RARE);
		binaryWriter.Write(f_VALUE_X);
		binaryWriter.Write(f_VALUE_Y);
		binaryWriter.Write(n_SELL_ID);
		binaryWriter.Write(n_SELL_COUNT);
		binaryWriter.Write(n_DNA_CONVERT);
		binaryWriter.Write(n_MAX);
		binaryWriter.Write(n_FAKEITEM);
		binaryWriter.WriteExString(s_HOWTOGET);
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
		n_TYPE_X = binaryReader.ReadInt32();
		s_NAME = binaryReader.ReadExString();
		s_ICON = binaryReader.ReadExString();
		n_RARE = binaryReader.ReadInt32();
		f_VALUE_X = binaryReader.ReadSingle();
		f_VALUE_Y = binaryReader.ReadSingle();
		n_SELL_ID = binaryReader.ReadInt32();
		n_SELL_COUNT = binaryReader.ReadInt32();
		n_DNA_CONVERT = binaryReader.ReadInt32();
		n_MAX = binaryReader.ReadInt32();
		n_FAKEITEM = binaryReader.ReadInt32();
		s_HOWTOGET = binaryReader.ReadExString();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		w_NAME = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
	}
}
