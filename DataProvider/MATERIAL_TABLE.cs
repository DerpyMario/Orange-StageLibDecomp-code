using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class MATERIAL_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_MATERIAL_1,
		n_MATERIAL_MOUNT1,
		n_MATERIAL_2,
		n_MATERIAL_MOUNT2,
		n_MATERIAL_3,
		n_MATERIAL_MOUNT3,
		n_MATERIAL_4,
		n_MATERIAL_MOUNT4,
		n_MATERIAL_5,
		n_MATERIAL_MOUNT5,
		n_MONEY
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_MATERIAL_1 { get; set; }

	[Preserve]
	public int n_MATERIAL_MOUNT1 { get; set; }

	[Preserve]
	public int n_MATERIAL_2 { get; set; }

	[Preserve]
	public int n_MATERIAL_MOUNT2 { get; set; }

	[Preserve]
	public int n_MATERIAL_3 { get; set; }

	[Preserve]
	public int n_MATERIAL_MOUNT3 { get; set; }

	[Preserve]
	public int n_MATERIAL_4 { get; set; }

	[Preserve]
	public int n_MATERIAL_MOUNT4 { get; set; }

	[Preserve]
	public int n_MATERIAL_5 { get; set; }

	[Preserve]
	public int n_MATERIAL_MOUNT5 { get; set; }

	[Preserve]
	public int n_MONEY { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(MATERIAL_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_MATERIAL_1 != tbl.n_MATERIAL_1)
		{
			dictionary.Add(1, n_MATERIAL_1);
		}
		if (n_MATERIAL_MOUNT1 != tbl.n_MATERIAL_MOUNT1)
		{
			dictionary.Add(2, n_MATERIAL_MOUNT1);
		}
		if (n_MATERIAL_2 != tbl.n_MATERIAL_2)
		{
			dictionary.Add(3, n_MATERIAL_2);
		}
		if (n_MATERIAL_MOUNT2 != tbl.n_MATERIAL_MOUNT2)
		{
			dictionary.Add(4, n_MATERIAL_MOUNT2);
		}
		if (n_MATERIAL_3 != tbl.n_MATERIAL_3)
		{
			dictionary.Add(5, n_MATERIAL_3);
		}
		if (n_MATERIAL_MOUNT3 != tbl.n_MATERIAL_MOUNT3)
		{
			dictionary.Add(6, n_MATERIAL_MOUNT3);
		}
		if (n_MATERIAL_4 != tbl.n_MATERIAL_4)
		{
			dictionary.Add(7, n_MATERIAL_4);
		}
		if (n_MATERIAL_MOUNT4 != tbl.n_MATERIAL_MOUNT4)
		{
			dictionary.Add(8, n_MATERIAL_MOUNT4);
		}
		if (n_MATERIAL_5 != tbl.n_MATERIAL_5)
		{
			dictionary.Add(9, n_MATERIAL_5);
		}
		if (n_MATERIAL_MOUNT5 != tbl.n_MATERIAL_MOUNT5)
		{
			dictionary.Add(10, n_MATERIAL_MOUNT5);
		}
		if (n_MONEY != tbl.n_MONEY)
		{
			dictionary.Add(11, n_MONEY);
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
				n_MATERIAL_1 = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_MATERIAL_MOUNT1 = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_MATERIAL_2 = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_MATERIAL_MOUNT2 = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_MATERIAL_3 = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_MATERIAL_MOUNT3 = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_MATERIAL_4 = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_MATERIAL_MOUNT4 = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_MATERIAL_5 = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_MATERIAL_MOUNT5 = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_MONEY = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(MATERIAL_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_MATERIAL_1 != table.n_MATERIAL_1)
		{
			return false;
		}
		if (n_MATERIAL_MOUNT1 != table.n_MATERIAL_MOUNT1)
		{
			return false;
		}
		if (n_MATERIAL_2 != table.n_MATERIAL_2)
		{
			return false;
		}
		if (n_MATERIAL_MOUNT2 != table.n_MATERIAL_MOUNT2)
		{
			return false;
		}
		if (n_MATERIAL_3 != table.n_MATERIAL_3)
		{
			return false;
		}
		if (n_MATERIAL_MOUNT3 != table.n_MATERIAL_MOUNT3)
		{
			return false;
		}
		if (n_MATERIAL_4 != table.n_MATERIAL_4)
		{
			return false;
		}
		if (n_MATERIAL_MOUNT4 != table.n_MATERIAL_MOUNT4)
		{
			return false;
		}
		if (n_MATERIAL_5 != table.n_MATERIAL_5)
		{
			return false;
		}
		if (n_MATERIAL_MOUNT5 != table.n_MATERIAL_MOUNT5)
		{
			return false;
		}
		if (n_MONEY != table.n_MONEY)
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
		binaryWriter.Write(n_MATERIAL_1);
		binaryWriter.Write(n_MATERIAL_MOUNT1);
		binaryWriter.Write(n_MATERIAL_2);
		binaryWriter.Write(n_MATERIAL_MOUNT2);
		binaryWriter.Write(n_MATERIAL_3);
		binaryWriter.Write(n_MATERIAL_MOUNT3);
		binaryWriter.Write(n_MATERIAL_4);
		binaryWriter.Write(n_MATERIAL_MOUNT4);
		binaryWriter.Write(n_MATERIAL_5);
		binaryWriter.Write(n_MATERIAL_MOUNT5);
		binaryWriter.Write(n_MONEY);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_MATERIAL_1 = binaryReader.ReadInt32();
		n_MATERIAL_MOUNT1 = binaryReader.ReadInt32();
		n_MATERIAL_2 = binaryReader.ReadInt32();
		n_MATERIAL_MOUNT2 = binaryReader.ReadInt32();
		n_MATERIAL_3 = binaryReader.ReadInt32();
		n_MATERIAL_MOUNT3 = binaryReader.ReadInt32();
		n_MATERIAL_4 = binaryReader.ReadInt32();
		n_MATERIAL_MOUNT4 = binaryReader.ReadInt32();
		n_MATERIAL_5 = binaryReader.ReadInt32();
		n_MATERIAL_MOUNT5 = binaryReader.ReadInt32();
		n_MONEY = binaryReader.ReadInt32();
	}
}
