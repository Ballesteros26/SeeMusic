using System.Collections.Generic;
using UnityEngine;

public class NativeShare
{
	public enum ShareResult
	{
		Unknown = 0,
		Shared = 1,
		NotShared = 2
	}

	public delegate void ShareResultCallback(ShareResult result, string shareTarget);

	private string subject;

	private string text;

	private string title;

	private string url;

	private readonly List<string> files;

	private readonly List<string> mimes;

	private ShareResultCallback callback;

	public NativeShare Clear()
	{
		return null;
	}

	public NativeShare SetSubject(string subject)
	{
		return null;
	}

	public NativeShare SetText(string text)
	{
		return null;
	}

	public NativeShare SetUrl(string url)
	{
		return null;
	}

	public NativeShare SetTitle(string title)
	{
		return null;
	}

	public NativeShare SetCallback(ShareResultCallback callback)
	{
		return null;
	}

	public NativeShare AddTarget(string androidPackageName, string androidClassName = null)
	{
		return null;
	}

	public NativeShare AddFile(string filePath, string mime = null)
	{
		return null;
	}

	public NativeShare AddFile(Texture2D texture, string createdFileName = "Image.png")
	{
		return null;
	}

	public NativeShare AddEmailRecipient(string emailAddress)
	{
		return null;
	}

	public void Share()
	{
	}

	public static bool TargetExists(string androidPackageName, string androidClassName = null)
	{
		return false;
	}

	public static bool FindTarget(out string androidPackageName, out string androidClassName, string packageNameRegex, string classNameRegex = null)
	{
		androidPackageName = null;
		androidClassName = null;
		return false;
	}

	private string GetURLWithScheme()
	{
		return null;
	}

	private string CombineURLWithText()
	{
		return null;
	}

	private byte[] GetTextureBytes(Texture2D texture, bool isJpeg)
	{
		return null;
	}

	private byte[] GetTextureBytesFromCopy(Texture2D texture, bool isJpeg)
	{
		return null;
	}
}
