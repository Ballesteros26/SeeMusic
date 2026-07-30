using System.IO;
using UnityEngine;

public static class BetterStreamingAssets
{
	internal struct ReadInfo
	{
		public string readPath;

		public long size;

		public long offset;

		public uint crc32;
	}

	internal static class LooseFilesImpl
	{
		public static string s_root;

		private static string[] s_emptyArray;

		public static void Initialize(string dataPath, string streamingAssetsPath)
		{
		}

		public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			return null;
		}

		public static bool TryGetInfo(string path, out ReadInfo info)
		{
			info = default(ReadInfo);
			return false;
		}

		public static bool DirectoryExists(string path)
		{
			return false;
		}

		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		public static Stream OpenRead(string path)
		{
			return null;
		}
	}

	public static string Root => null;

	public static void Initialize()
	{
	}

	public static bool FileExists(string path)
	{
		return false;
	}

	public static bool DirectoryExists(string path)
	{
		return false;
	}

	public static AssetBundleCreateRequest LoadAssetBundleAsync(string path, uint crc = 0u)
	{
		return null;
	}

	public static AssetBundle LoadAssetBundle(string path, uint crc = 0u)
	{
		return null;
	}

	public static Stream OpenRead(string path)
	{
		return null;
	}

	public static StreamReader OpenText(string path)
	{
		return null;
	}

	public static string ReadAllText(string path)
	{
		return null;
	}

	public static string[] ReadAllLines(string path)
	{
		return null;
	}

	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return null;
	}

	public static string[] GetFiles(string path)
	{
		return null;
	}

	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	private static ReadInfo GetInfoOrThrow(string path)
	{
		return default(ReadInfo);
	}

	private static void ThrowFileNotFound(string path)
	{
	}
}
