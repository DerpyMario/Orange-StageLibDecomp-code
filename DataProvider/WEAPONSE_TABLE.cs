using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class WEAPONSE_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_CUEID,
		s_CUENAME,
		s_ACB,
		n_CHANNEL
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_CUEID { get; set; }

	[Preserve]
	public string s_CUENAME { get; set; }

	[Preserve]
	public string s_ACB { get; set; }

	[Preserve]
	public int n_CHANNEL { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(WEAPONSE_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_CUEID != tbl.n_CUEID)
		{
			dictionary.Add(1, n_CUEID);
		}
		if (s_CUENAME != tbl.s_CUENAME)
		{
			dictionary.Add(2, s_CUENAME);
		}
		if (s_ACB != tbl.s_ACB)
		{
			dictionary.Add(3, s_ACB);
		}
		if (n_CHANNEL != tbl.n_CHANNEL)
		{
			dictionary.Add(4, n_CHANNEL);
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
				n_CUEID = Convert.ToInt32(item.Value);
				break;
			case 2:
				s_CUENAME = item.Value.ToString();
				break;
			case 3:
				s_ACB = item.Value.ToString();
				break;
			case 4:
				n_CHANNEL = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(WEAPONSE_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_CUEID != table.n_CUEID)
		{
			return false;
		}
		if (s_CUENAME != table.s_CUENAME)
		{
			return false;
		}
		if (s_ACB != table.s_ACB)
		{
			return false;
		}
		if (n_CHANNEL != table.n_CHANNEL)
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
		binaryWriter.Write(n_CUEID);
		binaryWriter.WriteExString(s_CUENAME);
		binaryWriter.WriteExString(s_ACB);
		binaryWriter.Write(n_CHANNEL);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_CUEID = binaryReader.ReadInt32();
		s_CUENAME = binaryReader.ReadExString();
		s_ACB = binaryReader.ReadExString();
		n_CHANNEL = binaryReader.ReadInt32();
	}
}
