namespace UnityEngine.VFX
{
	internal class LoopAndDelay : VFXSpawnerCallbacks
	{
		public class InputProperties
		{
			[Tooltip("Number of Loops (< 0 for infinite), evaluated when Context Start is hit")]
			public int LoopCount;

			[Tooltip("Duration of one loop, evaluated every loop")]
			public float LoopDuration;

			[Tooltip("Duration of in-between delay (after each loop), evaluated every loop")]
			public float Delay;
		}

		private int m_LoopMaxCount;

		private int m_LoopCurrentIndex;

		private float m_WaitingForTotalTime;

		private static readonly int loopCountPropertyID;

		private static readonly int loopDurationPropertyID;

		private static readonly int delayPropertyID;

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
