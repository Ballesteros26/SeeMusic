using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace ForieroEngine.Audio.Recording
{
	public static class SaveWav
	{
		private const int HEADER_SIZE = 44;

		public static byte[] GetWavBytes(AudioClip clip)
		{
			return null;
		}

		public static AudioClip TrimSilence(AudioClip clip, float min)
		{
			return null;
		}

		public static AudioClip TrimSilence(List<float> samples, float min, int channels, int hz)
		{
			return null;
		}

		public static AudioClip TrimSilence(List<float> samples, float min, int channels, int hz, bool stream)
		{
			return null;
		}

		private static MemoryStream CreateEmpty()
		{
			return null;
		}

		private static void ConvertAndWrite(MemoryStream memStream, AudioClip clip)
		{
		}

		private static void WriteHeader(MemoryStream memStream, AudioClip clip)
		{
		}
	}
}
