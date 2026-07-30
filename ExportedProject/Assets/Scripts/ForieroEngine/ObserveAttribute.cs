using UnityEngine;

public class ObserveAttribute : PropertyAttribute
{
	public string[] callbackNames;

	public ObserveAttribute(params string[] callbackNames)
	{
	}
}
