using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class INITIAL_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_LV,
		n_UPGRADE,
		n_RANK
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_LV { get; set; }

	[Preserve]
	public int n_UPGRADE { get; set; }

	[Preserve]
	public int n_RANK { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(INITIAL_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_LV != tbl.n_LV)
		{
			dictionary.Add(1, n_LV);
		}
		if (n_UPGRADE != tbl.n_UPGRADE)
		{
			dictionary.Add(2, n_UPGRADE);
		}
		if (n_RANK != tbl.n_RANK)
		{
			dictionary.Add(3, n_RANK);
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
				n_LV = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_UPGRADE = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_RANK = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(INITIAL_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_LV != table.n_LV)
		{
			return false;
		}
		if (n_UPGRADE != table.n_UPGRADE)
		{
			return false;
		}
		if (n_RANK != table.n_RANK)
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
		binaryWriter.Write(n_LV);
		binaryWriter.Write(n_UPGRADE);
		binaryWriter.Write(n_RANK);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_LV = binaryReader.ReadInt32();
		n_UPGRADE = binaryReader.ReadInt32();
		n_RANK = binaryReader.ReadInt32();
	}
}
