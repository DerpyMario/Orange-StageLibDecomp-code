using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class SCENARIO_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_GROUP,
		s_TALK,
		n_HEAD_TYPE,
		s_HEAD,
		n_EYE,
		n_MOUTH,
		n_LOCATION,
		n_FLIP,
		w_NAME,
		w_CONTENT,
		s_VOICE
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_GROUP { get; set; }

	[Preserve]
	public string s_TALK { get; set; }

	[Preserve]
	public int n_HEAD_TYPE { get; set; }

	[Preserve]
	public string s_HEAD { get; set; }

	[Preserve]
	public int n_EYE { get; set; }

	[Preserve]
	public int n_MOUTH { get; set; }

	[Preserve]
	public int n_LOCATION { get; set; }

	[Preserve]
	public int n_FLIP { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string w_CONTENT { get; set; }

	[Preserve]
	public string s_VOICE { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(SCENARIO_TABLE tbl)
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
		if (s_TALK != tbl.s_TALK)
		{
			dictionary.Add(2, s_TALK);
		}
		if (n_HEAD_TYPE != tbl.n_HEAD_TYPE)
		{
			dictionary.Add(3, n_HEAD_TYPE);
		}
		if (s_HEAD != tbl.s_HEAD)
		{
			dictionary.Add(4, s_HEAD);
		}
		if (n_EYE != tbl.n_EYE)
		{
			dictionary.Add(5, n_EYE);
		}
		if (n_MOUTH != tbl.n_MOUTH)
		{
			dictionary.Add(6, n_MOUTH);
		}
		if (n_LOCATION != tbl.n_LOCATION)
		{
			dictionary.Add(7, n_LOCATION);
		}
		if (n_FLIP != tbl.n_FLIP)
		{
			dictionary.Add(8, n_FLIP);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(9, w_NAME);
		}
		if (w_CONTENT != tbl.w_CONTENT)
		{
			dictionary.Add(10, w_CONTENT);
		}
		if (s_VOICE != tbl.s_VOICE)
		{
			dictionary.Add(11, s_VOICE);
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
				s_TALK = item.Value.ToString();
				break;
			case 3:
				n_HEAD_TYPE = Convert.ToInt32(item.Value);
				break;
			case 4:
				s_HEAD = item.Value.ToString();
				break;
			case 5:
				n_EYE = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_MOUTH = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_LOCATION = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_FLIP = Convert.ToInt32(item.Value);
				break;
			case 9:
				w_NAME = item.Value.ToString();
				break;
			case 10:
				w_CONTENT = item.Value.ToString();
				break;
			case 11:
				s_VOICE = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(SCENARIO_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_GROUP != table.n_GROUP)
		{
			return false;
		}
		if (s_TALK != table.s_TALK)
		{
			return false;
		}
		if (n_HEAD_TYPE != table.n_HEAD_TYPE)
		{
			return false;
		}
		if (s_HEAD != table.s_HEAD)
		{
			return false;
		}
		if (n_EYE != table.n_EYE)
		{
			return false;
		}
		if (n_MOUTH != table.n_MOUTH)
		{
			return false;
		}
		if (n_LOCATION != table.n_LOCATION)
		{
			return false;
		}
		if (n_FLIP != table.n_FLIP)
		{
			return false;
		}
		if (w_NAME != table.w_NAME)
		{
			return false;
		}
		if (w_CONTENT != table.w_CONTENT)
		{
			return false;
		}
		if (s_VOICE != table.s_VOICE)
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
		binaryWriter.WriteExString(s_TALK);
		binaryWriter.Write(n_HEAD_TYPE);
		binaryWriter.WriteExString(s_HEAD);
		binaryWriter.Write(n_EYE);
		binaryWriter.Write(n_MOUTH);
		binaryWriter.Write(n_LOCATION);
		binaryWriter.Write(n_FLIP);
		binaryWriter.WriteExString(w_NAME);
		binaryWriter.WriteExString(w_CONTENT);
		binaryWriter.WriteExString(s_VOICE);
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
		s_TALK = binaryReader.ReadExString();
		n_HEAD_TYPE = binaryReader.ReadInt32();
		s_HEAD = binaryReader.ReadExString();
		n_EYE = binaryReader.ReadInt32();
		n_MOUTH = binaryReader.ReadInt32();
		n_LOCATION = binaryReader.ReadInt32();
		n_FLIP = binaryReader.ReadInt32();
		w_NAME = binaryReader.ReadExString();
		w_CONTENT = binaryReader.ReadExString();
		s_VOICE = binaryReader.ReadExString();
	}
}
