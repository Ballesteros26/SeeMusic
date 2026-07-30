using UnityEngine;

public class PopupExample : MonoBehaviour
{
	[Popup(new object[] { "Hoge", "Fuga", "Foo", "Bar" })]
	public string popup;

	[Popup(new object[] { 1, 2, 3, 4, 5, 6 })]
	public int popup2;

	[Popup(new object[] { 1.5f, 2.3f, 3.4f, 4.5f, 5.6f, 6.7f })]
	public float popup3;
}
