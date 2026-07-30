using System;
using System.Runtime.InteropServices;
using System.Text;
using NatML.API.Types;

namespace NatML.Internal
{
	public static class NatML
	{
		public delegate void ModelCreationHandler(IntPtr context, IntPtr model);

		public delegate void SecretCreationHandler(IntPtr context, IntPtr secret);

		public const string Version = "1.1.16";

		public const string Assembly = "NatML";

		[PreserveSig]
		public static extern void CreateModelConfiguration(out IntPtr configuration);

		[PreserveSig]
		public static extern void ReleaseModelConfiguration(this IntPtr configuration);

		[PreserveSig]
		public static extern void SetComputeTarget(this IntPtr configuration, MLEdgeModel.ComputeTarget target);

		[PreserveSig]
		public static extern void SetComputeDevice(this IntPtr configuration, IntPtr device);

		[PreserveSig]
		public static extern void SetFingerprint(this IntPtr configuration, string fingerprint);

		[PreserveSig]
		public static extern void SetSecret(this IntPtr configuration, string secret);

		[PreserveSig]
		public static extern void CreateSecret(SecretCreationHandler handler, IntPtr context);

		[PreserveSig]
		public static extern void CreateModel(byte[] buffer, long bufferSize, IntPtr options, ModelCreationHandler handler, IntPtr context);

		[PreserveSig]
		public static extern void ReleaseModel(this IntPtr model);

		[PreserveSig]
		public static extern int MetadataCount(this IntPtr model);

		[PreserveSig]
		public static extern void MetadataKey(this IntPtr model, int index, StringBuilder dest, int size);

		[PreserveSig]
		public static extern void MetadataValue(this IntPtr model, string key, StringBuilder dest, int size);

		[PreserveSig]
		public static extern int InputFeatureCount(this IntPtr model);

		[PreserveSig]
		public static extern void InputFeatureType(this IntPtr model, int index, out IntPtr type);

		[PreserveSig]
		public static extern int OutputFeatureCount(this IntPtr model);

		[PreserveSig]
		public static extern void OutputFeatureType(this IntPtr model, int index, out IntPtr type);

		[PreserveSig]
		public static extern void Predict(this IntPtr model, [In] IntPtr[] inputs, [Out] IntPtr[] outputs);

		[PreserveSig]
		public static extern void ReleaseFeature(this IntPtr feature);

		[PreserveSig]
		public static extern void FeatureType(this IntPtr feature, out IntPtr type);

		[PreserveSig]
		public static extern IntPtr FeatureData(this IntPtr feature);

		[PreserveSig]
		public unsafe static extern void CreateFeature(void* data, [In] int[] shape, int dims, Dtype type, int flags, out IntPtr feature);

		[PreserveSig]
		public unsafe static extern void CreateFeature(void* pixelBuffer, int width, int height, [In] int[] shape, Dtype type, float* mean, float* std, int flags, out IntPtr feature);

		[PreserveSig]
		public unsafe static extern void CreateFeature(float* sampleBuffer, int bufferSampleRate, [In] int[] bufferShape, int sampleRate, int channelCount, Dtype type, [In] float[] mean, [In] float[] std, int flags, out IntPtr feature);

		[PreserveSig]
		public unsafe static extern void CopyTo(void* srcBuffer, int width, int height, int* rect, float rotation, byte* background, void* dstBuffer);

		[PreserveSig]
		public static extern void ReleaseFeatureType(this IntPtr type);

		[PreserveSig]
		public static extern void FeatureTypeName(this IntPtr type, StringBuilder dest, int size);

		[PreserveSig]
		public static extern Dtype FeatureTypeDataType(this IntPtr type);

		[PreserveSig]
		public static extern int FeatureTypeDimensions(this IntPtr type);

		[PreserveSig]
		public static extern void FeatureTypeShape(this IntPtr type, [Out] int[] shape, int length);

		[PreserveSig]
		public static extern void GetVideoFormat(string path, out int width, out int height, out int frames);

		[PreserveSig]
		public static extern void GetAudioFormat(string path, out int sampleRate, out int channelCount, out int sampleCount);

		[PreserveSig]
		public static extern void ReleaseFeatureReader(this IntPtr reader);

		[PreserveSig]
		public static extern void ReadNextFeature(this IntPtr reader, out long timestamp, out IntPtr feature);

		[PreserveSig]
		public static extern void CreateImageFeatureReader(string path, out IntPtr reader);

		[PreserveSig]
		public static extern void CreateAudioFeatureReader(string path, out IntPtr reader);
	}
}
