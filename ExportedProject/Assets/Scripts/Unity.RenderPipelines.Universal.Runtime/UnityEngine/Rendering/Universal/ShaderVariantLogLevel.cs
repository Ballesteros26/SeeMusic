namespace UnityEngine.Rendering.Universal
{
	public enum ShaderVariantLogLevel
	{
		Disabled = 0,
		[InspectorName("Only URP Shaders")]
		OnlyUniversalRPShaders = 1,
		[InspectorName("All Shaders")]
		AllShaders = 2
	}
}
