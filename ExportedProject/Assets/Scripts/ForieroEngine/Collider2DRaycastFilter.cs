using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(RectTransform), typeof(Collider2D))]
public class Collider2DRaycastFilter : MonoBehaviour, ICanvasRaycastFilter, IPointerClickHandler, IEventSystemHandler
{
	private Collider2D _c;

	private RectTransform _rt;

	private void Awake()
	{
	}

	public bool IsRaycastLocationValid(Vector2 screenPos, Camera eventCamera)
	{
		return false;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
