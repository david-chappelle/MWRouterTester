using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography;
using System.Net.NetworkInformation;

namespace urlgen
{
	public static class Crypto
	{
		public static byte[] HashHMAC(byte[] key, byte[] message)
		{
			//var hash = new HMACSHA256(key);
			var hash = new HMACMD5(key);
			return hash.ComputeHash(message);
		}

		public static byte[] StringEncode(string text)
		{
			var encoding = new ASCIIEncoding();
			return encoding.GetBytes(text);
		}

		public static string HashEncode(byte[] hash)
		{
			return BitConverter.ToString(hash).Replace("-", "").ToLower();
		}

		public static byte[] HexDecode(string hex)
		{
			var bytes = new byte[hex.Length / 2];
			for (int i = 0; i < bytes.Length; i++)
			{
				bytes[i] = byte.Parse(hex.Substring(i * 2, 2), NumberStyles.HexNumber);
			}
			return bytes;
		}

		public static string HashHMACHex(string key, string message, bool keyIsHex = true)
		{
			byte[] hash = HashHMAC(keyIsHex ? HexDecode(key) : StringEncode(key), StringEncode(message));
			return HashEncode(hash);
		}
	}
}
