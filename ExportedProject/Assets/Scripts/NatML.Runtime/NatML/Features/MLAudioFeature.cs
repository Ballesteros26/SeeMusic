using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NatML.Types;
using Unity.Collections;
using UnityEngine;

namespace NatML.Features
{
	public sealed class MLAudioFeature : MLFeature, IMLEdgeFeature, IMLCloudFeature, IEnumerable<(MLAudioFeature, long)>, IEnumerable
	{
		public int sampleRate;

		public int channelCount;

		public float mean;

		public float std;

		private readonly float[] sampleBuffer;

		private unsafe readonly float* nativeBuffer;

		private readonly string path;

		public MLAudioFeature(AudioClip clip, float duration = -1f)
			: base(null)
		{
		}

		public MLAudioFeature(float[] sampleBuffer, int sampleRate, int channelCount)
			: base(null)
		{
		}

		public MLAudioFeature(NativeArray<float> sampleBuffer, int sampleRate, int channelCount)
			: base(null)
		{
		}

		public unsafe MLAudioFeature(float* sampleBuffer, int sampleRate, int channelCount, int sampleCount)
			: base(null)
		{
		}

		public MLAudioFeature(IEnumerable<float[]> bufferList, int sampleRate, int channelCount)
			: base(null)
		{
		}

		public MLAudioFeature(string path)
			: base(null)
		{
		}

		public MLAudioFeature Contiguous()
		{
			return null;
		}

		public void CopyTo(float[] sampleBuffer)
		{
		}

		public void CopyTo(NativeArray<float> sampleBuffer)
		{
		}

		public unsafe void CopyTo(float* sampleBuffer)
		{
		}

		public AudioClip ToAudioClip()
		{
			return null;
		}

		public ref float GetPinnableReference()
		{
			throw null;
		}

		MLEdgeFeature IMLEdgeFeature.Create(MLFeatureType type)
		{
			return default(MLEdgeFeature);
		}

		MLCloudFeature IMLCloudFeature.Create(MLFeatureType _)
		{
			return default(MLCloudFeature);
		}

		[IteratorStateMachine(typeof(_003CSystem_002DCollections_002DGeneric_002DIEnumerable_003C_0028NatML_002DFeatures_002DMLAudioFeaturefeature_005C_002CSystem_002DInt64timestamp_0029_003E_002DGetEnumerator_003Ed__21))]
		IEnumerator<(MLAudioFeature, long)> IEnumerable<(MLAudioFeature, long)>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private static float[] Extract(AudioClip clip, float duration = -1f)
		{
			return null;
		}

		private static float[] Flatten(IEnumerable<float[]> bufferList)
		{
			return null;
		}

		private static MLAudioFeature CreateAudioFeature(IntPtr feature, MLAudioType audioType)
		{
			return null;
		}
	}
}
