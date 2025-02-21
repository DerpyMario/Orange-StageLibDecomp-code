using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class EXP_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_RANKEXP,
		n_TOTAL_RANKEXP,
		n_RANK_ATK,
		n_RANK_HP,
		n_RANK_DEF,
		n_RANK_DOD,
		n_STAMINA,
		n_SKILL1_LV,
		n_SKILL2_LV,
		n_SKILLUP_MONEY,
		n_SKILLUP_SP,
		n_GALLERYEXP,
		n_TOTAL_GALLERYEXP,
		n_GALLERY_ATK,
		n_GALLERY_HP,
		n_GALLERY_DEF,
		n_CARDGALLERY_ATK,
		n_CARDGALLERY_HP,
		n_CARDGALLERY_DEF,
		n_WEAPONEXP,
		n_TOTAL_WEAPONEXP,
		n_WEAPON_ATK,
		n_WEAPON_HP,
		n_WEAPON_CRI,
		n_WEAPON_HIT,
		n_DISCEXP,
		n_TOTAL_DISCEXP,
		n_DISC_ATK,
		n_DISC_HP,
		n_DISC_DEF,
		n_CARDEXP,
		n_TOTAL_CARDEXP,
		n_CARD_ATK,
		n_CARD_HP,
		n_CARD_DEF,
		n_EQUIPUP_DEF,
		n_EQUIPUP_HP,
		n_EQUIPUP_MATERIAL,
		n_EQUIPUP_MONEY,
		n_PET_ATK,
		n_PET_HP,
		n_PET_DEF,
		n_PET_MATERIAL,
		n_PET_MONEY,
		n_RESEARCHEXP,
		n_TOTAL_RESEARCHEXP,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_RANKEXP { get; set; }

	[Preserve]
	public int n_TOTAL_RANKEXP { get; set; }

	[Preserve]
	public int n_RANK_ATK { get; set; }

	[Preserve]
	public int n_RANK_HP { get; set; }

	[Preserve]
	public int n_RANK_DEF { get; set; }

	[Preserve]
	public int n_RANK_DOD { get; set; }

	[Preserve]
	public int n_STAMINA { get; set; }

	[Preserve]
	public int n_SKILL1_LV { get; set; }

	[Preserve]
	public int n_SKILL2_LV { get; set; }

	[Preserve]
	public int n_SKILLUP_MONEY { get; set; }

	[Preserve]
	public int n_SKILLUP_SP { get; set; }

	[Preserve]
	public int n_GALLERYEXP { get; set; }

	[Preserve]
	public int n_TOTAL_GALLERYEXP { get; set; }

	[Preserve]
	public int n_GALLERY_ATK { get; set; }

	[Preserve]
	public int n_GALLERY_HP { get; set; }

	[Preserve]
	public int n_GALLERY_DEF { get; set; }

	[Preserve]
	public int n_CARDGALLERY_ATK { get; set; }

	[Preserve]
	public int n_CARDGALLERY_HP { get; set; }

	[Preserve]
	public int n_CARDGALLERY_DEF { get; set; }

	[Preserve]
	public int n_WEAPONEXP { get; set; }

	[Preserve]
	public int n_TOTAL_WEAPONEXP { get; set; }

	[Preserve]
	public int n_WEAPON_ATK { get; set; }

	[Preserve]
	public int n_WEAPON_HP { get; set; }

	[Preserve]
	public int n_WEAPON_CRI { get; set; }

	[Preserve]
	public int n_WEAPON_HIT { get; set; }

	[Preserve]
	public int n_DISCEXP { get; set; }

	[Preserve]
	public int n_TOTAL_DISCEXP { get; set; }

	[Preserve]
	public int n_DISC_ATK { get; set; }

	[Preserve]
	public int n_DISC_HP { get; set; }

	[Preserve]
	public int n_DISC_DEF { get; set; }

	[Preserve]
	public int n_CARDEXP { get; set; }

	[Preserve]
	public int n_TOTAL_CARDEXP { get; set; }

	[Preserve]
	public int n_CARD_ATK { get; set; }

	[Preserve]
	public int n_CARD_HP { get; set; }

	[Preserve]
	public int n_CARD_DEF { get; set; }

	[Preserve]
	public int n_EQUIPUP_DEF { get; set; }

	[Preserve]
	public int n_EQUIPUP_HP { get; set; }

	[Preserve]
	public int n_EQUIPUP_MATERIAL { get; set; }

	[Preserve]
	public int n_EQUIPUP_MONEY { get; set; }

	[Preserve]
	public int n_PET_ATK { get; set; }

	[Preserve]
	public int n_PET_HP { get; set; }

	[Preserve]
	public int n_PET_DEF { get; set; }

	[Preserve]
	public int n_PET_MATERIAL { get; set; }

	[Preserve]
	public int n_PET_MONEY { get; set; }

	[Preserve]
	public int n_RESEARCHEXP { get; set; }

	[Preserve]
	public int n_TOTAL_RESEARCHEXP { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(EXP_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_RANKEXP != tbl.n_RANKEXP)
		{
			dictionary.Add(1, n_RANKEXP);
		}
		if (n_TOTAL_RANKEXP != tbl.n_TOTAL_RANKEXP)
		{
			dictionary.Add(2, n_TOTAL_RANKEXP);
		}
		if (n_RANK_ATK != tbl.n_RANK_ATK)
		{
			dictionary.Add(3, n_RANK_ATK);
		}
		if (n_RANK_HP != tbl.n_RANK_HP)
		{
			dictionary.Add(4, n_RANK_HP);
		}
		if (n_RANK_DEF != tbl.n_RANK_DEF)
		{
			dictionary.Add(5, n_RANK_DEF);
		}
		if (n_RANK_DOD != tbl.n_RANK_DOD)
		{
			dictionary.Add(6, n_RANK_DOD);
		}
		if (n_STAMINA != tbl.n_STAMINA)
		{
			dictionary.Add(7, n_STAMINA);
		}
		if (n_SKILL1_LV != tbl.n_SKILL1_LV)
		{
			dictionary.Add(8, n_SKILL1_LV);
		}
		if (n_SKILL2_LV != tbl.n_SKILL2_LV)
		{
			dictionary.Add(9, n_SKILL2_LV);
		}
		if (n_SKILLUP_MONEY != tbl.n_SKILLUP_MONEY)
		{
			dictionary.Add(10, n_SKILLUP_MONEY);
		}
		if (n_SKILLUP_SP != tbl.n_SKILLUP_SP)
		{
			dictionary.Add(11, n_SKILLUP_SP);
		}
		if (n_GALLERYEXP != tbl.n_GALLERYEXP)
		{
			dictionary.Add(12, n_GALLERYEXP);
		}
		if (n_TOTAL_GALLERYEXP != tbl.n_TOTAL_GALLERYEXP)
		{
			dictionary.Add(13, n_TOTAL_GALLERYEXP);
		}
		if (n_GALLERY_ATK != tbl.n_GALLERY_ATK)
		{
			dictionary.Add(14, n_GALLERY_ATK);
		}
		if (n_GALLERY_HP != tbl.n_GALLERY_HP)
		{
			dictionary.Add(15, n_GALLERY_HP);
		}
		if (n_GALLERY_DEF != tbl.n_GALLERY_DEF)
		{
			dictionary.Add(16, n_GALLERY_DEF);
		}
		if (n_CARDGALLERY_ATK != tbl.n_CARDGALLERY_ATK)
		{
			dictionary.Add(17, n_CARDGALLERY_ATK);
		}
		if (n_CARDGALLERY_HP != tbl.n_CARDGALLERY_HP)
		{
			dictionary.Add(18, n_CARDGALLERY_HP);
		}
		if (n_CARDGALLERY_DEF != tbl.n_CARDGALLERY_DEF)
		{
			dictionary.Add(19, n_CARDGALLERY_DEF);
		}
		if (n_WEAPONEXP != tbl.n_WEAPONEXP)
		{
			dictionary.Add(20, n_WEAPONEXP);
		}
		if (n_TOTAL_WEAPONEXP != tbl.n_TOTAL_WEAPONEXP)
		{
			dictionary.Add(21, n_TOTAL_WEAPONEXP);
		}
		if (n_WEAPON_ATK != tbl.n_WEAPON_ATK)
		{
			dictionary.Add(22, n_WEAPON_ATK);
		}
		if (n_WEAPON_HP != tbl.n_WEAPON_HP)
		{
			dictionary.Add(23, n_WEAPON_HP);
		}
		if (n_WEAPON_CRI != tbl.n_WEAPON_CRI)
		{
			dictionary.Add(24, n_WEAPON_CRI);
		}
		if (n_WEAPON_HIT != tbl.n_WEAPON_HIT)
		{
			dictionary.Add(25, n_WEAPON_HIT);
		}
		if (n_DISCEXP != tbl.n_DISCEXP)
		{
			dictionary.Add(26, n_DISCEXP);
		}
		if (n_TOTAL_DISCEXP != tbl.n_TOTAL_DISCEXP)
		{
			dictionary.Add(27, n_TOTAL_DISCEXP);
		}
		if (n_DISC_ATK != tbl.n_DISC_ATK)
		{
			dictionary.Add(28, n_DISC_ATK);
		}
		if (n_DISC_HP != tbl.n_DISC_HP)
		{
			dictionary.Add(29, n_DISC_HP);
		}
		if (n_DISC_DEF != tbl.n_DISC_DEF)
		{
			dictionary.Add(30, n_DISC_DEF);
		}
		if (n_CARDEXP != tbl.n_CARDEXP)
		{
			dictionary.Add(31, n_CARDEXP);
		}
		if (n_TOTAL_CARDEXP != tbl.n_TOTAL_CARDEXP)
		{
			dictionary.Add(32, n_TOTAL_CARDEXP);
		}
		if (n_CARD_ATK != tbl.n_CARD_ATK)
		{
			dictionary.Add(33, n_CARD_ATK);
		}
		if (n_CARD_HP != tbl.n_CARD_HP)
		{
			dictionary.Add(34, n_CARD_HP);
		}
		if (n_CARD_DEF != tbl.n_CARD_DEF)
		{
			dictionary.Add(35, n_CARD_DEF);
		}
		if (n_EQUIPUP_DEF != tbl.n_EQUIPUP_DEF)
		{
			dictionary.Add(36, n_EQUIPUP_DEF);
		}
		if (n_EQUIPUP_HP != tbl.n_EQUIPUP_HP)
		{
			dictionary.Add(37, n_EQUIPUP_HP);
		}
		if (n_EQUIPUP_MATERIAL != tbl.n_EQUIPUP_MATERIAL)
		{
			dictionary.Add(38, n_EQUIPUP_MATERIAL);
		}
		if (n_EQUIPUP_MONEY != tbl.n_EQUIPUP_MONEY)
		{
			dictionary.Add(39, n_EQUIPUP_MONEY);
		}
		if (n_PET_ATK != tbl.n_PET_ATK)
		{
			dictionary.Add(40, n_PET_ATK);
		}
		if (n_PET_HP != tbl.n_PET_HP)
		{
			dictionary.Add(41, n_PET_HP);
		}
		if (n_PET_DEF != tbl.n_PET_DEF)
		{
			dictionary.Add(42, n_PET_DEF);
		}
		if (n_PET_MATERIAL != tbl.n_PET_MATERIAL)
		{
			dictionary.Add(43, n_PET_MATERIAL);
		}
		if (n_PET_MONEY != tbl.n_PET_MONEY)
		{
			dictionary.Add(44, n_PET_MONEY);
		}
		if (n_RESEARCHEXP != tbl.n_RESEARCHEXP)
		{
			dictionary.Add(45, n_RESEARCHEXP);
		}
		if (n_TOTAL_RESEARCHEXP != tbl.n_TOTAL_RESEARCHEXP)
		{
			dictionary.Add(46, n_TOTAL_RESEARCHEXP);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(47, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(48, s_END_VERSION);
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
				n_RANKEXP = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_TOTAL_RANKEXP = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_RANK_ATK = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_RANK_HP = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_RANK_DEF = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_RANK_DOD = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_STAMINA = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_SKILL1_LV = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_SKILL2_LV = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_SKILLUP_MONEY = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_SKILLUP_SP = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_GALLERYEXP = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_TOTAL_GALLERYEXP = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_GALLERY_ATK = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_GALLERY_HP = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_GALLERY_DEF = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_CARDGALLERY_ATK = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_CARDGALLERY_HP = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_CARDGALLERY_DEF = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_WEAPONEXP = Convert.ToInt32(item.Value);
				break;
			case 21:
				n_TOTAL_WEAPONEXP = Convert.ToInt32(item.Value);
				break;
			case 22:
				n_WEAPON_ATK = Convert.ToInt32(item.Value);
				break;
			case 23:
				n_WEAPON_HP = Convert.ToInt32(item.Value);
				break;
			case 24:
				n_WEAPON_CRI = Convert.ToInt32(item.Value);
				break;
			case 25:
				n_WEAPON_HIT = Convert.ToInt32(item.Value);
				break;
			case 26:
				n_DISCEXP = Convert.ToInt32(item.Value);
				break;
			case 27:
				n_TOTAL_DISCEXP = Convert.ToInt32(item.Value);
				break;
			case 28:
				n_DISC_ATK = Convert.ToInt32(item.Value);
				break;
			case 29:
				n_DISC_HP = Convert.ToInt32(item.Value);
				break;
			case 30:
				n_DISC_DEF = Convert.ToInt32(item.Value);
				break;
			case 31:
				n_CARDEXP = Convert.ToInt32(item.Value);
				break;
			case 32:
				n_TOTAL_CARDEXP = Convert.ToInt32(item.Value);
				break;
			case 33:
				n_CARD_ATK = Convert.ToInt32(item.Value);
				break;
			case 34:
				n_CARD_HP = Convert.ToInt32(item.Value);
				break;
			case 35:
				n_CARD_DEF = Convert.ToInt32(item.Value);
				break;
			case 36:
				n_EQUIPUP_DEF = Convert.ToInt32(item.Value);
				break;
			case 37:
				n_EQUIPUP_HP = Convert.ToInt32(item.Value);
				break;
			case 38:
				n_EQUIPUP_MATERIAL = Convert.ToInt32(item.Value);
				break;
			case 39:
				n_EQUIPUP_MONEY = Convert.ToInt32(item.Value);
				break;
			case 40:
				n_PET_ATK = Convert.ToInt32(item.Value);
				break;
			case 41:
				n_PET_HP = Convert.ToInt32(item.Value);
				break;
			case 42:
				n_PET_DEF = Convert.ToInt32(item.Value);
				break;
			case 43:
				n_PET_MATERIAL = Convert.ToInt32(item.Value);
				break;
			case 44:
				n_PET_MONEY = Convert.ToInt32(item.Value);
				break;
			case 45:
				n_RESEARCHEXP = Convert.ToInt32(item.Value);
				break;
			case 46:
				n_TOTAL_RESEARCHEXP = Convert.ToInt32(item.Value);
				break;
			case 47:
				s_START_VERSION = item.Value.ToString();
				break;
			case 48:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(EXP_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_RANKEXP != table.n_RANKEXP)
		{
			return false;
		}
		if (n_TOTAL_RANKEXP != table.n_TOTAL_RANKEXP)
		{
			return false;
		}
		if (n_RANK_ATK != table.n_RANK_ATK)
		{
			return false;
		}
		if (n_RANK_HP != table.n_RANK_HP)
		{
			return false;
		}
		if (n_RANK_DEF != table.n_RANK_DEF)
		{
			return false;
		}
		if (n_RANK_DOD != table.n_RANK_DOD)
		{
			return false;
		}
		if (n_STAMINA != table.n_STAMINA)
		{
			return false;
		}
		if (n_SKILL1_LV != table.n_SKILL1_LV)
		{
			return false;
		}
		if (n_SKILL2_LV != table.n_SKILL2_LV)
		{
			return false;
		}
		if (n_SKILLUP_MONEY != table.n_SKILLUP_MONEY)
		{
			return false;
		}
		if (n_SKILLUP_SP != table.n_SKILLUP_SP)
		{
			return false;
		}
		if (n_GALLERYEXP != table.n_GALLERYEXP)
		{
			return false;
		}
		if (n_TOTAL_GALLERYEXP != table.n_TOTAL_GALLERYEXP)
		{
			return false;
		}
		if (n_GALLERY_ATK != table.n_GALLERY_ATK)
		{
			return false;
		}
		if (n_GALLERY_HP != table.n_GALLERY_HP)
		{
			return false;
		}
		if (n_GALLERY_DEF != table.n_GALLERY_DEF)
		{
			return false;
		}
		if (n_CARDGALLERY_ATK != table.n_CARDGALLERY_ATK)
		{
			return false;
		}
		if (n_CARDGALLERY_HP != table.n_CARDGALLERY_HP)
		{
			return false;
		}
		if (n_CARDGALLERY_DEF != table.n_CARDGALLERY_DEF)
		{
			return false;
		}
		if (n_WEAPONEXP != table.n_WEAPONEXP)
		{
			return false;
		}
		if (n_TOTAL_WEAPONEXP != table.n_TOTAL_WEAPONEXP)
		{
			return false;
		}
		if (n_WEAPON_ATK != table.n_WEAPON_ATK)
		{
			return false;
		}
		if (n_WEAPON_HP != table.n_WEAPON_HP)
		{
			return false;
		}
		if (n_WEAPON_CRI != table.n_WEAPON_CRI)
		{
			return false;
		}
		if (n_WEAPON_HIT != table.n_WEAPON_HIT)
		{
			return false;
		}
		if (n_DISCEXP != table.n_DISCEXP)
		{
			return false;
		}
		if (n_TOTAL_DISCEXP != table.n_TOTAL_DISCEXP)
		{
			return false;
		}
		if (n_DISC_ATK != table.n_DISC_ATK)
		{
			return false;
		}
		if (n_DISC_HP != table.n_DISC_HP)
		{
			return false;
		}
		if (n_DISC_DEF != table.n_DISC_DEF)
		{
			return false;
		}
		if (n_CARDEXP != table.n_CARDEXP)
		{
			return false;
		}
		if (n_TOTAL_CARDEXP != table.n_TOTAL_CARDEXP)
		{
			return false;
		}
		if (n_CARD_ATK != table.n_CARD_ATK)
		{
			return false;
		}
		if (n_CARD_HP != table.n_CARD_HP)
		{
			return false;
		}
		if (n_CARD_DEF != table.n_CARD_DEF)
		{
			return false;
		}
		if (n_EQUIPUP_DEF != table.n_EQUIPUP_DEF)
		{
			return false;
		}
		if (n_EQUIPUP_HP != table.n_EQUIPUP_HP)
		{
			return false;
		}
		if (n_EQUIPUP_MATERIAL != table.n_EQUIPUP_MATERIAL)
		{
			return false;
		}
		if (n_EQUIPUP_MONEY != table.n_EQUIPUP_MONEY)
		{
			return false;
		}
		if (n_PET_ATK != table.n_PET_ATK)
		{
			return false;
		}
		if (n_PET_HP != table.n_PET_HP)
		{
			return false;
		}
		if (n_PET_DEF != table.n_PET_DEF)
		{
			return false;
		}
		if (n_PET_MATERIAL != table.n_PET_MATERIAL)
		{
			return false;
		}
		if (n_PET_MONEY != table.n_PET_MONEY)
		{
			return false;
		}
		if (n_RESEARCHEXP != table.n_RESEARCHEXP)
		{
			return false;
		}
		if (n_TOTAL_RESEARCHEXP != table.n_TOTAL_RESEARCHEXP)
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
		binaryWriter.Write(n_RANKEXP);
		binaryWriter.Write(n_TOTAL_RANKEXP);
		binaryWriter.Write(n_RANK_ATK);
		binaryWriter.Write(n_RANK_HP);
		binaryWriter.Write(n_RANK_DEF);
		binaryWriter.Write(n_RANK_DOD);
		binaryWriter.Write(n_STAMINA);
		binaryWriter.Write(n_SKILL1_LV);
		binaryWriter.Write(n_SKILL2_LV);
		binaryWriter.Write(n_SKILLUP_MONEY);
		binaryWriter.Write(n_SKILLUP_SP);
		binaryWriter.Write(n_GALLERYEXP);
		binaryWriter.Write(n_TOTAL_GALLERYEXP);
		binaryWriter.Write(n_GALLERY_ATK);
		binaryWriter.Write(n_GALLERY_HP);
		binaryWriter.Write(n_GALLERY_DEF);
		binaryWriter.Write(n_CARDGALLERY_ATK);
		binaryWriter.Write(n_CARDGALLERY_HP);
		binaryWriter.Write(n_CARDGALLERY_DEF);
		binaryWriter.Write(n_WEAPONEXP);
		binaryWriter.Write(n_TOTAL_WEAPONEXP);
		binaryWriter.Write(n_WEAPON_ATK);
		binaryWriter.Write(n_WEAPON_HP);
		binaryWriter.Write(n_WEAPON_CRI);
		binaryWriter.Write(n_WEAPON_HIT);
		binaryWriter.Write(n_DISCEXP);
		binaryWriter.Write(n_TOTAL_DISCEXP);
		binaryWriter.Write(n_DISC_ATK);
		binaryWriter.Write(n_DISC_HP);
		binaryWriter.Write(n_DISC_DEF);
		binaryWriter.Write(n_CARDEXP);
		binaryWriter.Write(n_TOTAL_CARDEXP);
		binaryWriter.Write(n_CARD_ATK);
		binaryWriter.Write(n_CARD_HP);
		binaryWriter.Write(n_CARD_DEF);
		binaryWriter.Write(n_EQUIPUP_DEF);
		binaryWriter.Write(n_EQUIPUP_HP);
		binaryWriter.Write(n_EQUIPUP_MATERIAL);
		binaryWriter.Write(n_EQUIPUP_MONEY);
		binaryWriter.Write(n_PET_ATK);
		binaryWriter.Write(n_PET_HP);
		binaryWriter.Write(n_PET_DEF);
		binaryWriter.Write(n_PET_MATERIAL);
		binaryWriter.Write(n_PET_MONEY);
		binaryWriter.Write(n_RESEARCHEXP);
		binaryWriter.Write(n_TOTAL_RESEARCHEXP);
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
		n_RANKEXP = binaryReader.ReadInt32();
		n_TOTAL_RANKEXP = binaryReader.ReadInt32();
		n_RANK_ATK = binaryReader.ReadInt32();
		n_RANK_HP = binaryReader.ReadInt32();
		n_RANK_DEF = binaryReader.ReadInt32();
		n_RANK_DOD = binaryReader.ReadInt32();
		n_STAMINA = binaryReader.ReadInt32();
		n_SKILL1_LV = binaryReader.ReadInt32();
		n_SKILL2_LV = binaryReader.ReadInt32();
		n_SKILLUP_MONEY = binaryReader.ReadInt32();
		n_SKILLUP_SP = binaryReader.ReadInt32();
		n_GALLERYEXP = binaryReader.ReadInt32();
		n_TOTAL_GALLERYEXP = binaryReader.ReadInt32();
		n_GALLERY_ATK = binaryReader.ReadInt32();
		n_GALLERY_HP = binaryReader.ReadInt32();
		n_GALLERY_DEF = binaryReader.ReadInt32();
		n_CARDGALLERY_ATK = binaryReader.ReadInt32();
		n_CARDGALLERY_HP = binaryReader.ReadInt32();
		n_CARDGALLERY_DEF = binaryReader.ReadInt32();
		n_WEAPONEXP = binaryReader.ReadInt32();
		n_TOTAL_WEAPONEXP = binaryReader.ReadInt32();
		n_WEAPON_ATK = binaryReader.ReadInt32();
		n_WEAPON_HP = binaryReader.ReadInt32();
		n_WEAPON_CRI = binaryReader.ReadInt32();
		n_WEAPON_HIT = binaryReader.ReadInt32();
		n_DISCEXP = binaryReader.ReadInt32();
		n_TOTAL_DISCEXP = binaryReader.ReadInt32();
		n_DISC_ATK = binaryReader.ReadInt32();
		n_DISC_HP = binaryReader.ReadInt32();
		n_DISC_DEF = binaryReader.ReadInt32();
		n_CARDEXP = binaryReader.ReadInt32();
		n_TOTAL_CARDEXP = binaryReader.ReadInt32();
		n_CARD_ATK = binaryReader.ReadInt32();
		n_CARD_HP = binaryReader.ReadInt32();
		n_CARD_DEF = binaryReader.ReadInt32();
		n_EQUIPUP_DEF = binaryReader.ReadInt32();
		n_EQUIPUP_HP = binaryReader.ReadInt32();
		n_EQUIPUP_MATERIAL = binaryReader.ReadInt32();
		n_EQUIPUP_MONEY = binaryReader.ReadInt32();
		n_PET_ATK = binaryReader.ReadInt32();
		n_PET_HP = binaryReader.ReadInt32();
		n_PET_DEF = binaryReader.ReadInt32();
		n_PET_MATERIAL = binaryReader.ReadInt32();
		n_PET_MONEY = binaryReader.ReadInt32();
		n_RESEARCHEXP = binaryReader.ReadInt32();
		n_TOTAL_RESEARCHEXP = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
