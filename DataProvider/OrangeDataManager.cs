using System.Collections.Generic;
using OrangeDataProvider;

[Preserve]
public class OrangeDataManager : ManagedSingleton<OrangeDataManager>
{
	public Dictionary<int, CHARACTER_TABLE> CHARACTER_TABLE_DICT;

	public Dictionary<int, WEAPON_TABLE> WEAPON_TABLE_DICT;

	public Dictionary<int, SKIN_TABLE> SKIN_TABLE_DICT;

	public Dictionary<int, CARD_TABLE> CARD_TABLE_DICT;

	public Dictionary<int, SKILL_TABLE> SKILL_TABLE_DICT;

	public Dictionary<int, CONDITION_TABLE> CONDITION_TABLE_DICT;

	public Dictionary<int, TRACKING_TABLE> TRACKING_TABLE_DICT;

	public Dictionary<int, RANDOMSKILL_TABLE> RANDOMSKILL_TABLE_DICT;

	public Dictionary<int, DNA_TABLE> DNA_TABLE_DICT;

	public Dictionary<int, EXP_TABLE> EXP_TABLE_DICT;

	public Dictionary<int, STAR_TABLE> STAR_TABLE_DICT;

	public Dictionary<int, UPGRADE_TABLE> UPGRADE_TABLE_DICT;

	public Dictionary<int, ITEM_TABLE> ITEM_TABLE_DICT;

	public Dictionary<int, HOWTOGET_TABLE> HOWTOGET_TABLE_DICT;

	public Dictionary<int, MATERIAL_TABLE> MATERIAL_TABLE_DICT;

	public Dictionary<int, RESEARCH_TABLE> RESEARCH_TABLE_DICT;

	public Dictionary<int, EQUIP_TABLE> EQUIP_TABLE_DICT;

	public Dictionary<int, SUIT_TABLE> SUIT_TABLE_DICT;

	public Dictionary<int, PET_TABLE> PET_TABLE_DICT;

	public Dictionary<int, DISC_TABLE> DISC_TABLE_DICT;

	public Dictionary<int, FS_TABLE> FS_TABLE_DICT;

	public Dictionary<int, STAGE_TABLE> STAGE_TABLE_DICT;

	public Dictionary<int, MOB_TABLE> MOB_TABLE_DICT;

	public Dictionary<int, STAGE_RULE_TABLE> STAGE_RULE_TABLE_DICT;

	public Dictionary<int, VEHICLE_TABLE> VEHICLE_TABLE_DICT;

	public Dictionary<int, GACHA_TABLE> GACHA_TABLE_DICT;

	public Dictionary<int, INITIAL_TABLE> INITIAL_TABLE_DICT;

	public Dictionary<int, BACKUP_TABLE> BACKUP_TABLE_DICT;

	public Dictionary<int, GALLERY_TABLE> GALLERY_TABLE_DICT;

	public Dictionary<int, GACHALIST_TABLE> GACHALIST_TABLE_DICT;

	public Dictionary<int, SHOP_TABLE> SHOP_TABLE_DICT;

	public Dictionary<int, SERVICE_TABLE> SERVICE_TABLE_DICT;

	public Dictionary<int, GUIDE_TABLE> GUIDE_TABLE_DICT;

	public Dictionary<int, BPGUIDE_TABLE> BPGUIDE_TABLE_DICT;

	public Dictionary<int, HUNTERRANK_TABLE> HUNTERRANK_TABLE_DICT;

	public Dictionary<int, BANNER_TABLE> BANNER_TABLE_DICT;

	public Dictionary<int, EVENT_TABLE> EVENT_TABLE_DICT;

	public Dictionary<int, BOXGACHA_TABLE> BOXGACHA_TABLE_DICT;

	public Dictionary<int, BOXGACHACONTENT_TABLE> BOXGACHACONTENT_TABLE_DICT;

	public Dictionary<int, LABOEVENT_TABLE> LABOEVENT_TABLE_DICT;

	public Dictionary<int, MISSION_TABLE> MISSION_TABLE_DICT;

	public Dictionary<int, PVP_REWARD_TABLE> PVP_REWARD_TABLE_DICT;

	public Dictionary<int, SCENARIO_TABLE> SCENARIO_TABLE_DICT;

	public Dictionary<int, TUTORIAL_TABLE> TUTORIAL_TABLE_DICT;

	public Dictionary<int, BUYSTEP_TABLE> BUYSTEP_TABLE_DICT;

	public Dictionary<int, CUSTOMIZE_TABLE> CUSTOMIZE_TABLE_DICT;

	public Dictionary<int, VIP_TABLE> VIP_TABLE_DICT;

	public Dictionary<int, EMOTICONS_GROUP_TABLE> EMOTICONS_GROUP_TABLE_DICT;

	public Dictionary<int, EMOTICONS_TABLE> EMOTICONS_TABLE_DICT;

	public Dictionary<int, GUILD_MAIN> GUILD_MAIN_DICT;

	public Dictionary<int, POWER_TABLE> POWER_TABLE_DICT;

	public Dictionary<int, ORE_TABLE> ORE_TABLE_DICT;

	public Dictionary<int, WANTED_TABLE> WANTED_TABLE_DICT;

	public Dictionary<int, WANTED_SUCCESS_TABLE> WANTED_SUCCESS_TABLE_DICT;

	public Dictionary<int, RECORD_TABLE> RECORD_TABLE_DICT;

	public Dictionary<int, RECORDGRID_TABLE> RECORDGRID_TABLE_DICT;

	public Dictionary<int, RANDOMLATTICE_TABLE> RANDOMLATTICE_TABLE_DICT;

	public Dictionary<int, AREA_TABLE> AREA_TABLE_DICT;

	public Dictionary<int, ABMANAGER_TABLE> ABMANAGER_TABLE_DICT;

	public Dictionary<int, BGM_TABLE> BGM_TABLE_DICT;

	public Dictionary<int, SYSTEMSE_TABLE> SYSTEMSE_TABLE_DICT;

	public Dictionary<int, CHARASE_TABLE> CHARASE_TABLE_DICT;

	public Dictionary<int, SKILLSE_TABLE> SKILLSE_TABLE_DICT;

	public Dictionary<int, WEAPONSE_TABLE> WEAPONSE_TABLE_DICT;

	public Dictionary<int, VOICE_TABLE> VOICE_TABLE_DICT;

	public Dictionary<int, CREDITS_TABLE> CREDITS_TABLE_DICT;

	public Dictionary<int, CREDITS_PRESET_TABLE> CREDITS_PRESET_TABLE_DICT;

	public Dictionary<int, CREDITS_FOLLOWMODE_TABLE> CREDITS_FOLLOWMODE_TABLE_DICT;

	private bool _initialized;

	public static CapDataReader Reader { get; set; }

	public override void Reset()
	{
		base.Reset();
		_initialized = false;
	}

	public override void Initialize()
	{
		if (!_initialized)
		{
			CHARACTER_TABLE_DICT = Reader.DeserializeTableToClass<int, CHARACTER_TABLE>("n_ID", "CHARACTER_TABLE");
			WEAPON_TABLE_DICT = Reader.DeserializeTableToClass<int, WEAPON_TABLE>("n_ID", "WEAPON_TABLE");
			SKIN_TABLE_DICT = Reader.DeserializeTableToClass<int, SKIN_TABLE>("n_ID", "SKIN_TABLE");
			CARD_TABLE_DICT = Reader.DeserializeTableToClass<int, CARD_TABLE>("n_ID", "CARD_TABLE");
			SKILL_TABLE_DICT = Reader.DeserializeTableToClass<int, SKILL_TABLE>("n_ID", "SKILL_TABLE");
			CONDITION_TABLE_DICT = Reader.DeserializeTableToClass<int, CONDITION_TABLE>("n_ID", "CONDITION_TABLE");
			TRACKING_TABLE_DICT = Reader.DeserializeTableToClass<int, TRACKING_TABLE>("n_ID", "TRACKING_TABLE");
			RANDOMSKILL_TABLE_DICT = Reader.DeserializeTableToClass<int, RANDOMSKILL_TABLE>("n_ID", "RANDOMSKILL_TABLE");
			DNA_TABLE_DICT = Reader.DeserializeTableToClass<int, DNA_TABLE>("n_ID", "DNA_TABLE");
			EXP_TABLE_DICT = Reader.DeserializeTableToClass<int, EXP_TABLE>("n_ID", "EXP_TABLE");
			STAR_TABLE_DICT = Reader.DeserializeTableToClass<int, STAR_TABLE>("n_ID", "STAR_TABLE");
			UPGRADE_TABLE_DICT = Reader.DeserializeTableToClass<int, UPGRADE_TABLE>("n_ID", "UPGRADE_TABLE");
			ITEM_TABLE_DICT = Reader.DeserializeTableToClass<int, ITEM_TABLE>("n_ID", "ITEM_TABLE");
			HOWTOGET_TABLE_DICT = Reader.DeserializeTableToClass<int, HOWTOGET_TABLE>("n_ID", "HOWTOGET_TABLE");
			MATERIAL_TABLE_DICT = Reader.DeserializeTableToClass<int, MATERIAL_TABLE>("n_ID", "MATERIAL_TABLE");
			RESEARCH_TABLE_DICT = Reader.DeserializeTableToClass<int, RESEARCH_TABLE>("n_ID", "RESEARCH_TABLE");
			EQUIP_TABLE_DICT = Reader.DeserializeTableToClass<int, EQUIP_TABLE>("n_ID", "EQUIP_TABLE");
			SUIT_TABLE_DICT = Reader.DeserializeTableToClass<int, SUIT_TABLE>("n_ID", "SUIT_TABLE");
			PET_TABLE_DICT = Reader.DeserializeTableToClass<int, PET_TABLE>("n_ID", "PET_TABLE");
			DISC_TABLE_DICT = Reader.DeserializeTableToClass<int, DISC_TABLE>("n_ID", "DISC_TABLE");
			FS_TABLE_DICT = Reader.DeserializeTableToClass<int, FS_TABLE>("n_ID", "FS_TABLE");
			STAGE_TABLE_DICT = Reader.DeserializeTableToClass<int, STAGE_TABLE>("n_ID", "STAGE_TABLE");
			MOB_TABLE_DICT = Reader.DeserializeTableToClass<int, MOB_TABLE>("n_ID", "MOB_TABLE");
			STAGE_RULE_TABLE_DICT = Reader.DeserializeTableToClass<int, STAGE_RULE_TABLE>("n_ID", "STAGE_RULE_TABLE");
			VEHICLE_TABLE_DICT = Reader.DeserializeTableToClass<int, VEHICLE_TABLE>("n_ID", "VEHICLE_TABLE");
			GACHA_TABLE_DICT = Reader.DeserializeTableToClass<int, GACHA_TABLE>("n_ID", "GACHA_TABLE");
			INITIAL_TABLE_DICT = Reader.DeserializeTableToClass<int, INITIAL_TABLE>("n_ID", "INITIAL_TABLE");
			BACKUP_TABLE_DICT = Reader.DeserializeTableToClass<int, BACKUP_TABLE>("n_ID", "BACKUP_TABLE");
			GALLERY_TABLE_DICT = Reader.DeserializeTableToClass<int, GALLERY_TABLE>("n_ID", "GALLERY_TABLE");
			GACHALIST_TABLE_DICT = Reader.DeserializeTableToClass<int, GACHALIST_TABLE>("n_ID", "GACHALIST_TABLE");
			SHOP_TABLE_DICT = Reader.DeserializeTableToClass<int, SHOP_TABLE>("n_ID", "SHOP_TABLE");
			SERVICE_TABLE_DICT = Reader.DeserializeTableToClass<int, SERVICE_TABLE>("n_ID", "SERVICE_TABLE");
			GUIDE_TABLE_DICT = Reader.DeserializeTableToClass<int, GUIDE_TABLE>("n_ID", "GUIDE_TABLE");
			BPGUIDE_TABLE_DICT = Reader.DeserializeTableToClass<int, BPGUIDE_TABLE>("n_ID", "BPGUIDE_TABLE");
			HUNTERRANK_TABLE_DICT = Reader.DeserializeTableToClass<int, HUNTERRANK_TABLE>("n_ID", "HUNTERRANK_TABLE");
			BANNER_TABLE_DICT = Reader.DeserializeTableToClass<int, BANNER_TABLE>("n_ID", "BANNER_TABLE");
			EVENT_TABLE_DICT = Reader.DeserializeTableToClass<int, EVENT_TABLE>("n_ID", "EVENT_TABLE");
			BOXGACHA_TABLE_DICT = Reader.DeserializeTableToClass<int, BOXGACHA_TABLE>("n_ID", "BOXGACHA_TABLE");
			BOXGACHACONTENT_TABLE_DICT = Reader.DeserializeTableToClass<int, BOXGACHACONTENT_TABLE>("n_ID", "BOXGACHACONTENT_TABLE");
			LABOEVENT_TABLE_DICT = Reader.DeserializeTableToClass<int, LABOEVENT_TABLE>("n_ID", "LABOEVENT_TABLE");
			MISSION_TABLE_DICT = Reader.DeserializeTableToClass<int, MISSION_TABLE>("n_ID", "MISSION_TABLE");
			PVP_REWARD_TABLE_DICT = Reader.DeserializeTableToClass<int, PVP_REWARD_TABLE>("n_ID", "PVP_REWARD_TABLE");
			SCENARIO_TABLE_DICT = Reader.DeserializeTableToClass<int, SCENARIO_TABLE>("n_ID", "SCENARIO_TABLE");
			TUTORIAL_TABLE_DICT = Reader.DeserializeTableToClass<int, TUTORIAL_TABLE>("n_ID", "TUTORIAL_TABLE");
			BUYSTEP_TABLE_DICT = Reader.DeserializeTableToClass<int, BUYSTEP_TABLE>("n_ID", "BUYSTEP_TABLE");
			CUSTOMIZE_TABLE_DICT = Reader.DeserializeTableToClass<int, CUSTOMIZE_TABLE>("n_ID", "CUSTOMIZE_TABLE");
			VIP_TABLE_DICT = Reader.DeserializeTableToClass<int, VIP_TABLE>("n_ID", "VIP_TABLE");
			EMOTICONS_GROUP_TABLE_DICT = Reader.DeserializeTableToClass<int, EMOTICONS_GROUP_TABLE>("n_ID", "EMOTICONS_GROUP_TABLE");
			EMOTICONS_TABLE_DICT = Reader.DeserializeTableToClass<int, EMOTICONS_TABLE>("n_ID", "EMOTICONS_TABLE");
			GUILD_MAIN_DICT = Reader.DeserializeTableToClass<int, GUILD_MAIN>("n_ID", "GUILD_MAIN");
			POWER_TABLE_DICT = Reader.DeserializeTableToClass<int, POWER_TABLE>("n_ID", "POWER_TABLE");
			ORE_TABLE_DICT = Reader.DeserializeTableToClass<int, ORE_TABLE>("n_ID", "ORE_TABLE");
			WANTED_TABLE_DICT = Reader.DeserializeTableToClass<int, WANTED_TABLE>("n_ID", "WANTED_TABLE");
			WANTED_SUCCESS_TABLE_DICT = Reader.DeserializeTableToClass<int, WANTED_SUCCESS_TABLE>("n_ID", "WANTED_SUCCESS_TABLE");
			RECORD_TABLE_DICT = Reader.DeserializeTableToClass<int, RECORD_TABLE>("n_ID", "RECORD_TABLE");
			RECORDGRID_TABLE_DICT = Reader.DeserializeTableToClass<int, RECORDGRID_TABLE>("n_ID", "RECORDGRID_TABLE");
			RANDOMLATTICE_TABLE_DICT = Reader.DeserializeTableToClass<int, RANDOMLATTICE_TABLE>("n_ID", "RANDOMLATTICE_TABLE");
			AREA_TABLE_DICT = Reader.DeserializeTableToClass<int, AREA_TABLE>("n_ID", "AREA_TABLE");
			ABMANAGER_TABLE_DICT = Reader.DeserializeTableToClass<int, ABMANAGER_TABLE>("n_ID", "ABMANAGER_TABLE");
			BGM_TABLE_DICT = Reader.DeserializeTableToClass<int, BGM_TABLE>("n_ID", "BGM_TABLE");
			SYSTEMSE_TABLE_DICT = Reader.DeserializeTableToClass<int, SYSTEMSE_TABLE>("n_ID", "SYSTEMSE_TABLE");
			CHARASE_TABLE_DICT = Reader.DeserializeTableToClass<int, CHARASE_TABLE>("n_ID", "CHARASE_TABLE");
			SKILLSE_TABLE_DICT = Reader.DeserializeTableToClass<int, SKILLSE_TABLE>("n_ID", "SKILLSE_TABLE");
			WEAPONSE_TABLE_DICT = Reader.DeserializeTableToClass<int, WEAPONSE_TABLE>("n_ID", "WEAPONSE_TABLE");
			VOICE_TABLE_DICT = Reader.DeserializeTableToClass<int, VOICE_TABLE>("n_ID", "VOICE_TABLE");
			CREDITS_TABLE_DICT = Reader.DeserializeTableToClass<int, CREDITS_TABLE>("n_ID", "CREDITS_TABLE");
			CREDITS_PRESET_TABLE_DICT = Reader.DeserializeTableToClass<int, CREDITS_PRESET_TABLE>("n_ID", "CREDITS_PRESET_TABLE");
			CREDITS_FOLLOWMODE_TABLE_DICT = Reader.DeserializeTableToClass<int, CREDITS_FOLLOWMODE_TABLE>("n_ID", "CREDITS_FOLLOWMODE_TABLE");
			_initialized = true;
		}
	}

	public override void Dispose()
	{
	}
}
