using UnityEngine;

namespace MakeIt.Core
{
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("MakeIt/Render Target File Saver")]
	public class RenderTargetFileSaver : MonoBehaviour
	{
		public string filename;

		private Camera _camera;

		protected void Start()
		{
		}

		protected void OnPostRender()
		{
		}
	}
}
