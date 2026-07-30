using System;
using System.Runtime.InteropServices;
using System.Text;
using VideoKit.Devices;

namespace VideoKit.Internal
{
	public static class VideoKit
	{
		public enum AssetType
		{
			Unknown = 0,
			Image = 1,
			Audio = 2,
			Video = 3
		}

		[Flags]
		public enum DeviceFlags
		{
			Internal = 1,
			External = 2,
			Default = 8,
			EchoCancellation = 4,
			FrontFacing = 0x40,
			Flash = 0x80,
			Torch = 0x100,
			Depth = 0x8000,
			ExposureContinuous = 0x10000,
			ExposureLock = 0x800,
			ExposureManual = 0x4000,
			ExposurePoint = 0x200,
			FocusContinuous = 0x20000,
			FocusLock = 0x1000,
			FocusPoint = 0x400,
			WhiteBalanceContinuous = 0x40000,
			WhiteBalanceLock = 0x2000,
			VideoStabilization = 0x80000
		}

		public enum Metadata
		{
			IntrinsicMatrix = 1,
			ExposureBias = 2,
			ExposureDuration = 3,
			FocalLength = 4,
			FNumber = 5,
			Brightness = 6,
			ISO = 7
		}

		public enum PermissionType
		{
			Microphone = 1,
			Camera = 2
		}

		public enum Status
		{
			Ok = 0,
			InvalidArgument = 1,
			InvalidOperation = 2,
			NotImplemented = 3,
			InvalidSession = 101,
			InvalidPlan = 104,
			LimitedPlan = 105
		}

		public delegate void RecordingHandler(IntPtr context, IntPtr path);

		public delegate void DeviceDiscoveryHandler(IntPtr context, IntPtr devices, int count);

		public delegate void SampleBufferHandler(IntPtr context, IntPtr sampleBuffer);

		public delegate void DeviceDisconnectHandler(IntPtr context);

		public delegate void PermissionResultHandler(IntPtr context, MediaDevice.PermissionStatus result);

		public delegate void AssetLoadHandler(IntPtr context, IntPtr path, AssetType type, int width, int height, float frameRate, int sampleRate, int channelCount, float duration);

		public delegate void AssetShareHandler(IntPtr context, IntPtr receiver);

		public const string Assembly = "VideoKit";

		public static bool IsAppDomainLoaded => false;

		[PreserveSig]
		public static extern Status BundleIdentifier(StringBuilder dest);

		[PreserveSig]
		public static extern Status SessionStatus();

		[PreserveSig]
		public static extern Status SetSessionToken(string? token);

		[PreserveSig]
		public static extern Status LoadAsset(string path, AssetLoadHandler handler, IntPtr context);

		[PreserveSig]
		public static extern Status LoadAssetFromCameraRoll(AssetType type, AssetLoadHandler handler, IntPtr context);

		[PreserveSig]
		public static extern Status ShareAsset(string path, string message, AssetShareHandler handler, IntPtr context);

		[PreserveSig]
		public static extern Status SaveAssetToCameraRoll(string path, string album, AssetShareHandler handler, IntPtr context);

		[PreserveSig]
		public static extern Status GetHighResolutionTimestamp(out long timestamp);

		[PreserveSig]
		public static extern Status FrameSize(this IntPtr recorder, out int width, out int height);

		[PreserveSig]
		public unsafe static extern Status CommitFrame(this IntPtr recorder, void* pixelBuffer, long timestamp);

		[PreserveSig]
		public unsafe static extern Status CommitSamples(this IntPtr recorder, float* sampleBuffer, int sampleCount, long timestamp);

		[PreserveSig]
		public static extern Status FinishWriting(this IntPtr recorder, RecordingHandler handler, IntPtr context);

		[PreserveSig]
		public static extern Status CreateMP4Recorder(string path, int width, int height, float frameRate, int sampleRate, int channelCount, int videoBitrate, int keyframeInterval, int audioBitRate, out IntPtr recorder);

		[PreserveSig]
		public static extern Status CreateHEVCRecorder(string path, int width, int height, float frameRate, int sampleRate, int channelCount, int videoBitRate, int keyframeInterval, int audioBitRate, out IntPtr recorder);

		[PreserveSig]
		public static extern Status CreateGIFRecorder(string path, int width, int height, float delay, out IntPtr recorder);

		[PreserveSig]
		public static extern Status CreateWAVRecorder(string path, int sampleRate, int channelCount, out IntPtr recorder);

		[PreserveSig]
		public static extern Status CreateWEBMRecorder(string path, int width, int height, float frameRate, int sampleRate, int channelCount, int videoBitRate, int keyframeInterval, int audioBitRate, out IntPtr recorder);

		[PreserveSig]
		public static extern Status CreateJPEGRecorder(string path, int width, int height, float quality, out IntPtr recorder);

		[PreserveSig]
		public static extern Status ReleaseDevice(this IntPtr device);

		[PreserveSig]
		public static extern Status UniqueID(this IntPtr device, StringBuilder dest);

		[PreserveSig]
		public static extern Status Name(this IntPtr device, StringBuilder dest);

		[PreserveSig]
		public static extern DeviceFlags Flags(this IntPtr device);

		[PreserveSig]
		public static extern bool Running(this IntPtr device);

		[PreserveSig]
		public static extern Status StartRunning(this IntPtr device, SampleBufferHandler callback, IntPtr context);

		[PreserveSig]
		public static extern Status StopRunning(this IntPtr device);

		[PreserveSig]
		public static extern Status SetDisconnectHandler(this IntPtr device, DeviceDisconnectHandler handler, IntPtr context);

		[PreserveSig]
		public static extern Status CheckPermissions(PermissionType type, bool request, PermissionResultHandler handler, IntPtr context);

		[PreserveSig]
		public static extern Status DiscoverMicrophones(DeviceDiscoveryHandler handler, IntPtr context);

		[PreserveSig]
		public static extern bool EchoCancellation(this IntPtr microphone);

		[PreserveSig]
		public static extern void SetEchoCancellation(this IntPtr microphone, bool mode);

		[PreserveSig]
		public static extern int SampleRate(this IntPtr microphone);

		[PreserveSig]
		public static extern void SetSampleRate(this IntPtr microphone, int sampleRate);

		[PreserveSig]
		public static extern int ChannelCount(this IntPtr microphone);

		[PreserveSig]
		public static extern void SetChannelCount(this IntPtr microphone, int sampleRate);

		[PreserveSig]
		public unsafe static extern float* AudioBufferData(this IntPtr audioBuffer);

		[PreserveSig]
		public static extern int AudioBufferSampleCount(this IntPtr audioBuffer);

		[PreserveSig]
		public static extern int AudioBufferSampleRate(this IntPtr audioBuffer);

		[PreserveSig]
		public static extern int AudioBufferChannelCount(this IntPtr audioBuffer);

		[PreserveSig]
		public static extern long AudioBufferTimestamp(this IntPtr audioBuffer);

		[PreserveSig]
		public static extern Status DiscoverCameras(DeviceDiscoveryHandler handler, IntPtr context);

		[PreserveSig]
		public static extern void FieldOfView(this IntPtr camera, out float x, out float y);

		[PreserveSig]
		public static extern void ExposureBiasRange(this IntPtr camera, out float min, out float max);

		[PreserveSig]
		public static extern void ExposureDurationRange(this IntPtr camera, out float min, out float max);

		[PreserveSig]
		public static extern void ISORange(this IntPtr device, out float min, out float max);

		[PreserveSig]
		public static extern void ZoomRange(this IntPtr camera, out float min, out float max);

		[PreserveSig]
		public static extern void PreviewResolution(this IntPtr camera, out int width, out int height);

		[PreserveSig]
		public static extern void SetPreviewResolution(this IntPtr camera, int width, int height);

		[PreserveSig]
		public static extern void PhotoResolution(this IntPtr camera, out int width, out int height);

		[PreserveSig]
		public static extern void SetPhotoResolution(this IntPtr camera, int width, int height);

		[PreserveSig]
		public static extern int FrameRate(this IntPtr camera);

		[PreserveSig]
		public static extern void SetFrameRate(this IntPtr camera, int framerate);

		[PreserveSig]
		public static extern CameraDevice.ExposureMode ExposureMode(this IntPtr camera);

		[PreserveSig]
		public static extern void SetExposureMode(this IntPtr camera, CameraDevice.ExposureMode mode);

		[PreserveSig]
		public static extern float ExposureBias(this IntPtr camera);

		[PreserveSig]
		public static extern void SetExposureBias(this IntPtr camera, float bias);

		[PreserveSig]
		public static extern float ExposureDuration(this IntPtr camera);

		[PreserveSig]
		public static extern float ISO(this IntPtr camera);

		[PreserveSig]
		public static extern void SetExposureDuration(this IntPtr camera, float duration, float ISO);

		[PreserveSig]
		public static extern void SetExposurePoint(this IntPtr camera, float x, float y);

		[PreserveSig]
		public static extern CameraDevice.FlashMode FlashMode(this IntPtr camera);

		[PreserveSig]
		public static extern void SetFlashMode(this IntPtr camera, CameraDevice.FlashMode mode);

		[PreserveSig]
		public static extern CameraDevice.FocusMode FocusMode(this IntPtr camera);

		[PreserveSig]
		public static extern void SetFocusMode(this IntPtr camera, CameraDevice.FocusMode mode);

		[PreserveSig]
		public static extern void SetFocusPoint(this IntPtr camera, float x, float y);

		[PreserveSig]
		public static extern CameraDevice.TorchMode TorchMode(this IntPtr camera);

		[PreserveSig]
		public static extern void SetTorchMode(this IntPtr camera, CameraDevice.TorchMode mode);

		[PreserveSig]
		public static extern CameraDevice.WhiteBalanceMode WhiteBalanceMode(this IntPtr camera);

		[PreserveSig]
		public static extern void SetWhiteBalanceMode(this IntPtr camera, CameraDevice.WhiteBalanceMode mode);

		[PreserveSig]
		public static extern CameraDevice.VideoStabilizationMode VideoStabilizationMode(this IntPtr camera);

		[PreserveSig]
		public static extern void SetVideoStabilizationMode(this IntPtr camera, CameraDevice.VideoStabilizationMode mode);

		[PreserveSig]
		public static extern float ZoomRatio(this IntPtr camera);

		[PreserveSig]
		public static extern void SetZoomRatio(this IntPtr camera, float ratio);

		[PreserveSig]
		public static extern void CapturePhoto(this IntPtr camera, SampleBufferHandler handler, IntPtr context);

		[PreserveSig]
		public unsafe static extern void* CameraImageData(this IntPtr image);

		[PreserveSig]
		public static extern int CameraImageDataSize(this IntPtr image);

		[PreserveSig]
		public static extern CameraImage.Format CameraImageFormat(this IntPtr image);

		[PreserveSig]
		public static extern int CameraImageWidth(this IntPtr image);

		[PreserveSig]
		public static extern int CameraImageHeight(this IntPtr image);

		[PreserveSig]
		public static extern int CameraImageRowStride(this IntPtr image);

		[PreserveSig]
		public static extern long CameraImageTimestamp(this IntPtr image);

		[PreserveSig]
		public static extern bool CameraImageVerticallyMirrored(this IntPtr image);

		[PreserveSig]
		public static extern int CameraImagePlaneCount(this IntPtr image);

		[PreserveSig]
		public unsafe static extern void* CameraImagePlaneData(this IntPtr image, int planeIdx);

		[PreserveSig]
		public static extern int CameraImagePlaneDataSize(this IntPtr image, int planeIdx);

		[PreserveSig]
		public static extern int CameraImagePlaneWidth(this IntPtr image, int planeIdx);

		[PreserveSig]
		public static extern int CameraImagePlaneHeight(this IntPtr image, int planeIdx);

		[PreserveSig]
		public static extern int CameraImagePlanePixelStride(this IntPtr image, int planeIdx);

		[PreserveSig]
		public static extern int CameraImagePlaneRowStride(this IntPtr image, int planeIdx);

		[PreserveSig]
		public unsafe static extern bool CameraImageMetadata(this IntPtr image, Metadata key, float* value, int count = 1);

		[PreserveSig]
		public unsafe static extern void ConvertToRGBA8888(this IntPtr image, int orientation, bool mirror, void* tempBuffer, void* dstBuffer, out int dstWidth, out int dstHeight);

		public static void CheckStatus(this Status status)
		{
		}
	}
}
