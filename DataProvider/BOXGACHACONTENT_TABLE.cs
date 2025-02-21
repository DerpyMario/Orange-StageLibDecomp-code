using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class BOXGACHACONTENT_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		n_REWARD_TYPE,
		n_REWARD_ID,
		n_AMOUNT_MIN,
		n_AMOUNT_MAX,
		n_TOTAL,
		n_PICKUP,
		n_VALUE
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_REWARD_TYPE { get; set; }

	[Preserve]
	public int n_REWARD_ID { get; set; }

	[Preserve]
	public int n_AMOUNT_MIN { get; set; }

	[Preserve]
	public int n_AMOUNT_MAX { get; set; }

	[Preserve]
	public int n_TOTAL { get; set; }

	[Preserve]
	public int n_PICKUP { get; set; }

	[Preserve]
	public int n_VALUE { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(BOXGACHACONTENT_TABLE tbl)
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
		if (n_REWARD_TYPE != tbl.n_REWARD_TYPE)
		{
			dictionary.Add(2, n_REWARD_TYPE);
		}
		if (n_REWARD_ID != tbl.n_REWARD_ID)
		{
			dictionary.Add(3, n_REWARD_ID);
		}
		if (n_AMOUNT_MIN != tbl.n_AMOUNT_MIN)
		{
			dictionary.Add(4, n_AMOUNT_MIN);
		}
		if (n_AMOUNT_MAX != tbl.n_AMOUNT_MAX)
		{
			dictionary.Add(5, n_AMOUNT_MAX);
		}
		if (n_TOTAL != tbl.n_TOTAL)
		{
			dictionary.Add(6, n_TOTAL);
		}
		if (n_PICKUP != tbl.n_PICKUP)
		{
			dictionary.Add(7, n_PICKUP);
		}
		if (n_VALUE != tbl.n_VALUE)
		{
			dictionary.Add(8, n_VALUE);
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
				n_REWARD_TYPE = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_REWARD_ID = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_AMOUNT_MIN = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_AMOUNT_MAX = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_TOTAL = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_PICKUP = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_VALUE = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(BOXGACHACONTENT_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
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
		if (n_TOTAL != table.n_TOTAL)
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
		return true;
	}

	public string ConvertToString()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(n_ID);
		binaryWriter.Write(n_GROUP);
		binaryWriter.Write(n_REWARD_TYPE);
		binaryWriter.Write(n_REWARD_ID);
		binaryWriter.Write(n_AMOUNT_MIN);
		binaryWriter.Write(n_AMOUNT_MAX);
		binaryWriter.Write(n_TOTAL);
		binaryWriter.Write(n_PICKUP);
		binaryWriter.Write(n_VALUE);
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
		n_REWARD_TYPE = binaryReader.ReadInt32();
		n_REWARD_ID = binaryReader.ReadInt32();
		n_AMOUNT_MIN = binaryReader.ReadInt32();
		n_AMOUNT_MAX = binaryReader.ReadInt32();
		n_TOTAL = binaryReader.ReadInt32();
		n_PICKUP = binaryReader.ReadInt32();
		n_VALUE = binaryReader.ReadInt32();
	}
}
