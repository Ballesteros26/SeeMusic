using UnityEngine;
using UnityEngine.Rendering;

public class DebugDrawPhysics2D : MonoBehaviour
{
	private const int JOINT_CIRCLE_SEGMENTS = 20;

	private const int CIRCLE_COLLIDER_SEGMENTS = 40;

	private Material lineMaterial;

	private BoxCollider2D[] boxColliders2D;

	private PolygonCollider2D[] polygonColliders2D;

	private CircleCollider2D[] circleColliders2D;

	private EdgeCollider2D[] edgeColliders2D;

	private AnchoredJoint2D[] anchoredJoints2D;

	private Vector3[][] boxPointList;

	private Vector3[][] circlePointList;

	private Vector3[][] polygonPointList;

	private Vector3[][] edgePointList;

	private Vector3[][] anchoredJointPointList;

	public Color circleColour;

	public Color polygonColour;

	public Color boxColour;

	public Color edgeColour;

	public Color jointColour;

	private Camera _c;

	private void Start()
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	private void endCameraRendering(ScriptableRenderContext src, Camera[] c)
	{
	}

	protected void OnCameraRender(Camera c)
	{
	}

	private bool CheckFilter(Camera c)
	{
		return false;
	}

	private bool CheckFilter(Camera[] c)
	{
		return false;
	}

	private void Update()
	{
	}

	private Vector3[] GetPolygonPoints(PolygonCollider2D collider)
	{
		return null;
	}

	private Vector3[] GetEdgePoints(EdgeCollider2D collider)
	{
		return null;
	}

	private Vector3[] GetAnchoredJointPoints(AnchoredJoint2D joint)
	{
		return null;
	}

	private Vector3[] GetBoxPoints(BoxCollider2D collider)
	{
		return null;
	}

	private Vector3[] GetCircle(float x, float y, float radius, int segments)
	{
		return null;
	}

	private Vector3[] GetCircleColliderPoints(CircleCollider2D collider, int segments)
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}

	private void DrawBox2DGizmo(Vector3[][] colliderPoints)
	{
	}

	private void RenderColliders()
	{
	}

	private void RenderColliders(Vector3[][] colliderPoints, Color colour)
	{
	}

	private void CreateLineMaterial()
	{
	}
}
