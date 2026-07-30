namespace UnityEngine.VFX
{
	internal class IncrementStripIndexOnStart : VFXSpawnerCallbacks
	{
		public class InputProperties
		{
			[Tooltip("Maximum Strip Count (Used to cycle indices)")]
			public uint StripMaxCount;
		}

		private static readonly int stripMaxCountID;

		private static readonly int stripIndexID;

		private uint m_Index;

		public override void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
		{
		}

		public override void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
		{
		}

		public override void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
		{
		}
	}
}
