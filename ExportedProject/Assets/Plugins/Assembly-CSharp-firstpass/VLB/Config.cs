using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject
	{
		public bool geometryOverrideLayer;

		public int geometryLayerID;

		public string geometryTag;

		public int geometryRenderQueue;

		public RenderPipeline renderPipeline;

		[Obsolete("Use 'renderingMode' instead")]
		public bool forceSinglePass;

		public RenderingMode renderingMode;

		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[FormerlySerializedAs("BeamShader")]
		[FormerlySerializedAs("beamShader")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader2Pass;

		public int sharedMeshSides;

		public int sharedMeshSegments;

		[Range(0.01f, 2f)]
		public float globalNoiseScale;

		public Vector3 globalNoiseVelocity;

		public string fadeOutCameraTag;

		[HighlightNull]
		public TextAsset noise3DData;

		public int noise3DSize;

		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[SerializeField]
		private int pluginVersion;

		private Transform m_CachedFadeOutCamera;

		private const string kAssetName = "Config";

		private static Config m_Instance;

		public RenderingMode actualRenderingMode => default(RenderingMode);

		public bool useSinglePassShader => false;

		public Shader beamShader => null;

		public Vector4 globalNoiseParam => default(Vector4);

		public Transform fadeOutCameraTransform => null;

		public static Config Instance => null;

		public void ForceUpdateFadeOutCamera()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
		}

		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		public void Reset()
		{
		}

		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}
	}
}
