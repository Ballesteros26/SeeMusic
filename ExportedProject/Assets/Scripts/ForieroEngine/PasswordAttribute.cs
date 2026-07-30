using UnityEngine;

public class PasswordAttribute : PropertyAttribute
{
	public char mask;

	public bool useMask;

	public int minLength;

	public int maxLength;

	public PasswordAttribute()
	{
	}

	public PasswordAttribute(int minLength, int maxLength)
	{
	}

	public PasswordAttribute(int minLength, bool useMask)
	{
	}

	public PasswordAttribute(int minLength, int maxLength, bool useMask)
	{
	}
}
