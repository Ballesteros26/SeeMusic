using System;
using UnityEngine;

namespace MakeIt.Numerics
{
	[Serializable]
	public struct Sphere : IEquatable<Sphere>, IComparable<Sphere>
	{
		public Vector3 center;

		public float radius;

		public Sphere(Vector3 center, float radius)
		{
			this.center = default(Vector3);
			this.radius = 0f;
		}

		public void Encapsulate(Vector3 point)
		{
		}

		public void Encapsulate(Bounds bounds)
		{
		}

		public void Encapsulate(Sphere bounds)
		{
		}

		public int CompareTo(Sphere other)
		{
			return 0;
		}

		public bool Equals(Sphere other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(Sphere lhs, Sphere rhs)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
