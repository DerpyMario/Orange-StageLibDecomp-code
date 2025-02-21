using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class RESEARCH_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_RESEARCH_LV,
		n_RANK,
		n_GET_AP,
		n_ITEMID,
		n_ITEMCOUNT,
		n_GET_TIME,
		n_LIMIT,
		n_RESET_RULE,
		n_PRE,
		n_TIME,
		n_MATERIAL,
		n_GET_EXP,
		n_EVENT,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_RESEARCH_LV { get; set; }

	[Preserve]
	public int n_RANK { get; set; }

	[Preserve]
	public int n_GET_AP { get; set; }

	[Preserve]
	public int n_ITEMID { get; set; }

	[Preserve]
	public int n_ITEMCOUNT { get; set; }

	[Preserve]
	public int n_GET_TIME { get; set; }

	[Preserve]
	public int n_LIMIT { get; set; }

	[Preserve]
	public int n_RESET_RULE { get; set; }

	[Preserve]
	public int n_PRE { get; set; }

	[Preserve]
	public int n_TIME { get; set; }

	[Preserve]
	public int n_MATERIAL { get; set; }

	[Preserve]
	public int n_GET_EXP { get; set; }

	[Preserve]
	public int n_EVENT { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(RESEARCH_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_RESEARCH_LV != tbl.n_RESEARCH_LV)
		{
			dictionary.Add(1, n_RESEARCH_LV);
		}
		if (n_RANK != tbl.n_RANK)
		{
			dictionary.Add(2, n_RANK);
		}
		if (n_GET_AP != tbl.n_GET_AP)
		{
			dictionary.Add(3, n_GET_AP);
		}
		if (n_ITEMID != tbl.n_ITEMID)
		{
			dictionary.Add(4, n_ITEMID);
		}
		if (n_ITEMCOUNT != tbl.n_ITEMCOUNT)
		{
			dictionary.Add(5, n_ITEMCOUNT);
		}
		if (n_GET_TIME != tbl.n_GET_TIME)
		{
			dictionary.Add(6, n_GET_TIME);
		}
		if (n_LIMIT != tbl.n_LIMIT)
		{
			dictionary.Add(7, n_LIMIT);
		}
		if (n_RESET_RULE != tbl.n_RESET_RULE)
		{
			dictionary.Add(8, n_RESET_RULE);
		}
		if (n_PRE != tbl.n_PRE)
		{
			dictionary.Add(9, n_PRE);
		}
		if (n_TIME != tbl.n_TIME)
		{
			dictionary.Add(10, n_TIME);
		}
		if (n_MATERIAL != tbl.n_MATERIAL)
		{
			dictionary.Add(11, n_MATERIAL);
		}
		if (n_GET_EXP != tbl.n_GET_EXP)
		{
			dictionary.Add(12, n_GET_EXP);
		}
		if (n_EVENT != tbl.n_EVENT)
		{
			dictionary.Add(13, n_EVENT);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(14, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(15, s_END_VERSION);
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
				n_RESEARCH_LV = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_RANK = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_GET_AP = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_ITEMID = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_ITEMCOUNT = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_GET_TIME = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_LIMIT = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_RESET_RULE = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_PRE = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_TIME = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_MATERIAL = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_GET_EXP = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_EVENT = Convert.ToInt32(item.Value);
				break;
			case 14:
				s_START_VERSION = item.Value.ToString();
				break;
			case 15:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(RESEARCH_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_RESEARCH_LV != table.n_RESEARCH_LV)
		{
			return false;
		}
		if (n_RANK != table.n_RANK)
		{
			return false;
		}
		if (n_GET_AP != table.n_GET_AP)
		{
			return false;
		}
		if (n_ITEMID != table.n_ITEMID)
		{
			return false;
		}
		if (n_ITEMCOUNT != table.n_ITEMCOUNT)
		{
			return false;
		}
		if (n_GET_TIME != table.n_GET_TIME)
		{
			return false;
		}
		if (n_LIMIT != table.n_LIMIT)
		{
			return false;
		}
		if (n_RESET_RULE != table.n_RESET_RULE)
		{
			return false;
		}
		if (n_PRE != table.n_PRE)
		{
			return false;
		}
		if (n_TIME != table.n_TIME)
		{
			return false;
		}
		if (n_MATERIAL != table.n_MATERIAL)
		{
			return false;
		}
		if (n_GET_EXP != table.n_GET_EXP)
		{
			return false;
		}
		if (n_EVENT != table.n_EVENT)
		{
			return false;
		}
		if (s_START_VERSION != table.s_START_VERSION)
		{
			return false;
		}
		if (s_END_VERSION != table.s_END_VERSION)
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
		binaryWriter.Write(n_RESEARCH_LV);
		binaryWriter.Write(n_RANK);
		binaryWriter.Write(n_GET_AP);
		binaryWriter.Write(n_ITEMID);
		binaryWriter.Write(n_ITEMCOUNT);
		binaryWriter.Write(n_GET_TIME);
		binaryWriter.Write(n_LIMIT);
		binaryWriter.Write(n_RESET_RULE);
		binaryWriter.Write(n_PRE);
		binaryWriter.Write(n_TIME);
		binaryWriter.Write(n_MATERIAL);
		binaryWriter.Write(n_GET_EXP);
		binaryWriter.Write(n_EVENT);
		binaryWriter.WriteExString(s_START_VERSION);
		binaryWriter.WriteExString(s_END_VERSION);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_RESEARCH_LV = binaryReader.ReadInt32();
		n_RANK = binaryReader.ReadInt32();
		n_GET_AP = binaryReader.ReadInt32();
		n_ITEMID = binaryReader.ReadInt32();
		n_ITEMCOUNT = binaryReader.ReadInt32();
		n_GET_TIME = binaryReader.ReadInt32();
		n_LIMIT = binaryReader.ReadInt32();
		n_RESET_RULE = binaryReader.ReadInt32();
		n_PRE = binaryReader.ReadInt32();
		n_TIME = binaryReader.ReadInt32();
		n_MATERIAL = binaryReader.ReadInt32();
		n_GET_EXP = binaryReader.ReadInt32();
		n_EVENT = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
