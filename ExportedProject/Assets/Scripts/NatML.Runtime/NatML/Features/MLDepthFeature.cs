using System;
using NatML.Types;
using UnityEngine;

namespace NatML.Features
{
	public abstract class MLDepthFeature : MLFeature
	{
		public int width => 0;

		public int height => 0;

		public abstract float Sample(Vector2 point);

		public abstract Vector3 Unproject(Vector2 point);

		protected MLDepthFeature(int width, int height)
			: base(null)
		{
		}

		protected MLDepthFeature(MLImageType type)
			: base(null)
		{
		}

		[Obsolete("Deprecated in NatML 1.0.16. Use `ViewportToWorldPoint` method instead.", false)]
		public virtual Vector3 TransformPoint(Vector2 point)
		{
			return default(Vector3);
		}

		[Obsolete("Deprecated in NatML 1.1.4. Use `Unproject` method instead.", false)]
		public virtual Vector3 ViewportToWorldPoint(Vector2 point)
		{
			return default(Vector3);
		}
	}
}
