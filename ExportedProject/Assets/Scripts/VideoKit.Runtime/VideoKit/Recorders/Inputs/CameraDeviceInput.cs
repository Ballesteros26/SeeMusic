using System;
using VideoKit.Recorders.Clocks;

namespace VideoKit.Recorders.Inputs
{
	public sealed class CameraDeviceInput : IDisposable
	{
		public int frameSkip;

		private readonly TextureInput input;

		private readonly IClock clock;

		private readonly VideoKitCameraManager cameraManager;

		private int frameIdx;

		public CameraDeviceInput(MediaRecorder recorder, IClock clock, VideoKitCameraManager cameraManager)
		{
		}

		public CameraDeviceInput(MediaRecorder recorder, VideoKitCameraManager cameraManager)
		{
		}

		public CameraDeviceInput(TextureInput input, IClock clock, VideoKitCameraManager cameraManager)
		{
		}

		public CameraDeviceInput(TextureInput input, VideoKitCameraManager cameraManager)
		{
		}

		public void Dispose()
		{
		}

		private void OnCameraFrame()
		{
		}
	}
}
