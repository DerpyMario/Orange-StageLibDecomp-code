using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class STAGE_RULE_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_UI,
		n_CHARACTER,
		n_MAIN_WEAPON,
		n_SUB_WEAPON,
		n_MAIN_DISC,
		n_SUB_DISC,
		n_MAIN_FS,
		n_SUB_FS,
		n_HP,
		n_ATK,
		n_DEF,
		n_CRI,
		n_CRI_RESIST,
		n_CRIDMG,
		n_CRIDMG_RESIST,
		n_DODGE,
		n_HIT,
		n_PARRY,
		n_PARRY_RESIST,
		n_PARRY_DEF,
		n_SKILL_LV,
		n_PASSIVE_SKILL1,
		n_PASSIVE_SKILL2,
		n_PASSIVE_SKILL3,
		s_TIP
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_UI { get; set; }

	[Preserve]
	public int n_CHARACTER { get; set; }

	[Preserve]
	public int n_MAIN_WEAPON { get; set; }

	[Preserve]
	public int n_SUB_WEAPON { get; set; }

	[Preserve]
	public int n_MAIN_DISC { get; set; }

	[Preserve]
	public int n_SUB_DISC { get; set; }

	[Preserve]
	public int n_MAIN_FS { get; set; }

	[Preserve]
	public int n_SUB_FS { get; set; }

	[Preserve]
	public int n_HP { get; set; }

	[Preserve]
	public int n_ATK { get; set; }

	[Preserve]
	public int n_DEF { get; set; }

	[Preserve]
	public int n_CRI { get; set; }

	[Preserve]
	public int n_CRI_RESIST { get; set; }

	[Preserve]
	public int n_CRIDMG { get; set; }

	[Preserve]
	public int n_CRIDMG_RESIST { get; set; }

	[Preserve]
	public int n_DODGE { get; set; }

	[Preserve]
	public int n_HIT { get; set; }

	[Preserve]
	public int n_PARRY { get; set; }

	[Preserve]
	public int n_PARRY_RESIST { get; set; }

	[Preserve]
	public int n_PARRY_DEF { get; set; }

	[Preserve]
	public int n_SKILL_LV { get; set; }

	[Preserve]
	public int n_PASSIVE_SKILL1 { get; set; }

	[Preserve]
	public int n_PASSIVE_SKILL2 { get; set; }

	[Preserve]
	public int n_PASSIVE_SKILL3 { get; set; }

	[Preserve]
	public string s_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(STAGE_RULE_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_UI != tbl.n_UI)
		{
			dictionary.Add(1, n_UI);
		}
		if (n_CHARACTER != tbl.n_CHARACTER)
		{
			dictionary.Add(2, n_CHARACTER);
		}
		if (n_MAIN_WEAPON != tbl.n_MAIN_WEAPON)
		{
			dictionary.Add(3, n_MAIN_WEAPON);
		}
		if (n_SUB_WEAPON != tbl.n_SUB_WEAPON)
		{
			dictionary.Add(4, n_SUB_WEAPON);
		}
		if (n_MAIN_DISC != tbl.n_MAIN_DISC)
		{
			dictionary.Add(5, n_MAIN_DISC);
		}
		if (n_SUB_DISC != tbl.n_SUB_DISC)
		{
			dictionary.Add(6, n_SUB_DISC);
		}
		if (n_MAIN_FS != tbl.n_MAIN_FS)
		{
			dictionary.Add(7, n_MAIN_FS);
		}
		if (n_SUB_FS != tbl.n_SUB_FS)
		{
			dictionary.Add(8, n_SUB_FS);
		}
		if (n_HP != tbl.n_HP)
		{
			dictionary.Add(9, n_HP);
		}
		if (n_ATK != tbl.n_ATK)
		{
			dictionary.Add(10, n_ATK);
		}
		if (n_DEF != tbl.n_DEF)
		{
			dictionary.Add(11, n_DEF);
		}
		if (n_CRI != tbl.n_CRI)
		{
			dictionary.Add(12, n_CRI);
		}
		if (n_CRI_RESIST != tbl.n_CRI_RESIST)
		{
			dictionary.Add(13, n_CRI_RESIST);
		}
		if (n_CRIDMG != tbl.n_CRIDMG)
		{
			dictionary.Add(14, n_CRIDMG);
		}
		if (n_CRIDMG_RESIST != tbl.n_CRIDMG_RESIST)
		{
			dictionary.Add(15, n_CRIDMG_RESIST);
		}
		if (n_DODGE != tbl.n_DODGE)
		{
			dictionary.Add(16, n_DODGE);
		}
		if (n_HIT != tbl.n_HIT)
		{
			dictionary.Add(17, n_HIT);
		}
		if (n_PARRY != tbl.n_PARRY)
		{
			dictionary.Add(18, n_PARRY);
		}
		if (n_PARRY_RESIST != tbl.n_PARRY_RESIST)
		{
			dictionary.Add(19, n_PARRY_RESIST);
		}
		if (n_PARRY_DEF != tbl.n_PARRY_DEF)
		{
			dictionary.Add(20, n_PARRY_DEF);
		}
		if (n_SKILL_LV != tbl.n_SKILL_LV)
		{
			dictionary.Add(21, n_SKILL_LV);
		}
		if (n_PASSIVE_SKILL1 != tbl.n_PASSIVE_SKILL1)
		{
			dictionary.Add(22, n_PASSIVE_SKILL1);
		}
		if (n_PASSIVE_SKILL2 != tbl.n_PASSIVE_SKILL2)
		{
			dictionary.Add(23, n_PASSIVE_SKILL2);
		}
		if (n_PASSIVE_SKILL3 != tbl.n_PASSIVE_SKILL3)
		{
			dictionary.Add(24, n_PASSIVE_SKILL3);
		}
		if (s_TIP != tbl.s_TIP)
		{
			dictionary.Add(25, s_TIP);
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
				n_UI = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_CHARACTER = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_MAIN_WEAPON = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_SUB_WEAPON = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_MAIN_DISC = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_SUB_DISC = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_MAIN_FS = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_SUB_FS = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_HP = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_ATK = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_DEF = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_CRI = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_CRI_RESIST = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_CRIDMG = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_CRIDMG_RESIST = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_DODGE = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_HIT = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_PARRY = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_PARRY_RESIST = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_PARRY_DEF = Convert.ToInt32(item.Value);
				break;
			case 21:
				n_SKILL_LV = Convert.ToInt32(item.Value);
				break;
			case 22:
				n_PASSIVE_SKILL1 = Convert.ToInt32(item.Value);
				break;
			case 23:
				n_PASSIVE_SKILL2 = Convert.ToInt32(item.Value);
				break;
			case 24:
				n_PASSIVE_SKILL3 = Convert.ToInt32(item.Value);
				break;
			case 25:
				s_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(STAGE_RULE_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_UI != table.n_UI)
		{
			return false;
		}
		if (n_CHARACTER != table.n_CHARACTER)
		{
			return false;
		}
		if (n_MAIN_WEAPON != table.n_MAIN_WEAPON)
		{
			return false;
		}
		if (n_SUB_WEAPON != table.n_SUB_WEAPON)
		{
			return false;
		}
		if (n_MAIN_DISC != table.n_MAIN_DISC)
		{
			return false;
		}
		if (n_SUB_DISC != table.n_SUB_DISC)
		{
			return false;
		}
		if (n_MAIN_FS != table.n_MAIN_FS)
		{
			return false;
		}
		if (n_SUB_FS != table.n_SUB_FS)
		{
			return false;
		}
		if (n_HP != table.n_HP)
		{
			return false;
		}
		if (n_ATK != table.n_ATK)
		{
			return false;
		}
		if (n_DEF != table.n_DEF)
		{
			return false;
		}
		if (n_CRI != table.n_CRI)
		{
			return false;
		}
		if (n_CRI_RESIST != table.n_CRI_RESIST)
		{
			return false;
		}
		if (n_CRIDMG != table.n_CRIDMG)
		{
			return false;
		}
		if (n_CRIDMG_RESIST != table.n_CRIDMG_RESIST)
		{
			return false;
		}
		if (n_DODGE != table.n_DODGE)
		{
			return false;
		}
		if (n_HIT != table.n_HIT)
		{
			return false;
		}
		if (n_PARRY != table.n_PARRY)
		{
			return false;
		}
		if (n_PARRY_RESIST != table.n_PARRY_RESIST)
		{
			return false;
		}
		if (n_PARRY_DEF != table.n_PARRY_DEF)
		{
			return false;
		}
		if (n_SKILL_LV != table.n_SKILL_LV)
		{
			return false;
		}
		if (n_PASSIVE_SKILL1 != table.n_PASSIVE_SKILL1)
		{
			return false;
		}
		if (n_PASSIVE_SKILL2 != table.n_PASSIVE_SKILL2)
		{
			return false;
		}
		if (n_PASSIVE_SKILL3 != table.n_PASSIVE_SKILL3)
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
		binaryWriter.Write(n_UI);
		binaryWriter.Write(n_CHARACTER);
		binaryWriter.Write(n_MAIN_WEAPON);
		binaryWriter.Write(n_SUB_WEAPON);
		binaryWriter.Write(n_MAIN_DISC);
		binaryWriter.Write(n_SUB_DISC);
		binaryWriter.Write(n_MAIN_FS);
		binaryWriter.Write(n_SUB_FS);
		binaryWriter.Write(n_HP);
		binaryWriter.Write(n_ATK);
		binaryWriter.Write(n_DEF);
		binaryWriter.Write(n_CRI);
		binaryWriter.Write(n_CRI_RESIST);
		binaryWriter.Write(n_CRIDMG);
		binaryWriter.Write(n_CRIDMG_RESIST);
		binaryWriter.Write(n_DODGE);
		binaryWriter.Write(n_HIT);
		binaryWriter.Write(n_PARRY);
		binaryWriter.Write(n_PARRY_RESIST);
		binaryWriter.Write(n_PARRY_DEF);
		binaryWriter.Write(n_SKILL_LV);
		binaryWriter.Write(n_PASSIVE_SKILL1);
		binaryWriter.Write(n_PASSIVE_SKILL2);
		binaryWriter.Write(n_PASSIVE_SKILL3);
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
		n_UI = binaryReader.ReadInt32();
		n_CHARACTER = binaryReader.ReadInt32();
		n_MAIN_WEAPON = binaryReader.ReadInt32();
		n_SUB_WEAPON = binaryReader.ReadInt32();
		n_MAIN_DISC = binaryReader.ReadInt32();
		n_SUB_DISC = binaryReader.ReadInt32();
		n_MAIN_FS = binaryReader.ReadInt32();
		n_SUB_FS = binaryReader.ReadInt32();
		n_HP = binaryReader.ReadInt32();
		n_ATK = binaryReader.ReadInt32();
		n_DEF = binaryReader.ReadInt32();
		n_CRI = binaryReader.ReadInt32();
		n_CRI_RESIST = binaryReader.ReadInt32();
		n_CRIDMG = binaryReader.ReadInt32();
		n_CRIDMG_RESIST = binaryReader.ReadInt32();
		n_DODGE = binaryReader.ReadInt32();
		n_HIT = binaryReader.ReadInt32();
		n_PARRY = binaryReader.ReadInt32();
		n_PARRY_RESIST = binaryReader.ReadInt32();
		n_PARRY_DEF = binaryReader.ReadInt32();
		n_SKILL_LV = binaryReader.ReadInt32();
		n_PASSIVE_SKILL1 = binaryReader.ReadInt32();
		n_PASSIVE_SKILL2 = binaryReader.ReadInt32();
		n_PASSIVE_SKILL3 = binaryReader.ReadInt32();
		s_TIP = binaryReader.ReadExString();
	}
}
