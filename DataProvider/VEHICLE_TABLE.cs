using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class VEHICLE_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		s_NAME,
		s_MODEL,
		n_HP,
		n_SPEED,
		n_ABILITY,
		n_SKILL_1,
		n_SKILL_2,
		n_SKILL_3,
		n_INITIAL_SKILL1,
		n_INITIAL_SKILL2,
		n_INITIAL_SKILL3
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public string s_MODEL { get; set; }

	[Preserve]
	public int n_HP { get; set; }

	[Preserve]
	public int n_SPEED { get; set; }

	[Preserve]
	public int n_ABILITY { get; set; }

	[Preserve]
	public int n_SKILL_1 { get; set; }

	[Preserve]
	public int n_SKILL_2 { get; set; }

	[Preserve]
	public int n_SKILL_3 { get; set; }

	[Preserve]
	public int n_INITIAL_SKILL1 { get; set; }

	[Preserve]
	public int n_INITIAL_SKILL2 { get; set; }

	[Preserve]
	public int n_INITIAL_SKILL3 { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(VEHICLE_TABLE tbl)
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
		if (s_MODEL != tbl.s_MODEL)
		{
			dictionary.Add(2, s_MODEL);
		}
		if (n_HP != tbl.n_HP)
		{
			dictionary.Add(3, n_HP);
		}
		if (n_SPEED != tbl.n_SPEED)
		{
			dictionary.Add(4, n_SPEED);
		}
		if (n_ABILITY != tbl.n_ABILITY)
		{
			dictionary.Add(5, n_ABILITY);
		}
		if (n_SKILL_1 != tbl.n_SKILL_1)
		{
			dictionary.Add(6, n_SKILL_1);
		}
		if (n_SKILL_2 != tbl.n_SKILL_2)
		{
			dictionary.Add(7, n_SKILL_2);
		}
		if (n_SKILL_3 != tbl.n_SKILL_3)
		{
			dictionary.Add(8, n_SKILL_3);
		}
		if (n_INITIAL_SKILL1 != tbl.n_INITIAL_SKILL1)
		{
			dictionary.Add(9, n_INITIAL_SKILL1);
		}
		if (n_INITIAL_SKILL2 != tbl.n_INITIAL_SKILL2)
		{
			dictionary.Add(10, n_INITIAL_SKILL2);
		}
		if (n_INITIAL_SKILL3 != tbl.n_INITIAL_SKILL3)
		{
			dictionary.Add(11, n_INITIAL_SKILL3);
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
				s_MODEL = item.Value.ToString();
				break;
			case 3:
				n_HP = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_SPEED = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_ABILITY = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_SKILL_1 = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_SKILL_2 = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_SKILL_3 = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_INITIAL_SKILL1 = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_INITIAL_SKILL2 = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_INITIAL_SKILL3 = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(VEHICLE_TABLE table)
	{
		if (n_ID != table.n_ID)
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
		if (n_HP != table.n_HP)
		{
			return false;
		}
		if (n_SPEED != table.n_SPEED)
		{
			return false;
		}
		if (n_ABILITY != table.n_ABILITY)
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
		return true;
	}

	public string ConvertToString()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(n_ID);
		binaryWriter.WriteExString(s_NAME);
		binaryWriter.WriteExString(s_MODEL);
		binaryWriter.Write(n_HP);
		binaryWriter.Write(n_SPEED);
		binaryWriter.Write(n_ABILITY);
		binaryWriter.Write(n_SKILL_1);
		binaryWriter.Write(n_SKILL_2);
		binaryWriter.Write(n_SKILL_3);
		binaryWriter.Write(n_INITIAL_SKILL1);
		binaryWriter.Write(n_INITIAL_SKILL2);
		binaryWriter.Write(n_INITIAL_SKILL3);
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
		s_MODEL = binaryReader.ReadExString();
		n_HP = binaryReader.ReadInt32();
		n_SPEED = binaryReader.ReadInt32();
		n_ABILITY = binaryReader.ReadInt32();
		n_SKILL_1 = binaryReader.ReadInt32();
		n_SKILL_2 = binaryReader.ReadInt32();
		n_SKILL_3 = binaryReader.ReadInt32();
		n_INITIAL_SKILL1 = binaryReader.ReadInt32();
		n_INITIAL_SKILL2 = binaryReader.ReadInt32();
		n_INITIAL_SKILL3 = binaryReader.ReadInt32();
	}
}
