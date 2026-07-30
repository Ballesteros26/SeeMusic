using UnityEngine;

public class PopupIntList : PropertyAttribute
{
	public delegate int[] GetIntList();

	public bool showLabel;

	public int[] List { get; private set; }

	public PopupIntList(int[] list)
	{
	}
}
