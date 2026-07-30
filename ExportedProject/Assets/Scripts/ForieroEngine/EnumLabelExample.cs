using UnityEngine;

public class EnumLabelExample : MonoBehaviour
{
	public enum Example
	{
		[EnumLabel("Marek")]
		HIGH = 0,
		[EnumLabel("Keram")]
		LOW = 1
	}

	[EnumLabel("例")]
	public Example test;
}
