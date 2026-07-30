using System.Collections.Generic;
using MH.WaterCausticsModules.Effect;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;

namespace MH.WaterCausticsModules
{
	[ExecuteAlways]
	[HelpURL("https://hacoapp.com/asset/wce/v2/ManualPDF.pdf")]
	[AddComponentMenu("WaterCausticsModules/WaterCausticsEffect")]
	[DisallowMultipleComponent]
	public class WaterCausticsEffect : MonoBehaviour
	{
		private class pID
		{
			internal static readonly int _WCE_CausticsTex;

			internal static readonly int _WCE_TexChannels;

			internal static readonly int _WCE_TexRotateSinCos;

			internal static readonly int _WCE_TilingSeed;

			internal static readonly int _WCE_TilingRot;

			internal static readonly int _WCE_TilingHard;

			internal static readonly int _WCE_IntensityMainLit;

			internal static readonly int _WCE_IntensityAddLit;

			internal static readonly int _WCE_Density;

			internal static readonly int _WCE_ColorShift;

			internal static readonly int _WCE_SurfaceY;

			internal static readonly int _WCE_SurfFadeStart;

			internal static readonly int _WCE_SurfFadeCoef;

			internal static readonly int _WCE_DepthFadeStart;

			internal static readonly int _WCE_DepthFadeCoef;

			internal static readonly int _WCE_DistanceFadeStart;

			internal static readonly int _WCE_DistanceFadeCoef;

			internal static readonly int _WCE_LitSaturation;

			internal static readonly int _WCE_MultiplyByTex;

			internal static readonly int _WCE_NormalAtten;

			internal static readonly int _WCE_NormalAttenRate;

			internal static readonly int _WCE_TransparentBack;

			internal static readonly int _WCE_BacksideShadow;

			internal static readonly int _WCE_ShadowIntensity;

			internal static readonly int _WCE_ImageMaskTex;

			internal static readonly int _WCE_WorldToObjMatrix;

			internal static readonly int _WCE_ClipOutside;

			internal static readonly int _WCE_UseImageMask;

			internal static readonly int _StencilRef;

			internal static readonly int _StencilReadMask;

			internal static readonly int _StencilWriteMask;

			internal static readonly int _StencilComp;

			internal static readonly int _StencilPass;

			internal static readonly int _StencilFail;

			internal static readonly int _StencilZFail;

			internal static readonly int _CullMode;

			internal static readonly int _ZWrite;

			internal static readonly int _ZTest;

			internal static readonly int _OffsetFactor;

			internal static readonly int _OffsetUnits;

			internal static readonly int _BlendSrcFactor;

			internal static readonly int _BlendDstFactor;

			internal static readonly int _WCECF_TexChannels;

			internal static readonly int _WCECF_TexRotateSinCos;

			internal static readonly int _WCECF_TilingSeed;

			internal static readonly int _WCECF_TilingRot;

			internal static readonly int _WCECF_TilingHard;

			internal static readonly int _WCECF_IntensityMainLit;

			internal static readonly int _WCECF_Density;

			internal static readonly int _WCECF_ColorShift;

			internal static readonly int _WCECF_SurfaceY;

			internal static readonly int _WCECF_SurfFadeStart;

			internal static readonly int _WCECF_SurfFadeCoef;

			internal static readonly int _WCECF_DepthFadeStart;

			internal static readonly int _WCECF_DepthFadeCoef;

			internal static readonly int _WCECF_DistanceFadeStart;

			internal static readonly int _WCECF_DistanceFadeCoef;

			internal static readonly int _WCECF_LitSaturation;

			internal static readonly int _WCECF_IntensityAddLit;

			internal static readonly int _WCECF_MultiplyIntensity;

			internal static readonly int _WCECF_NormalAttenRate;

			internal static readonly int _WCECF_NormalAtten;

			internal static readonly int _WCECF_TransparentBack;

			internal static readonly int _WCECF_BacksideShadow;

			internal static readonly int _WCECF_ShadowIntensity;

			internal static readonly int _WCECF_WorldToObjMatrix;

			internal static readonly int _WCECF_ClipOutside;

			internal static readonly int _WCECF_UseImageMask;

			internal static readonly int _WCECF_CausticsTex;

			internal static readonly int _WCECF_ImageMaskTex;
		}

		internal class WCEAtOncePass : ScriptableRenderPass
		{
			private ShaderTagId _shaderTagId;

			private bool _useNormalTex;

			private bool _useOpaqueTex;

			private static readonly HashSet<RenderPassEvent> s_hashSet;

			private RenderPassEvent __evt;

			private RenderQueueRange _queueRange;

			private void setRenderEvt(RenderPassEvent v)
			{
			}

			internal WCEAtOncePass()
			{
			}

			internal void Setup(RenderPassEvent evt, bool useNormalTex, bool useOpaqueTex)
			{
			}

			public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData rendData)
			{
			}

			public override void Execute(ScriptableRenderContext context, ref RenderingData rendData)
			{
			}

			public override void OnCameraCleanup(CommandBuffer cmd)
			{
			}
		}

		internal class WCEEachMeshPass : ScriptableRenderPass
		{
			private Material _mat;

			private readonly List<ShaderTagId> _shaderTagIds;

			private bool _useOpaqueTex;

			private LayerMask _layerMask;

			internal WCEEachMeshPass()
			{
			}

			internal void Setup(RenderPassEvent evt, Material mat, LayerMask layerMask, bool useOpaqueTex)
			{
			}

			public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData rendData)
			{
			}

			public override void Execute(ScriptableRenderContext context, ref RenderingData rendData)
			{
			}
		}

		private readonly Vector3[] _texChannelVec;

		internal static readonly RenderPassEvent SYS_OPAQUE_TEX_EVENT;

		internal static readonly RenderPassEvent RENDER_EVENT;

		internal static readonly int RENDER_EVENT_ADJ;

		[SerializeField]
		private Method m_method;

		[SerializeField]
		private NormalSrc m_normalSrc;

		[SerializeField]
		private bool m_debugInfo;

		[SerializeField]
		private DebugMode m_debugMode;

		[SerializeField]
		private uint m_renderLayerMask;

		[SerializeField]
		private LayerMask m_layerMask;

		[FormerlySerializedAs("m_clipOutsideVolume")]
		[SerializeField]
		private bool m_clipOutside;

		[SerializeField]
		private bool m_useImageMask;

		[SerializeField]
		private Texture m_imageMaskTexture;

		[SerializeField]
		private Texture m_texture;

		[SerializeField]
		private TexChannel m_textureChannel;

		[SerializeField]
		[Range(-180f, 180f)]
		private float m_textureRotation;

		[SerializeField]
		private Vector2 m_texRotSinCos;

		[SerializeField]
		private bool m_useRandomTiling;

		[SerializeField]
		[Range(0f, 1000f)]
		private int m_tilingSeed;

		[Range(0f, 0.2f)]
		[SerializeField]
		private float m_tilingRotation;

		[SerializeField]
		[Range(0.75f, 0.999f)]
		private float m_tilingHardness;

		[SerializeField]
		[Min(0.0001f)]
		private float m_scale;

		[FormerlySerializedAs("m_waterSurfaceY")]
		[SerializeField]
		private float m_surfaceY;

		[SerializeField]
		[Min(0f)]
		[FormerlySerializedAs("m_waterSurfaceAttenOffset")]
		private float m_surfFadeStart;

		[Min(0f)]
		[SerializeField]
		[FormerlySerializedAs("m_waterSurfaceAttenWide")]
		private float m_surfFadeEnd;

		[SerializeField]
		[FormerlySerializedAs("m_useDepthAtten")]
		private bool m_useDepthFade;

		[SerializeField]
		[Min(0f)]
		private float m_depthFadeStart;

		[FormerlySerializedAs("m_depthAttenDepth")]
		[SerializeField]
		[Min(0f)]
		private float m_depthFadeEnd;

		[SerializeField]
		private bool m_useDistanceFade;

		[SerializeField]
		[Min(0f)]
		private float m_distanceFadeStart;

		[SerializeField]
		[Min(0f)]
		private float m_distanceFadeEnd;

		[SerializeField]
		[Min(0f)]
		private float m_intensity;

		[Range(0f, 10f)]
		[SerializeField]
		[FormerlySerializedAs("m_adjustMainLit")]
		private float m_mainLit;

		[Range(0f, 10f)]
		[SerializeField]
		[FormerlySerializedAs("m_adjustAddLit")]
		private float m_addLit;

		[SerializeField]
		private float m_colorShiftU;

		[SerializeField]
		private float m_colorShiftV;

		[SerializeField]
		[Range(0f, 5f)]
		private float m_colorShift;

		[Range(-180f, 180f)]
		[SerializeField]
		private float m_colorShiftDir;

		[SerializeField]
		[Range(0f, 2f)]
		private float m_litSaturation;

		[FormerlySerializedAs("m_multiplyOpaqueColor")]
		[SerializeField]
		private bool m_useMultiply;

		[FormerlySerializedAs("m_multiplyOpaqueIntensity")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_multiply;

		[FormerlySerializedAs("m_normalAttenIntensity")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_normalAtten;

		[FormerlySerializedAs("m_normalAttenPower")]
		[SerializeField]
		[Range(1f, 8f)]
		private float m_normalAttenRate;

		[Range(0f, 1f)]
		[SerializeField]
		private float m_transparentBackside;

		[Range(0f, 1f)]
		[SerializeField]
		private float m_backsideShadow;

		[SerializeField]
		private bool m_receiveShadows;

		[Range(0f, 1f)]
		[SerializeField]
		private float m_shadowIntensity;

		[SerializeField]
		[FormerlySerializedAs("m_useMainLight")]
		private int m_version;

		[SerializeField]
		private bool m_useMainLit;

		[SerializeField]
		[FormerlySerializedAs("m_useAdditionalLights")]
		private bool m_useAddLit;

		[SerializeField]
		[FormerlySerializedAs("m_syncWithShaderFunctions")]
		private bool m_useCustomFunc;

		[SerializeField]
		private RenderPassEvent m_renderEvent;

		[SerializeField]
		private int m_renderEventAdjust;

		[Range(0f, 255f)]
		[SerializeField]
		private int m_stencilRef;

		[SerializeField]
		[Range(0f, 255f)]
		private int m_stencilReadMask;

		[Range(0f, 255f)]
		[SerializeField]
		private int m_stencilWriteMask;

		[SerializeField]
		private CompareFunction m_stencilComp;

		[SerializeField]
		private StencilOp m_stencilPass;

		[SerializeField]
		private StencilOp m_stencilFail;

		[SerializeField]
		private StencilOp m_stencilZFail;

		[SerializeField]
		private CullMode m_cullMode;

		[SerializeField]
		private bool m_zWriteMode;

		[SerializeField]
		private CompareFunction m_zTestMode;

		[SerializeField]
		private float m_depthOffsetFactor;

		[SerializeField]
		private float m_depthOffsetUnits;

		[SerializeField]
		private Shader m_shader;

		[SerializeField]
		private Texture m_noTexture;

		private bool _needUpdateMat;

		private Material __mat;

		private static WaterCausticsEffect s_nextSync;

		private static WaterCausticsEffect s_lastSync;

		private WCEEachMeshPass _eachMeshPass;

		private WCEAtOncePass _atOncePass;

		private readonly Vector3[] _points;

		private readonly Plane[] _planes;

		private AtOnce _atOnce;

		private RenderPassEvent eventAdjusted => default(RenderPassEvent);

		private bool existOpaqueTex => false;

		private bool useBlendMultiply => false;

		private float multiplyByTex => 0f;

		private float multiplyRaw => 0f;

		private float finalMainLit => 0f;

		private float finalAddLit => 0f;

		private bool isIntensityZero => false;

		private bool useClipOutside => false;

		public Method method
		{
			get
			{
				return default(Method);
			}
			set
			{
			}
		}

		public NormalSrc normalSrc
		{
			get
			{
				return default(NormalSrc);
			}
			set
			{
			}
		}

		public bool debugInfo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public DebugMode debugMode
		{
			get
			{
				return default(DebugMode);
			}
			set
			{
			}
		}

		public uint renderingLayerMask
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public LayerMask layerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public bool clipOutside
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Texture texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TexChannel textureChannel
		{
			get
			{
				return default(TexChannel);
			}
			set
			{
			}
		}

		public float textureRotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useRandomTiling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int tilingSeed
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float tilingRotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float tilingHardness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float intensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float mainLightIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float additionalLightsIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float colorShift
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float colorShiftDirection
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float surfaceY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float surfaceFadeStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float surfaceFadeEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useDepthFade
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float depthAttenStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float depthAttenEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useDistanceAtten
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float distanceAttenStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float distanceAttenEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float lightSaturation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool receiveShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float shadowIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useMainLight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useAdditionalLights
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float multiplyWithBaseColor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float normalAttenRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float normalAtten
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float TransparentBack
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float backsideShadow
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int stencilRef
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int stencilReadMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int stencilWriteMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public CompareFunction stencilComp
		{
			get
			{
				return default(CompareFunction);
			}
			set
			{
			}
		}

		public StencilOp stencilPass
		{
			get
			{
				return default(StencilOp);
			}
			set
			{
			}
		}

		public StencilOp stencilFail
		{
			get
			{
				return default(StencilOp);
			}
			set
			{
			}
		}

		public StencilOp stencilZFail
		{
			get
			{
				return default(StencilOp);
			}
			set
			{
			}
		}

		public CullMode cullMode
		{
			get
			{
				return default(CullMode);
			}
			set
			{
			}
		}

		public bool zWriteMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CompareFunction zTestMode
		{
			get
			{
				return default(CompareFunction);
			}
			set
			{
			}
		}

		public float depthOffsetFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float depthOffsetUnits
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useImageMask
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Texture imageMaskTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool supportCustomFunction
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public RenderPassEvent renderEvent
		{
			get
			{
				return default(RenderPassEvent);
			}
			set
			{
			}
		}

		public int renderEventAdjust
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal AtOnce atOnce => null;

		private Vector2 calcColorShiftVec()
		{
			return default(Vector2);
		}

		private void setValAndNeedSetMat<T>(ref T prop, T val)
		{
		}

		public void ForceApplyChanges()
		{
		}

		private static float round2Dec(float val)
		{
			return 0f;
		}

		private static float round2Dec5(float val)
		{
			return 0f;
		}

		private static float wrapAngle180(float angle)
		{
			return 0f;
		}

		private static Vector2 dirToVec(float dir)
		{
			return default(Vector2);
		}

		private static float vecToDir(Vector2 v)
		{
			return 0f;
		}

		private void Reset()
		{
		}

		internal void VersionCheck()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void destroy<T>(ref T o) where T : Object
		{
		}

		private void destroy(Object o)
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private Material getMat()
		{
			return null;
		}

		private Material createMat(Shader shader, string name)
		{
			return null;
		}

		private float calcFadeCoef(float depth)
		{
			return 0f;
		}

		private void updateMaterialValues()
		{
		}

		private void setMatKeyword(Material mat, bool isEnable, string keyword)
		{
		}

		private void onDisableForCF()
		{
		}

		private void updateForCF()
		{
		}

		private void lateUpdateForCF()
		{
		}

		private void setCustomFunc()
		{
		}

		private void setCFIntensityZero()
		{
		}

		private void setCFIntensity()
		{
		}

		private void tellCustomFuncNeedDraw(bool needDraw)
		{
		}

		private void onEnableForPass()
		{
		}

		private void onDisableForPass()
		{
		}

		private void enqueuePass(ScriptableRenderer renderer, Camera cam)
		{
		}

		private bool insightCheck(Camera cam)
		{
			return false;
		}

		private bool checkNeedDraw(Camera cam)
		{
			return false;
		}

		private void onDestroyForAtOnce()
		{
		}

		private void prepAtOnce()
		{
		}
	}
}
