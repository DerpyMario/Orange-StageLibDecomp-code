using System.Security.Cryptography;
using System.Text;

public class MD5Crypto
{
	public static string Encode(string input)
	{
		byte[] array = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}
}
