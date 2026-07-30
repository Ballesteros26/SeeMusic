using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class AspectRatio : MonoBehaviour
{
	public enum RatioEnum
	{
		Ratio_4_3 = 0,
		Ratio_16_9 = 1,
		Ratio_3_4 = 2,
		Ratio_9_16 = 3
	}

	private Vector2 resolution;

	private Vector2 aspectRatio;

	public RatioEnum ratio;

	public bool continuous;

	public bool onResolutionChange;

	public bool inEditor;

	public float originalCamSize;

	public bool drawGizmos;

	private Camera cam;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void Apply()
	{
	}

	private void AdjustCameraViewPort()
	{
	}

	public virtual void OnDrawGizmos()
	{
	}
}
