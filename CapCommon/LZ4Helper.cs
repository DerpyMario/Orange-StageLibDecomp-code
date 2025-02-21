using System;
using LZ4;

public class LZ4Helper
{
	public static byte[] EncodeWithHeader(byte[] rawData)
	{
		byte[] array = LZ4Codec.Encode(rawData, 0, rawData.Length);
		byte[] array2 = new byte[array.Length + 4];
		Buffer.BlockCopy(BitConverter.GetBytes(rawData.Length), 0, array2, 0, 4);
		Buffer.BlockCopy(array, 0, array2, 4, array.Length);
		return array2;
	}

	public static byte[] DecodeWithHeader(byte[] compressedData)
	{
		int outputLength = BitConverter.ToInt32(compressedData, 0);
		byte[] array = new byte[compressedData.Length - 4];
		Buffer.BlockCopy(compressedData, 4, array, 0, array.Length);
		return LZ4Codec.Decode(array, 0, array.Length, outputLength);
	}

	public static byte[] EncodeWithoutHeader(byte[] rawData)
	{
		return LZ4Codec.Encode(rawData, 0, rawData.Length);
	}

	public static byte[] DecodeWithoutHeader(byte[] compressedData)
	{
		int num = LZ4Codec.MaximumOutputLength(compressedData.Length);
		byte[] output = new byte[num];
		int outputLength = LZ4Codec.Decode(compressedData, 0, compressedData.Length, output, 0, num);
		return LZ4Codec.Decode(compressedData, 0, compressedData.Length, outputLength);
	}
}
