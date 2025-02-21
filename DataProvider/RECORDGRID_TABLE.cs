using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class RECORDGRID_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		n_NUMBER,
		n_TYPE,
		n_VALUE_X,
		n_VALUE_Y,
		n_VALUE_Z,
		n_REWARD,
		n_ACTION,
		n_ONLY,
		s_TITLE,
		s_TIP
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_NUMBER { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_VALUE_X { get; set; }

	[Preserve]
	public int n_VALUE_Y { get; set; }

	[Preserve]
	public int n_VALUE_Z { get; set; }

	[Preserve]
	public int n_REWARD { get; set; }

	[Preserve]
	public int n_ACTION { get; set; }

	[Preserve]
	public int n_ONLY { get; set; }

	[Preserve]
	public string s_TITLE { get; set; }

	[Preserve]
	public string s_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(RECORDGRID_TABLE tbl)
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
		if (n_NUMBER != tbl.n_NUMBER)
		{
			dictionary.Add(2, n_NUMBER);
		}
		if (n_TYPE != tbl.n_TYPE)
		{
			dictionary.Add(3, n_TYPE);
		}
		if (n_VALUE_X != tbl.n_VALUE_X)
		{
			dictionary.Add(4, n_VALUE_X);
		}
		if (n_VALUE_Y != tbl.n_VALUE_Y)
		{
			dictionary.Add(5, n_VALUE_Y);
		}
		if (n_VALUE_Z != tbl.n_VALUE_Z)
		{
			dictionary.Add(6, n_VALUE_Z);
		}
		if (n_REWARD != tbl.n_REWARD)
		{
			dictionary.Add(7, n_REWARD);
		}
		if (n_ACTION != tbl.n_ACTION)
		{
			dictionary.Add(8, n_ACTION);
		}
		if (n_ONLY != tbl.n_ONLY)
		{
			dictionary.Add(9, n_ONLY);
		}
		if (s_TITLE != tbl.s_TITLE)
		{
			dictionary.Add(10, s_TITLE);
		}
		if (s_TIP != tbl.s_TIP)
		{
			dictionary.Add(11, s_TIP);
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
				n_NUMBER = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_TYPE = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_VALUE_X = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_VALUE_Y = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_VALUE_Z = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_REWARD = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_ACTION = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_ONLY = Convert.ToInt32(item.Value);
				break;
			case 10:
				s_TITLE = item.Value.ToString();
				break;
			case 11:
				s_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(RECORDGRID_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (n_NUMBER != table.n_NUMBER)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_VALUE_X != table.n_VALUE_X)
		{
			return false;
		}
		if (n_VALUE_Y != table.n_VALUE_Y)
		{
			return false;
		}
		if (n_VALUE_Z != table.n_VALUE_Z)
		{
			return false;
		}
		if (n_REWARD != table.n_REWARD)
		{
			return false;
		}
		if (n_ACTION != table.n_ACTION)
		{
			return false;
		}
		if (n_ONLY != table.n_ONLY)
		{
			return false;
		}
		if (s_TITLE != table.s_TITLE)
		{
			return false;
		}
		if (s_TIP != table.s_TIP)
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
		binaryWriter.Write(n_NUMBER);
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_VALUE_X);
		binaryWriter.Write(n_VALUE_Y);
		binaryWriter.Write(n_VALUE_Z);
		binaryWriter.Write(n_REWARD);
		binaryWriter.Write(n_ACTION);
		binaryWriter.Write(n_ONLY);
		binaryWriter.WriteExString(s_TITLE);
		binaryWriter.WriteExString(s_TIP);
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
		n_NUMBER = binaryReader.ReadInt32();
		n_TYPE = binaryReader.ReadInt32();
		n_VALUE_X = binaryReader.ReadInt32();
		n_VALUE_Y = binaryReader.ReadInt32();
		n_VALUE_Z = binaryReader.ReadInt32();
		n_REWARD = binaryReader.ReadInt32();
		n_ACTION = binaryReader.ReadInt32();
		n_ONLY = binaryReader.ReadInt32();
		s_TITLE = binaryReader.ReadExString();
		s_TIP = binaryReader.ReadExString();
	}
}
