#define RELEASE
using System;
using System.Collections.Generic;
using System.Linq;
using Better;
using CallbackDefs;
using StageLib;
using UnityEngine;

public class EventManager : MonoBehaviourSingleton<EventManager>
{
	public enum ID
	{
		NONE,
		SWITCH_SCENE,
		SCENE_INIT,
		UPDATE_RENDER_WEAPON,
		UPDATE_RENDER_CHARACTER,
		SHOW_DAMAGE,
		UPDATE_DOWNLOAD_BAR,
		CAMERA_SHAKE,
		LOCAL_PLAYER_SPWAN,
		LOCAL_PLAYER_DESTROY,
		BATTLE_START,
		LOCK_RANGE,
		STAGE_PLAYER_SPWAN_ED,
		STAGE_PLAYER_DESTROY_ED,
		STAGE_FALLDOWN_PLAYER,
		STAGE_FALLDOWN_ENEMY,
		STAGE_REBORNEVENT,
		STAGE_END_REPORT,
		STAGE_UPDATE_HOST,
		STAGE_TELEPORT,
		STAGE_RESTART,
		BATTLE_INFO_UPDATE,
		STAGE_OBJ_TOUCHCB,
		STAGE_CAMERA_FOCUS,
		STAGE_DELETE_CHECK,
		STAGE_OBJ_CTRL,
		STAGE_EVENT_CALL,
		STAGE_EVENT_WARING,
		STAGE_SHOW_ENEMYINFO,
		STAGE_GENERATE_PVE_PLAYER,
		STAGE_REGISTER_PVP_SPAWNPOS,
		UI_UPDATEMAINSUBWEAPON,
		UI_UPDATESTAGEREWARD,
		STAGE_ALLOK,
		PLAYERBUILD_PLAYER_SPAWN,
		PLAYERBUILD_PLAYER_NETCTRLON,
		UPDATE_TOPBAR_DATA,
		STAGE_PLAYBGM,
		UI_CHARACTERINFO_CHARACTER_CHANGE,
		RT_UPDATE_WEAPON,
		UPDATE_BATTLE_POWER,
		UPDATE_HOMETOP_HINT,
		UPDATE_PLAYER_BOX,
		UPDATE_PLAYER_EQUIPMENT,
		STAGE_SKILL_ATK_TARGET,
		UI_RANKING_CHARACTER_CHANGE,
		UI_PLAYER_INFO_MAIN_WEAPON_CHANGE,
		UI_PLAYER_INFO_SUB_WEAPON_CHANGE,
		UPDATE_SHOP,
		STAGE_UPDATE_PLAYER_LIST,
		UPDATE_LOADING_PROGRESS,
		UPDATE_LOADING_EFT,
		UPDATE_FULL_LOADING_PROGRESS,
		GACHA_SKIP,
		UPDATE_HOMETOP_RENDER,
		STAGE_CONTINUE_PLATER,
		STAGE_BULLET_REGISTER,
		STAGE_BULLET_UNREGISTER,
		STAGE_PLAYER_INFLAG_RANGE,
		WEATHER_SYSTEM_INIT,
		WEATHER_SYSTEM_CTRL,
		UPDATE_SETTING,
		UPDATE_SCENE_PROGRESS,
		REGISTER_STAGE_PARAM,
		LOGIN_FAILED,
		PLAYER_LEVEL_UP,
		BACK_TO_HOMETOP,
		CHARACTER_RT_VISIBLE,
		GACHA_PRIZE_START,
		UI_CHARACTER_POS,
		CHARGE_STAMINA,
		UI_CHARACTERINFO_BONUS_COUNT,
		UPDATE_PLAYER_IDENTIFY,
		CHANGE_DAY,
		UPDATE_MAILBOX,
		LOGIN_CANCEL,
		UI_RESEARCH_COMPLETE_VOICE,
		UPDATE_STAGE_RES_PROGRESS,
		UPDATE_BANNER,
		SD_HOME_BGM,
		SD_BACK_BGM,
		LIBRARY_UPDATE_MAIN_UI,
		CLOSE_FX,
		STAGE_TIMESCALE_CHANGE,
		GAME_PAUSE,
		CHARACTER_RT_SUNSHINE,
		STAGE_OBJ_CTRL_SYNC_HP,
		STAGE_OBJ_CTRL_PET_ACTION,
		STAGE_OBJ_CTRL_ENEMY_ACTION,
		STAGE_OBJ_CTRL_PLAYSHOWANI,
		CHARACTER_RT_DIALOG,
		CAMERA_EFFECT_CTRL,
		PATCH_CHANGE,
		RT_UPDATE_CAMERA_FOV,
		TOGGLE_GUILD_SCENE_RENDER,
		UPDATE_HOMETOP_CANVAS,
		UPDATE_GUILD_HINT,
		UPDATE_RESOLUTION,
		UPDATE_FULLSCREEN,
		SOCKET_NOTIFY_NEW_CHATMESSAGE,
		GUILD_ID_CHANGED,
		STAGE_OBJ_CTRL_BULLET_ACTION,
		ENTER_OR_LEAVE_RIDE_ARMOR,
		REMOVE_DEAD_AREA_EVENT,
		LOCK_WALL_JUMP,
		STAGE_PLAYBGM_BEAT_SYNC,
		SHUTDOWN_OPERATION
	}

	public class RegisterStageParam
	{
		public int nMode;

		public int nStageSecert;
	}

	public class LockRangeParam
	{
		public int nMode;

		public float fMinX;

		public float fMaxX;

		public float fMinY;

		public float fMaxY;

		public int? nNoBack;

		public float? fSpeed;

		public bool? bSetFocus;

		public Vector3? vDir;

		public float? fOY;

		public bool bSlowWhenMove;
	}

	public class StageSkillAtkTargetParam
	{
		public Transform tTrans;

		public int nSkillID;

		public bool bAtkNoCast;

		public Vector3 tPos;

		public Vector3 tDir;

		public bool bBuff;

		public LayerMask tLM = BulletScriptableObject.Instance.BulletLayerMaskPlayer;
	}

	public class StageGeneratePlayer
	{
		public int nMode;

		public int nID;

		public int nSkinID;

		public string sPlayerID = "";

		public Vector3 vPos = Vector3.zero;

		public int nHP;

		public bool bLookDir;

		public int nCharacterID;

		public int WeaponCurrent;

		public int nMeasureNow;

		public bool bUsePassiveskill;

		public int HealHp;

		public int DmgHp;
	}

	public class StageCameraFocus
	{
		public bool bLock;

		public bool bRightNow;

		public bool bUnRange;

		public int nMode;

		public Vector3 roominpos;

		public float fRoomInTime;

		public float fRoomOutTime;

		public float fRoomInFov;

		public bool bDontPlayMotion;

		public bool bCallStageEnd = true;
	}

	public class StageEventCall
	{
		public int nID;

		public STAGE_EVENT nStageEvent;

		public Transform tTransform;
	}

	public class RemoveDeadAreaEvent
	{
		public OrangeCharacter tOC;
	}

	public class BattleInfoUpdate
	{
		public int nType;
	}

	private System.Collections.Generic.Dictionary<ID, List<CallbackObjs>> dictEvents = new Better.Dictionary<ID, List<CallbackObjs>>();

	[Obsolete("This API is expected to be removed and is not recommended.")]
	public void AttachEvent(ID p_eventId, CallbackObjs p_cb)
	{
		Debug.Log("AttachEvent:" + p_eventId);
		if (!dictEvents.TryGetValue(p_eventId, out var value))
		{
			value = new List<CallbackObjs>();
			dictEvents.Add(p_eventId, value);
		}
		value.Add(p_cb);
	}

	[Obsolete("This API is expected to be removed and is not recommended.")]
	public void DetachEvent(ID p_eventId, CallbackObjs p_cb)
	{
		Debug.Log("DetachEvent:" + p_eventId);
		if (dictEvents.TryGetValue(p_eventId, out var value))
		{
			CallbackObjs callbackObjs = value.Find((CallbackObjs x) => x == p_cb);
			if (callbackObjs != null)
			{
				value.Remove(callbackObjs);
				callbackObjs = null;
			}
		}
		else
		{
			Debug.LogWarning(string.Concat("DetachEvent:", p_eventId, "Failed, No Event Attached"));
		}
	}

	[Obsolete("This API is expected to be removed and is not recommended.")]
	public void NotifyEvent(ID p_eventId, params object[] p_param)
	{
		Debug.Log("NotifyEvent:" + p_eventId);
		if (dictEvents.TryGetValue(p_eventId, out var value))
		{
			foreach (CallbackObjs item in value.ToList())
			{
				item.CheckTargetToInvoke(p_param);
			}
			return;
		}
		Debug.LogWarning(string.Concat("NotifyEvent:", p_eventId, "Failed, No Event Attached"));
	}

	public void DetachAllEvent()
	{
		foreach (List<CallbackObjs> value in dictEvents.Values)
		{
			for (int i = 0; i < value.Count; i++)
			{
				value[i] = null;
			}
			value.Clear();
		}
		dictEvents.Clear();
	}

	protected override void OnDestroy()
	{
		DetachAllEvent();
		base.OnDestroy();
	}

	private void OnDisable()
	{
		DetachAllEvent();
	}
}
