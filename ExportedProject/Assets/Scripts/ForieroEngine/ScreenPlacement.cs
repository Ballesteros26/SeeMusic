using UnityEngine;

[ExecuteInEditMode]
public class ScreenPlacement : MonoBehaviour
{
	public Camera cam;

	public TextAnchor anchor;

	public Vector2 pixelOffset;

	public bool useResRatio;

	public bool continuous;

	public bool onResolutionChange;

	public bool inEditor;

	private Vector2 resolution;

	private TextAnchor lastAnchor;

	private Vector2 lastPixelOffset;

	private Camera lastCam;

	private bool lastUseResRation;

	private bool lastContinuous;

	private bool lastOnResolutionChange;

	private bool lastInEditor;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void ApplyEditor()
	{
	}

	private void Apply()
	{
	}

	public void ApplyScreenPlacement()
	{
	}
}
