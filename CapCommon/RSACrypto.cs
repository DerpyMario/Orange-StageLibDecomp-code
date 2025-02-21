using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class RSACrypto
{
	private string RSAPublicKey = "<RSAKeyValue><Modulus>twhblfaR8KbgXUKx4kVj/jx8I30kVrJYYP+dJJUnPLyWmzEj8jksXg+WkIX0H8ty3UkbRgAbCtZdSA4deFBaa7l1Aym+TF2qcxkzkXSA8OM3TiQ8t1cMKfeXvikCoZ8EyyU5ts6M4HJBVNf6uVGgPPWYDZLjgMrGtjRNVEqbp8c=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	public string RSAEncrypt(string data, bool fOAEP = false)
	{
		return RSACryptor(Encoding.UTF8.GetBytes(data), fOAEP);
	}

	public string RSACryptor(byte[] data, bool fOAEP = false)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(RSAPublicKey);
		return Convert.ToBase64String(rSACryptoServiceProvider.Encrypt(data, fOAEP));
	}

	public string RSAEncryptData(string data, bool fOAEP = false, int encryptionBufferSize = 117, int decryptionBufferSize = 128)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(RSAPublicKey);
		byte[] bytes = Encoding.UTF8.GetBytes(data);
		using MemoryStream memoryStream = new MemoryStream();
		byte[] array = new byte[encryptionBufferSize];
		int num = 0;
		int num2 = array.Length;
		do
		{
			if (num + num2 > bytes.Length)
			{
				num2 = bytes.Length - num;
			}
			array = new byte[num2];
			Array.Copy(bytes, num, array, 0, num2);
			num += num2;
			memoryStream.Write(rSACryptoServiceProvider.Encrypt(array, fOAEP), 0, decryptionBufferSize);
			Array.Clear(array, 0, num2);
		}
		while (num < bytes.Length);
		return Convert.ToBase64String(memoryStream.ToArray());
	}
}
