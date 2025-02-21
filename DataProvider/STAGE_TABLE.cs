using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class STAGE_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		n_MAIN,
		n_SUB,
		n_DIFFICULTY,
		s_PRE,
		s_BG,
		s_ICON,
		n_RANK,
		n_AP,
		n_PLAY_COUNT,
		n_RESET_RULE,
		n_CP,
		n_TIME,
		n_ENV_DAMAGE,
		n_SINGLEPLAY,
		n_STAGE_RULE,
		s_STAGE,
		s_SET,
		s_BGM,
		s_BOSSENTRY_BGM,
		s_BOSSBATTLE_BGM,
		n_SECRET,
		n_CLEAR1,
		n_CLEAR_VALUE1,
		n_CLEAR2,
		n_CLEAR_VALUE2,
		n_CLEAR3,
		n_CLEAR_VALUE3,
		n_FIRST_EXP,
		n_FIRST_MONEY,
		n_FIRST_REWARD,
		n_GET_EXP,
		n_GET_MONEY,
		n_GET_REWARD,
		n_PROF,
		w_BOSS_INTRO,
		s_PATH,
		s_BEGIN_TIME,
		s_END_TIME,
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
	public int n_MAIN { get; set; }

	[Preserve]
	public int n_SUB { get; set; }

	[Preserve]
	public int n_DIFFICULTY { get; set; }

	[Preserve]
	public string s_PRE { get; set; }

	[Preserve]
	public string s_BG { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public int n_RANK { get; set; }

	[Preserve]
	public int n_AP { get; set; }

	[Preserve]
	public int n_PLAY_COUNT { get; set; }

	[Preserve]
	public int n_RESET_RULE { get; set; }

	[Preserve]
	public int n_CP { get; set; }

	[Preserve]
	public int n_TIME { get; set; }

	[Preserve]
	public int n_ENV_DAMAGE { get; set; }

	[Preserve]
	public int n_SINGLEPLAY { get; set; }

	[Preserve]
	public int n_STAGE_RULE { get; set; }

	[Preserve]
	public string s_STAGE { get; set; }

	[Preserve]
	public string s_SET { get; set; }

	[Preserve]
	public string s_BGM { get; set; }

	[Preserve]
	public string s_BOSSENTRY_BGM { get; set; }

	[Preserve]
	public string s_BOSSBATTLE_BGM { get; set; }

	[Preserve]
	public int n_SECRET { get; set; }

	[Preserve]
	public int n_CLEAR1 { get; set; }

	[Preserve]
	public int n_CLEAR_VALUE1 { get; set; }

	[Preserve]
	public int n_CLEAR2 { get; set; }

	[Preserve]
	public int n_CLEAR_VALUE2 { get; set; }

	[Preserve]
	public int n_CLEAR3 { get; set; }

	[Preserve]
	public int n_CLEAR_VALUE3 { get; set; }

	[Preserve]
	public int n_FIRST_EXP { get; set; }

	[Preserve]
	public int n_FIRST_MONEY { get; set; }

	[Preserve]
	public int n_FIRST_REWARD { get; set; }

	[Preserve]
	public int n_GET_EXP { get; set; }

	[Preserve]
	public int n_GET_MONEY { get; set; }

	[Preserve]
	public int n_GET_REWARD { get; set; }

	[Preserve]
	public int n_PROF { get; set; }

	[Preserve]
	public string w_BOSS_INTRO { get; set; }

	[Preserve]
	public string s_PATH { get; set; }

	[Preserve]
	public string s_BEGIN_TIME { get; set; }

	[Preserve]
	public string s_END_TIME { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string w_TIP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(STAGE_TABLE tbl)
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
		if (n_MAIN != tbl.n_MAIN)
		{
			dictionary.Add(2, n_MAIN);
		}
		if (n_SUB != tbl.n_SUB)
		{
			dictionary.Add(3, n_SUB);
		}
		if (n_DIFFICULTY != tbl.n_DIFFICULTY)
		{
			dictionary.Add(4, n_DIFFICULTY);
		}
		if (s_PRE != tbl.s_PRE)
		{
			dictionary.Add(5, s_PRE);
		}
		if (s_BG != tbl.s_BG)
		{
			dictionary.Add(6, s_BG);
		}
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(7, s_ICON);
		}
		if (n_RANK != tbl.n_RANK)
		{
			dictionary.Add(8, n_RANK);
		}
		if (n_AP != tbl.n_AP)
		{
			dictionary.Add(9, n_AP);
		}
		if (n_PLAY_COUNT != tbl.n_PLAY_COUNT)
		{
			dictionary.Add(10, n_PLAY_COUNT);
		}
		if (n_RESET_RULE != tbl.n_RESET_RULE)
		{
			dictionary.Add(11, n_RESET_RULE);
		}
		if (n_CP != tbl.n_CP)
		{
			dictionary.Add(12, n_CP);
		}
		if (n_TIME != tbl.n_TIME)
		{
			dictionary.Add(13, n_TIME);
		}
		if (n_ENV_DAMAGE != tbl.n_ENV_DAMAGE)
		{
			dictionary.Add(14, n_ENV_DAMAGE);
		}
		if (n_SINGLEPLAY != tbl.n_SINGLEPLAY)
		{
			dictionary.Add(15, n_SINGLEPLAY);
		}
		if (n_STAGE_RULE != tbl.n_STAGE_RULE)
		{
			dictionary.Add(16, n_STAGE_RULE);
		}
		if (s_STAGE != tbl.s_STAGE)
		{
			dictionary.Add(17, s_STAGE);
		}
		if (s_SET != tbl.s_SET)
		{
			dictionary.Add(18, s_SET);
		}
		if (s_BGM != tbl.s_BGM)
		{
			dictionary.Add(19, s_BGM);
		}
		if (s_BOSSENTRY_BGM != tbl.s_BOSSENTRY_BGM)
		{
			dictionary.Add(20, s_BOSSENTRY_BGM);
		}
		if (s_BOSSBATTLE_BGM != tbl.s_BOSSBATTLE_BGM)
		{
			dictionary.Add(21, s_BOSSBATTLE_BGM);
		}
		if (n_SECRET != tbl.n_SECRET)
		{
			dictionary.Add(22, n_SECRET);
		}
		if (n_CLEAR1 != tbl.n_CLEAR1)
		{
			dictionary.Add(23, n_CLEAR1);
		}
		if (n_CLEAR_VALUE1 != tbl.n_CLEAR_VALUE1)
		{
			dictionary.Add(24, n_CLEAR_VALUE1);
		}
		if (n_CLEAR2 != tbl.n_CLEAR2)
		{
			dictionary.Add(25, n_CLEAR2);
		}
		if (n_CLEAR_VALUE2 != tbl.n_CLEAR_VALUE2)
		{
			dictionary.Add(26, n_CLEAR_VALUE2);
		}
		if (n_CLEAR3 != tbl.n_CLEAR3)
		{
			dictionary.Add(27, n_CLEAR3);
		}
		if (n_CLEAR_VALUE3 != tbl.n_CLEAR_VALUE3)
		{
			dictionary.Add(28, n_CLEAR_VALUE3);
		}
		if (n_FIRST_EXP != tbl.n_FIRST_EXP)
		{
			dictionary.Add(29, n_FIRST_EXP);
		}
		if (n_FIRST_MONEY != tbl.n_FIRST_MONEY)
		{
			dictionary.Add(30, n_FIRST_MONEY);
		}
		if (n_FIRST_REWARD != tbl.n_FIRST_REWARD)
		{
			dictionary.Add(31, n_FIRST_REWARD);
		}
		if (n_GET_EXP != tbl.n_GET_EXP)
		{
			dictionary.Add(32, n_GET_EXP);
		}
		if (n_GET_MONEY != tbl.n_GET_MONEY)
		{
			dictionary.Add(33, n_GET_MONEY);
		}
		if (n_GET_REWARD != tbl.n_GET_REWARD)
		{
			dictionary.Add(34, n_GET_REWARD);
		}
		if (n_PROF != tbl.n_PROF)
		{
			dictionary.Add(35, n_PROF);
		}
		if (w_BOSS_INTRO != tbl.w_BOSS_INTRO)
		{
			dictionary.Add(36, w_BOSS_INTRO);
		}
		if (s_PATH != tbl.s_PATH)
		{
			dictionary.Add(37, s_PATH);
		}
		if (s_BEGIN_TIME != tbl.s_BEGIN_TIME)
		{
			dictionary.Add(38, s_BEGIN_TIME);
		}
		if (s_END_TIME != tbl.s_END_TIME)
		{
			dictionary.Add(39, s_END_TIME);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(40, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(41, s_END_VERSION);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(42, w_NAME);
		}
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(43, w_TIP);
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
				n_MAIN = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_SUB = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_DIFFICULTY = Convert.ToInt32(item.Value);
				break;
			case 5:
				s_PRE = item.Value.ToString();
				break;
			case 6:
				s_BG = item.Value.ToString();
				break;
			case 7:
				s_ICON = item.Value.ToString();
				break;
			case 8:
				n_RANK = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_AP = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_PLAY_COUNT = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_RESET_RULE = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_CP = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_TIME = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_ENV_DAMAGE = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_SINGLEPLAY = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_STAGE_RULE = Convert.ToInt32(item.Value);
				break;
			case 17:
				s_STAGE = item.Value.ToString();
				break;
			case 18:
				s_SET = item.Value.ToString();
				break;
			case 19:
				s_BGM = item.Value.ToString();
				break;
			case 20:
				s_BOSSENTRY_BGM = item.Value.ToString();
				break;
			case 21:
				s_BOSSBATTLE_BGM = item.Value.ToString();
				break;
			case 22:
				n_SECRET = Convert.ToInt32(item.Value);
				break;
			case 23:
				n_CLEAR1 = Convert.ToInt32(item.Value);
				break;
			case 24:
				n_CLEAR_VALUE1 = Convert.ToInt32(item.Value);
				break;
			case 25:
				n_CLEAR2 = Convert.ToInt32(item.Value);
				break;
			case 26:
				n_CLEAR_VALUE2 = Convert.ToInt32(item.Value);
				break;
			case 27:
				n_CLEAR3 = Convert.ToInt32(item.Value);
				break;
			case 28:
				n_CLEAR_VALUE3 = Convert.ToInt32(item.Value);
				break;
			case 29:
				n_FIRST_EXP = Convert.ToInt32(item.Value);
				break;
			case 30:
				n_FIRST_MONEY = Convert.ToInt32(item.Value);
				break;
			case 31:
				n_FIRST_REWARD = Convert.ToInt32(item.Value);
				break;
			case 32:
				n_GET_EXP = Convert.ToInt32(item.Value);
				break;
			case 33:
				n_GET_MONEY = Convert.ToInt32(item.Value);
				break;
			case 34:
				n_GET_REWARD = Convert.ToInt32(item.Value);
				break;
			case 35:
				n_PROF = Convert.ToInt32(item.Value);
				break;
			case 36:
				w_BOSS_INTRO = item.Value.ToString();
				break;
			case 37:
				s_PATH = item.Value.ToString();
				break;
			case 38:
				s_BEGIN_TIME = item.Value.ToString();
				break;
			case 39:
				s_END_TIME = item.Value.ToString();
				break;
			case 40:
				s_START_VERSION = item.Value.ToString();
				break;
			case 41:
				s_END_VERSION = item.Value.ToString();
				break;
			case 42:
				w_NAME = item.Value.ToString();
				break;
			case 43:
				w_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(STAGE_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_MAIN != table.n_MAIN)
		{
			return false;
		}
		if (n_SUB != table.n_SUB)
		{
			return false;
		}
		if (n_DIFFICULTY != table.n_DIFFICULTY)
		{
			return false;
		}
		if (s_PRE != table.s_PRE)
		{
			return false;
		}
		if (s_BG != table.s_BG)
		{
			return false;
		}
		if (s_ICON != table.s_ICON)
		{
			return false;
		}
		if (n_RANK != table.n_RANK)
		{
			return false;
		}
		if (n_AP != table.n_AP)
		{
			return false;
		}
		if (n_PLAY_COUNT != table.n_PLAY_COUNT)
		{
			return false;
		}
		if (n_RESET_RULE != table.n_RESET_RULE)
		{
			return false;
		}
		if (n_CP != table.n_CP)
		{
			return false;
		}
		if (n_TIME != table.n_TIME)
		{
			return false;
		}
		if (n_ENV_DAMAGE != table.n_ENV_DAMAGE)
		{
			return false;
		}
		if (n_SINGLEPLAY != table.n_SINGLEPLAY)
		{
			return false;
		}
		if (n_STAGE_RULE != table.n_STAGE_RULE)
		{
			return false;
		}
		if (s_STAGE != table.s_STAGE)
		{
			return false;
		}
		if (s_SET != table.s_SET)
		{
			return false;
		}
		if (s_BGM != table.s_BGM)
		{
			return false;
		}
		if (s_BOSSENTRY_BGM != table.s_BOSSENTRY_BGM)
		{
			return false;
		}
		if (s_BOSSBATTLE_BGM != table.s_BOSSBATTLE_BGM)
		{
			return false;
		}
		if (n_SECRET != table.n_SECRET)
		{
			return false;
		}
		if (n_CLEAR1 != table.n_CLEAR1)
		{
			return false;
		}
		if (n_CLEAR_VALUE1 != table.n_CLEAR_VALUE1)
		{
			return false;
		}
		if (n_CLEAR2 != table.n_CLEAR2)
		{
			return false;
		}
		if (n_CLEAR_VALUE2 != table.n_CLEAR_VALUE2)
		{
			return false;
		}
		if (n_CLEAR3 != table.n_CLEAR3)
		{
			return false;
		}
		if (n_CLEAR_VALUE3 != table.n_CLEAR_VALUE3)
		{
			return false;
		}
		if (n_FIRST_EXP != table.n_FIRST_EXP)
		{
			return false;
		}
		if (n_FIRST_MONEY != table.n_FIRST_MONEY)
		{
			return false;
		}
		if (n_FIRST_REWARD != table.n_FIRST_REWARD)
		{
			return false;
		}
		if (n_GET_EXP != table.n_GET_EXP)
		{
			return false;
		}
		if (n_GET_MONEY != table.n_GET_MONEY)
		{
			return false;
		}
		if (n_GET_REWARD != table.n_GET_REWARD)
		{
			return false;
		}
		if (n_PROF != table.n_PROF)
		{
			return false;
		}
		if (w_BOSS_INTRO != table.w_BOSS_INTRO)
		{
			return false;
		}
		if (s_PATH != table.s_PATH)
		{
			return false;
		}
		if (s_BEGIN_TIME != table.s_BEGIN_TIME)
		{
			return false;
		}
		if (s_END_TIME != table.s_END_TIME)
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
		binaryWriter.Write(n_MAIN);
		binaryWriter.Write(n_SUB);
		binaryWriter.Write(n_DIFFICULTY);
		binaryWriter.WriteExString(s_PRE);
		binaryWriter.WriteExString(s_BG);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.Write(n_RANK);
		binaryWriter.Write(n_AP);
		binaryWriter.Write(n_PLAY_COUNT);
		binaryWriter.Write(n_RESET_RULE);
		binaryWriter.Write(n_CP);
		binaryWriter.Write(n_TIME);
		binaryWriter.Write(n_ENV_DAMAGE);
		binaryWriter.Write(n_SINGLEPLAY);
		binaryWriter.Write(n_STAGE_RULE);
		binaryWriter.WriteExString(s_STAGE);
		binaryWriter.WriteExString(s_SET);
		binaryWriter.WriteExString(s_BGM);
		binaryWriter.WriteExString(s_BOSSENTRY_BGM);
		binaryWriter.WriteExString(s_BOSSBATTLE_BGM);
		binaryWriter.Write(n_SECRET);
		binaryWriter.Write(n_CLEAR1);
		binaryWriter.Write(n_CLEAR_VALUE1);
		binaryWriter.Write(n_CLEAR2);
		binaryWriter.Write(n_CLEAR_VALUE2);
		binaryWriter.Write(n_CLEAR3);
		binaryWriter.Write(n_CLEAR_VALUE3);
		binaryWriter.Write(n_FIRST_EXP);
		binaryWriter.Write(n_FIRST_MONEY);
		binaryWriter.Write(n_FIRST_REWARD);
		binaryWriter.Write(n_GET_EXP);
		binaryWriter.Write(n_GET_MONEY);
		binaryWriter.Write(n_GET_REWARD);
		binaryWriter.Write(n_PROF);
		binaryWriter.WriteExString(w_BOSS_INTRO);
		binaryWriter.WriteExString(s_PATH);
		binaryWriter.WriteExString(s_BEGIN_TIME);
		binaryWriter.WriteExString(s_END_TIME);
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
		n_MAIN = binaryReader.ReadInt32();
		n_SUB = binaryReader.ReadInt32();
		n_DIFFICULTY = binaryReader.ReadInt32();
		s_PRE = binaryReader.ReadExString();
		s_BG = binaryReader.ReadExString();
		s_ICON = binaryReader.ReadExString();
		n_RANK = binaryReader.ReadInt32();
		n_AP = binaryReader.ReadInt32();
		n_PLAY_COUNT = binaryReader.ReadInt32();
		n_RESET_RULE = binaryReader.ReadInt32();
		n_CP = binaryReader.ReadInt32();
		n_TIME = binaryReader.ReadInt32();
		n_ENV_DAMAGE = binaryReader.ReadInt32();
		n_SINGLEPLAY = binaryReader.ReadInt32();
		n_STAGE_RULE = binaryReader.ReadInt32();
		s_STAGE = binaryReader.ReadExString();
		s_SET = binaryReader.ReadExString();
		s_BGM = binaryReader.ReadExString();
		s_BOSSENTRY_BGM = binaryReader.ReadExString();
		s_BOSSBATTLE_BGM = binaryReader.ReadExString();
		n_SECRET = binaryReader.ReadInt32();
		n_CLEAR1 = binaryReader.ReadInt32();
		n_CLEAR_VALUE1 = binaryReader.ReadInt32();
		n_CLEAR2 = binaryReader.ReadInt32();
		n_CLEAR_VALUE2 = binaryReader.ReadInt32();
		n_CLEAR3 = binaryReader.ReadInt32();
		n_CLEAR_VALUE3 = binaryReader.ReadInt32();
		n_FIRST_EXP = binaryReader.ReadInt32();
		n_FIRST_MONEY = binaryReader.ReadInt32();
		n_FIRST_REWARD = binaryReader.ReadInt32();
		n_GET_EXP = binaryReader.ReadInt32();
		n_GET_MONEY = binaryReader.ReadInt32();
		n_GET_REWARD = binaryReader.ReadInt32();
		n_PROF = binaryReader.ReadInt32();
		w_BOSS_INTRO = binaryReader.ReadExString();
		s_PATH = binaryReader.ReadExString();
		s_BEGIN_TIME = binaryReader.ReadExString();
		s_END_TIME = binaryReader.ReadExString();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		w_NAME = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
	}
}
