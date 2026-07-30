using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	public class SupportedRenderingFeatures
	{
		[Flags]
		public enum ReflectionProbeModes
		{
			None = 0,
			Rotation = 1
		}

		[Flags]
		public enum LightmapMixedBakeModes
		{
			None = 0,
			IndirectOnly = 1,
			Subtractive = 2,
			Shadowmask = 4
		}

		private static SupportedRenderingFeatures s_Active;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ReflectionProbeModes _003CreflectionProbeModes_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003ClightProbeProxyVolumes_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CmotionVectors_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CreceiveShadows_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CreflectionProbes_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CreflectionProbesBlendDistance_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CrendererPriority_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CoverridesEnvironmentLighting_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CoverridesFog_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CoverridesRealtimeReflectionProbes_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CoverridesOtherLightingSettings_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CeditableMaterialRenderQueue_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CoverridesLODBias_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CoverridesMaximumLODLevel_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CrendererProbes_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CparticleSystemInstancing_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CoverridesShadowmask_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _003CoverrideShadowmaskMessage_003Ek__BackingField;

		public static SupportedRenderingFeatures active
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LightmapMixedBakeModes defaultMixedLightingModes { get; }

		public LightmapMixedBakeModes mixedLightingModes { get; }

		public LightmapBakeType lightmapBakeTypes { get; }

		public LightmapsMode lightmapsModes { get; }

		public bool enlightenLightmapper { get; }

		public bool enlighten { get; }

		public bool motionVectors
		{
			[CompilerGenerated]
			set
			{
				_003CmotionVectors_003Ek__BackingField = value;
			}
		}

		public bool rendersUIOverlay { get; }

		public bool autoAmbientProbeBaking { get; }

		public bool autoDefaultReflectionProbeBaking { get; }

		[RequiredByNativeCode]
		internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr)
		{
		}

		internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr)
		{
		}

		internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr)
		{
		}
	}
}
