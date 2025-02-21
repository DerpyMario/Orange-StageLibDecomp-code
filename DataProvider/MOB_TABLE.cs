using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class MOB_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		n_DIFFICULTY,
		s_NAME,
		s_MODEL,
		s_ICON,
		n_TYPE,
		n_HP_STEP,
		n_AVATAR,
		n_SP_FLAG,
		n_COLLIDE,
		n_SCORE,
		f_CHECK_RANGE,
		s_BORNFX,
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
		s_DIE_SE,
		s_BLOCK_SE,
		s_AI,
		n_AI_TIMER,
		n_SKILL_1,
		n_SKILL_2,
		n_SKILL_3,
		n_SKILL_4,
		n_SKILL_5,
		n_SKILL_6,
		n_SKILL_7,
		n_SKILL_8,
		n_SKILL_9,
		n_SKILL_10,
		n_SKILL_11,
		n_SKILL_12,
		n_INITIAL_SKILL1,
		n_INITIAL_SKILL2,
		n_INITIAL_SKILL3,
		n_GET_CONDITION,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public int n_DIFFICULTY { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public string s_MODEL { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_HP_STEP { get; set; }

	[Preserve]
	public int n_AVATAR { get; set; }

	[Preserve]
	public int n_SP_FLAG { get; set; }

	[Preserve]
	public int n_COLLIDE { get; set; }

	[Preserve]
	public int n_SCORE { get; set; }

	[Preserve]
	public float f_CHECK_RANGE { get; set; }

	[Preserve]
	public string s_BORNFX { get; set; }

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
	public string s_DIE_SE { get; set; }

	[Preserve]
	public string s_BLOCK_SE { get; set; }

	[Preserve]
	public string s_AI { get; set; }

	[Preserve]
	public int n_AI_TIMER { get; set; }

	[Preserve]
	public int n_SKILL_1 { get; set; }

	[Preserve]
	public int n_SKILL_2 { get; set; }

	[Preserve]
	public int n_SKILL_3 { get; set; }

	[Preserve]
	public int n_SKILL_4 { get; set; }

	[Preserve]
	public int n_SKILL_5 { get; set; }

	[Preserve]
	public int n_SKILL_6 { get; set; }

	[Preserve]
	public int n_SKILL_7 { get; set; }

	[Preserve]
	public int n_SKILL_8 { get; set; }

	[Preserve]
	public int n_SKILL_9 { get; set; }

	[Preserve]
	public int n_SKILL_10 { get; set; }

	[Preserve]
	public int n_SKILL_11 { get; set; }

	[Preserve]
	public int n_SKILL_12 { get; set; }

	[Preserve]
	public int n_INITIAL_SKILL1 { get; set; }

	[Preserve]
	public int n_INITIAL_SKILL2 { get; set; }

	[Preserve]
	public int n_INITIAL_SKILL3 { get; set; }

	[Preserve]
	public int n_GET_CONDITION { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(MOB_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_GROUP != tbl.n_GROUP)
		{
			dictionary.Add(1, n_GROUP);
		}
		if (n_DIFFICULTY != tbl.n_DIFFICULTY)
		{
			dictionary.Add(2, n_DIFFICULTY);
		}
		if (s_NAME != tbl.s_NAME)
		{
			dictionary.Add(3, s_NAME);
		}
		if (s_MODEL != tbl.s_MODEL)
		{
			dictionary.Add(4, s_MODEL);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(5, s_ICON);
		}
		if (n_TYPE != tbl.n_TYPE)
		{
			dictionary.Add(6, n_TYPE);
		}
		if (n_HP_STEP != tbl.n_HP_STEP)
		{
			dictionary.Add(7, n_HP_STEP);
		}
		if (n_AVATAR != tbl.n_AVATAR)
		{
			dictionary.Add(8, n_AVATAR);
		}
		if (n_SP_FLAG != tbl.n_SP_FLAG)
		{
			dictionary.Add(9, n_SP_FLAG);
		}
		if (n_COLLIDE != tbl.n_COLLIDE)
		{
			dictionary.Add(10, n_COLLIDE);
		}
		if (n_SCORE != tbl.n_SCORE)
		{
			dictionary.Add(11, n_SCORE);
		}
		if (f_CHECK_RANGE != tbl.f_CHECK_RANGE)
		{
			dictionary.Add(12, f_CHECK_RANGE);
		}
		if (s_BORNFX != tbl.s_BORNFX)
		{
			dictionary.Add(13, s_BORNFX);
		}
		if (n_HP != tbl.n_HP)
		{
			dictionary.Add(14, n_HP);
		}
		if (n_ATK != tbl.n_ATK)
		{
			dictionary.Add(15, n_ATK);
		}
		if (n_DEF != tbl.n_DEF)
		{
			dictionary.Add(16, n_DEF);
		}
		if (n_CRI != tbl.n_CRI)
		{
			dictionary.Add(17, n_CRI);
		}
		if (n_CRI_RESIST != tbl.n_CRI_RESIST)
		{
			dictionary.Add(18, n_CRI_RESIST);
		}
		if (n_CRIDMG != tbl.n_CRIDMG)
		{
			dictionary.Add(19, n_CRIDMG);
		}
		if (n_CRIDMG_RESIST != tbl.n_CRIDMG_RESIST)
		{
			dictionary.Add(20, n_CRIDMG_RESIST);
		}
		if (n_DODGE != tbl.n_DODGE)
		{
			dictionary.Add(21, n_DODGE);
		}
		if (n_HIT != tbl.n_HIT)
		{
			dictionary.Add(22, n_HIT);
		}
		if (n_PARRY != tbl.n_PARRY)
		{
			dictionary.Add(23, n_PARRY);
		}
		if (n_PARRY_RESIST != tbl.n_PARRY_RESIST)
		{
			dictionary.Add(24, n_PARRY_RESIST);
		}
		if (n_PARRY_DEF != tbl.n_PARRY_DEF)
		{
			dictionary.Add(25, n_PARRY_DEF);
		}
		if (s_DIE_SE != tbl.s_DIE_SE)
		{
			dictionary.Add(26, s_DIE_SE);
		}
		if (s_BLOCK_SE != tbl.s_BLOCK_SE)
		{
			dictionary.Add(27, s_BLOCK_SE);
		}
		if (s_AI != tbl.s_AI)
		{
			dictionary.Add(28, s_AI);
		}
		if (n_AI_TIMER != tbl.n_AI_TIMER)
		{
			dictionary.Add(29, n_AI_TIMER);
		}
		if (n_SKILL_1 != tbl.n_SKILL_1)
		{
			dictionary.Add(30, n_SKILL_1);
		}
		if (n_SKILL_2 != tbl.n_SKILL_2)
		{
			dictionary.Add(31, n_SKILL_2);
		}
		if (n_SKILL_3 != tbl.n_SKILL_3)
		{
			dictionary.Add(32, n_SKILL_3);
		}
		if (n_SKILL_4 != tbl.n_SKILL_4)
		{
			dictionary.Add(33, n_SKILL_4);
		}
		if (n_SKILL_5 != tbl.n_SKILL_5)
		{
			dictionary.Add(34, n_SKILL_5);
		}
		if (n_SKILL_6 != tbl.n_SKILL_6)
		{
			dictionary.Add(35, n_SKILL_6);
		}
		if (n_SKILL_7 != tbl.n_SKILL_7)
		{
			dictionary.Add(36, n_SKILL_7);
		}
		if (n_SKILL_8 != tbl.n_SKILL_8)
		{
			dictionary.Add(37, n_SKILL_8);
		}
		if (n_SKILL_9 != tbl.n_SKILL_9)
		{
			dictionary.Add(38, n_SKILL_9);
		}
		if (n_SKILL_10 != tbl.n_SKILL_10)
		{
			dictionary.Add(39, n_SKILL_10);
		}
		if (n_SKILL_11 != tbl.n_SKILL_11)
		{
			dictionary.Add(40, n_SKILL_11);
		}
		if (n_SKILL_12 != tbl.n_SKILL_12)
		{
			dictionary.Add(41, n_SKILL_12);
		}
		if (n_INITIAL_SKILL1 != tbl.n_INITIAL_SKILL1)
		{
			dictionary.Add(42, n_INITIAL_SKILL1);
		}
		if (n_INITIAL_SKILL2 != tbl.n_INITIAL_SKILL2)
		{
			dictionary.Add(43, n_INITIAL_SKILL2);
		}
		if (n_INITIAL_SKILL3 != tbl.n_INITIAL_SKILL3)
		{
			dictionary.Add(44, n_INITIAL_SKILL3);
		}
		if (n_GET_CONDITION != tbl.n_GET_CONDITION)
		{
			dictionary.Add(45, n_GET_CONDITION);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(46, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(47, s_END_VERSION);
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
				n_GROUP = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_DIFFICULTY = Convert.ToInt32(item.Value);
				break;
			case 3:
				s_NAME = item.Value.ToString();
				break;
			case 4:
				s_MODEL = item.Value.ToString();
				break;
			case 5:
				s_ICON = item.Value.ToString();
				break;
			case 6:
				n_TYPE = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_HP_STEP = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_AVATAR = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_SP_FLAG = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_COLLIDE = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_SCORE = Convert.ToInt32(item.Value);
				break;
			case 12:
				f_CHECK_RANGE = Convert.ToSingle(item.Value);
				break;
			case 13:
				s_BORNFX = item.Value.ToString();
				break;
			case 14:
				n_HP = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_ATK = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_DEF = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_CRI = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_CRI_RESIST = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_CRIDMG = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_CRIDMG_RESIST = Convert.ToInt32(item.Value);
				break;
			case 21:
				n_DODGE = Convert.ToInt32(item.Value);
				break;
			case 22:
				n_HIT = Convert.ToInt32(item.Value);
				break;
			case 23:
				n_PARRY = Convert.ToInt32(item.Value);
				break;
			case 24:
				n_PARRY_RESIST = Convert.ToInt32(item.Value);
				break;
			case 25:
				n_PARRY_DEF = Convert.ToInt32(item.Value);
				break;
			case 26:
				s_DIE_SE = item.Value.ToString();
				break;
			case 27:
				s_BLOCK_SE = item.Value.ToString();
				break;
			case 28:
				s_AI = item.Value.ToString();
				break;
			case 29:
				n_AI_TIMER = Convert.ToInt32(item.Value);
				break;
			case 30:
				n_SKILL_1 = Convert.ToInt32(item.Value);
				break;
			case 31:
				n_SKILL_2 = Convert.ToInt32(item.Value);
				break;
			case 32:
				n_SKILL_3 = Convert.ToInt32(item.Value);
				break;
			case 33:
				n_SKILL_4 = Convert.ToInt32(item.Value);
				break;
			case 34:
				n_SKILL_5 = Convert.ToInt32(item.Value);
				break;
			case 35:
				n_SKILL_6 = Convert.ToInt32(item.Value);
				break;
			case 36:
				n_SKILL_7 = Convert.ToInt32(item.Value);
				break;
			case 37:
				n_SKILL_8 = Convert.ToInt32(item.Value);
				break;
			case 38:
				n_SKILL_9 = Convert.ToInt32(item.Value);
				break;
			case 39:
				n_SKILL_10 = Convert.ToInt32(item.Value);
				break;
			case 40:
				n_SKILL_11 = Convert.ToInt32(item.Value);
				break;
			case 41:
				n_SKILL_12 = Convert.ToInt32(item.Value);
				break;
			case 42:
				n_INITIAL_SKILL1 = Convert.ToInt32(item.Value);
				break;
			case 43:
				n_INITIAL_SKILL2 = Convert.ToInt32(item.Value);
				break;
			case 44:
				n_INITIAL_SKILL3 = Convert.ToInt32(item.Value);
				break;
			case 45:
				n_GET_CONDITION = Convert.ToInt32(item.Value);
				break;
			case 46:
				s_START_VERSION = item.Value.ToString();
				break;
			case 47:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(MOB_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (n_DIFFICULTY != table.n_DIFFICULTY)
		{
			return false;
		}
		if (s_NAME != table.s_NAME)
		{
			return false;
		}
		if (s_MODEL != table.s_MODEL)
		{
			return false;
		}
		if (s_ICON != table.s_ICON)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_HP_STEP != table.n_HP_STEP)
		{
			return false;
		}
		if (n_AVATAR != table.n_AVATAR)
		{
			return false;
		}
		if (n_SP_FLAG != table.n_SP_FLAG)
		{
			return false;
		}
		if (n_COLLIDE != table.n_COLLIDE)
		{
			return false;
		}
		if (n_SCORE != table.n_SCORE)
		{
			return false;
		}
		if (f_CHECK_RANGE != table.f_CHECK_RANGE)
		{
			return false;
		}
		if (s_BORNFX != table.s_BORNFX)
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
		if (s_DIE_SE != table.s_DIE_SE)
		{
			return false;
		}
		if (s_BLOCK_SE != table.s_BLOCK_SE)
		{
			return false;
		}
		if (s_AI != table.s_AI)
		{
			return false;
		}
		if (n_AI_TIMER != table.n_AI_TIMER)
		{
			return false;
		}
		if (n_SKILL_1 != table.n_SKILL_1)
		{
			return false;
		}
		if (n_SKILL_2 != table.n_SKILL_2)
		{
			return false;
		}
		if (n_SKILL_3 != table.n_SKILL_3)
		{
			return false;
		}
		if (n_SKILL_4 != table.n_SKILL_4)
		{
			return false;
		}
		if (n_SKILL_5 != table.n_SKILL_5)
		{
			return false;
		}
		if (n_SKILL_6 != table.n_SKILL_6)
		{
			return false;
		}
		if (n_SKILL_7 != table.n_SKILL_7)
		{
			return false;
		}
		if (n_SKILL_8 != table.n_SKILL_8)
		{
			return false;
		}
		if (n_SKILL_9 != table.n_SKILL_9)
		{
			return false;
		}
		if (n_SKILL_10 != table.n_SKILL_10)
		{
			return false;
		}
		if (n_SKILL_11 != table.n_SKILL_11)
		{
			return false;
		}
		if (n_SKILL_12 != table.n_SKILL_12)
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
		if (n_GET_CONDITION != table.n_GET_CONDITION)
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
		binaryWriter.Write(n_GROUP);
		binaryWriter.Write(n_DIFFICULTY);
		binaryWriter.WriteExString(s_NAME);
		binaryWriter.WriteExString(s_MODEL);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.Write(n_TYPE);
		binaryWriter.Write(n_HP_STEP);
		binaryWriter.Write(n_AVATAR);
		binaryWriter.Write(n_SP_FLAG);
		binaryWriter.Write(n_COLLIDE);
		binaryWriter.Write(n_SCORE);
		binaryWriter.Write(f_CHECK_RANGE);
		binaryWriter.WriteExString(s_BORNFX);
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
		binaryWriter.WriteExString(s_DIE_SE);
		binaryWriter.WriteExString(s_BLOCK_SE);
		binaryWriter.WriteExString(s_AI);
		binaryWriter.Write(n_AI_TIMER);
		binaryWriter.Write(n_SKILL_1);
		binaryWriter.Write(n_SKILL_2);
		binaryWriter.Write(n_SKILL_3);
		binaryWriter.Write(n_SKILL_4);
		binaryWriter.Write(n_SKILL_5);
		binaryWriter.Write(n_SKILL_6);
		binaryWriter.Write(n_SKILL_7);
		binaryWriter.Write(n_SKILL_8);
		binaryWriter.Write(n_SKILL_9);
		binaryWriter.Write(n_SKILL_10);
		binaryWriter.Write(n_SKILL_11);
		binaryWriter.Write(n_SKILL_12);
		binaryWriter.Write(n_INITIAL_SKILL1);
		binaryWriter.Write(n_INITIAL_SKILL2);
		binaryWriter.Write(n_INITIAL_SKILL3);
		binaryWriter.Write(n_GET_CONDITION);
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
		n_GROUP = binaryReader.ReadInt32();
		n_DIFFICULTY = binaryReader.ReadInt32();
		s_NAME = binaryReader.ReadExString();
		s_MODEL = binaryReader.ReadExString();
		s_ICON = binaryReader.ReadExString();
		n_TYPE = binaryReader.ReadInt32();
		n_HP_STEP = binaryReader.ReadInt32();
		n_AVATAR = binaryReader.ReadInt32();
		n_SP_FLAG = binaryReader.ReadInt32();
		n_COLLIDE = binaryReader.ReadInt32();
		n_SCORE = binaryReader.ReadInt32();
		f_CHECK_RANGE = binaryReader.ReadSingle();
		s_BORNFX = binaryReader.ReadExString();
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
		s_DIE_SE = binaryReader.ReadExString();
		s_BLOCK_SE = binaryReader.ReadExString();
		s_AI = binaryReader.ReadExString();
		n_AI_TIMER = binaryReader.ReadInt32();
		n_SKILL_1 = binaryReader.ReadInt32();
		n_SKILL_2 = binaryReader.ReadInt32();
		n_SKILL_3 = binaryReader.ReadInt32();
		n_SKILL_4 = binaryReader.ReadInt32();
		n_SKILL_5 = binaryReader.ReadInt32();
		n_SKILL_6 = binaryReader.ReadInt32();
		n_SKILL_7 = binaryReader.ReadInt32();
		n_SKILL_8 = binaryReader.ReadInt32();
		n_SKILL_9 = binaryReader.ReadInt32();
		n_SKILL_10 = binaryReader.ReadInt32();
		n_SKILL_11 = binaryReader.ReadInt32();
		n_SKILL_12 = binaryReader.ReadInt32();
		n_INITIAL_SKILL1 = binaryReader.ReadInt32();
		n_INITIAL_SKILL2 = binaryReader.ReadInt32();
		n_INITIAL_SKILL3 = binaryReader.ReadInt32();
		n_GET_CONDITION = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
