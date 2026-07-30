namespace UnityEngine.Rendering.Universal
{
	public static class ShaderInput
	{
		[GenerateHLSL(PackingRules.Exact, false, false, false, 1, false, false, false, -1, "C:\\Users\\pshan\\Desktop\\seeMusic Unity\\Library\\PackageCache\\com.unity.render-pipelines.universal@12.1.12\\ShaderLibrary\\ShaderTypes.cs")]
		public struct LightData
		{
			public Vector4 position;

			public Vector4 color;

			public Vector4 attenuation;

			public Vector4 spotDirection;

			public Vector4 occlusionProbeChannels;

			public uint layerMask;
		}
	}
}
