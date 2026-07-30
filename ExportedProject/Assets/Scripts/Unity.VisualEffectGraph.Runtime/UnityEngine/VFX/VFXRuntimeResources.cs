namespace UnityEngine.VFX
{
	internal class VFXRuntimeResources : ScriptableObject
	{
		[SerializeField]
		private ComputeShader m_SDFRayMapCS;

		[SerializeField]
		private ComputeShader m_SDFNormalsCS;

		[SerializeField]
		private Shader m_SDFRayMapShader;

		internal ComputeShader sdfRayMapCS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ComputeShader sdfNormalsCS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Shader sdfRayMapShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static VFXRuntimeResources runtimeResources => null;
	}
}
