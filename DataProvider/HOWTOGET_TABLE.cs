using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class HOWTOGET_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_UILINK,
		n_VALUE_X,
		n_VALUE_Y,
		n_VALUE_Z,
		n_RANK,
		s_START_VERSION,
		s_END_VERSION,
		w_NAME,
		w_TIP
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_UILINK { get; set; }

	[Preserve]
	public int n_VALUE_X { get; set; }

	[Preserve]
	public int n_VALUE_Y { get; set; }

	[Preserve]
	public int n_VALUE_Z { get; set; }

	[Preserve]
	public int n_RANK { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string w_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(HOWTOGET_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_UILINK != tbl.n_UILINK)
		{
			dictionary.Add(1, n_UILINK);
		}
		if (n_VALUE_X != tbl.n_VALUE_X)
		{
			dictionary.Add(2, n_VALUE_X);
		}
		if (n_VALUE_Y != tbl.n_VALUE_Y)
		{
			dictionary.Add(3, n_VALUE_Y);
		}
		if (n_VALUE_Z != tbl.n_VALUE_Z)
		{
			dictionary.Add(4, n_VALUE_Z);
		}
		if (n_RANK != tbl.n_RANK)
		{
			dictionary.Add(5, n_RANK);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(6, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(7, s_END_VERSION);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(8, w_NAME);
		}
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(9, w_TIP);
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
				n_UILINK = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_VALUE_X = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_VALUE_Y = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_VALUE_Z = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_RANK = Convert.ToInt32(item.Value);
				break;
			case 6:
				s_START_VERSION = item.Value.ToString();
				break;
			case 7:
				s_END_VERSION = item.Value.ToString();
				break;
			case 8:
				w_NAME = item.Value.ToString();
				break;
			case 9:
				w_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(HOWTOGET_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_UILINK != table.n_UILINK)
		{
			return false;
		}
		if (n_VALUE_X != table.n_VALUE_X)
		{
			return false;
		}
		if (n_VALUE_Y != table.n_VALUE_Y)
		{
			return false;
		}
		if (n_VALUE_Z != table.n_VALUE_Z)
		{
			return false;
		}
		if (n_RANK != table.n_RANK)
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
		binaryWriter.Write(n_UILINK);
		binaryWriter.Write(n_VALUE_X);
		binaryWriter.Write(n_VALUE_Y);
		binaryWriter.Write(n_VALUE_Z);
		binaryWriter.Write(n_RANK);
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
		n_UILINK = binaryReader.ReadInt32();
		n_VALUE_X = binaryReader.ReadInt32();
		n_VALUE_Y = binaryReader.ReadInt32();
		n_VALUE_Z = binaryReader.ReadInt32();
		n_RANK = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		w_NAME = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
	}
}
