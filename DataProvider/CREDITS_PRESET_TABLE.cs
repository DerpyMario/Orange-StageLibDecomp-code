using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class CREDITS_PRESET_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		n_SIZE,
		n_X_OFFSET,
		n_Y_OFFSET,
		n_ALIGN,
		n_MODE,
		n_COLOR,
		n_OUTLINE,
		n_OUTLINE_COLOR
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_SIZE { get; set; }

	[Preserve]
	public int n_X_OFFSET { get; set; }

	[Preserve]
	public int n_Y_OFFSET { get; set; }

	[Preserve]
	public int n_ALIGN { get; set; }

	[Preserve]
	public int n_MODE { get; set; }

	[Preserve]
	public int n_COLOR { get; set; }

	[Preserve]
	public int n_OUTLINE { get; set; }

	[Preserve]
	public int n_OUTLINE_COLOR { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(CREDITS_PRESET_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_TYPE != tbl.n_TYPE)
		{
			dictionary.Add(1, n_TYPE);
		}
		if (n_SIZE != tbl.n_SIZE)
		{
			dictionary.Add(2, n_SIZE);
		}
		if (n_X_OFFSET != tbl.n_X_OFFSET)
		{
			dictionary.Add(3, n_X_OFFSET);
		}
		if (n_Y_OFFSET != tbl.n_Y_OFFSET)
		{
			dictionary.Add(4, n_Y_OFFSET);
		}
		if (n_ALIGN != tbl.n_ALIGN)
		{
			dictionary.Add(5, n_ALIGN);
		}
		if (n_MODE != tbl.n_MODE)
		{
			dictionary.Add(6, n_MODE);
		}
		if (n_COLOR != tbl.n_COLOR)
		{
			dictionary.Add(7, n_COLOR);
		}
		if (n_OUTLINE != tbl.n_OUTLINE)
		{
			dictionary.Add(8, n_OUTLINE);
		}
		if (n_OUTLINE_COLOR != tbl.n_OUTLINE_COLOR)
		{
			dictionary.Add(9, n_OUTLINE_COLOR);
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
				n_TYPE = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_SIZE = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_X_OFFSET = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_Y_OFFSET = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_ALIGN = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_MODE = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_COLOR = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_OUTLINE = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_OUTLINE_COLOR = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(CREDITS_PRESET_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_SIZE != table.n_SIZE)
		{
			return false;
		}
		if (n_X_OFFSET != table.n_X_OFFSET)
		{
			return false;
		}
		if (n_Y_OFFSET != table.n_Y_OFFSET)
		{
			return false;
		}
		if (n_ALIGN != table.n_ALIGN)
		{
			return false;
		}
		if (n_MODE != table.n_MODE)
		{
			return false;
		}
		if (n_COLOR != table.n_COLOR)
		{
			return false;
		}
		if (n_OUTLINE != table.n_OUTLINE)
		{
			return false;
		}
		if (n_OUTLINE_COLOR != table.n_OUTLINE_COLOR)
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
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_SIZE);
		binaryWriter.Write(n_X_OFFSET);
		binaryWriter.Write(n_Y_OFFSET);
		binaryWriter.Write(n_ALIGN);
		binaryWriter.Write(n_MODE);
		binaryWriter.Write(n_COLOR);
		binaryWriter.Write(n_OUTLINE);
		binaryWriter.Write(n_OUTLINE_COLOR);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_TYPE = binaryReader.ReadInt32();
		n_SIZE = binaryReader.ReadInt32();
		n_X_OFFSET = binaryReader.ReadInt32();
		n_Y_OFFSET = binaryReader.ReadInt32();
		n_ALIGN = binaryReader.ReadInt32();
		n_MODE = binaryReader.ReadInt32();
		n_COLOR = binaryReader.ReadInt32();
		n_OUTLINE = binaryReader.ReadInt32();
		n_OUTLINE_COLOR = binaryReader.ReadInt32();
	}
}
