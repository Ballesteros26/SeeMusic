namespace UnityEngine.Rendering.Universal
{
	public enum UpscalingFilterSelection
	{
		[InspectorName("Automatic")]
		Auto = 0,
		[InspectorName("Bilinear")]
		Linear = 1,
		[InspectorName("Nearest-Neighbor")]
		Point = 2,
		[InspectorName("FidelityFX Super Resolution 1.0")]
		FSR = 3
	}
}
