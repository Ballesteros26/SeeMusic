using UnityEngine;

public class ObserveExample : MonoBehaviour
{
	public enum Test
	{
		Hoge = 0,
		Fuga = 1
	}

	[Observe(new string[] { "Callback" })]
	public string hoge;

	[Observe(new string[] { "Callback", "Callback2" })]
	public Test test;

	public void Callback()
	{
	}

	private void Callback2()
	{
	}
}
