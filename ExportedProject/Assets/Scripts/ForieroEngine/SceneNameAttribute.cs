using UnityEngine;

public class SceneNameAttribute : PropertyAttribute
{
	public int selectedValue;

	public bool enableOnly;

	public SceneNameAttribute(bool enableOnly = true)
	{
	}
}
