using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class HUNTERRANK_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		s_NAME,
		s_IMG,
		n_MAIN_RANK,
		n_SUB_RANK,
		n_PT_MIN,
		n_PT_MAX,
		n_PTRESULT_MAX,
		n_PT_WIN,
		n_PT_LOSE,
		n_RESET,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public string s_IMG { get; set; }

	[Preserve]
	public int n_MAIN_RANK { get; set; }

	[Preserve]
	public int n_SUB_RANK { get; set; }

	[Preserve]
	public int n_PT_MIN { get; set; }

	[Preserve]
	public int n_PT_MAX { get; set; }

	[Preserve]
	public int n_PTRESULT_MAX { get; set; }

	[Preserve]
	public int n_PT_WIN { get; set; }

	[Preserve]
	public int n_PT_LOSE { get; set; }

	[Preserve]
	public int n_RESET { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(HUNTERRANK_TABLE tbl)
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
		if (s_IMG != tbl.s_IMG)
		{
			dictionary.Add(2, s_IMG);
		}
		if (n_MAIN_RANK != tbl.n_MAIN_RANK)
		{
			dictionary.Add(3, n_MAIN_RANK);
		}
		if (n_SUB_RANK != tbl.n_SUB_RANK)
		{
			dictionary.Add(4, n_SUB_RANK);
		}
		if (n_PT_MIN != tbl.n_PT_MIN)
		{
			dictionary.Add(5, n_PT_MIN);
		}
		if (n_PT_MAX != tbl.n_PT_MAX)
		{
			dictionary.Add(6, n_PT_MAX);
		}
		if (n_PTRESULT_MAX != tbl.n_PTRESULT_MAX)
		{
			dictionary.Add(7, n_PTRESULT_MAX);
		}
		if (n_PT_WIN != tbl.n_PT_WIN)
		{
			dictionary.Add(8, n_PT_WIN);
		}
		if (n_PT_LOSE != tbl.n_PT_LOSE)
		{
			dictionary.Add(9, n_PT_LOSE);
		}
		if (n_RESET != tbl.n_RESET)
		{
			dictionary.Add(10, n_RESET);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(11, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(12, s_END_VERSION);
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
				s_IMG = item.Value.ToString();
				break;
			case 3:
				n_MAIN_RANK = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_SUB_RANK = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_PT_MIN = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_PT_MAX = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_PTRESULT_MAX = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_PT_WIN = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_PT_LOSE = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_RESET = Convert.ToInt32(item.Value);
				break;
			case 11:
				s_START_VERSION = item.Value.ToString();
				break;
			case 12:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(HUNTERRANK_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (s_NAME != table.s_NAME)
		{
			return false;
		}
		if (s_IMG != table.s_IMG)
		{
			return false;
		}
		if (n_MAIN_RANK != table.n_MAIN_RANK)
		{
			return false;
		}
		if (n_SUB_RANK != table.n_SUB_RANK)
		{
			return false;
		}
		if (n_PT_MIN != table.n_PT_MIN)
		{
			return false;
		}
		if (n_PT_MAX != table.n_PT_MAX)
		{
			return false;
		}
		if (n_PTRESULT_MAX != table.n_PTRESULT_MAX)
		{
			return false;
		}
		if (n_PT_WIN != table.n_PT_WIN)
		{
			return false;
		}
		if (n_PT_LOSE != table.n_PT_LOSE)
		{
			return false;
		}
		if (n_RESET != table.n_RESET)
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
		binaryWriter.WriteExString(s_IMG);
		binaryWriter.Write(n_MAIN_RANK);
		binaryWriter.Write(n_SUB_RANK);
		binaryWriter.Write(n_PT_MIN);
		binaryWriter.Write(n_PT_MAX);
		binaryWriter.Write(n_PTRESULT_MAX);
		binaryWriter.Write(n_PT_WIN);
		binaryWriter.Write(n_PT_LOSE);
		binaryWriter.Write(n_RESET);
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
		s_IMG = binaryReader.ReadExString();
		n_MAIN_RANK = binaryReader.ReadInt32();
		n_SUB_RANK = binaryReader.ReadInt32();
		n_PT_MIN = binaryReader.ReadInt32();
		n_PT_MAX = binaryReader.ReadInt32();
		n_PTRESULT_MAX = binaryReader.ReadInt32();
		n_PT_WIN = binaryReader.ReadInt32();
		n_PT_LOSE = binaryReader.ReadInt32();
		n_RESET = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
