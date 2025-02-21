using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class GALLERY_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		n_MAINID,
		s_ICON,
		n_CONDITION,
		n_CONDITION_STEP,
		n_CONDITION_X,
		n_CONDITION_Y,
		n_EXP,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_MAINID { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public int n_CONDITION { get; set; }

	[Preserve]
	public int n_CONDITION_STEP { get; set; }

	[Preserve]
	public int n_CONDITION_X { get; set; }

	[Preserve]
	public int n_CONDITION_Y { get; set; }

	[Preserve]
	public int n_EXP { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(GALLERY_TABLE tbl)
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
		if (n_MAINID != tbl.n_MAINID)
		{
			dictionary.Add(2, n_MAINID);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(3, s_ICON);
		}
		if (n_CONDITION != tbl.n_CONDITION)
		{
			dictionary.Add(4, n_CONDITION);
		}
		if (n_CONDITION_STEP != tbl.n_CONDITION_STEP)
		{
			dictionary.Add(5, n_CONDITION_STEP);
		}
		if (n_CONDITION_X != tbl.n_CONDITION_X)
		{
			dictionary.Add(6, n_CONDITION_X);
		}
		if (n_CONDITION_Y != tbl.n_CONDITION_Y)
		{
			dictionary.Add(7, n_CONDITION_Y);
		}
		if (n_EXP != tbl.n_EXP)
		{
			dictionary.Add(8, n_EXP);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(9, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(10, s_END_VERSION);
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
				n_MAINID = Convert.ToInt32(item.Value);
				break;
			case 3:
				s_ICON = item.Value.ToString();
				break;
			case 4:
				n_CONDITION = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_CONDITION_STEP = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_CONDITION_X = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_CONDITION_Y = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_EXP = Convert.ToInt32(item.Value);
				break;
			case 9:
				s_START_VERSION = item.Value.ToString();
				break;
			case 10:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(GALLERY_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_MAINID != table.n_MAINID)
		{
			return false;
		}
		if (s_ICON != table.s_ICON)
		{
			return false;
		}
		if (n_CONDITION != table.n_CONDITION)
		{
			return false;
		}
		if (n_CONDITION_STEP != table.n_CONDITION_STEP)
		{
			return false;
		}
		if (n_CONDITION_X != table.n_CONDITION_X)
		{
			return false;
		}
		if (n_CONDITION_Y != table.n_CONDITION_Y)
		{
			return false;
		}
		if (n_EXP != table.n_EXP)
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
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_MAINID);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.Write(n_CONDITION);
		binaryWriter.Write(n_CONDITION_STEP);
		binaryWriter.Write(n_CONDITION_X);
		binaryWriter.Write(n_CONDITION_Y);
		binaryWriter.Write(n_EXP);
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
		n_TYPE = binaryReader.ReadInt32();
		n_MAINID = binaryReader.ReadInt32();
		s_ICON = binaryReader.ReadExString();
		n_CONDITION = binaryReader.ReadInt32();
		n_CONDITION_STEP = binaryReader.ReadInt32();
		n_CONDITION_X = binaryReader.ReadInt32();
		n_CONDITION_Y = binaryReader.ReadInt32();
		n_EXP = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
