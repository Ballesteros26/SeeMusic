using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
	public sealed class ReflectionProbe : Behaviour
	{
		public enum ReflectionProbeEvent
		{
			ReflectionProbeAdded = 0,
			ReflectionProbeRemoved = 1
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Cubemap> defaultReflectionSet;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Texture> defaultReflectionTexture;

		[NativeName("BoxSize")]
		public Vector3 size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public int resolution
		{
			set
			{
			}
		}

		public ReflectionProbeRefreshMode refreshMode
		{
			set
			{
			}
		}

		public ReflectionProbeTimeSlicingMode timeSlicingMode => default(ReflectionProbeTimeSlicingMode);

		[StaticAccessor("GetReflectionProbes()")]
		public static Vector4 defaultTextureHDRDecodeValues => default(Vector4);

		[StaticAccessor("GetReflectionProbes()")]
		public static Texture defaultTexture => null;

		public int RenderProbe()
		{
			return 0;
		}

		public int RenderProbe([DefaultValue("null")] RenderTexture targetTexture)
		{
			return 0;
		}

		public bool IsFinishedRendering(int renderId)
		{
			return false;
		}

		private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture)
		{
			return 0;
		}

		[RequiredByNativeCode]
		private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent)
		{
		}

		[RequiredByNativeCode]
		private static void CallSetDefaultReflection(Texture defaultReflectionCubemap)
		{
		}

		[SpecialName]
		private void get_size_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		[SpecialName]
		private void set_size_Injected(ref Vector3 value)
		{
		}

		[SpecialName]
		private static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret)
		{
			ret = default(Vector4);
		}
	}
}
