using System;
using MakeIt.Numerics;
using UnityEngine;

namespace MakeIt.Core
{
	public static class GameObjectHierarchy
	{
		public static void ForAllRigidbodyColliders(Transform transform, Action<Collider> action)
		{
		}

		public static void ForAllRigidbodyColliders(Transform transform, Action<Collider2D> action)
		{
		}

		public static void ForAllComponents<TComponent>(Transform transform, Action<TComponent> action) where TComponent : Component
		{
		}

		public static Bounds GetColliderGroupAxisAlignedBoxBounds(Transform transform)
		{
			return default(Bounds);
		}

		public static Sphere GetColliderGroupSphereBounds(Transform transform)
		{
			return default(Sphere);
		}

		public static Bounds GetCollider2DGroupAxisAlignedBoxBounds(Transform transform)
		{
			return default(Bounds);
		}

		public static Sphere GetCollider2DGroupSphereBounds(Transform transform)
		{
			return default(Sphere);
		}

		public static Bounds GetLightGroupAxisAlignedBoxBounds(Transform transform)
		{
			return default(Bounds);
		}

		public static Sphere GetLightGroupSphereBounds(Transform transform)
		{
			return default(Sphere);
		}

		public static Bounds GetMeshGroupAxisAlignedBoxBounds(Transform transform)
		{
			return default(Bounds);
		}

		public static Sphere GetMeshGroupSphereBounds(Transform transform)
		{
			return default(Sphere);
		}

		public static Bounds GetSpriteGroupAxisAlignedBoxBounds(Transform transform)
		{
			return default(Bounds);
		}

		public static Sphere GetSpriteGroupSphereBounds(Transform transform)
		{
			return default(Sphere);
		}
	}
}
