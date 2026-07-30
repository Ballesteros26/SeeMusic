using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[NativeHeader("Runtime/Shaders/Shader.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Camera/RenderManager.h")]
	public sealed class Camera : Behaviour
	{
		public enum StereoscopicEye
		{
			Left = 0,
			Right = 1
		}

		public enum MonoOrStereoscopicEye
		{
			Left = 0,
			Right = 1,
			Mono = 2
		}

		public enum SceneViewFilterMode
		{
			Off = 0,
			ShowFiltered = 1
		}

		public enum RenderRequestMode
		{
			None = 0,
			ObjectId = 1,
			Depth = 2,
			VertexNormal = 3,
			WorldPosition = 4,
			EntityId = 5,
			BaseColor = 6,
			SpecularColor = 7,
			Metallic = 8,
			Emission = 9,
			Normal = 10,
			Smoothness = 11,
			Occlusion = 12,
			DiffuseColor = 13
		}

		public enum RenderRequestOutputSpace
		{
			ScreenSpace = -1,
			UV0 = 0,
			UV1 = 1,
			UV2 = 2,
			UV3 = 3,
			UV4 = 4,
			UV5 = 5,
			UV6 = 6,
			UV7 = 7,
			UV8 = 8
		}

		public struct RenderRequest
		{
			private readonly RenderRequestMode m_CameraRenderMode;

			private readonly RenderTexture m_ResultRT;

			private readonly RenderRequestOutputSpace m_OutputSpace;
		}

		public delegate void CameraCallback(Camera cam);

		public static CameraCallback onPreCull;

		public static CameraCallback onPreRender;

		public static CameraCallback onPostRender;

		[NativeProperty("Near")]
		public float nearClipPlane
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("Far")]
		public float farClipPlane
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("VerticalFieldOfView")]
		public float fieldOfView
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public RenderingPath renderingPath
		{
			get
			{
				return default(RenderingPath);
			}
			set
			{
			}
		}

		public RenderingPath actualRenderingPath
		{
			[NativeName("CalculateRenderingPath")]
			get
			{
				return default(RenderingPath);
			}
		}

		public bool allowHDR
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool allowMSAA
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool allowDynamicResolution => false;

		public float orthographicSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool orthographic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public OpaqueSortMode opaqueSortMode => default(OpaqueSortMode);

		public float depth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float aspect
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int cullingMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int eventMask => 0;

		public CameraType cameraType
		{
			get
			{
				return default(CameraType);
			}
			set
			{
			}
		}

		public bool useOcclusionCulling
		{
			set
			{
			}
		}

		public Color backgroundColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public CameraClearFlags clearFlags
		{
			get
			{
				return default(CameraClearFlags);
			}
			set
			{
			}
		}

		public DepthTextureMode depthTextureMode
		{
			get
			{
				return default(DepthTextureMode);
			}
			set
			{
			}
		}

		public bool usePhysicalProperties => false;

		[NativeProperty("NormalizedViewportRect")]
		public Rect rect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		[NativeProperty("ScreenViewportRect")]
		public Rect pixelRect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public int pixelWidth
		{
			[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = true)]
			get
			{
				return 0;
			}
		}

		public int pixelHeight
		{
			[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = true)]
			get
			{
				return 0;
			}
		}

		public RenderTexture targetTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int targetDisplay => 0;

		public Matrix4x4 cameraToWorldMatrix => default(Matrix4x4);

		public Matrix4x4 worldToCameraMatrix
		{
			get
			{
				return default(Matrix4x4);
			}
			set
			{
			}
		}

		public Matrix4x4 projectionMatrix
		{
			get
			{
				return default(Matrix4x4);
			}
			set
			{
			}
		}

		public static Camera main
		{
			[FreeFunction("FindMainCamera")]
			get
			{
				return null;
			}
		}

		public static Camera current
		{
			[FreeFunction("GetCurrentCameraPPtr")]
			get
			{
				return null;
			}
		}

		public bool stereoEnabled
		{
			[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
			get
			{
				return false;
			}
		}

		public float stereoSeparation
		{
			set
			{
			}
		}

		public StereoTargetEyeMask stereoTargetEye => default(StereoTargetEyeMask);

		public static int allCamerasCount => 0;

		public static Camera[] allCameras => null;

		[NativeConditional("UNITY_EDITOR")]
		public SceneViewFilterMode sceneViewFilterMode => default(SceneViewFilterMode);

		public void ResetWorldToCameraMatrix()
		{
		}

		public void ResetProjectionMatrix()
		{
		}

		public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		public Vector3 WorldToScreenPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 WorldToViewportPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 ViewportToWorldPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 ScreenToWorldPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 ScreenToViewportPoint(Vector3 position)
		{
			return default(Vector3);
		}

		private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye)
		{
			return default(Ray);
		}

		public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye)
		{
			return default(Ray);
		}

		public Ray ScreenPointToRay(Vector3 pos)
		{
			return default(Ray);
		}

		public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix)
		{
		}

		public void ResetStereoProjectionMatrices()
		{
		}

		public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix)
		{
		}

		public void ResetStereoViewMatrices()
		{
		}

		[FreeFunction("CameraScripting::GetAllCamerasCount")]
		private static int GetAllCamerasCount()
		{
			return 0;
		}

		[FreeFunction("CameraScripting::GetAllCameras")]
		private static int GetAllCamerasImpl([Out][NotNull("ArgumentNullException")] Camera[] cam)
		{
			return 0;
		}

		public static int GetAllCameras(Camera[] cameras)
		{
			return 0;
		}

		[FreeFunction("CameraScripting::RenderToCubemap", HasExplicitThis = true)]
		private bool RenderToCubemapImpl(Texture tex, [DefaultValue("63")] int faceMask)
		{
			return false;
		}

		public bool RenderToCubemap(RenderTexture cubemap, int faceMask)
		{
			return false;
		}

		[NativeConditional("UNITY_EDITOR")]
		private int GetFilterMode()
		{
			return 0;
		}

		[NativeName("RenderToCubemap")]
		private bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye)
		{
			return false;
		}

		public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye)
		{
			return false;
		}

		[FreeFunction("CameraScripting::Render", HasExplicitThis = true)]
		public void Render()
		{
		}

		[FreeFunction("CameraScripting::SetupCurrent")]
		public static void SetupCurrent(Camera cur)
		{
		}

		[RequiredByNativeCode]
		private static void FireOnPreCull(Camera cam)
		{
		}

		[RequiredByNativeCode]
		private static void FireOnPreRender(Camera cam)
		{
		}

		[RequiredByNativeCode]
		private static void FireOnPostRender(Camera cam)
		{
		}

		public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters)
		{
			cullingParameters = default(ScriptableCullingParameters);
			return false;
		}

		[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
		[FreeFunction("ScriptableRenderPipeline_Bindings::GetCullingParameters_Internal")]
		private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize)
		{
			cullingParameters = default(ScriptableCullingParameters);
			return false;
		}

		[SpecialName]
		private void get_backgroundColor_Injected(out Color ret)
		{
			ret = default(Color);
		}

		[SpecialName]
		private void set_backgroundColor_Injected(ref Color value)
		{
		}

		[SpecialName]
		private void get_rect_Injected(out Rect ret)
		{
			ret = default(Rect);
		}

		[SpecialName]
		private void set_rect_Injected(ref Rect value)
		{
		}

		[SpecialName]
		private void get_pixelRect_Injected(out Rect ret)
		{
			ret = default(Rect);
		}

		[SpecialName]
		private void set_pixelRect_Injected(ref Rect value)
		{
		}

		[SpecialName]
		private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		[SpecialName]
		private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		[SpecialName]
		private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value)
		{
		}

		[SpecialName]
		private void get_projectionMatrix_Injected(out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		[SpecialName]
		private void set_projectionMatrix_Injected(ref Matrix4x4 value)
		{
		}

		private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void WorldToViewportPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void ViewportToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void ScreenToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret)
		{
			ret = default(Ray);
		}

		private void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix)
		{
		}

		private void SetStereoViewMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix)
		{
		}
	}
}
