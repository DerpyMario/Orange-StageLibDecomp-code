using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class CREDITS_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		n_PRESET,
		n_FOLLOW,
		s_CONTENT
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_PRESET { get; set; }

	[Preserve]
	public int n_FOLLOW { get; set; }

	[Preserve]
	public string s_CONTENT { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(CREDITS_TABLE tbl)
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
		if (n_PRESET != tbl.n_PRESET)
		{
			dictionary.Add(2, n_PRESET);
		}
		if (n_FOLLOW != tbl.n_FOLLOW)
		{
			dictionary.Add(3, n_FOLLOW);
		}
		if (s_CONTENT != tbl.s_CONTENT)
		{
			dictionary.Add(4, s_CONTENT);
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
				n_PRESET = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_FOLLOW = Convert.ToInt32(item.Value);
				break;
			case 4:
				s_CONTENT = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(CREDITS_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (n_PRESET != table.n_PRESET)
		{
			return false;
		}
		if (n_FOLLOW != table.n_FOLLOW)
		{
			return false;
		}
		if (s_CONTENT != table.s_CONTENT)
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
		binaryWriter.Write(n_PRESET);
		binaryWriter.Write(n_FOLLOW);
		binaryWriter.WriteExString(s_CONTENT);
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
		n_PRESET = binaryReader.ReadInt32();
		n_FOLLOW = binaryReader.ReadInt32();
		s_CONTENT = binaryReader.ReadExString();
	}
}
