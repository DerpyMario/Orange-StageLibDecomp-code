using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class BACKUP_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_SLOT,
		n_SLOT_LV,
		n_PLAYER_RANK,
		n_MATERIAL,
		n_STATUS_RATE,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_SLOT { get; set; }

	[Preserve]
	public int n_SLOT_LV { get; set; }

	[Preserve]
	public int n_PLAYER_RANK { get; set; }

	[Preserve]
	public int n_MATERIAL { get; set; }

	[Preserve]
	public int n_STATUS_RATE { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(BACKUP_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_SLOT != tbl.n_SLOT)
		{
			dictionary.Add(1, n_SLOT);
		}
		if (n_SLOT_LV != tbl.n_SLOT_LV)
		{
			dictionary.Add(2, n_SLOT_LV);
		}
		if (n_PLAYER_RANK != tbl.n_PLAYER_RANK)
		{
			dictionary.Add(3, n_PLAYER_RANK);
		}
		if (n_MATERIAL != tbl.n_MATERIAL)
		{
			dictionary.Add(4, n_MATERIAL);
		}
		if (n_STATUS_RATE != tbl.n_STATUS_RATE)
		{
			dictionary.Add(5, n_STATUS_RATE);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(6, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(7, s_END_VERSION);
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
				n_SLOT = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_SLOT_LV = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_PLAYER_RANK = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_MATERIAL = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_STATUS_RATE = Convert.ToInt32(item.Value);
				break;
			case 6:
				s_START_VERSION = item.Value.ToString();
				break;
			case 7:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(BACKUP_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_SLOT != table.n_SLOT)
		{
			return false;
		}
		if (n_SLOT_LV != table.n_SLOT_LV)
		{
			return false;
		}
		if (n_PLAYER_RANK != table.n_PLAYER_RANK)
		{
			return false;
		}
		if (n_MATERIAL != table.n_MATERIAL)
		{
			return false;
		}
		if (n_STATUS_RATE != table.n_STATUS_RATE)
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
		binaryWriter.Write(n_SLOT);
		binaryWriter.Write(n_SLOT_LV);
		binaryWriter.Write(n_PLAYER_RANK);
		binaryWriter.Write(n_MATERIAL);
		binaryWriter.Write(n_STATUS_RATE);
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
		n_SLOT = binaryReader.ReadInt32();
		n_SLOT_LV = binaryReader.ReadInt32();
		n_PLAYER_RANK = binaryReader.ReadInt32();
		n_MATERIAL = binaryReader.ReadInt32();
		n_STATUS_RATE = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
