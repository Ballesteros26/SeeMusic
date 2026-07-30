using UnityEngine;

public class PopupStringList : PropertyAttribute
{
	public delegate string[] GetStringList();

	public string[] List { get; private set; }

	public PopupStringList(string[] list)
	{
	}
}
