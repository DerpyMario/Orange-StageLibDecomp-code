using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OrangeDataProvider;

[Preserve]
public class SKILL_TABLE : CapTableBase
{
	private enum eSerial
	{
		n_ID,
		s_NAME,
		s_ICON,
		s_SHOWCASE,
		n_LVMAX,
		n_USE_TYPE,
		n_RELOAD,
		n_FIRE_SPEED,
		n_MAGAZINE,
		n_TRIGGER,
		n_TRIGGER_RATE,
		n_TRIGGER_X,
		n_TRIGGER_Y,
		n_TRIGGER_Z,
		n_CHARGE,
		n_CHARGE_MAX_LEVEL,
		n_TYPE,
		s_MODEL,
		n_FLAG,
		n_SHOTLINE,
		s_CONTI,
		s_FIELD,
		f_ENERGY_RATE,
		n_MAGAZINE_TYPE,
		n_NUM_SHOOT,
		n_USE_COST,
		f_ANGLE,
		n_SPEED,
		f_DISTANCE,
		n_TARGET,
		f_RANGE,
		n_AMOUNT,
		n_BULLET_HP,
		n_TRACKING,
		s_REBOUND,
		n_ROLLBACK,
		n_HITBACK,
		n_THROUGH,
		n_THROUGH_DAMAGE,
		n_MOTION_DEF,
		n_DAMAGE_COUNT,
		n_EFFECT,
		f_EFFECT_X,
		f_EFFECT_Y,
		f_EFFECT_Z,
		n_CONDITION_RATE,
		n_CONDITION_TARGET,
		n_CONDITION_ID,
		s_COMBO,
		f_COMBO,
		n_COMBO_SKILL,
		n_LINK_SKILL,
		n_USE_DEFAULT_WEAPON,
		s_USE_MOTION,
		s_CHARGE_FX,
		s_CHARGESWITCH_FX,
		s_USE_FX,
		n_USE_FX_FOLLOW,
		s_HIT_FX,
		s_VANISH_FX,
		s_USE_SE,
		s_HIT_SE,
		s_HIT_BLOCK_SE,
		w_NAME,
		w_TIP,
		s_START_VERSION,
		s_END_VERSION
	}

	[Preserve]
	public int n_ID { get; set; }

	[Preserve]
	public string s_NAME { get; set; }

	[Preserve]
	public string s_ICON { get; set; }

	[Preserve]
	public string s_SHOWCASE { get; set; }

	[Preserve]
	public int n_LVMAX { get; set; }

	[Preserve]
	public int n_USE_TYPE { get; set; }

	[Preserve]
	public int n_RELOAD { get; set; }

	[Preserve]
	public int n_FIRE_SPEED { get; set; }

	[Preserve]
	public int n_MAGAZINE { get; set; }

	[Preserve]
	public int n_TRIGGER { get; set; }

	[Preserve]
	public int n_TRIGGER_RATE { get; set; }

	[Preserve]
	public int n_TRIGGER_X { get; set; }

	[Preserve]
	public int n_TRIGGER_Y { get; set; }

	[Preserve]
	public int n_TRIGGER_Z { get; set; }

	[Preserve]
	public int n_CHARGE { get; set; }

	[Preserve]
	public int n_CHARGE_MAX_LEVEL { get; set; }

	[Preserve]
	public int n_TYPE { get; set; }

	[Preserve]
	public string s_MODEL { get; set; }

	[Preserve]
	public int n_FLAG { get; set; }

	[Preserve]
	public int n_SHOTLINE { get; set; }

	[Preserve]
	public string s_CONTI { get; set; }

	[Preserve]
	public string s_FIELD { get; set; }

	[Preserve]
	public float f_ENERGY_RATE { get; set; }

	[Preserve]
	public int n_MAGAZINE_TYPE { get; set; }

	[Preserve]
	public int n_NUM_SHOOT { get; set; }

	[Preserve]
	public int n_USE_COST { get; set; }

	[Preserve]
	public float f_ANGLE { get; set; }

	[Preserve]
	public int n_SPEED { get; set; }

	[Preserve]
	public float f_DISTANCE { get; set; }

	[Preserve]
	public int n_TARGET { get; set; }

	[Preserve]
	public float f_RANGE { get; set; }

	[Preserve]
	public int n_AMOUNT { get; set; }

	[Preserve]
	public int n_BULLET_HP { get; set; }

	[Preserve]
	public int n_TRACKING { get; set; }

	[Preserve]
	public string s_REBOUND { get; set; }

	[Preserve]
	public int n_ROLLBACK { get; set; }

	[Preserve]
	public int n_HITBACK { get; set; }

	[Preserve]
	public int n_THROUGH { get; set; }

	[Preserve]
	public int n_THROUGH_DAMAGE { get; set; }

	[Preserve]
	public int n_MOTION_DEF { get; set; }

	[Preserve]
	public int n_DAMAGE_COUNT { get; set; }

	[Preserve]
	public int n_EFFECT { get; set; }

	[Preserve]
	public float f_EFFECT_X { get; set; }

	[Preserve]
	public float f_EFFECT_Y { get; set; }

	[Preserve]
	public float f_EFFECT_Z { get; set; }

	[Preserve]
	public int n_CONDITION_RATE { get; set; }

	[Preserve]
	public int n_CONDITION_TARGET { get; set; }

	[Preserve]
	public int n_CONDITION_ID { get; set; }

	[Preserve]
	public string s_COMBO { get; set; }

	[Preserve]
	public float f_COMBO { get; set; }

	[Preserve]
	public int n_COMBO_SKILL { get; set; }

	[Preserve]
	public int n_LINK_SKILL { get; set; }

	[Preserve]
	public int n_USE_DEFAULT_WEAPON { get; set; }

	[Preserve]
	public string s_USE_MOTION { get; set; }

	[Preserve]
	public string s_CHARGE_FX { get; set; }

	[Preserve]
	public string s_CHARGESWITCH_FX { get; set; }

	[Preserve]
	public string s_USE_FX { get; set; }

	[Preserve]
	public int n_USE_FX_FOLLOW { get; set; }

	[Preserve]
	public string s_HIT_FX { get; set; }

	[Preserve]
	public string s_VANISH_FX { get; set; }

	[Preserve]
	public string s_USE_SE { get; set; }

	[Preserve]
	public string s_HIT_SE { get; set; }

	[Preserve]
	public string s_HIT_BLOCK_SE { get; set; }

	[Preserve]
	public string w_NAME { get; set; }

	[Preserve]
	public string w_TIP { get; set; }

	[Preserve]
	public string s_START_VERSION { get; set; }

	[Preserve]
	public string s_END_VERSION { get; set; }

	public Dictionary<int, object> MakeDiffDictionary(SKILL_TABLE tbl)
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
		if (s_SHOWCASE != tbl.s_SHOWCASE)
		{
			dictionary.Add(3, s_SHOWCASE);
		}
		if (n_LVMAX != tbl.n_LVMAX)
		{
			dictionary.Add(4, n_LVMAX);
		}
		if (n_USE_TYPE != tbl.n_USE_TYPE)
		{
			dictionary.Add(5, n_USE_TYPE);
		}
		if (n_RELOAD != tbl.n_RELOAD)
		{
			dictionary.Add(6, n_RELOAD);
		}
		if (n_FIRE_SPEED != tbl.n_FIRE_SPEED)
		{
			dictionary.Add(7, n_FIRE_SPEED);
		}
		if (n_MAGAZINE != tbl.n_MAGAZINE)
		{
			dictionary.Add(8, n_MAGAZINE);
		}
		if (n_TRIGGER != tbl.n_TRIGGER)
		{
			dictionary.Add(9, n_TRIGGER);
		}
		if (n_TRIGGER_RATE != tbl.n_TRIGGER_RATE)
		{
			dictionary.Add(10, n_TRIGGER_RATE);
		}
		if (n_TRIGGER_X != tbl.n_TRIGGER_X)
		{
			dictionary.Add(11, n_TRIGGER_X);
		}
		if (n_TRIGGER_Y != tbl.n_TRIGGER_Y)
		{
			dictionary.Add(12, n_TRIGGER_Y);
		}
		if (n_TRIGGER_Z != tbl.n_TRIGGER_Z)
		{
			dictionary.Add(13, n_TRIGGER_Z);
		}
		if (n_CHARGE != tbl.n_CHARGE)
		{
			dictionary.Add(14, n_CHARGE);
		}
		if (n_CHARGE_MAX_LEVEL != tbl.n_CHARGE_MAX_LEVEL)
		{
			dictionary.Add(15, n_CHARGE_MAX_LEVEL);
		}
		if (n_TYPE != tbl.n_TYPE)
		{
			dictionary.Add(16, n_TYPE);
		}
		if (s_MODEL != tbl.s_MODEL)
		{
			dictionary.Add(17, s_MODEL);
		}
		if (n_FLAG != tbl.n_FLAG)
		{
			dictionary.Add(18, n_FLAG);
		}
		if (n_SHOTLINE != tbl.n_SHOTLINE)
		{
			dictionary.Add(19, n_SHOTLINE);
		}
		if (s_CONTI != tbl.s_CONTI)
		{
			dictionary.Add(20, s_CONTI);
		}
		if (s_FIELD != tbl.s_FIELD)
		{
			dictionary.Add(21, s_FIELD);
		}
		if (f_ENERGY_RATE != tbl.f_ENERGY_RATE)
		{
			dictionary.Add(22, f_ENERGY_RATE);
		}
		if (n_MAGAZINE_TYPE != tbl.n_MAGAZINE_TYPE)
		{
			dictionary.Add(23, n_MAGAZINE_TYPE);
		}
		if (n_NUM_SHOOT != tbl.n_NUM_SHOOT)
		{
			dictionary.Add(24, n_NUM_SHOOT);
		}
		if (n_USE_COST != tbl.n_USE_COST)
		{
			dictionary.Add(25, n_USE_COST);
		}
		if (f_ANGLE != tbl.f_ANGLE)
		{
			dictionary.Add(26, f_ANGLE);
		}
		if (n_SPEED != tbl.n_SPEED)
		{
			dictionary.Add(27, n_SPEED);
		}
		if (f_DISTANCE != tbl.f_DISTANCE)
		{
			dictionary.Add(28, f_DISTANCE);
		}
		if (n_TARGET != tbl.n_TARGET)
		{
			dictionary.Add(29, n_TARGET);
		}
		if (f_RANGE != tbl.f_RANGE)
		{
			dictionary.Add(30, f_RANGE);
		}
		if (n_AMOUNT != tbl.n_AMOUNT)
		{
			dictionary.Add(31, n_AMOUNT);
		}
		if (n_BULLET_HP != tbl.n_BULLET_HP)
		{
			dictionary.Add(32, n_BULLET_HP);
		}
		if (n_TRACKING != tbl.n_TRACKING)
		{
			dictionary.Add(33, n_TRACKING);
		}
		if (s_REBOUND != tbl.s_REBOUND)
		{
			dictionary.Add(34, s_REBOUND);
		}
		if (n_ROLLBACK != tbl.n_ROLLBACK)
		{
			dictionary.Add(35, n_ROLLBACK);
		}
		if (n_HITBACK != tbl.n_HITBACK)
		{
			dictionary.Add(36, n_HITBACK);
		}
		if (n_THROUGH != tbl.n_THROUGH)
		{
			dictionary.Add(37, n_THROUGH);
		}
		if (n_THROUGH_DAMAGE != tbl.n_THROUGH_DAMAGE)
		{
			dictionary.Add(38, n_THROUGH_DAMAGE);
		}
		if (n_MOTION_DEF != tbl.n_MOTION_DEF)
		{
			dictionary.Add(39, n_MOTION_DEF);
		}
		if (n_DAMAGE_COUNT != tbl.n_DAMAGE_COUNT)
		{
			dictionary.Add(40, n_DAMAGE_COUNT);
		}
		if (n_EFFECT != tbl.n_EFFECT)
		{
			dictionary.Add(41, n_EFFECT);
		}
		if (f_EFFECT_X != tbl.f_EFFECT_X)
		{
			dictionary.Add(42, f_EFFECT_X);
		}
		if (f_EFFECT_Y != tbl.f_EFFECT_Y)
		{
			dictionary.Add(43, f_EFFECT_Y);
		}
		if (f_EFFECT_Z != tbl.f_EFFECT_Z)
		{
			dictionary.Add(44, f_EFFECT_Z);
		}
		if (n_CONDITION_RATE != tbl.n_CONDITION_RATE)
		{
			dictionary.Add(45, n_CONDITION_RATE);
		}
		if (n_CONDITION_TARGET != tbl.n_CONDITION_TARGET)
		{
			dictionary.Add(46, n_CONDITION_TARGET);
		}
		if (n_CONDITION_ID != tbl.n_CONDITION_ID)
		{
			dictionary.Add(47, n_CONDITION_ID);
		}
		if (s_COMBO != tbl.s_COMBO)
		{
			dictionary.Add(48, s_COMBO);
		}
		if (f_COMBO != tbl.f_COMBO)
		{
			dictionary.Add(49, f_COMBO);
		}
		if (n_COMBO_SKILL != tbl.n_COMBO_SKILL)
		{
			dictionary.Add(50, n_COMBO_SKILL);
		}
		if (n_LINK_SKILL != tbl.n_LINK_SKILL)
		{
			dictionary.Add(51, n_LINK_SKILL);
		}
		if (n_USE_DEFAULT_WEAPON != tbl.n_USE_DEFAULT_WEAPON)
		{
			dictionary.Add(52, n_USE_DEFAULT_WEAPON);
		}
		if (s_USE_MOTION != tbl.s_USE_MOTION)
		{
			dictionary.Add(53, s_USE_MOTION);
		}
		if (s_CHARGE_FX != tbl.s_CHARGE_FX)
		{
			dictionary.Add(54, s_CHARGE_FX);
		}
		if (s_CHARGESWITCH_FX != tbl.s_CHARGESWITCH_FX)
		{
			dictionary.Add(55, s_CHARGESWITCH_FX);
		}
		if (s_USE_FX != tbl.s_USE_FX)
		{
			dictionary.Add(56, s_USE_FX);
		}
		if (n_USE_FX_FOLLOW != tbl.n_USE_FX_FOLLOW)
		{
			dictionary.Add(57, n_USE_FX_FOLLOW);
		}
		if (s_HIT_FX != tbl.s_HIT_FX)
		{
			dictionary.Add(58, s_HIT_FX);
		}
		if (s_VANISH_FX != tbl.s_VANISH_FX)
		{
			dictionary.Add(59, s_VANISH_FX);
		}
		if (s_USE_SE != tbl.s_USE_SE)
		{
			dictionary.Add(60, s_USE_SE);
		}
		if (s_HIT_SE != tbl.s_HIT_SE)
		{
			dictionary.Add(61, s_HIT_SE);
		}
		if (s_HIT_BLOCK_SE != tbl.s_HIT_BLOCK_SE)
		{
			dictionary.Add(62, s_HIT_BLOCK_SE);
		}
		if (w_NAME != tbl.w_NAME)
		{
			dictionary.Add(63, w_NAME);
		}
		if (w_TIP != tbl.w_TIP)
		{
			dictionary.Add(64, w_TIP);
		}
		if (s_START_VERSION != tbl.s_START_VERSION)
		{
			dictionary.Add(65, s_START_VERSION);
		}
		if (s_END_VERSION != tbl.s_END_VERSION)
		{
			dictionary.Add(66, s_END_VERSION);
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
				s_SHOWCASE = item.Value.ToString();
				break;
			case 4:
				n_LVMAX = Convert.ToInt32(item.Value);
				break;
			case 5:
				n_USE_TYPE = Convert.ToInt32(item.Value);
				break;
			case 6:
				n_RELOAD = Convert.ToInt32(item.Value);
				break;
			case 7:
				n_FIRE_SPEED = Convert.ToInt32(item.Value);
				break;
			case 8:
				n_MAGAZINE = Convert.ToInt32(item.Value);
				break;
			case 9:
				n_TRIGGER = Convert.ToInt32(item.Value);
				break;
			case 10:
				n_TRIGGER_RATE = Convert.ToInt32(item.Value);
				break;
			case 11:
				n_TRIGGER_X = Convert.ToInt32(item.Value);
				break;
			case 12:
				n_TRIGGER_Y = Convert.ToInt32(item.Value);
				break;
			case 13:
				n_TRIGGER_Z = Convert.ToInt32(item.Value);
				break;
			case 14:
				n_CHARGE = Convert.ToInt32(item.Value);
				break;
			case 15:
				n_CHARGE_MAX_LEVEL = Convert.ToInt32(item.Value);
				break;
			case 16:
				n_TYPE = Convert.ToInt32(item.Value);
				break;
			case 17:
				s_MODEL = item.Value.ToString();
				break;
			case 18:
				n_FLAG = Convert.ToInt32(item.Value);
				break;
			case 19:
				n_SHOTLINE = Convert.ToInt32(item.Value);
				break;
			case 20:
				s_CONTI = item.Value.ToString();
				break;
			case 21:
				s_FIELD = item.Value.ToString();
				break;
			case 22:
				f_ENERGY_RATE = Convert.ToSingle(item.Value);
				break;
			case 23:
				n_MAGAZINE_TYPE = Convert.ToInt32(item.Value);
				break;
			case 24:
				n_NUM_SHOOT = Convert.ToInt32(item.Value);
				break;
			case 25:
				n_USE_COST = Convert.ToInt32(item.Value);
				break;
			case 26:
				f_ANGLE = Convert.ToSingle(item.Value);
				break;
			case 27:
				n_SPEED = Convert.ToInt32(item.Value);
				break;
			case 28:
				f_DISTANCE = Convert.ToSingle(item.Value);
				break;
			case 29:
				n_TARGET = Convert.ToInt32(item.Value);
				break;
			case 30:
				f_RANGE = Convert.ToSingle(item.Value);
				break;
			case 31:
				n_AMOUNT = Convert.ToInt32(item.Value);
				break;
			case 32:
				n_BULLET_HP = Convert.ToInt32(item.Value);
				break;
			case 33:
				n_TRACKING = Convert.ToInt32(item.Value);
				break;
			case 34:
				s_REBOUND = item.Value.ToString();
				break;
			case 35:
				n_ROLLBACK = Convert.ToInt32(item.Value);
				break;
			case 36:
				n_HITBACK = Convert.ToInt32(item.Value);
				break;
			case 37:
				n_THROUGH = Convert.ToInt32(item.Value);
				break;
			case 38:
				n_THROUGH_DAMAGE = Convert.ToInt32(item.Value);
				break;
			case 39:
				n_MOTION_DEF = Convert.ToInt32(item.Value);
				break;
			case 40:
				n_DAMAGE_COUNT = Convert.ToInt32(item.Value);
				break;
			case 41:
				n_EFFECT = Convert.ToInt32(item.Value);
				break;
			case 42:
				f_EFFECT_X = Convert.ToSingle(item.Value);
				break;
			case 43:
				f_EFFECT_Y = Convert.ToSingle(item.Value);
				break;
			case 44:
				f_EFFECT_Z = Convert.ToSingle(item.Value);
				break;
			case 45:
				n_CONDITION_RATE = Convert.ToInt32(item.Value);
				break;
			case 46:
				n_CONDITION_TARGET = Convert.ToInt32(item.Value);
				break;
			case 47:
				n_CONDITION_ID = Convert.ToInt32(item.Value);
				break;
			case 48:
				s_COMBO = item.Value.ToString();
				break;
			case 49:
				f_COMBO = Convert.ToSingle(item.Value);
				break;
			case 50:
				n_COMBO_SKILL = Convert.ToInt32(item.Value);
				break;
			case 51:
				n_LINK_SKILL = Convert.ToInt32(item.Value);
				break;
			case 52:
				n_USE_DEFAULT_WEAPON = Convert.ToInt32(item.Value);
				break;
			case 53:
				s_USE_MOTION = item.Value.ToString();
				break;
			case 54:
				s_CHARGE_FX = item.Value.ToString();
				break;
			case 55:
				s_CHARGESWITCH_FX = item.Value.ToString();
				break;
			case 56:
				s_USE_FX = item.Value.ToString();
				break;
			case 57:
				n_USE_FX_FOLLOW = Convert.ToInt32(item.Value);
				break;
			case 58:
				s_HIT_FX = item.Value.ToString();
				break;
			case 59:
				s_VANISH_FX = item.Value.ToString();
				break;
			case 60:
				s_USE_SE = item.Value.ToString();
				break;
			case 61:
				s_HIT_SE = item.Value.ToString();
				break;
			case 62:
				s_HIT_BLOCK_SE = item.Value.ToString();
				break;
			case 63:
				w_NAME = item.Value.ToString();
				break;
			case 64:
				w_TIP = item.Value.ToString();
				break;
			case 65:
				s_START_VERSION = item.Value.ToString();
				break;
			case 66:
				s_END_VERSION = item.Value.ToString();
				break;
			}
		}
	}

	public bool EqualValue(SKILL_TABLE table)
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
		if (s_SHOWCASE != table.s_SHOWCASE)
		{
			return false;
		}
		if (n_LVMAX != table.n_LVMAX)
		{
			return false;
		}
		if (n_USE_TYPE != table.n_USE_TYPE)
		{
			return false;
		}
		if (n_RELOAD != table.n_RELOAD)
		{
			return false;
		}
		if (n_FIRE_SPEED != table.n_FIRE_SPEED)
		{
			return false;
		}
		if (n_MAGAZINE != table.n_MAGAZINE)
		{
			return false;
		}
		if (n_TRIGGER != table.n_TRIGGER)
		{
			return false;
		}
		if (n_TRIGGER_RATE != table.n_TRIGGER_RATE)
		{
			return false;
		}
		if (n_TRIGGER_X != table.n_TRIGGER_X)
		{
			return false;
		}
		if (n_TRIGGER_Y != table.n_TRIGGER_Y)
		{
			return false;
		}
		if (n_TRIGGER_Z != table.n_TRIGGER_Z)
		{
			return false;
		}
		if (n_CHARGE != table.n_CHARGE)
		{
			return false;
		}
		if (n_CHARGE_MAX_LEVEL != table.n_CHARGE_MAX_LEVEL)
		{
			return false;
		}
		if (n_TYPE != table.n_TYPE)
		{
			return false;
		}
		if (s_MODEL != table.s_MODEL)
		{
			return false;
		}
		if (n_FLAG != table.n_FLAG)
		{
			return false;
		}
		if (n_SHOTLINE != table.n_SHOTLINE)
		{
			return false;
		}
		if (s_CONTI != table.s_CONTI)
		{
			return false;
		}
		if (s_FIELD != table.s_FIELD)
		{
			return false;
		}
		if (f_ENERGY_RATE != table.f_ENERGY_RATE)
		{
			return false;
		}
		if (n_MAGAZINE_TYPE != table.n_MAGAZINE_TYPE)
		{
			return false;
		}
		if (n_NUM_SHOOT != table.n_NUM_SHOOT)
		{
			return false;
		}
		if (n_USE_COST != table.n_USE_COST)
		{
			return false;
		}
		if (f_ANGLE != table.f_ANGLE)
		{
			return false;
		}
		if (n_SPEED != table.n_SPEED)
		{
			return false;
		}
		if (f_DISTANCE != table.f_DISTANCE)
		{
			return false;
		}
		if (n_TARGET != table.n_TARGET)
		{
			return false;
		}
		if (f_RANGE != table.f_RANGE)
		{
			return false;
		}
		if (n_AMOUNT != table.n_AMOUNT)
		{
			return false;
		}
		if (n_BULLET_HP != table.n_BULLET_HP)
		{
			return false;
		}
		if (n_TRACKING != table.n_TRACKING)
		{
			return false;
		}
		if (s_REBOUND != table.s_REBOUND)
		{
			return false;
		}
		if (n_ROLLBACK != table.n_ROLLBACK)
		{
			return false;
		}
		if (n_HITBACK != table.n_HITBACK)
		{
			return false;
		}
		if (n_THROUGH != table.n_THROUGH)
		{
			return false;
		}
		if (n_THROUGH_DAMAGE != table.n_THROUGH_DAMAGE)
		{
			return false;
		}
		if (n_MOTION_DEF != table.n_MOTION_DEF)
		{
			return false;
		}
		if (n_DAMAGE_COUNT != table.n_DAMAGE_COUNT)
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
		if (n_CONDITION_RATE != table.n_CONDITION_RATE)
		{
			return false;
		}
		if (n_CONDITION_TARGET != table.n_CONDITION_TARGET)
		{
			return false;
		}
		if (n_CONDITION_ID != table.n_CONDITION_ID)
		{
			return false;
		}
		if (s_COMBO != table.s_COMBO)
		{
			return false;
		}
		if (f_COMBO != table.f_COMBO)
		{
			return false;
		}
		if (n_COMBO_SKILL != table.n_COMBO_SKILL)
		{
			return false;
		}
		if (n_LINK_SKILL != table.n_LINK_SKILL)
		{
			return false;
		}
		if (n_USE_DEFAULT_WEAPON != table.n_USE_DEFAULT_WEAPON)
		{
			return false;
		}
		if (s_USE_MOTION != table.s_USE_MOTION)
		{
			return false;
		}
		if (s_CHARGE_FX != table.s_CHARGE_FX)
		{
			return false;
		}
		if (s_CHARGESWITCH_FX != table.s_CHARGESWITCH_FX)
		{
			return false;
		}
		if (s_USE_FX != table.s_USE_FX)
		{
			return false;
		}
		if (n_USE_FX_FOLLOW != table.n_USE_FX_FOLLOW)
		{
			return false;
		}
		if (s_HIT_FX != table.s_HIT_FX)
		{
			return false;
		}
		if (s_VANISH_FX != table.s_VANISH_FX)
		{
			return false;
		}
		if (s_USE_SE != table.s_USE_SE)
		{
			return false;
		}
		if (s_HIT_SE != table.s_HIT_SE)
		{
			return false;
		}
		if (s_HIT_BLOCK_SE != table.s_HIT_BLOCK_SE)
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
		binaryWriter.WriteExString(s_NAME);
		binaryWriter.WriteExString(s_ICON);
		binaryWriter.WriteExString(s_SHOWCASE);
		binaryWriter.Write(n_LVMAX);
		binaryWriter.Write(n_USE_TYPE);
		binaryWriter.Write(n_RELOAD);
		binaryWriter.Write(n_FIRE_SPEED);
		binaryWriter.Write(n_MAGAZINE);
		binaryWriter.Write(n_TRIGGER);
		binaryWriter.Write(n_TRIGGER_RATE);
		binaryWriter.Write(n_TRIGGER_X);
		binaryWriter.Write(n_TRIGGER_Y);
		binaryWriter.Write(n_TRIGGER_Z);
		binaryWriter.Write(n_CHARGE);
		binaryWriter.Write(n_CHARGE_MAX_LEVEL);
		binaryWriter.Write(n_TYPE);
		binaryWriter.WriteExString(s_MODEL);
		binaryWriter.Write(n_FLAG);
		binaryWriter.Write(n_SHOTLINE);
		binaryWriter.WriteExString(s_CONTI);
		binaryWriter.WriteExString(s_FIELD);
		binaryWriter.Write(f_ENERGY_RATE);
		binaryWriter.Write(n_MAGAZINE_TYPE);
		binaryWriter.Write(n_NUM_SHOOT);
		binaryWriter.Write(n_USE_COST);
		binaryWriter.Write(f_ANGLE);
		binaryWriter.Write(n_SPEED);
		binaryWriter.Write(f_DISTANCE);
		binaryWriter.Write(n_TARGET);
		binaryWriter.Write(f_RANGE);
		binaryWriter.Write(n_AMOUNT);
		binaryWriter.Write(n_BULLET_HP);
		binaryWriter.Write(n_TRACKING);
		binaryWriter.WriteExString(s_REBOUND);
		binaryWriter.Write(n_ROLLBACK);
		binaryWriter.Write(n_HITBACK);
		binaryWriter.Write(n_THROUGH);
		binaryWriter.Write(n_THROUGH_DAMAGE);
		binaryWriter.Write(n_MOTION_DEF);
		binaryWriter.Write(n_DAMAGE_COUNT);
		binaryWriter.Write(n_EFFECT);
		binaryWriter.Write(f_EFFECT_X);
		binaryWriter.Write(f_EFFECT_Y);
		binaryWriter.Write(f_EFFECT_Z);
		binaryWriter.Write(n_CONDITION_RATE);
		binaryWriter.Write(n_CONDITION_TARGET);
		binaryWriter.Write(n_CONDITION_ID);
		binaryWriter.WriteExString(s_COMBO);
		binaryWriter.Write(f_COMBO);
		binaryWriter.Write(n_COMBO_SKILL);
		binaryWriter.Write(n_LINK_SKILL);
		binaryWriter.Write(n_USE_DEFAULT_WEAPON);
		binaryWriter.WriteExString(s_USE_MOTION);
		binaryWriter.WriteExString(s_CHARGE_FX);
		binaryWriter.WriteExString(s_CHARGESWITCH_FX);
		binaryWriter.WriteExString(s_USE_FX);
		binaryWriter.Write(n_USE_FX_FOLLOW);
		binaryWriter.WriteExString(s_HIT_FX);
		binaryWriter.WriteExString(s_VANISH_FX);
		binaryWriter.WriteExString(s_USE_SE);
		binaryWriter.WriteExString(s_HIT_SE);
		binaryWriter.WriteExString(s_HIT_BLOCK_SE);
		binaryWriter.WriteExString(w_NAME);
		binaryWriter.WriteExString(w_TIP);
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
		s_NAME = binaryReader.ReadExString();
		s_ICON = binaryReader.ReadExString();
		s_SHOWCASE = binaryReader.ReadExString();
		n_LVMAX = binaryReader.ReadInt32();
		n_USE_TYPE = binaryReader.ReadInt32();
		n_RELOAD = binaryReader.ReadInt32();
		n_FIRE_SPEED = binaryReader.ReadInt32();
		n_MAGAZINE = binaryReader.ReadInt32();
		n_TRIGGER = binaryReader.ReadInt32();
		n_TRIGGER_RATE = binaryReader.ReadInt32();
		n_TRIGGER_X = binaryReader.ReadInt32();
		n_TRIGGER_Y = binaryReader.ReadInt32();
		n_TRIGGER_Z = binaryReader.ReadInt32();
		n_CHARGE = binaryReader.ReadInt32();
		n_CHARGE_MAX_LEVEL = binaryReader.ReadInt32();
		n_TYPE = binaryReader.ReadInt32();
		s_MODEL = binaryReader.ReadExString();
		n_FLAG = binaryReader.ReadInt32();
		n_SHOTLINE = binaryReader.ReadInt32();
		s_CONTI = binaryReader.ReadExString();
		s_FIELD = binaryReader.ReadExString();
		f_ENERGY_RATE = binaryReader.ReadSingle();
		n_MAGAZINE_TYPE = binaryReader.ReadInt32();
		n_NUM_SHOOT = binaryReader.ReadInt32();
		n_USE_COST = binaryReader.ReadInt32();
		f_ANGLE = binaryReader.ReadSingle();
		n_SPEED = binaryReader.ReadInt32();
		f_DISTANCE = binaryReader.ReadSingle();
		n_TARGET = binaryReader.ReadInt32();
		f_RANGE = binaryReader.ReadSingle();
		n_AMOUNT = binaryReader.ReadInt32();
		n_BULLET_HP = binaryReader.ReadInt32();
		n_TRACKING = binaryReader.ReadInt32();
		s_REBOUND = binaryReader.ReadExString();
		n_ROLLBACK = binaryReader.ReadInt32();
		n_HITBACK = binaryReader.ReadInt32();
		n_THROUGH = binaryReader.ReadInt32();
		n_THROUGH_DAMAGE = binaryReader.ReadInt32();
		n_MOTION_DEF = binaryReader.ReadInt32();
		n_DAMAGE_COUNT = binaryReader.ReadInt32();
		n_EFFECT = binaryReader.ReadInt32();
		f_EFFECT_X = binaryReader.ReadSingle();
		f_EFFECT_Y = binaryReader.ReadSingle();
		f_EFFECT_Z = binaryReader.ReadSingle();
		n_CONDITION_RATE = binaryReader.ReadInt32();
		n_CONDITION_TARGET = binaryReader.ReadInt32();
		n_CONDITION_ID = binaryReader.ReadInt32();
		s_COMBO = binaryReader.ReadExString();
		f_COMBO = binaryReader.ReadSingle();
		n_COMBO_SKILL = binaryReader.ReadInt32();
		n_LINK_SKILL = binaryReader.ReadInt32();
		n_USE_DEFAULT_WEAPON = binaryReader.ReadInt32();
		s_USE_MOTION = binaryReader.ReadExString();
		s_CHARGE_FX = binaryReader.ReadExString();
		s_CHARGESWITCH_FX = binaryReader.ReadExString();
		s_USE_FX = binaryReader.ReadExString();
		n_USE_FX_FOLLOW = binaryReader.ReadInt32();
		s_HIT_FX = binaryReader.ReadExString();
		s_VANISH_FX = binaryReader.ReadExString();
		s_USE_SE = binaryReader.ReadExString();
		s_HIT_SE = binaryReader.ReadExString();
		s_HIT_BLOCK_SE = binaryReader.ReadExString();
		w_NAME = binaryReader.ReadExString();
		w_TIP = binaryReader.ReadExString();
		s_START_VERSION = binaryReader.ReadExString();
		s_END_VERSION = binaryReader.ReadExString();
	}
}
