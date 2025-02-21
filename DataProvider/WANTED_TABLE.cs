using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class WANTED_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_STAR,
		s_ICON,
		s_STAGE_ICON,
		n_BASIS_EFFECT,
		n_EFFECT_X,
		n_EFFECT_Y,
		n_EXTRA_1,
		n_EXTRAX_1,
		n_EXTRAY_1,
		n_EXTRA_2,
		n_EXTRAX_2,
		n_EXTRAY_2,
		n_EXTRA_3,
		n_EXTRAX_3,
		n_EXTRAY_3,
		n_REWRD_1,
		n_NUMBER_1,
		n_REWRD_2,
		n_NUMBER_2,
		n_REWRD_3,
		n_NUMBER_3,
		n_PLAYERSTAR,
		n_GUILDLEVEL,
		n_APPEAR,
		n_APPEAR_EFFECT,
		n_APPEAR_RATE,
		n_RESET,
		n_WANTEDTIME,
		n_WANTEDAP,
		n_WANTED_SUCCESS,
		w_NAME,
		w_TIP
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_STAR { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public string s_STAGE_ICON { get; set; }

	[Preserve]
	public int n_BASIS_EFFECT { get; set; }

	[Preserve]
	public int n_EFFECT_X { get; set; }

	[Preserve]
	public int n_EFFECT_Y { get; set; }

	[Preserve]
	public int n_EXTRA_1 { get; set; }

	[Preserve]
	public int n_EXTRAX_1 { get; set; }

	[Preserve]
	public int n_EXTRAY_1 { get; set; }

	[Preserve]
	public int n_EXTRA_2 { get; set; }

	[Preserve]
	public int n_EXTRAX_2 { get; set; }

	[Preserve]
	public int n_EXTRAY_2 { get; set; }

	[Preserve]
	public int n_EXTRA_3 { get; set; }

	[Preserve]
	public int n_EXTRAX_3 { get; set; }

	[Preserve]
	public int n_EXTRAY_3 { get; set; }

	[Preserve]
	public int n_REWRD_1 { get; set; }

	[Preserve]
	public int n_NUMBER_1 { get; set; }

	[Preserve]
	public int n_REWRD_2 { get; set; }

	[Preserve]
	public int n_NUMBER_2 { get; set; }

	[Preserve]
	public int n_REWRD_3 { get; set; }

	[Preserve]
	public int n_NUMBER_3 { get; set; }

	[Preserve]
	public int n_PLAYERSTAR { get; set; }

	[Preserve]
	public int n_GUILDLEVEL { get; set; }

	[Preserve]
	public int n_APPEAR { get; set; }

	[Preserve]
	public int n_APPEAR_EFFECT { get; set; }

	[Preserve]
	public int n_APPEAR_RATE { get; set; }

	[Preserve]
	public int n_RESET { get; set; }

	[Preserve]
	public int n_WANTEDTIME { get; set; }

	[Preserve]
	public int n_WANTEDAP { get; set; }

	[Preserve]
	public int n_WANTED_SUCCESS { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string w_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(WANTED_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_STAR != tbl.n_STAR)
		{
			dictionary.Add(1, n_STAR);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(2, s_ICON);
		}
		if (s_STAGE_ICON != tbl.s_STAGE_ICON)
		{
			dictionary.Add(3, s_STAGE_ICON);
		}
		if (n_BASIS_EFFECT != tbl.n_BASIS_EFFECT)
		{
			dictionary.Add(4, n_BASIS_EFFECT);
		}
		if (n_EFFECT_X != tbl.n_EFFECT_X)
		{
			dictionary.Add(5, n_EFFECT_X);
		}
		if (n_EFFECT_Y != tbl.n_EFFECT_Y)
		{
			dictionary.Add(6, n_EFFECT_Y);
		}
		if (n_EXTRA_1 != tbl.n_EXTRA_1)
		{
			dictionary.Add(7, n_EXTRA_1);
		}
		if (n_EXTRAX_1 != tbl.n_EXTRAX_1)
		{
			dictionary.Add(8, n_EXTRAX_1);
		}
		if (n_EXTRAY_1 != tbl.n_EXTRAY_1)
		{
			dictionary.Add(9, n_EXTRAY_1);
		}
		if (n_EXTRA_2 != tbl.n_EXTRA_2)
		{
			dictionary.Add(10, n_EXTRA_2);
		}
		if (n_EXTRAX_2 != tbl.n_EXTRAX_2)
		{
			dictionary.Add(11, n_EXTRAX_2);
		}
		if (n_EXTRAY_2 != tbl.n_EXTRAY_2)
		{
			dictionary.Add(12, n_EXTRAY_2);
		}
		if (n_EXTRA_3 != tbl.n_EXTRA_3)
		{
			dictionary.Add(13, n_EXTRA_3);
		}
		if (n_EXTRAX_3 != tbl.n_EXTRAX_3)
		{
			dictionary.Add(14, n_EXTRAX_3);
		}
		if (n_EXTRAY_3 != tbl.n_EXTRAY_3)
		{
			dictionary.Add(15, n_EXTRAY_3);
		}
		if (n_REWRD_1 != tbl.n_REWRD_1)
		{
			dictionary.Add(16, n_REWRD_1);
		}
		if (n_NUMBER_1 != tbl.n_NUMBER_1)
		{
			dictionary.Add(17, n_NUMBER_1);
		}
		if (n_REWRD_2 != tbl.n_REWRD_2)
		{
			dictionary.Add(18, n_REWRD_2);
		}
		if (n_NUMBER_2 != tbl.n_NUMBER_2)
		{
			dictionary.Add(19, n_NUMBER_2);
		}
		if (n_REWRD_3 != tbl.n_REWRD_3)
		{
			dictionary.Add(20, n_REWRD_3);
		}
		if (n_NUMBER_3 != tbl.n_NUMBER_3)
		{
			dictionary.Add(21, n_NUMBER_3);
		}
		if (n_PLAYERSTAR != tbl.n_PLAYERSTAR)
		{
			dictionary.Add(22, n_PLAYERSTAR);
		}
		if (n_GUILDLEVEL != tbl.n_GUILDLEVEL)
		{
			dictionary.Add(23, n_GUILDLEVEL);
		}
		if (n_APPEAR != tbl.n_APPEAR)
		{
			dictionary.Add(24, n_APPEAR);
		}
		if (n_APPEAR_EFFECT != tbl.n_APPEAR_EFFECT)
		{
			dictionary.Add(25, n_APPEAR_EFFECT);
		}
		if (n_APPEAR_RATE != tbl.n_APPEAR_RATE)
		{
			dictionary.Add(26, n_APPEAR_RATE);
		}
		if (n_RESET != tbl.n_RESET)
		{
			dictionary.Add(27, n_RESET);
		}
		if (n_WANTEDTIME != tbl.n_WANTEDTIME)
		{
			dictionary.Add(28, n_WANTEDTIME);
		}
		if (n_WANTEDAP != tbl.n_WANTEDAP)
		{
			dictionary.Add(29, n_WANTEDAP);
		}
		if (n_WANTED_SUCCESS != tbl.n_WANTED_SUCCESS)
		{
			dictionary.Add(30, n_WANTED_SUCCESS);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(31, w_NAME);
		}
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(32, w_TIP);
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
				n_STAR = Convert.ToInt32(item.Value);
				break;
			case 2:
				s_ICON = item.Value.ToString();
				break;
			case 3:
				s_STAGE_ICON = item.Value.ToString();
				break;
			case 4:
				n_BASIS_EFFECT = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_EFFECT_X = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_EFFECT_Y = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_EXTRA_1 = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_EXTRAX_1 = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_EXTRAY_1 = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_EXTRA_2 = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_EXTRAX_2 = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_EXTRAY_2 = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_EXTRA_3 = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_EXTRAX_3 = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_EXTRAY_3 = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_REWRD_1 = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_NUMBER_1 = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_REWRD_2 = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_NUMBER_2 = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_REWRD_3 = Convert.ToInt32(item.Value);
				break;
			case 21:
				n_NUMBER_3 = Convert.ToInt32(item.Value);
				break;
			case 22:
				n_PLAYERSTAR = Convert.ToInt32(item.Value);
				break;
			case 23:
				n_GUILDLEVEL = Convert.ToInt32(item.Value);
				break;
			case 24:
				n_APPEAR = Convert.ToInt32(item.Value);
				break;
			case 25:
				n_APPEAR_EFFECT = Convert.ToInt32(item.Value);
				break;
			case 26:
				n_APPEAR_RATE = Convert.ToInt32(item.Value);
				break;
			case 27:
				n_RESET = Convert.ToInt32(item.Value);
				break;
			case 28:
				n_WANTEDTIME = Convert.ToInt32(item.Value);
				break;
			case 29:
				n_WANTEDAP = Convert.ToInt32(item.Value);
				break;
			case 30:
				n_WANTED_SUCCESS = Convert.ToInt32(item.Value);
				break;
			case 31:
				w_NAME = item.Value.ToString();
				break;
			case 32:
				w_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(WANTED_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_STAR != table.n_STAR)
		{
			return false;
		}
		if (s_ICON != table.s_ICON)
		{
			return false;
		}
		if (s_STAGE_ICON != table.s_STAGE_ICON)
		{
			return false;
		}
		if (n_BASIS_EFFECT != table.n_BASIS_EFFECT)
		{
			return false;
		}
		if (n_EFFECT_X != table.n_EFFECT_X)
		{
			return false;
		}
		if (n_EFFECT_Y != table.n_EFFECT_Y)
		{
			return false;
		}
		if (n_EXTRA_1 != table.n_EXTRA_1)
		{
			return false;
		}
		if (n_EXTRAX_1 != table.n_EXTRAX_1)
		{
			return false;
		}
		if (n_EXTRAY_1 != table.n_EXTRAY_1)
		{
			return false;
		}
		if (n_EXTRA_2 != table.n_EXTRA_2)
		{
			return false;
		}
		if (n_EXTRAX_2 != table.n_EXTRAX_2)
		{
			return false;
		}
		if (n_EXTRAY_2 != table.n_EXTRAY_2)
		{
			return false;
		}
		if (n_EXTRA_3 != table.n_EXTRA_3)
		{
			return false;
		}
		if (n_EXTRAX_3 != table.n_EXTRAX_3)
		{
			return false;
		}
		if (n_EXTRAY_3 != table.n_EXTRAY_3)
		{
			return false;
		}
		if (n_REWRD_1 != table.n_REWRD_1)
		{
			return false;
		}
		if (n_NUMBER_1 != table.n_NUMBER_1)
		{
			return false;
		}
		if (n_REWRD_2 != table.n_REWRD_2)
		{
			return false;
		}
		if (n_NUMBER_2 != table.n_NUMBER_2)
		{
			return false;
		}
		if (n_REWRD_3 != table.n_REWRD_3)
		{
			return false;
		}
		if (n_NUMBER_3 != table.n_NUMBER_3)
		{
			return false;
		}
		if (n_PLAYERSTAR != table.n_PLAYERSTAR)
		{
			return false;
		}
		if (n_GUILDLEVEL != table.n_GUILDLEVEL)
		{
			return false;
		}
		if (n_APPEAR != table.n_APPEAR)
		{
			return false;
		}
		if (n_APPEAR_EFFECT != table.n_APPEAR_EFFECT)
		{
			return false;
		}
		if (n_APPEAR_RATE != table.n_APPEAR_RATE)
		{
			return false;
		}
		if (n_RESET != table.n_RESET)
		{
			return false;
		}
		if (n_WANTEDTIME != table.n_WANTEDTIME)
		{
			return false;
		}
		if (n_WANTEDAP != table.n_WANTEDAP)
		{
			return false;
		}
		if (n_WANTED_SUCCESS != table.n_WANTED_SUCCESS)
		{
			return false;
		}
		if (w_NAME != table.w_NAME)
		{
			return false;
		}
		if (w_TIP != table.w_TIP)
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
		binaryWriter.Write(n_STAR);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.WriteExString(s_STAGE_ICON);
		binaryWriter.Write(n_BASIS_EFFECT);
		binaryWriter.Write(n_EFFECT_X);
		binaryWriter.Write(n_EFFECT_Y);
		binaryWriter.Write(n_EXTRA_1);
		binaryWriter.Write(n_EXTRAX_1);
		binaryWriter.Write(n_EXTRAY_1);
		binaryWriter.Write(n_EXTRA_2);
		binaryWriter.Write(n_EXTRAX_2);
		binaryWriter.Write(n_EXTRAY_2);
		binaryWriter.Write(n_EXTRA_3);
		binaryWriter.Write(n_EXTRAX_3);
		binaryWriter.Write(n_EXTRAY_3);
		binaryWriter.Write(n_REWRD_1);
		binaryWriter.Write(n_NUMBER_1);
		binaryWriter.Write(n_REWRD_2);
		binaryWriter.Write(n_NUMBER_2);
		binaryWriter.Write(n_REWRD_3);
		binaryWriter.Write(n_NUMBER_3);
		binaryWriter.Write(n_PLAYERSTAR);
		binaryWriter.Write(n_GUILDLEVEL);
		binaryWriter.Write(n_APPEAR);
		binaryWriter.Write(n_APPEAR_EFFECT);
		binaryWriter.Write(n_APPEAR_RATE);
		binaryWriter.Write(n_RESET);
		binaryWriter.Write(n_WANTEDTIME);
		binaryWriter.Write(n_WANTEDAP);
		binaryWriter.Write(n_WANTED_SUCCESS);
		binaryWriter.WriteExString(w_NAME);
		binaryWriter.WriteExString(w_TIP);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_STAR = binaryReader.ReadInt32();
		s_ICON = binaryReader.ReadExString();
		s_STAGE_ICON = binaryReader.ReadExString();
		n_BASIS_EFFECT = binaryReader.ReadInt32();
		n_EFFECT_X = binaryReader.ReadInt32();
		n_EFFECT_Y = binaryReader.ReadInt32();
		n_EXTRA_1 = binaryReader.ReadInt32();
		n_EXTRAX_1 = binaryReader.ReadInt32();
		n_EXTRAY_1 = binaryReader.ReadInt32();
		n_EXTRA_2 = binaryReader.ReadInt32();
		n_EXTRAX_2 = binaryReader.ReadInt32();
		n_EXTRAY_2 = binaryReader.ReadInt32();
		n_EXTRA_3 = binaryReader.ReadInt32();
		n_EXTRAX_3 = binaryReader.ReadInt32();
		n_EXTRAY_3 = binaryReader.ReadInt32();
		n_REWRD_1 = binaryReader.ReadInt32();
		n_NUMBER_1 = binaryReader.ReadInt32();
		n_REWRD_2 = binaryReader.ReadInt32();
		n_NUMBER_2 = binaryReader.ReadInt32();
		n_REWRD_3 = binaryReader.ReadInt32();
		n_NUMBER_3 = binaryReader.ReadInt32();
		n_PLAYERSTAR = binaryReader.ReadInt32();
		n_GUILDLEVEL = binaryReader.ReadInt32();
		n_APPEAR = binaryReader.ReadInt32();
		n_APPEAR_EFFECT = binaryReader.ReadInt32();
		n_APPEAR_RATE = binaryReader.ReadInt32();
		n_RESET = binaryReader.ReadInt32();
		n_WANTEDTIME = binaryReader.ReadInt32();
		n_WANTEDAP = binaryReader.ReadInt32();
		n_WANTED_SUCCESS = binaryReader.ReadInt32();
		w_NAME = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
	}
}
