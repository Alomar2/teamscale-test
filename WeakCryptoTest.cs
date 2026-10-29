using System.Security.Cryptography;
using System.Text;

namespace TeamscaleTest;

internal static class WeakCryptoTest
{
	internal static byte[] HashPasswordWithMd5(string password)
	{
		using var md5 = MD5.Create();
		return md5.ComputeHash(Encoding.UTF8.GetBytes(password));
	}
}
