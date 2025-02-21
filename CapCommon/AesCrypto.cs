using System;
using System.Security.Cryptography;
using System.Text;

public class AesCrypto
{
	public static string encryptKey = "cbs4/+-jDAf!?s/#cbs4/+-jDAf!?s/#";

	public static string iv = "=!r19kCsGHTAcr/@";

	public static byte[] Encode(byte[] rawData)
	{
		return new RijndaelManaged
		{
			Key = Encoding.UTF8.GetBytes(encryptKey),
			IV = Encoding.UTF8.GetBytes(iv),
			Padding = PaddingMode.PKCS7
		}.CreateEncryptor().TransformFinalBlock(rawData, 0, rawData.Length);
	}

	public static string Encode(string encryptString)
	{
		return Convert.ToBase64String(Encode(Encoding.UTF8.GetBytes(encryptString)));
	}

	public static byte[] Decode(byte[] encryptedData)
	{
		return new RijndaelManaged
		{
			Key = Encoding.UTF8.GetBytes(encryptKey),
			IV = Encoding.UTF8.GetBytes(iv),
			Padding = PaddingMode.PKCS7
		}.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
	}

	public static string Decode(string decryptString)
	{
		try
		{
			byte[] bytes = Decode(Convert.FromBase64String(decryptString));
			return Encoding.UTF8.GetString(bytes);
		}
		catch
		{
			return "";
		}
	}

	public static byte[] Encode(byte[] rawData, string secretKey, string secretIV)
	{
		return new RijndaelManaged
		{
			Key = Encoding.UTF8.GetBytes(secretKey),
			IV = Encoding.UTF8.GetBytes(secretIV),
			Padding = PaddingMode.PKCS7
		}.CreateEncryptor().TransformFinalBlock(rawData, 0, rawData.Length);
	}

	public static byte[] Decode(byte[] encryptedData, string secretKey, string secretIV)
	{
		return new RijndaelManaged
		{
			Key = Encoding.UTF8.GetBytes(secretKey),
			IV = Encoding.UTF8.GetBytes(secretIV),
			Padding = PaddingMode.PKCS7
		}.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
	}
}
