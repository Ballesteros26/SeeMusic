using UnityEngine;

public class MinMaxAttribute : PropertyAttribute
{
	public float MinLimit;

	public float MaxLimit;

	public bool ShowEditRange;

	public bool ShowDebugValues;

	public MinMaxAttribute(int min, int max)
	{
	}
}
