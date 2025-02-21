using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class STAR_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TYPE,
		n_MAINID,
		n_STAR,
		n_MATERIAL,
		f_HP,
		f_ATK,
		f_DEF,
		s_IMG
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public int n_MAINID { get; set; }

	[Preserve]
	public int n_STAR { get; set; }

	[Preserve]
	public int n_MATERIAL { get; set; }

	[Preserve]
	public float f_HP { get; set; }

	[Preserve]
	public float f_ATK { get; set; }

	[Preserve]
	public float f_DEF { get; set; }

	[Preserve]
	public string s_IMG { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(STAR_TABLE tbl)
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
		if (n_MAINID != tbl.n_MAINID)
		{
			dictionary.Add(2, n_MAINID);
		}
		if (n_STAR != tbl.n_STAR)
		{
			dictionary.Add(3, n_STAR);
		}
		if (n_MATERIAL != tbl.n_MATERIAL)
		{
			dictionary.Add(4, n_MATERIAL);
		}
		if (f_HP != tbl.f_HP)
		{
			dictionary.Add(5, f_HP);
		}
		if (f_ATK != tbl.f_ATK)
		{
			dictionary.Add(6, f_ATK);
		}
		if (f_DEF != tbl.f_DEF)
		{
			dictionary.Add(7, f_DEF);
		}
		if (s_IMG != tbl.s_IMG)
		{
			dictionary.Add(8, s_IMG);
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
				n_MAINID = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_STAR = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_MATERIAL = Convert.ToInt32(item.Value);
				break;
			case 5:
				f_HP = Convert.ToSingle(item.Value);
				break;
			case 6:
				f_ATK = Convert.ToSingle(item.Value);
				break;
			case 7:
				f_DEF = Convert.ToSingle(item.Value);
				break;
			case 8:
				s_IMG = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(STAR_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (n_MAINID != table.n_MAINID)
		{
			return false;
		}
		if (n_STAR != table.n_STAR)
		{
			return false;
		}
		if (n_MATERIAL != table.n_MATERIAL)
		{
			return false;
		}
		if (f_HP != table.f_HP)
		{
			return false;
		}
		if (f_ATK != table.f_ATK)
		{
			return false;
		}
		if (f_DEF != table.f_DEF)
		{
			return false;
		}
		if (s_IMG != table.s_IMG)
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
		binaryWriter.Write(n_MAINID);
		binaryWriter.Write(n_STAR);
		binaryWriter.Write(n_MATERIAL);
		binaryWriter.Write(f_HP);
		binaryWriter.Write(f_ATK);
		binaryWriter.Write(f_DEF);
		binaryWriter.WriteExString(s_IMG);
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
		n_MAINID = binaryReader.ReadInt32();
		n_STAR = binaryReader.ReadInt32();
		n_MATERIAL = binaryReader.ReadInt32();
		f_HP = binaryReader.ReadSingle();
		f_ATK = binaryReader.ReadSingle();
		f_DEF = binaryReader.ReadSingle();
		s_IMG = binaryReader.ReadExString();
	}
}
