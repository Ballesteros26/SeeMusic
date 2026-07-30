using System.Collections.Generic;
using UnityEngine;

public class MovingBackground2D : MonoBehaviour
{
	private class EdgeTransforms
	{
		public SpriteRenderer spriteRenderer;

		public Transform left;

		public Transform right;
	}

	public enum DirectionEnum
	{
		None = 0,
		Right = 1,
		Left = 2
	}

	public enum TypeEnum
	{
		Seamless = 0,
		Objects = 1
	}

	private List<EdgeTransforms> edges;

	public Camera cam;

	public TypeEnum type;

	public float speed;

	public float timeScale;

	public bool reverse;

	[HideInInspector]
	public DirectionEnum direction;

	[HideInInspector]
	public float x;

	private float xUpdate;

	[Tooltip("Objects from left to right")]
	public SpriteRenderer[] objects;

	public Transform leftEdge;

	public Transform rightEdge;

	private Vector3 leftScreenPoint;

	private Vector3 rightScreenPoint;

	private SpriteRenderer spriteRenderer;

	private EdgeTransforms edgeTransfomrs;

	private void Start()
	{
	}

	private void SetUpSeamlessTransfomrs()
	{
	}

	private Transform CreateEdgeTransformPoint(Transform parent, float left, float right, float y, float z)
	{
		return null;
	}

	private void Update()
	{
	}

	private void UpdateObjectTransforms()
	{
	}

	private void UpdateSeemlessTransforms()
	{
	}

	private EdgeTransforms GetPreviousEdge(int index)
	{
		return null;
	}

	private EdgeTransforms GetNextEdge(int index)
	{
		return null;
	}
}
