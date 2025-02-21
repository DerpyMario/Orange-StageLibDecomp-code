using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class POWER_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_POWER_INTEGRAL,
		n_POWER_MONEY,
		n_POWER_LIMIT
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_POWER_INTEGRAL { get; set; }

	[Preserve]
	public int n_POWER_MONEY { get; set; }

	[Preserve]
	public int n_POWER_LIMIT { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(POWER_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_POWER_INTEGRAL != tbl.n_POWER_INTEGRAL)
		{
			dictionary.Add(1, n_POWER_INTEGRAL);
		}
		if (n_POWER_MONEY != tbl.n_POWER_MONEY)
		{
			dictionary.Add(2, n_POWER_MONEY);
		}
		if (n_POWER_LIMIT != tbl.n_POWER_LIMIT)
		{
			dictionary.Add(3, n_POWER_LIMIT);
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
				n_POWER_INTEGRAL = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_POWER_MONEY = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_POWER_LIMIT = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(POWER_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_POWER_INTEGRAL != table.n_POWER_INTEGRAL)
		{
			return false;
		}
		if (n_POWER_MONEY != table.n_POWER_MONEY)
		{
			return false;
		}
		if (n_POWER_LIMIT != table.n_POWER_LIMIT)
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
		binaryWriter.Write(n_POWER_INTEGRAL);
		binaryWriter.Write(n_POWER_MONEY);
		binaryWriter.Write(n_POWER_LIMIT);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_POWER_INTEGRAL = binaryReader.ReadInt32();
		n_POWER_MONEY = binaryReader.ReadInt32();
		n_POWER_LIMIT = binaryReader.ReadInt32();
	}
}
