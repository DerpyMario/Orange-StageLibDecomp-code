using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class RANDOMSKILL_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		n_VALUE,
		n_SKILL
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_VALUE { get; set; }

	[Preserve]
	public int n_SKILL { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(RANDOMSKILL_TABLE tbl)
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
		if (n_VALUE != tbl.n_VALUE)
		{
			dictionary.Add(2, n_VALUE);
		}
		if (n_SKILL != tbl.n_SKILL)
		{
			dictionary.Add(3, n_SKILL);
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
				n_VALUE = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_SKILL = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(RANDOMSKILL_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (n_VALUE != table.n_VALUE)
		{
			return false;
		}
		if (n_SKILL != table.n_SKILL)
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
		binaryWriter.Write(n_VALUE);
		binaryWriter.Write(n_SKILL);
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
		n_VALUE = binaryReader.ReadInt32();
		n_SKILL = binaryReader.ReadInt32();
	}
}
