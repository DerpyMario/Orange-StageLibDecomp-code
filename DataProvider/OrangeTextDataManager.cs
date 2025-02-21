using System.Collections.Generic;
using OrangeDataProvider;

[Preserve]
public class OrangeTextDataManager : ManagedSingleton<OrangeTextDataManager>
{
	public Dictionary<string, LOCALIZATION_TABLE> LOCALIZATION_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> SKILLTEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> CHARATEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> WEAPONTEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> CARDTEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> SKINTEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> ITEMTEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> EQUIPTEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> DISCTEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> SCENARIOTEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> STAGETEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> MISSIONTEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> MAILTEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> HOWTOGETTEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> RECORDTIP_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> RANDOMNAME_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> TIP_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> WANTEDTEXT_TABLE_DICT;

	public Dictionary<string, LOCALIZATION_TABLE> AREATEXT_TABLE_DICT;

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
			LOCALIZATION_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "LOCALIZATION_TABLE");
			SKILLTEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "SKILLTEXT_TABLE");
			CHARATEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "CHARATEXT_TABLE");
			WEAPONTEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "WEAPONTEXT_TABLE");
			CARDTEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "CARDTEXT_TABLE");
			SKINTEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "SKINTEXT_TABLE");
			ITEMTEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "ITEMTEXT_TABLE");
			EQUIPTEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "EQUIPTEXT_TABLE");
			DISCTEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "DISCTEXT_TABLE");
			SCENARIOTEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "SCENARIOTEXT_TABLE");
			STAGETEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "STAGETEXT_TABLE");
			MISSIONTEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "MISSIONTEXT_TABLE");
			MAILTEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "MAILTEXT_TABLE");
			HOWTOGETTEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "HOWTOGETTEXT_TABLE");
			RECORDTIP_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "RECORDTIP_TABLE");
			RANDOMNAME_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "RANDOMNAME_TABLE");
			TIP_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "TIP_TABLE");
			WANTEDTEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "WANTEDTEXT_TABLE");
			AREATEXT_TABLE_DICT = Reader.DeserializeTableToClass<string, LOCALIZATION_TABLE>("w_KEY", "AREATEXT_TABLE");
			_initialized = true;
		}
	}

	public override void Dispose()
	{
	}
}
