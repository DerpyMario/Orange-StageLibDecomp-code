using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class SERVICE_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		n_DURATION,
		n_TYPE,
		n_TYPE_1,
		n_TYPE_2,
		n_TYPE_3,
		n_TYPE_4,
		n_MAILID
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_DURATION { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_TYPE_1 { get; set; }

	[Preserve]
	public int n_TYPE_2 { get; set; }

	[Preserve]
	public int n_TYPE_3 { get; set; }

	[Preserve]
	public int n_TYPE_4 { get; set; }

	[Preserve]
	public int n_MAILID { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(SERVICE_TABLE tbl)
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
		if (n_DURATION != tbl.n_DURATION)
		{
			dictionary.Add(2, n_DURATION);
		}
		if (n_TYPE != tbl.n_TYPE)
		{
			dictionary.Add(3, n_TYPE);
		}
		if (n_TYPE_1 != tbl.n_TYPE_1)
		{
			dictionary.Add(4, n_TYPE_1);
		}
		if (n_TYPE_2 != tbl.n_TYPE_2)
		{
			dictionary.Add(5, n_TYPE_2);
		}
		if (n_TYPE_3 != tbl.n_TYPE_3)
		{
			dictionary.Add(6, n_TYPE_3);
		}
		if (n_TYPE_4 != tbl.n_TYPE_4)
		{
			dictionary.Add(7, n_TYPE_4);
		}
		if (n_MAILID != tbl.n_MAILID)
		{
			dictionary.Add(8, n_MAILID);
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
				n_DURATION = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_TYPE = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_TYPE_1 = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_TYPE_2 = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_TYPE_3 = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_TYPE_4 = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_MAILID = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(SERVICE_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (n_DURATION != table.n_DURATION)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_TYPE_1 != table.n_TYPE_1)
		{
			return false;
		}
		if (n_TYPE_2 != table.n_TYPE_2)
		{
			return false;
		}
		if (n_TYPE_3 != table.n_TYPE_3)
		{
			return false;
		}
		if (n_TYPE_4 != table.n_TYPE_4)
		{
			return false;
		}
		if (n_MAILID != table.n_MAILID)
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
		binaryWriter.Write(n_DURATION);
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_TYPE_1);
		binaryWriter.Write(n_TYPE_2);
		binaryWriter.Write(n_TYPE_3);
		binaryWriter.Write(n_TYPE_4);
		binaryWriter.Write(n_MAILID);
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
		n_DURATION = binaryReader.ReadInt32();
		n_TYPE = binaryReader.ReadInt32();
		n_TYPE_1 = binaryReader.ReadInt32();
		n_TYPE_2 = binaryReader.ReadInt32();
		n_TYPE_3 = binaryReader.ReadInt32();
		n_TYPE_4 = binaryReader.ReadInt32();
		n_MAILID = binaryReader.ReadInt32();
	}
}
