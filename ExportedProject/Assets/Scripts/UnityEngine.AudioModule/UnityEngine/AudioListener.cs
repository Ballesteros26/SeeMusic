using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[StaticAccessor("AudioListenerBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioListener : AudioBehaviour
	{
		public static float volume
		{
			set
			{
			}
		}

		public AudioVelocityUpdateMode velocityUpdateMode
		{
			set
			{
			}
		}

		[NativeThrows]
		private static void GetOutputDataHelper([Out] float[] samples, int channel)
		{
		}

		[NativeThrows]
		private static void GetSpectrumDataHelper([Out] float[] samples, int channel, FFTWindow window)
		{
		}

		public static void GetOutputData(float[] samples, int channel)
		{
		}

		public static void GetSpectrumData(float[] samples, int channel, FFTWindow window)
		{
		}
	}
}
