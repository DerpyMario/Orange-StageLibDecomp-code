using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class BOXGACHA_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		n_BOXGACHA_TYPE,
		n_PRE,
		n_CYCLE,
		n_COIN_ID,
		n_COIN_MOUNT,
		n_GACHA
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_BOXGACHA_TYPE { get; set; }

	[Preserve]
	public int n_PRE { get; set; }

	[Preserve]
	public int n_CYCLE { get; set; }

	[Preserve]
	public int n_COIN_ID { get; set; }

	[Preserve]
	public int n_COIN_MOUNT { get; set; }

	[Preserve]
	public int n_GACHA { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(BOXGACHA_TABLE tbl)
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
		if (n_BOXGACHA_TYPE != tbl.n_BOXGACHA_TYPE)
		{
			dictionary.Add(2, n_BOXGACHA_TYPE);
		}
		if (n_PRE != tbl.n_PRE)
		{
			dictionary.Add(3, n_PRE);
		}
		if (n_CYCLE != tbl.n_CYCLE)
		{
			dictionary.Add(4, n_CYCLE);
		}
		if (n_COIN_ID != tbl.n_COIN_ID)
		{
			dictionary.Add(5, n_COIN_ID);
		}
		if (n_COIN_MOUNT != tbl.n_COIN_MOUNT)
		{
			dictionary.Add(6, n_COIN_MOUNT);
		}
		if (n_GACHA != tbl.n_GACHA)
		{
			dictionary.Add(7, n_GACHA);
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
				n_BOXGACHA_TYPE = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_PRE = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_CYCLE = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_COIN_ID = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_COIN_MOUNT = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_GACHA = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(BOXGACHA_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (n_BOXGACHA_TYPE != table.n_BOXGACHA_TYPE)
		{
			return false;
		}
		if (n_PRE != table.n_PRE)
		{
			return false;
		}
		if (n_CYCLE != table.n_CYCLE)
		{
			return false;
		}
		if (n_COIN_ID != table.n_COIN_ID)
		{
			return false;
		}
		if (n_COIN_MOUNT != table.n_COIN_MOUNT)
		{
			return false;
		}
		if (n_GACHA != table.n_GACHA)
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
		binaryWriter.Write(n_BOXGACHA_TYPE);
		binaryWriter.Write(n_PRE);
		binaryWriter.Write(n_CYCLE);
		binaryWriter.Write(n_COIN_ID);
		binaryWriter.Write(n_COIN_MOUNT);
		binaryWriter.Write(n_GACHA);
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
		n_BOXGACHA_TYPE = binaryReader.ReadInt32();
		n_PRE = binaryReader.ReadInt32();
		n_CYCLE = binaryReader.ReadInt32();
		n_COIN_ID = binaryReader.ReadInt32();
		n_COIN_MOUNT = binaryReader.ReadInt32();
		n_GACHA = binaryReader.ReadInt32();
	}
}
