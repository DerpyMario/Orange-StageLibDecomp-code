using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class BUYSTEP_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_BUY_COUNT,
		n_STEP1,
		n_STEP1_COST,
		n_STEP2,
		n_STEP2_COST,
		n_STEP3,
		n_STEP3_COST,
		n_STEP4,
		n_STEP4_COST,
		n_STEP5,
		n_STEP5_COST
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_BUY_COUNT { get; set; }

	[Preserve]
	public int n_STEP1 { get; set; }

	[Preserve]
	public int n_STEP1_COST { get; set; }

	[Preserve]
	public int n_STEP2 { get; set; }

	[Preserve]
	public int n_STEP2_COST { get; set; }

	[Preserve]
	public int n_STEP3 { get; set; }

	[Preserve]
	public int n_STEP3_COST { get; set; }

	[Preserve]
	public int n_STEP4 { get; set; }

	[Preserve]
	public int n_STEP4_COST { get; set; }

	[Preserve]
	public int n_STEP5 { get; set; }

	[Preserve]
	public int n_STEP5_COST { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(BUYSTEP_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_BUY_COUNT != tbl.n_BUY_COUNT)
		{
			dictionary.Add(1, n_BUY_COUNT);
		}
		if (n_STEP1 != tbl.n_STEP1)
		{
			dictionary.Add(2, n_STEP1);
		}
		if (n_STEP1_COST != tbl.n_STEP1_COST)
		{
			dictionary.Add(3, n_STEP1_COST);
		}
		if (n_STEP2 != tbl.n_STEP2)
		{
			dictionary.Add(4, n_STEP2);
		}
		if (n_STEP2_COST != tbl.n_STEP2_COST)
		{
			dictionary.Add(5, n_STEP2_COST);
		}
		if (n_STEP3 != tbl.n_STEP3)
		{
			dictionary.Add(6, n_STEP3);
		}
		if (n_STEP3_COST != tbl.n_STEP3_COST)
		{
			dictionary.Add(7, n_STEP3_COST);
		}
		if (n_STEP4 != tbl.n_STEP4)
		{
			dictionary.Add(8, n_STEP4);
		}
		if (n_STEP4_COST != tbl.n_STEP4_COST)
		{
			dictionary.Add(9, n_STEP4_COST);
		}
		if (n_STEP5 != tbl.n_STEP5)
		{
			dictionary.Add(10, n_STEP5);
		}
		if (n_STEP5_COST != tbl.n_STEP5_COST)
		{
			dictionary.Add(11, n_STEP5_COST);
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
				n_BUY_COUNT = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_STEP1 = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_STEP1_COST = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_STEP2 = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_STEP2_COST = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_STEP3 = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_STEP3_COST = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_STEP4 = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_STEP4_COST = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_STEP5 = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_STEP5_COST = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(BUYSTEP_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_BUY_COUNT != table.n_BUY_COUNT)
		{
			return false;
		}
		if (n_STEP1 != table.n_STEP1)
		{
			return false;
		}
		if (n_STEP1_COST != table.n_STEP1_COST)
		{
			return false;
		}
		if (n_STEP2 != table.n_STEP2)
		{
			return false;
		}
		if (n_STEP2_COST != table.n_STEP2_COST)
		{
			return false;
		}
		if (n_STEP3 != table.n_STEP3)
		{
			return false;
		}
		if (n_STEP3_COST != table.n_STEP3_COST)
		{
			return false;
		}
		if (n_STEP4 != table.n_STEP4)
		{
			return false;
		}
		if (n_STEP4_COST != table.n_STEP4_COST)
		{
			return false;
		}
		if (n_STEP5 != table.n_STEP5)
		{
			return false;
		}
		if (n_STEP5_COST != table.n_STEP5_COST)
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
		binaryWriter.Write(n_BUY_COUNT);
		binaryWriter.Write(n_STEP1);
		binaryWriter.Write(n_STEP1_COST);
		binaryWriter.Write(n_STEP2);
		binaryWriter.Write(n_STEP2_COST);
		binaryWriter.Write(n_STEP3);
		binaryWriter.Write(n_STEP3_COST);
		binaryWriter.Write(n_STEP4);
		binaryWriter.Write(n_STEP4_COST);
		binaryWriter.Write(n_STEP5);
		binaryWriter.Write(n_STEP5_COST);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_BUY_COUNT = binaryReader.ReadInt32();
		n_STEP1 = binaryReader.ReadInt32();
		n_STEP1_COST = binaryReader.ReadInt32();
		n_STEP2 = binaryReader.ReadInt32();
		n_STEP2_COST = binaryReader.ReadInt32();
		n_STEP3 = binaryReader.ReadInt32();
		n_STEP3_COST = binaryReader.ReadInt32();
		n_STEP4 = binaryReader.ReadInt32();
		n_STEP4_COST = binaryReader.ReadInt32();
		n_STEP5 = binaryReader.ReadInt32();
		n_STEP5_COST = binaryReader.ReadInt32();
	}
}
