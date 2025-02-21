using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class GUIDE_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		n_PLAYER_RANK,
		s_ICON,
		w_TITLE,
		w_TIP,
		n_UILINK
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_PLAYER_RANK { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public string w_TITLE { get; set; }

	[Preserve]
	public string w_TIP { get; set; }

	[Preserve]
	public int n_UILINK { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(GUIDE_TABLE tbl)
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
		if (n_PLAYER_RANK != tbl.n_PLAYER_RANK)
		{
			dictionary.Add(2, n_PLAYER_RANK);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(3, s_ICON);
		}
		if (w_TITLE != tbl.w_TITLE)
		{
			dictionary.Add(4, w_TITLE);
		}
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(5, w_TIP);
		}
		if (n_UILINK != tbl.n_UILINK)
		{
			dictionary.Add(6, n_UILINK);
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
				n_PLAYER_RANK = Convert.ToInt32(item.Value);
				break;
			case 3:
				s_ICON = item.Value.ToString();
				break;
			case 4:
				w_TITLE = item.Value.ToString();
				break;
			case 5:
				w_TIP = item.Value.ToString();
				break;
			case 6:
				n_UILINK = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(GUIDE_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_PLAYER_RANK != table.n_PLAYER_RANK)
		{
			return false;
		}
		if (s_ICON != table.s_ICON)
		{
			return false;
		}
		if (w_TITLE != table.w_TITLE)
		{
			return false;
		}
		if (w_TIP != table.w_TIP)
		{
			return false;
		}
		if (n_UILINK != table.n_UILINK)
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
		binaryWriter.Write(n_PLAYER_RANK);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.WriteExString(w_TITLE);
		binaryWriter.WriteExString(w_TIP);
		binaryWriter.Write(n_UILINK);
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
		n_PLAYER_RANK = binaryReader.ReadInt32();
		s_ICON = binaryReader.ReadExString();
		w_TITLE = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
		n_UILINK = binaryReader.ReadInt32();
	}
}
