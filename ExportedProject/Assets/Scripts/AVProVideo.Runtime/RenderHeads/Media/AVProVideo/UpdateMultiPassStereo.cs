using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	[AddComponentMenu("AVPro Video/Update Multi-Pass Stereo", 320)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class UpdateMultiPassStereo : MonoBehaviour
	{
		[Header("Stereo camera")]
		[SerializeField]
		private Camera _camera;

		private static readonly LazyShaderProperty PropWorldCameraPosition;

		private static readonly LazyShaderProperty PropWorldCameraRight;

		private Camera _foundCamera;

		public Camera Camera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void LogXRDeviceDetails()
		{
		}

		private static bool IsMultiPassVrEnabled()
		{
			return false;
		}

		private void LateUpdate()
		{
		}
	}
}
