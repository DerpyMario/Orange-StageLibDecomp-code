namespace enums;

public enum IAPReceiptStatus : short
{
	None,
	New,
	InvalidData,
	StoreAuthSuccess,
	StoreAuthFailed,
	Exchanged,
	Expired,
	RetryExchanged
}
