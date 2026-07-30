using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	public static class RenderPipelineManager
	{
		internal static RenderPipelineAsset s_CurrentPipelineAsset;

		private static List<Camera> s_Cameras;

		private static string s_currentPipelineType;

		private static RenderPipeline s_currentPipeline;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<ScriptableRenderContext, List<Camera>> beginContextRendering;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<ScriptableRenderContext, List<Camera>> endContextRendering;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<ScriptableRenderContext, Camera[]> beginFrameRendering;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action activeRenderPipelineTypeChanged;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action activeRenderPipelineCreated;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action activeRenderPipelineDisposed;

		public static RenderPipeline currentPipeline
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static event Action<ScriptableRenderContext, Camera> beginCameraRendering
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<ScriptableRenderContext, Camera[]> endFrameRendering
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<ScriptableRenderContext, Camera> endCameraRendering
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
		}

		internal static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		internal static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
		}

		internal static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		[RequiredByNativeCode]
		internal static void OnActiveRenderPipelineTypeChanged()
		{
		}

		[RequiredByNativeCode]
		internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset)
		{
		}

		[RequiredByNativeCode]
		internal static void CleanupRenderPipeline()
		{
		}

		[RequiredByNativeCode]
		private static string GetCurrentPipelineAssetType()
		{
			return null;
		}

		[RequiredByNativeCode]
		private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, List<Camera.RenderRequest> renderRequests)
		{
		}

		internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset)
		{
		}

		private static bool IsPipelineRequireCreation()
		{
			return false;
		}
	}
}
