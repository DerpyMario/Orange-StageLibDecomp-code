using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class SUIT_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_EQUIP_1,
		n_EQUIP_2,
		n_EQUIP_3,
		n_EQUIP_4,
		n_EQUIP_5,
		n_EQUIP_6,
		n_SUIT_1,
		n_EFFECT_1,
		n_SUIT_2,
		n_EFFECT_2,
		n_SUIT_3,
		n_EFFECT_3
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_EQUIP_1 { get; set; }

	[Preserve]
	public int n_EQUIP_2 { get; set; }

	[Preserve]
	public int n_EQUIP_3 { get; set; }

	[Preserve]
	public int n_EQUIP_4 { get; set; }

	[Preserve]
	public int n_EQUIP_5 { get; set; }

	[Preserve]
	public int n_EQUIP_6 { get; set; }

	[Preserve]
	public int n_SUIT_1 { get; set; }

	[Preserve]
	public int n_EFFECT_1 { get; set; }

	[Preserve]
	public int n_SUIT_2 { get; set; }

	[Preserve]
	public int n_EFFECT_2 { get; set; }

	[Preserve]
	public int n_SUIT_3 { get; set; }

	[Preserve]
	public int n_EFFECT_3 { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(SUIT_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_EQUIP_1 != tbl.n_EQUIP_1)
		{
			dictionary.Add(1, n_EQUIP_1);
		}
		if (n_EQUIP_2 != tbl.n_EQUIP_2)
		{
			dictionary.Add(2, n_EQUIP_2);
		}
		if (n_EQUIP_3 != tbl.n_EQUIP_3)
		{
			dictionary.Add(3, n_EQUIP_3);
		}
		if (n_EQUIP_4 != tbl.n_EQUIP_4)
		{
			dictionary.Add(4, n_EQUIP_4);
		}
		if (n_EQUIP_5 != tbl.n_EQUIP_5)
		{
			dictionary.Add(5, n_EQUIP_5);
		}
		if (n_EQUIP_6 != tbl.n_EQUIP_6)
		{
			dictionary.Add(6, n_EQUIP_6);
		}
		if (n_SUIT_1 != tbl.n_SUIT_1)
		{
			dictionary.Add(7, n_SUIT_1);
		}
		if (n_EFFECT_1 != tbl.n_EFFECT_1)
		{
			dictionary.Add(8, n_EFFECT_1);
		}
		if (n_SUIT_2 != tbl.n_SUIT_2)
		{
			dictionary.Add(9, n_SUIT_2);
		}
		if (n_EFFECT_2 != tbl.n_EFFECT_2)
		{
			dictionary.Add(10, n_EFFECT_2);
		}
		if (n_SUIT_3 != tbl.n_SUIT_3)
		{
			dictionary.Add(11, n_SUIT_3);
		}
		if (n_EFFECT_3 != tbl.n_EFFECT_3)
		{
			dictionary.Add(12, n_EFFECT_3);
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
				n_EQUIP_1 = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_EQUIP_2 = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_EQUIP_3 = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_EQUIP_4 = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_EQUIP_5 = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_EQUIP_6 = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_SUIT_1 = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_EFFECT_1 = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_SUIT_2 = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_EFFECT_2 = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_SUIT_3 = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_EFFECT_3 = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(SUIT_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_EQUIP_1 != table.n_EQUIP_1)
		{
			return false;
		}
		if (n_EQUIP_2 != table.n_EQUIP_2)
		{
			return false;
		}
		if (n_EQUIP_3 != table.n_EQUIP_3)
		{
			return false;
		}
		if (n_EQUIP_4 != table.n_EQUIP_4)
		{
			return false;
		}
		if (n_EQUIP_5 != table.n_EQUIP_5)
		{
			return false;
		}
		if (n_EQUIP_6 != table.n_EQUIP_6)
		{
			return false;
		}
		if (n_SUIT_1 != table.n_SUIT_1)
		{
			return false;
		}
		if (n_EFFECT_1 != table.n_EFFECT_1)
		{
			return false;
		}
		if (n_SUIT_2 != table.n_SUIT_2)
		{
			return false;
		}
		if (n_EFFECT_2 != table.n_EFFECT_2)
		{
			return false;
		}
		if (n_SUIT_3 != table.n_SUIT_3)
		{
			return false;
		}
		if (n_EFFECT_3 != table.n_EFFECT_3)
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
		binaryWriter.Write(n_EQUIP_1);
		binaryWriter.Write(n_EQUIP_2);
		binaryWriter.Write(n_EQUIP_3);
		binaryWriter.Write(n_EQUIP_4);
		binaryWriter.Write(n_EQUIP_5);
		binaryWriter.Write(n_EQUIP_6);
		binaryWriter.Write(n_SUIT_1);
		binaryWriter.Write(n_EFFECT_1);
		binaryWriter.Write(n_SUIT_2);
		binaryWriter.Write(n_EFFECT_2);
		binaryWriter.Write(n_SUIT_3);
		binaryWriter.Write(n_EFFECT_3);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_EQUIP_1 = binaryReader.ReadInt32();
		n_EQUIP_2 = binaryReader.ReadInt32();
		n_EQUIP_3 = binaryReader.ReadInt32();
		n_EQUIP_4 = binaryReader.ReadInt32();
		n_EQUIP_5 = binaryReader.ReadInt32();
		n_EQUIP_6 = binaryReader.ReadInt32();
		n_SUIT_1 = binaryReader.ReadInt32();
		n_EFFECT_1 = binaryReader.ReadInt32();
		n_SUIT_2 = binaryReader.ReadInt32();
		n_EFFECT_2 = binaryReader.ReadInt32();
		n_SUIT_3 = binaryReader.ReadInt32();
		n_EFFECT_3 = binaryReader.ReadInt32();
	}
}
