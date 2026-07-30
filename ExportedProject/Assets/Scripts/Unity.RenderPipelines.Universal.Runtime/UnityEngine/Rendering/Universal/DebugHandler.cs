using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.Rendering.Universal
{
	internal class DebugHandler : IDebugDisplaySettingsQuery
	{
		private class DebugRenderPassEnumerable : IEnumerable<DebugRenderSetup>, IEnumerable
		{
			private class Enumerator : IEnumerator<DebugRenderSetup>, IEnumerator, IDisposable
			{
				private readonly DebugHandler m_DebugHandler;

				private readonly ScriptableRenderContext m_Context;

				private readonly CommandBuffer m_CommandBuffer;

				private readonly int m_NumIterations;

				private int m_Index;

				public DebugRenderSetup Current { get; private set; }

				object IEnumerator.Current => null;

				public Enumerator(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer)
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Reset()
				{
				}

				public void Dispose()
				{
				}
			}

			private readonly DebugHandler m_DebugHandler;

			private readonly ScriptableRenderContext m_Context;

			private readonly CommandBuffer m_CommandBuffer;

			public DebugRenderPassEnumerable(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer)
			{
			}

			public IEnumerator<DebugRenderSetup> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal delegate void DrawFunction(ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock);

		private static readonly int k_DebugColorInvalidModePropertyId;

		private static readonly int k_DebugColorPropertyId;

		private static readonly int k_DebugTexturePropertyId;

		private static readonly int k_DebugTextureNoStereoPropertyId;

		private static readonly int k_DebugTextureDisplayRect;

		private static readonly int k_DebugRenderTargetSupportsStereo;

		private static readonly int k_DebugMaterialModeId;

		private static readonly int k_DebugVertexAttributeModeId;

		private static readonly int k_DebugMaterialValidationModeId;

		private static readonly int k_DebugMipInfoModeId;

		private static readonly int k_DebugSceneOverrideModeId;

		private static readonly int k_DebugFullScreenModeId;

		private static readonly int k_DebugValidationModeId;

		private static readonly int k_DebugValidateBelowMinThresholdColorPropertyId;

		private static readonly int k_DebugValidateAboveMaxThresholdColorPropertyId;

		private static readonly int k_DebugLightingModeId;

		private static readonly int k_DebugLightingFeatureFlagsId;

		private static readonly int k_DebugValidateAlbedoMinLuminanceId;

		private static readonly int k_DebugValidateAlbedoMaxLuminanceId;

		private static readonly int k_DebugValidateAlbedoSaturationToleranceId;

		private static readonly int k_DebugValidateAlbedoHueToleranceId;

		private static readonly int k_DebugValidateAlbedoCompareColorId;

		private static readonly int k_DebugValidateMetallicMinValueId;

		private static readonly int k_DebugValidateMetallicMaxValueId;

		private static readonly int k_ValidationChannelsId;

		private static readonly int k_RangeMinimumId;

		private static readonly int k_RangeMaximumId;

		private readonly Material m_ReplacementMaterial;

		private bool m_HasDebugRenderTarget;

		private bool m_DebugRenderTargetSupportsStereo;

		private Vector4 m_DebugRenderTargetPixelRect;

		private RenderTargetIdentifier m_DebugRenderTargetIdentifier;

		private readonly DebugDisplaySettings m_DebugDisplaySettings;

		private DebugDisplaySettingsLighting LightingSettings => null;

		private DebugDisplaySettingsMaterial MaterialSettings => null;

		private DebugDisplaySettingsRendering RenderingSettings => null;

		public bool AreAnySettingsActive => false;

		public bool IsPostProcessingAllowed => false;

		public bool IsLightingActive => false;

		internal bool IsActiveModeUnsupportedForDeferred => false;

		internal Material ReplacementMaterial => null;

		internal DebugDisplaySettings DebugDisplaySettings => null;

		internal bool IsScreenClearNeeded => false;

		internal bool IsRenderPassSupported => false;

		public bool TryGetScreenClearColor(ref Color color)
		{
			return false;
		}

		internal DebugHandler(ScriptableRendererData scriptableRendererData)
		{
		}

		public void Dispose()
		{
		}

		internal bool IsActiveForCamera(ref CameraData cameraData)
		{
			return false;
		}

		internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode)
		{
			debugFullScreenMode = default(DebugFullScreenMode);
			return false;
		}

		internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode, out int textureHeightPercent)
		{
			debugFullScreenMode = default(DebugFullScreenMode);
			textureHeightPercent = default(int);
			return false;
		}

		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		internal void SetupShaderProperties(CommandBuffer cmd, int passIndex = 0)
		{
		}

		internal void SetDebugRenderTarget(RenderTargetIdentifier renderTargetIdentifier, Rect displayRect, bool supportsStereo)
		{
		}

		internal void ResetDebugRenderTarget()
		{
		}

		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		internal void UpdateShaderGlobalPropertiesForFinalValidationPass(CommandBuffer cmd, ref CameraData cameraData, bool isFinalPass)
		{
		}

		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		internal void Setup(ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		internal IEnumerable<DebugRenderSetup> CreateDebugRenderSetupEnumerable(ScriptableRenderContext context, CommandBuffer commandBuffer)
		{
			return null;
		}

		internal void DrawWithDebugRenderState(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, DrawFunction func)
		{
		}
	}
}
