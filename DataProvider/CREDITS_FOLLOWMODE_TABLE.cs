using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class CREDITS_FOLLOWMODE_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_FOLLOW_MODE,
		n_TIMEDIFF
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_FOLLOW_MODE { get; set; }

	[Preserve]
	public int n_TIMEDIFF { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(CREDITS_FOLLOWMODE_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_FOLLOW_MODE != tbl.n_FOLLOW_MODE)
		{
			dictionary.Add(1, n_FOLLOW_MODE);
		}
		if (n_TIMEDIFF != tbl.n_TIMEDIFF)
		{
			dictionary.Add(2, n_TIMEDIFF);
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
				n_FOLLOW_MODE = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_TIMEDIFF = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(CREDITS_FOLLOWMODE_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_FOLLOW_MODE != table.n_FOLLOW_MODE)
		{
			return false;
		}
		if (n_TIMEDIFF != table.n_TIMEDIFF)
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
		binaryWriter.Write(n_FOLLOW_MODE);
		binaryWriter.Write(n_TIMEDIFF);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_FOLLOW_MODE = binaryReader.ReadInt32();
		n_TIMEDIFF = binaryReader.ReadInt32();
	}
}
