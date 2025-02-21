using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class BPGUIDE_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		n_TOTAL_BP,
		n_WEAPON_LVUP,
		n_WEAPON_UPGRADE,
		n_EQUIP_MAIN,
		n_EQUIP_POWERUP,
		n_FS,
		n_DISC,
		n_DETECT_BP,
		n_DETECT_WEAPONBP
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public int n_TOTAL_BP { get; set; }

	[Preserve]
	public int n_WEAPON_LVUP { get; set; }

	[Preserve]
	public int n_WEAPON_UPGRADE { get; set; }

	[Preserve]
	public int n_EQUIP_MAIN { get; set; }

	[Preserve]
	public int n_EQUIP_POWERUP { get; set; }

	[Preserve]
	public int n_FS { get; set; }

	[Preserve]
	public int n_DISC { get; set; }

	[Preserve]
	public int n_DETECT_BP { get; set; }

	[Preserve]
	public int n_DETECT_WEAPONBP { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(BPGUIDE_TABLE tbl)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		if (n_ID != tbl.n_ID)
		{
			dictionary.Add(0, n_ID);
		}
		if (n_TOTAL_BP != tbl.n_TOTAL_BP)
		{
			dictionary.Add(1, n_TOTAL_BP);
		}
		if (n_WEAPON_LVUP != tbl.n_WEAPON_LVUP)
		{
			dictionary.Add(2, n_WEAPON_LVUP);
		}
		if (n_WEAPON_UPGRADE != tbl.n_WEAPON_UPGRADE)
		{
			dictionary.Add(3, n_WEAPON_UPGRADE);
		}
		if (n_EQUIP_MAIN != tbl.n_EQUIP_MAIN)
		{
			dictionary.Add(4, n_EQUIP_MAIN);
		}
		if (n_EQUIP_POWERUP != tbl.n_EQUIP_POWERUP)
		{
			dictionary.Add(5, n_EQUIP_POWERUP);
		}
		if (n_FS != tbl.n_FS)
		{
			dictionary.Add(6, n_FS);
		}
		if (n_DISC != tbl.n_DISC)
		{
			dictionary.Add(7, n_DISC);
		}
		if (n_DETECT_BP != tbl.n_DETECT_BP)
		{
			dictionary.Add(8, n_DETECT_BP);
		}
		if (n_DETECT_WEAPONBP != tbl.n_DETECT_WEAPONBP)
		{
			dictionary.Add(9, n_DETECT_WEAPONBP);
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
				n_TOTAL_BP = Convert.ToInt32(item.Value);
				break;
			case 2:
				n_WEAPON_LVUP = Convert.ToInt32(item.Value);
				break;
			case 3:
				n_WEAPON_UPGRADE = Convert.ToInt32(item.Value);
				break;
			case 4:
				n_EQUIP_MAIN = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_EQUIP_POWERUP = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_FS = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_DISC = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_DETECT_BP = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_DETECT_WEAPONBP = Convert.ToInt32(item.Value);
				break;
			}
		}
	}

	public bool EqualValue(BPGUIDE_TABLE table)
	{
		if (n_ID != table.n_ID)
		{
			return false;
		}
		if (n_TOTAL_BP != table.n_TOTAL_BP)
		{
			return false;
		}
		if (n_WEAPON_LVUP != table.n_WEAPON_LVUP)
		{
			return false;
		}
		if (n_WEAPON_UPGRADE != table.n_WEAPON_UPGRADE)
		{
			return false;
		}
		if (n_EQUIP_MAIN != table.n_EQUIP_MAIN)
		{
			return false;
		}
		if (n_EQUIP_POWERUP != table.n_EQUIP_POWERUP)
		{
			return false;
		}
		if (n_FS != table.n_FS)
		{
			return false;
		}
		if (n_DISC != table.n_DISC)
		{
			return false;
		}
		if (n_DETECT_BP != table.n_DETECT_BP)
		{
			return false;
		}
		if (n_DETECT_WEAPONBP != table.n_DETECT_WEAPONBP)
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
		binaryWriter.Write(n_TOTAL_BP);
		binaryWriter.Write(n_WEAPON_LVUP);
		binaryWriter.Write(n_WEAPON_UPGRADE);
		binaryWriter.Write(n_EQUIP_MAIN);
		binaryWriter.Write(n_EQUIP_POWERUP);
		binaryWriter.Write(n_FS);
		binaryWriter.Write(n_DISC);
		binaryWriter.Write(n_DETECT_BP);
		binaryWriter.Write(n_DETECT_WEAPONBP);
		byte[] bytes = memoryStream.ToArray();
		return Encoding.Unicode.GetString(bytes);
	}

	public void ConvertFromString(string src)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(src);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(bytes));
		binaryReader.BaseStream.Position = 0L;
		n_ID = binaryReader.ReadInt32();
		n_TOTAL_BP = binaryReader.ReadInt32();
		n_WEAPON_LVUP = binaryReader.ReadInt32();
		n_WEAPON_UPGRADE = binaryReader.ReadInt32();
		n_EQUIP_MAIN = binaryReader.ReadInt32();
		n_EQUIP_POWERUP = binaryReader.ReadInt32();
		n_FS = binaryReader.ReadInt32();
		n_DISC = binaryReader.ReadInt32();
		n_DETECT_BP = binaryReader.ReadInt32();
		n_DETECT_WEAPONBP = binaryReader.ReadInt32();
	}
}
