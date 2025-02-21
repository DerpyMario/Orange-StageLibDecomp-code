using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class VIP_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_VIP,
		n_MONEY,
		n_BUY_AP,
		n_BUY_MONEY,
		n_PROF_RATE,
		n_RESEARCH_BOOST,
		n_BOSS_RESET,
		n_FRIEND_AP
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_VIP { get; set; }

	[Preserve]
	public int n_MONEY { get; set; }

	[Preserve]
	public int n_BUY_AP { get; set; }

	[Preserve]
	public int n_BUY_MONEY { get; set; }

	[Preserve]
	public int n_PROF_RATE { get; set; }

	[Preserve]
	public int n_RESEARCH_BOOST { get; set; }

	[Preserve]
	public int n_BOSS_RESET { get; set; }

	[Preserve]
	public int n_FRIEND_AP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(VIP_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_VIP != tbl.n_VIP)
		{
			dictionary.Add(1, n_VIP);
		}
		if (n_MONEY != tbl.n_MONEY)
		{
			dictionary.Add(2, n_MONEY);
		}
		if (n_BUY_AP != tbl.n_BUY_AP)
		{
			dictionary.Add(3, n_BUY_AP);
		}
		if (n_BUY_MONEY != tbl.n_BUY_MONEY)
		{
			dictionary.Add(4, n_BUY_MONEY);
		}
		if (n_PROF_RATE != tbl.n_PROF_RATE)
		{
			dictionary.Add(5, n_PROF_RATE);
		}
		if (n_RESEARCH_BOOST != tbl.n_RESEARCH_BOOST)
		{
			dictionary.Add(6, n_RESEARCH_BOOST);
		}
		if (n_BOSS_RESET != tbl.n_BOSS_RESET)
		{
			dictionary.Add(7, n_BOSS_RESET);
		}
		if (n_FRIEND_AP != tbl.n_FRIEND_AP)
		{
			dictionary.Add(8, n_FRIEND_AP);
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
				n_VIP = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_MONEY = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_BUY_AP = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_BUY_MONEY = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_PROF_RATE = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_RESEARCH_BOOST = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_BOSS_RESET = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_FRIEND_AP = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(VIP_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_VIP != table.n_VIP)
		{
			return false;
		}
		if (n_MONEY != table.n_MONEY)
		{
			return false;
		}
		if (n_BUY_AP != table.n_BUY_AP)
		{
			return false;
		}
		if (n_BUY_MONEY != table.n_BUY_MONEY)
		{
			return false;
		}
		if (n_PROF_RATE != table.n_PROF_RATE)
		{
			return false;
		}
		if (n_RESEARCH_BOOST != table.n_RESEARCH_BOOST)
		{
			return false;
		}
		if (n_BOSS_RESET != table.n_BOSS_RESET)
		{
			return false;
		}
		if (n_FRIEND_AP != table.n_FRIEND_AP)
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
		binaryWriter.Write(n_VIP);
		binaryWriter.Write(n_MONEY);
		binaryWriter.Write(n_BUY_AP);
		binaryWriter.Write(n_BUY_MONEY);
		binaryWriter.Write(n_PROF_RATE);
		binaryWriter.Write(n_RESEARCH_BOOST);
		binaryWriter.Write(n_BOSS_RESET);
		binaryWriter.Write(n_FRIEND_AP);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_VIP = binaryReader.ReadInt32();
		n_MONEY = binaryReader.ReadInt32();
		n_BUY_AP = binaryReader.ReadInt32();
		n_BUY_MONEY = binaryReader.ReadInt32();
		n_PROF_RATE = binaryReader.ReadInt32();
		n_RESEARCH_BOOST = binaryReader.ReadInt32();
		n_BOSS_RESET = binaryReader.ReadInt32();
		n_FRIEND_AP = binaryReader.ReadInt32();
	}
}
