public class CapDatagram
{
	public static byte[] Encrypt(byte[] rawData)
	{
		return AesCrypto.Encode(CapUtility.EncryptDecryptByte(LZ4Helper.EncodeWithHeader(rawData), AesCrypto.encryptKey + AesCrypto.iv));
	}

	public static byte[] Decrypt(byte[] encryptedData)
	{
		return LZ4Helper.DecodeWithHeader(CapUtility.EncryptDecryptByte(AesCrypto.Decode(encryptedData), AesCrypto.encryptKey + AesCrypto.iv));
	}
}
