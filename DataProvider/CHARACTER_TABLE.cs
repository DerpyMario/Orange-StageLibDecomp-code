using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class CHARACTER_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		s_NAME,
		s_ICON,
		s_MODEL,
		s_ANIMATOR,
		s_CHARA_PIVOT,
		s_ModelExtraSize,
		f_MODELSIZE,
		s_VOICE,
		s_SE_CHARA,
		s_SE_SKILL,
		n_RARITY,
		n_ABILITY,
		n_LOADING,
		n_TREND,
		n_HEAD,
		n_INIT_WEAPON1,
		n_INIT_WEAPON2,
		n_WEAPON_IN,
		n_WEAPON_OUT,
		n_SPECIAL_SHOWPOSE,
		n_WEAPON_MOTION,
		n_ENABLE_FLAG,
		n_FATIGUE,
		n_UNLOCK_ID,
		n_UNLOCK_COUNT,
		n_SKILL1,
		n_SKILL1_EX1,
		n_SKILL1_UNLOCK1,
		n_SKILL1_EX2,
		n_SKILL1_UNLOCK2,
		n_SKILL1_EX3,
		n_SKILL1_UNLOCK3,
		n_SKILL2,
		n_SKILL2_EX1,
		n_SKILL2_UNLOCK1,
		n_SKILL2_EX2,
		n_SKILL2_UNLOCK2,
		n_SKILL2_EX3,
		n_SKILL2_UNLOCK3,
		n_PASSIVE_1,
		n_PASSIVE_UNLOCK1,
		n_PASSIVE_MATERIAL1,
		n_PASSIVE_2,
		n_PASSIVE_UNLOCK2,
		n_PASSIVE_MATERIAL2,
		n_PASSIVE_3,
		n_PASSIVE_UNLOCK3,
		n_PASSIVE_MATERIAL3,
		n_PASSIVE_4,
		n_PASSIVE_UNLOCK4,
		n_PASSIVE_MATERIAL4,
		n_PASSIVE_5,
		n_PASSIVE_UNLOCK5,
		n_PASSIVE_MATERIAL5,
		n_PASSIVE_6,
		n_PASSIVE_UNLOCK6,
		n_PASSIVE_MATERIAL6,
		n_INITIAL_SKILL1,
		n_INITIAL_SKILL2,
		n_INITIAL_SKILL3,
		n_RECORD_BATTLE,
		n_RECORD_EXPLORE,
		n_RECORD_ACTION,
		s_START_VERSION,
		s_END_VERSION,
		w_NAME,
		w_TYPETIP,
		w_TIP
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public string s_MODEL { get; set; }

	[Preserve]
	public string s_ANIMATOR { get; set; }

	[Preserve]
	public string s_CHARA_PIVOT { get; set; }

	[Preserve]
	public string s_ModelExtraSize { get; set; }

	[Preserve]
	public float f_MODELSIZE { get; set; }

	[Preserve]
	public string s_VOICE { get; set; }

	[Preserve]
	public string s_SE_CHARA { get; set; }

	[Preserve]
	public string s_SE_SKILL { get; set; }

	[Preserve]
	public int n_RARITY { get; set; }

	[Preserve]
	public int n_ABILITY { get; set; }

	[Preserve]
	public int n_LOADING { get; set; }

	[Preserve]
	public int n_TREND { get; set; }

	[Preserve]
	public int n_HEAD { get; set; }

	[Preserve]
	public int n_INIT_WEAPON1 { get; set; }

	[Preserve]
	public int n_INIT_WEAPON2 { get; set; }

	[Preserve]
	public int n_WEAPON_IN { get; set; }

	[Preserve]
	public int n_WEAPON_OUT { get; set; }

	[Preserve]
	public int n_SPECIAL_SHOWPOSE { get; set; }

	[Preserve]
	public int n_WEAPON_MOTION { get; set; }

	[Preserve]
	public int n_ENABLE_FLAG { get; set; }

	[Preserve]
	public int n_FATIGUE { get; set; }

	[Preserve]
	public int n_UNLOCK_ID { get; set; }

	[Preserve]
	public int n_UNLOCK_COUNT { get; set; }

	[Preserve]
	public int n_SKILL1 { get; set; }

	[Preserve]
	public int n_SKILL1_EX1 { get; set; }

	[Preserve]
	public int n_SKILL1_UNLOCK1 { get; set; }

	[Preserve]
	public int n_SKILL1_EX2 { get; set; }

	[Preserve]
	public int n_SKILL1_UNLOCK2 { get; set; }

	[Preserve]
	public int n_SKILL1_EX3 { get; set; }

	[Preserve]
	public int n_SKILL1_UNLOCK3 { get; set; }

	[Preserve]
	public int n_SKILL2 { get; set; }

	[Preserve]
	public int n_SKILL2_EX1 { get; set; }

	[Preserve]
	public int n_SKILL2_UNLOCK1 { get; set; }

	[Preserve]
	public int n_SKILL2_EX2 { get; set; }

	[Preserve]
	public int n_SKILL2_UNLOCK2 { get; set; }

	[Preserve]
	public int n_SKILL2_EX3 { get; set; }

	[Preserve]
	public int n_SKILL2_UNLOCK3 { get; set; }

	[Preserve]
	public int n_PASSIVE_1 { get; set; }

	[Preserve]
	public int n_PASSIVE_UNLOCK1 { get; set; }

	[Preserve]
	public int n_PASSIVE_MATERIAL1 { get; set; }

	[Preserve]
	public int n_PASSIVE_2 { get; set; }

	[Preserve]
	public int n_PASSIVE_UNLOCK2 { get; set; }

	[Preserve]
	public int n_PASSIVE_MATERIAL2 { get; set; }

	[Preserve]
	public int n_PASSIVE_3 { get; set; }

	[Preserve]
	public int n_PASSIVE_UNLOCK3 { get; set; }

	[Preserve]
	public int n_PASSIVE_MATERIAL3 { get; set; }

	[Preserve]
	public int n_PASSIVE_4 { get; set; }

	[Preserve]
	public int n_PASSIVE_UNLOCK4 { get; set; }

	[Preserve]
	public int n_PASSIVE_MATERIAL4 { get; set; }

	[Preserve]
	public int n_PASSIVE_5 { get; set; }

	[Preserve]
	public int n_PASSIVE_UNLOCK5 { get; set; }

	[Preserve]
	public int n_PASSIVE_MATERIAL5 { get; set; }

	[Preserve]
	public int n_PASSIVE_6 { get; set; }

	[Preserve]
	public int n_PASSIVE_UNLOCK6 { get; set; }

	[Preserve]
	public int n_PASSIVE_MATERIAL6 { get; set; }

	[Preserve]
	public int n_INITIAL_SKILL1 { get; set; }

	[Preserve]
	public int n_INITIAL_SKILL2 { get; set; }

	[Preserve]
	public int n_INITIAL_SKILL3 { get; set; }

	[Preserve]
	public int n_RECORD_BATTLE { get; set; }

	[Preserve]
	public int n_RECORD_EXPLORE { get; set; }

	[Preserve]
	public int n_RECORD_ACTION { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string w_TYPETIP { get; set; }

	[Preserve]
	public string w_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(CHARACTER_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (s_NAME != tbl.s_NAME)
		{
			dictionary.Add(1, s_NAME);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(2, s_ICON);
		}
		if (s_MODEL != tbl.s_MODEL)
		{
			dictionary.Add(3, s_MODEL);
		}
		if (s_ANIMATOR != tbl.s_ANIMATOR)
		{
			dictionary.Add(4, s_ANIMATOR);
		}
		if (s_CHARA_PIVOT != tbl.s_CHARA_PIVOT)
		{
			dictionary.Add(5, s_CHARA_PIVOT);
		}
		if (s_ModelExtraSize != tbl.s_ModelExtraSize)
		{
			dictionary.Add(6, s_ModelExtraSize);
		}
		if (f_MODELSIZE != tbl.f_MODELSIZE)
		{
			dictionary.Add(7, f_MODELSIZE);
		}
		if (s_VOICE != tbl.s_VOICE)
		{
			dictionary.Add(8, s_VOICE);
		}
		if (s_SE_CHARA != tbl.s_SE_CHARA)
		{
			dictionary.Add(9, s_SE_CHARA);
		}
		if (s_SE_SKILL != tbl.s_SE_SKILL)
		{
			dictionary.Add(10, s_SE_SKILL);
		}
		if (n_RARITY != tbl.n_RARITY)
		{
			dictionary.Add(11, n_RARITY);
		}
		if (n_ABILITY != tbl.n_ABILITY)
		{
			dictionary.Add(12, n_ABILITY);
		}
		if (n_LOADING != tbl.n_LOADING)
		{
			dictionary.Add(13, n_LOADING);
		}
		if (n_TREND != tbl.n_TREND)
		{
			dictionary.Add(14, n_TREND);
		}
		if (n_HEAD != tbl.n_HEAD)
		{
			dictionary.Add(15, n_HEAD);
		}
		if (n_INIT_WEAPON1 != tbl.n_INIT_WEAPON1)
		{
			dictionary.Add(16, n_INIT_WEAPON1);
		}
		if (n_INIT_WEAPON2 != tbl.n_INIT_WEAPON2)
		{
			dictionary.Add(17, n_INIT_WEAPON2);
		}
		if (n_WEAPON_IN != tbl.n_WEAPON_IN)
		{
			dictionary.Add(18, n_WEAPON_IN);
		}
		if (n_WEAPON_OUT != tbl.n_WEAPON_OUT)
		{
			dictionary.Add(19, n_WEAPON_OUT);
		}
		if (n_SPECIAL_SHOWPOSE != tbl.n_SPECIAL_SHOWPOSE)
		{
			dictionary.Add(20, n_SPECIAL_SHOWPOSE);
		}
		if (n_WEAPON_MOTION != tbl.n_WEAPON_MOTION)
		{
			dictionary.Add(21, n_WEAPON_MOTION);
		}
		if (n_ENABLE_FLAG != tbl.n_ENABLE_FLAG)
		{
			dictionary.Add(22, n_ENABLE_FLAG);
		}
		if (n_FATIGUE != tbl.n_FATIGUE)
		{
			dictionary.Add(23, n_FATIGUE);
		}
		if (n_UNLOCK_ID != tbl.n_UNLOCK_ID)
		{
			dictionary.Add(24, n_UNLOCK_ID);
		}
		if (n_UNLOCK_COUNT != tbl.n_UNLOCK_COUNT)
		{
			dictionary.Add(25, n_UNLOCK_COUNT);
		}
		if (n_SKILL1 != tbl.n_SKILL1)
		{
			dictionary.Add(26, n_SKILL1);
		}
		if (n_SKILL1_EX1 != tbl.n_SKILL1_EX1)
		{
			dictionary.Add(27, n_SKILL1_EX1);
		}
		if (n_SKILL1_UNLOCK1 != tbl.n_SKILL1_UNLOCK1)
		{
			dictionary.Add(28, n_SKILL1_UNLOCK1);
		}
		if (n_SKILL1_EX2 != tbl.n_SKILL1_EX2)
		{
			dictionary.Add(29, n_SKILL1_EX2);
		}
		if (n_SKILL1_UNLOCK2 != tbl.n_SKILL1_UNLOCK2)
		{
			dictionary.Add(30, n_SKILL1_UNLOCK2);
		}
		if (n_SKILL1_EX3 != tbl.n_SKILL1_EX3)
		{
			dictionary.Add(31, n_SKILL1_EX3);
		}
		if (n_SKILL1_UNLOCK3 != tbl.n_SKILL1_UNLOCK3)
		{
			dictionary.Add(32, n_SKILL1_UNLOCK3);
		}
		if (n_SKILL2 != tbl.n_SKILL2)
		{
			dictionary.Add(33, n_SKILL2);
		}
		if (n_SKILL2_EX1 != tbl.n_SKILL2_EX1)
		{
			dictionary.Add(34, n_SKILL2_EX1);
		}
		if (n_SKILL2_UNLOCK1 != tbl.n_SKILL2_UNLOCK1)
		{
			dictionary.Add(35, n_SKILL2_UNLOCK1);
		}
		if (n_SKILL2_EX2 != tbl.n_SKILL2_EX2)
		{
			dictionary.Add(36, n_SKILL2_EX2);
		}
		if (n_SKILL2_UNLOCK2 != tbl.n_SKILL2_UNLOCK2)
		{
			dictionary.Add(37, n_SKILL2_UNLOCK2);
		}
		if (n_SKILL2_EX3 != tbl.n_SKILL2_EX3)
		{
			dictionary.Add(38, n_SKILL2_EX3);
		}
		if (n_SKILL2_UNLOCK3 != tbl.n_SKILL2_UNLOCK3)
		{
			dictionary.Add(39, n_SKILL2_UNLOCK3);
		}
		if (n_PASSIVE_1 != tbl.n_PASSIVE_1)
		{
			dictionary.Add(40, n_PASSIVE_1);
		}
		if (n_PASSIVE_UNLOCK1 != tbl.n_PASSIVE_UNLOCK1)
		{
			dictionary.Add(41, n_PASSIVE_UNLOCK1);
		}
		if (n_PASSIVE_MATERIAL1 != tbl.n_PASSIVE_MATERIAL1)
		{
			dictionary.Add(42, n_PASSIVE_MATERIAL1);
		}
		if (n_PASSIVE_2 != tbl.n_PASSIVE_2)
		{
			dictionary.Add(43, n_PASSIVE_2);
		}
		if (n_PASSIVE_UNLOCK2 != tbl.n_PASSIVE_UNLOCK2)
		{
			dictionary.Add(44, n_PASSIVE_UNLOCK2);
		}
		if (n_PASSIVE_MATERIAL2 != tbl.n_PASSIVE_MATERIAL2)
		{
			dictionary.Add(45, n_PASSIVE_MATERIAL2);
		}
		if (n_PASSIVE_3 != tbl.n_PASSIVE_3)
		{
			dictionary.Add(46, n_PASSIVE_3);
		}
		if (n_PASSIVE_UNLOCK3 != tbl.n_PASSIVE_UNLOCK3)
		{
			dictionary.Add(47, n_PASSIVE_UNLOCK3);
		}
		if (n_PASSIVE_MATERIAL3 != tbl.n_PASSIVE_MATERIAL3)
		{
			dictionary.Add(48, n_PASSIVE_MATERIAL3);
		}
		if (n_PASSIVE_4 != tbl.n_PASSIVE_4)
		{
			dictionary.Add(49, n_PASSIVE_4);
		}
		if (n_PASSIVE_UNLOCK4 != tbl.n_PASSIVE_UNLOCK4)
		{
			dictionary.Add(50, n_PASSIVE_UNLOCK4);
		}
		if (n_PASSIVE_MATERIAL4 != tbl.n_PASSIVE_MATERIAL4)
		{
			dictionary.Add(51, n_PASSIVE_MATERIAL4);
		}
		if (n_PASSIVE_5 != tbl.n_PASSIVE_5)
		{
			dictionary.Add(52, n_PASSIVE_5);
		}
		if (n_PASSIVE_UNLOCK5 != tbl.n_PASSIVE_UNLOCK5)
		{
			dictionary.Add(53, n_PASSIVE_UNLOCK5);
		}
		if (n_PASSIVE_MATERIAL5 != tbl.n_PASSIVE_MATERIAL5)
		{
			dictionary.Add(54, n_PASSIVE_MATERIAL5);
		}
		if (n_PASSIVE_6 != tbl.n_PASSIVE_6)
		{
			dictionary.Add(55, n_PASSIVE_6);
		}
		if (n_PASSIVE_UNLOCK6 != tbl.n_PASSIVE_UNLOCK6)
		{
			dictionary.Add(56, n_PASSIVE_UNLOCK6);
		}
		if (n_PASSIVE_MATERIAL6 != tbl.n_PASSIVE_MATERIAL6)
		{
			dictionary.Add(57, n_PASSIVE_MATERIAL6);
		}
		if (n_INITIAL_SKILL1 != tbl.n_INITIAL_SKILL1)
		{
			dictionary.Add(58, n_INITIAL_SKILL1);
		}
		if (n_INITIAL_SKILL2 != tbl.n_INITIAL_SKILL2)
		{
			dictionary.Add(59, n_INITIAL_SKILL2);
		}
		if (n_INITIAL_SKILL3 != tbl.n_INITIAL_SKILL3)
		{
			dictionary.Add(60, n_INITIAL_SKILL3);
		}
		if (n_RECORD_BATTLE != tbl.n_RECORD_BATTLE)
		{
			dictionary.Add(61, n_RECORD_BATTLE);
		}
		if (n_RECORD_EXPLORE != tbl.n_RECORD_EXPLORE)
		{
			dictionary.Add(62, n_RECORD_EXPLORE);
		}
		if (n_RECORD_ACTION != tbl.n_RECORD_ACTION)
		{
			dictionary.Add(63, n_RECORD_ACTION);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(64, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(65, s_END_VERSION);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(66, w_NAME);
		}
		if (w_TYPETIP != tbl.w_TYPETIP)
		{
			dictionary.Add(67, w_TYPETIP);
		}
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(68, w_TIP);
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
				s_NAME = item.Value.ToString();
				break;
			case 2:
				s_ICON = item.Value.ToString();
				break;
			case 3:
				s_MODEL = item.Value.ToString();
				break;
			case 4:
				s_ANIMATOR = item.Value.ToString();
				break;
			case 5:
				s_CHARA_PIVOT = item.Value.ToString();
				break;
			case 6:
				s_ModelExtraSize = item.Value.ToString();
				break;
			case 7:
				f_MODELSIZE = Convert.ToSingle(item.Value);
				break;
			case 8:
				s_VOICE = item.Value.ToString();
				break;
			case 9:
				s_SE_CHARA = item.Value.ToString();
				break;
			case 10:
				s_SE_SKILL = item.Value.ToString();
				break;
			case 11:
				n_RARITY = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_ABILITY = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_LOADING = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_TREND = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_HEAD = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_INIT_WEAPON1 = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_INIT_WEAPON2 = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_WEAPON_IN = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_WEAPON_OUT = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_SPECIAL_SHOWPOSE = Convert.ToInt32(item.Value);
				break;
			case 21:
				n_WEAPON_MOTION = Convert.ToInt32(item.Value);
				break;
			case 22:
				n_ENABLE_FLAG = Convert.ToInt32(item.Value);
				break;
			case 23:
				n_FATIGUE = Convert.ToInt32(item.Value);
				break;
			case 24:
				n_UNLOCK_ID = Convert.ToInt32(item.Value);
				break;
			case 25:
				n_UNLOCK_COUNT = Convert.ToInt32(item.Value);
				break;
			case 26:
				n_SKILL1 = Convert.ToInt32(item.Value);
				break;
			case 27:
				n_SKILL1_EX1 = Convert.ToInt32(item.Value);
				break;
			case 28:
				n_SKILL1_UNLOCK1 = Convert.ToInt32(item.Value);
				break;
			case 29:
				n_SKILL1_EX2 = Convert.ToInt32(item.Value);
				break;
			case 30:
				n_SKILL1_UNLOCK2 = Convert.ToInt32(item.Value);
				break;
			case 31:
				n_SKILL1_EX3 = Convert.ToInt32(item.Value);
				break;
			case 32:
				n_SKILL1_UNLOCK3 = Convert.ToInt32(item.Value);
				break;
			case 33:
				n_SKILL2 = Convert.ToInt32(item.Value);
				break;
			case 34:
				n_SKILL2_EX1 = Convert.ToInt32(item.Value);
				break;
			case 35:
				n_SKILL2_UNLOCK1 = Convert.ToInt32(item.Value);
				break;
			case 36:
				n_SKILL2_EX2 = Convert.ToInt32(item.Value);
				break;
			case 37:
				n_SKILL2_UNLOCK2 = Convert.ToInt32(item.Value);
				break;
			case 38:
				n_SKILL2_EX3 = Convert.ToInt32(item.Value);
				break;
			case 39:
				n_SKILL2_UNLOCK3 = Convert.ToInt32(item.Value);
				break;
			case 40:
				n_PASSIVE_1 = Convert.ToInt32(item.Value);
				break;
			case 41:
				n_PASSIVE_UNLOCK1 = Convert.ToInt32(item.Value);
				break;
			case 42:
				n_PASSIVE_MATERIAL1 = Convert.ToInt32(item.Value);
				break;
			case 43:
				n_PASSIVE_2 = Convert.ToInt32(item.Value);
				break;
			case 44:
				n_PASSIVE_UNLOCK2 = Convert.ToInt32(item.Value);
				break;
			case 45:
				n_PASSIVE_MATERIAL2 = Convert.ToInt32(item.Value);
				break;
			case 46:
				n_PASSIVE_3 = Convert.ToInt32(item.Value);
				break;
			case 47:
				n_PASSIVE_UNLOCK3 = Convert.ToInt32(item.Value);
				break;
			case 48:
				n_PASSIVE_MATERIAL3 = Convert.ToInt32(item.Value);
				break;
			case 49:
				n_PASSIVE_4 = Convert.ToInt32(item.Value);
				break;
			case 50:
				n_PASSIVE_UNLOCK4 = Convert.ToInt32(item.Value);
				break;
			case 51:
				n_PASSIVE_MATERIAL4 = Convert.ToInt32(item.Value);
				break;
			case 52:
				n_PASSIVE_5 = Convert.ToInt32(item.Value);
				break;
			case 53:
				n_PASSIVE_UNLOCK5 = Convert.ToInt32(item.Value);
				break;
			case 54:
				n_PASSIVE_MATERIAL5 = Convert.ToInt32(item.Value);
				break;
			case 55:
				n_PASSIVE_6 = Convert.ToInt32(item.Value);
				break;
			case 56:
				n_PASSIVE_UNLOCK6 = Convert.ToInt32(item.Value);
				break;
			case 57:
				n_PASSIVE_MATERIAL6 = Convert.ToInt32(item.Value);
				break;
			case 58:
				n_INITIAL_SKILL1 = Convert.ToInt32(item.Value);
				break;
			case 59:
				n_INITIAL_SKILL2 = Convert.ToInt32(item.Value);
				break;
			case 60:
				n_INITIAL_SKILL3 = Convert.ToInt32(item.Value);
				break;
			case 61:
				n_RECORD_BATTLE = Convert.ToInt32(item.Value);
				break;
			case 62:
				n_RECORD_EXPLORE = Convert.ToInt32(item.Value);
				break;
			case 63:
				n_RECORD_ACTION = Convert.ToInt32(item.Value);
				break;
			case 64:
				s_START_VERSION = item.Value.ToString();
				break;
			case 65:
				s_END_VERSION = item.Value.ToString();
				break;
			case 66:
				w_NAME = item.Value.ToString();
				break;
			case 67:
				w_TYPETIP = item.Value.ToString();
				break;
			case 68:
				w_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(CHARACTER_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (s_NAME != table.s_NAME)
		{
			return false;
		}
		if (s_ICON != table.s_ICON)
		{
			return false;
		}
		if (s_MODEL != table.s_MODEL)
		{
			return false;
		}
		if (s_ANIMATOR != table.s_ANIMATOR)
		{
			return false;
		}
		if (s_CHARA_PIVOT != table.s_CHARA_PIVOT)
		{
			return false;
		}
		if (s_ModelExtraSize != table.s_ModelExtraSize)
		{
			return false;
		}
		if (f_MODELSIZE != table.f_MODELSIZE)
		{
			return false;
		}
		if (s_VOICE != table.s_VOICE)
		{
			return false;
		}
		if (s_SE_CHARA != table.s_SE_CHARA)
		{
			return false;
		}
		if (s_SE_SKILL != table.s_SE_SKILL)
		{
			return false;
		}
		if (n_RARITY != table.n_RARITY)
		{
			return false;
		}
		if (n_ABILITY != table.n_ABILITY)
		{
			return false;
		}
		if (n_LOADING != table.n_LOADING)
		{
			return false;
		}
		if (n_TREND != table.n_TREND)
		{
			return false;
		}
		if (n_HEAD != table.n_HEAD)
		{
			return false;
		}
		if (n_INIT_WEAPON1 != table.n_INIT_WEAPON1)
		{
			return false;
		}
		if (n_INIT_WEAPON2 != table.n_INIT_WEAPON2)
		{
			return false;
		}
		if (n_WEAPON_IN != table.n_WEAPON_IN)
		{
			return false;
		}
		if (n_WEAPON_OUT != table.n_WEAPON_OUT)
		{
			return false;
		}
		if (n_SPECIAL_SHOWPOSE != table.n_SPECIAL_SHOWPOSE)
		{
			return false;
		}
		if (n_WEAPON_MOTION != table.n_WEAPON_MOTION)
		{
			return false;
		}
		if (n_ENABLE_FLAG != table.n_ENABLE_FLAG)
		{
			return false;
		}
		if (n_FATIGUE != table.n_FATIGUE)
		{
			return false;
		}
		if (n_UNLOCK_ID != table.n_UNLOCK_ID)
		{
			return false;
		}
		if (n_UNLOCK_COUNT != table.n_UNLOCK_COUNT)
		{
			return false;
		}
		if (n_SKILL1 != table.n_SKILL1)
		{
			return false;
		}
		if (n_SKILL1_EX1 != table.n_SKILL1_EX1)
		{
			return false;
		}
		if (n_SKILL1_UNLOCK1 != table.n_SKILL1_UNLOCK1)
		{
			return false;
		}
		if (n_SKILL1_EX2 != table.n_SKILL1_EX2)
		{
			return false;
		}
		if (n_SKILL1_UNLOCK2 != table.n_SKILL1_UNLOCK2)
		{
			return false;
		}
		if (n_SKILL1_EX3 != table.n_SKILL1_EX3)
		{
			return false;
		}
		if (n_SKILL1_UNLOCK3 != table.n_SKILL1_UNLOCK3)
		{
			return false;
		}
		if (n_SKILL2 != table.n_SKILL2)
		{
			return false;
		}
		if (n_SKILL2_EX1 != table.n_SKILL2_EX1)
		{
			return false;
		}
		if (n_SKILL2_UNLOCK1 != table.n_SKILL2_UNLOCK1)
		{
			return false;
		}
		if (n_SKILL2_EX2 != table.n_SKILL2_EX2)
		{
			return false;
		}
		if (n_SKILL2_UNLOCK2 != table.n_SKILL2_UNLOCK2)
		{
			return false;
		}
		if (n_SKILL2_EX3 != table.n_SKILL2_EX3)
		{
			return false;
		}
		if (n_SKILL2_UNLOCK3 != table.n_SKILL2_UNLOCK3)
		{
			return false;
		}
		if (n_PASSIVE_1 != table.n_PASSIVE_1)
		{
			return false;
		}
		if (n_PASSIVE_UNLOCK1 != table.n_PASSIVE_UNLOCK1)
		{
			return false;
		}
		if (n_PASSIVE_MATERIAL1 != table.n_PASSIVE_MATERIAL1)
		{
			return false;
		}
		if (n_PASSIVE_2 != table.n_PASSIVE_2)
		{
			return false;
		}
		if (n_PASSIVE_UNLOCK2 != table.n_PASSIVE_UNLOCK2)
		{
			return false;
		}
		if (n_PASSIVE_MATERIAL2 != table.n_PASSIVE_MATERIAL2)
		{
			return false;
		}
		if (n_PASSIVE_3 != table.n_PASSIVE_3)
		{
			return false;
		}
		if (n_PASSIVE_UNLOCK3 != table.n_PASSIVE_UNLOCK3)
		{
			return false;
		}
		if (n_PASSIVE_MATERIAL3 != table.n_PASSIVE_MATERIAL3)
		{
			return false;
		}
		if (n_PASSIVE_4 != table.n_PASSIVE_4)
		{
			return false;
		}
		if (n_PASSIVE_UNLOCK4 != table.n_PASSIVE_UNLOCK4)
		{
			return false;
		}
		if (n_PASSIVE_MATERIAL4 != table.n_PASSIVE_MATERIAL4)
		{
			return false;
		}
		if (n_PASSIVE_5 != table.n_PASSIVE_5)
		{
			return false;
		}
		if (n_PASSIVE_UNLOCK5 != table.n_PASSIVE_UNLOCK5)
		{
			return false;
		}
		if (n_PASSIVE_MATERIAL5 != table.n_PASSIVE_MATERIAL5)
		{
			return false;
		}
		if (n_PASSIVE_6 != table.n_PASSIVE_6)
		{
			return false;
		}
		if (n_PASSIVE_UNLOCK6 != table.n_PASSIVE_UNLOCK6)
		{
			return false;
		}
		if (n_PASSIVE_MATERIAL6 != table.n_PASSIVE_MATERIAL6)
		{
			return false;
		}
		if (n_INITIAL_SKILL1 != table.n_INITIAL_SKILL1)
		{
			return false;
		}
		if (n_INITIAL_SKILL2 != table.n_INITIAL_SKILL2)
		{
			return false;
		}
		if (n_INITIAL_SKILL3 != table.n_INITIAL_SKILL3)
		{
			return false;
		}
		if (n_RECORD_BATTLE != table.n_RECORD_BATTLE)
		{
			return false;
		}
		if (n_RECORD_EXPLORE != table.n_RECORD_EXPLORE)
		{
			return false;
		}
		if (n_RECORD_ACTION != table.n_RECORD_ACTION)
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
		if (w_TYPETIP != table.w_TYPETIP)
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
		binaryWriter.WriteExString(s_NAME);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.WriteExString(s_MODEL);
		binaryWriter.WriteExString(s_ANIMATOR);
		binaryWriter.WriteExString(s_CHARA_PIVOT);
		binaryWriter.WriteExString(s_ModelExtraSize);
		binaryWriter.Write(f_MODELSIZE);
		binaryWriter.WriteExString(s_VOICE);
		binaryWriter.WriteExString(s_SE_CHARA);
		binaryWriter.WriteExString(s_SE_SKILL);
		binaryWriter.Write(n_RARITY);
		binaryWriter.Write(n_ABILITY);
		binaryWriter.Write(n_LOADING);
		binaryWriter.Write(n_TREND);
		binaryWriter.Write(n_HEAD);
		binaryWriter.Write(n_INIT_WEAPON1);
		binaryWriter.Write(n_INIT_WEAPON2);
		binaryWriter.Write(n_WEAPON_IN);
		binaryWriter.Write(n_WEAPON_OUT);
		binaryWriter.Write(n_SPECIAL_SHOWPOSE);
		binaryWriter.Write(n_WEAPON_MOTION);
		binaryWriter.Write(n_ENABLE_FLAG);
		binaryWriter.Write(n_FATIGUE);
		binaryWriter.Write(n_UNLOCK_ID);
		binaryWriter.Write(n_UNLOCK_COUNT);
		binaryWriter.Write(n_SKILL1);
		binaryWriter.Write(n_SKILL1_EX1);
		binaryWriter.Write(n_SKILL1_UNLOCK1);
		binaryWriter.Write(n_SKILL1_EX2);
		binaryWriter.Write(n_SKILL1_UNLOCK2);
		binaryWriter.Write(n_SKILL1_EX3);
		binaryWriter.Write(n_SKILL1_UNLOCK3);
		binaryWriter.Write(n_SKILL2);
		binaryWriter.Write(n_SKILL2_EX1);
		binaryWriter.Write(n_SKILL2_UNLOCK1);
		binaryWriter.Write(n_SKILL2_EX2);
		binaryWriter.Write(n_SKILL2_UNLOCK2);
		binaryWriter.Write(n_SKILL2_EX3);
		binaryWriter.Write(n_SKILL2_UNLOCK3);
		binaryWriter.Write(n_PASSIVE_1);
		binaryWriter.Write(n_PASSIVE_UNLOCK1);
		binaryWriter.Write(n_PASSIVE_MATERIAL1);
		binaryWriter.Write(n_PASSIVE_2);
		binaryWriter.Write(n_PASSIVE_UNLOCK2);
		binaryWriter.Write(n_PASSIVE_MATERIAL2);
		binaryWriter.Write(n_PASSIVE_3);
		binaryWriter.Write(n_PASSIVE_UNLOCK3);
		binaryWriter.Write(n_PASSIVE_MATERIAL3);
		binaryWriter.Write(n_PASSIVE_4);
		binaryWriter.Write(n_PASSIVE_UNLOCK4);
		binaryWriter.Write(n_PASSIVE_MATERIAL4);
		binaryWriter.Write(n_PASSIVE_5);
		binaryWriter.Write(n_PASSIVE_UNLOCK5);
		binaryWriter.Write(n_PASSIVE_MATERIAL5);
		binaryWriter.Write(n_PASSIVE_6);
		binaryWriter.Write(n_PASSIVE_UNLOCK6);
		binaryWriter.Write(n_PASSIVE_MATERIAL6);
		binaryWriter.Write(n_INITIAL_SKILL1);
		binaryWriter.Write(n_INITIAL_SKILL2);
		binaryWriter.Write(n_INITIAL_SKILL3);
		binaryWriter.Write(n_RECORD_BATTLE);
		binaryWriter.Write(n_RECORD_EXPLORE);
		binaryWriter.Write(n_RECORD_ACTION);
		binaryWriter.WriteExString(s_START_VERSION);
		binaryWriter.WriteExString(s_END_VERSION);
		binaryWriter.WriteExString(w_NAME);
		binaryWriter.WriteExString(w_TYPETIP);
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
		s_NAME = binaryReader.ReadExString();
		s_ICON = binaryReader.ReadExString();
		s_MODEL = binaryReader.ReadExString();
		s_ANIMATOR = binaryReader.ReadExString();
		s_CHARA_PIVOT = binaryReader.ReadExString();
		s_ModelExtraSize = binaryReader.ReadExString();
		f_MODELSIZE = binaryReader.ReadSingle();
		s_VOICE = binaryReader.ReadExString();
		s_SE_CHARA = binaryReader.ReadExString();
		s_SE_SKILL = binaryReader.ReadExString();
		n_RARITY = binaryReader.ReadInt32();
		n_ABILITY = binaryReader.ReadInt32();
		n_LOADING = binaryReader.ReadInt32();
		n_TREND = binaryReader.ReadInt32();
		n_HEAD = binaryReader.ReadInt32();
		n_INIT_WEAPON1 = binaryReader.ReadInt32();
		n_INIT_WEAPON2 = binaryReader.ReadInt32();
		n_WEAPON_IN = binaryReader.ReadInt32();
		n_WEAPON_OUT = binaryReader.ReadInt32();
		n_SPECIAL_SHOWPOSE = binaryReader.ReadInt32();
		n_WEAPON_MOTION = binaryReader.ReadInt32();
		n_ENABLE_FLAG = binaryReader.ReadInt32();
		n_FATIGUE = binaryReader.ReadInt32();
		n_UNLOCK_ID = binaryReader.ReadInt32();
		n_UNLOCK_COUNT = binaryReader.ReadInt32();
		n_SKILL1 = binaryReader.ReadInt32();
		n_SKILL1_EX1 = binaryReader.ReadInt32();
		n_SKILL1_UNLOCK1 = binaryReader.ReadInt32();
		n_SKILL1_EX2 = binaryReader.ReadInt32();
		n_SKILL1_UNLOCK2 = binaryReader.ReadInt32();
		n_SKILL1_EX3 = binaryReader.ReadInt32();
		n_SKILL1_UNLOCK3 = binaryReader.ReadInt32();
		n_SKILL2 = binaryReader.ReadInt32();
		n_SKILL2_EX1 = binaryReader.ReadInt32();
		n_SKILL2_UNLOCK1 = binaryReader.ReadInt32();
		n_SKILL2_EX2 = binaryReader.ReadInt32();
		n_SKILL2_UNLOCK2 = binaryReader.ReadInt32();
		n_SKILL2_EX3 = binaryReader.ReadInt32();
		n_SKILL2_UNLOCK3 = binaryReader.ReadInt32();
		n_PASSIVE_1 = binaryReader.ReadInt32();
		n_PASSIVE_UNLOCK1 = binaryReader.ReadInt32();
		n_PASSIVE_MATERIAL1 = binaryReader.ReadInt32();
		n_PASSIVE_2 = binaryReader.ReadInt32();
		n_PASSIVE_UNLOCK2 = binaryReader.ReadInt32();
		n_PASSIVE_MATERIAL2 = binaryReader.ReadInt32();
		n_PASSIVE_3 = binaryReader.ReadInt32();
		n_PASSIVE_UNLOCK3 = binaryReader.ReadInt32();
		n_PASSIVE_MATERIAL3 = binaryReader.ReadInt32();
		n_PASSIVE_4 = binaryReader.ReadInt32();
		n_PASSIVE_UNLOCK4 = binaryReader.ReadInt32();
		n_PASSIVE_MATERIAL4 = binaryReader.ReadInt32();
		n_PASSIVE_5 = binaryReader.ReadInt32();
		n_PASSIVE_UNLOCK5 = binaryReader.ReadInt32();
		n_PASSIVE_MATERIAL5 = binaryReader.ReadInt32();
		n_PASSIVE_6 = binaryReader.ReadInt32();
		n_PASSIVE_UNLOCK6 = binaryReader.ReadInt32();
		n_PASSIVE_MATERIAL6 = binaryReader.ReadInt32();
		n_INITIAL_SKILL1 = binaryReader.ReadInt32();
		n_INITIAL_SKILL2 = binaryReader.ReadInt32();
		n_INITIAL_SKILL3 = binaryReader.ReadInt32();
		n_RECORD_BATTLE = binaryReader.ReadInt32();
		n_RECORD_EXPLORE = binaryReader.ReadInt32();
		n_RECORD_ACTION = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		w_NAME = binaryReader.ReadExString();
		w_TYPETIP = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
	}
}
