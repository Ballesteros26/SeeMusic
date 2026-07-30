using System;
using System.Collections.Generic;
using MH.WaterCausticsModules.TexGen;
using UnityEngine;
using UnityEngine.Serialization;

namespace MH.WaterCausticsModules
{
	[AddComponentMenu("WaterCausticsModules/WaterCausticsTexGenerator")]
	[HelpURL("https://hacoapp.com/asset/wce/v2/ManualPDF.pdf")]
	[ExecuteAlways]
	public class WaterCausticsTexGenerator : MonoBehaviour
	{
		private class pID
		{
			internal static readonly int _WaveCnt;

			internal static readonly int _WaveData;

			internal static readonly int _WaveUVShift;

			internal static readonly int _WaveNoiseDir;

			internal static readonly int _CalcResUI;

			internal static readonly int _CalcTexel;

			internal static readonly int _CalcTexelInv;

			internal static readonly int _LightDir;

			internal static readonly int _Eta;

			internal static readonly int _Brightness;

			internal static readonly int _Gamma;

			internal static readonly int _Clamp;

			internal static readonly int _IdxStride;

			internal static readonly int _DrawOffset;

			internal static readonly int _BufNoiseRW;

			internal static readonly int _BufNoise;

			internal static readonly int _BufRefractRW;

			internal static readonly int _BufRefract;

			internal static readonly int _LightDirection;

			internal static readonly int _Offset;

			internal static readonly int _OffsetColor;

			internal static readonly int _SSLinearTex;
		}

		private class kID
		{
			internal static int NoiseCS;

			internal static int RefractCS;

			internal static int ColorCS;

			internal static void setKernelID(ComputeShader cs)
			{
			}
		}

		[Serializable]
		public class Wave
		{
			[SerializeField]
			[FormerlySerializedAs("Active")]
			private bool m_active;

			[Range(1f, 20f)]
			[SerializeField]
			private float m_density;

			[SerializeField]
			[Range(0f, 1f)]
			private float m_height;

			[SerializeField]
			[Range(0f, 4f)]
			private float m_fluctuation;

			[Range(0f, 1.5f)]
			[SerializeField]
			private float m_flow;

			[Range(-180f, 180f)]
			[SerializeField]
			private float m_direction;

			[SerializeField]
			[HideInInspector]
			private bool Pause;

			[HideInInspector]
			[SerializeField]
			private float m_flowU;

			[SerializeField]
			[HideInInspector]
			private float m_flowV;

			[NonSerialized]
			internal Vector3 pos;

			public bool active
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public float density
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float height
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float fluctuation
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float flow
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float direction
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public Wave(float density, float height, float fluct, float flow, float dir)
			{
			}

			internal Vector3 getData(float adjustDensity, float adjustHeight, int idx)
			{
				return default(Vector3);
			}

			internal void renewFlowData(float scale)
			{
			}
		}

		private const int THREAD_SIZE = 16;

		internal const int WAVE_MAX_CNT = 4;

		private readonly string[] _lcStyleStr;

		private readonly float[] _lcStyleBright;

		private readonly float[] _lcStyleGamma;

		[SerializeField]
		private bool m_generateInEditMode;

		[SerializeField]
		private bool m_animateInEditMode;

		[SerializeField]
		private bool m_pause;

		[Range(0.1f, 3f)]
		[SerializeField]
		private float m_density;

		[Range(0f, 4f)]
		[SerializeField]
		private float m_height;

		[Range(0f, 4f)]
		[SerializeField]
		private float m_speed;

		[SerializeField]
		[Range(0f, 1.5f)]
		private float m_flow;

		[Range(-180f, 180f)]
		[SerializeField]
		private float m_flowDirection;

		[SerializeField]
		private List<Wave> m_waves;

		[SerializeField]
		private CalcRes m_calcResolution;

		[SerializeField]
		private RenderTexture m_renderTexture;

		[SerializeField]
		[FormerlySerializedAs("m_FillGapAmount")]
		[Range(0f, 0.5f)]
		private float m_FillGap;

		[SerializeField]
		[FormerlySerializedAs("m_lightDirectionType")]
		private LightRay m_lightRay;

		[SerializeField]
		private Transform m_lightTransform;

		[SerializeField]
		[FormerlySerializedAs("m_lightDir")]
		private Vector3 m_lightVector;

		[Range(-180f, 180f)]
		[SerializeField]
		private float m_lightDirection;

		[Range(0f, 90f)]
		[SerializeField]
		private float m_lightIncidentAngle;

		[SerializeField]
		[FormerlySerializedAs("m_lightCondensingStyle")]
		private int m_version;

		[SerializeField]
		private Style m_style;

		[FormerlySerializedAs("m_rayStyle")]
		[SerializeField]
		private RefractedRay m_refractedRay;

		[Range(0f, 3f)]
		[SerializeField]
		private float m_brightness;

		[Range(0.0001f, 2f)]
		[SerializeField]
		private float m_gamma;

		[Range(0f, 3f)]
		[SerializeField]
		private float m_clamp;

		[SerializeField]
		[Range(1f, 3f)]
		private float m_refractionIndex;

		[SerializeField]
		private bool m_useChromaticAberration;

		[Range(0f, 0.3f)]
		[SerializeField]
		private float m_chromaticAberration;

		[SerializeField]
		private bool m_usePostProcessing;

		[SerializeField]
		private bool m_useBlur;

		[SerializeField]
		[Range(1f, 20f)]
		private int m_blurIterations;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_blurSpread;

		[SerializeField]
		private MSAASamples m_msaa;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_blurDirectional;

		[Range(-180f, 180f)]
		[SerializeField]
		private float m_blurDirection;

		[SerializeField]
		[Range(0f, 3f)]
		private float m_colorShift;

		[SerializeField]
		[Range(-180f, 180f)]
		private float m_colorShiftDir;

		[SerializeField]
		private bool m_useSyncDirection;

		[Range(0f, 2f)]
		[SerializeField]
		private float m_postBrightness;

		[SerializeField]
		[Range(0.0001f, 2f)]
		private float m_postContrast;

		[SerializeField]
		private ComputeShader m_computeShader;

		[SerializeField]
		private Shader m_shader;

		[NonSerialized]
		public bool ManualUpdate;

		private ComputeShader __computeShader;

		private Material __mat;

		private Mesh __mesh;

		private int _meshVertsCnt;

		private GraphicsBuffer _bufNoise;

		private GraphicsBuffer _bufRefract;

		private static readonly Dictionary<RenderTexture, WaterCausticsTexGenerator> s_drawer;

		private readonly Vector4[] _tmpDataAry;

		private readonly Vector4[] _tmpUVAry;

		private readonly Vector4[] _tmpDirAry;

		private const float NOISE_RADIUS = 100f;

		private const float NOISE_CIRCUMFERENCE_INV = 1f / (200f * (float)Math.PI);

		private int _sysMaxMSAA;

		private bool useChromAbe => false;

		private int bufSize3or1 => 0;

		public bool generateInEditMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool animateInEditMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool pause
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float density
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float height
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float speed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float flow
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float flowDirection
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public List<Wave> waves => null;

		public CalcRes calculateResolution
		{
			get
			{
				return default(CalcRes);
			}
			set
			{
			}
		}

		public RenderTexture renderTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float fillGapAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public LightRay lightRayType
		{
			get
			{
				return default(LightRay);
			}
			set
			{
			}
		}

		public Transform lightTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 lightVector
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float lightDirection
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float lightIncidentAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Style style
		{
			get
			{
				return default(Style);
			}
			set
			{
			}
		}

		public RefractedRay refractedRayProcessing
		{
			get
			{
				return default(RefractedRay);
			}
			set
			{
			}
		}

		public float brightness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float gamma
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float clamp
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float refractionIndex
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useChromaticAberration
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float chromaticAberration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool usePostProcessing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useBlur
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int blurIterations
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float blurSpread
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public MSAASamples msaa
		{
			get
			{
				return default(MSAASamples);
			}
			set
			{
			}
		}

		public float blurDirectional
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float blurDirection
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

		public bool useSyncDirection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float postContrast
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float postBrightness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void syncDir(ref float prop, float dir)
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

		private void destroyAllBuffers()
		{
		}

		private void destroy<T>(ref T o) where T : UnityEngine.Object
		{
		}

		private ComputeShader getComputeShader()
		{
			return null;
		}

		private Material getMat()
		{
			return null;
		}

		private void setMaterialKeyword(Material mat, bool isEnable, string keyword)
		{
		}

		private int calcVerticesCnt(int res)
		{
			return 0;
		}

		private Mesh getMesh()
		{
			return null;
		}

		private void setupMesh()
		{
		}

		private void prepGraphicsBuffers()
		{
		}

		private void checkAndRemakeCBuffer(ref GraphicsBuffer buf, int count, int stride)
		{
		}

		private void releaseGraphicsBuffers()
		{
		}

		private void release(ref GraphicsBuffer cb)
		{
		}

		private static bool isDrawer(WaterCausticsTexGenerator texGen)
		{
			return false;
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public void UpdateManual(float deltaTime)
		{
		}

		private void generate(float deltaTime, RenderTexture rt)
		{
		}

		private Vector3 refract(Vector3 I, float eta)
		{
			return default(Vector3);
		}

		private float getDecimal(float v)
		{
			return 0f;
		}

		private void setConstantBuffer(float delteTime)
		{
		}

		private void calcComputeShader()
		{
		}

		private void drawMesh(RenderTexture rt)
		{
		}

		private void storeSystemMaxMSAA()
		{
		}

		private RenderTexture getPPTmpRT(RenderTexture rt, bool useMSAA)
		{
			return null;
		}

		private void postProcessing(RenderTexture src, RenderTexture dst)
		{
		}
	}
}
