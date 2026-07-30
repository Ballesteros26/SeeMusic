using UnityEngine.Bindings;

namespace UnityEngine
{
	[StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
	public sealed class Microphone
	{
		public static string[] devices
		{
			[NativeName("GetRecordDevices")]
			get
			{
				return null;
			}
		}

		[NativeMethod(IsThreadSafe = true)]
		private static int GetMicrophoneDeviceIDFromName(string name)
		{
			return 0;
		}

		private static AudioClip StartRecord(int deviceID, bool loop, float lengthSec, int frequency)
		{
			return null;
		}

		private static void EndRecord(int deviceID)
		{
		}

		[NativeMethod(IsThreadSafe = true)]
		private static int GetRecordPosition(int deviceID)
		{
			return 0;
		}

		private static void GetDeviceCaps(int deviceID, out int minFreq, out int maxFreq)
		{
			minFreq = default(int);
			maxFreq = default(int);
		}

		public static AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency)
		{
			return null;
		}

		public static void End(string deviceName)
		{
		}

		public static int GetPosition(string deviceName)
		{
			return 0;
		}

		public static void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq)
		{
			minFreq = default(int);
			maxFreq = default(int);
		}
	}
}
