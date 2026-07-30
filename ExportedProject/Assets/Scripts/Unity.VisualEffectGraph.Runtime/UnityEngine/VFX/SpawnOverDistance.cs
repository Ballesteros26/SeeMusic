namespace UnityEngine.VFX
{
	internal class SpawnOverDistance : VFXSpawnerCallbacks
	{
		public class InputProperties
		{
			public Vector3 Position;

			public float RatePerUnit;

			public float VelocityThreshold;

			public bool ClampToOne;
		}

		private Vector3 m_OldPosition;

		private static readonly int positionPropertyId;

		private static readonly int ratePerUnitPropertyId;

		private static readonly int velocityThresholdPropertyId;

		private static readonly int clampToOnePropertyId;

		private static readonly int positionAttributeId;

		private static readonly int oldPositionAttributeId;

		public sealed override void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
		{
		}

		public sealed override void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
		{
		}

		public sealed override void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
		{
		}
	}
}
