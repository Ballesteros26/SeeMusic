using UnityEngine;

namespace CodeStage.AntiCheat.Examples
{
	[AddComponentMenu(null)]
	internal class InfiniteRotator : MonoBehaviour
	{
		[Range(1f, 100f)]
		public float speed;

		private void Update()
		{
		}
	}
}
