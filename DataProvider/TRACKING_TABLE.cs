using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class TRACKING_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		f_RANGE,
		n_POWER,
		n_TARGET,
		n_CONDITION,
		n_BEGINTIME_1,
		n_ENDTIME_1,
		n_BEGINTIME_2,
		n_ENDTIME_2,
		n_BEGINTIME_3,
		n_ENDTIME_3
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public float f_RANGE { get; set; }

	[Preserve]
	public int n_POWER { get; set; }

	[Preserve]
	public int n_TARGET { get; set; }

	[Preserve]
	public int n_CONDITION { get; set; }

	[Preserve]
	public int n_BEGINTIME_1 { get; set; }

	[Preserve]
	public int n_ENDTIME_1 { get; set; }

	[Preserve]
	public int n_BEGINTIME_2 { get; set; }

	[Preserve]
	public int n_ENDTIME_2 { get; set; }

	[Preserve]
	public int n_BEGINTIME_3 { get; set; }

	[Preserve]
	public int n_ENDTIME_3 { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(TRACKING_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (f_RANGE != tbl.f_RANGE)
		{
			dictionary.Add(1, f_RANGE);
		}
		if (n_POWER != tbl.n_POWER)
		{
			dictionary.Add(2, n_POWER);
		}
		if (n_TARGET != tbl.n_TARGET)
		{
			dictionary.Add(3, n_TARGET);
		}
		if (n_CONDITION != tbl.n_CONDITION)
		{
			dictionary.Add(4, n_CONDITION);
		}
		if (n_BEGINTIME_1 != tbl.n_BEGINTIME_1)
		{
			dictionary.Add(5, n_BEGINTIME_1);
		}
		if (n_ENDTIME_1 != tbl.n_ENDTIME_1)
		{
			dictionary.Add(6, n_ENDTIME_1);
		}
		if (n_BEGINTIME_2 != tbl.n_BEGINTIME_2)
		{
			dictionary.Add(7, n_BEGINTIME_2);
		}
		if (n_ENDTIME_2 != tbl.n_ENDTIME_2)
		{
			dictionary.Add(8, n_ENDTIME_2);
		}
		if (n_BEGINTIME_3 != tbl.n_BEGINTIME_3)
		{
			dictionary.Add(9, n_BEGINTIME_3);
		}
		if (n_ENDTIME_3 != tbl.n_ENDTIME_3)
		{
			dictionary.Add(10, n_ENDTIME_3);
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
				f_RANGE = Convert.ToSingle(item.Value);
				break;
			case 2:
				n_POWER = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_TARGET = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_CONDITION = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_BEGINTIME_1 = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_ENDTIME_1 = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_BEGINTIME_2 = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_ENDTIME_2 = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_BEGINTIME_3 = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_ENDTIME_3 = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(TRACKING_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (f_RANGE != table.f_RANGE)
		{
			return false;
		}
		if (n_POWER != table.n_POWER)
		{
			return false;
		}
		if (n_TARGET != table.n_TARGET)
		{
			return false;
		}
		if (n_CONDITION != table.n_CONDITION)
		{
			return false;
		}
		if (n_BEGINTIME_1 != table.n_BEGINTIME_1)
		{
			return false;
		}
		if (n_ENDTIME_1 != table.n_ENDTIME_1)
		{
			return false;
		}
		if (n_BEGINTIME_2 != table.n_BEGINTIME_2)
		{
			return false;
		}
		if (n_ENDTIME_2 != table.n_ENDTIME_2)
		{
			return false;
		}
		if (n_BEGINTIME_3 != table.n_BEGINTIME_3)
		{
			return false;
		}
		if (n_ENDTIME_3 != table.n_ENDTIME_3)
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
		binaryWriter.Write(f_RANGE);
		binaryWriter.Write(n_POWER);
		binaryWriter.Write(n_TARGET);
		binaryWriter.Write(n_CONDITION);
		binaryWriter.Write(n_BEGINTIME_1);
		binaryWriter.Write(n_ENDTIME_1);
		binaryWriter.Write(n_BEGINTIME_2);
		binaryWriter.Write(n_ENDTIME_2);
		binaryWriter.Write(n_BEGINTIME_3);
		binaryWriter.Write(n_ENDTIME_3);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		f_RANGE = binaryReader.ReadSingle();
		n_POWER = binaryReader.ReadInt32();
		n_TARGET = binaryReader.ReadInt32();
		n_CONDITION = binaryReader.ReadInt32();
		n_BEGINTIME_1 = binaryReader.ReadInt32();
		n_ENDTIME_1 = binaryReader.ReadInt32();
		n_BEGINTIME_2 = binaryReader.ReadInt32();
		n_ENDTIME_2 = binaryReader.ReadInt32();
		n_BEGINTIME_3 = binaryReader.ReadInt32();
		n_ENDTIME_3 = binaryReader.ReadInt32();
	}
}
