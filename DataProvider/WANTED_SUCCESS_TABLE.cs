using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class WANTED_SUCCESS_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GUILD_WANTED_RATE_1,
		n_GUILD_WANTED_RATE_2,
		n_GUILD_WANTED_RATE_3,
		n_GUILD_WANTED_RATE_4,
		n_GUILD_WANTED_RATE_5,
		n_GUILD_WANTED_RATE_6,
		n_GUILD_WANTED_RATE_7,
		n_GUILD_WANTED_RATE_8,
		n_GUILD_WANTED_RATE_9,
		n_GUILD_WANTED_RATE_10,
		n_GUILD_WANTED_RATE_11,
		n_GUILD_WANTED_RATE_12
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GUILD_WANTED_RATE_1 { get; set; }

	[Preserve]
	public int n_GUILD_WANTED_RATE_2 { get; set; }

	[Preserve]
	public int n_GUILD_WANTED_RATE_3 { get; set; }

	[Preserve]
	public int n_GUILD_WANTED_RATE_4 { get; set; }

	[Preserve]
	public int n_GUILD_WANTED_RATE_5 { get; set; }

	[Preserve]
	public int n_GUILD_WANTED_RATE_6 { get; set; }

	[Preserve]
	public int n_GUILD_WANTED_RATE_7 { get; set; }

	[Preserve]
	public int n_GUILD_WANTED_RATE_8 { get; set; }

	[Preserve]
	public int n_GUILD_WANTED_RATE_9 { get; set; }

	[Preserve]
	public int n_GUILD_WANTED_RATE_10 { get; set; }

	[Preserve]
	public int n_GUILD_WANTED_RATE_11 { get; set; }

	[Preserve]
	public int n_GUILD_WANTED_RATE_12 { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(WANTED_SUCCESS_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_GUILD_WANTED_RATE_1 != tbl.n_GUILD_WANTED_RATE_1)
		{
			dictionary.Add(1, n_GUILD_WANTED_RATE_1);
		}
		if (n_GUILD_WANTED_RATE_2 != tbl.n_GUILD_WANTED_RATE_2)
		{
			dictionary.Add(2, n_GUILD_WANTED_RATE_2);
		}
		if (n_GUILD_WANTED_RATE_3 != tbl.n_GUILD_WANTED_RATE_3)
		{
			dictionary.Add(3, n_GUILD_WANTED_RATE_3);
		}
		if (n_GUILD_WANTED_RATE_4 != tbl.n_GUILD_WANTED_RATE_4)
		{
			dictionary.Add(4, n_GUILD_WANTED_RATE_4);
		}
		if (n_GUILD_WANTED_RATE_5 != tbl.n_GUILD_WANTED_RATE_5)
		{
			dictionary.Add(5, n_GUILD_WANTED_RATE_5);
		}
		if (n_GUILD_WANTED_RATE_6 != tbl.n_GUILD_WANTED_RATE_6)
		{
			dictionary.Add(6, n_GUILD_WANTED_RATE_6);
		}
		if (n_GUILD_WANTED_RATE_7 != tbl.n_GUILD_WANTED_RATE_7)
		{
			dictionary.Add(7, n_GUILD_WANTED_RATE_7);
		}
		if (n_GUILD_WANTED_RATE_8 != tbl.n_GUILD_WANTED_RATE_8)
		{
			dictionary.Add(8, n_GUILD_WANTED_RATE_8);
		}
		if (n_GUILD_WANTED_RATE_9 != tbl.n_GUILD_WANTED_RATE_9)
		{
			dictionary.Add(9, n_GUILD_WANTED_RATE_9);
		}
		if (n_GUILD_WANTED_RATE_10 != tbl.n_GUILD_WANTED_RATE_10)
		{
			dictionary.Add(10, n_GUILD_WANTED_RATE_10);
		}
		if (n_GUILD_WANTED_RATE_11 != tbl.n_GUILD_WANTED_RATE_11)
		{
			dictionary.Add(11, n_GUILD_WANTED_RATE_11);
		}
		if (n_GUILD_WANTED_RATE_12 != tbl.n_GUILD_WANTED_RATE_12)
		{
			dictionary.Add(12, n_GUILD_WANTED_RATE_12);
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
				n_GUILD_WANTED_RATE_1 = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_GUILD_WANTED_RATE_2 = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_GUILD_WANTED_RATE_3 = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_GUILD_WANTED_RATE_4 = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_GUILD_WANTED_RATE_5 = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_GUILD_WANTED_RATE_6 = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_GUILD_WANTED_RATE_7 = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_GUILD_WANTED_RATE_8 = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_GUILD_WANTED_RATE_9 = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_GUILD_WANTED_RATE_10 = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_GUILD_WANTED_RATE_11 = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_GUILD_WANTED_RATE_12 = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(WANTED_SUCCESS_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GUILD_WANTED_RATE_1 != table.n_GUILD_WANTED_RATE_1)
		{
			return false;
		}
		if (n_GUILD_WANTED_RATE_2 != table.n_GUILD_WANTED_RATE_2)
		{
			return false;
		}
		if (n_GUILD_WANTED_RATE_3 != table.n_GUILD_WANTED_RATE_3)
		{
			return false;
		}
		if (n_GUILD_WANTED_RATE_4 != table.n_GUILD_WANTED_RATE_4)
		{
			return false;
		}
		if (n_GUILD_WANTED_RATE_5 != table.n_GUILD_WANTED_RATE_5)
		{
			return false;
		}
		if (n_GUILD_WANTED_RATE_6 != table.n_GUILD_WANTED_RATE_6)
		{
			return false;
		}
		if (n_GUILD_WANTED_RATE_7 != table.n_GUILD_WANTED_RATE_7)
		{
			return false;
		}
		if (n_GUILD_WANTED_RATE_8 != table.n_GUILD_WANTED_RATE_8)
		{
			return false;
		}
		if (n_GUILD_WANTED_RATE_9 != table.n_GUILD_WANTED_RATE_9)
		{
			return false;
		}
		if (n_GUILD_WANTED_RATE_10 != table.n_GUILD_WANTED_RATE_10)
		{
			return false;
		}
		if (n_GUILD_WANTED_RATE_11 != table.n_GUILD_WANTED_RATE_11)
		{
			return false;
		}
		if (n_GUILD_WANTED_RATE_12 != table.n_GUILD_WANTED_RATE_12)
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
		binaryWriter.Write(n_GUILD_WANTED_RATE_1);
		binaryWriter.Write(n_GUILD_WANTED_RATE_2);
		binaryWriter.Write(n_GUILD_WANTED_RATE_3);
		binaryWriter.Write(n_GUILD_WANTED_RATE_4);
		binaryWriter.Write(n_GUILD_WANTED_RATE_5);
		binaryWriter.Write(n_GUILD_WANTED_RATE_6);
		binaryWriter.Write(n_GUILD_WANTED_RATE_7);
		binaryWriter.Write(n_GUILD_WANTED_RATE_8);
		binaryWriter.Write(n_GUILD_WANTED_RATE_9);
		binaryWriter.Write(n_GUILD_WANTED_RATE_10);
		binaryWriter.Write(n_GUILD_WANTED_RATE_11);
		binaryWriter.Write(n_GUILD_WANTED_RATE_12);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_GUILD_WANTED_RATE_1 = binaryReader.ReadInt32();
		n_GUILD_WANTED_RATE_2 = binaryReader.ReadInt32();
		n_GUILD_WANTED_RATE_3 = binaryReader.ReadInt32();
		n_GUILD_WANTED_RATE_4 = binaryReader.ReadInt32();
		n_GUILD_WANTED_RATE_5 = binaryReader.ReadInt32();
		n_GUILD_WANTED_RATE_6 = binaryReader.ReadInt32();
		n_GUILD_WANTED_RATE_7 = binaryReader.ReadInt32();
		n_GUILD_WANTED_RATE_8 = binaryReader.ReadInt32();
		n_GUILD_WANTED_RATE_9 = binaryReader.ReadInt32();
		n_GUILD_WANTED_RATE_10 = binaryReader.ReadInt32();
		n_GUILD_WANTED_RATE_11 = binaryReader.ReadInt32();
		n_GUILD_WANTED_RATE_12 = binaryReader.ReadInt32();
	}
}
