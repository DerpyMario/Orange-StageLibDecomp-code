using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class MISSION_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		n_SUB_TYPE,
		n_COUNTER,
		n_CONDITION,
		n_CONDITION_X,
		n_CONDITION_Y,
		n_CONDITION_Z,
		n_CONDITION_W,
		n_ITEMID_1,
		n_ITEMCOUNT_1,
		n_ITEMID_2,
		n_ITEMCOUNT_2,
		n_ITEMID_3,
		n_ITEMCOUNT_3,
		n_SKILL,
		n_EXP,
		n_ACTIVITY,
		n_AP,
		n_EP,
		n_LIMIT,
		n_RESET_RULE,
		n_OPEN_CONDITION,
		n_OPEN_CONDITION_X,
		n_END_RANK,
		n_MAILID,
		n_UILINK,
		s_CREATE_TIME,
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
	public int n_SUB_TYPE { get; set; }

	[Preserve]
	public int n_COUNTER { get; set; }

	[Preserve]
	public int n_CONDITION { get; set; }

	[Preserve]
	public int n_CONDITION_X { get; set; }

	[Preserve]
	public int n_CONDITION_Y { get; set; }

	[Preserve]
	public int n_CONDITION_Z { get; set; }

	[Preserve]
	public int n_CONDITION_W { get; set; }

	[Preserve]
	public int n_ITEMID_1 { get; set; }

	[Preserve]
	public int n_ITEMCOUNT_1 { get; set; }

	[Preserve]
	public int n_ITEMID_2 { get; set; }

	[Preserve]
	public int n_ITEMCOUNT_2 { get; set; }

	[Preserve]
	public int n_ITEMID_3 { get; set; }

	[Preserve]
	public int n_ITEMCOUNT_3 { get; set; }

	[Preserve]
	public int n_SKILL { get; set; }

	[Preserve]
	public int n_EXP { get; set; }

	[Preserve]
	public int n_ACTIVITY { get; set; }

	[Preserve]
	public int n_AP { get; set; }

	[Preserve]
	public int n_EP { get; set; }

	[Preserve]
	public int n_LIMIT { get; set; }

	[Preserve]
	public int n_RESET_RULE { get; set; }

	[Preserve]
	public int n_OPEN_CONDITION { get; set; }

	[Preserve]
	public int n_OPEN_CONDITION_X { get; set; }

	[Preserve]
	public int n_END_RANK { get; set; }

	[Preserve]
	public int n_MAILID { get; set; }

	[Preserve]
	public int n_UILINK { get; set; }

	[Preserve]
	public string s_CREATE_TIME { get; set; }

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

	public Dictionary<int, object> MakeDiffDictionary(MISSION_TABLE tbl)
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
		if (n_SUB_TYPE != tbl.n_SUB_TYPE)
		{
			dictionary.Add(2, n_SUB_TYPE);
		}
		if (n_COUNTER != tbl.n_COUNTER)
		{
			dictionary.Add(3, n_COUNTER);
		}
		if (n_CONDITION != tbl.n_CONDITION)
		{
			dictionary.Add(4, n_CONDITION);
		}
		if (n_CONDITION_X != tbl.n_CONDITION_X)
		{
			dictionary.Add(5, n_CONDITION_X);
		}
		if (n_CONDITION_Y != tbl.n_CONDITION_Y)
		{
			dictionary.Add(6, n_CONDITION_Y);
		}
		if (n_CONDITION_Z != tbl.n_CONDITION_Z)
		{
			dictionary.Add(7, n_CONDITION_Z);
		}
		if (n_CONDITION_W != tbl.n_CONDITION_W)
		{
			dictionary.Add(8, n_CONDITION_W);
		}
		if (n_ITEMID_1 != tbl.n_ITEMID_1)
		{
			dictionary.Add(9, n_ITEMID_1);
		}
		if (n_ITEMCOUNT_1 != tbl.n_ITEMCOUNT_1)
		{
			dictionary.Add(10, n_ITEMCOUNT_1);
		}
		if (n_ITEMID_2 != tbl.n_ITEMID_2)
		{
			dictionary.Add(11, n_ITEMID_2);
		}
		if (n_ITEMCOUNT_2 != tbl.n_ITEMCOUNT_2)
		{
			dictionary.Add(12, n_ITEMCOUNT_2);
		}
		if (n_ITEMID_3 != tbl.n_ITEMID_3)
		{
			dictionary.Add(13, n_ITEMID_3);
		}
		if (n_ITEMCOUNT_3 != tbl.n_ITEMCOUNT_3)
		{
			dictionary.Add(14, n_ITEMCOUNT_3);
		}
		if (n_SKILL != tbl.n_SKILL)
		{
			dictionary.Add(15, n_SKILL);
		}
		if (n_EXP != tbl.n_EXP)
		{
			dictionary.Add(16, n_EXP);
		}
		if (n_ACTIVITY != tbl.n_ACTIVITY)
		{
			dictionary.Add(17, n_ACTIVITY);
		}
		if (n_AP != tbl.n_AP)
		{
			dictionary.Add(18, n_AP);
		}
		if (n_EP != tbl.n_EP)
		{
			dictionary.Add(19, n_EP);
		}
		if (n_LIMIT != tbl.n_LIMIT)
		{
			dictionary.Add(20, n_LIMIT);
		}
		if (n_RESET_RULE != tbl.n_RESET_RULE)
		{
			dictionary.Add(21, n_RESET_RULE);
		}
		if (n_OPEN_CONDITION != tbl.n_OPEN_CONDITION)
		{
			dictionary.Add(22, n_OPEN_CONDITION);
		}
		if (n_OPEN_CONDITION_X != tbl.n_OPEN_CONDITION_X)
		{
			dictionary.Add(23, n_OPEN_CONDITION_X);
		}
		if (n_END_RANK != tbl.n_END_RANK)
		{
			dictionary.Add(24, n_END_RANK);
		}
		if (n_MAILID != tbl.n_MAILID)
		{
			dictionary.Add(25, n_MAILID);
		}
		if (n_UILINK != tbl.n_UILINK)
		{
			dictionary.Add(26, n_UILINK);
		}
		if (s_CREATE_TIME != tbl.s_CREATE_TIME)
		{
			dictionary.Add(27, s_CREATE_TIME);
		}
		if (s_BEGIN_TIME != tbl.s_BEGIN_TIME)
		{
			dictionary.Add(28, s_BEGIN_TIME);
		}
		if (s_END_TIME != tbl.s_END_TIME)
		{
			dictionary.Add(29, s_END_TIME);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(30, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(31, s_END_VERSION);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(32, w_NAME);
		}
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(33, w_TIP);
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
				n_SUB_TYPE = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_COUNTER = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_CONDITION = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_CONDITION_X = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_CONDITION_Y = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_CONDITION_Z = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_CONDITION_W = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_ITEMID_1 = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_ITEMCOUNT_1 = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_ITEMID_2 = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_ITEMCOUNT_2 = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_ITEMID_3 = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_ITEMCOUNT_3 = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_SKILL = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_EXP = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_ACTIVITY = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_AP = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_EP = Convert.ToInt32(item.Value);
				break;
			case 20:
				n_LIMIT = Convert.ToInt32(item.Value);
				break;
			case 21:
				n_RESET_RULE = Convert.ToInt32(item.Value);
				break;
			case 22:
				n_OPEN_CONDITION = Convert.ToInt32(item.Value);
				break;
			case 23:
				n_OPEN_CONDITION_X = Convert.ToInt32(item.Value);
				break;
			case 24:
				n_END_RANK = Convert.ToInt32(item.Value);
				break;
			case 25:
				n_MAILID = Convert.ToInt32(item.Value);
				break;
			case 26:
				n_UILINK = Convert.ToInt32(item.Value);
				break;
			case 27:
				s_CREATE_TIME = item.Value.ToString();
				break;
			case 28:
				s_BEGIN_TIME = item.Value.ToString();
				break;
			case 29:
				s_END_TIME = item.Value.ToString();
				break;
			case 30:
				s_START_VERSION = item.Value.ToString();
				break;
			case 31:
				s_END_VERSION = item.Value.ToString();
				break;
			case 32:
				w_NAME = item.Value.ToString();
				break;
			case 33:
				w_TIP = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(MISSION_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_SUB_TYPE != table.n_SUB_TYPE)
		{
			return false;
		}
		if (n_COUNTER != table.n_COUNTER)
		{
			return false;
		}
		if (n_CONDITION != table.n_CONDITION)
		{
			return false;
		}
		if (n_CONDITION_X != table.n_CONDITION_X)
		{
			return false;
		}
		if (n_CONDITION_Y != table.n_CONDITION_Y)
		{
			return false;
		}
		if (n_CONDITION_Z != table.n_CONDITION_Z)
		{
			return false;
		}
		if (n_CONDITION_W != table.n_CONDITION_W)
		{
			return false;
		}
		if (n_ITEMID_1 != table.n_ITEMID_1)
		{
			return false;
		}
		if (n_ITEMCOUNT_1 != table.n_ITEMCOUNT_1)
		{
			return false;
		}
		if (n_ITEMID_2 != table.n_ITEMID_2)
		{
			return false;
		}
		if (n_ITEMCOUNT_2 != table.n_ITEMCOUNT_2)
		{
			return false;
		}
		if (n_ITEMID_3 != table.n_ITEMID_3)
		{
			return false;
		}
		if (n_ITEMCOUNT_3 != table.n_ITEMCOUNT_3)
		{
			return false;
		}
		if (n_SKILL != table.n_SKILL)
		{
			return false;
		}
		if (n_EXP != table.n_EXP)
		{
			return false;
		}
		if (n_ACTIVITY != table.n_ACTIVITY)
		{
			return false;
		}
		if (n_AP != table.n_AP)
		{
			return false;
		}
		if (n_EP != table.n_EP)
		{
			return false;
		}
		if (n_LIMIT != table.n_LIMIT)
		{
			return false;
		}
		if (n_RESET_RULE != table.n_RESET_RULE)
		{
			return false;
		}
		if (n_OPEN_CONDITION != table.n_OPEN_CONDITION)
		{
			return false;
		}
		if (n_OPEN_CONDITION_X != table.n_OPEN_CONDITION_X)
		{
			return false;
		}
		if (n_END_RANK != table.n_END_RANK)
		{
			return false;
		}
		if (n_MAILID != table.n_MAILID)
		{
			return false;
		}
		if (n_UILINK != table.n_UILINK)
		{
			return false;
		}
		if (s_CREATE_TIME != table.s_CREATE_TIME)
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
		binaryWriter.Write(n_SUB_TYPE);
		binaryWriter.Write(n_COUNTER);
		binaryWriter.Write(n_CONDITION);
		binaryWriter.Write(n_CONDITION_X);
		binaryWriter.Write(n_CONDITION_Y);
		binaryWriter.Write(n_CONDITION_Z);
		binaryWriter.Write(n_CONDITION_W);
		binaryWriter.Write(n_ITEMID_1);
		binaryWriter.Write(n_ITEMCOUNT_1);
		binaryWriter.Write(n_ITEMID_2);
		binaryWriter.Write(n_ITEMCOUNT_2);
		binaryWriter.Write(n_ITEMID_3);
		binaryWriter.Write(n_ITEMCOUNT_3);
		binaryWriter.Write(n_SKILL);
		binaryWriter.Write(n_EXP);
		binaryWriter.Write(n_ACTIVITY);
		binaryWriter.Write(n_AP);
		binaryWriter.Write(n_EP);
		binaryWriter.Write(n_LIMIT);
		binaryWriter.Write(n_RESET_RULE);
		binaryWriter.Write(n_OPEN_CONDITION);
		binaryWriter.Write(n_OPEN_CONDITION_X);
		binaryWriter.Write(n_END_RANK);
		binaryWriter.Write(n_MAILID);
		binaryWriter.Write(n_UILINK);
		binaryWriter.WriteExString(s_CREATE_TIME);
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
		n_SUB_TYPE = binaryReader.ReadInt32();
		n_COUNTER = binaryReader.ReadInt32();
		n_CONDITION = binaryReader.ReadInt32();
		n_CONDITION_X = binaryReader.ReadInt32();
		n_CONDITION_Y = binaryReader.ReadInt32();
		n_CONDITION_Z = binaryReader.ReadInt32();
		n_CONDITION_W = binaryReader.ReadInt32();
		n_ITEMID_1 = binaryReader.ReadInt32();
		n_ITEMCOUNT_1 = binaryReader.ReadInt32();
		n_ITEMID_2 = binaryReader.ReadInt32();
		n_ITEMCOUNT_2 = binaryReader.ReadInt32();
		n_ITEMID_3 = binaryReader.ReadInt32();
		n_ITEMCOUNT_3 = binaryReader.ReadInt32();
		n_SKILL = binaryReader.ReadInt32();
		n_EXP = binaryReader.ReadInt32();
		n_ACTIVITY = binaryReader.ReadInt32();
		n_AP = binaryReader.ReadInt32();
		n_EP = binaryReader.ReadInt32();
		n_LIMIT = binaryReader.ReadInt32();
		n_RESET_RULE = binaryReader.ReadInt32();
		n_OPEN_CONDITION = binaryReader.ReadInt32();
		n_OPEN_CONDITION_X = binaryReader.ReadInt32();
		n_END_RANK = binaryReader.ReadInt32();
		n_MAILID = binaryReader.ReadInt32();
		n_UILINK = binaryReader.ReadInt32();
		s_CREATE_TIME = binaryReader.ReadExString();
		s_BEGIN_TIME = binaryReader.ReadExString();
		s_END_TIME = binaryReader.ReadExString();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
		w_NAME = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
	}
}
