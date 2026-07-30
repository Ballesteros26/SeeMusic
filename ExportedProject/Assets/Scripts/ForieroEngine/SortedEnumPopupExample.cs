using UnityEngine;

public class SortedEnumPopupExample : MonoBehaviour
{
	public enum TestEnum
	{
		z = 0,
		f = 1,
		t = 2,
		x = 3
	}

	[SortedEnumPopup]
	public TestEnum testEnum;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
