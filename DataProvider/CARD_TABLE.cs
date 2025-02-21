using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class CARD_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		s_NAME,
		n_RARITY,
		s_ICON,
		s_CARDIMG,
		n_CHARACTER_ID,
		n_PATCH,
		f_PARAM_HP,
		f_PARAM_ATK,
		f_PARAM_DEF,
		n_RANKMAX,
		f_RANKUP,
		n_GALLERY_MODEL,
		n_EXP,
		n_MONEY,
		s_SKILL1_COMBINATION,
		n_SKILL1_CHARAID,
		n_SKILL1_RANK0,
		n_SKILL1_RANK1,
		n_SKILL1_RANK2,
		n_SKILL1_RANK3,
		n_SKILL1_RANK4,
		n_SKILL1_RANK5,
		s_SKILL2_COMBINATION,
		n_SKILL2_CHARAID,
		n_SKILL2_RANK0,
		n_SKILL2_RANK1,
		n_SKILL2_RANK2,
		n_SKILL2_RANK3,
		n_SKILL2_RANK4,
		n_SKILL2_RANK5,
		s_START_VERSION,
		s_END_VERSION,
		w_NAME,
		w_TIP
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public int n_RARITY { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public string s_CARDIMG { get; set; }

	[Preserve]
	public int n_CHARACTER_ID { get; set; }

	[Preserve]
	public int n_PATCH { get; set; }

	[Preserve]
	public float f_PARAM_HP { get; set; }

	[Preserve]
	public float f_PARAM_ATK { get; set; }

	[Preserve]
	public float f_PARAM_DEF { get; set; }

	[Preserve]
	public int n_RANKMAX { get; set; }

	[Preserve]
	public float f_RANKUP { get; set; }

	[Preserve]
	public int n_GALLERY_MODEL { get; set; }

	[Preserve]
	public int n_EXP { get; set; }

	[Preserve]
	public int n_MONEY { get; set; }

	[Preserve]
	public string s_SKILL1_COMBINATION { get; set; }

	[Preserve]
	public int n_SKILL1_CHARAID { get; set; }

	[Preserve]
	public int n_SKILL1_RANK0 { get; set; }

	[Preserve]
	public int n_SKILL1_RANK1 { get; set; }

	[Preserve]
	public int n_SKILL1_RANK2 { get; set; }

	[Preserve]
	public int n_SKILL1_RANK3 { get; set; }

	[Preserve]
	public int n_SKILL1_RANK4 { get; set; }

	[Preserve]
	public int n_SKILL1_RANK5 { get; set; }

	[Preserve]
	public string s_SKILL2_COMBINATION { get; set; }

	[Preserve]
	public int n_SKILL2_CHARAID { get; set; }

	[Preserve]
	public int n_SKILL2_RANK0 { get; set; }

	[Preserve]
	public int n_SKILL2_RANK1 { get; set; }

	[Preserve]
	public int n_SKILL2_RANK2 { get; set; }

	[Preserve]
	public int n_SKILL2_RANK3 { get; set; }

	[Preserve]
	public int n_SKILL2_RANK4 { get; set; }

	[Preserve]
	public int n_SKILL2_RANK5 { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string w_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(CARD_TABLE tbl)
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
		if (s_NAME != tbl.s_NAME)
		{
			dictionary.Add(2, s_NAME);
		}
		if (n_RARITY != tbl.n_RARITY)
		{
			dictionary.Add(3, n_RARITY);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(4, s_ICON);
		}
		if (s_CARDIMG != tbl.s_CARDIMG)
		{
			dictionary.Add(5, s_CARDIMG);
		}
		if (n_CHARACTER_ID != tbl.n_CHARACTER_ID)
		{
			dictionary.Add(6, n_CHARACTER_ID);
		}
		if (n_PATCH != tbl.n_PATCH)
		{
			dictionary.Add(7, n_PATCH);
		}
		if (f_PARAM_HP != tbl.f_PARAM_HP)
		{
			dictionary.Add(8, f_PARAM_HP);
		}
		if (f_PARAM_ATK != tbl.f_PARAM_ATK)
		{
			dictionary.Add(9, f_PARAM_ATK);
		}
		if (f_PARAM_DEF != tbl.f_PARAM_DEF)
		{
			dictionary.Add(10, f_PARAM_DEF);
		}
		if (n_RANKMAX != tbl.n_RANKMAX)
		{
			dictionary.Add(11, n_RANKMAX);
		}
		if (f_RANKUP != tbl.f_RANKUP)
		{
			dictionary.Add(12, f_RANKUP);
		}
		if (n_GALLERY_MODEL != tbl.n_GALLERY_MODEL)
		{
			dictionary.Add(13, n_GALLERY_MODEL);
		}
		if (n_EXP != tbl.n_EXP)
		{
			dictionary.Add(14, n_EXP);
		}
		if (n_MONEY != tbl.n_MONEY)
		{
			dictionary.Add(15, n_MONEY);
		}
		if (s_SKILL1_COMBINATION != tbl.s_SKILL1_COMBINATION)
		{
			dictionary.Add(16, s_SKILL1_COMBINATION);
		}
		if (n_SKILL1_CHARAID != tbl.n_SKILL1_CHARAID)
		{
			dictionary.Add(17, n_SKILL1_CHARAID);
		}
		if (n_SKILL1_RANK0 != tbl.n_SKILL1_RANK0)
		{
			dictionary.Add(18, n_SKILL1_RANK0);
		}
		if (n_SKILL1_RANK1 != tbl.n_SKILL1_RANK1)
		{
			dictionary.Add(19, n_SKILL1_RANK1);
		}
		if (n_SKILL1_RANK2 != tbl.n_SKILL1_RANK2)
		{
			dictionary.Add(20, n_SKILL1_RANK2);
		}
		if (n_SKILL1_RANK3 != tbl.n_SKILL1_RANK3)
		{
			dictionary.Add(21, n_SKILL1_RANK3);
		}
		if (n_SKILL1_RANK4 != tbl.n_SKILL1_RANK4)
		{
			dictionary.Add(22, n_SKILL1_RANK4);
		}
		if (n_SKILL1_RANK5 != tbl.n_SKILL1_RANK5)
		{
			dictionary.Add(23, n_SKILL1_RANK5);
		}
		if (s_SKILL2_COMBINATION != tbl.s_SKILL2_COMBINATION)
		{
			dictionary.Add(24, s_SKILL2_COMBINATION);
		}
		if (n_SKILL2_CHARAID != tbl.n_SKILL2_CHARAID)
		{
			dictionary.Add(25, n_SKILL2_CHARAID);
		}
		if (n_SKILL2_RANK0 != tbl.n_SKILL2_RANK0)
		{
			dictionary.Add(26, n_SKILL2_RANK0);
		}
		if (n_SKILL2_RANK1 != tbl.n_SKILL2_RANK1)
		{
			dictionary.Add(27, n_SKILL2_RANK1);
		}
		if (n_SKILL2_RANK2 != tbl.n_SKILL2_RANK2)
		{
			dictionary.Add(28, n_SKILL2_RANK2);
		}
		if (n_SKILL2_RANK3 != tbl.n_SKILL2_RANK3)
		{
			dictionary.Add(29, n_SKILL2_RANK3);
		}
		if (n_SKILL2_RANK4 != tbl.n_SKILL2_RANK4)
		{
			dictionary.Add(30, n_SKILL2_RANK4);
		}
		if (n_SKILL2_RANK5 != tbl.n_SKILL2_RANK5)
		{
			dictionary.Add(31, n_SKILL2_RANK5);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(32, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(33, s_END_VERSION);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(34, w_NAME);
		}
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(35, w_TIP);
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
				s_NAME = item.Value.ToString();
				break;
			case 3:
				n_RARITY = Convert.ToInt32(item.Value);
				break;
			case 4:
				s_ICON = item.Value.ToString();
				break;
			case 5:
				s_CARDIMG = item.Value.ToString();
				break;
			case 6:
				n_CHARACTER_ID = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_PATCH = Convert.ToInt32(item.Value);
				break;
			case 8:
				f_PARAM_HP = Convert.ToSingle(item.Value);
				break;
			case 9:
				f_PARAM_ATK = Convert.ToSingle(item.Value);
				break;
			case 10:
				f_PARAM_DEF = Convert.ToSingle(item.Value);
				break;
			case 11:
				n_RANKMAX = Convert.ToInt32(item.Value);
				break;
			case 12:
				f_RANKUP = Convert.ToSingle(item.Value);
				break;
			case 13:
				n_GALLERY_MODEL = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_EXP = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_MONEY = Convert.ToInt32(item.Value);
				break;
			case 16:
				s_SKILL1_COMBINATION = item.Value.ToString();
				break;
			case 17:
				n_SKILL1_CHARAID = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_SKILL1_RANK0 = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_SKILL1_RANK1 = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_SKILL1_RANK2 = Convert.ToInt32(item.Value);
				break;
			case 21:
				n_SKILL1_RANK3 = Convert.ToInt32(item.Value);
				break;
			case 22:
				n_SKILL1_RANK4 = Convert.ToInt32(item.Value);
				break;
			case 23:
				n_SKILL1_RANK5 = Convert.ToInt32(item.Value);
				break;
			case 24:
				s_SKILL2_COMBINATION = item.Value.ToString();
				break;
			case 25:
				n_SKILL2_CHARAID = Convert.ToInt32(item.Value);
				break;
			case 26:
				n_SKILL2_RANK0 = Convert.ToInt32(item.Value);
				break;
			case 27:
				n_SKILL2_RANK1 = Convert.ToInt32(item.Value);
				break;
			case 28:
				n_SKILL2_RANK2 = Convert.ToInt32(item.Value);
				break;
			case 29:
				n_SKILL2_RANK3 = Convert.ToInt32(item.Value);
				break;
			case 30:
				n_SKILL2_RANK4 = Convert.ToInt32(item.Value);
				break;
			case 31:
				n_SKILL2_RANK5 = Convert.ToInt32(item.Value);
				break;
			case 32:
				s_START_VERSION = item.Value.ToString();
				break;
			case 33:
				s_END_VERSION = item.Value.ToString();
				break;
			case 34:
				w_NAME = item.Value.ToString();
				break;
			case 35:
				w_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(CARD_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (s_NAME != table.s_NAME)
		{
			return false;
		}
		if (n_RARITY != table.n_RARITY)
		{
			return false;
		}
		if (s_ICON != table.s_ICON)
		{
			return false;
		}
		if (s_CARDIMG != table.s_CARDIMG)
		{
			return false;
		}
		if (n_CHARACTER_ID != table.n_CHARACTER_ID)
		{
			return false;
		}
		if (n_PATCH != table.n_PATCH)
		{
			return false;
		}
		if (f_PARAM_HP != table.f_PARAM_HP)
		{
			return false;
		}
		if (f_PARAM_ATK != table.f_PARAM_ATK)
		{
			return false;
		}
		if (f_PARAM_DEF != table.f_PARAM_DEF)
		{
			return false;
		}
		if (n_RANKMAX != table.n_RANKMAX)
		{
			return false;
		}
		if (f_RANKUP != table.f_RANKUP)
		{
			return false;
		}
		if (n_GALLERY_MODEL != table.n_GALLERY_MODEL)
		{
			return false;
		}
		if (n_EXP != table.n_EXP)
		{
			return false;
		}
		if (n_MONEY != table.n_MONEY)
		{
			return false;
		}
		if (s_SKILL1_COMBINATION != table.s_SKILL1_COMBINATION)
		{
			return false;
		}
		if (n_SKILL1_CHARAID != table.n_SKILL1_CHARAID)
		{
			return false;
		}
		if (n_SKILL1_RANK0 != table.n_SKILL1_RANK0)
		{
			return false;
		}
		if (n_SKILL1_RANK1 != table.n_SKILL1_RANK1)
		{
			return false;
		}
		if (n_SKILL1_RANK2 != table.n_SKILL1_RANK2)
		{
			return false;
		}
		if (n_SKILL1_RANK3 != table.n_SKILL1_RANK3)
		{
			return false;
		}
		if (n_SKILL1_RANK4 != table.n_SKILL1_RANK4)
		{
			return false;
		}
		if (n_SKILL1_RANK5 != table.n_SKILL1_RANK5)
		{
			return false;
		}
		if (s_SKILL2_COMBINATION != table.s_SKILL2_COMBINATION)
		{
			return false;
		}
		if (n_SKILL2_CHARAID != table.n_SKILL2_CHARAID)
		{
			return false;
		}
		if (n_SKILL2_RANK0 != table.n_SKILL2_RANK0)
		{
			return false;
		}
		if (n_SKILL2_RANK1 != table.n_SKILL2_RANK1)
		{
			return false;
		}
		if (n_SKILL2_RANK2 != table.n_SKILL2_RANK2)
		{
			return false;
		}
		if (n_SKILL2_RANK3 != table.n_SKILL2_RANK3)
		{
			return false;
		}
		if (n_SKILL2_RANK4 != table.n_SKILL2_RANK4)
		{
			return false;
		}
		if (n_SKILL2_RANK5 != table.n_SKILL2_RANK5)
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
		binaryWriter.Write(n_TYPE);
		binaryWriter.WriteExString(s_NAME);
		binaryWriter.Write(n_RARITY);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.WriteExString(s_CARDIMG);
		binaryWriter.Write(n_CHARACTER_ID);
		binaryWriter.Write(n_PATCH);
		binaryWriter.Write(f_PARAM_HP);
		binaryWriter.Write(f_PARAM_ATK);
		binaryWriter.Write(f_PARAM_DEF);
		binaryWriter.Write(n_RANKMAX);
		binaryWriter.Write(f_RANKUP);
		binaryWriter.Write(n_GALLERY_MODEL);
		binaryWriter.Write(n_EXP);
		binaryWriter.Write(n_MONEY);
		binaryWriter.WriteExString(s_SKILL1_COMBINATION);
		binaryWriter.Write(n_SKILL1_CHARAID);
		binaryWriter.Write(n_SKILL1_RANK0);
		binaryWriter.Write(n_SKILL1_RANK1);
		binaryWriter.Write(n_SKILL1_RANK2);
		binaryWriter.Write(n_SKILL1_RANK3);
		binaryWriter.Write(n_SKILL1_RANK4);
		binaryWriter.Write(n_SKILL1_RANK5);
		binaryWriter.WriteExString(s_SKILL2_COMBINATION);
		binaryWriter.Write(n_SKILL2_CHARAID);
		binaryWriter.Write(n_SKILL2_RANK0);
		binaryWriter.Write(n_SKILL2_RANK1);
		binaryWriter.Write(n_SKILL2_RANK2);
		binaryWriter.Write(n_SKILL2_RANK3);
		binaryWriter.Write(n_SKILL2_RANK4);
		binaryWriter.Write(n_SKILL2_RANK5);
		binaryWriter.WriteExString(s_START_VERSION);
		binaryWriter.WriteExString(s_END_VERSION);
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
		n_TYPE = binaryReader.ReadInt32();
		s_NAME = binaryReader.ReadExString();
		n_RARITY = binaryReader.ReadInt32();
		s_ICON = binaryReader.ReadExString();
		s_CARDIMG = binaryReader.ReadExString();
		n_CHARACTER_ID = binaryReader.ReadInt32();
		n_PATCH = binaryReader.ReadInt32();
		f_PARAM_HP = binaryReader.ReadSingle();
		f_PARAM_ATK = binaryReader.ReadSingle();
		f_PARAM_DEF = binaryReader.ReadSingle();
		n_RANKMAX = binaryReader.ReadInt32();
		f_RANKUP = binaryReader.ReadSingle();
		n_GALLERY_MODEL = binaryReader.ReadInt32();
		n_EXP = binaryReader.ReadInt32();
		n_MONEY = binaryReader.ReadInt32();
		s_SKILL1_COMBINATION = binaryReader.ReadExString();
		n_SKILL1_CHARAID = binaryReader.ReadInt32();
		n_SKILL1_RANK0 = binaryReader.ReadInt32();
		n_SKILL1_RANK1 = binaryReader.ReadInt32();
		n_SKILL1_RANK2 = binaryReader.ReadInt32();
		n_SKILL1_RANK3 = binaryReader.ReadInt32();
		n_SKILL1_RANK4 = binaryReader.ReadInt32();
		n_SKILL1_RANK5 = binaryReader.ReadInt32();
		s_SKILL2_COMBINATION = binaryReader.ReadExString();
		n_SKILL2_CHARAID = binaryReader.ReadInt32();
		n_SKILL2_RANK0 = binaryReader.ReadInt32();
		n_SKILL2_RANK1 = binaryReader.ReadInt32();
		n_SKILL2_RANK2 = binaryReader.ReadInt32();
		n_SKILL2_RANK3 = binaryReader.ReadInt32();
		n_SKILL2_RANK4 = binaryReader.ReadInt32();
		n_SKILL2_RANK5 = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		w_NAME = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
	}
}
