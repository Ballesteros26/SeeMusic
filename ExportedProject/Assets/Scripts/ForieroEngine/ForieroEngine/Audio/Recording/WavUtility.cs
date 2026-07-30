using System.IO;
using UnityEngine;

namespace ForieroEngine.Audio.Recording
{
	public class WavUtility
	{
		private const int BlockSize_16Bit = 2;

		public static AudioClip ToAudioClip(string filePath)
		{
			return null;
		}

		public static AudioClip ToAudioClip(byte[] fileBytes, int offsetSamples = 0, string name = "wav")
		{
			return null;
		}

		private static float[] Convert8BitByteArrayToAudioClipData(byte[] source, int headerOffset, int dataSize)
		{
			return null;
		}

		private static float[] Convert16BitByteArrayToAudioClipData(byte[] source, int headerOffset, int dataSize)
		{
			return null;
		}

		private static float[] Convert24BitByteArrayToAudioClipData(byte[] source, int headerOffset, int dataSize)
		{
			return null;
		}

		private static float[] Convert32BitByteArrayToAudioClipData(byte[] source, int headerOffset, int dataSize)
		{
			return null;
		}

		public static byte[] FromAudioClip(AudioClip audioClip)
		{
			return null;
		}

		public static byte[] FromAudioClip(AudioClip audioClip, out string filepath, bool saveAsFile = true, string dirname = "recordings")
		{
			filepath = null;
			return null;
		}

		private static int WriteFileHeader(ref MemoryStream stream, int fileSize)
		{
			return 0;
		}

		private static int WriteFileFormat(ref MemoryStream stream, int channels, int sampleRate, ushort bitDepth)
		{
			return 0;
		}

		private static int WriteFileData(ref MemoryStream stream, AudioClip audioClip, ushort bitDepth)
		{
			return 0;
		}

		private static byte[] ConvertAudioClipDataToInt16ByteArray(float[] data)
		{
			return null;
		}

		private static int WriteBytesToMemoryStream(ref MemoryStream stream, byte[] bytes, string tag = "")
		{
			return 0;
		}

		public static ushort BitDepth(AudioClip audioClip)
		{
			return 0;
		}

		private static int BytesPerSample(ushort bitDepth)
		{
			return 0;
		}

		private static int BlockSize(ushort bitDepth)
		{
			return 0;
		}

		private static string FormatCode(ushort code)
		{
			return null;
		}
	}
}
