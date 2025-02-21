using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class CONDITION_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		s_ICON,
		s_HIT_FX,
		s_DURING_FX,
		s_UICAMERA_FX,
		s_HIT_SE,
		n_IGNORE_HITSE,
		s_DURING_SE,
		n_EFFECT,
		f_EFFECT_X,
		f_EFFECT_Y,
		f_EFFECT_Z,
		n_STACK_RULE,
		n_MAX_STACK,
		n_MAX_TRIGGER,
		n_DURATION,
		n_NOT_REMOVABLE,
		n_LINK,
		n_REMOVE,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public string s_HIT_FX { get; set; }

	[Preserve]
	public string s_DURING_FX { get; set; }

	[Preserve]
	public string s_UICAMERA_FX { get; set; }

	[Preserve]
	public string s_HIT_SE { get; set; }

	[Preserve]
	public int n_IGNORE_HITSE { get; set; }

	[Preserve]
	public string s_DURING_SE { get; set; }

	[Preserve]
	public int n_EFFECT { get; set; }

	[Preserve]
	public float f_EFFECT_X { get; set; }

	[Preserve]
	public float f_EFFECT_Y { get; set; }

	[Preserve]
	public float f_EFFECT_Z { get; set; }

	[Preserve]
	public int n_STACK_RULE { get; set; }

	[Preserve]
	public int n_MAX_STACK { get; set; }

	[Preserve]
	public int n_MAX_TRIGGER { get; set; }

	[Preserve]
	public int n_DURATION { get; set; }

	[Preserve]
	public int n_NOT_REMOVABLE { get; set; }

	[Preserve]
	public int n_LINK { get; set; }

	[Preserve]
	public int n_REMOVE { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(CONDITION_TABLE tbl)
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
		if (s_ICON != tbl.s_ICON)
		{
			dictionary.Add(2, s_ICON);
		}
		if (s_HIT_FX != tbl.s_HIT_FX)
		{
			dictionary.Add(3, s_HIT_FX);
		}
		if (s_DURING_FX != tbl.s_DURING_FX)
		{
			dictionary.Add(4, s_DURING_FX);
		}
		if (s_UICAMERA_FX != tbl.s_UICAMERA_FX)
		{
			dictionary.Add(5, s_UICAMERA_FX);
		}
		if (s_HIT_SE != tbl.s_HIT_SE)
		{
			dictionary.Add(6, s_HIT_SE);
		}
		if (n_IGNORE_HITSE != tbl.n_IGNORE_HITSE)
		{
			dictionary.Add(7, n_IGNORE_HITSE);
		}
		if (s_DURING_SE != tbl.s_DURING_SE)
		{
			dictionary.Add(8, s_DURING_SE);
		}
		if (n_EFFECT != tbl.n_EFFECT)
		{
			dictionary.Add(9, n_EFFECT);
		}
		if (f_EFFECT_X != tbl.f_EFFECT_X)
		{
			dictionary.Add(10, f_EFFECT_X);
		}
		if (f_EFFECT_Y != tbl.f_EFFECT_Y)
		{
			dictionary.Add(11, f_EFFECT_Y);
		}
		if (f_EFFECT_Z != tbl.f_EFFECT_Z)
		{
			dictionary.Add(12, f_EFFECT_Z);
		}
		if (n_STACK_RULE != tbl.n_STACK_RULE)
		{
			dictionary.Add(13, n_STACK_RULE);
		}
		if (n_MAX_STACK != tbl.n_MAX_STACK)
		{
			dictionary.Add(14, n_MAX_STACK);
		}
		if (n_MAX_TRIGGER != tbl.n_MAX_TRIGGER)
		{
			dictionary.Add(15, n_MAX_TRIGGER);
		}
		if (n_DURATION != tbl.n_DURATION)
		{
			dictionary.Add(16, n_DURATION);
		}
		if (n_NOT_REMOVABLE != tbl.n_NOT_REMOVABLE)
		{
			dictionary.Add(17, n_NOT_REMOVABLE);
		}
		if (n_LINK != tbl.n_LINK)
		{
			dictionary.Add(18, n_LINK);
		}
		if (n_REMOVE != tbl.n_REMOVE)
		{
			dictionary.Add(19, n_REMOVE);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(20, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(21, s_END_VERSION);
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
				s_ICON = item.Value.ToString();
				break;
			case 3:
				s_HIT_FX = item.Value.ToString();
				break;
			case 4:
				s_DURING_FX = item.Value.ToString();
				break;
			case 5:
				s_UICAMERA_FX = item.Value.ToString();
				break;
			case 6:
				s_HIT_SE = item.Value.ToString();
				break;
			case 7:
				n_IGNORE_HITSE = Convert.ToInt32(item.Value);
				break;
			case 8:
				s_DURING_SE = item.Value.ToString();
				break;
			case 9:
				n_EFFECT = Convert.ToInt32(item.Value);
				break;
			case 10:
				f_EFFECT_X = Convert.ToSingle(item.Value);
				break;
			case 11:
				f_EFFECT_Y = Convert.ToSingle(item.Value);
				break;
			case 12:
				f_EFFECT_Z = Convert.ToSingle(item.Value);
				break;
			case 13:
				n_STACK_RULE = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_MAX_STACK = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_MAX_TRIGGER = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_DURATION = Convert.ToInt32(item.Value);
				break;
			case 17:
				n_NOT_REMOVABLE = Convert.ToInt32(item.Value);
				break;
			case 18:
				n_LINK = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_REMOVE = Convert.ToInt32(item.Value);
				break;
			case 20:
				s_START_VERSION = item.Value.ToString();
				break;
			case 21:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(CONDITION_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (s_ICON != table.s_ICON)
		{
			return false;
		}
		if (s_HIT_FX != table.s_HIT_FX)
		{
			return false;
		}
		if (s_DURING_FX != table.s_DURING_FX)
		{
			return false;
		}
		if (s_UICAMERA_FX != table.s_UICAMERA_FX)
		{
			return false;
		}
		if (s_HIT_SE != table.s_HIT_SE)
		{
			return false;
		}
		if (n_IGNORE_HITSE != table.n_IGNORE_HITSE)
		{
			return false;
		}
		if (s_DURING_SE != table.s_DURING_SE)
		{
			return false;
		}
		if (n_EFFECT != table.n_EFFECT)
		{
			return false;
		}
		if (f_EFFECT_X != table.f_EFFECT_X)
		{
			return false;
		}
		if (f_EFFECT_Y != table.f_EFFECT_Y)
		{
			return false;
		}
		if (f_EFFECT_Z != table.f_EFFECT_Z)
		{
			return false;
		}
		if (n_STACK_RULE != table.n_STACK_RULE)
		{
			return false;
		}
		if (n_MAX_STACK != table.n_MAX_STACK)
		{
			return false;
		}
		if (n_MAX_TRIGGER != table.n_MAX_TRIGGER)
		{
			return false;
		}
		if (n_DURATION != table.n_DURATION)
		{
			return false;
		}
		if (n_NOT_REMOVABLE != table.n_NOT_REMOVABLE)
		{
			return false;
		}
		if (n_LINK != table.n_LINK)
		{
			return false;
		}
		if (n_REMOVE != table.n_REMOVE)
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
		binaryWriter.Write(n_TYPE);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.WriteExString(s_HIT_FX);
		binaryWriter.WriteExString(s_DURING_FX);
		binaryWriter.WriteExString(s_UICAMERA_FX);
		binaryWriter.WriteExString(s_HIT_SE);
		binaryWriter.Write(n_IGNORE_HITSE);
		binaryWriter.WriteExString(s_DURING_SE);
		binaryWriter.Write(n_EFFECT);
		binaryWriter.Write(f_EFFECT_X);
		binaryWriter.Write(f_EFFECT_Y);
		binaryWriter.Write(f_EFFECT_Z);
		binaryWriter.Write(n_STACK_RULE);
		binaryWriter.Write(n_MAX_STACK);
		binaryWriter.Write(n_MAX_TRIGGER);
		binaryWriter.Write(n_DURATION);
		binaryWriter.Write(n_NOT_REMOVABLE);
		binaryWriter.Write(n_LINK);
		binaryWriter.Write(n_REMOVE);
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
		n_TYPE = binaryReader.ReadInt32();
		s_ICON = binaryReader.ReadExString();
		s_HIT_FX = binaryReader.ReadExString();
		s_DURING_FX = binaryReader.ReadExString();
		s_UICAMERA_FX = binaryReader.ReadExString();
		s_HIT_SE = binaryReader.ReadExString();
		n_IGNORE_HITSE = binaryReader.ReadInt32();
		s_DURING_SE = binaryReader.ReadExString();
		n_EFFECT = binaryReader.ReadInt32();
		f_EFFECT_X = binaryReader.ReadSingle();
		f_EFFECT_Y = binaryReader.ReadSingle();
		f_EFFECT_Z = binaryReader.ReadSingle();
		n_STACK_RULE = binaryReader.ReadInt32();
		n_MAX_STACK = binaryReader.ReadInt32();
		n_MAX_TRIGGER = binaryReader.ReadInt32();
		n_DURATION = binaryReader.ReadInt32();
		n_NOT_REMOVABLE = binaryReader.ReadInt32();
		n_LINK = binaryReader.ReadInt32();
		n_REMOVE = binaryReader.ReadInt32();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
