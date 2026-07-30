using UnityEngine;

namespace VLB
{
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion/")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class DynamicOcclusion : MonoBehaviour
	{
		public class HitResult
		{
			public Vector3 point;

			public Vector3 normal;

			public float distance;

			private Collider2D collider2D;

			private Collider collider3D;

			public bool hasCollider => false;

			public string name => null;

			public Bounds bounds => default(Bounds);

			public HitResult(RaycastHit hit3D)
			{
			}

			public HitResult(RaycastHit2D hit2D)
			{
			}

			public HitResult()
			{
			}
		}

		private enum Direction
		{
			Up = 0,
			Right = 1,
			Down = 2,
			Left = 3
		}

		public OccluderDimensions dimensions;

		public LayerMask layerMask;

		public bool considerTriggers;

		public float minOccluderArea;

		public int waitFrameCount;

		public float minSurfaceRatio;

		public float maxSurfaceDot;

		public PlaneAlignment planeAlignment;

		public float planeOffset;

		public float fadeDistanceToPlane;

		private VolumetricLightBeam m_Master;

		private int m_FrameCountToWait;

		private float m_RangeMultiplier;

		private uint m_PrevNonSubHitDirectionId;

		public HitResult currentHit { get; private set; }

		public Plane planeEquationWS { get; private set; }

		private QueryTriggerInteraction queryTriggerInteraction => default(QueryTriggerInteraction);

		private float raycastMaxDistance => 0f;

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		private bool IsHitValid(HitResult hit)
		{
			return false;
		}

		private void ProcessRaycasts()
		{
		}

		private void SetHit(HitResult hit)
		{
		}

		private void SetHitNull()
		{
		}

		private void SetClippingPlane(Plane planeWS)
		{
		}

		private void SetClippingPlaneOff()
		{
		}

		private void SetPlaneWS(Plane planeWS)
		{
		}
	}
}
