using System;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;


public class UserLoginValidator
{
	public string HashPassword;

    public UserLoginValidator(string username, string password)
    {
		if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) throw new Exception("Wrong Username or Password");
		string preparedUsername = username;
		Regex rgx = new Regex("[^a-zA-Z0-9 -]");
		_ = rgx.Replace(preparedUsername, "");

		HashPassword = SHA.GenerateSHA512String(password);
    }
}

public static class SHA
{
	public static string GenerateSHA256String(string inputString)
	{
		SHA256 sha256 = SHA256Managed.Create();
		byte[] bytes = Encoding.UTF8.GetBytes(inputString);
		byte[] hash = sha256.ComputeHash(bytes);
		return GetStringFromHash(hash);
	}

	public static string GenerateSHA512String(string inputString)
	{
		SHA512 sha512 = SHA512Managed.Create();
		byte[] bytes = Encoding.UTF8.GetBytes(inputString);
		byte[] hash = sha512.ComputeHash(bytes);
		return GetStringFromHash(hash);
	}

	private static string GetStringFromHash(byte[] hash)
	{
		StringBuilder result = new StringBuilder();

		foreach (var t in hash)
			result.Append(t.ToString("X2"));

		return result.ToString();
	}

}

