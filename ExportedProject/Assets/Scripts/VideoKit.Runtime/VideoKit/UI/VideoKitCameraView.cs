using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace VideoKit.UI
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RawImage), typeof(AspectRatioFitter), typeof(EventTrigger))]
	[Tooltip("VideoKit UI component for displaying the camera preview from a camera manager.")]
	[HelpURL("https://docs.videokit.ai/videokit/api/videokitcameraview")]
	public sealed class VideoKitCameraView : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler
	{
		public enum ViewMode
		{
			CameraTexture = 0,
			HumanTexture = 1
		}

		public enum GestureMode
		{
			None = 0,
			Tap = 1,
			Pinch = 2,
			Drag = 3
		}

		[Header("Configuration")]
		[Tooltip("VideoKit camera manager.")]
		public VideoKitCameraManager cameraManager;

		[Tooltip("View mode of the view.")]
		public ViewMode viewMode;

		[Header("Gestures")]
		[Tooltip("Focus gesture mode.")]
		public GestureMode focusMode;

		[Tooltip("Exposure gesture mode.")]
		public GestureMode exposureMode;

		[Tooltip("Zoom gesture mode.")]
		public GestureMode zoomMode;

		[Tooltip("Event raised when the camera preview is presented on the UI panel.")]
		[Header("Events")]
		public UnityEvent<VideoKitCameraView> OnPresent;

		private RawImage rawImage;

		private AspectRatioFitter aspectFitter;

		private bool presented;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnCameraFrame()
		{
		}

		private void OnDisable()
		{
		}

		void IPointerUpHandler.OnPointerUp(PointerEventData data)
		{
		}

		void IBeginDragHandler.OnBeginDrag(PointerEventData data)
		{
		}

		void IDragHandler.OnDrag(PointerEventData data)
		{
		}
	}
}
