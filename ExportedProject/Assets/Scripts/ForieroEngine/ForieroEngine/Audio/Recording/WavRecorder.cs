using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace ForieroEngine.Audio.Recording
{
	public static class WavRecorder
	{
		public static void ConverAndWrite(this FileStream fileStream, float[] samples)
		{
		}

		public static void PrepareHeader(this FileStream fileStream, int headerSize = 44)
		{
		}

		public static void WriteHeader(this FileStream fileStream, int outputRate = 44100, int headerSize = 44)
		{
		}

		public static void WriteHeader(this FileStream fileStream, AudioClip clip)
		{
		}

		public static AudioClip TrimSilence(this AudioClip clip, float min)
		{
			return null;
		}

		public static AudioClip TrimSilence(List<float> samples, float min, int channels, int hz)
		{
			return null;
		}

		public static AudioClip TrimSilence(List<float> samples, float min, int channels, int hz, bool _3D, bool stream)
		{
			return null;
		}
	}
}
