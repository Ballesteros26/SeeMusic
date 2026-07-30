using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Tonemapping", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class Tonemapping : VolumeComponent, IPostProcessComponent
	{
		[Tooltip("Select a tonemapping algorithm to use for the color grading process.")]
		public TonemappingModeParameter mode;

		public bool IsActive()
		{
			return false;
		}

		public bool IsTileCompatible()
		{
			return false;
		}
	}
}
